using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000380 RID: 896
[Token(Token = "0x2000380")]
public class CornCaltrop : Plant
{
	// Token: 0x06001074 RID: 4212 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
	[Token(Token = "0x6001074")]
	[Address(RVA = "0x47E710", Offset = "0x47CD10", VA = "0x18047E710", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x0005E000 File Offset: 0x0005C200
	[Token(Token = "0x6001075")]
	[Address(RVA = "0x47E5A0", Offset = "0x47CBA0", VA = "0x18047E5A0", Slot = "39")]
	protected override void AttributeEvent()
	{
		ulong num;
		do
		{
			HashSet<Zombie> hashSet = this.zombies;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x0005E034 File Offset: 0x0005C234
	[Token(Token = "0x6001076")]
	[Address(RVA = "0x47E780", Offset = "0x47CD80", VA = "0x18047E780")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			bool flag2;
			if (flag2)
			{
				HashSet<Zombie> hashSet = this.zombies;
				ulong num;
				if (num != (ulong)0L)
				{
				}
			}
		}
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x0005E068 File Offset: 0x0005C268
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x47E960", Offset = "0x47CF60", VA = "0x18047E960")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			HashSet<Zombie> hashSet = this.zombies;
			int thePlantRow = this.thePlantRow;
			bool flag2;
			ulong num;
			if (!flag2)
			{
				while (collision == 0)
				{
				}
				if (num != (ulong)0L)
				{
				}
				return;
			}
			bool flag3;
			if (!flag3)
			{
				HashSet<Zombie> hashSet2 = this.zombies;
			}
			if (num != (ulong)0L)
			{
			}
		}
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x0005E0B4 File Offset: 0x0005C2B4
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x47E870", Offset = "0x47CE70", VA = "0x18047E870")]
	private void OnTriggerExit2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			HashSet<Zombie> hashSet = this.zombies;
			bool flag2;
			if (flag2)
			{
				ulong num;
				if (num != (ulong)0L)
				{
				}
				HashSet<Zombie> hashSet2 = this.zombies;
			}
		}
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x0005E0E8 File Offset: 0x0005C2E8
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x47E740", Offset = "0x47CD40", VA = "0x18047E740")]
	private bool IsValidZombie(Zombie zombie)
	{
		int thePlantRow = this.thePlantRow;
		if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled)
		{
			return Lawnf.InLandStatus(zombie.theStatus);
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x0005E124 File Offset: 0x0005C324
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x47EAF0", Offset = "0x47D0F0", VA = "0x18047EAF0")]
	public CornCaltrop()
	{
		HashSet<Zombie> hashSet = new HashSet();
		this.zombies = hashSet;
		base..ctor();
	}

	// Token: 0x04000BC2 RID: 3010
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BC2")]
	private readonly HashSet<Zombie> zombies;
}
