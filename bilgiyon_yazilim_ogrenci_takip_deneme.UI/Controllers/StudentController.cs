using bilgiyon_yazilim_ogrenci_takip_deneme.BusinessLayer.Concrete;
using bilgiyon_yazilim_ogrenci_takip_deneme.BusinessLayer.ValidationRules;
using bilgiyon_yazilim_ogrenci_takip_deneme.DataAccessLayer.EntityFramework;
using bilgiyon_yazilim_ogrenci_takip_deneme.EntityLayer.Concrete;
using FluentValidation.Results;
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
			StudentValidator sv = new StudentValidator();
			ValidationResult validationResult = sv.Validate(p);
			if(validationResult.IsValid)
			{
				studentManager.TInsert(p);
				return RedirectToAction("Index");
			}
			else
			{
				foreach(var item in validationResult.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
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
