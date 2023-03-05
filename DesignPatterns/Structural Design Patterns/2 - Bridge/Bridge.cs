using System;

namespace DesignPatterns.Bridge
{
	class Class1
	{
		static void Main(string[] args)
		{
			//白色
			Color white = new White();
			//正方形
			Shape square = new Square();
			//白色的正方形
			square.SetColor(white);
			square.Draw();

			//长方形
			Shape rectange = new Rectangle();
			rectange.SetColor(white);
			rectange.Draw();
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
			color.Paint("圆形");
		}
	}

	public class Rectangle : Shape
	{
		public override void Draw()
		{
			color.Paint("长方形");
		}
	}

	public class Square : Shape
	{
		public override void Draw()
		{
			color.Paint("正方形");
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
			Console.WriteLine("白色的" + shape);
		}
	}

	public class Gray : Color
	{
		public void Paint(string shape)
		{
			Console.WriteLine("灰色的" + shape);
		}
	}

	public class Black : Color
	{
		public void Paint(string shape)
		{
			Console.WriteLine("黑色的" + shape);
		}
	}
}