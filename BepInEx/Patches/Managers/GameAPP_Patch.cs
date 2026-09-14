using System;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(GameAPP))]
	public class GameAPP_Patch
    {
		[HarmonyPatch(nameof(GameAPP.Update))]
		[HarmonyPrefix]
		private static bool Update(GameAPP __instance)
		{
            try
            {
                if (PluginCore.Instance != null)
                {
                    PluginCore.Instance.OnUpdate();
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[GameAPP_Patch] OnUpdate error: {ex.Message}");
            }

            if (GameAPP.soundManager == null || GameAPP.soundManager.musicUpdater == null)
            {
                return false;
            }

            return true;
		}

		[HarmonyPatch(nameof(GameAPP.Update))]
		[HarmonyFinalizer]
		private static Exception Finalizer(Exception __exception)
		{
            if (__exception != null)
            {
                return null;
            }
            return null;
		}
	}

    [HarmonyPatch(typeof(MusicUpdater))]
    public static class MusicUpdater_Patch
    {
        [HarmonyPatch(nameof(MusicUpdater.MusicUpdate))]
        [HarmonyPrefix]
        private static bool MusicUpdate_Prefix(MusicUpdater __instance)
        {
            if (__instance == null || __instance.music == null)
                return false;

            if (Board.Instance == null)
            {
                __instance.musicVolume = 1f;
                __instance.needPlayDrum = false;
                __instance.drumVolume = 0f;
                __instance.keepDrumingTime = 0f;
                if (GameAPP.config != null)
                {
                    if (__instance.music != null)
                        __instance.music.volume = GameAPP.config.gameMusicVolume;
                    if (__instance.musicDrum != null)
                        __instance.musicDrum.volume = 0f;
                }
                return false;
            }
            return true;
        }

        [HarmonyPatch(nameof(MusicUpdater.MusicUpdate))]
        [HarmonyFinalizer]
        private static Exception MusicUpdate_Finalizer(Exception __exception)
        {
            if (__exception != null)
            {
                return null;
            }
            return null;
        }
    }
}