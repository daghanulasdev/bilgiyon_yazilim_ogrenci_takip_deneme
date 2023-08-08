using bilgiyon_yazilim_ogrenci_takip_deneme.DataAccessLayer.Abstract;
using bilgiyon_yazilim_ogrenci_takip_deneme.DataAccessLayer.Repositories;
using bilgiyon_yazilim_ogrenci_takip_deneme.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiyon_yazilim_ogrenci_takip_deneme.DataAccessLayer.EntityFramework
{
	public class EfStudentDal : GenericRepository<Student>, IStudentDal
	{
	}
}
