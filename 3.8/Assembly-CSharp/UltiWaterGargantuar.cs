using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200070C RID: 1804
[Token(Token = "0x200070C")]
public class UltiWaterGargantuar : DrownGargantuar
{
	// Token: 0x0600243E RID: 9278 RVA: 0x000BD194 File Offset: 0x000BB394
	[Token(Token = "0x600243E")]
	[Address(RVA = "0x584950", Offset = "0x582F50", VA = "0x180584950", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1f;
		this.attributeCount = (int)((ulong)7L);
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x000BD1BC File Offset: 0x000BB3BC
	[Token(Token = "0x600243F")]
	[Address(RVA = "0x584820", Offset = "0x582E20", VA = "0x180584820", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.attributeCountDown = 1f;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)26)))
		{
			float num;
			this.attributeCountDown = num;
		}
		List<GameObject> weapons = this.weapons;
		int num2 = 0;
		int attributeCount = this.attributeCount;
		if (num2 < attributeCount)
		{
			this.weapons[num2].GetComponent<SpriteRenderer>().enabled = true;
		}
		List<GameObject> weapons2 = this.weapons;
		num2++;
		this.theStatus = (ZombieStatus)((ulong)15L);
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x000BD230 File Offset: 0x000BB430
	[Token(Token = "0x6002440")]
	[Address(RVA = "0x584610", Offset = "0x582C10", VA = "0x180584610", Slot = "75")]
	protected override Zombie AnimThrow()
	{
		ulong num3;
		do
		{
			bool flag;
			if (flag)
			{
				float num;
				base.Recover(num);
			}
			List<GameObject> weapons = this.weapons;
			bool flag2;
			if (flag2)
			{
				int num2 = 0;
				SpriteRenderer spriteRenderer;
				spriteRenderer.enabled = num2 != 0;
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x000BD288 File Offset: 0x000BB488
	[Token(Token = "0x6002441")]
	[Address(RVA = "0x584980", Offset = "0x582F80", VA = "0x180584980", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		while (!fix)
		{
			List<Zombie> zombieHead = this.board.zombieHead;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
			ulong num;
			if (num == (ulong)0L)
			{
				break;
			}
		}
		int num2;
		return num2;
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x000BD2CC File Offset: 0x000BB4CC
	[Token(Token = "0x6002442")]
	[Address(RVA = "0x584B90", Offset = "0x583190", VA = "0x180584B90")]
	public UltiWaterGargantuar()
	{
	}
}
