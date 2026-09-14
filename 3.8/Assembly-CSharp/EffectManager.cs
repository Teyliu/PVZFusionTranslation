using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public static class EffectManager
{
	// Token: 0x0600000D RID: 13 RVA: 0x00002204 File Offset: 0x00000404
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3A8670", Offset = "0x3A6C70", VA = "0x1803A8670")]
	public static bool SetEffect(this Plant plant, EffectType effectType, float duration = 1f, float value = 1f)
	{
		if (typeof(PlantRecoverEffect).TypeHandle <= (ulong)6L)
		{
			PlantFragileEffect plantFragileEffect;
			plantFragileEffect.first = true;
			plantFragileEffect.OnStart();
			plantFragileEffect.plant = plant;
			EffectType effectType2 = plantFragileEffect.EffectType;
			bool flag;
			if (flag)
			{
			}
			plantFragileEffect.extraDamageMultiplier = value;
			PlantPortalBalloonEffect plantPortalBalloonEffect;
			plantPortalBalloonEffect.first = true;
			plantPortalBalloonEffect.OnStart();
			plantPortalBalloonEffect.plant = plant;
			int effectType3 = (int)plantPortalBalloonEffect.EffectType;
			bool flag2;
			LotusFastShoot lotusFastShoot;
			if (flag2)
			{
				int num = 0;
				PlantCurseEffect plantCurseEffect;
				plantCurseEffect.first = true;
				int num2 = 0;
				plantCurseEffect.OnStart();
				num -= num2;
				int num3 = num.MultiplyPercent(value);
				plantCurseEffect.plant = plant;
				EffectType effectType4 = plantCurseEffect.EffectType;
				bool flag3;
				if (flag3)
				{
					float value2 = plantCurseEffect.Value;
				}
				plantCurseEffect.Value = 1f;
				PlantRecoverEffect plantRecoverEffect;
				plantRecoverEffect.first = true;
				plantRecoverEffect.OnStart();
				plantRecoverEffect.plant = plant;
				EffectType effectType5 = plantRecoverEffect.EffectType;
				bool flag4;
				if (flag4)
				{
					plantRecoverEffect.timer = flag4;
					PlantFireEffect plantFireEffect;
					plantFireEffect.first = true;
					plantFireEffect.OnStart();
					plantFireEffect.plant = plant;
					EffectType effectType6 = plantFireEffect.EffectType;
					bool flag5;
					if (flag5)
					{
					}
					plantFireEffect.blockCount = (int)((ulong)25L);
					EffectType effectType7 = new CherryFastShoot(plant, 1f, value)
					{
						plant = plant
					}.EffectType;
					bool flag6;
					if (flag6)
					{
						lotusFastShoot = new LotusFastShoot(plant, 1f, value);
						lotusFastShoot.plant = plant;
						EffectType effectType8 = lotusFastShoot.EffectType;
						bool flag7;
						if (flag7)
						{
						}
					}
					lotusFastShoot.Value = value;
				}
			}
			lotusFastShoot.during = 1f;
			if (lotusFastShoot != 0)
			{
				Dictionary<EffectType, BaseEffect> effects = plant.effects;
				lotusFastShoot.OnStart();
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3A8DC0", Offset = "0x3A73C0", VA = "0x1803A8DC0")]
	public static bool SetEffect(this Zombie zombie, EffectType effectType, float duration = 1f, float value = 1f)
	{
		if (effectType <= EffectType.Launch)
		{
			ColdEffect coldEffect;
			coldEffect.first = true;
			coldEffect.OnStart();
			coldEffect.zombie = zombie;
			EffectType effectType2 = coldEffect.EffectType;
			bool flag;
			if (flag)
			{
			}
			coldEffect.coldSpeed = value;
			coldEffect.duration = duration;
			zombie.coldSpeed = value;
			FreezeEffect freezeEffect;
			freezeEffect.first = true;
			freezeEffect.OnStart();
			freezeEffect.zombie = zombie;
			int effectType3 = (int)freezeEffect.EffectType;
			bool flag2;
			ImmuneEffect immuneEffect;
			if (flag2)
			{
				freezeEffect.iceTrap = effectType3;
				PoisonEffect poisonEffect;
				poisonEffect.first = true;
				poisonEffect.OnStart();
				poisonEffect.zombie = zombie;
				int effectType4 = (int)poisonEffect.EffectType;
				bool flag3;
				if (flag3)
				{
					poisonEffect.timer = flag3;
					PortalEffect portalEffect;
					portalEffect.first = true;
					portalEffect.OnStart();
					portalEffect.zombie = zombie;
					int effectType5 = (int)portalEffect.EffectType;
					bool flag4;
					if (flag4)
					{
						portalEffect.portalGlow = effectType5;
						ButterEffect butterEffect;
						butterEffect.first = true;
						butterEffect.OnStart();
						butterEffect.zombie = zombie;
						int effectType6 = (int)butterEffect.EffectType;
						bool flag5;
						if (flag5)
						{
							butterEffect.butter = effectType6;
						}
						int num = 0;
						if (effectType6 == 0)
						{
							butterEffect.duration = duration;
							ulong num2;
							butterEffect.showButter = num2 != 0UL;
						}
						int num3 = 0;
						butterEffect.duration = duration;
						butterEffect.showButter = num3 != 0;
						KelpEffect kelpEffect;
						kelpEffect.first = true;
						kelpEffect.OnStart();
						kelpEffect.zombie = zombie;
						kelpEffect.duration = duration;
						int effectType7 = (int)kelpEffect.EffectType;
						bool flag6;
						if (flag6)
						{
							kelpEffect.kelp = effectType7;
							kelpEffect.duration = (float)num;
						}
						zombie.kelpSpeed = 0.5f;
						immuneEffect.first = true;
						immuneEffect.OnStart();
						immuneEffect.zombie = zombie;
						int effectType8 = (int)immuneEffect.EffectType;
						bool flag7;
						if (flag7)
						{
						}
					}
				}
			}
			immuneEffect.duration = duration;
			IceDoomFreezeEffect iceDoomFreezeEffect;
			iceDoomFreezeEffect.first = true;
			iceDoomFreezeEffect.OnStart();
			iceDoomFreezeEffect.zombie = zombie;
			int effectType9 = (int)iceDoomFreezeEffect.EffectType;
			bool flag8;
			while (!flag8)
			{
			}
			LoveEffect loveEffect;
			loveEffect.first = true;
			loveEffect.OnStart();
			loveEffect.zombie = zombie;
		}
		bool flag9;
		int num4;
		uint num5;
		LaunchEffect launchEffect;
		if (flag9 && (num4 != 0 || num5 != (uint)0))
		{
			launchEffect.first = true;
			launchEffect.OnStart();
			EffectType effectType10 = launchEffect.EffectType;
			bool flag10;
			if (flag10)
			{
				launchEffect.state = flag10;
			}
			launchEffect.zombie = 0;
		}
		while (launchEffect == 0)
		{
		}
		launchEffect.OnStart();
		throw new NullReferenceException();
	}
}
