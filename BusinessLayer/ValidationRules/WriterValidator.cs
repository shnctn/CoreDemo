using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public  class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.writerName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage(" Mail boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.writerName).MinimumLength(3).WithMessage("Lütfen en az 2 karakter giriniz.");
        }
    }
}
