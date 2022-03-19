using AVLabWeb.DbWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
		/// Получить данные о сданых экзаменах студента.
		/// </summary>
		/// <param name="StudentId"> Id студента. </param>
		/// <returns> Список экзаменов. </returns>
		public override List<Mark> GetStudentExams(int StudentId)
		{
			var sqlRequest = "SELECT * " +
				"FROM Оценки " +
				"INNER JOIN Предметы " +
				"ON Оценки.Код_предмета = Предметы.Код_предмета " +
				$"WHERE Код_студента = {StudentId} ";

			try
			{
				var examsTable = GetDataSet(sqlRequest, "Оценки").Tables["Оценки"];

				var linqQuery = from exam in examsTable.AsEnumerable()
								orderby exam.ItemArray[2]
								select exam;

				var examsList = new List<Mark>();

				foreach (var exam in linqQuery)
				{
					examsList.Add(new Mark()
					{
						ExamDate = Convert.ToDateTime(exam["Дата_экзамена"]),
						MarkValue = (int)exam["Оценка"],
						DisciplineName = (string)exam["Название_предмета"]
					});
				}

				return examsList;
			}
			catch (Exception e)
			{
				var mes = e.Message;
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