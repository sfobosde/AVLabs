using System;

namespace AVLabWeb.DbWork.Entities
{
	public class Mark
	{
		/// <summary>
		/// Id студента.
		/// </summary>
		public int StudentId { get; set; }

		/// <summary>
		/// Дата экзамена.
		/// </summary>
		public DateTime ExamDate { get; set; }

		/// <summary>
		/// Id предмета.
		/// </summary>
		public int DisciplineId { get; set; }

		/// <summary>
		/// Оценка за экзамен.
		/// </summary>
		public int MarkValue { get; set; }
	}
}