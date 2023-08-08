using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiyon_yazilim_ogrenci_takip_deneme.DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Insert(T t);
		void Update(T t);
		void Delete(T t);
		T GetById(int id);
		List<T> GetList();
	}
}
