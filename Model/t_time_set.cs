using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_time_set:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_time_set
	{
		public t_time_set()
		{}
		#region Model
		private int _id;
		private DateTime? _dept_head_start;
		private DateTime? _dept_head_end;
		private DateTime? _teacher_satrt;
		private DateTime? _teacher_end;
		private DateTime? _student_start;
		private DateTime? _student_end;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dept_head_start
		{
			set{ _dept_head_start=value;}
			get{return _dept_head_start;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dept_head_end
		{
			set{ _dept_head_end=value;}
			get{return _dept_head_end;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? teacher_satrt
		{
			set{ _teacher_satrt=value;}
			get{return _teacher_satrt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? teacher_end
		{
			set{ _teacher_end=value;}
			get{return _teacher_end;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? student_start
		{
			set{ _student_start=value;}
			get{return _student_start;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? student_end
		{
			set{ _student_end=value;}
			get{return _student_end;}
		}
		#endregion Model

	}
}

