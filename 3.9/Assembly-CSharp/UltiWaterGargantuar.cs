using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000745 RID: 1861
[Token(Token = "0x2000745")]
public class UltiWaterGargantuar : DrownGargantuar
{
	// Token: 0x0600255E RID: 9566 RVA: 0x000C1F64 File Offset: 0x000C0164
	[Token(Token = "0x600255E")]
	[Address(RVA = "0x6080A0", Offset = "0x6066A0", VA = "0x1806080A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1f;
		this.attributeCount = (int)((ulong)7L);
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x000C1F8C File Offset: 0x000C018C
	[Token(Token = "0x600255F")]
	[Address(RVA = "0x607F70", Offset = "0x606570", VA = "0x180607F70", Slot = "24")]
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

	// Token: 0x06002560 RID: 9568 RVA: 0x000C2000 File Offset: 0x000C0200
	[Token(Token = "0x6002560")]
	[Address(RVA = "0x607D40", Offset = "0x606340", VA = "0x180607D40", Slot = "77")]
	protected override Zombie AnimThrow()
	{
		ulong num4;
		do
		{
			bool flag;
			if (flag)
			{
				ulong num;
				num += num;
				int num2 = 0;
				base.Recover((float)num2);
			}
			List<GameObject> weapons = this.weapons;
			bool flag2;
			if (flag2)
			{
				int num3 = 0;
				SpriteRenderer spriteRenderer;
				spriteRenderer.enabled = num3 != 0;
			}
		}
		while (num4 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x000C2060 File Offset: 0x000C0260
	[Token(Token = "0x6002561")]
	[Address(RVA = "0x6080D0", Offset = "0x6066D0", VA = "0x1806080D0", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
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
		long num2;
		return num2;
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x000C20A8 File Offset: 0x000C02A8
	[Token(Token = "0x6002562")]
	[Address(RVA = "0x6082F0", Offset = "0x6068F0", VA = "0x1806082F0")]
	public UltiWaterGargantuar()
	{
	}
}
