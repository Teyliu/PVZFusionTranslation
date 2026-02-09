# BepInEx Patches for PVZ Fusion Translation - Version 3.4

## Summary

This directory contains translation patches for BepInEx plugin for PVZ Fusion version 3.4.

## New Patches for Version 3.4

### UI/Menu Patches (Patches/GameObjects/)

| File Name | Description | Target Class |
|-----------|-------------|--------------|
| `OptionMenu_Patch.cs` | Options menu with settings toggles | `OptionMenu` |
| `WarningMenu_Patch.cs` | Challenge mode warning menu | `WarningMenu` |
| `TravelSynergyMenu_Patch.cs` | Synergy selection menu | `TravelSynergyMenu` |
| `InGame_openBag_Patch.cs` | In-game bag opening UI | `InGame_openBag` |
| `SynergyDisplay_Patch.cs` | Synergy display in-game UI | `SynergyDisplay` |

### Manager Patches (Patches/Managers/)

| File Name | Description | Target Class |
|-----------|-------------|--------------|
| `EventManager_Patch.cs` | Event system text handling | `EventManager` |

### Updated Patches

| File Name | Changes |
|-----------|---------|
| `TravelMgr_Patch.cs` | Added synergy data dumping to travel_buffs.json |

### Health System Patches (Patches/HealthSlider_Patch.cs)

| Patch Class | Description |
|-------------|-------------|
| `HealthSliderManager_Patch` | Health slider manager UI |
| `BoardHealthSlider_Patch` | Individual health slider UI |

## Translation JSON Files (Assets/Strings/[Language]/)

| File | Description |
|------|-------------|
| `warning_menu.json` | Warning menu strings |
| `synergy_menu.json` | Synergy menu strings (template) |
| `travel_buffs.json` | All travel buffs including synergies (auto-dumped) |

## New Features in Version 3.4

### Synergy System
- 18 new synergy types with descriptions
- Synergy names from `SynergyType` enum
- Synergy descriptions from `BaseSynergyData.GetAllData()` -> `SynergyLevelData.Description`

### Investment System (Already Handled)
- 42 investment buff classes
- Descriptions from `InvestBuff.ToString()`
- Added to `investmentBuffs` category in `travel_buffs.json`

### New UI Classes
- Option Menu: Settings toggles (strongUltiZombieInRandom, leaderInRandom, levelZombieInRandom, enableBossHealthSlider, autoEnterGame)
- Warning Menu: Challenge mode entry with Chinese text:
  - "再次点击挑战模式进入游戏" 
  - "请先通关普通模式"
- Synergy Display: In-game synergy UI overlay
- In-game Bag: Bag opening interface
- Health Slider: Boss health bar UI

## How Translation Works

### Synergy Data Flow
1. On `TravelMgr.get_Instance`, iterate through `TravelMgr.SynergysData`
2. For each `SynergyType`, call `GetSynergyDescription(BaseSynergyData)`
3. Extract `Description` from the last `SynergyLevelData` 
4. Add to `dumpedTravelBuffs["synergies"]` list
5. Save to `Assets/Strings/[Language]/travel_buffs.json`
6. Load translations from `travel_buffs.json` on startup
7. Match and translate via `TravelMgr_Patch.MatchTravelBuff()`

### UI Text Flow
1. On class `Awake()` or specific methods, load font and translation JSON
2. Translate all `TextMeshProUGUI` components
3. Apply font asset

## Patch Implementation Pattern

```csharp
[HarmonyPatch(typeof(ClassName))]
public static class ClassName_Patch
{
    [HarmonyPatch(nameof(ClassName.MethodName))]
    [HarmonyPostfix]
    private static void Post_MethodName(ClassName __instance)
    {
        TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
        
        foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
        {
            text.text = StringStore.TranslateText(text.text);
            text.font = fontAsset;
        }
    }
}
```

## Multi-Language Support

All patches support multiple languages via:
- `Utils.Language` enumeration
- `FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language)` for language-specific paths
- `FontStore.LoadTMPFont(Utils.Language.ToString())` for language-specific fonts

## Translation File Format

### warning_menu.json
```json
{
  "再次点击挑战模式进入游戏": "English translation",
  "请先通关普通模式": "English translation"
}
```

### travel_buffs.json (auto-generated)
```json
{
  "advancedUpgrades": ["text1", "text2", ...],
  "ultimateUpgrades": [...],
  "strongUltimates": [...],
  "debuffs": [...],
  "investmentBuffs": [...],
  "synergies": ["synergy_name", "synergy_description", ...]
}
```

## Notes

- Synergy descriptions are extracted from the last level of `GetAllData()` list
- Investment buff descriptions use `InvestBuff.ToString()` which returns the enum value (Chinese)
- All patches follow the existing codebase structure and naming conventions
- Font loading uses `FontStore.LoadTMPFont()` for TextMeshPro support
