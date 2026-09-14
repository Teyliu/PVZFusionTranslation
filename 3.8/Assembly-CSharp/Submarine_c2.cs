using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D4 RID: 1748
[Token(Token = "0x20006D4")]
public class Submarine_c2 : Submarine_b2
{
	// Token: 0x0600226E RID: 8814 RVA: 0x000B493C File Offset: 0x000B2B3C
	[Token(Token = "0x600226E")]
	[Address(RVA = "0x573040", Offset = "0x571640", VA = "0x180573040", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
		this.uniqueSpeed = 2f;
		this.attributeCountDown = 0.3f;
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x000B496C File Offset: 0x000B2B6C
	[Token(Token = "0x600226F")]
	[Address(RVA = "0x572ED0", Offset = "0x5714D0", VA = "0x180572ED0", Slot = "23")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.ZombieUpdate();
		Transform axis = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num++;
		}
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x000B49B0 File Offset: 0x000B2BB0
	[Token(Token = "0x6002270")]
	[Address(RVA = "0x572B40", Offset = "0x571140", VA = "0x180572B40")]
	public Submarine_c2()
	{
	}
}
