using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200021E RID: 542
[Token(Token = "0x200021E")]
public class BombCherry
{
	// Token: 0x06000950 RID: 2384 RVA: 0x00032008 File Offset: 0x00030208
	[Token(Token = "0x6000950")]
	[Address(RVA = "0x8FFC10", Offset = "0x8FE210", VA = "0x1808FFC10")]
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
			func = (Zombie a) => a.theStatus == ZombieStatus.Raised;
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

	// Token: 0x06000951 RID: 2385 RVA: 0x00032130 File Offset: 0x00030330
	[Token(Token = "0x6000951")]
	[Address(RVA = "0x900B10", Offset = "0x8FF110", VA = "0x180900B10")]
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

	// Token: 0x06000952 RID: 2386 RVA: 0x000321A8 File Offset: 0x000303A8
	[Token(Token = "0x6000952")]
	[Address(RVA = "0x8FFEE0", Offset = "0x8FE4E0", VA = "0x1808FFEE0")]
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
				if (this.zombieAction != 0)
				{
				}
				bool flag5;
				if (!flag5 || !this.bulletFromZombie)
				{
				}
				CherryBombType cherryBombType = this.bombType;
				if (typeof(global::UnityEngine.Object).TypeHandle != 0)
				{
					if (typeof(global::UnityEngine.Object).TypeHandle != 0)
					{
						if (typeof(global::UnityEngine.Object).TypeHandle == 0 || typeof(global::UnityEngine.Object).TypeHandle == 0 || cherryBombType != CherryBombType.Sun)
						{
							goto IL_01FA;
						}
						bool flag6;
						if (flag6)
						{
							goto IL_01C1;
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

	// Token: 0x06000953 RID: 2387 RVA: 0x000323C4 File Offset: 0x000305C4
	[Token(Token = "0x6000953")]
	[Address(RVA = "0x900890", Offset = "0x8FEE90", VA = "0x180900890")]
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

	// Token: 0x06000954 RID: 2388 RVA: 0x00032464 File Offset: 0x00030664
	[Token(Token = "0x6000954")]
	[Address(RVA = "0x9007A0", Offset = "0x8FEDA0", VA = "0x1809007A0")]
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

	// Token: 0x06000955 RID: 2389 RVA: 0x00032490 File Offset: 0x00030690
	[Token(Token = "0x6000955")]
	[Address(RVA = "0x901270", Offset = "0x8FF870", VA = "0x180901270")]
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

	// Token: 0x06000956 RID: 2390 RVA: 0x00032648 File Offset: 0x00030848
	[Token(Token = "0x6000956")]
	[Address(RVA = "0x900BA0", Offset = "0x8FF1A0", VA = "0x180900BA0")]
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

	// Token: 0x06000957 RID: 2391 RVA: 0x00032824 File Offset: 0x00030A24
	[Token(Token = "0x6000957")]
	[Address(RVA = "0x8FFB20", Offset = "0x8FE120", VA = "0x1808FFB20")]
	private void ApplyDamage(Plant plant, int damage)
	{
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00032838 File Offset: 0x00030A38
	[Token(Token = "0x6000958")]
	[Address(RVA = "0x8FFB80", Offset = "0x8FE180", VA = "0x1808FFB80")]
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

	// Token: 0x06000959 RID: 2393 RVA: 0x0003287C File Offset: 0x00030A7C
	[Token(Token = "0x6000959")]
	[Address(RVA = "0x9018C0", Offset = "0x8FFEC0", VA = "0x1809018C0")]
	public BombCherry()
	{
	}

	// Token: 0x040004A4 RID: 1188
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A4")]
	[Header("爆炸配置")]
	public bool bulletFromZombie;

	// Token: 0x040004A5 RID: 1189
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004A5")]
	public Team team;

	// Token: 0x040004A6 RID: 1190
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004A6")]
	public CherryBombType bombType;

	// Token: 0x040004A7 RID: 1191
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004A7")]
	public PlantType fromType;

	// Token: 0x040004A8 RID: 1192
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004A8")]
	public int bombRow;

	// Token: 0x040004A9 RID: 1193
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004A9")]
	public IDamageMaker damageMaker;

	// Token: 0x040004AA RID: 1194
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004AA")]
	[Header("爆炸范围")]
	public Vector2 bombPosition;

	// Token: 0x040004AB RID: 1195
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004AB")]
	public int maxRow = (int)((ulong)1L);

	// Token: 0x040004AC RID: 1196
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40004AC")]
	public float range = 1.5f;

	// Token: 0x040004AD RID: 1197
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004AD")]
	public int damageToZombie = (int)((ulong)300L);

	// Token: 0x040004AE RID: 1198
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004AE")]
	public Plant targetPlant;

	// Token: 0x040004AF RID: 1199
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004AF")]
	public Board board;

	// Token: 0x040004B0 RID: 1200
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004B0")]
	public Action<Zombie> zombieAction;

	// Token: 0x040004B1 RID: 1201
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004B1")]
	private int killCount;

	// Token: 0x040004B2 RID: 1202
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40004B2")]
	private bool realCherry;

	// Token: 0x040004B3 RID: 1203
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004B3")]
	private int damageToPlant = (int)((ulong)1000L);

	// Token: 0x040004B4 RID: 1204
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40004B4")]
	private bool sputtering = true;

	// Token: 0x040004B5 RID: 1205
	[FieldOffset(Offset = "0x6D")]
	[Token(Token = "0x40004B5")]
	private bool fragile;
}
