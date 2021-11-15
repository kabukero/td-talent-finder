using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.Service.Domain
{
	/// <summary>
	/// Clase base para implementar el patron de diseño observer
	/// de un idioma
	/// </summary>
	public class IdiomaSubject
	{
		/// <summary>
		/// lista de observadores
		/// </summary>
		public static List<IIdiomaObserver> observers = new List<IIdiomaObserver>();

		/// <summary>
		/// Método para agregar un observer a la lista
		/// </summary>
		/// <param name="observer">un observer</param>
		public static void AddObserver(IIdiomaObserver observer)
		{
			observers.Add(observer);
		}

		/// <summary>
		/// Método para remover un observer de la lista
		/// </summary>
		/// <param name="observer">un observer</param>
		public static void RemoveObserver(IIdiomaObserver observer)
		{
			observers.Remove(observer);
		}

		/// <summary>
		/// Método para notificar a los observers que se cambio de idioma
		/// </summary>
		/// <param name="idioma">el idioma seleccionado</param>
		public static void Notify(Idioma idioma)
		{
			foreach(var observer in observers)
				observer.Update(idioma);
		}
	}
}
