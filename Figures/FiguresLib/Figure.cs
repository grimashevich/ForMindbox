using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
	abstract public class Figure
	{
		/// <summary>
		/// 
		/// </summary>
		public readonly Dictionary<string, double> Params = new();

		/// <summary>
		/// String description of figure type
		/// </summary>
		public readonly string figureType;


		public Figure(string figureType)
		{
			this.figureType = figureType;
		}

		/// <summary>
		/// Calculate and return the area of figure
		/// </summary>
		/// <returns>Area of figure</returns>
		abstract public double GetArea();

		public string GetFigureType() => figureType;

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(figureType + " (");
			foreach (var param in Params)
			{
				sb.Append(param.Key.ToString() + " = " + param.Value.ToString());
				sb.Append(", ");
			}
			sb.Append("square = " + GetArea().ToString() + ")");
			return sb.ToString();
		}

		public override bool Equals(object? obj)
		{
			return obj is Figure @base &&
				   EqualityComparer<Dictionary<string, double>>.Default.Equals(Params, @base.Params) &&
				   figureType == @base.figureType;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Params, figureType);
		}

		public static bool operator ==(Figure left, Figure right)
		{
			if (left.figureType != right.figureType)
				return left.GetArea() == right.GetArea();

			double[] leftParams = left.Params.Values.Order().ToArray();
			double[] rightParams = right.Params.Values.Order().ToArray();
			for (int i = 0; i < leftParams.Count(); i++)
			{
				if (leftParams[i] != rightParams[i])
					return false;
			}
			return true;
		}

		public static bool operator !=(Figure left, Figure right)
		{
			return !(left == right);
		}

		public static bool operator >(Figure left, Figure right)
		{
			return left.GetArea() > right.GetArea();
		}

		public static bool operator <(Figure left, Figure right)
		{
			return left.GetArea() < right.GetArea();
		}

		public static bool operator >=(Figure left, Figure right)
		{
			return left > right || left == right;
		}

		public static bool operator <=(Figure left, Figure right)
		{
			return left < right || left == right;
		}

	}
}
