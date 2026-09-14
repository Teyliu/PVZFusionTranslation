using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000219 RID: 537
[Token(Token = "0x2000219")]
public class BombCherry
{
	// Token: 0x0600093A RID: 2362 RVA: 0x000321EC File Offset: 0x000303EC
	[Token(Token = "0x600093A")]
	[Address(RVA = "0x86FF40", Offset = "0x86E540", VA = "0x18086FF40")]
	public void Explode(IDamageMaker damageMaker)
	{
		this.damageMaker = damageMaker;
		if (Lawnf.EveBalaced())
		{
			this.damageToPlant = (int)((ulong)80L);
		}
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
			this.damageToPlant = (int)((ulong)300L);
			this.sputtering = false;
		}
		if (this.team != Team.AI)
		{
			CherryBombType cherryBombType = this.bombType;
			bool flag2;
			if ((cherryBombType == CherryBombType.Bullet || cherryBombType == CherryBombType.BulletAll) && flag2)
			{
				uint num;
				this.damageToZombie = (int)num;
			}
			bool flag3;
			this.realCherry = flag3;
			if (flag3)
			{
				int num2 = this.damageToZombie;
				uint num3;
				this.damageToZombie = (int)num3;
			}
			CherryBombType cherryBombType2 = this.bombType;
			float num4;
			if (cherryBombType2 == CherryBombType.Bullet || cherryBombType2 == CherryBombType.BulletAll)
			{
				num4 = this.range;
			}
			this.Explode(num4);
		}
		Board board = this.board;
		Func<Zombie, bool> func;
		if (BombCherry.<>c.<>9__18_0 == 0)
		{
			BombCherry.<>c.<>9__18_0 = func;
		}
		List<Zombie> list;
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(list, func);
		int num5 = 0;
		bool flag4 = zombie;
		this.fragile = flag4;
		float num6 = this.range;
		this.ZombieExplode(num5, num6);
		int num7 = 0;
		this.board = num7;
		this.zombieAction = num7;
		this.targetPlant = num7;
		throw new NullReferenceException();
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00032300 File Offset: 0x00030500
	[Token(Token = "0x600093B")]
	[Address(RVA = "0x870E30", Offset = "0x86F430", VA = "0x180870E30")]
	private void PlantExplode()
	{
		CherryBombType cherryBombType = this.bombType;
		if ((cherryBombType == CherryBombType.Bullet || cherryBombType == CherryBombType.BulletAll) && Lawnf.TravelUltimate((UltiBuff)((uint)2)))
		{
			this.damageToZombie = (int)((uint)2);
		}
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)1013));
		this.realCherry = flag;
		if (flag)
		{
			int num = this.damageToZombie;
			this.damageToZombie = 1800;
		}
		CherryBombType cherryBombType2 = this.bombType;
		float num2;
		if (cherryBombType2 == CherryBombType.Bullet || cherryBombType2 == CherryBombType.BulletAll)
		{
			num2 = this.range;
		}
		this.Explode(num2);
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00032378 File Offset: 0x00030578
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x870210", Offset = "0x86E810", VA = "0x180870210")]
	private void Explode(float range)
	{
		AdvantureData data = AdvantureConfig.data;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			Collider2D collider2D = array[num3];
			bool flag;
			int num4;
			if (flag)
			{
				LayerMask contactCaptureLayers = collider2D.contactCaptureLayers;
				int mask = contactCaptureLayers.m_Mask;
				if (contactCaptureLayers != 0)
				{
					if (typeof(IChargeByFire).TypeHandle > (ulong)996L)
					{
						bool flag2;
						if (typeof(IChargeByFire).TypeHandle > (ulong)1164L)
						{
							if (typeof(IChargeByFire).TypeHandle == (ulong)1169L)
							{
								goto IL_00E2;
							}
							if (typeof(IChargeByFire).TypeHandle != (ulong)1243L)
							{
								goto IL_01FA;
							}
							flag2 = "{il2cpp field on {'IChargeByFire' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(CherryPot).TypeHandle;
							num2++;
							num3++;
						}
						if (flag2)
						{
							goto IL_00E2;
						}
						if (!flag2)
						{
							goto IL_01FA;
						}
						num2++;
						num3++;
					}
					bool flag3;
					if (flag3 > true)
					{
						if (!flag3 && !flag3)
						{
							goto IL_01FA;
						}
						num2++;
						num3++;
					}
					if (!flag3 && !flag3)
					{
						goto IL_01FA;
					}
					IL_00E2:
					num4 = 0;
					num2++;
					num3++;
				}
			}
			if (this.bombType != CherryBombType.Bullet && this.bombType != CherryBombType.BulletAll && collider2D.TryGetComponent<GridItem>(num4))
			{
				if (typeof(FreezedPlant).TypeHandle == (ulong)3L)
				{
					num2++;
					num3++;
				}
				if (typeof(FreezedPlant).TypeHandle != (ulong)8L)
				{
					goto IL_01FA;
				}
				bool flag4 = "{il2cpp field on {'FreezedPlant' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(FreezedPlant).TypeHandle;
				num2++;
				num3++;
			}
			if (collider2D.TryGetComponent<Zombie>(num4))
			{
				int num5 = 0;
				int num6 = this.damageToZombie;
				num6 -= num5;
				bool flag5;
				if (!flag5 || !this.bulletFromZombie)
				{
				}
				CherryBombType cherryBombType = this.bombType;
				if (typeof(global::UnityEngine.Object).TypeHandle != 0)
				{
					if (typeof(global::UnityEngine.Object).TypeHandle != 0)
					{
						bool flag6;
						if (typeof(global::UnityEngine.Object).TypeHandle != 0 && typeof(global::UnityEngine.Object).TypeHandle != 0 && cherryBombType == CherryBombType.Sun && flag6)
						{
							goto IL_01C1;
						}
						if (this.zombieAction == 0)
						{
							goto IL_01FA;
						}
					}
					bool flag7;
					if (!flag7)
					{
						goto IL_01FA;
					}
					IL_01C1:
					if (this.realCherry)
					{
						goto IL_01FA;
					}
					PlantType plantType = this.fromType;
					num2++;
					num3++;
				}
				CreateItem instance = CreateItem.Instance;
				bool flag8;
				if (flag8)
				{
					CreateItem instance2 = CreateItem.Instance;
					CreateItem instance3 = CreateItem.Instance;
				}
			}
			IL_01FA:
			num2++;
			num3++;
		}
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00032594 File Offset: 0x00030794
	[Token(Token = "0x600093D")]
	[Address(RVA = "0x870BB0", Offset = "0x86F1B0", VA = "0x180870BB0")]
	private void HandlePlants(Plant plant)
	{
		PlantType thePlantType = plant.thePlantType;
		if (thePlantType > PlantType.UltimateFireSeaShroom)
		{
			if (thePlantType > PlantType.CherryPumpkin)
			{
				if (thePlantType != PlantType.BigPumpkin)
				{
					if (thePlantType == PlantType.CherryPot)
					{
						return;
					}
					return;
				}
			}
			else if (thePlantType != PlantType.CherryNut)
			{
				while (thePlantType != PlantType.CherryPumpkin)
				{
				}
				return;
			}
		}
		else
		{
			int num;
			if (thePlantType > PlantType.CherryUltimatePumpkin)
			{
				if (thePlantType != PlantType.UltimateCattail)
				{
					while (thePlantType != PlantType.UltimateFireSeaShroom)
					{
					}
				}
				num = 0;
				if (num < plant)
				{
					num += num;
					num++;
				}
				num += 312;
			}
			if (num != 903)
			{
				while (num != 922)
				{
				}
			}
		}
		plant.FlashOnce();
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00032634 File Offset: 0x00030834
	[Token(Token = "0x600093E")]
	[Address(RVA = "0x870AC0", Offset = "0x86F0C0", VA = "0x180870AC0")]
	private void HandleGirdItem(GridItem gridItem)
	{
		GridItemType theItemType = gridItem.theItemType;
		if (theItemType == GridItemType.Ladder)
		{
			gridItem.Die();
			return;
		}
		while (theItemType != GridItemType.IceBlock)
		{
		}
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00032660 File Offset: 0x00030860
	[Token(Token = "0x600093F")]
	[Address(RVA = "0x871590", Offset = "0x86FB90", VA = "0x180871590")]
	private void ZombieExplode(Vector2 explosionPosition, float explosionRadius)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			Plant plant = this.targetPlant;
			int num3 = 0;
			if (!(plant != num3))
			{
				break;
			}
			Plant plant2 = this.targetPlant;
			if (GameAPP.config.difficulty != 5)
			{
				goto IL_014C;
			}
			int thePlantType = (int)this.targetPlant.thePlantType;
			bool flag;
			if (flag)
			{
				goto IL_014C;
			}
			Plant plant3 = this.targetPlant;
			if (plant3.thePlantType == PlantType.Firecracker || plant3.thePlantType == PlantType.CherryJalapeno)
			{
				goto IL_014C;
			}
			if ((this.sputtering ? 1 : 0) == num2)
			{
				goto IL_0154;
			}
			this.PlantTakeDamage(plant3);
			Plant plant4 = this.targetPlant;
			int thePlantRow = plant4.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(plant4.thePlantColumn, thePlantRow);
			bool flag2;
			if (flag2)
			{
				if (this.targetPlant == (ulong)1L)
				{
					this.PlantTakeDamage(num);
				}
				Plant plant5 = this.targetPlant;
				while (this != plant5.thePlantColumn)
				{
				}
				if (Lawnf.EveBalaced() || this.targetPlant != (ulong)1L)
				{
					continue;
				}
				this.PlantTakeDamage(num);
			}
		}
		while (num2 != 0);
		int mask = LayerMask.GetMask(new string[] { "Zombie", "Plant" });
		Collider2D[] array;
		if (num2 >= array.Length)
		{
			return;
		}
		bool flag3;
		if (!flag3 || !AoeDamage.InLandAoeRange((ZombieStatus)num2))
		{
			num2++;
			throw new NullReferenceException();
		}
		PlantType plantType = this.fromType;
		num2++;
		IL_014C:
		Plant plant6 = this.targetPlant;
		IL_0154:
		this.PlantTakeDamage(plant6);
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00032818 File Offset: 0x00030A18
	[Token(Token = "0x6000940")]
	[Address(RVA = "0x870EC0", Offset = "0x86F4C0", VA = "0x180870EC0")]
	private void PlantTakeDamage(Plant plant)
	{
		for (;;)
		{
			int num = 0;
			int num2 = this.damageToPlant;
			int thePlantType = (int)plant.thePlantType;
			bool flag;
			if (flag)
			{
				return;
			}
			int thePlantType2 = (int)plant.thePlantType;
			bool flag2;
			if (flag2)
			{
				return;
			}
			if ((this.fragile ? 1 : 0) != num)
			{
				Dictionary<EffectType, BaseEffect> effects = plant.effects;
				bool flag3;
				if (flag3)
				{
				}
			}
			bool flag4;
			if (flag4)
			{
			}
			Plant pumpkin = plant.Pumpkin;
			PlantType thePlantType3 = plant.thePlantType;
			if (thePlantType3 <= PlantType.CherryNut)
			{
				goto IL_010D;
			}
			if (thePlantType3 > PlantType.HelmetFume)
			{
				if (thePlantType3 > PlantType.IronCorn)
				{
					if (thePlantType3 > PlantType.IronSquash && (thePlantType3 == PlantType.HelmetGatling || thePlantType3 == PlantType.IronMelon))
					{
						goto IL_0174;
					}
					if (thePlantType3 == PlantType.CherryPot)
					{
					}
					if (plant == (ulong)1253L)
					{
						goto IL_0174;
					}
				}
				if (plant == (ulong)1164L)
				{
				}
				if (plant == (ulong)1169L)
				{
					goto IL_017E;
				}
				if (plant == (ulong)1211L)
				{
					goto IL_0174;
				}
			}
			bool flag5;
			if ((plant <= (ulong)1095L || (flag5 > true && plant != (ulong)1152L && flag5 > true)) && plant != (ulong)1020L && flag5 > true)
			{
				goto IL_010D;
			}
			goto IL_0174;
			IL_017E:
			if (plant != (ulong)911L)
			{
				break;
			}
			List<Plant> plants = MagnetSystem.GetPlants(plant);
			bool flag6;
			if (flag6)
			{
				plant.FlashOnce();
			}
			if (plant == 0)
			{
				break;
			}
			continue;
			IL_010D:
			if (plant <= (ulong)921L)
			{
				goto IL_017E;
			}
			if (plant > (ulong)940L)
			{
				if (plant > (ulong)985L)
				{
					if (plant == (ulong)991L)
					{
						goto IL_0174;
					}
					if (plant == (ulong)1003L)
					{
						goto IL_017E;
					}
				}
				if (plant == (ulong)942L || plant == (ulong)985L)
				{
					goto IL_0174;
				}
			}
			if (plant == (ulong)922L)
			{
				goto IL_017E;
			}
			if (plant != (ulong)935L && plant != (ulong)940L)
			{
				goto IL_01BD;
			}
			IL_0174:
			bool flag7;
			if (!flag7)
			{
				uint num3;
				num2 -= (int)num3;
				goto IL_017E;
			}
			return;
		}
		if (plant == (ulong)12L || plant == (ulong)301L || plant == (ulong)366L)
		{
			return;
		}
		IL_01BD:
		bool flag8;
		if (!flag8)
		{
		}
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x000329F4 File Offset: 0x00030BF4
	[Token(Token = "0x6000941")]
	[Address(RVA = "0x86FE50", Offset = "0x86E450", VA = "0x18086FE50")]
	private void ApplyDamage(Plant plant, int damage)
	{
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00032A08 File Offset: 0x00030C08
	[Token(Token = "0x6000942")]
	[Address(RVA = "0x86FEB0", Offset = "0x86E4B0", VA = "0x18086FEB0")]
	private bool CherryPumpkin(Plant plant)
	{
		int num = 0;
		if (plant != num)
		{
			PlantType thePlantType = plant.thePlantType;
			return thePlantType == PlantType.CherryUltimatePumpkin || thePlantType == PlantType.CherryPumpkin || thePlantType == PlantType.BigPumpkin;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00032A4C File Offset: 0x00030C4C
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x871BE0", Offset = "0x8701E0", VA = "0x180871BE0")]
	public BombCherry()
	{
	}

	// Token: 0x0400049F RID: 1183
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400049F")]
	[Header("爆炸配置")]
	public bool bulletFromZombie;

	// Token: 0x040004A0 RID: 1184
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004A0")]
	public Team team;

	// Token: 0x040004A1 RID: 1185
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004A1")]
	public CherryBombType bombType;

	// Token: 0x040004A2 RID: 1186
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004A2")]
	public PlantType fromType;

	// Token: 0x040004A3 RID: 1187
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004A3")]
	public int bombRow;

	// Token: 0x040004A4 RID: 1188
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004A4")]
	public IDamageMaker damageMaker;

	// Token: 0x040004A5 RID: 1189
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004A5")]
	[Header("爆炸范围")]
	public Vector2 bombPosition;

	// Token: 0x040004A6 RID: 1190
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004A6")]
	public int maxRow = (int)((ulong)1L);

	// Token: 0x040004A7 RID: 1191
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40004A7")]
	public float range = 1.5f;

	// Token: 0x040004A8 RID: 1192
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004A8")]
	public int damageToZombie = (int)((ulong)300L);

	// Token: 0x040004A9 RID: 1193
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004A9")]
	public Plant targetPlant;

	// Token: 0x040004AA RID: 1194
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004AA")]
	public Board board;

	// Token: 0x040004AB RID: 1195
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004AB")]
	public Action<Zombie> zombieAction;

	// Token: 0x040004AC RID: 1196
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004AC")]
	private int killCount;

	// Token: 0x040004AD RID: 1197
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40004AD")]
	private bool realCherry;

	// Token: 0x040004AE RID: 1198
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004AE")]
	private int damageToPlant = (int)((ulong)1000L);

	// Token: 0x040004AF RID: 1199
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40004AF")]
	private bool sputtering = true;

	// Token: 0x040004B0 RID: 1200
	[FieldOffset(Offset = "0x6D")]
	[Token(Token = "0x40004B0")]
	private bool fragile;
}
