/**  版本信息模板在安装目录下，可自行修改。
* v_student_textbook_info.cs
*
* 功 能： N/A
* 类 名： v_student_textbook_info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/9/20 19:38:56   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TSIMS.DAL
{
	/// <summary>
	/// 数据访问类:v_student_textbook_info
	/// </summary>
	public partial class v_student_textbook_info
	{
		public v_student_textbook_info()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TSIMS.Model.v_student_textbook_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into v_student_textbook_info(");
			strSql.Append("course_name,course_type,user_name,need_book,isbn,book_name,price,author,publisher,edition,remark,user_num,id)");
			strSql.Append(" values (");
			strSql.Append("@course_name,@course_type,@user_name,@need_book,@isbn,@book_name,@price,@author,@publisher,@edition,@remark,@user_num,@id)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@course_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@course_type", MySqlDbType.Int32,11),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@need_book", MySqlDbType.Int32,11),
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50),
					new MySqlParameter("@book_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@price", MySqlDbType.Decimal,10),
					new MySqlParameter("@author", MySqlDbType.VarChar,100),
					new MySqlParameter("@publisher", MySqlDbType.VarChar,100),
					new MySqlParameter("@edition", MySqlDbType.VarChar,100),
					new MySqlParameter("@remark", MySqlDbType.VarChar,100),
					new MySqlParameter("@user_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.course_name;
			parameters[1].Value = model.course_type;
			parameters[2].Value = model.user_name;
			parameters[3].Value = model.need_book;
			parameters[4].Value = model.isbn;
			parameters[5].Value = model.book_name;
			parameters[6].Value = model.price;
			parameters[7].Value = model.author;
			parameters[8].Value = model.publisher;
			parameters[9].Value = model.edition;
			parameters[10].Value = model.remark;
			parameters[11].Value = model.user_num;
			parameters[12].Value = model.id;

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
		public bool Update(TSIMS.Model.v_student_textbook_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update v_student_textbook_info set ");
			strSql.Append("course_name=@course_name,");
			strSql.Append("course_type=@course_type,");
			strSql.Append("user_name=@user_name,");
			strSql.Append("need_book=@need_book,");
			strSql.Append("isbn=@isbn,");
			strSql.Append("book_name=@book_name,");
			strSql.Append("price=@price,");
			strSql.Append("author=@author,");
			strSql.Append("publisher=@publisher,");
			strSql.Append("edition=@edition,");
			strSql.Append("remark=@remark,");
			strSql.Append("user_num=@user_num,");
			strSql.Append("id=@id");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@course_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@course_type", MySqlDbType.Int32,11),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@need_book", MySqlDbType.Int32,11),
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50),
					new MySqlParameter("@book_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@price", MySqlDbType.Decimal,10),
					new MySqlParameter("@author", MySqlDbType.VarChar,100),
					new MySqlParameter("@publisher", MySqlDbType.VarChar,100),
					new MySqlParameter("@edition", MySqlDbType.VarChar,100),
					new MySqlParameter("@remark", MySqlDbType.VarChar,100),
					new MySqlParameter("@user_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.course_name;
			parameters[1].Value = model.course_type;
			parameters[2].Value = model.user_name;
			parameters[3].Value = model.need_book;
			parameters[4].Value = model.isbn;
			parameters[5].Value = model.book_name;
			parameters[6].Value = model.price;
			parameters[7].Value = model.author;
			parameters[8].Value = model.publisher;
			parameters[9].Value = model.edition;
			parameters[10].Value = model.remark;
			parameters[11].Value = model.user_num;
			parameters[12].Value = model.id;

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
			strSql.Append("delete from v_student_textbook_info ");
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
		public TSIMS.Model.v_student_textbook_info GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select course_name,course_type,user_name,need_book,isbn,book_name,price,author,publisher,edition,remark,user_num,id from v_student_textbook_info ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			TSIMS.Model.v_student_textbook_info model=new TSIMS.Model.v_student_textbook_info();
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
		public TSIMS.Model.v_student_textbook_info DataRowToModel(DataRow row)
		{
			TSIMS.Model.v_student_textbook_info model=new TSIMS.Model.v_student_textbook_info();
			if (row != null)
			{
				if(row["course_name"]!=null)
				{
					model.course_name=row["course_name"].ToString();
				}
				if(row["course_type"]!=null && row["course_type"].ToString()!="")
				{
					model.course_type=int.Parse(row["course_type"].ToString());
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["need_book"]!=null && row["need_book"].ToString()!="")
				{
					model.need_book=int.Parse(row["need_book"].ToString());
				}
				if(row["isbn"]!=null)
				{
					model.isbn=row["isbn"].ToString();
				}
				if(row["book_name"]!=null)
				{
					model.book_name=row["book_name"].ToString();
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
				if(row["author"]!=null)
				{
					model.author=row["author"].ToString();
				}
				if(row["publisher"]!=null)
				{
					model.publisher=row["publisher"].ToString();
				}
				if(row["edition"]!=null)
				{
					model.edition=row["edition"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["user_num"]!=null)
				{
					model.user_num=row["user_num"].ToString();
				}
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
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
			strSql.Append("select course_name,course_type,user_name,need_book,isbn,book_name,price,author,publisher,edition,remark,user_num,id ");
			strSql.Append(" FROM v_student_textbook_info ");
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
			strSql.Append("select count(1) FROM v_student_textbook_info ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from v_student_textbook_info T ");
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
			parameters[0].Value = "v_student_textbook_info";
			parameters[1].Value = "";
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

