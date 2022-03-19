using AVLabWeb.DbWork.Entities;
using System.Collections.Generic;

namespace AVLabWeb.Interfaces
{
	interface IDbProvider
	{
		/// <summary>
		/// Получить список студентов.
		/// </summary>
		/// <returns> Список студентов. </returns>
		List<Student> GetStudentsList();
	}
}
