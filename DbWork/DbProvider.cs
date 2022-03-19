using AVLabWeb.DbWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
			throw new NotImplementedException();
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