﻿// <auto-generated/>
#pragma warning disable
#nullable enable

using System;

using SR  = System.Reflection;
using SLE = System.Linq.Expressions;
using SCG = System.Collections.Generic;

namespace AspectGenerator
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

		static SR. MemberInfo                 StaticMethod_Interceptor_MemberInfo        = MethodOf(() => ClassLibrary.Class1.StaticMethod());
		static SCG.Dictionary<string,object?> StaticMethod_Interceptor_AspectArguments_0 = new()
		{
		};
		//
		/// <summary>
		/// Intercepts ClassLibrary.Class1.StaticMethod().
		/// </summary>
		//
		// Intercepts StaticMethod().
		[System.Runtime.CompilerServices.InterceptsLocation(@"P:\AspectGenerator\Examples\AspectLibrary\ClassLibrary\Class1.cs", line: 12, character: 4)]
		//
		[System.Runtime.CompilerServices.CompilerGenerated]
		//[System.Diagnostics.DebuggerStepThrough]
		public static void StaticMethod_Interceptor()
		{
			// AspectLibrary.ConsoleLogAttribute
			//
			var __info__0 = new AspectGenerator.InterceptInfo<AspectGenerator.Void>
			{
				MemberInfo      = StaticMethod_Interceptor_MemberInfo,
				AspectType      = typeof(AspectLibrary.ConsoleLogAttribute),
				AspectArguments = StaticMethod_Interceptor_AspectArguments_0,
			};

			AspectLibrary.ConsoleLogAttribute.OnBeforeCall(__info__0);

			if (__info__0.InterceptResult != AspectGenerator.InterceptResult.Return)
			{
				ClassLibrary.Class1.StaticMethod();

				AspectLibrary.ConsoleLogAttribute.OnAfterCall(__info__0);
			}
		}
	}
}
