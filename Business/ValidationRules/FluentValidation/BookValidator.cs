using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.Title).NotEmpty();
            RuleFor(b => b.Title).MinimumLength(2);
            RuleFor(b => b.Description).NotEmpty();
        }
    }
}
