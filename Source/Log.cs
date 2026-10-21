// ReSharper disable once RedundantUsingDirective
using System.Drawing;

namespace PvZ_Fusion_Translator;

internal static class Log
{
#if MELONLOADER
    public static void LogDebug(object txt) => Melon<Core>.Logger.Msg(ColorARGB.Gray, txt);

    public static void LogDebug(string txt) => Melon<Core>.Logger.Msg(ColorARGB.Gray, txt);

    public static void LogDebug(string txt, params object[] args) =>
        Melon<Core>.Logger.Msg(ColorARGB.Gray, txt, args);

    public static void LogInfo(object txt) => Melon<Core>.Logger.Msg(ColorARGB.Blue, txt);

    public static void LogInfo(string txt) => Melon<Core>.Logger.Msg(ColorARGB.Blue, txt);

    public static void LogInfo(string txt, params object[] args) =>
        Melon<Core>.Logger.Msg(ColorARGB.Blue, txt, args);

    public static void LogWarning(object txt) => Melon<Core>.Logger.Warning(txt);

    public static void LogWarning(string txt) => Melon<Core>.Logger.Warning(txt);

    public static void LogWarning(string txt, params object[] args) => Melon<Core>.Logger.Warning(txt, args);

    public static void LogError(object txt) => Melon<Core>.Logger.Error(txt);

    public static void LogError(string txt) => Melon<Core>.Logger.Error(txt);

    public static void LogError(string txt, params object[] args) => Melon<Core>.Logger.Error(txt, args);
#elif BEPINEX

    public static void LogDebug(object txt) => Core.Log.LogDebug(txt);

    public static void LogDebug(string txt) => Core.Log.LogDebug(txt);

    public static void LogDebug(string txt, params object[] args) => Core.Log.LogDebug(string.Format(txt, args));

    public static void LogInfo(object txt) => Core.Log.LogInfo(txt);

    public static void LogInfo(string txt) => Core.Log.LogInfo(txt);

    public static void LogInfo(string txt, params object[] args) => Core.Log.LogInfo(string.Format(txt, args));

    public static void LogWarning(object txt) => Core.Log.LogWarning(txt);

    public static void LogWarning(string txt) => Core.Log.LogWarning(txt);

    public static void LogWarning(string txt, params object[] args) => Core.Log.LogWarning(string.Format(txt, args));

    public static void LogError(object txt) => Core.Log.LogError(txt);

    public static void LogError(string txt) => Core.Log.LogError(txt);

    public static void LogError(string txt, params object[] args) => Core.Log.LogError(string.Format(txt, args));
#endif
}
