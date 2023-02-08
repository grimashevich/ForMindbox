using FiguresLib;

var rand = new Random();


List<Figure> figures = new List<Figure>();

figures.Add(new Cirlce(0.01));
figures.Add(new Cirlce(1.5));
figures.Add(new Cirlce(10.00));
figures.Add(new Triangle(1, 1, 1));
figures.Add(new Triangle(5, 7, 10));
figures.Add(new Triangle(3, 4, 5));


foreach (Figure fig in figures)
{
	Console.Write(fig);
	if (fig.GetFigureType() == "triangle")
	{
		Triangle triangle = (Triangle)fig;
		if (triangle.IsTriangleRight())
			Console.Write(" прямоугольный");
	}
	Console.WriteLine();
}


Console.WriteLine("\n");

Console.WriteLine("Вычисление площади фигуры без знания типа в compile time");
Figure figure;
if (rand.Next() % 2 == 0)
	figure = new Cirlce(3);
else
	figure = new Triangle(3, 4, 5);

Console.WriteLine($"Тип {figure.GetType()}, площадь: {figure.GetArea()}");
