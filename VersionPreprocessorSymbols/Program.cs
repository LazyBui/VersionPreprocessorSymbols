using System;

namespace VersionPreprocessorSymbols {
	internal static class Program {
		static void Main() {
			Identity();
			Console.WriteLine();
			Higher();
			Console.WriteLine();
			Lower();

			Console.WriteLine();
			Console.WriteLine("Press enter to continue. . .");
			Console.ReadLine();
		}

		private static void Identity() {
			#if NETFX_20
			Console.WriteLine("Current targeted framework is 2.0");
			#endif
			#if NETFX_30
			Console.WriteLine("Current targeted framework is 3.0");
			#endif
			#if NETFX_35
			Console.WriteLine("Current targeted framework is 3.5");
			#endif
			#if NETFX_40
			Console.WriteLine("Current targeted framework is 4.0");
			#endif
			#if NETFX_45
			Console.WriteLine("Current targeted framework is 4.5");
			#endif
			#if NETFX_451
			Console.WriteLine("Current targeted framework is 4.5.1");
			#endif
			#if NETFX_452
			Console.WriteLine("Current targeted framework is 4.5.2");
			#endif
			#if NETFX_46
			Console.WriteLine("Current targeted framework is 4.6");
			#endif
			#if NETFX_461
			Console.WriteLine("Current targeted framework is 4.6.1");
			#endif
			#if NETFX_462
			Console.WriteLine("Current targeted framework is 4.6.2");
			#endif
		}

		private static void Higher() {
			#if NETFX_20_OR_HIGHER
			Console.WriteLine("Current targeted framework is 2.0 or higher");
			#endif
			#if NETFX_20_HIGHER
			Console.WriteLine("Current targeted framework is higher than 2.0");
			#endif
			#if NETFX_30_OR_HIGHER
			Console.WriteLine("Current targeted framework is 3.0 or higher");
			#endif
			#if NETFX_30_HIGHER
			Console.WriteLine("Current targeted framework is higher than 3.0");
			#endif
			#if NETFX_35_OR_HIGHER
			Console.WriteLine("Current targeted framework is 3.5 or higher");
			#endif
			#if NETFX_35_HIGHER
			Console.WriteLine("Current targeted framework is higher than 3.5");
			#endif
			#if NETFX_40_OR_HIGHER
			Console.WriteLine("Current targeted framework is 4.0 or higher");
			#endif
			#if NETFX_40_HIGHER
			Console.WriteLine("Current targeted framework is higher than 4.0");
			#endif
			#if NETFX_45_OR_HIGHER
			Console.WriteLine("Current targeted framework is 4.5 or higher");
			#endif
			#if NETFX_45_HIGHER
			Console.WriteLine("Current targeted framework is higher than 4.5");
			#endif
			#if NETFX_451_OR_HIGHER
			Console.WriteLine("Current targeted framework is 4.5.1 or higher");
			#endif
			#if NETFX_451_HIGHER
			Console.WriteLine("Current targeted framework is higher than 4.5.1");
			#endif
			#if NETFX_452_OR_HIGHER
			Console.WriteLine("Current targeted framework is 4.5.2 or higher");
			#endif
			#if NETFX_452_HIGHER
			Console.WriteLine("Current targeted framework is higher than 4.5.2");
			#endif
			#if NETFX_46_OR_HIGHER
			Console.WriteLine("Current targeted framework is 4.6 or higher");
			#endif
			#if NETFX_46_HIGHER
			Console.WriteLine("Current targeted framework is higher than 4.6");
			#endif
			#if NETFX_461_OR_HIGHER
			Console.WriteLine("Current targeted framework is 4.6.1 or higher");
			#endif
			#if NETFX_461_HIGHER
			Console.WriteLine("Current targeted framework is higher than 4.6.1");
			#endif
			#if NETFX_462_OR_HIGHER
			Console.WriteLine("Current targeted framework is 4.6.2 or higher");
			#endif
			#if NETFX_462_HIGHER
			Console.WriteLine("Current targeted framework is higher than 4.6.2");
			#endif
		}

		private static void Lower() {
			#if NETFX_20_OR_LOWER
			Console.WriteLine("Current targeted framework is 2.0 or lower");
			#endif
			#if NETFX_20_LOWER
			Console.WriteLine("Current targeted framework is lower than 2.0");
			#endif
			#if NETFX_30_OR_LOWER
			Console.WriteLine("Current targeted framework is 3.0 or lower");
			#endif
			#if NETFX_30_LOWER
			Console.WriteLine("Current targeted framework is lower than 3.0");
			#endif
			#if NETFX_35_OR_LOWER
			Console.WriteLine("Current targeted framework is 3.5 or lower");
			#endif
			#if NETFX_35_LOWER
			Console.WriteLine("Current targeted framework is lower than 3.5");
			#endif
			#if NETFX_40_OR_LOWER
			Console.WriteLine("Current targeted framework is 4.0 or lower");
			#endif
			#if NETFX_40_LOWER
			Console.WriteLine("Current targeted framework is lower than 4.0");
			#endif
			#if NETFX_45_OR_LOWER
			Console.WriteLine("Current targeted framework is 4.5 or lower");
			#endif
			#if NETFX_45_LOWER
			Console.WriteLine("Current targeted framework is lower than 4.5");
			#endif
			#if NETFX_451_OR_LOWER
			Console.WriteLine("Current targeted framework is 4.5.1 or lower");
			#endif
			#if NETFX_451_LOWER
			Console.WriteLine("Current targeted framework is lower than 4.5.1");
			#endif
			#if NETFX_452_OR_LOWER
			Console.WriteLine("Current targeted framework is 4.5.2 or lower");
			#endif
			#if NETFX_451_LOWER
			Console.WriteLine("Current targeted framework is lower than 4.5.1");
			#endif
			#if NETFX_46_OR_LOWER
			Console.WriteLine("Current targeted framework is 4.6 or lower");
			#endif
			#if NETFX_46_LOWER
			Console.WriteLine("Current targeted framework is lower than 4.6");
			#endif
			#if NETFX_461_OR_LOWER
			Console.WriteLine("Current targeted framework is 4.6.1 or lower");
			#endif
			#if NETFX_461_LOWER
			Console.WriteLine("Current targeted framework is lower than 4.6.1");
			#endif
			#if NETFX_462_OR_LOWER
			Console.WriteLine("Current targeted framework is 4.6.2 or lower");
			#endif
			#if NETFX_462_LOWER
			Console.WriteLine("Current targeted framework is lower than 4.6.2");
			#endif
		}
	}
}