using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TSIMSServer.DAL
{
	/// <summary>
	/// 数据访问类:t_teaching
	/// </summary>
	public partial class t_teaching
	{
		public t_teaching()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "t_teaching"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_teaching");
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
		public bool Add(TSIMSServer.Model.t_teaching model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_teaching(");
			strSql.Append("semester,course_num,course_name,course_type,need_book,college_num,department_num,major_num,class_num,user_num)");
			strSql.Append(" values (");
			strSql.Append("@semester,@course_num,@course_name,@course_type,@need_book,@college_num,@department_num,@major_num,@class_num,@user_num)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@semester", MySqlDbType.VarChar,50),
					new MySqlParameter("@course_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@course_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@course_type", MySqlDbType.Int32,11),
					new MySqlParameter("@need_book", MySqlDbType.Int32,11),
					new MySqlParameter("@college_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@department_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@class_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@user_num", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.semester;
			parameters[1].Value = model.course_num;
			parameters[2].Value = model.course_name;
			parameters[3].Value = model.course_type;
			parameters[4].Value = model.need_book;
			parameters[5].Value = model.college_num;
			parameters[6].Value = model.department_num;
			parameters[7].Value = model.major_num;
			parameters[8].Value = model.class_num;
			parameters[9].Value = model.user_num;

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
		public bool Update(TSIMSServer.Model.t_teaching model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_teaching set ");
			strSql.Append("semester=@semester,");
			strSql.Append("course_num=@course_num,");
			strSql.Append("course_name=@course_name,");
			strSql.Append("course_type=@course_type,");
			strSql.Append("need_book=@need_book,");
			strSql.Append("college_num=@college_num,");
			strSql.Append("department_num=@department_num,");
			strSql.Append("major_num=@major_num,");
			strSql.Append("class_num=@class_num,");
			strSql.Append("user_num=@user_num");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@semester", MySqlDbType.VarChar,50),
					new MySqlParameter("@course_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@course_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@course_type", MySqlDbType.Int32,11),
					new MySqlParameter("@need_book", MySqlDbType.Int32,11),
					new MySqlParameter("@college_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@department_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@major_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@class_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@user_num", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.semester;
			parameters[1].Value = model.course_num;
			parameters[2].Value = model.course_name;
			parameters[3].Value = model.course_type;
			parameters[4].Value = model.need_book;
			parameters[5].Value = model.college_num;
			parameters[6].Value = model.department_num;
			parameters[7].Value = model.major_num;
			parameters[8].Value = model.class_num;
			parameters[9].Value = model.user_num;
			parameters[10].Value = model.id;

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
			strSql.Append("delete from t_teaching ");
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
			strSql.Append("delete from t_teaching ");
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
		public TSIMSServer.Model.t_teaching GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,semester,course_num,course_name,course_type,need_book,college_num,department_num,major_num,class_num,user_num from t_teaching ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			TSIMSServer.Model.t_teaching model=new TSIMSServer.Model.t_teaching();
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
		public TSIMSServer.Model.t_teaching DataRowToModel(DataRow row)
		{
			TSIMSServer.Model.t_teaching model=new TSIMSServer.Model.t_teaching();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
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
				if(row["college_num"]!=null)
				{
					model.college_num=row["college_num"].ToString();
				}
				if(row["department_num"]!=null)
				{
					model.department_num=row["department_num"].ToString();
				}
				if(row["major_num"]!=null)
				{
					model.major_num=row["major_num"].ToString();
				}
				if(row["class_num"]!=null)
				{
					model.class_num=row["class_num"].ToString();
				}
				if(row["user_num"]!=null)
				{
					model.user_num=row["user_num"].ToString();
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
			strSql.Append("select id,semester,course_num,course_name,course_type,need_book,college_num,department_num,major_num,class_num,user_num ");
			strSql.Append(" FROM t_teaching ");
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
			strSql.Append("select count(1) FROM t_teaching ");
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
			strSql.Append(")AS Row, T.*  from t_teaching T ");
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
			parameters[0].Value = "t_teaching";
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

