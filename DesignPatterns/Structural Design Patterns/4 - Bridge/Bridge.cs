﻿using System;

namespace DesignPatterns.Bridge
{
	public interface Color
	{
		void Paint(string shape);
	}

	public class Red : Color
	{
		public void Paint(string shape)
		{
			Console.WriteLine("Red " + shape);
		}
	}

	public class Blue : Color
	{
		public void Paint(string shape)
		{
			Console.WriteLine("Blue " + shape);
		}
	}

	public class White : Color
	{
		public void Paint(string shape)
		{
			Console.WriteLine("White " + shape);
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
	
	public class Square : Shape
	{
		public override void Draw()
		{
			color.Paint("Square");
		}
	}

	public class Client
	{
		public static void Run()
		{
			var red = new Red();
			var blue = new Blue();
			var white = new White();

			var square = new Square();
			var circle = new Circle();

			square.SetColor(red);
			square.Draw();

			circle.SetColor(white);
			circle.Draw();

			circle.SetColor(blue);
			circle.Draw();
		}
	}
}