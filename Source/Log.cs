using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime.InteropTypes;

namespace PvZ_Fusion_Translator;

internal static partial class Log
{
    public static T Assert<T>(this T it, [CallerArgumentExpression(nameof(it))] string expression = "")
        where T : Il2CppObjectBase
    {
        switch (it)
        {
            case null:
                LogWarning($"{typeof(T).Name} is null: {expression}");
                break;
            case { ObjectClass: (nint)0 }:
                LogWarning($"{typeof(T).Name} is a null class: {expression}");
                break;
            case { Pointer: (nint)0 }:
                LogWarning($"{typeof(T).Name} points to null: {expression}");
                break;
            case { WasCollected: true }:
                LogWarning($"{typeof(T).Name} was garbage-collected: {expression}");
                break;
        }

        return it;
    }
}
