using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TSIMSServer.DAL
{
	/// <summary>
	/// 数据访问类:t_time_set
	/// </summary>
	public partial class t_time_set
	{
		public t_time_set()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "t_time_set"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_time_set");
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
		public bool Add(TSIMSServer.Model.t_time_set model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_time_set(");
			strSql.Append("dept_head_start,dept_head_end,teacher_satrt,teacher_end,student_start,student_end)");
			strSql.Append(" values (");
			strSql.Append("@dept_head_start,@dept_head_end,@teacher_satrt,@teacher_end,@student_start,@student_end)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@dept_head_start", MySqlDbType.DateTime),
					new MySqlParameter("@dept_head_end", MySqlDbType.DateTime),
					new MySqlParameter("@teacher_satrt", MySqlDbType.DateTime),
					new MySqlParameter("@teacher_end", MySqlDbType.DateTime),
					new MySqlParameter("@student_start", MySqlDbType.DateTime),
					new MySqlParameter("@student_end", MySqlDbType.DateTime)};
			parameters[0].Value = model.dept_head_start;
			parameters[1].Value = model.dept_head_end;
			parameters[2].Value = model.teacher_satrt;
			parameters[3].Value = model.teacher_end;
			parameters[4].Value = model.student_start;
			parameters[5].Value = model.student_end;

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
		public bool Update(TSIMSServer.Model.t_time_set model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_time_set set ");
			strSql.Append("dept_head_start=@dept_head_start,");
			strSql.Append("dept_head_end=@dept_head_end,");
			strSql.Append("teacher_satrt=@teacher_satrt,");
			strSql.Append("teacher_end=@teacher_end,");
			strSql.Append("student_start=@student_start,");
			strSql.Append("student_end=@student_end");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@dept_head_start", MySqlDbType.DateTime),
					new MySqlParameter("@dept_head_end", MySqlDbType.DateTime),
					new MySqlParameter("@teacher_satrt", MySqlDbType.DateTime),
					new MySqlParameter("@teacher_end", MySqlDbType.DateTime),
					new MySqlParameter("@student_start", MySqlDbType.DateTime),
					new MySqlParameter("@student_end", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.dept_head_start;
			parameters[1].Value = model.dept_head_end;
			parameters[2].Value = model.teacher_satrt;
			parameters[3].Value = model.teacher_end;
			parameters[4].Value = model.student_start;
			parameters[5].Value = model.student_end;
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
			strSql.Append("delete from t_time_set ");
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
			strSql.Append("delete from t_time_set ");
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
		public TSIMSServer.Model.t_time_set GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,dept_head_start,dept_head_end,teacher_satrt,teacher_end,student_start,student_end from t_time_set ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			TSIMSServer.Model.t_time_set model=new TSIMSServer.Model.t_time_set();
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
		public TSIMSServer.Model.t_time_set DataRowToModel(DataRow row)
		{
			TSIMSServer.Model.t_time_set model=new TSIMSServer.Model.t_time_set();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["dept_head_start"]!=null && row["dept_head_start"].ToString()!="")
				{
					model.dept_head_start=DateTime.Parse(row["dept_head_start"].ToString());
				}
				if(row["dept_head_end"]!=null && row["dept_head_end"].ToString()!="")
				{
					model.dept_head_end=DateTime.Parse(row["dept_head_end"].ToString());
				}
				if(row["teacher_satrt"]!=null && row["teacher_satrt"].ToString()!="")
				{
					model.teacher_satrt=DateTime.Parse(row["teacher_satrt"].ToString());
				}
				if(row["teacher_end"]!=null && row["teacher_end"].ToString()!="")
				{
					model.teacher_end=DateTime.Parse(row["teacher_end"].ToString());
				}
				if(row["student_start"]!=null && row["student_start"].ToString()!="")
				{
					model.student_start=DateTime.Parse(row["student_start"].ToString());
				}
				if(row["student_end"]!=null && row["student_end"].ToString()!="")
				{
					model.student_end=DateTime.Parse(row["student_end"].ToString());
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
			strSql.Append("select id,dept_head_start,dept_head_end,teacher_satrt,teacher_end,student_start,student_end ");
			strSql.Append(" FROM t_time_set ");
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
			strSql.Append("select count(1) FROM t_time_set ");
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
			strSql.Append(")AS Row, T.*  from t_time_set T ");
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
			parameters[0].Value = "t_time_set";
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

