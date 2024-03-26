using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel ismi boş geçilemez!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklama kısmı boş geçilemez!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş geçilemez!");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Maximum 20 karakter giriniz!");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Minimum 8 karakter giriniz!");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Maximum 50 karakter giriniz!");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Minimum 20 karakter giriniz!");
        }
    }
}
