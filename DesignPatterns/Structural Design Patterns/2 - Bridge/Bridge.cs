using System;

namespace DesignPatterns.Bridge
{
	public class Client
	{
		public static void Run()
		{
			var white = new White();
			var blue = new Blue();
			var pink = new Pink();

			var square = new Square();
			var rectange = new Rectangle();
			var circle = new Circle();

			var obj1 = new ColorfulShape(white, square);
			obj1.Draw();

			var obj2 = new ColorfulShape(blue, rectange);
			obj2.Draw();

			var obj3 = new ColorfulShape(pink, square);
			obj3.Draw();

			var obj4 = new ColorfulShape(pink, circle);
			obj4.Draw();
		}
	}

	public class ColorfulShape
	{
		public Color Color;
		public Shape Shape;

		public ColorfulShape(Color color, Shape shape)
		{
			Color = color;
			Shape = shape;
		}

		public void Draw()
		{
			Shape.Draw();

			Console.Write(" ");

			Color.Paint();

			Console.WriteLine();
		}
	}

	#region Shape

	public interface Shape
	{
		void Draw();
	}

	public class Circle : Shape
	{
		public void Draw()
		{
			Console.Write("Circle");
		}
	}

	public class Rectangle : Shape
	{
		public void Draw()
		{
			Console.Write("Rectangle");
		}
	}

	public class Square : Shape
	{
		public void Draw()
		{
			Console.Write("Square");
		}
	}

	#endregion

	#region Color

	public interface Color
	{
		void Paint();
	}

	public class White : Color
	{
		public void Paint()
		{
			Console.Write("White");
		}
	}

	public class Pink : Color
	{
		public void Paint()
		{
			Console.Write("Pink");
		}
	}

	public class Blue : Color
	{
		public void Paint()
		{
			Console.Write("Blue");
		}
	}

	#endregion
}