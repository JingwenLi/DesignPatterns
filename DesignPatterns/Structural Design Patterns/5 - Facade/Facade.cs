using System;

namespace DesignPatterns.Facade
{
	class Client
	{
		static void Main(string[] args)
		{
			var facade = new SystemFacade();
			facade.SubmitOrder();
		}
	}

	public class WarehouseSystem
	{
		public void Pack()
		{
			Console.WriteLine("Pack good");
		}
	}

	public class LogisticsSystem
	{
		public void Delivery()
		{
			Console.WriteLine("Delivery goods");
		}
	}

	public class SystemFacade
	{
		private WarehouseSystem warehouseSystem;
		private LogisticsSystem logisticsSystem;

		public SystemFacade()
		{
			warehouseSystem = new WarehouseSystem();
			logisticsSystem = new LogisticsSystem();
		}

		public void SubmitOrder()
		{
			warehouseSystem.Pack();
			logisticsSystem.Delivery();
		}
	}
}