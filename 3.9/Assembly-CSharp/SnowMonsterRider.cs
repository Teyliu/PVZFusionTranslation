using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FF RID: 1791
[Token(Token = "0x20006FF")]
public class SnowMonsterRider : Zombie
{
	// Token: 0x06002336 RID: 9014 RVA: 0x000B7EB8 File Offset: 0x000B60B8
	[Token(Token = "0x6002336")]
	[Address(RVA = "0x5D1ED0", Offset = "0x5D04D0", VA = "0x1805D1ED0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)43L);
	}

	// Token: 0x06002337 RID: 9015 RVA: 0x000B7ED8 File Offset: 0x000B60D8
	[Token(Token = "0x6002337")]
	[Address(RVA = "0x5D2CA0", Offset = "0x5D12A0", VA = "0x1805D2CA0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = this.CrashEntity(collision, num != 0, 0.3f);
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x000B7EF8 File Offset: 0x000B60F8
	[Token(Token = "0x6002338")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x000B7F08 File Offset: 0x000B6108
	[Token(Token = "0x6002339")]
	[Address(RVA = "0x5D1EF0", Offset = "0x5D04F0", VA = "0x1805D1EF0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num5;
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			num -= (long)theDamage;
			long num2 = this.theMaxHealth;
			num2 -= (long)theDamage;
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
				Lawnf.ChangeSprite((float)0, (float)num4, gameObject);
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x0600233A RID: 9018 RVA: 0x000B7F84 File Offset: 0x000B6184
	[Token(Token = "0x600233A")]
	[Address(RVA = "0x5D2B80", Offset = "0x5D1180", VA = "0x1805D2B80", Slot = "29")]
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

	// Token: 0x0600233B RID: 9019 RVA: 0x000B7FF8 File Offset: 0x000B61F8
	[Token(Token = "0x600233B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600233C RID: 9020 RVA: 0x000B8008 File Offset: 0x000B6208
	[Token(Token = "0x600233C")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x0600233D RID: 9021 RVA: 0x000B8024 File Offset: 0x000B6224
	[Token(Token = "0x600233D")]
	[Address(RVA = "0x5D2570", Offset = "0x5D0B70", VA = "0x1805D2570")]
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

	// Token: 0x0600233E RID: 9022 RVA: 0x000B8128 File Offset: 0x000B6328
	[Token(Token = "0x600233E")]
	[Address(RVA = "0x5D20C0", Offset = "0x5D06C0", VA = "0x1805D20C0", Slot = "68")]
	protected override Plant CrashEntity(Collider2D collision, bool inWater = false, float knockBack = 1f)
	{
		int num = 0;
		if (collision.TryGetComponent<Plant>(num))
		{
			bool flag;
			if (flag)
			{
				goto IL_0126;
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
							goto IL_0126;
						}
						if (!flag2)
						{
							goto IL_00E0;
						}
					}
					if (flag2)
					{
						ZombieType theZombieType = this.theZombieType;
						if (theZombieType > ZombieType.CherryCatapultZombie && ((theZombieType > ZombieType.DrownpultZombie && (flag2 <= true || flag2 <= true || flag2 <= true)) || theZombieType == ZombieType.JacksonDriver || theZombieType == ZombieType.DrownpultZombie))
						{
							goto IL_008F;
						}
						if (theZombieType <= ZombieType.CatapultZombie)
						{
						}
					}
				}
				if (flag2 <= true)
				{
					goto IL_00D8;
				}
				if (flag2)
				{
					goto IL_0126;
				}
				if (!flag2)
				{
					goto IL_00E0;
				}
				IL_008F:
				GameAPP.PlaySound(77, 0.5f, 1f);
				base.KillByCaltrop();
				Transform transform = base.transform;
				int num2 = 0;
				int num3 = 0;
				transform.Translate(knockBack, (float)num3, (float)num2);
				GameAPP.PlaySound(global::UnityEngine.Random.Range(72, 74), 0.5f, 1f);
				IL_00D8:
				if (flag2 || flag2)
				{
					goto IL_0126;
				}
				IL_00E0:
				this.CrashPlant(num);
			}
			Transform transform2 = base.transform;
			int num4 = 0;
			int num5 = 0;
			transform2.Translate(knockBack, (float)num5, (float)num4);
			int num6 = global::UnityEngine.Random.Range(72, 74);
		}
		if (collision.TryGetComponent<Zombie>(num))
		{
			int theZombieRow2 = this.theZombieRow;
			bool isMindControlled = this.isMindControlled;
		}
		IL_0126:
		throw new NullReferenceException();
	}

	// Token: 0x0600233F RID: 9023 RVA: 0x000B8264 File Offset: 0x000B6464
	[Token(Token = "0x600233F")]
	[Address(RVA = "0x5D2CD0", Offset = "0x5D12D0", VA = "0x1805D2CD0")]
	public SnowMonsterRider()
	{
	}
}
