using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000370 RID: 880
[Token(Token = "0x2000370")]
public class CornCaltrop : Plant
{
	// Token: 0x06001029 RID: 4137 RVA: 0x0005D05C File Offset: 0x0005B25C
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x42DFB0", Offset = "0x42C5B0", VA = "0x18042DFB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x0005D07C File Offset: 0x0005B27C
	[Token(Token = "0x600102A")]
	[Address(RVA = "0x42DE40", Offset = "0x42C440", VA = "0x18042DE40", Slot = "40")]
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

	// Token: 0x0600102B RID: 4139 RVA: 0x0005D0B0 File Offset: 0x0005B2B0
	[Token(Token = "0x600102B")]
	[Address(RVA = "0x42E020", Offset = "0x42C620", VA = "0x18042E020")]
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

	// Token: 0x0600102C RID: 4140 RVA: 0x0005D0E4 File Offset: 0x0005B2E4
	[Token(Token = "0x600102C")]
	[Address(RVA = "0x42E200", Offset = "0x42C800", VA = "0x18042E200")]
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

	// Token: 0x0600102D RID: 4141 RVA: 0x0005D130 File Offset: 0x0005B330
	[Token(Token = "0x600102D")]
	[Address(RVA = "0x42E110", Offset = "0x42C710", VA = "0x18042E110")]
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

	// Token: 0x0600102E RID: 4142 RVA: 0x0005D164 File Offset: 0x0005B364
	[Token(Token = "0x600102E")]
	[Address(RVA = "0x42DFE0", Offset = "0x42C5E0", VA = "0x18042DFE0")]
	private bool IsValidZombie(Zombie zombie)
	{
		int thePlantRow = this.thePlantRow;
		if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled)
		{
			return Lawnf.InLandStatus(zombie.theStatus);
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x0005D1A0 File Offset: 0x0005B3A0
	[Token(Token = "0x600102F")]
	[Address(RVA = "0x42E390", Offset = "0x42C990", VA = "0x18042E390")]
	public CornCaltrop()
	{
		HashSet<Zombie> hashSet = new HashSet();
		this.zombies = hashSet;
		base..ctor();
	}

	// Token: 0x04000B72 RID: 2930
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B72")]
	private readonly HashSet<Zombie> zombies;
}
