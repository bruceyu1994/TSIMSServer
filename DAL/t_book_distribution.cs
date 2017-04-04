using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TSIMSServer.DAL
{
	/// <summary>
	/// 数据访问类:t_book_distribution
	/// </summary>
	public partial class t_book_distribution
	{
		public t_book_distribution()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "t_book_distribution"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_book_distribution");
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
		public bool Add(TSIMSServer.Model.t_book_distribution model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_book_distribution(");
			strSql.Append("unit_num,unit_type,book_num,count,total_fee,paid_fee,user_num,receive_date)");
			strSql.Append(" values (");
			strSql.Append("@unit_num,@unit_type,@book_num,@count,@total_fee,@paid_fee,@user_num,@receive_date)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@unit_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@unit_type", MySqlDbType.Int32,11),
					new MySqlParameter("@book_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@count", MySqlDbType.Int32,11),
					new MySqlParameter("@total_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@paid_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@user_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@receive_date", MySqlDbType.DateTime)};
			parameters[0].Value = model.unit_num;
			parameters[1].Value = model.unit_type;
			parameters[2].Value = model.book_num;
			parameters[3].Value = model.count;
			parameters[4].Value = model.total_fee;
			parameters[5].Value = model.paid_fee;
			parameters[6].Value = model.user_num;
			parameters[7].Value = model.receive_date;

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
		public bool Update(TSIMSServer.Model.t_book_distribution model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_book_distribution set ");
			strSql.Append("unit_num=@unit_num,");
			strSql.Append("unit_type=@unit_type,");
			strSql.Append("book_num=@book_num,");
			strSql.Append("count=@count,");
			strSql.Append("total_fee=@total_fee,");
			strSql.Append("paid_fee=@paid_fee,");
			strSql.Append("user_num=@user_num,");
			strSql.Append("receive_date=@receive_date");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@unit_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@unit_type", MySqlDbType.Int32,11),
					new MySqlParameter("@book_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@count", MySqlDbType.Int32,11),
					new MySqlParameter("@total_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@paid_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@user_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@receive_date", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.unit_num;
			parameters[1].Value = model.unit_type;
			parameters[2].Value = model.book_num;
			parameters[3].Value = model.count;
			parameters[4].Value = model.total_fee;
			parameters[5].Value = model.paid_fee;
			parameters[6].Value = model.user_num;
			parameters[7].Value = model.receive_date;
			parameters[8].Value = model.id;

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
			strSql.Append("delete from t_book_distribution ");
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
			strSql.Append("delete from t_book_distribution ");
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
		public TSIMSServer.Model.t_book_distribution GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,unit_num,unit_type,book_num,count,total_fee,paid_fee,user_num,receive_date from t_book_distribution ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			TSIMSServer.Model.t_book_distribution model=new TSIMSServer.Model.t_book_distribution();
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
		public TSIMSServer.Model.t_book_distribution DataRowToModel(DataRow row)
		{
			TSIMSServer.Model.t_book_distribution model=new TSIMSServer.Model.t_book_distribution();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["unit_num"]!=null)
				{
					model.unit_num=row["unit_num"].ToString();
				}
				if(row["unit_type"]!=null && row["unit_type"].ToString()!="")
				{
					model.unit_type=int.Parse(row["unit_type"].ToString());
				}
				if(row["book_num"]!=null)
				{
					model.book_num=row["book_num"].ToString();
				}
				if(row["count"]!=null && row["count"].ToString()!="")
				{
					model.count=int.Parse(row["count"].ToString());
				}
				if(row["total_fee"]!=null && row["total_fee"].ToString()!="")
				{
					model.total_fee=decimal.Parse(row["total_fee"].ToString());
				}
				if(row["paid_fee"]!=null && row["paid_fee"].ToString()!="")
				{
					model.paid_fee=decimal.Parse(row["paid_fee"].ToString());
				}
				if(row["user_num"]!=null)
				{
					model.user_num=row["user_num"].ToString();
				}
				if(row["receive_date"]!=null && row["receive_date"].ToString()!="")
				{
					model.receive_date=DateTime.Parse(row["receive_date"].ToString());
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
			strSql.Append("select id,unit_num,unit_type,book_num,count,total_fee,paid_fee,user_num,receive_date ");
			strSql.Append(" FROM t_book_distribution ");
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
			strSql.Append("select count(1) FROM t_book_distribution ");
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
			strSql.Append(")AS Row, T.*  from t_book_distribution T ");
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
			parameters[0].Value = "t_book_distribution";
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

