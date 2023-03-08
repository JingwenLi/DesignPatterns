using System;

namespace DesignPatterns.Composite
{
	class Class1
	{
		static void Main(string[] args)
		{
			ConcretProuct livingProduct = new ConcretProuct("平底锅", 100);
			Console.WriteLine(PrintProductDetails(livingProduct));
			Decorator dec1 = new Decorator(livingProduct, "海鲜酱油", 10);
			Console.WriteLine(PrintProductDetails(dec1));
			Decorator dec2 = new Decorator(dec1, "老坛酸菜", 12);
			Console.WriteLine(PrintProductDetails(dec2));
			Console.ReadKey();
		}
		private static string PrintProductDetails(ProductBase product)
		{
			return string.Format("产品组合：{0}   价格：{1}", product.GetName(), product.GetPrice());
		}
	}

	public abstract class ProductBase
	{
		public abstract string GetName();
		public abstract double GetPrice();
	}

	public class ConcretProuct : ProductBase
	{
		private string Name;
		private double Price;

		public ConcretProuct(string name, double price)
		{
			Name = name;
			Price = price;
		}
		public override string GetName() => Name;
		public override double GetPrice() => Price;
	}

	public class Decorator : ProductBase
	{
		private ProductBase _product = null;
		private string _name;
		private double _price;

		public Decorator(ProductBase product, string name, double price)
		{
			this._product = product;
			this._name = name;
			this._price = price;
		}
		public override string GetName()
		{
			return string.Format("{0},{1}", _product.GetName(), _name);
		}
		public override double GetPrice()
		{
			return _product.GetPrice() + _price;
		}
	}

}