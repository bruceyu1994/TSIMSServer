﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TSIMSServer.DAL
{
	/// <summary>
	/// 数据访问类:t_major
	/// </summary>
	public partial class t_major
	{
		public t_major()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string major_num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_major");
			strSql.Append(" where major_num=@major_num ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50)			};
			parameters[0].Value = major_num;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TSIMSServer.Model.t_major model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_major(");
			strSql.Append("major_num,major_name,department_num)");
			strSql.Append(" values (");
			strSql.Append("@major_num,@major_name,@department_num)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@major_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@department_num", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.major_num;
			parameters[1].Value = model.major_name;
			parameters[2].Value = model.department_num;

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
		public bool Update(TSIMSServer.Model.t_major model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_major set ");
			strSql.Append("major_name=@major_name,");
			strSql.Append("department_num=@department_num");
			strSql.Append(" where major_num=@major_num ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@major_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@department_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.major_name;
			parameters[1].Value = model.department_num;
			parameters[2].Value = model.major_num;

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
		public bool Delete(string major_num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_major ");
			strSql.Append(" where major_num=@major_num ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50)			};
			parameters[0].Value = major_num;

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
		public bool DeleteList(string major_numlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_major ");
			strSql.Append(" where major_num in ("+major_numlist + ")  ");
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
		public TSIMSServer.Model.t_major GetModel(string major_num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select major_num,major_name,department_num from t_major ");
			strSql.Append(" where major_num=@major_num ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50)			};
			parameters[0].Value = major_num;

			TSIMSServer.Model.t_major model=new TSIMSServer.Model.t_major();
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
		public TSIMSServer.Model.t_major DataRowToModel(DataRow row)
		{
			TSIMSServer.Model.t_major model=new TSIMSServer.Model.t_major();
			if (row != null)
			{
				if(row["major_num"]!=null)
				{
					model.major_num=row["major_num"].ToString();
				}
				if(row["major_name"]!=null)
				{
					model.major_name=row["major_name"].ToString();
				}
				if(row["department_num"]!=null)
				{
					model.department_num=row["department_num"].ToString();
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
			strSql.Append("select major_num,major_name,department_num ");
			strSql.Append(" FROM t_major ");
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
			strSql.Append("select count(1) FROM t_major ");
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
				strSql.Append("order by T.major_num desc");
			}
			strSql.Append(")AS Row, T.*  from t_major T ");
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
			parameters[0].Value = "t_major";
			parameters[1].Value = "major_num";
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

