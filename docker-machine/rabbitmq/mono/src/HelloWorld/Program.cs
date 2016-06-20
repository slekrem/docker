namespace HelloWorld
{
	using System;
	using RabbitMQ.Client;

	class MainClass
	{
		public static void Main(string[] args)
		{
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
