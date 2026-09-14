# MelonLoader Port

Entry: `Core.cs` (`Core : MelonMod`). Namespace: `PvZ_Fusion_Translator`.

## Lifecycle

MelonLoader calls these hooks in order:

1. `OnEarlyInitializeMelon()` -- currently empty
2. `OnInitializeMelon()` -- config, language load, store init (Texture, String, Audio, Font)
3. `OnLateInitializeMelon()` -- starts `TextureStore.ReplaceTexturesCoroutine()` via `MelonCoroutines`
4. `OnDeinitializeMelon()` -- stops coroutine, saves language, optional checksum export
5. `OnLateUpdate()` -- per-frame: debug features, hotkeys (Insert, PageUp), tower text updates
6. `OnGUI()` -- debug toast overlay

Harmony patches are auto-discovered. No manual registration. Patches live under `Patches/` and follow `*_Patch.cs` naming.

## Config

`MelonPreferences` category `"PvZ_Fusion_Translator"` with entries: `DefaultTextures`, `DefaultAudio`, `UseLocal`, `Language`. Saved to `UserData/MelonPreferences.cfg`.

## Where to Look

| What | Where |
|---|---|
| Entry point | `Core.cs` |
| Asset stores | `AssetStore/` -- 7 stores: Audio, CheckSum, Dll, Font, String, Texture, Warning |
| Utilities | `Utils.cs`, `FileLoader.cs`, `FontHandler.cs`, `Log.cs`, `ModFeatures.cs` |
| Patches | `Patches/{BaseTextObjects,GameObjects,Managers,Modes,OtherManagers}/` |
| Patch details | `Patches/AGENTS.md` |
| Translation data | `Strings/`, `Textures/`, `Audios/`, `Dumps/`, `Almanac/` |
| Embedded resources | `Resources/` (e.g. `ModUpdateUtil.exe`) |

## References

All game DLLs come from `$(GamePath)\MelonLoader\Il2CppAssemblies\`. MelonLoader runtime from `$(GamePath)\MelonLoader\net6\` (MelonLoader.dll, 0Harmony.dll, Il2CppInterop.*). AudioImportLib from `$(GamePath)\Mods\`.

## Conventions

- `GamePath` in csproj must match your local install. Edit before building.
- `EnableDefaultCompileItems=false`. Every `.cs` file needs an explicit `<Compile Include="..."/>` in the csproj. **Adding a file without updating the csproj breaks the build.**
- Configurations: `Debug`, `DebugEnglish`, `DebugObfuscate`, `DebugTesting`, `ReleaseMulti`, `ReleaseEnglish`, `ReleaseObfuscate`, `ReleaseOther`. Key defines: `MULTI_LANGUAGE`, `OBFUSCATE`, `CHEAT`, `TESTING`.
- `AllowUnsafeBlocks=true`, `LangVersion=latest`.

## PostBuild

Copies output DLL to 4 destinations: `$(GamePath)\Mods\`, `$(GamePath)\Translation Builds\`, and two local GitHub repo paths. These paths are developer-specific. Windows `COPY` command only.

## Anti-Patterns

- Do not add `.cs` files without editing the csproj `<Compile>` list.
- Do not assume BepInEx patches exist here. The two ports have different patch sets.
