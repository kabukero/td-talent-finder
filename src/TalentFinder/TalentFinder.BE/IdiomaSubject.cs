using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class IdiomaSubject
	{
		public static List<IIdiomaObserver> observers = new List<IIdiomaObserver>();

		public static void AddObserver(IIdiomaObserver observer)
		{
			observers.Add(observer);
		}
		public static void RemoveObserver(IIdiomaObserver observer)
		{
			observers.Remove(observer);
		}
		public static void Notify(Idioma idioma)
		{
			foreach(var observer in observers)
				observer.Update(idioma);
		}
	}
}
