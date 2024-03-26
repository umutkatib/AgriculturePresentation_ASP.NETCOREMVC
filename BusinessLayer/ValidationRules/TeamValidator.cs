using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Personel ismi boş geçilemez!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmı boş geçilemez!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim yolu boş geçilemez!");
            RuleFor(x => x.PersonName).MaximumLength(40).WithMessage("Personel ismi 40 karakteri geçemez!");
            RuleFor(x => x.PersonName).MinimumLength(4).WithMessage("Personel ismi 4 karakterden az olamaz!");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla veri girişi yapın!");
        }
    }
}
