using FiguresLib;

namespace FiguresLibTests
{
	public class FigureBaseTests
	{

		[Fact]
		public void FigureAsCirlceNotNull()
		{
			Figure circle = new Cirlce(1);
			Assert.NotNull(circle);
		}

		[Fact]
		public void FigureToString()
		{
			Figure triangle = new Triangle(3, 4, 5);
			Assert.Equal("triangle (a = 3, b = 4, c = 5, square = 6)", triangle.ToString());
		}

		[Fact]
		public void EqualsOperatorTrueSameFigures()
		{
			Figure triangle1 = new Triangle(3, 4, 5);
			Figure triangle2 = new Triangle(3, 4, 5);
			Assert.True(triangle1 == triangle2);
			Assert.False(triangle2 != triangle1);
		}

		[Fact]
		public void EqualsOperatorFalseSameFigures()
		{
			Figure triangle1 = new Triangle(3, 4, 5);
			Figure triangle2 = new Triangle(4, 4, 5);
			Assert.False(triangle1 == triangle2);
			Assert.True(triangle1 != triangle2);
		}

		[Fact]
		public void EqualsOperatorTrueDifferentFigures()
		{
			Figure triangle1 = new Triangle(13, 14, 15);
			Figure circle1 = new Cirlce(Math.Pow(84 / Math.PI, 0.5));
			Assert.True(triangle1 == circle1);
			Assert.False(triangle1 != circle1);
		}

		[Fact]
		public void EqualsOperatorFalseDifferentFigures()
		{
			Figure triangle1 = new Triangle(15, 14, 15);
			Figure circle1 = new Cirlce(Math.Pow(84 / Math.PI, 0.5));
			Assert.False(triangle1 == circle1);
			Assert.True(triangle1 != circle1);
		}

		[Fact]
		public void MoreAndLess()
		{
			Figure triangle1 = new Triangle(3, 4, 5);
			Figure triangle2 = new Triangle(4, 4, 5);
			Assert.True(triangle1 < triangle2);
			Assert.False(triangle1 > triangle2);
		}

		[Fact]
		public void MoreOeEqualsAndLessOrEquals()
		{
			Figure triangle1 = new Triangle(3, 4, 5);
			Figure triangle2 = new Triangle(4, 4, 5);
			Figure triangle3 = new Triangle(4, 4, 5);
			Assert.True(triangle1 <= triangle2);
			Assert.False(triangle1 >= triangle2);
			Assert.True(triangle2 <= triangle3);
		}
	}
}
