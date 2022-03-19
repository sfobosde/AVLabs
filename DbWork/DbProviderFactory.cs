using AVLabWeb.DbWork.Entities;
using AVLabWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace AVLabWeb.DbWork
{
	/// <summary>
	/// Класс - "Фабрика" для работы с БД.
	/// </summary>
	public abstract class DbProviderFactory : IDbProvider
	{
		/// <summary>
		/// Строка подключения к БД.
		/// </summary>
		protected string connectionString;

		/// <summary>
		/// Подключение к БД.
		/// </summary>
		protected OleDbConnection dbConnection;

		/// <summary>
		/// Не реализовываем. Реализуем в прототипе.
		/// </summary>
		/// <returns> Список студентов. </returns>
		public abstract List<Student> GetStudentsList();

		/// <summary>
		/// Подключение к БД с использованием connectionString.
		/// </summary>
		/// <param name="connectionString"> Данные для подключения. </param>
		public DbProviderFactory(string connectionString)
		{
			this.connectionString = connectionString;

			dbConnection = new OleDbConnection(connectionString);
		}
	}
}