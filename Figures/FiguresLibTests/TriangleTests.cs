using FiguresLib;

namespace FiguresLibTests
{
	public class TriangleTests
	{
		[Fact]
		public void TriangleNotNull()
		{
			Triangle triangle = new Triangle(4, 5, 6);
			Assert.NotNull(triangle);
		}

		[Fact]
		public void FigureAsTriangleNotNull()
		{
			Figure triangle = new Triangle(4, 5, 6);
			Assert.NotNull(triangle);
		}

		[Fact]
		public void TriangleIsAssignableFromFigureBase()
		{
			Figure triangle = new Triangle(4, 5, 6);
			Assert.IsAssignableFrom<Figure>(triangle);
		}

		[Fact]
		public void ObjectIsTriangleClass()
		{
			Figure triangle = new Triangle(4, 5, 6);
			Assert.IsType<Triangle>(triangle);
		}

		[Theory]
		[InlineData(0, 0, 0)]
		[InlineData(3, 0, 5)]
		[InlineData(3, 4, 0)]
		[InlineData(-3, 4, 5)]
		[InlineData(3, -4, 5)]
		[InlineData(3, 4, -5)]
		[InlineData(-3, -4, -5)]
		[InlineData(1, 2, 3)]
		public void ThrowExceptionIfSidesIsWrong(double a, double b, double c)
		{
			Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
		}

		[Fact]
		public void FigureTypeHasStringType()
		{
			Figure triangle = new Triangle(4, 5, 6);
			Assert.IsType<string>(triangle.GetFigureType());
		}

		[Fact]
		public void FigureTypeIsCircle()
		{
			Figure triangle = new Triangle(4, 5, 6);
			Assert.Equal("triangle", triangle.GetFigureType());
		}

		[Fact]
		public void CircleAreaTypeIsDouble()
		{
			Figure triangle = new Triangle(4, 5, 6);
			var area = triangle.GetArea();
			Assert.IsType<double>(area);
		}


		[Theory]
		[InlineData(3, 4, 5, 6)]
		[InlineData(1, 1, 1, 0.4330127018922193)]
		[InlineData(5, 7, 10, 16.24807680927192)]
		public void TriangleAreaIsCorrect(double a, double b, double c, double area)
		{
			Triangle triangle = new Triangle(a, b, c);
			Assert.Equal(area, triangle.GetArea());
		}

		[Theory]
		[InlineData(3, 4, 5, true)]
		[InlineData(8, 10, 6, true)]
		[InlineData(97, 72, 65, true)]
		[InlineData(63, 16, 65, true)]
		[InlineData(1, 1, 1, false)]
		[InlineData(99, 72, 60, false)]
		[InlineData(3, 55, 57, false)]
		public void isTriangleRight(double a, double b, double c, bool answer)
		{
			Triangle triangle = new Triangle(a, b, c);
			bool isRight = triangle.IsTriangleRight();
			Assert.Equal(answer, isRight);
		}
	}
}
