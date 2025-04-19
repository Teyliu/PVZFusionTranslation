using BepInEx.Logging;

namespace PvZ_Fusion_Translator__BepInEx_
{
	internal static class Log
	{
		private static readonly ManualLogSource Logger = BepInEx.Logging.Logger.CreateLogSource("PvZ_Fusion_Translator");

		public static void LogDebug(object txt) => Logger.LogDebug(txt);
		public static void LogDebug(string txt) => Logger.LogDebug(txt);
		public static void LogDebug(string txt, params object[] args) => Logger.LogDebug(string.Format(txt, args));

		public static void LogInfo(object txt) => Logger.LogInfo(txt);
		public static void LogInfo(string txt) => Logger.LogInfo(txt);
		public static void LogInfo(string txt, params object[] args) => Logger.LogInfo(string.Format(txt, args));

		public static void LogWarning(object txt) => Logger.LogWarning(txt);
		public static void LogWarning(string txt) => Logger.LogWarning(txt);
		public static void LogWarning(string txt, params object[] args) => Logger.LogWarning(string.Format(txt, args));

		public static void LogError(object txt) => Logger.LogError(txt);
		public static void LogError(string txt) => Logger.LogError(txt);
		public static void LogError(string txt, params object[] args) => Logger.LogError(string.Format(txt, args));
	}
}