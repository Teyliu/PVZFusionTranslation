# PvZ Fusion Translator - Online Sync/Fetch System

## Tổng quan

Hệ thống Online Sync/Fetch cho phép mod tự động tải dữ liệu dịch thuật từ GitHub repository online thay vì sử dụng file local. Người dùng có thể chuyển đổi giữa chế độ Online và Local thông qua nút "SwapLocal" trong menu Options.

## Cấu trúc thư mục dữ liệu

```
PvZ_Fusion_Translator/
├── Localization/{Language}/
│   ├── Strings/
│   │   ├── translation_strings.json    # Dịch thuật text thông thường
│   │   ├── translation_regexs.json     # Dịch thuật theo regex pattern
│   │   ├── travel_buffs.json           # Dịch thuật buffs trong Odyssey
│   │   ├── abyss_buffs.json            # Dịch thuật buffs trong Abyss
│   │   ├── changelog.txt               # Nội dung changelog
│   │   ├── tips_iz.json                # Tips cho Infinity Zone
│   │   ├── tips_fs.json                # Tips cho Fusion Showcase
│   │   ├── custom_level_data.json      # Dịch thuật tên level tùy chỉnh
│   │   └── abyss_buffs.json            # Buff data cho Abyss mode
│   └── Almanac/
│       ├── LawnStringsTranslate.json    # Dịch thuật cây trồng
│       └── ZombieStringsTranslate.json # Dịch thuật zombie
```

## URL API Online

Tất cả dữ liệu được tải từ:
```
https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Language}/
```

## Các thành phần chính

### 1. Utils.cs - HTTP Client

**Methods:**
- `GetDataFromWeb(string url)` - Tải text content từ URL
- `GetImageDataFromWeb(string url)` - Tải binary image data từ URL
- `useLocal` - Biến boolean kiểm tra chế độ sử dụng local (false = online, true = local)
- `WarnLocalData()` - In log khi chuyển đổi chế độ
- `ToggleNames` - Dictionary mapping toggle enum sang tên hiển thị

**Sử dụng:**
```csharp
string content = await Utils.GetDataFromWeb(url);
if (content != null)
{
    // Xử lý dữ liệu
}
```

### 2. FileLoader.cs - Quản lý tải dữ liệu

**Load order:**
1. `LoadStrings()` - Tải translation_strings.json và translation_regexs.json
2. `LoadTravelBuffs()` - Tải travel_buffs.json (Online với fallback Local)
3. `LoadAlmanac()` - Tải LawnStringsTranslate.json và ZombieStringsTranslate.json (Online với fallback Local)
4. `LoadChangelogText()` - Tải changelog.txt (Online với fallback Local)
5. `LoadIZStrings()` - Tải tips cho Infinity Zone
6. `LoadFSStrings()` - Tải tips cho Fusion Showcase

**Online loading logic:**
```csharp
if (!Utils.useLocal)
{
    // Thử tải từ online trước
    string content = Utils.GetDataFromWeb(url).Result;
    if (content != null)
    {
        data = content;
    }
    else
    {
        // Fallback sang local
        if (File.Exists(localPath))
        {
            data = File.ReadAllText(localPath);
        }
    }
}
else
{
    // Chỉ sử dụng local
    data = File.ReadAllText(localPath);
}
```

### 3. Core.cs - Config

**Config entries:**
- `configUseLocal` - Boolean, mặc định `false`. Nếu `true` sẽ bỏ qua tất cả online fetching và chỉ dùng local files.

### 4. OptLanguageBtn_Patch.cs - UI Toggle

**Toggle buttons:**
1. **Textures** - Chuyển đổi giữa Default/Custom textures
2. **Audio** - Chuyển đổi giữa Default/Custom audio
3. **SwapLocal** - Chuyển đổi giữa Online/Local translation mode

**Vị trí các nút:**
- Languages: 6 nút (5 languages + Next button)
- Toggles: 3 nút (Textures, Audio, SwapLocal)

## Các patches sử dụng Online Data

### TravelBuffs (Odyssey)
- **File:** `TravelMgr_Patch.cs`
- **Loaded in:** `FileLoader.LoadTravelBuffs()`
- **URL:** `.../Strings/travel_buffs.json`

### Abyss Buffs
- **File:** `AbyssBuffMenu_Patch.cs`
- **Loaded in:** `FileLoader.LoadStrings()` (khi load file kết thúc bằng "abyss_buffs")
- **URL:** `.../Strings/abyss_buffs.json`

### Almanac (Plants & Zombies)
- **Files:** `AlmanacPlantMenu_Patch.almanacJson`, `AlmanacZombieMenu_Patch.almanacJson`
- **Loaded in:** `FileLoader.LoadAlmanac()`
- **URLs:** 
  - `.../Almanac/LawnStringsTranslate.json`
  - `.../Almanac/ZombieStringsTranslate.json`
  - `.../Almanac/ModdedPlantsTranslate.json` (optional, merge with main almanac)
  - `.../Almanac/ModdedZombiesTranslate.json` (optional, merge with main almanac)

**Modded Plants/Zombies:**
- Modded data được merge vào cuối file almanac chính (nối thêm "\n" + moddedContent)
- Thứ tự ưu tiên: Online Modded → Local Modded → (bỏ qua nếu không có)
- Fallback: Nếu online fail hoặc không có, thử load từ local file

### Changelog
- **File:** `NoticePauseMenu_Patch.changelogText`
- **Loaded in:** `FileLoader.LoadChangelogText()`
- **URL:** `.../Strings/changelog.txt`

### Custom Level Data (Super Editor)
- **File:** `CustomLevelMenu_Patch.translatedLevelData`
- **Loaded in:** `CustomLevelMenu_Patch.LoadOnlineData()` / `LoadLocalData()`
- **URL:** `.../Strings/custom_level_data.json`

### IZ/FS Tips
- **Files:** `StringStore.izTipCollectionString`, `StringStore.fsTipCollectionString`
- **Loaded in:** `FileLoader.LoadIZStrings()`, `LoadFSStrings()`
- **URLs:**
  - `.../Strings/tips_iz.json`
  - `.../Strings/tips_fs.json`

## Flow tải dữ liệu khi khởi động

```
Core.Start()
  └─> FileLoader.Init()
        ├─> LoadStrings()
        │   └─> Load translation_strings.json, translation_regexs.json
        │       └─> Load travel_buffs, tips_iz, tips_fs, abyss_buffs (nếu có trong folder)
        │
        ├─> LoadTravelBuffs() [MULTI_LANGUAGE]
        │   └─> Online: Utils.GetDataFromWeb(travel_buffs.json)
        │       └─> Fallback: File.ReadAllText(local)
        │
        ├─> LoadAlmanac() [MULTI_LANGUAGE]
        │   ├─> Online: Utils.GetDataFromWeb(LawnStringsTranslate.json)
        │   │   └─> Fallback: File.ReadAllText(local)
        │   └─> Online: Utils.GetDataFromWeb(ZombieStringsTranslate.json)
        │       └─> Fallback: File.ReadAllText(local)
        │
        └─> TextureStore.Init()
            └─> FileLoader.LoadTextures()
                └─> TextureStore.ReplaceTexturesCoroutine()
```

## StringStore - Tip Dictionaries

**Thêm mới trong 4 commits:**
- `izLevelTipDictionary` - Mapping level name → tip (IZ)
- `izTipCollectionString` - Mapping original tip → translated tip (IZ)
- `fsLevelTipDictionary` - Mapping level name → tip (FS)
- `fsTipCollectionString` - Mapping original tip → translated tip (FS)

**Sử dụng trong TranslateText():**
```csharp
// Ưu tiên: translationString → izTipCollectionString → fsTipCollectionString → regex → original
if(translationString.ContainsKey(originalText))
    return translationString[originalText];
if(izTipCollectionString.ContainsKey(originalText))
    return izTipCollectionString[originalText];
if(fsTipCollectionString.ContainsKey(originalText))
    return fsTipCollectionString[originalText];
```

## Xử lý lỗi

Tất cả online requests đều có try-catch:
- Nếu online fail → Log warning → Fallback sang local
- Nếu local cũng fail → Tiếp tục mà không có data

## ModFeatures (Debug)

**Hotkeys:**
- `Home` - Reload Strings
- `End` - Reload Textures  
- `Minus` - Dump Travel Buffs (nếu có)

## Lưu ý quan trọng

1. **.Result blocking:** Các lời gọi `Utils.GetDataFromWeb().Result` sẽ block thread chính. Cân nhắc sử dụng async/await đầy đủ trong các phiên bản sau.

2. **Cooldown:** CustomLevelMenu có timer 5 giây giữa các lần request để tránh rate limit từ GitHub.

3. **Thread safety:** HttpClient nên được tái sử dụng thay vì tạo mới mỗi lần (hiện tại tạo mới mỗi lần).

4. **Fallback priority:** Online → Local → (optional: empty/default)

5. **Cache:** Dữ liệu được cache trong memory sau khi load lần đầu.
