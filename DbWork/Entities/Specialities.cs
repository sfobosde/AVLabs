using System;

namespace AVLabWeb.DbWork.Entities
{
	public class Specialities
	{
		/// <summary>
		/// Код специальности.
		/// </summary>
		public string SpecialityId { get; set; }

		/// <summary>
		/// Название специальности.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Описание специальности.
		/// </summary>
		public string Description { get; set; }
	}
}