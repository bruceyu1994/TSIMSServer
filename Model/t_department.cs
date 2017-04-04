using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_department:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_department
	{
		public t_department()
		{}
		#region Model
		private string _department_num;
		private string _department_name;
		private string _college_num;
		/// <summary>
		/// 
		/// </summary>
		public string department_num
		{
			set{ _department_num=value;}
			get{return _department_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string department_name
		{
			set{ _department_name=value;}
			get{return _department_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string college_num
		{
			set{ _college_num=value;}
			get{return _college_num;}
		}
		#endregion Model

	}
}

