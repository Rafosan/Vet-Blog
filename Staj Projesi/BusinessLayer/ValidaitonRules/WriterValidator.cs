using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusineesLayer.ValidaitonRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi kısmı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girin");
            RuleFor(x => x.WriterName).MaximumLength(40).WithMessage("Lütfen en fazla 40 karakter girin");
        }
    }
}
