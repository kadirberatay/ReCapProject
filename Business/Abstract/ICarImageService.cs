﻿using Core.Utilities.Results;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICarImageService
	{
		IResult Add(CarImage carImage);
		IResult Delete(CarImage carImage);
		IResult Update(CarImage carImage);
	}
}
