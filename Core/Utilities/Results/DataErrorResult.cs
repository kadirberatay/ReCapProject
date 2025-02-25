﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
	public class DataErrorResult<T> : DataResult<T>
	{
		public DataErrorResult(T data, string message) : base(data, false, message)
		{

		}

		public DataErrorResult(T data) : base(data, false)
		{

		}

		public DataErrorResult(string message) : base(default, false, message)
		{
			
		}

		public DataErrorResult() : base(default, false)
		{

		}
	}
}
