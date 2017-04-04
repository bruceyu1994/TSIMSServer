using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_major:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_major
	{
		public t_major()
		{}
		#region Model
		private string _major_num;
		private string _major_name;
		private string _department_num;
		/// <summary>
		/// 
		/// </summary>
		public string major_num
		{
			set{ _major_num=value;}
			get{return _major_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string major_name
		{
			set{ _major_name=value;}
			get{return _major_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string department_num
		{
			set{ _department_num=value;}
			get{return _department_num;}
		}
		#endregion Model

	}
}

