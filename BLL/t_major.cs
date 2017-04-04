using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TSIMSServer.Model;
namespace TSIMSServer.BLL
{
	/// <summary>
	/// t_major
	/// </summary>
	public partial class t_major
	{
		private readonly TSIMSServer.DAL.t_major dal=new TSIMSServer.DAL.t_major();
		public t_major()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string major_num)
		{
			return dal.Exists(major_num);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TSIMSServer.Model.t_major model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TSIMSServer.Model.t_major model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string major_num)
		{
			
			return dal.Delete(major_num);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string major_numlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(major_numlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TSIMSServer.Model.t_major GetModel(string major_num)
		{
			
			return dal.GetModel(major_num);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public TSIMSServer.Model.t_major GetModelByCache(string major_num)
		{
			
			string CacheKey = "t_majorModel-" + major_num;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(major_num);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSIMSServer.Model.t_major)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TSIMSServer.Model.t_major> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TSIMSServer.Model.t_major> DataTableToList(DataTable dt)
		{
			List<TSIMSServer.Model.t_major> modelList = new List<TSIMSServer.Model.t_major>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSIMSServer.Model.t_major model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

