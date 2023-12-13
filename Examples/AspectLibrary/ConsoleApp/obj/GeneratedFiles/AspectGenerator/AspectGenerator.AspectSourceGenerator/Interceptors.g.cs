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

		static SR. MemberInfo                 InstanceMethod_Interceptor_MemberInfo        = MethodOf(() => default(ClassLibrary.Class1).InstanceMethod());
		static SCG.Dictionary<string,object?> InstanceMethod_Interceptor_AspectArguments_0 = new()
		{
		};
		//
		/// <summary>
		/// Intercepts ClassLibrary.Class1.InstanceMethod().
		/// </summary>
		//
		// Intercepts new Class1().InstanceMethod().
		[System.Runtime.CompilerServices.InterceptsLocation(@"P:\AspectGenerator\Examples\AspectLibrary\ConsoleApp\Program.cs", line: 11, character: 17)]
		//
		[System.Runtime.CompilerServices.CompilerGenerated]
		//[System.Diagnostics.DebuggerStepThrough]
		public static void InstanceMethod_Interceptor(this ClassLibrary.Class1 __this__)
		{
			// AspectLibrary.LogAttribute
			//
			var __info__0 = new AspectGenerator.InterceptInfo<AspectGenerator.Void>
			{
				MemberInfo      = InstanceMethod_Interceptor_MemberInfo,
				AspectType      = typeof(AspectLibrary.LogAttribute),
				AspectArguments = InstanceMethod_Interceptor_AspectArguments_0,
			};

			AspectLibrary.LogAttribute.OnBeforeCall(__info__0);

			if (__info__0.InterceptResult != AspectGenerator.InterceptResult.Return)
			{
				__this__.InstanceMethod();

				AspectLibrary.LogAttribute.OnAfterCall(__info__0);
			}
		}
	}
}
