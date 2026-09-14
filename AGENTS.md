# AGENTS.md - PvZ Fusion Translator

> Generated 2026-07-12. Commit d94d788, branch JustNull.
> Graph index: `PvZ-Fusion-Translator-2` (37,077 nodes, 141,992 edges).

## Overview

Dual .NET 6 Unity IL2CPP translator for Plants vs Zombies Fusion. Two independent loader targets share translation logic but have separate entry points, patch trees, and csproj files.

- **BepInEx port** -- `BepInEx/` directory, entry `BepInEx/Core.cs` (`PluginCore : BasePlugin`)
- **MelonLoader port** -- `MelonLoader/` directory, entry `MelonLoader/Core.cs` (`Core : MelonMod`)
- **Solution** -- `PvZ Fusion Translator.sln` includes both projects.

## Where to Look

| What | Where |
|---|---|
| Entry points | `BepInEx/Core.cs`, `MelonLoader/Core.cs` |
| Patch source | `BepInEx/Patches/`, `MelonLoader/Patches/` |
| Asset stores | `*/AssetStore/` (Font, Texture, String, Audio, Dll, CheckSum, Warning) |
| Shared utilities | `*/Utils.cs`, `*/FileLoader.cs`, `*/FontHandler.cs`, `*/Log.cs`, `*/ModFeatures.cs` |
| Translation data | `Strings/`, `Textures/`, `Audios/`, `Dumps/`, `Almanac/` (under each project) |
| Solution file | `PvZ Fusion Translator.sln` |

## Build

Both projects use `EnableDefaultCompileItems=false`. Every `.cs` file is explicitly listed as a `<Compile Include="..."/>` item in its csproj. **Adding a new source file requires editing the csproj.**

### Local GamePath

Each csproj references a local `GamePath` property pointing to a game install. These paths are developer-specific and must be edited before building.

- BepInEx: `<GamePath>` in `BepInEx/PvZ Fusion Translator [BepInEx].csproj`
- MelonLoader: `<GamePath>` in `MelonLoader/PvZ Fusion Translator [MelonLoader].csproj`

### Canonical Build Commands

```
dotnet build "BepInEx\PvZ Fusion Translator [BepInEx].csproj" -c ReleaseMulti
dotnet build "MelonLoader\PvZ Fusion Translator [MelonLoader].csproj" -c ReleaseMulti
```

PostBuild targets copy the output DLL directly into the live game folder. No separate deploy step.

### Configurations

`Debug`, `DebugEnglish`, `DebugMulti`, `DebugObfuscate`, `DebugTesting`, `ReleaseMulti`, `ReleaseEnglish`, `ReleaseObfuscate`, `ReleaseOther`. Key defines: `MULTI_LANGUAGE`, `OBFUSCATE`, `CHEAT`, `TESTING`.

## Testing

No automated tests, no CI. QA is manual: build, launch game, verify translated UI in-game.

## Conventions

- C# with `LangVersion=latest`, `AllowUnsafeBlocks=true`.
- Harmony patches follow `*_Patch.cs` naming.
- BepInEx patches live under `BepInEx/Patches/{BaseTextObjects,GameObjects,Managers,Modes,OtherManagers}/`.
- MelonLoader patches live under `MelonLoader/Patches/{BaseTextObjects,GameObjects,Managers,Modes,OtherManagers}/`.
- Children (`BepInEx/AGENTS.md`, `MelonLoader/AGENTS.md`, and their `Patches/` subdirs) document patch taxonomy and per-file details.

## Anti-Patterns

- **Do not** edit or build `3.8/` -- it is an untracked Cpp2IL reference tree.
- **Do not** treat `Trans_ML/`, `CustomizeLib.BepInEx/`, or `il2cpp-stringliteral-patcher/` as build targets. They are local gitignored reference copies.
- **Do not** add `.cs` files without updating the corresponding `<Compile>` list in csproj.
- **Do not** commit `bin/`, `obj/`, `.vs/`, `.omo/`, `.codebase-memory/` -- these are outputs and tool state.

## Gotchas

- The two projects have **different** patch sets. A patch in BepInEx does not imply one exists in MelonLoader and vice versa.
- `GamePath` is baked into the csproj. If your game is elsewhere, edit it before building or the build will fail on missing DLL references.
- PostBuild `COPY` commands are Windows-specific (`COPY`, not `cp`).
- The `3.5/`, `3.6.1/`, `3.7/` directories are also untracked reference trees alongside `3.8/`. Same rules apply.

## Agent skills

### Issue tracker

Issues live in GitHub Issues (Teyliu/PVZFusionTranslation). See `docs/agents/issue-tracker.md`.

### Triage labels

Default five canonical labels. See `docs/agents/triage-labels.md`.

### Domain docs

Single-context layout (`CONTEXT.md` + `docs/adr/`). See `docs/agents/domain.md`.
