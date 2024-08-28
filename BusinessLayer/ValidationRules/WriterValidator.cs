using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("isim gir");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("mail gir");
			RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("8 karakter olmalı")
				.Matches(@"[A-Z]").WithMessage("en az büyük harf");
			
		}
	}
}
