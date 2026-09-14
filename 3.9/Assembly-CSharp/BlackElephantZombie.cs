using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200065A RID: 1626
[Token(Token = "0x200065A")]
public class BlackElephantZombie : ElephantZombie
{
	// Token: 0x06001EC3 RID: 7875 RVA: 0x000A4284 File Offset: 0x000A2484
	[Token(Token = "0x6001EC3")]
	[Address(RVA = "0x587BD0", Offset = "0x5861D0", VA = "0x180587BD0", Slot = "16")]
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
				func = delegate(Zombie z)
				{
					int theZombieType2 = (int)z.theZombieType;
					bool flag3;
					return flag3;
				};
				BlackElephantZombie.<>c.<>9__1_0 = func;
			}
			if (Enumerable.Where<Zombie>(allZombies, func) != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_00A9;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_00A9;
				}
				IL_00B1:
				HashSet<Zombie> hashSet;
				hashSet += hashSet;
				goto IL_00B8;
				IL_00A9:
				hashSet = this.leaders;
				goto IL_00B1;
			}
			IL_00B8:
			if ("{il2cpp array field local30->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001EC4 RID: 7876 RVA: 0x000A4374 File Offset: 0x000A2574
	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0x5877F0", Offset = "0x585DF0", VA = "0x1805877F0", Slot = "29")]
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

	// Token: 0x06001EC5 RID: 7877 RVA: 0x000A43B0 File Offset: 0x000A25B0
	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0x587B50", Offset = "0x586150", VA = "0x180587B50", Slot = "39")]
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

	// Token: 0x06001EC6 RID: 7878 RVA: 0x000A43FC File Offset: 0x000A25FC
	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0x587970", Offset = "0x585F70", VA = "0x180587970", Slot = "76")]
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

	// Token: 0x06001EC7 RID: 7879 RVA: 0x000A4450 File Offset: 0x000A2650
	[Token(Token = "0x6001EC7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x000A4460 File Offset: 0x000A2660
	[Token(Token = "0x6001EC8")]
	[Address(RVA = "0x588020", Offset = "0x586620", VA = "0x180588020")]
	public BlackElephantZombie()
	{
		HashSet<Zombie> hashSet = new HashSet();
		this.leaders = hashSet;
		base..ctor();
	}

	// Token: 0x040010FC RID: 4348
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40010FC")]
	private readonly HashSet<Zombie> leaders;
}
