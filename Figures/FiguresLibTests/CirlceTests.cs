using FiguresLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibTests
{
	public class CirlceTests
	{
		[Fact]
		public void CirlceNotNull()
		{
			Cirlce circle = new Cirlce(1);
			Assert.NotNull(circle);
		}

		[Fact]
		public void FigureAsCirlceNotNull()
		{
			Figure circle = new Cirlce(1);
			Assert.NotNull(circle);
		}

		[Fact]
		public void CircleIsAssignableFromFigureBase()
		{
			Figure circle = new Cirlce(1);
			Assert.IsAssignableFrom<Figure>(circle);
		}

		[Fact]
		public void ObjectIsCircleClass()
		{
			Figure circle = new Cirlce(1);
			Assert.IsType<Cirlce>(circle);
		}

		[Fact]
		public void ThrowExceptionIfCircleRadiusIsZero()
		{
			Assert.Throws<ArgumentException>(() => new Cirlce(0));
		}

		[Fact]
		public void ThrowExceptionIfCircleRadiusIsNegative()
		{
			Assert.Throws<ArgumentException>(() => new Cirlce(-1));
		}

		[Fact]
		public void FigureTypeHasStringType()
		{
			Figure circle = new Cirlce(1);
			Assert.IsType<string>(circle.GetFigureType());
		}

		[Fact]
		public void FigureTypeIsCircle()
		{
			Figure circle = new Cirlce(1);
			Assert.Equal("circle", circle.GetFigureType());
		}

		[Fact]
		public void CircleAreaTypeIsDouble()
		{
			Figure circle = new Cirlce(1);
			var area = circle.GetArea();
			Assert.IsType<double>(area);
		}

		[Theory]
		[InlineData(0.01, 0.0003141592653589793)]
		[InlineData(1.5, 7.0685834705770345)]
		[InlineData(500.0, 785398.1633974483)]
		public void CircleAreaisCorrect(double radius, double area)
		{
			Figure circle = new Cirlce(radius);
			Assert.Equal(Math.PI * Math.Pow(radius, 2), area);
		}
	}
}
