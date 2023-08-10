using bilgiyon_yazilim_ogrenci_takip_deneme.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiyon_yazilim_ogrenci_takip_deneme.BusinessLayer.ValidationRules
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator() 
        {
            //Isim kurallari
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Bu alan bos gecilemez.")
            .MinimumLength(2).WithMessage("Lutfen en az 2 karakter girisi yapiniz.")
            .MaximumLength(50).WithMessage("Lutfen en fazla 50 karakter giriniz");
           


            //Soyad kurallari
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Bu alan bos gecilemez.")
            .MinimumLength(2).WithMessage("Lutfen en az 2 karakter girisi yapiniz.")
            .MaximumLength(50).WithMessage("Lutfen en fazla 50 karakter giriniz");


            //Adres kurallari
            RuleFor(x=>x.Address).NotEmpty().WithMessage("Bu alan bos gecilemez.");
            RuleFor(x => x.Address).MaximumLength(200).WithMessage("En fazla 200 karakter giriniz.");


            ////Telefon kurallari
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Bu alan bos gecilemez.").Length(11).WithMessage("Telefon numarası tam olarak 11 karakter olmalıdır.")
                .Must(HasOnlyNumbers).WithMessage("Telefon numarası sadece sayılardan oluşmalıdır.");



            //Sinif kurallari
            RuleFor(x => x.Class).NotEmpty().WithMessage("Bu alan bos gecilemez.")
               .MaximumLength(4).WithMessage("En fazla 4 karakter giriniz.");            
        }
        private bool HasOnlyNumbers(string number)
        {
            return long.TryParse(number, out _);
        }
    }
}
