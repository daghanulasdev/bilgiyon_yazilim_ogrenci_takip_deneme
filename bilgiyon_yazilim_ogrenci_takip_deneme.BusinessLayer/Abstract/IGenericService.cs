using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiyon_yazilim_ogrenci_takip_deneme.BusinessLayer.Abstract
{
	public interface IGenericService<T>
	{
		void TInsert(T t);
		void TUpdate(T t);
		void TDelete(T t);
		T TGetById (int id);
		List<T> TGetList();
	}
}
