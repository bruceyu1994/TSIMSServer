using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using TSIMSServer.Model;
namespace TSIMSServer.BLL
{
	/// <summary>
	/// t_book
	/// </summary>
	public partial class t_book
	{
		private readonly TSIMSServer.DAL.t_book dal=new TSIMSServer.DAL.t_book();
		public t_book()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string isbn)
		{
			return dal.Exists(isbn);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TSIMSServer.Model.t_book model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TSIMSServer.Model.t_book model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string isbn)
		{
			
			return dal.Delete(isbn);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string isbnlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(isbnlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TSIMSServer.Model.t_book GetModel(string isbn)
		{
			
			return dal.GetModel(isbn);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public TSIMSServer.Model.t_book GetModelByCache(string isbn)
		{
			
			string CacheKey = "t_bookModel-" + isbn;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(isbn);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSIMSServer.Model.t_book)objModel;
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
		public List<TSIMSServer.Model.t_book> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TSIMSServer.Model.t_book> DataTableToList(DataTable dt)
		{
			List<TSIMSServer.Model.t_book> modelList = new List<TSIMSServer.Model.t_book>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSIMSServer.Model.t_book model;
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

