using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
	public class CarImage:IEntity
	{
		public int ImagesId { get; set; }
		public int CarId { get; set; }
		public string ImagePath { get; set; }
		public DateTime Date { get; set; }
	}
}
