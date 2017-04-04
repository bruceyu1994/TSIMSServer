using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TSIMSServer.DAL
{
	/// <summary>
	/// 数据访问类:t_teaching_book
	/// </summary>
	public partial class t_teaching_book
	{
		public t_teaching_book()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "t_teaching_book"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_teaching_book");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TSIMSServer.Model.t_teaching_book model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_teaching_book(");
			strSql.Append("teaching_id,isbn,remark,book_status,dept_check,college_check)");
			strSql.Append(" values (");
			strSql.Append("@teaching_id,@isbn,@remark,@book_status,@dept_check,@college_check)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@teaching_id", MySqlDbType.Int32,11),
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50),
					new MySqlParameter("@remark", MySqlDbType.VarChar,100),
					new MySqlParameter("@book_status", MySqlDbType.Int32,11),
					new MySqlParameter("@dept_check", MySqlDbType.Int32,11),
					new MySqlParameter("@college_check", MySqlDbType.Int32,11)};
			parameters[0].Value = model.teaching_id;
			parameters[1].Value = model.isbn;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.book_status;
			parameters[4].Value = model.dept_check;
			parameters[5].Value = model.college_check;

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
		public bool Update(TSIMSServer.Model.t_teaching_book model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_teaching_book set ");
			strSql.Append("teaching_id=@teaching_id,");
			strSql.Append("isbn=@isbn,");
			strSql.Append("remark=@remark,");
			strSql.Append("book_status=@book_status,");
			strSql.Append("dept_check=@dept_check,");
			strSql.Append("college_check=@college_check");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@teaching_id", MySqlDbType.Int32,11),
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50),
					new MySqlParameter("@remark", MySqlDbType.VarChar,100),
					new MySqlParameter("@book_status", MySqlDbType.Int32,11),
					new MySqlParameter("@dept_check", MySqlDbType.Int32,11),
					new MySqlParameter("@college_check", MySqlDbType.Int32,11),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.teaching_id;
			parameters[1].Value = model.isbn;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.book_status;
			parameters[4].Value = model.dept_check;
			parameters[5].Value = model.college_check;
			parameters[6].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_teaching_book ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_teaching_book ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public TSIMSServer.Model.t_teaching_book GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,teaching_id,isbn,remark,book_status,dept_check,college_check from t_teaching_book ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			TSIMSServer.Model.t_teaching_book model=new TSIMSServer.Model.t_teaching_book();
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
		public TSIMSServer.Model.t_teaching_book DataRowToModel(DataRow row)
		{
			TSIMSServer.Model.t_teaching_book model=new TSIMSServer.Model.t_teaching_book();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["teaching_id"]!=null && row["teaching_id"].ToString()!="")
				{
					model.teaching_id=int.Parse(row["teaching_id"].ToString());
				}
				if(row["isbn"]!=null)
				{
					model.isbn=row["isbn"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["book_status"]!=null && row["book_status"].ToString()!="")
				{
					model.book_status=int.Parse(row["book_status"].ToString());
				}
				if(row["dept_check"]!=null && row["dept_check"].ToString()!="")
				{
					model.dept_check=int.Parse(row["dept_check"].ToString());
				}
				if(row["college_check"]!=null && row["college_check"].ToString()!="")
				{
					model.college_check=int.Parse(row["college_check"].ToString());
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
			strSql.Append("select id,teaching_id,isbn,remark,book_status,dept_check,college_check ");
			strSql.Append(" FROM t_teaching_book ");
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
			strSql.Append("select count(1) FROM t_teaching_book ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from t_teaching_book T ");
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
			parameters[0].Value = "t_teaching_book";
			parameters[1].Value = "id";
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

