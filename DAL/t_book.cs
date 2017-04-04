using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TSIMSServer.DAL
{
	/// <summary>
	/// 数据访问类:t_book
	/// </summary>
	public partial class t_book
	{
		public t_book()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string isbn)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_book");
			strSql.Append(" where isbn=@isbn ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50)			};
			parameters[0].Value = isbn;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TSIMSServer.Model.t_book model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_book(");
			strSql.Append("isbn,book_name,author,price,publisher,edition)");
			strSql.Append(" values (");
			strSql.Append("@isbn,@book_name,@author,@price,@publisher,@edition)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50),
					new MySqlParameter("@book_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@author", MySqlDbType.VarChar,100),
					new MySqlParameter("@price", MySqlDbType.Decimal,10),
					new MySqlParameter("@publisher", MySqlDbType.VarChar,100),
					new MySqlParameter("@edition", MySqlDbType.VarChar,100)};
			parameters[0].Value = model.isbn;
			parameters[1].Value = model.book_name;
			parameters[2].Value = model.author;
			parameters[3].Value = model.price;
			parameters[4].Value = model.publisher;
			parameters[5].Value = model.edition;

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
		public bool Update(TSIMSServer.Model.t_book model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_book set ");
			strSql.Append("book_name=@book_name,");
			strSql.Append("author=@author,");
			strSql.Append("price=@price,");
			strSql.Append("publisher=@publisher,");
			strSql.Append("edition=@edition");
			strSql.Append(" where isbn=@isbn ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@book_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@author", MySqlDbType.VarChar,100),
					new MySqlParameter("@price", MySqlDbType.Decimal,10),
					new MySqlParameter("@publisher", MySqlDbType.VarChar,100),
					new MySqlParameter("@edition", MySqlDbType.VarChar,100),
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.book_name;
			parameters[1].Value = model.author;
			parameters[2].Value = model.price;
			parameters[3].Value = model.publisher;
			parameters[4].Value = model.edition;
			parameters[5].Value = model.isbn;

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
		public bool Delete(string isbn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_book ");
			strSql.Append(" where isbn=@isbn ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50)			};
			parameters[0].Value = isbn;

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
		public bool DeleteList(string isbnlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_book ");
			strSql.Append(" where isbn in ("+isbnlist + ")  ");
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
		public TSIMSServer.Model.t_book GetModel(string isbn)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select isbn,book_name,author,price,publisher,edition from t_book ");
			strSql.Append(" where isbn=@isbn ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@isbn", MySqlDbType.VarChar,50)			};
			parameters[0].Value = isbn;

			TSIMSServer.Model.t_book model=new TSIMSServer.Model.t_book();
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
		public TSIMSServer.Model.t_book DataRowToModel(DataRow row)
		{
			TSIMSServer.Model.t_book model=new TSIMSServer.Model.t_book();
			if (row != null)
			{
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select isbn,book_name,author,price,publisher,edition ");
			strSql.Append(" FROM t_book ");
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
			strSql.Append("select count(1) FROM t_book ");
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
				strSql.Append("order by T.isbn desc");
			}
			strSql.Append(")AS Row, T.*  from t_book T ");
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
			parameters[0].Value = "t_book";
			parameters[1].Value = "isbn";
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

