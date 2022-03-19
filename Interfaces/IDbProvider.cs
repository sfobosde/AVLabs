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

		/// <summary>
		/// Получить данные о сданых экзаменах студента.
		/// </summary>
		/// <param name="StudentId"> Id студента. </param>
		/// <returns> Список экзаменов. </returns>
		List<Mark> GetStudentExams(int StudentId);
	}
}
