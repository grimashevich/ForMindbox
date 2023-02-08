namespace FiguresLib
{
	public class Triangle : Figure
	{
		public Triangle(double sideA, double sideB, double sideC) : base("triangle")
		{
			if (sideA <= 0 || sideB <= 0 || sideC <= 0)
			{
				throw new ArgumentException("The side of the triangle must be > 0");
			}

			string error = "";
			if (CheckTriangleSides(sideA, sideB, sideC, ref error) == false)
			{
				throw new ArgumentException(error);
			}

			Params.Add("a", sideA);
			Params.Add("b", sideB);
			Params.Add("c", sideC);
		}

		public Triangle(IEnumerable<double> sides) : base("triangle")
		{
			if (sides == null || sides.Count() != 3)
			{
				throw new ArgumentException("Expected 3 sides of triangle");
			}
			double[] sidesArray = sides.ToArray();
			string error = "";
			if (CheckTriangleSides(sidesArray[0], sidesArray[1], sidesArray[2], ref error) == false)
			{
				throw new ArgumentException(error);
			}
			Params.Add("a", sidesArray[0]);
			Params.Add("b", sidesArray[1]);
			Params.Add("c", sidesArray[2]);
		}

		/// <summary>
		/// Calculate and return the area of triangle
		/// </summary>
		/// <returns>Area of triangle</returns>
		public override double GetArea()
		{
			double p = Params.Values.Sum() / 2.0;
			double s = Math.Sqrt(p * (p - Params["a"]) * (p - Params["b"]) * (p - Params["c"]));
			return s;
		}

		/// <summary>
		/// Determines if a triangle is a right triangle
		/// </summary>
		/// <returns>true if the triangle is right, else false</returns>
		public bool IsTriangleRight()
		{
			double hypotenuse = Math.Max(Math.Max(Params["a"], Params["b"]), Params["c"]);
			double leg1 = Math.Min(Math.Min(Params["a"], Params["b"]), Params["c"]);
			double leg2 = Params.Values.Sum() - hypotenuse - leg1;
			return leg1 * leg2 / 2 == GetArea();
			// variant 2
			// return Math.Pow(hypotenuse, 2) == Math.Pow(leg1, 2) + Math.Pow(leg2, 2);
		}

		/// <summary>
		/// Checks if it is possible to form a triangle given sides
		/// </summary>
		/// <param name="a">Side a length</param>
		/// <param name="b">Side b length</param>
		/// <param name="c">Side c length</param>
		/// <param name="error">Reference to the error string variable.
		/// An error text will be written if the triangle cannot be formed.</param>
		/// <returns>true if possible to form a triangle, else false anf error message to error variable</returns>
		static bool CheckTriangleSides(double a, double b, double c, ref string error)
		{
			if (a <= 0 || b <= 0 || c <= 0)
			{
				error = "The side of the triangle must be > 0";
				return false;
			}

			if ((a + b > c && a + c > b && b + c > a) == false)
			{
				error = "Incorrect triangle sides values";
				return false;
			}

			return true;
		}
	}
}
