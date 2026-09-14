# MelonLoader Patches

> Child of `../AGENTS.md`; this file documents patch placement and local Harmony patterns only.

## Taxonomy

| Target | Folder | Examples |
|---|---|---|
| Generic text components | `BaseTextObjects/` | `TextMeshPro_Patch.cs`, `TextMeshProUGUI_Patch.cs`, `TMP_InputField_Patch.cs`, `TMP_Dropdown_Patch.cs`, `InGameText_Patch.cs` |
| Menus and UI objects | `GameObjects/` | Almanac, cards, menus, windows, board UI |
| Clickable controls | `GameObjects/ButtonObjects/` | navigation, option, save, and level-entry buttons |
| Small scene objects | `GameObjects/MinorObjects/` | plants, zombies, money, jigsaw pieces, player name |
| System controllers | `Managers/` | `UIMgr`, `TowerManager`, `Screen`, `SaveMenu`, `InGameUI` |
| Cross-cutting controllers | `OtherManagers/` | achievement, garden UI, menu text, thanks menu |

## Mode Patches

Mode-specific targets belong under `Modes/`, not in the general `GameObjects/` group.

- `Modes/Abyss/` -- Abyss menus, goods, buffs, settlement, level entry, and data.
- `Modes/Harvest/` -- garden and treasure menus, cards, equipment, stores, and manager hooks.
- `Modes/Odyssey/` -- travel menus, buffs, stores, synergy, and multiple-choice UI.
- `Modes/Starbound/` -- adventure menus, missions, evolution, stars, and help screens.
- `Modes/Super Editor/` -- custom-level and online-editor screens. The folder contains a space, while its namespace segment is `Super_Editor`.
  - `GameLevel/` -- level manager hooks.
  - `GameLevel/EventNodes/` -- runtime event-node editor and node UI.
  - `RhythmGame/` -- rhythm chart editor and rhythm manager.

## Canonical Patch Shape

```csharp
namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TargetClass))]
    public static class TargetClass_Patch
    {
        [HarmonyPatch(nameof(TargetClass.MethodName))]
        [HarmonyPostfix]
        private static void MethodName(TargetClass __instance)
        {
            // Translate target text after the game initializes it.
        }
    }
}
```

- Match the target type in the filename and class name: `TargetClass_Patch.cs` / `TargetClass_Patch`.
- Match namespaces to the logical folder under `PvZ_Fusion_Translator.Patches.*`; use `Super_Editor` for the literal `Super Editor` directory.
- Prefer `nameof(TargetClass.MethodName)` so target renames fail at compile time.
- Use a postfix after the game creates text. Use a prefix only when translation must alter or suppress input before the original method.
- Use Harmony parameters such as `__instance`, `__result`, and original argument names rather than global lookups when available.

## Translation Flow

- Translate text through `AssetStore.StringStore`; do not add private translation dictionaries to individual patches.
- Apply language fonts through `AssetStore.FontStore` when a target bypasses the generic TMP hooks.
- Let `BaseTextObjects/` handle ordinary TMP lifecycle translation; add a class-specific patch only for dynamically regenerated, formatted, or nested UI.
- Shared mode data commonly lives in public static fields on the owning patch class, such as translated buff or almanac caches. Keep ownership with the patch that loads the data.

## Placement Rules

- Put a target in `Managers/` when it coordinates scenes or systems; put a visual menu/window in `GameObjects/`.
- Use `ButtonObjects/` only for button subclasses and `MinorObjects/` for small reusable world/UI objects.
- Keep mode-owned classes in their mode directory even when the class name ends in `Menu` or `Manager`.
- Add every new patch to the explicit `<Compile Include="Patches\..."/>` list in the MelonLoader csproj.

## Avoid

- Do not copy a BepInEx patch verbatim; namespaces, IL2CPP types, loader APIs, and available targets differ.
- Do not duplicate a generic TMP translation hook in every screen patch.
- Do not move a mode patch into `GameObjects/` merely to flatten the tree.
- Do not retain stale target types after a game update; verify signatures against the current reference dump, then modify only this active patch tree.
