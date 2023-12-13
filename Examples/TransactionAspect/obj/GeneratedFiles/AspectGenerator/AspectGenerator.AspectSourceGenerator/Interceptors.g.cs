﻿// <auto-generated/>
#pragma warning disable
#nullable enable

using System;

using SR  = System.Reflection;
using SLE = System.Linq.Expressions;
using SCG = System.Collections.Generic;

namespace ExampleAspectGenerator
{
	using AspectGenerator = AspectGenerator;

	static partial class Interceptors
	{
		static SR.MethodInfo GetMethodInfo(SLE.Expression expr)
		{
			return expr switch
			{
				SLE.MethodCallExpression mc => mc.Method,
				_                           => throw new InvalidOperationException()
			};
		}

		static SR.MethodInfo MethodOf<T>(SLE.Expression<Func<T>> func) => GetMethodInfo(func.Body);
		static SR.MethodInfo MethodOf   (SLE.Expression<Action>  func) => GetMethodInfo(func.Body);

		static SR. MemberInfo                 GetCustomers_Interceptor_MemberInfo        = MethodOf(() => TransactionAspect.Program.GetCustomers(default(LinqToDB.Data.DataConnection)));
		static SCG.Dictionary<string,object?> GetCustomers_Interceptor_AspectArguments_0 = new()
		{
			["IsolationLevel"] = 256,
		};
		//
		/// <summary>
		/// Intercepts TransactionAspect.Program.GetCustomers(LinqToDB.Data.DataConnection).
		/// </summary>
		//
		// Intercepts GetCustomers(db).
		[System.Runtime.CompilerServices.InterceptsLocation(@"P:\AspectGenerator\Examples\TransactionAspect\Program.cs", line: 38, character: 14)]
		//
		[System.Runtime.CompilerServices.CompilerGenerated]
		//[System.Diagnostics.DebuggerStepThrough]
		public static System.Collections.Generic.List<TransactionAspect.Program.Customer> GetCustomers_Interceptor(LinqToDB.Data.DataConnection db)
		{
			var __args__ = new object?[] { db };

			// Aspects.TransactionAttribute(IsolationLevel = System.Data.IsolationLevel.ReadUncommitted)
			//
			var __info__0 = new AspectGenerator.InterceptInfo<System.Collections.Generic.List<TransactionAspect.Program.Customer>>
			{
				MemberInfo      = GetCustomers_Interceptor_MemberInfo,
				AspectType      = typeof(Aspects.TransactionAttribute),
				AspectArguments = GetCustomers_Interceptor_AspectArguments_0,
				MethodArguments = __args__,
			};

			try
			{
				Aspects.TransactionAttribute.OnBeforeCall(__info__0);

				if (__info__0.InterceptResult != AspectGenerator.InterceptResult.Return)
				{
					__info__0.ReturnValue = TransactionAspect.Program.GetCustomers(db);
				}
			}
			catch (Exception __ex__)
			{
				__info__0.Exception = __ex__;
				throw;
			}
			finally
			{
				Aspects.TransactionAttribute.OnFinally(__info__0);
			}

			return __info__0.ReturnValue;
		}

		static SR. MemberInfo                 GetCustomersAsync_Interceptor_MemberInfo        = MethodOf(() => TransactionAspect.Program.GetCustomersAsync(default(LinqToDB.Data.DataConnection)));
		static SCG.Dictionary<string,object?> GetCustomersAsync_Interceptor_AspectArguments_0 = new()
		{
		};
		//
		/// <summary>
		/// Intercepts TransactionAspect.Program.GetCustomersAsync(LinqToDB.Data.DataConnection).
		/// </summary>
		//
		// Intercepts GetCustomersAsync(db).
		[System.Runtime.CompilerServices.InterceptsLocation(@"P:\AspectGenerator\Examples\TransactionAspect\Program.cs", line: 39, character: 14)]
		//
		[System.Runtime.CompilerServices.CompilerGenerated]
		//[System.Diagnostics.DebuggerStepThrough]
		public static async System.Threading.Tasks.Task<System.Collections.Generic.List<TransactionAspect.Program.Customer>> GetCustomersAsync_Interceptor(LinqToDB.Data.DataConnection db)
		{
			var __args__ = new object?[] { db };

			// Aspects.TransactionAttribute
			//
			var __info__0 = new AspectGenerator.InterceptInfo<System.Collections.Generic.List<TransactionAspect.Program.Customer>>
			{
				MemberInfo      = GetCustomersAsync_Interceptor_MemberInfo,
				AspectType      = typeof(Aspects.TransactionAttribute),
				AspectArguments = GetCustomersAsync_Interceptor_AspectArguments_0,
				MethodArguments = __args__,
			};

			try
			{
				await Aspects.TransactionAttribute.OnBeforeCallAsync(__info__0);

				if (__info__0.InterceptResult != AspectGenerator.InterceptResult.Return)
				{
					__info__0.ReturnValue = await TransactionAspect.Program.GetCustomersAsync(db);
				}
			}
			catch (Exception __ex__)
			{
				__info__0.Exception = __ex__;
				throw;
			}
			finally
			{
				await Aspects.TransactionAttribute.OnFinallyAsync(__info__0);
			}

			return __info__0.ReturnValue;
		}
	}
}
