using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TSIMSServer.Controllers
{
    [RoutePrefix("api/tsims")]
    public class TSIMSController : ApiController
    {
        /// <summary>
        ///  登陆；
        ///  参数：{"user_num": "13110033140", "password": "123456"}；
        ///  返回结果：{"code": "1","data": "登陆成功"}
        /// </summary>
        /// <param name="user">学生信息（学号和密码）</param>
        /// <returns>返回登陆结果</returns>
        [HttpPost, Route("login")]
        public HttpResponseMessage Login(Model.User user)
        {   
            string userNo = user.user_num;
            string password = user.password;

            BLL.t_user BLL_User = new BLL.t_user();
            List<Model.t_user> userList = BLL_User.GetModelList("user_num=" + "'" + userNo + "'" + "and password=" + "'" + password + "'");
            if (userList.Count > 0)
            {
                BLL.t_time_set TTSBLL = new BLL.t_time_set();
                Model.t_time_set TTSModel = TTSBLL.GetModel(1);
                string startTime = "";
                string endTime = "";
                if (TTSModel != null)
                {
                    startTime = TTSModel.student_start.ToString().Replace('/', '-');
                    endTime = TTSModel.student_end.ToString().Replace('/','-');
                }
                
                //string json = "{\"code\":" + 1 + ", \"data\":" + "\"登陆成功\"" + "}";
                //return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
                string json = "{\"code\":" + 1 + ", \"data\":" + "\"" + startTime + "," + endTime +  "\"" + "}";
                return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            }
            else
            {
                string json = "{\"code\":" + 0 + ", \"data\":" + "\"登陆失败\"" + "}";
                return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            }
            
        }

        /// <summary>
        ///  获取该学生对应的课程及教材信息；
        ///  参数：{"user_num":"13110033140"}； 
        ///  返回结果：
        ///  {"textBookInfo": [
        ///  {
        ///    "courseName": "Java 程序设计基础",
        ///    "needBook": "1",
        ///    "isbn":"9787111506904",
        ///    "bookName": "Java语言程序设计（基础篇）",
        ///    "price": "85"
        ///   },
        ///  {
        ///    "courseName": "桌面应用程序开发技术",
        ///    "needBook": "1",
        ///    "isbn":"9787115297617",
        ///    "bookName": "C#面向对象程序设计(第2版)",
        ///    "price": "49.8"
        ///   }
        ///   ]}
        /// </summary>
        /// <param name="user_num ">学号</param>
        /// <returns>该学生对应的课程、教材信息和选订情况</returns>
        [HttpGet, Route("getTextBookInfo")]
        public HttpResponseMessage GetTextBookInfo(string user_num)
        {
            //string user_num = userNo.user_num;
            //List<Model.t_user> userList = BLL_User.GetModelList("1=1");
            if (user_num != null)
            {
                TSIMSServer.BLL.v_course_textbook_info VCTI_BLL = new BLL.v_course_textbook_info();
                string sql = "select a.course_name, a.need_book,c.isbn," +
                    "d.book_name,d.price,e.user_num from t_teaching as a " +
                    "join t_user as b on b.user_num = '" + user_num + "' and a.class_num = b.class_num left join " +
                    "t_teaching_book as c on a.id = c.teaching_id left join t_book d on d.isbn = c.isbn left join " +
                    "t_book_order as e on e.user_num = b.user_num and e.isbn = c.isbn";
                List<TSIMSServer.Model.v_course_textbook_info> VCTIList = VCTI_BLL.GetModelListByUser(sql);
                string jsonResult = "{\"code\": 1,\"data\": [";
                for (int i = 0; i < VCTIList.Count; i++)
                {
                    TSIMSServer.Model.v_course_textbook_info VCTI = VCTIList[i];
                    string json = "";
                    if (i != 0)
                    {
                        json = json + ",";
                    }
                    json = json + "{\"courseName\": \"" + VCTI.course_name;
                    json = json + "\",\"needBook\": \"" + VCTI.need_book;
                    json = json + "\",\"isbn\": \"" + VCTI.isbn;
                    json = json + "\",\"bookName\": \"" + VCTI.book_name;
                    json = json + "\",\"price\": \"" + VCTI.price;
                    if (VCTI.user_num.Equals(user_num))
                    {
                        json = json + "\",\"isSelect\": \"" + 1;
                    }
                    else
                    {
                        json = json + "\",\"isSelect\": \"" + 0;
                    }
                    json = json + "\"}";
                    jsonResult += json;
                }
                jsonResult += "]}";
                //string json = "{\"user_num\":" + user_num + "}";
                return new HttpResponseMessage { Content = new StringContent(jsonResult, System.Text.Encoding.UTF8, "application/json") };
            }
            else
            {
                string json = "{\"code\":" + 0 + ", \"data\":" + "\"获取失败\"" + "}";
                return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            }
        }

        /// <summary>
        /// 提交课程教材选订信息；
        /// 参数：
        /// {
        /// "user_num":"13110033140",
        /// "textBookInfoList": [
        ///     {
        ///         "isbn":"9787111506904",
        ///         "isSelect":"0"
        ///     },
        ///     {
        ///         "isbn":"9787115297617",
        ///         "isSelect":"1"
        ///     }
        /// ]
        /// }； 
        /// 返回结果：
        /// {
        ///     "code": "1",
        ///     "data": "提交成功"
        /// }
        /// </summary>
        /// <param name="bookOrderInfo">学号和教材选定信息</param>
        /// <returns>提交成功或失败</returns>
        [HttpPost, Route("submitBookOrderInfo")]
        public HttpResponseMessage SubmitBookOrderInfo([FromBody]Model.BookOrderInfo bookOrderInfo)
        {
            if (bookOrderInfo != null)
            {
            //    string jsonResult = "{\"code\": 1,\"data\": {";
            //    jsonResult = jsonResult + "\"user_num\": \"" + bookOrderInfo.user_num +"\",\"textBookInfoList\": [";
            //    List<Model.TextBookInfo> textBookInfo = bookOrderInfo.textBookInfoList;
            //    for (int i = 0; i < textBookInfo.Count; i++)
            //    {
            //        string json = "";
            //        if (i != 0)
            //        {
            //            json = json + ",";
            //        }
            //        json = "{\"isbn\": \"";
            //        json = json + textBookInfo[i].isbn;
            //        json = json + "\",\"isSelect\": \"" + textBookInfo[i].isSelect;
            //        json = json + "\"}";
            //        jsonResult += json;
            //    }
            //    jsonResult += "]}}";
            //    return new HttpResponseMessage { Content = new StringContent(jsonResult, System.Text.Encoding.UTF8, "application/json") };

                string user_num = bookOrderInfo.user_num;
                BLL.t_book_order bookOrder_BLL = new BLL.t_book_order();
                List<Model.TextBookInfo> textbookInfoList = bookOrderInfo.textBookInfoList;
                for (int i = 0; i < textbookInfoList.Count; i++)
                {
                    Model.TextBookInfo textBookInfo = textbookInfoList[i];
                    if (textBookInfo.isSelect == 1)
                    {
                        // 判断该选订记录是否存在
                        List<Model.t_book_order> bookOrderRecord = bookOrder_BLL.GetModelList("user_num = '" + user_num + "' and isbn = '" + textBookInfo.isbn + "'");
                        if (bookOrderRecord.Count <= 0)
                        {
                            // 添加教材订购记录
                            Model.t_book_order bookOrder = new Model.t_book_order();
                            bookOrder.isbn = textBookInfo.isbn;
                            bookOrder.user_num = user_num;
                            bookOrder_BLL.Add(bookOrder);
                        }
                    }
                    else
                    {
                        // 删除教材订购记录
                        // 判断该选订记录是否存在
                        List<Model.t_book_order> bookOrderRecord = bookOrder_BLL.GetModelList("user_num = '" + user_num + "' and isbn = '" + textBookInfo.isbn + "'");
                        if (bookOrderRecord.Count > 0)
                        {
                            // 添加教材订购记录
                            for (int j = 0; j < bookOrderRecord.Count; j++)
                            {
                                bookOrder_BLL.Delete(bookOrderRecord[j].id);
                            }
                        }
                    }
                }
                string json = "{\"code\":" + 1 + ", \"data\":" + "\"提交成功\"" + "}";
                return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            }
            else
            {
                string json = "{\"code\":" + 0 + ", \"data\":" + "\"提交失败\"" + "}";
                return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            }
        }

        /// <summary>
        /// 获取教材信息；
        /// 参数：?isbn=9787111506904
        /// 返回结果：{"code": 1,"data": [{"isbn": "9787111506904","book_name": "Java语言程序设计（基础篇）","author": "[美] 梁勇（Y.Daniel Liang） 著；Y.DanielLiang 编；戴开宇 译","price": "85.00","publisher": "机械工业出版社","edition": "原书第10版"}]}
        /// </summary>
        /// <param name="isbn">ISBN</param>
        /// <returns></returns>
        [HttpGet, Route("getBookDetail")]
        public HttpResponseMessage GetBookDetail(string isbn)
        {
            if (isbn != null)
            {
                BLL.t_book book_BLL = new BLL.t_book();
                List<Model.t_book> bookList = book_BLL.GetModelList("isbn = '" + isbn + "'");
                string jsonResult = "{\"code\": 1,\"data\": ";
                Model.t_book book = bookList[0];
                string json = "";
                json = json + "{\"isbn\": \"" + isbn + "\",";
                json = json + "\"book_name\": \"" + book.book_name + "\",";
                json = json + "\"author\": \""+ book.author + "\",";
                json = json + "\"price\": \"" + book.price + "\",";
                json = json + "\"publisher\": \"" + book.publisher + "\",";
                json = json + "\"edition\": \"" + book.edition + "\"";
                json += "}";
                jsonResult += json;

                jsonResult += "}";
                return new HttpResponseMessage { Content = new StringContent(jsonResult, System.Text.Encoding.UTF8, "application/json") };
            }
            else
            {
                string json = "{\"code\":" + 0 + ", \"data\":" + "\"获取失败\"" + "}";
                return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            }
        }


        /// </summary>
        /// <param name="bookOrderInfo">学号和教材选定信息</param>
        /// <returns>提交成功或失败</returns>
        [HttpPost, Route("newStuOrderBook")]
        public HttpResponseMessage NewStuOrderBook(int type)
        {
            if (type != null)
            {  
               
                string json = "{\"code\":" + 1 + ", \"data\":" + "\"提交成功\"" + "}";
                return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            }
            else
            {
                string json = "{\"code\":" + 0 + ", \"data\":" + "\"提交失败\"" + "}";
                return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
            }
        }

    }
}
