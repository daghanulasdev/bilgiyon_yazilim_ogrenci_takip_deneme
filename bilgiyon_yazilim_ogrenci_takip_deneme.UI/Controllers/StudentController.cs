using bilgiyon_yazilim_ogrenci_takip_deneme.BusinessLayer.Concrete;
using bilgiyon_yazilim_ogrenci_takip_deneme.DataAccessLayer.EntityFramework;
using bilgiyon_yazilim_ogrenci_takip_deneme.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace bilgiyon_yazilim_ogrenci_takip_deneme.UI.Controllers
{
	public class StudentController : Controller
	{
		StudentManager studentManager = new StudentManager(new EfStudentDal());
		public IActionResult Index()
		{
			var studentvalues = studentManager.TGetList();
			return View(studentvalues);
		}
		[HttpGet]
        public IActionResult AddStudent()
		{
			return View();
		}
		[HttpPost]
        public IActionResult AddStudent(Student p)
        {
			studentManager.TInsert(p);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteStudent(int id)
		{
			
			var studentvalues = studentManager.TGetById(id);
			studentManager.TDelete(studentvalues);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditStudent(int id) 
		{
			var studentvalues = studentManager.TGetById(id);
			return View(studentvalues);
		}
		[HttpPost]
		public IActionResult EditStudent(Student p)
		{
			studentManager.TUpdate(p);
			return RedirectToAction("Index");
		}
	}
}
