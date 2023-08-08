using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiyon_yazilim_ogrenci_takip_deneme.EntityLayer.Concrete
{
	public class Student
	{
        public int StudentID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Class { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }

    }
}
