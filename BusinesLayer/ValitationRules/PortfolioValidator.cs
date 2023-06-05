using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.ValitationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş geçilemeze");
            RuleFor(x => x.ImgUrl).NotEmpty().WithMessage("Görsel Alanı Boş geçilemeze");
            RuleFor(x => x.ImgUrl2).NotEmpty().WithMessage("Görsel Alanı Boş geçilemeze");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Alanı Boş geçilemeze");
            RuleFor(x => x.Values).NotEmpty().WithMessage("Değer Alanı Boş geçilemeze");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("En az 5 karakter olmak zorunda");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("En fazla 100 karakter olmak zorunda");
        }
    }
}
