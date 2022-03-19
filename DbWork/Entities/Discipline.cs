using System;

namespace AVLabWeb.DbWork.Entities
{
	public class Discipline
	{
		/// <summary>
		/// Код предмета.
		/// </summary>
		public int DisciplineId { get; set; }

		/// <summary>
		/// Название предмета.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Описание предмета.
		/// </summary>
		public string Description { get; set; }
	}
}