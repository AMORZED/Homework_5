// <copyright file="Program.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;

namespace Deadlock
{
	/// <summary>
	/// Класс главной программы.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главный метод.
		/// </summary>
		/// <param name="args">Параметры.</param>
		internal static void Main(string[] args)
		{
			var thread1 = new Thread(() =>
			{
				AcquireLocks1();
			});
			var thread2 = new Thread(() =>
			{
				AcquireLocks2();
			});

			thread1.Name = "Thread 1";
			thread2.Name = "Thread 2";

			thread1.Start();
			thread2.Start();

			thread1.Join();
			thread2.Join();

			Console.WriteLine("Finished.");
			Console.ReadLine();
		}

		/// <summary>
		/// Получение вызывающим потоком блокировки.
		/// </summary>
		internal static void AcquireLocks1()
		{
			var threadId = Thread.CurrentThread.ManagedThreadId;

			Monitor.Enter(lock1, ref acquiredLock1);
			try
			{
				Console.WriteLine($"Thread {threadId} acquired lock 1.");
				Thread.Sleep(1000);
				Console.WriteLine($"Thread {threadId} attempted to acquire lock 2.");

				if (acquiredLock2)
				{
					Console.WriteLine($"Thread {threadId} couldn't get access to lock 2 due to blocking");
				}
				else
				{
					lock (lock2)
					{
						Console.WriteLine($"Thread {threadId} acquired lock 2.");
					}
				}
			}
			finally
			{
				if (acquiredLock1)
				{
					Monitor.Exit(lock1);
				}
			}
		}

		/// <summary>
		/// Получение вызывающим потоком блокировки.
		/// </summary>
		internal static void AcquireLocks2()
		{
			var threadId = Thread.CurrentThread.ManagedThreadId;

			Monitor.Enter(lock2, ref acquiredLock2);
			try
			{
				Console.WriteLine($"Thread {threadId} acquired lock 2.");
				Thread.Sleep(1000);
				Console.WriteLine($"Thread {threadId} attempted to acquire lock 1.");

				if (acquiredLock1)
				{
					Console.WriteLine($"Thread {threadId} couldn't get access to lock 1 due to blocking");
				}
				else
				{
					lock (lock1)
					{
						Console.WriteLine($"Thread {threadId} acquired lock 1.");
					}
				}
			}
			finally
			{
				if (acquiredLock2)
				{
					Monitor.Exit(lock2);
				}
			}
		}

		private static object lock1 = new object();
		private static object lock2 = new object();
		private static bool acquiredLock1 = false;
		private static bool acquiredLock2 = false;
	}
}
