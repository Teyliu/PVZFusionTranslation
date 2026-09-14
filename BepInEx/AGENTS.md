# BepInEx Port -- AGENTS.md

> Child of `../AGENTS.md`. That file owns build commands, global exclusions, and dual-port overview.

## Overview

BepInEx IL2CPP plugin for PvZ Fusion. Entry point is `PluginCore : BasePlugin` in `Core.cs`. The assembly name is `PvZ_Fusion_Translator__BepInEx_` (note the double underscores). Plugin GUID: `PVZFusionTranslator_BepInEx`.

## Where to Look

| What | Where |
|---|---|
| Entry point | `Core.cs` (`PluginCore.Load()` / `Unload()`) |
| Config bindings | `Core.cs` `LoadConfig()` via `BepInEx.Configuration.ConfigEntry<T>` |
| Coroutine helper | `Core.cs` `UnityCoroutineHelper : MonoBehaviour` (added via `AddComponent`) |
| Patch source | `Patches/` (subdirs: `BaseTextObjects/`, `GameObjects/`, `Managers/`, `Modes/`, `OtherManagers/`, `Outdated/`) |
| Patch details | `Patches/AGENTS.md` |
| Asset stores | `AssetStore/` -- 7 stores: `AudioStore`, `CheckSumStore`, `DllStore`, `FontStore`, `StringStore`, `TextureStore`, `WarningStore` |
| Utilities | `Utils.cs`, `FileLoader.cs`, `FontHandler.cs`, `Log.cs`, `ModFeatures.cs` |
| Translation data | `Strings/`, `Textures/`, `Audios/`, `Dumps/`, `Almanac/` (subdirs of `modsDirectory`) |
| Historical port notes | `PLAN.md` (3.7 port plan, not authoritative for current code) |
| NuGet sources | `nuget.bepinex.dev`, `nuget.samboy.dev` (see `RestoreAdditionalProjectSources` in csproj) |

## Plugin Lifecycle

`PluginCore.Load()` runs at startup:
1. Sets `Instance`, `Log`, loads config via `Config.Bind`
2. Adds `UnityCoroutineHelper` component for coroutines and `Update()` loop
3. Calls `Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly())` -- patches self-register
4. Initializes all stores: `AudioStore`, `TextureStore`, `StringStore`, `FontStore`
5. Starts `TextureStore.ReplaceTexturesCoroutine()` for async texture replacement

`PluginCore.Unload()` stops the coroutine and saves language preference. `OnUpdate()` handles hotkeys (semicolon = reload strings, Insert = open save dir, Delete = open online almanac).

## Conventions

- Namespace: `PvZ_Fusion_Translator__BepInEx_` (all patches and utilities use this).
- Config category: `"PvZ_Fusion_Translator"` with keys `DefaultTextures`, `DefaultAudio`, `Language`, `UseLocal`, `EnableDllUpdate`.
- Logging: use `Log.LogInfo()` / `Log.LogError()` etc. from `Log.cs` (wraps `BepInEx.Logging.ManualLogSource`).
- Harmony patches: `*_Patch.cs` naming, placed under `Patches/` subdirectories.
- Each `.cs` file must appear as a `<Compile Include="..."/>` in the csproj.
- References to game DLLs use `$(GamePath)\BepInEx\interop\` and `$(GamePath)\BepInEx\core\`.
- PostBuild copies the DLL to `$(GamePath)\BepInEx\plugins`.

## Anti-Patterns

- **Do not** add a `.cs` file without editing the `<Compile>` list in `PvZ Fusion Translator [BepInEx].csproj`.
- **Do not** use `PluginCore.Instance` before `Load()` finishes -- `IsInitialized` guards exist.
- **Do not** duplicate root AGENTS.md content here. Refer to it instead.
- **Do not** treat `PLAN.md` as current authority. It documents the 3.7 port effort, not ongoing rules.
- **Do not** copy MelonLoader patches directly. The two ports have different patch sets and class hierarchies.
