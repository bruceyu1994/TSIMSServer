using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_college:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_college
	{
		public t_college()
		{}
		#region Model
		private string _college_num;
		private string _college_name;
		/// <summary>
		/// 
		/// </summary>
		public string college_num
		{
			set{ _college_num=value;}
			get{return _college_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string college_name
		{
			set{ _college_name=value;}
			get{return _college_name;}
		}
		#endregion Model

	}
}

