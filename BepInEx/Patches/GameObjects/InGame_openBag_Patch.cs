using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(InGame_openBag))]
    public static class InGame_openBag_Patch
    {
        // ponytail: ShowText không tồn tại trên InGame_openBag/UIButton (3.8+3.9),
        // patch cũ làm Harmony.CreateAndPatchAll nổ -> Load abort -> font/string không init.
        // Giữ class rỗng để khỏi sửa csproj; dịch bag qua TextMeshProUGUI_Patch catch-all.
    }
}
