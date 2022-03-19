using AVLabWeb.DbWork.Entities;
using AVLabWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

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
		/// Адаптер базы данных.
		/// </summary>
		protected OleDbDataAdapter adapter;

		/// <summary>
		/// Выборка данных от запроса.
		/// </summary>
		protected DataSet dataSet;

		/// <summary>
		/// Не реализовываем. Реализуем в прототипе.
		/// </summary>
		/// <returns> Список студентов. </returns>
		public abstract List<Student> GetStudentsList();

		/// <summary>
		/// Получить данные о сданых экзаменах студента.
		/// </summary>
		/// <param name="StudentId"> Id студента. </param>
		/// <returns> Список экзаменов. </returns>
		public abstract List<Mark> GetStudentExams(int StudentId);

		/// <summary>
		/// Подключение к БД с использованием connectionString.
		/// </summary>
		/// <param name="connectionString"> Данные для подключения. </param>
		public DbProviderFactory(string connectionString)
		{
			this.connectionString = connectionString;

			dbConnection = new OleDbConnection(connectionString);
		}

		/// <summary>
		/// Получить набор данных по запросу.
		/// </summary>
		/// <param name="sqlRequest"> текст запроса. </param>
		/// <param name="tableName"> Название тбалицы в датасете. </param>
		/// <returns> Полученный запрос по датасету. </returns>
		protected DataSet GetDataSet(string sqlRequest, string tableName)
		{
			adapter = new OleDbDataAdapter(sqlRequest, dbConnection);

			dataSet = new DataSet();

			adapter.Fill(dataSet, tableName);

			return dataSet;
		}
	}
}