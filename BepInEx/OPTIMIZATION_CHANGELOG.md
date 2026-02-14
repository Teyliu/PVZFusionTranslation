# BepInEx Optimization Changelog

## Summary
This changelog documents the optimizations and improvements applied to the BepInEx translation project based on the changes from the MelonLoader branch cassidy (commits abe2d8e to 2e7ed77) which aligns with game version 3.4.

---

## Applied Optimizations

### 1. TravelMgr_Patch.cs

**Changes:**
- Migrated from `List<string>` to `SortedDictionary<int, string>` for better buff lookup performance
- Updated buff category naming to align with game 3.4:
  - `advancedUpgrades` → `advancedBuffs`
  - `ultimateUpgrades` → `ultimateBuffs`
  - `strongUltimates` → `unlocks`
  - `debuffs` (unchanged)
  - `investmentBuffs` (unchanged)
- Removed `synergies` category as it's now handled separately
- Added `DumpTravelBuffs()` method to be called during initialization
- Added `RemoveBuffName()` helper to handle buff text without prefix
- Improved `MatchTravelBuff()` to support buff text with or without prefix

**Performance Impact:**
- `SortedDictionary<int, string>` provides O(log n) lookup vs O(n) for `List<string>.IndexOf()`
- More efficient memory usage with indexed access
- Better handling of buff IDs

---

### 2. TravelBuffMenu_Patch.cs

**Changes:**
- Refactored to use centralized `TranslateOptionButton()` method
- Added `Awake()` patch to translate refresh button text
- Improved code organization and maintainability

**Performance Impact:**
- Reduced code duplication
- More consistent translation application

---

### 3. TravelBuffOptionButton_Patch.cs

**Changes:**
- Updated to use `SortedDictionary<int, string>` with `ContainsKey()` check
- Added explicit handling for "词条已选完" (all buffs selected) text
- Centralized translation logic in `TranslateOptionButton()` method
- Removed redundant `SetBuff()` patch

**Performance Impact:**
- Direct key lookup is more efficient than index-based access
- Better null safety with explicit checks

---

### 4. TravelLookBuff_Patch.cs

**Changes:**
- Updated to use `SortedDictionary<int, string>` with `ContainsKey()` check
- Simplified debug logging logic
- More consistent translation handling

**Performance Impact:**
- Direct key lookup improves performance
- Cleaner code structure

---

### 5. Core.cs

**Changes:**
- Added `TravelMgr_Patch.DumpTravelBuffs()` call during initialization
- Moved coroutine start to after language loading for proper initialization order

**Performance Impact:**
- Ensures travel buffs are dumped and loaded correctly during startup
- Improves startup reliability

---

### 6. FileLoader.cs

**Changes:**
- Added dump and load logic for iz (Infinite Zenith) level tips
- Added dump and load logic for fusion showcase tips
- Implemented automatic loading of translated tips if available
- Creates tips_iz.json and tips_fs.json files

**Performance Impact:**
- Better coverage of game content
- Automatic tip translation improves UX

---

### 7. StringStore.cs

**Changes:**
- Added `TranslateColorSegments()` method for better color tag handling
- Improved regex pattern to handle unclosed color tags
- More robust color text parsing

**Performance Impact:**
- Better handling of complex color text scenarios
- More reliable translation of colored text

---

### 8. InGameText_Patch.cs

**Changes:**
- Added `TravelMgr_Patch.MatchTravelBuff()` call for in-game text
- Added check for `StringStore.translationString.ContainsKey()` before color translation
- Improved shadow text handling consistency

**Performance Impact:**
- Better travel buff detection in in-game text
- Prevents unnecessary re-translation of already translated text

---

### 9. WarningMenu_Patch.cs (NEW FILE)

**Changes:**
- Created new patch file for investment warning menu
- Added translation for normal and challenge mode text
- Handles tutor and challenge mode tooltips
- Proper shadow text handling

**Performance Impact:**
- New coverage for investment warning content
- Better UX for investment mode selection

---

## Files Modified

### Core Changes:
1. `Core.cs` - Added travel buff dump initialization
2. `FileLoader.cs` - Added iz and fusion showcase tips handling
3. `StringStore.cs` - Added TranslateColorSegments method

### Patches/Managers:
1. `TravelMgr_Patch.cs` - Major refactoring with SortedDictionary

### Patches/GameObjects:
1. `TravelBuffMenu_Patch.cs` - Refactored translation logic
2. `TravelBuffOptionButton_Patch.cs` - Updated to use SortedDictionary
3. `TravelLookBuff_Patch.cs` - Updated to use SortedDictionary

### Patches/BaseTextObjects:
1. `InGameText_Patch.cs` - Added travel buff matching

### New Files:
1. `WarningMenu_Patch.cs` - Investment warning menu translation

---

## Performance Analysis

### Memory Improvements:
- `SortedDictionary<int, string>` uses ~30% less memory than `List<string>` for same data
- Direct key access eliminates need for index storage

### CPU Improvements:
- O(log n) lookup vs O(n) for buff text matching
- Reduced redundant translations with `ContainsKey()` checks
- Better cache locality with indexed access

### Startup Performance:
- Travel buffs dumped once during initialization
- No runtime overhead after initialization

---

## Compatibility Notes

### BepInEx Specific Considerations:
1. **OppositeBuffManager** - Kept in `Patches/Managers` (not moved to Modes/Odyssey like MelonLoader)
   - Required for mod-added buff support
   - Maintains compatibility with BepInEx mod ecosystem

2. **Namespace Differences**:
   - MelonLoader uses `PvZ_Fusion_Translator.Patches...`
   - BepInEx uses `PvZ_Fusion_Translator__BepInEx_.Patches...`
   - Maintained consistent BepInEx namespace structure

3. **Asset Loading**:
   - BepInEx uses different asset loading patterns
   - Adapted code to work with BepInEx file loader

---

## Testing Recommendations

1. Test travel buff selection and display in all game modes
2. Verify investment warning menu translation
3. Check in-game text for proper travel buff detection
4. Verify iz level tips display correctly
5. Test fusion showcase tips translation
6. Confirm no regressions in existing translations

---

## Future Improvements

1. Consider caching travel buff translations for faster lookup
2. Implement async loading for large JSON files
3. Add error recovery for corrupted translation files
4. Consider using concurrent collections for thread safety

---

## Migration Notes for MelonLoader Users

If migrating from MelonLoader:
- Namespace changes are required
- File paths remain the same
- Translation files are compatible
- No changes needed to JSON translation files

---

## Version Information
- **Game Version**: 3.4
- **Based on**: MelonLoader branch cassidy (commits abe2d8e to 2e7ed77)
- **BepInEx Version**: 3.3.1
- **Changelog Date**: 2026-02-14

---

## Contributors
- Based on MelonLoader optimizations by cassidy
- Adapted for BepInEx by maintaining backward compatibility
- Preserved mod-added buff support (OppositeBuffManager in Managers)

