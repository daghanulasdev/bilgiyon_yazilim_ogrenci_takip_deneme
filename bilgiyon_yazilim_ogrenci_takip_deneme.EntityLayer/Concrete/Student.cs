using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiyon_yazilim_ogrenci_takip_deneme.EntityLayer.Concrete
{
	public class Student
	{
		[Key]
        public int StudentID { get; set; }

		[StringLength(50)]
		public string? Name { get; set; }

		[StringLength(50)]
		public string? Surname { get; set; }

		[StringLength(4)]
		public string? Class { get; set; }

		[StringLength(11,MinimumLength =11,ErrorMessage ="Telefon numarasi 11 karakter olmalidir.")]
		[RegularExpression("^[0-9]*$", ErrorMessage ="Telefon numarasi sadece sayilardan olusmalidir.")]
        public string? Phone { get; set; }

		[StringLength(200)]
		public string? Address { get; set; }

    }
}
