using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TSIMSServer.DAL
{
	/// <summary>
	/// 数据访问类:v_teacher_buy_book_info
	/// </summary>
	public partial class v_teacher_buy_book_info
	{
		public v_teacher_buy_book_info()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TSIMSServer.Model.v_teacher_buy_book_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into v_teacher_buy_book_info(");
			strSql.Append("college_num,college_name,department_num,department_name,major_num,major_name,class_num,class_name,semester,course_num,course_name,course_type,need_book,teacher_num,teacher_name,isbn,book_name,author,price,publisher,edition,amount)");
			strSql.Append(" values (");
			strSql.Append("@college_num,@college_name,@department_num,@department_name,@major_num,@major_name,@class_num,@class_name,@semester,@course_num,@course_name,@course_type,@need_book,@teacher_num,@teacher_name,@isbn,@book_name,@author,@price,@publisher,@edition,@amount)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@college_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@college_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@department_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@department_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@major_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@class_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@class_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@semester", MySqlDbType.VarChar,50),
					new MySqlParameter("@course_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@course_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@course_type", MySqlDbType.Int32,11),
					new MySqlParameter("@need_book", MySqlDbType.Int32,11),
					new MySqlParameter("@teacher_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@teacher_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50),
					new MySqlParameter("@book_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@author", MySqlDbType.VarChar,100),
					new MySqlParameter("@price", MySqlDbType.Decimal,10),
					new MySqlParameter("@publisher", MySqlDbType.VarChar,100),
					new MySqlParameter("@edition", MySqlDbType.VarChar,100),
					new MySqlParameter("@amount", MySqlDbType.Int32,21)};
			parameters[0].Value = model.college_num;
			parameters[1].Value = model.college_name;
			parameters[2].Value = model.department_num;
			parameters[3].Value = model.department_name;
			parameters[4].Value = model.major_num;
			parameters[5].Value = model.major_name;
			parameters[6].Value = model.class_num;
			parameters[7].Value = model.class_name;
			parameters[8].Value = model.semester;
			parameters[9].Value = model.course_num;
			parameters[10].Value = model.course_name;
			parameters[11].Value = model.course_type;
			parameters[12].Value = model.need_book;
			parameters[13].Value = model.teacher_num;
			parameters[14].Value = model.teacher_name;
			parameters[15].Value = model.isbn;
			parameters[16].Value = model.book_name;
			parameters[17].Value = model.author;
			parameters[18].Value = model.price;
			parameters[19].Value = model.publisher;
			parameters[20].Value = model.edition;
			parameters[21].Value = model.amount;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TSIMSServer.Model.v_teacher_buy_book_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update v_teacher_buy_book_info set ");
			strSql.Append("college_num=@college_num,");
			strSql.Append("college_name=@college_name,");
			strSql.Append("department_num=@department_num,");
			strSql.Append("department_name=@department_name,");
			strSql.Append("major_num=@major_num,");
			strSql.Append("major_name=@major_name,");
			strSql.Append("class_num=@class_num,");
			strSql.Append("class_name=@class_name,");
			strSql.Append("semester=@semester,");
			strSql.Append("course_num=@course_num,");
			strSql.Append("course_name=@course_name,");
			strSql.Append("course_type=@course_type,");
			strSql.Append("need_book=@need_book,");
			strSql.Append("teacher_num=@teacher_num,");
			strSql.Append("teacher_name=@teacher_name,");
			strSql.Append("isbn=@isbn,");
			strSql.Append("book_name=@book_name,");
			strSql.Append("author=@author,");
			strSql.Append("price=@price,");
			strSql.Append("publisher=@publisher,");
			strSql.Append("edition=@edition,");
			strSql.Append("amount=@amount");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@college_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@college_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@department_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@department_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@major_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@class_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@class_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@semester", MySqlDbType.VarChar,50),
					new MySqlParameter("@course_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@course_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@course_type", MySqlDbType.Int32,11),
					new MySqlParameter("@need_book", MySqlDbType.Int32,11),
					new MySqlParameter("@teacher_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@teacher_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50),
					new MySqlParameter("@book_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@author", MySqlDbType.VarChar,100),
					new MySqlParameter("@price", MySqlDbType.Decimal,10),
					new MySqlParameter("@publisher", MySqlDbType.VarChar,100),
					new MySqlParameter("@edition", MySqlDbType.VarChar,100),
					new MySqlParameter("@amount", MySqlDbType.Int32,21)};
			parameters[0].Value = model.college_num;
			parameters[1].Value = model.college_name;
			parameters[2].Value = model.department_num;
			parameters[3].Value = model.department_name;
			parameters[4].Value = model.major_num;
			parameters[5].Value = model.major_name;
			parameters[6].Value = model.class_num;
			parameters[7].Value = model.class_name;
			parameters[8].Value = model.semester;
			parameters[9].Value = model.course_num;
			parameters[10].Value = model.course_name;
			parameters[11].Value = model.course_type;
			parameters[12].Value = model.need_book;
			parameters[13].Value = model.teacher_num;
			parameters[14].Value = model.teacher_name;
			parameters[15].Value = model.isbn;
			parameters[16].Value = model.book_name;
			parameters[17].Value = model.author;
			parameters[18].Value = model.price;
			parameters[19].Value = model.publisher;
			parameters[20].Value = model.edition;
			parameters[21].Value = model.amount;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from v_teacher_buy_book_info ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TSIMSServer.Model.v_teacher_buy_book_info GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select college_num,college_name,department_num,department_name,major_num,major_name,class_num,class_name,semester,course_num,course_name,course_type,need_book,teacher_num,teacher_name,isbn,book_name,author,price,publisher,edition,amount from v_teacher_buy_book_info ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			TSIMSServer.Model.v_teacher_buy_book_info model=new TSIMSServer.Model.v_teacher_buy_book_info();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TSIMSServer.Model.v_teacher_buy_book_info DataRowToModel(DataRow row)
		{
			TSIMSServer.Model.v_teacher_buy_book_info model=new TSIMSServer.Model.v_teacher_buy_book_info();
			if (row != null)
			{
				if(row["college_num"]!=null)
				{
					model.college_num=row["college_num"].ToString();
				}
				if(row["college_name"]!=null)
				{
					model.college_name=row["college_name"].ToString();
				}
				if(row["department_num"]!=null)
				{
					model.department_num=row["department_num"].ToString();
				}
				if(row["department_name"]!=null)
				{
					model.department_name=row["department_name"].ToString();
				}
				if(row["major_num"]!=null)
				{
					model.major_num=row["major_num"].ToString();
				}
				if(row["major_name"]!=null)
				{
					model.major_name=row["major_name"].ToString();
				}
				if(row["class_num"]!=null)
				{
					model.class_num=row["class_num"].ToString();
				}
				if(row["class_name"]!=null)
				{
					model.class_name=row["class_name"].ToString();
				}
				if(row["semester"]!=null)
				{
					model.semester=row["semester"].ToString();
				}
				if(row["course_num"]!=null)
				{
					model.course_num=row["course_num"].ToString();
				}
				if(row["course_name"]!=null)
				{
					model.course_name=row["course_name"].ToString();
				}
				if(row["course_type"]!=null && row["course_type"].ToString()!="")
				{
					model.course_type=int.Parse(row["course_type"].ToString());
				}
				if(row["need_book"]!=null && row["need_book"].ToString()!="")
				{
					model.need_book=int.Parse(row["need_book"].ToString());
				}
				if(row["teacher_num"]!=null)
				{
					model.teacher_num=row["teacher_num"].ToString();
				}
				if(row["teacher_name"]!=null)
				{
					model.teacher_name=row["teacher_name"].ToString();
				}
				if(row["isbn"]!=null)
				{
					model.isbn=row["isbn"].ToString();
				}
				if(row["book_name"]!=null)
				{
					model.book_name=row["book_name"].ToString();
				}
				if(row["author"]!=null)
				{
					model.author=row["author"].ToString();
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
				if(row["publisher"]!=null)
				{
					model.publisher=row["publisher"].ToString();
				}
				if(row["edition"]!=null)
				{
					model.edition=row["edition"].ToString();
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=long.Parse(row["amount"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select college_num,college_name,department_num,department_name,major_num,major_name,class_num,class_name,semester,course_num,course_name,course_type,need_book,teacher_num,teacher_name,isbn,book_name,author,price,publisher,edition,amount ");
			strSql.Append(" FROM v_teacher_buy_book_info ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM v_teacher_buy_book_info ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.user_num desc");
			}
			strSql.Append(")AS Row, T.*  from v_teacher_buy_book_info T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "v_teacher_buy_book_info";
			parameters[1].Value = "user_num";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

