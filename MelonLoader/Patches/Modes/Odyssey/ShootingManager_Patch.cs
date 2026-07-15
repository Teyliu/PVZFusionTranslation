using HarmonyLib;
using Il2CppGameLevel.RogueShooting;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(ShootingManager))]
    public static class ShootingManager_Patch
    {
		[HarmonyPatch(nameof(ShootingManager.RegisterCoreBuff))]
		[HarmonyPatch(nameof(ShootingManager.RegisterExpertBuff))]
		[HarmonyPatch(nameof(ShootingManager.RegisterGetPlantBuff))]
		[HarmonyPatch(nameof(ShootingManager.RegisterOtherBuff))]
		[HarmonyPostfix]
		public static void UpgradeBuff(ShootingManager __instance, ref Il2Cpp.MultipleChoiceMenu menu)
        {
            MultipleChoiceMenu_Patch.Awake(menu);
        }

        public static void GetBuffs()
        {
            /*#region code

			AbyssSwordStar t0 = new();
			Bamboo t1 = new();
			BigChomper t4 = new();
			BigGatling t5 = new();
			CabbageCannon t6 = new();
			Cabbagepult t7 = new();
			Cactus t8 = new();
			Caltrop t9 = new();
			CaltropNut t10 = new();
			CattailLour t11 = new();
			CherryChomper t12 = new();
			CherryGatling t13 = new();
			CherrySquash t14 = new();
			Chomper t15 = new();
			Cornpult t17 = new();
			DoomCactus t20 = new();
			DoomChomper t21 = new();
			DoomSniper t22 = new();
			EmeraleBlover t23 = new();
			FireMelon t24 = new();
			FumeShroom t25 = new();
			GarlicFume t26 = new();
			GloomShroom t28 = new();
			GoldCabbage t29 = new();
			HelmetGatling t30 = new();
			HypnoEmperor t31 = new();
			HypnoNut t32 = new();
			HypnoShroom t33 = new();
			IceFumeShroom t34 = new();
			IcePuff t35 = new();
			IFVIronPuff t36 = new();
			IronPuff t37 = new();
			LanternSplit t38 = new();
			LanternUmbrella t39 = new();
			LaserUmbrella t40 = new();
			LotusBamboo t41 = new();
			Melonpult t42 = new();
			NuclearSquash t43 = new();
			ObsidianSpike t44 = new();
			ObsidianWallNut t45 = new();
			PeaMine t46 = new();
			Peashooter t47 = new();
			PortalCorn t48 = new();
			PotatoMine t49 = new();
			ScaredyDoom t54 = new();
			ScaredyShroom t55 = new();
			SmallPuff t57 = new();
			SniperPea t58 = new();
			SnowGatlingPuff t59 = new();
			SpikeRock t61 = new();
			Squalour t62 = new();
			Squash t63 = new();
			StarFruit t64 = new();
			SuperChomper t66 = new();
			SuperHypno t67 = new();
			SuperMelon t68 = new();
			SuperStar t69 = new();
			SuperThreePeater t70 = new();
			SwordStar t71 = new();
			TallNut t72 = new();
			ThreeMine t73 = new();
			ThreePeater t74 = new();
			ThreeSquash t75 = new();
			UltimateBamboo t76 = new();
			UltimateBigChomper t77 = new();
			UltimateBigGatling t78 = new();
			UltimateBlover t79 = new();
			UltimateCabbage t80 = new();
			UltimateCabbageCannon t81 = new();
			UltimateCactus t82 = new();
			UltimateChomper t83 = new();
			UltimateCorn t84 = new();
			UltimateDoomScared t85 = new();
			UltimateFume t86 = new();
			UltimateGatling t87 = new();
			UltimateGloom t88 = new();
			UltimateHelmetGatling t89 = new();
			UltimateHypno t90 = new();
			UltimateLanternSplit t91 = new();
			UltimateMelon t92 = new();
			UltimateMinigun t93 = new();
			UltimatePoisonFume t94 = new();
			UltimateSniperGatling t95 = new();
			UltimateSpring t96 = new();
			UltimateStar t97 = new();
			UltimateStarTorch t98 = new();
			UltimateTallNut t99 = new();
			UltimateWinterMelon t100 = new();
			Umbrellaleaf t101 = new();
			WallNut t103 = new();
			WinterMelon t104 = new();

			Dictionary<string, string> t = new();

			#region 3

			if(t0.Buffs != null)
			{
				Utils.TryAdd(t, t0.Role, t0.Role);
			}

			if(t1.Buffs != null)
			{
				Utils.TryAdd(t, t1.Role, t1.Role);
			}

			if(t4.Buffs != null)
			{
				Utils.TryAdd(t, t4.Role, t4.Role);
			}

			if(t5.Buffs != null)
			{
				Utils.TryAdd(t, t5.Role, t5.Role);
			}

			if(t6.Buffs != null)
			{
				Utils.TryAdd(t, t6.Role, t6.Role);
			}

			if(t7.Buffs != null)
			{
				Utils.TryAdd(t, t7.Role, t7.Role);
			}

			if(t8.Buffs != null)
			{
				Utils.TryAdd(t, t8.Role, t8.Role);
			}

			if(t9.Buffs != null)
			{
				Utils.TryAdd(t, t9.Role, t9.Role);
			}

			if(t10.Buffs != null)
			{
				Utils.TryAdd(t, t10.Role, t10.Role);
			}

			if(t11.Buffs != null)
			{
				Utils.TryAdd(t, t11.Role, t11.Role);
			}

			if(t12.Buffs != null)
			{
				Utils.TryAdd(t, t12.Role, t12.Role);
			}

			if(t13.Buffs != null)
			{
				Utils.TryAdd(t, t13.Role, t13.Role);
			}

			if(t14.Buffs != null)
			{
				Utils.TryAdd(t, t14.Role, t14.Role);
			}

			if(t15.Buffs != null)
			{
				Utils.TryAdd(t, t15.Role, t15.Role);
			}

			if(t17.Buffs != null)
			{
				Utils.TryAdd(t, t17.Role, t17.Role);
			}

			if(t20.Buffs != null)
			{
				Utils.TryAdd(t, t20.Role, t20.Role);
			}

			if(t21.Buffs != null)
			{
				Utils.TryAdd(t, t21.Role, t21.Role);
			}

			if(t22.Buffs != null)
			{
				Utils.TryAdd(t, t22.Role, t22.Role);
			}

			if(t23.Buffs != null)
			{
				Utils.TryAdd(t, t23.Role, t23.Role);
			}

			if(t24.Buffs != null)
			{
				Utils.TryAdd(t, t24.Role, t24.Role);
			}

			if(t25.Buffs != null)
			{
				Utils.TryAdd(t, t25.Role, t25.Role);
			}

			if(t26.Buffs != null)
			{
				Utils.TryAdd(t, t26.Role, t26.Role);
			}

			if(t28.Buffs != null)
			{
				Utils.TryAdd(t, t28.Role, t28.Role);
			}

			if(t29.Buffs != null)
			{
				Utils.TryAdd(t, t29.Role, t29.Role);
			}

			if(t30.Buffs != null)
			{
				Utils.TryAdd(t, t30.Role, t30.Role);
			}

			if(t31.Buffs != null)
			{
				Utils.TryAdd(t, t31.Role, t31.Role);
			}

			if(t32.Buffs != null)
			{
				Utils.TryAdd(t, t32.Role, t32.Role);
			}

			if(t33.Buffs != null)
			{
				Utils.TryAdd(t, t33.Role, t33.Role);
			}

			if(t34.Buffs != null)
			{
				Utils.TryAdd(t, t34.Role, t34.Role);
			}

			if(t35.Buffs != null)
			{
				Utils.TryAdd(t, t35.Role, t35.Role);
			}

			if(t36.Buffs != null)
			{
				Utils.TryAdd(t, t36.Role, t36.Role);
			}

			if(t37.Buffs != null)
			{
				Utils.TryAdd(t, t37.Role, t37.Role);
			}

			if(t38.Buffs != null)
			{
				Utils.TryAdd(t, t38.Role, t38.Role);
			}

			if(t39.Buffs != null)
			{
				Utils.TryAdd(t, t39.Role, t39.Role);
			}

			if(t40.Buffs != null)
			{
				Utils.TryAdd(t, t40.Role, t40.Role);
			}

			if(t41.Buffs != null)
			{
				Utils.TryAdd(t, t41.Role, t41.Role);
			}

			if(t42.Buffs != null)
			{
				Utils.TryAdd(t, t42.Role, t42.Role);
			}

			if(t43.Buffs != null)
			{
				Utils.TryAdd(t, t43.Role, t43.Role);
			}

			if(t44.Buffs != null)
			{
				Utils.TryAdd(t, t44.Role, t44.Role);
			}

			if(t45.Buffs != null)
			{
				Utils.TryAdd(t, t45.Role, t45.Role);
			}

			if(t46.Buffs != null)
			{
				Utils.TryAdd(t, t46.Role, t46.Role);
			}

			if(t47.Buffs != null)
			{
				Utils.TryAdd(t, t47.Role, t47.Role);
			}

			if(t48.Buffs != null)
			{
				Utils.TryAdd(t, t48.Role, t48.Role);
			}

			if(t49.Buffs != null)
			{
				Utils.TryAdd(t, t49.Role, t49.Role);
			}

			if(t54.Buffs != null)
			{
				Utils.TryAdd(t, t54.Role, t54.Role);
			}

			if(t55.Buffs != null)
			{
				Utils.TryAdd(t, t55.Role, t55.Role);
			}

			if(t57.Buffs != null)
			{
				Utils.TryAdd(t, t57.Role, t57.Role);
			}

			if(t58.Buffs != null)
			{
				Utils.TryAdd(t, t58.Role, t58.Role);
			}

			if(t59.Buffs != null)
			{
				Utils.TryAdd(t, t59.Role, t59.Role);
			}

			if(t61.Buffs != null)
			{
				Utils.TryAdd(t, t61.Role, t61.Role);
			}

			if(t62.Buffs != null)
			{
				Utils.TryAdd(t, t62.Role, t62.Role);
			}

			if(t63.Buffs != null)
			{
				Utils.TryAdd(t, t63.Role, t63.Role);
			}

			if(t64.Buffs != null)
			{
				Utils.TryAdd(t, t64.Role, t64.Role);
			}

			if(t66.Buffs != null)
			{
				Utils.TryAdd(t, t66.Role, t66.Role);
			}

			if(t67.Buffs != null)
			{
				Utils.TryAdd(t, t67.Role, t67.Role);
			}

			if(t68.Buffs != null)
			{
				Utils.TryAdd(t, t68.Role, t68.Role);
			}

			if(t69.Buffs != null)
			{
				Utils.TryAdd(t, t69.Role, t69.Role);
			}

			if(t70.Buffs != null)
			{
				Utils.TryAdd(t, t70.Role, t70.Role);
			}

			if(t71.Buffs != null)
			{
				Utils.TryAdd(t, t71.Role, t71.Role);
			}

			if(t72.Buffs != null)
			{
				Utils.TryAdd(t, t72.Role, t72.Role);
			}

			if(t73.Buffs != null)
			{
				Utils.TryAdd(t, t73.Role, t73.Role);
			}

			if(t74.Buffs != null)
			{
				Utils.TryAdd(t, t74.Role, t74.Role);
			}

			if(t75.Buffs != null)
			{
				Utils.TryAdd(t, t75.Role, t75.Role);
			}

			if(t76.Buffs != null)
			{
				Utils.TryAdd(t, t76.Role, t76.Role);
			}

			if(t77.Buffs != null)
			{
				Utils.TryAdd(t, t77.Role, t77.Role);
			}

			if(t78.Buffs != null)
			{
				Utils.TryAdd(t, t78.Role, t78.Role);
			}

			if(t79.Buffs != null)
			{
				Utils.TryAdd(t, t79.Role, t79.Role);
			}

			if(t80.Buffs != null)
			{
				Utils.TryAdd(t, t80.Role, t80.Role);
			}

			if(t81.Buffs != null)
			{
				Utils.TryAdd(t, t81.Role, t81.Role);
			}

			if(t82.Buffs != null)
			{
				Utils.TryAdd(t, t82.Role, t82.Role);
			}

			if(t83.Buffs != null)
			{
				Utils.TryAdd(t, t83.Role, t83.Role);
			}

			if(t84.Buffs != null)
			{
				Utils.TryAdd(t, t84.Role, t84.Role);
			}

			if(t85.Buffs != null)
			{
				Utils.TryAdd(t, t85.Role, t85.Role);
			}

			if(t86.Buffs != null)
			{
				Utils.TryAdd(t, t86.Role, t86.Role);
			}

			if(t87.Buffs != null)
			{
				Utils.TryAdd(t, t87.Role, t87.Role);
			}

			if(t88.Buffs != null)
			{
				Utils.TryAdd(t, t88.Role, t88.Role);
			}

			if(t89.Buffs != null)
			{
				Utils.TryAdd(t, t89.Role, t89.Role);
			}

			if(t90.Buffs != null)
			{
				Utils.TryAdd(t, t90.Role, t90.Role);
			}

			if(t91.Buffs != null)
			{
				Utils.TryAdd(t, t91.Role, t91.Role);
			}

			if(t92.Buffs != null)
			{
				Utils.TryAdd(t, t92.Role, t92.Role);
			}

			if(t93.Buffs != null)
			{
				Utils.TryAdd(t, t93.Role, t93.Role);
			}

			if(t94.Buffs != null)
			{
				Utils.TryAdd(t, t94.Role, t94.Role);
			}

			if(t95.Buffs != null)
			{
				Utils.TryAdd(t, t95.Role, t95.Role);
			}

			if(t96.Buffs != null)
			{
				Utils.TryAdd(t, t96.Role, t96.Role);
			}

			if(t97.Buffs != null)
			{
				Utils.TryAdd(t, t97.Role, t97.Role);
			}

			if(t98.Buffs != null)
			{
				Utils.TryAdd(t, t98.Role, t98.Role);
			}

			if(t99.Buffs != null)
			{
				Utils.TryAdd(t, t99.Role, t99.Role);
			}

			if(t100.Buffs != null)
			{
				Utils.TryAdd(t, t100.Role, t100.Role);
			}

			if(t101.Buffs != null)
			{
				Utils.TryAdd(t, t101.Role, t101.Role);
			}

			if(t103.Buffs != null)
			{
				Utils.TryAdd(t, t103.Role, t103.Role);
			}

			if(t104.Buffs != null)
			{
				Utils.TryAdd(t, t104.Role, t104.Role);
			}

			#endregion

			File.WriteAllText("tge_roles.json", FileLoader.SerializeWithIndentation(t));

            #endregion*/
        }
    }
}
