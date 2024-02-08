using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MMyMethods;
using System.Security.Cryptography.X509Certificates;

namespace PProgram
{
	internal class Program
	{
		async static Task Main(string[] args)
		{
			MyMethods myMem = new MyMethods();

			CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
			CancellationToken token = cancelTokenSource.Token;
			token.Register(() =>
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ОПЕРАЦИЯ БЫЛА ПРЕРВАНА ЧЕРЕЗ ТОКЕН!");
				Console.ResetColor();
			});

			Task.Run(() => CallCancelRequest()); // Посылает запрос на отмену операции через указанное время

			await myMem.StartTheMethods(myMem.Cycle_1, myMem.Cycle_2, token);

			Console.WriteLine("ГЛАВНЫЙ МЕТОД ЗАВЕРШИЛ РАБОТУ!");



			void CallCancelRequest()
			{
				Thread.Sleep(2000);
				cancelTokenSource.Cancel();
			}
		}
	}
}