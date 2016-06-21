namespace HelloWorld
{
	using System;
	using System.Configuration;
	using RabbitMQ.Client;

	class MainClass
	{
		public static void Main(string[] args)
		{
			foreach (string key in ConfigurationManager.AppSettings)
			{
				string value = ConfigurationManager.AppSettings[key];
				Console.WriteLine("Key: {0}, Value: {1}", key, value);
			}

			foreach (var asd in Environment.GetEnvironmentVariables()) 
			{
				
				
				Console.WriteLine("Key: {0}, Value: {1}", asd.ToString(), "");
			}

			var factory = new ConnectionFactory() { HostName = "rabbitmq" };
			using (var connection = factory.CreateConnection())
			{
				using (var channel = connection.CreateModel())
				{
					Console.WriteLine(channel.ToString());
				}
			}

			Console.WriteLine("Hello World!");
		}
	}
}
