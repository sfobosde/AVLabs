using AVLabWeb.DbWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace AVLabWeb.DbWork
{
	/// <summary>
	/// Объект, возвращающий выборки по запросам к базе данных через свои методы.
	/// </summary>
	public class DbProvider : DbProviderFactory
	{
		/// <summary>
		/// Получить список студентов.
		/// </summary>
		/// <returns> Список студентов. </returns>
		public override List<Student> GetStudentsList()
		{
			var sqlRequest = "SELECT * " +
				"FROM Студенты";

			try
			{
				var studentTable = GetDataSet(sqlRequest, "Студенты").Tables["Студенты"];

				var linqQuery = from student in studentTable.AsEnumerable()
								orderby student.ItemArray[2]
								select student;

				var studentList = new List<Student>();

				foreach (var student in linqQuery)
				{
					studentList.Add(new Student()
					{
						StudentId = (int)student["Код студента"],
						SurnameNP = (string)student["ФИО"],
						GroupNum = (string)student["Группа"]
					});
				}

				return studentList;
			}
			catch
			{
				return null;
			}
		}

		/// <summary>
		/// Инициализация подключения.
		/// </summary>
		/// <param name="connectionString"> Строка подключения. </param>
		public DbProvider(string connectionString) : base(connectionString)
		{
			
		}
	}
}