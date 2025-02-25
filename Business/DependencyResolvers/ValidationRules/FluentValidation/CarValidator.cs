﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
	public class CarValidator : AbstractValidator<Car>
	{
		public CarValidator()
		{
			RuleFor(p => p.Description).NotEmpty();
			RuleFor(p => p.Description).MinimumLength(2);
			RuleFor(p => p.DailyPrice).NotEmpty();
			RuleFor(p => p.DailyPrice).GreaterThan(0);
			RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.BrandId == 1);
			RuleFor(p => p.Description).Must(StartWithA).WithMessage("Arabalar A harfi ile başlamalıdır.");
		}

		private bool StartWithA(string arg)
		{
			return arg.StartsWith("A");
		}
	}
}
