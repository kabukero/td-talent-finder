using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentFinder.BE
{
	public class TestResultado
	{
		public string Descripcion { get; set; }
		public IList<TestItem> TestItems = new List<TestItem>();
		public bool Estado { get; set; }
	}
}
