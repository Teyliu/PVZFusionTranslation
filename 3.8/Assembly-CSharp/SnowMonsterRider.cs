using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C7 RID: 1735
[Token(Token = "0x20006C7")]
public class SnowMonsterRider : Zombie
{
	// Token: 0x0600221B RID: 8731 RVA: 0x000B30B8 File Offset: 0x000B12B8
	[Token(Token = "0x600221B")]
	[Address(RVA = "0x56E7D0", Offset = "0x56CDD0", VA = "0x18056E7D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)43L);
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x000B30D8 File Offset: 0x000B12D8
	[Token(Token = "0x600221C")]
	[Address(RVA = "0x56F590", Offset = "0x56DB90", VA = "0x18056F590")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = this.CrashEntity(collision, num != 0, 0.3f);
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x000B30F8 File Offset: 0x000B12F8
	[Token(Token = "0x600221D")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x000B3108 File Offset: 0x000B1308
	[Token(Token = "0x600221E")]
	[Address(RVA = "0x56E7F0", Offset = "0x56CDF0", VA = "0x18056E7F0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num5;
		do
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			num -= theDamage;
			int num2 = this.theMaxHealth;
			num2 -= theDamage;
			if (num < num2)
			{
				int num3 = 0;
				base.ChangeStatus((ZombieStatus)num3);
				this.anim.SetTrigger("jump");
			}
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)num5, (float)num4, gameObject);
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x000B3184 File Offset: 0x000B1384
	[Token(Token = "0x600221F")]
	[Address(RVA = "0x56F470", Offset = "0x56DA70", VA = "0x18056F470", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		int num = 0;
		int childCount = base.transform.childCount;
		if (num < childCount)
		{
			if (string.Equals(base.transform.GetChild(num).name, "LoseHead"))
			{
				Transform child = base.transform.GetChild(num);
				base.AnimLoseActive(child);
			}
			num++;
			Transform transform = base.transform;
		}
		GameObject gameObject = base.gameObject;
		base.FindAndDestoryZombieHead(gameObject);
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x000B31F8 File Offset: 0x000B13F8
	[Token(Token = "0x6002220")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000B3208 File Offset: 0x000B1408
	[Token(Token = "0x6002221")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x000B3224 File Offset: 0x000B1424
	[Token(Token = "0x6002222")]
	[Address(RVA = "0x56EE60", Offset = "0x56D460", VA = "0x18056EE60")]
	private void CrashPlant(Plant plant)
	{
		int num;
		int num2;
		for (;;)
		{
			int thePlantRow = plant.thePlantRow;
			int thePlantColumn = plant.thePlantColumn;
			List<Plant> list = Lawnf.Get1x1Plants(thePlantColumn, thePlantRow);
			if (thePlantColumn != 0)
			{
				break;
			}
			num = 0;
			List<Plant> list2 = Lawnf.Get1x1Plants(num, num2);
			bool flag;
			if (flag)
			{
				GameAPP.PlaySound(flag ? 1 : 0, 0.5f, 1f);
				if (num != 0)
				{
					CreatePlant instance = CreatePlant.Instance;
					bool flag2;
					while (!flag2)
					{
					}
				}
				uint num4;
				uint num5;
				int num3 = global::UnityEngine.Random.Range((int)num4, (int)num5);
			}
			if (num != 0)
			{
				goto IL_00EA;
			}
			num++;
			int num6 = 0;
			bool flag3;
			if (flag3)
			{
				GameAPP.PlaySound(flag3 ? 1 : 0, 0.5f, 1f);
				CreatePlant instance2 = CreatePlant.Instance;
				int num7 = 0;
				Plant plant2;
				if (!(plant2 == num7))
				{
					continue;
				}
				uint num9;
				uint num10;
				int num8 = global::UnityEngine.Random.Range((int)num9, (int)num10);
			}
			if (num6 == 0)
			{
				goto Block_6;
			}
		}
		uint num12;
		uint num13;
		int num11 = global::UnityEngine.Random.Range((int)num12, (int)num13);
		num2 = 0;
		plant.Crashed(num2, num11, this);
		return;
		Block_6:
		num++;
		throw new NullReferenceException();
		IL_00EA:
		throw new NullReferenceException();
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000B3328 File Offset: 0x000B1528
	[Token(Token = "0x6002223")]
	[Address(RVA = "0x56E9B0", Offset = "0x56CFB0", VA = "0x18056E9B0", Slot = "66")]
	protected override Plant CrashEntity(Collider2D collision, bool inWater = false, float knockBack = 1f)
	{
		int num = 0;
		if (collision.TryGetComponent<Plant>(num))
		{
			bool flag;
			if (flag)
			{
				goto IL_0120;
			}
			int theZombieRow = this.theZombieRow;
			bool flag2 = TypeMgr.UncrashablePlant(num);
			if (!flag2)
			{
				if (flag2 > true)
				{
					if (flag2 > true)
					{
						if (flag2)
						{
							goto IL_0120;
						}
						if (!flag2)
						{
							goto IL_00DA;
						}
					}
					if (flag2)
					{
						uint num2;
						GameAPP.PlaySound((int)num2, 0.5f, 1f);
						base.KillByCaltrop();
						Transform transform = base.transform;
						int num3 = 0;
						int num4 = 0;
						transform.Translate(knockBack, (float)num4, (float)num3);
						uint num5;
						uint num6;
						GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num5, (int)num6), 0.5f, 1f);
					}
					if (!flag2)
					{
						goto IL_00DA;
					}
					ZombieType theZombieType = this.theZombieType;
					if (theZombieType > ZombieType.CherryCatapultZombie)
					{
						if (theZombieType > ZombieType.DrownpultZombie)
						{
							while (flag2 <= true)
							{
							}
							while (flag2 <= true)
							{
							}
							while (flag2 <= true)
							{
							}
						}
						while (theZombieType == ZombieType.JacksonDriver)
						{
						}
						while (theZombieType == ZombieType.DrownpultZombie)
						{
						}
					}
					if (theZombieType <= ZombieType.CatapultZombie)
					{
					}
					if (theZombieType != ZombieType.CherryCatapultZombie)
					{
						goto IL_00DA;
					}
				}
				if (flag2 <= true)
				{
				}
				IL_00DA:
				this.CrashPlant(num);
			}
			Transform transform2 = base.transform;
			int num7 = 0;
			int num8 = 0;
			transform2.Translate(knockBack, (float)num8, (float)num7);
			uint num10;
			uint num11;
			int num9 = global::UnityEngine.Random.Range((int)num10, (int)num11);
		}
		if (collision.TryGetComponent<Zombie>(num))
		{
			int theZombieRow2 = this.theZombieRow;
			bool isMindControlled = this.isMindControlled;
		}
		IL_0120:
		throw new NullReferenceException();
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x000B345C File Offset: 0x000B165C
	[Token(Token = "0x6002224")]
	[Address(RVA = "0x56F5C0", Offset = "0x56DBC0", VA = "0x18056F5C0")]
	public SnowMonsterRider()
	{
	}
}
