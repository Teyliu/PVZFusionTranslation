using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000366 RID: 870
[Token(Token = "0x2000366")]
public class CactusNut : WallNut
{
	// Token: 0x06000FEB RID: 4075 RVA: 0x0005B7C8 File Offset: 0x000599C8
	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x475DC0", Offset = "0x4743C0", VA = "0x180475DC0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		ulong num;
		do
		{
			List<GameObject> list = this.changeSprites;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x0005B7F0 File Offset: 0x000599F0
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x475B50", Offset = "0x474150", VA = "0x180475B50", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		int num2 = 0;
		if (base.Active)
		{
			Transform axis = this.axis;
			int num3 = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int thePlantRow = this.thePlantRow;
				}
				num++;
			}
		}
		this.anim.SetBool("rise", num2 != 0);
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x0005B858 File Offset: 0x00059A58
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x475D20", Offset = "0x474320", VA = "0x180475D20", Slot = "68")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
		}
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x0005B878 File Offset: 0x00059A78
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x475EF0", Offset = "0x4744F0", VA = "0x180475EF0")]
	public CactusNut()
	{
		List<GameObject> list = new List();
		this.changeSprites = list;
		base..ctor();
	}

	// Token: 0x04000BA1 RID: 2977
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA1")]
	public List<GameObject> changeSprites;
}
