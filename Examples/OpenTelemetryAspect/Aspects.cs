using System;
using System.Diagnostics;

using AspectGenerator;

using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace Aspects
{
	/// <summary>
	/// Initializes OpenTelemetry.
	/// </summary>
	static class OpenTelemetryFactory
	{
		public static TracerProvider? Create()
		{
			return Sdk.CreateTracerProviderBuilder()
				.SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("MySample"))
				.AddSource("Sample.Aspect")
				.AddConsoleExporter()
				.Build();
		}
	}

	/// <summary>
	/// Metrics aspect.
	/// </summary>
	[Aspect(
		OnUsing   = nameof(OnUsing),
		OnFinally = nameof(OnFinally)
		)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	sealed class MetricsAttribute : Attribute
	{
		static readonly ActivitySource _activitySource = new("Sample.Aspect");

		public static Activity? OnUsing(InterceptInfo info)
		{
			var activity = _activitySource.StartActivity(info.MemberInfo.Name);

			info.Tag = activity;

			return activity;
		}

		public static void OnFinally(InterceptInfo info)
		{
			if (info is { Tag: Activity activity, Exception: var ex })
				activity.SetStatus(ex is null ? ActivityStatusCode.Ok : ActivityStatusCode.Error);
		}
	}

	/// <summary>
	/// IgnoreCatch aspect.
	/// </summary>
	[Aspect(
		OnCatch = nameof(OnCatch)
		)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	sealed class IgnoreCatchAttribute : Attribute
	{
		public static void OnCatch(InterceptInfo info)
		{
			info.InterceptResult = InterceptResult.IgnoreThrow;
		}
	}
}
