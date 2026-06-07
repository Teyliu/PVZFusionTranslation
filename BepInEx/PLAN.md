# Kế hoạch Port BepInEx -> 3.7

## Phát hiện từ phân tích

### Nguyên nhân lỗi build
| Type bị lỗi | Vị trí thực tế | Handler |
|---|---|---|
| `InGameText` | **Core.dll** (namespace `Core`) – file `Assets/Scripts/Core/InGameText.cs` | Thêm reference `Core.dll` + `global::Core.InGameText` |
| `OppositeBuffManager` | REMOVED – thay bằng `OppsiteBuff` (typo, static class) | Comment patch cũ + tạo OppsiteBuff_Patch mới |
| `ShootingMenu` | REMOVED – thay bằng `PlayerShootingMenu` | Xoá file, PlayerShootingMenu_Patch đã có |
| `ShootingSelectWindow` | REMOVED – thay bằng `PlayerShootingWindow` | Xoá file, PlayerShootingWindow_Patch đã có |
| `CreatePlayerSaveMenu` | REMOVED | Xoá file |
| `Almanac.OldAlmanac` method | REMOVED | Xoá method patch |

---

## A. Sửa build error (6 items)

### A1. `.csproj` – thêm `Core.dll` reference
Thêm vào block `<ItemGroup>`:
```xml
<Reference Include="Core">
  <HintPath>$(GamePath)\BepInEx\interop\Core.dll</HintPath>
</Reference>
```

Xoá 3 dòng `<Compile>`:
- `CreatePlayerSaveMenu_Patch.cs` (line 184)
- `ShootingMenu_Patch.cs` (line 221)
- `ShootingSelectWindow_Patch.cs` (line 222)

Sau đó thêm ~12 dòng `<Compile>` cho file mới ở B.

### A2. `BepInEx/Patches/BaseTextObjects/InGameText_Patch.cs`
Đổi tất cả `InGameText` → `global::Core.InGameText` (5-6 chỗ)

### A3. `BepInEx/Patches/GameObjects/Almanac_Patch.cs`
Xoá method `OldAlmanac` (line 17-22)

### A4. Xoá `BepInEx/Patches/GameObjects/CreatePlayerSaveMenu_Patch.cs`

### A5. Xoá `BepInEx/Patches/GameObjects/ShootingMenu_Patch.cs`

### A6. Xoá `BepInEx/Patches/GameObjects/ShootingSelectWindow_Patch.cs`

### A7. `BepInEx/Patches/Managers/OppositeBuffManager_Patch.cs`
Comment `[HarmonyPatch(typeof(OppositeBuffManager))]` + toàn bộ method `Awake`.

---

## B. Tạo patch mới (12 file + OppsiteBuff_Patch)

### B1. `OppsiteBuff_Patch.cs`
Patch `ShowConfig(Board)` và `ShowChoice()` – text hardcode đi qua InGameText.Instance.ShowText nên InGameText_Patch sẽ dịch. Patch này đảm bảo font được set.

### B2. `LevelResultMenu_Patch.cs`
18+ fields: `sampleTitle`, `sampleText`, `resultText`, `durationText`, `realdurationText`, `waveText`, `zombiesKilledText`, `zombiesMindControlledText`, `zombieDamageText`, `plantsPlantedText`, `plantsDeathText`, `plantsShoveledText`, `finalSunText`, `sunProducedText`, `sunConsumedText`, `finalMoneyText`, `moneyEarnedText`, `moneyConsumedText`, `mowerUsedText`
Methods: `Start`, `ShowResult`, `ShowGameResult`, `ShowDuration`, `ShowWaveInfo`, `ShowCombatStats`, `ShowPlantStats`, `ShowResourceStats`, `ShowPenaltyStats`, `ShowOther`

### B3. `TowerUpgradeMenu_Patch.cs`
`SetText()`, `Awake`, `Start`, `Select1/2/3`

### B4. `AlmanacBuffMenu_Patch.cs`
`InitXxxBuffs()` methods calling `TravelMgr.Instance.GetText()`

### B5. `ReNameMenu_Patch.cs`
`SetTitle()`, `SetInputText()`

### B6. `LevelSaveEnter_Patch.cs`
`InitEnter()`

### B7. `RogueSelectMenu_Patch.cs`
`ShowCards()`

### B8. `RogueCrisisMenu_Patch.cs`
`ShowCrisis()`

### B9. `TheCard_Patch.cs`
`costText` field

### B10. `CardWithDamage_Patch.cs`
`totalDamage` field

### B11. `PropCard_Patch.cs`
`countText` field

### B12. `InGameUI_IZ_Patch.cs`
`Update()`, `ShowZombieCard()`

Mỗi file mới cần thêm `<Compile Include="..." />` trong `.csproj`.

---

## C. Review file đã tồn tại

| File | Cần verify |
|---|---|
| `PlayerShootingMenu_Patch` | Update/Refresh methods exist |
| `PlayerShootingWindow_Patch` | SetType/OnAnimOver methods exist |
| `MultipleChoiceMenu_Patch` | Method names match 3.7 |
| `SaveMenu_Patch` | Method names match 3.7 |
| `SaveMenuBtn_Patch` | Method names match 3.7 |
| `TravelBuffMenu_Patch` | Methods exist |
| `TravelRefresh_Patch` | Methods exist |
| `TravelLookMenu_Patch` | Methods exist |
| `TravelLookBuff_Patch` | Methods exist |
| `TravelBuffOptionButton_Patch` | Methods exist |
| `SynergyDisplay_Patch` | Methods exist |
| `SynergyNode_Patch` | Methods exist |
| `AlmanacPlantMenu_Patch` | Methods exist |
| `AlmanacZombieMenu_Patch` | Methods exist |
| `AlmanacPlantWindow_Patch` | Methods exist |
| `AlmanacZombieWindow_Patch` | Methods exist |
| `RogueStartMenu_Patch` | Methods exist |
| `RogueCardWindow_Patch` | Methods exist |
| `AdvantureEvolutionMenu_Patch` | Methods exist |
| `AdvantureMissionMenu_Patch` | Methods exist |
| `AdvantureHelpMenu_Patch` | Methods exist |
| `AdvantureStarMenu_Patch` | Methods exist |
| `Plant_Patch` (UpdateText/InitText) | Methods exist |
| `Zombie_Patch` (UpdateHealthText/InitHealth) | Methods exist |
| `HealthSlider_Patch` | Methods exist |
| `InGameUI_Patch` | Methods exist |
| `LoseMenu_Patch` | Methods exist |
| `MainMenu_Patch` | Methods exist |
| `PlantInfoWindow_Patch` | Methods exist |
| `PlantDamageMenu_Patch` | Methods exist |
| `BaseMenu_Patch` | Methods exist |
| `TravelStore_Patch` | Methods exist |
| `TravelStoreWindow_Patch` | Methods exist |
| `RuntimeEventNodeEditor_Patch` | Methods exist |
| `RuntimeNodeUI_Patch` | Methods exist |
| `TextMeshPro_Patch` | Methods exist |
| `TextMeshProUGUI_Patch` | Methods exist |
| `TMP_InputField_Patch` | Methods exist |
| `TMP_Dropdown_Patch` | Methods exist |

---

## D. Build

```powershell
dotnet build "BepInEx\PvZ Fusion Translator [BepInEx].csproj" -c ReleaseMulti
```

Build pass = hoàn thành. Nếu lỗi compile → sửa theo file lỗi.
