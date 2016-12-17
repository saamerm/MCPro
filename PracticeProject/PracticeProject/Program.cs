using System;
using System.Threading.Tasks;
namespace PracticeProject
{
	class MainClass
	{
		//Using Tasks
		public static void Main(string[] args)
		{
			Task t = Task.Run(() =>
			{
				for (int x = 0; x < 100; x++)
				{
					Console.Write("*");
				}
			});
			t.Wait();
		}
	}
}
