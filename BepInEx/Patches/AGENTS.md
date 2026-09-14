# BepInEx Patches -- AGENTS.md

> Child of `../AGENTS.md`. That file owns build commands, lifecycle, and global conventions.

## Patch Taxonomy

### BaseTextObjects/

Generic text hooks on base Unity/TMP components so every visible string gets translated regardless of which menu owns it.

- `TextMeshProUGUI_Patch.cs` / `TextMeshPro_Patch.cs` -- postfix on `OnEnable` and `Awake`. The main catch-all: calls `StringStore.TranslateText()` on instance text.
- `TMP_Dropdown_Patch.cs` / `TMP_InputField_Patch.cs` -- dropdown options and input field placeholders.
- `InGameText_Patch.cs` -- dynamically formatted in-game popups, warnings, and shadow text.

### GameObjects/

Patches for specific UI screens and interactive objects. Each file maps to one game menu or panel class.

- **ButtonObjects/** -- clickable buttons (`UIButton` subclasses, level enter buttons, nav buttons). Handle label translation and click-event wiring.
- **MinorObjects/** -- small scene objects with text: zombies, plants, money displays, jigsaw pieces, training dummies.

### Managers/

Patches for manager singletons and systems (`GameAPP`, `UIMgr`, `InGameUIMgr`, `TowerManager`, `TravelMgr`, etc.). Often hook `Update`, `Start`, or init methods to inject translation at the system level.

### Modes/

Mode-specific patches. BepInEx mode patches are sometimes flatter than MelonLoader's equivalent tree.

- **Odyssey/** -- one patch for the Odyssey multiple-choice menu.
- **Super Editor/** -- custom level editor: menu pages, online menu, zombie init, shooting.
  - **GameLevel/** -- level manager within Super Editor.
    - **EventNodes/** -- runtime event node editor and node UI.

### OtherManagers/

Miscellaneous patches that don't fit the main categories: `AchievementClip_Patch.cs`, `GardenUI_Patch.cs`, `MenuText_Patch.cs`, `ThanksMenu_Patch.cs`.

### Outdated/

Deprecated patches kept for reference. Contains `Playername_Patch.cs`. Don't add new patches here.

## Root-Level Files

- **AlmanacCompatibility.cs** -- not a Harmony patch. Defines local `PlantData`/`PlantInfo` types for backward compatibility with 3.5-era Almanac code. Uses `System.Text.Json` for IL2CPP.
- **HealthSlider_Patch.cs** -- patches `HealthSliderManager`, `BoardHealthSlider`, and `HealthSlider` across multiple namespaces in a single file. Handles font loading and text translation for health bars.

## Canonical Harmony Shape

```csharp
namespace PvZ_Fusion_Translator__BepInEx_.Patches.<SubFolder>
{
    [HarmonyPatch(typeof(TargetClass))]
    public static class TargetClass_Patch
    {
        [HarmonyPatch(nameof(TargetClass.MethodName))]
        [HarmonyPostfix]
        private static void Post_MethodName(TargetClass __instance)
        {
            // StringStore.TranslateText() + FontStore.LoadTMPFont()
        }
    }
}
```

- Class name: `TargetClass_Patch` (matches `*_Patch.cs` filename).
- Namespace: `PvZ_Fusion_Translator__BepInEx_.Patches.<SubFolder>` (double underscores in root).
- Use `[HarmonyPostfix]` for translation. Use `[HarmonyPrefix]` returning `bool` only to skip the original.
- Access the patched instance via `__instance`.

## Translation Flow

Call `StringStore.TranslateText(__instance)` or `StringStore.TranslateText(text)` to translate visible strings. Call `FontStore.LoadTMPFont(Utils.Language.ToString())` to swap the TMP font asset. Some patches also adjust `fontSize`/`fontSizeMin` for CJK text that needs more space.

## Adding a New Patch

1. Pick the subdirectory based on the target class (base text type, specific UI, manager, mode).
2. Create `TargetClass_Patch.cs` with the canonical shape above.
3. Add `<Compile Include="Patches\SubDir\TargetClass_Patch.cs"/>` in the csproj.
4. No registration needed. `Harmony.CreateAndPatchAll(Assembly)` discovers patches at startup.
