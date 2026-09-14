using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000625 RID: 1573
[Token(Token = "0x2000625")]
public class BlackElephantZombie : ElephantZombie
{
	// Token: 0x06001DC4 RID: 7620 RVA: 0x0009FC80 File Offset: 0x0009DE80
	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x531050", Offset = "0x52F650", VA = "0x180531050", Slot = "15")]
	protected override void Start()
	{
		int num;
		do
		{
			num = 0;
			base.Start();
			bool flag;
			if (flag)
			{
				CreateZombie instance = CreateZombie.Instance;
				ZombieType theZombieType = this.theZombieType;
				Transform axis = this.axis;
				float num2 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
				Zombie zombie;
				this.board.SetHealthInTravel(zombie);
				zombie.revived = true;
				zombie.theStatus = (ZombieStatus)((ulong)43L);
				num++;
			}
			bool flag2;
			if (!flag2)
			{
				break;
			}
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			Func<Zombie, bool> func;
			if (BlackElephantZombie.<>c.<>9__1_0 == 0)
			{
				BlackElephantZombie.<>c.<>9__1_0 = func;
			}
			if (Enumerable.Where<Zombie>(allZombies, func) != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_0097;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_0097;
				}
				IL_009F:
				HashSet<Zombie> hashSet;
				hashSet += hashSet;
				goto IL_00A6;
				IL_0097:
				hashSet = this.leaders;
				goto IL_009F;
			}
			IL_00A6:
			if ("{il2cpp array field local30->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x0009FD60 File Offset: 0x0009DF60
	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0x530C70", Offset = "0x52F270", VA = "0x180530C70", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		ulong num3;
		do
		{
			int num = 0;
			HashSet<Zombie> hashSet = this.leaders;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x0009FD9C File Offset: 0x0009DF9C
	[Token(Token = "0x6001DC6")]
	[Address(RVA = "0x530FD0", Offset = "0x52F5D0", VA = "0x180530FD0", Slot = "37")]
	protected override void PlayEatSound2()
	{
		base.PlayEatSound2();
		int attributeCount = this.attributeCount;
		int num = attributeCount + 1;
		this.attributeCount = num;
		if (attributeCount == 10)
		{
			this.anim.SetTrigger("attack2");
			this.attributeCount = (int)((ulong)0L);
		}
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x0009FDE8 File Offset: 0x0009DFE8
	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0x530DF0", Offset = "0x52F3F0", VA = "0x180530DF0", Slot = "74")]
	protected override void KnockOthers()
	{
		Transform shoot = this.shoot;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				bool flag2;
				if (!Lawnf.InLandStatus((ZombieStatus)num) || !flag2)
				{
				}
			}
			num++;
		}
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x0009FE3C File Offset: 0x0009E03C
	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x0009FE4C File Offset: 0x0009E04C
	[Token(Token = "0x6001DC9")]
	[Address(RVA = "0x5314A0", Offset = "0x52FAA0", VA = "0x1805314A0")]
	public BlackElephantZombie()
	{
		HashSet<Zombie> hashSet = new HashSet();
		this.leaders = hashSet;
		base..ctor();
	}

	// Token: 0x04001034 RID: 4148
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001034")]
	private readonly HashSet<Zombie> leaders;
}
