using MelonLoader;
using System.Drawing;

namespace PvZ_Fusion_Translator
{
	internal static class Log
	{
		public static void LogDebug(object txt) => Melon<Core>.Logger.Msg(Color.Gray, txt);
		public static void LogDebug(string txt) => Melon<Core>.Logger.Msg(Color.Gray, txt);
		public static void LogDebug(string txt, params object[] args) => Melon<Core>.Logger.Msg(Color.Gray, txt, args);

		public static void LogInfo(object txt) => Melon<Core>.Logger.Msg(Color.Blue, txt);
		public static void LogInfo(string txt) => Melon<Core>.Logger.Msg(Color.Blue, txt);
		public static void LogInfo(string txt, params object[] args) => Melon<Core>.Logger.Msg(Color.Blue, txt, args);

		public static void LogWarning(object txt) => Melon<Core>.Logger.Warning(txt);
		public static void LogWarning(string txt) => Melon<Core>.Logger.Warning(txt);
		public static void LogWarning(string txt, params object[] args) => Melon<Core>.Logger.Warning(txt, args);

		public static void LogError(object txt) => Melon<Core>.Logger.Error(txt);
		public static void LogError(string txt) => Melon<Core>.Logger.Error(txt);
		public static void LogError(string txt, params object[] args) => Melon<Core>.Logger.Error(txt, args);
	}
}