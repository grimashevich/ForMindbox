using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
	public class Cirlce : Figure
	{
		public Cirlce(double radius) : base("circle")
		{
			if (radius <= 0)
				throw new ArgumentException("Radius of square must be > 0");
			Params.Add("radius", radius);
		}

		/// <summary>
		/// Calculate and return the area of cirlce
		/// </summary>
		/// <returns>Radius of cirlce</returns>
		public override double GetArea()
		{
			return Math.PI * Math.Pow(Params["radius"], 2);
		}
	}
}
