using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusineesLayer.ValidaitonRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog boş bırakılamaz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Resim kısmı boş bırakılamaz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden az başlık koyun");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 5 karakterden fazla başlık koyun");
        }
    }
}
