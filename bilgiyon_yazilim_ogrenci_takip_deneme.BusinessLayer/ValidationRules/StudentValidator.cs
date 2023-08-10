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
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Bu alan bos gecilemez.");
            RuleFor(x=>x.Name).MinimumLength(2).WithMessage("Lutfen en az 2 karakter girisi yapiniz.");


            //Soyad kurallari
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Bu alan bos gecilemez.");
            

            //Adres kurallari
            RuleFor(x=>x.Address).NotEmpty().WithMessage("Bu alan bos gecilemez.");


            ////Telefon kurallari
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Bu alan bos gecilemez.").Length(11).WithMessage("Telefon numarası tam olarak 11 karakter olmalıdır.")
                .Must(HasOnlyNumbers).WithMessage("Telefon numarası sadece sayılardan oluşmalıdır.");



            //Sinif kurallari
            RuleFor(x => x.Class).NotEmpty().WithMessage("Bu alan bos gecilemez.");            
        }
        private bool HasOnlyNumbers(string number)
        {
            return long.TryParse(number, out _);
        }
    }
}
