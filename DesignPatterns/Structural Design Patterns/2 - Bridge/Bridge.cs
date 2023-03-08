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
			var rectangle = new Rectangle();
			var circle = new Circle();

			square.SetColor(white);
			square.Draw();

			rectangle.SetColor(blue);
			rectangle.Draw();

			circle.SetColor(pink);
			circle.Draw();
		}
	}

	public abstract class Shape
	{
		public Color color;
		public void SetColor(Color color)
		{
			this.color = color;
		}
		public abstract void Draw();
	}

	public class Circle : Shape
	{
		public override void Draw()
		{
			color.Paint("Circle");
		}
	}

	public class Rectangle : Shape
	{

		public override void Draw()
		{
			color.Paint("Rectangle");
		}
	}

	public class Square : Shape
	{
		public override void Draw()
		{
			color.Paint("Square");
		}
	}

	public interface Color
	{
		void Paint(string shape);
	}

	public class White : Color
	{
		public void Paint(string shape)
		{
			Console.WriteLine("White " + shape);
		}
	}

	public class Blue : Color
	{
		public void Paint(string shape)
		{
			Console.WriteLine("Blue " + shape);
		}
	}

	public class Pink : Color
	{
		public void Paint(string shape)
		{
			Console.WriteLine("Pink " + shape);
		}
	}
}