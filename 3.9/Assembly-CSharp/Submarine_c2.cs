using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200070C RID: 1804
[Token(Token = "0x200070C")]
public class Submarine_c2 : Submarine_b2
{
	// Token: 0x06002388 RID: 9096 RVA: 0x000B96F8 File Offset: 0x000B78F8
	[Token(Token = "0x6002388")]
	[Address(RVA = "0x5D66B0", Offset = "0x5D4CB0", VA = "0x1805D66B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
		this.uniqueSpeed = 2f;
		this.attributeCountDown = 0.3f;
	}

	// Token: 0x06002389 RID: 9097 RVA: 0x000B9728 File Offset: 0x000B7928
	[Token(Token = "0x6002389")]
	[Address(RVA = "0x5D6540", Offset = "0x5D4B40", VA = "0x1805D6540", Slot = "24")]
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

	// Token: 0x0600238A RID: 9098 RVA: 0x000B976C File Offset: 0x000B796C
	[Token(Token = "0x600238A")]
	[Address(RVA = "0x5D61B0", Offset = "0x5D47B0", VA = "0x1805D61B0")]
	public Submarine_c2()
	{
	}
}
