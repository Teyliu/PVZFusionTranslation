# PvZ Fusion Translator
PvZ Fusion Translator is a **Melon Mod** that allows for an easier method of translating the in-game UI, the Almanac, and textures.

# Installation
- Install [MelonLoader](https://melonwiki.xyz/#/modders/quickstart).
- Download and extract [AudioImportLib](https://thunderstore.io/c/bonelab/p/TrevTV/AudioImportLib/) to the `Mods` folder.
- [Download](https://github.com/Dynamixus/PvZ-Fusion-Translator/releases/latest) and extract everything to the `Mods` folder in your game's installation directory.

# Build
- Edit `GamePath` in `PvZ Fusion Translator.csproj` to point to your game installation folder.
- Proceed to `Build`.
- The built mod will automatically replace the current mod installed in your `Mods` directory.

# Translation
- Basic and regex string translation is available on the `Strings` folder.
- Texture replacements can be put inside the `Textures` folder, as long as the file is a `.PNG` file and the filename is an exact equivalent to an existing texture in the game.
- Almanac Translation can be done by editing the files in `Dumps` and putting the edited files in `Almanac`. Append `Translate` to the end of their file names (before the `.JSON`).

# Audio Replacing
- Same with texture replacements, put your replacement audio in the `Audios`

# Debug Features
- [Home] Reload Strings (Developer Build)
- [End] Reload Textures (Developer Build)

# Credits
- [蓝飘飘fly](https://space.bilibili.com/3546619314178489) - Game Developer
- [ArifRios1st](https://github.com/ArifRios1st/PVZ-Hyper-Fusion-Mod) - OG Mod Developer
- [TrevTV/MelonLoader-AudioTools](https://github.com/TrevTV/MelonLoader-AudioTools) - Audio Replacer Developer

# Contribution
If you'd like to contribute in any way, please join us on our [Discord](https://discord.gg/FTfz45NGxh).


