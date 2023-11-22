﻿using System;
using System.Threading;

using Aspects;

namespace OpenTelemetryAspect
{
	static class Program
	{
		static void Main()
		{
			using var _ = OpenTelemetryFactory.Create();

			Method1();
			Method2();
			Method1();
			MethodException();
		}

		[Metrics]
		public static void Method1()
		{
			Thread.Sleep(100);
		}

		[Metrics]
		public static void Method2()
		{
			Thread.Sleep(200);
		}

		[IgnoreCatch, Metrics]
		public static void MethodException()
		{
			throw new();
		}
	}
}
