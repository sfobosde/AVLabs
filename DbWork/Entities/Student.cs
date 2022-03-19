using System;

namespace AVLabWeb.DbWork.Entities
{
	public class Student
	{
		/// <summary>
		/// Код студента.
		/// </summary>
		public int StudentId { get; set; }

		/// <summary>
		/// ФИО студента.
		/// </summary>
		public string SurnameNP { get; set; }

		/// <summary>
		/// Пол студента.
		/// </summary>
		public bool Male { get; set; }

		/// <summary>
		/// Дата рождения.
		/// </summary>
		public DateTime BirthDate { get; set; }

		/// <summary>
		/// Данные о родителях.
		/// </summary>
		public string Parents { get; set; }

		/// <summary>
		/// Адрес проживания.
		/// </summary>
		public string Adress { get; set; }

		/// <summary>
		/// Номер телефона.
		/// </summary>
		public string Phone { get; set; }

		/// <summary>
		/// Паспортные данные.
		/// </summary>
		public string Passport { get; set; }

		/// <summary>
		/// Номер зачетной книжки.
		/// </summary>
		public int ExamsCertificateNum { get; set; }

		/// <summary>
		/// Дата поступления.
		/// </summary>
		public DateTime EnterDate { get; set; }

		/// <summary>
		/// Номер группы.
		/// </summary>
		public string GroupNum { get; set; }

		/// <summary>
		/// Курс.
		/// </summary>
		public int Year { get; set; }

		/// <summary>
		/// Номер специальности.
		/// </summary>
		public string SpecialityId { get; set; }

		/// <summary>
		///  Тип обучения. true - очная, false - заочная
		///  </summary>
		public bool EducationType { get; set; }
	}
}