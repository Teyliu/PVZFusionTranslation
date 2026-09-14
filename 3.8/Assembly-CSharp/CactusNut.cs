using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000356 RID: 854
[Token(Token = "0x2000356")]
public class CactusNut : WallNut
{
	// Token: 0x06000F9F RID: 3999 RVA: 0x0005A838 File Offset: 0x00058A38
	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x41EE80", Offset = "0x41D480", VA = "0x18041EE80", Slot = "29")]
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

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0005A860 File Offset: 0x00058A60
	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x41EC10", Offset = "0x41D210", VA = "0x18041EC10", Slot = "17")]
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

	// Token: 0x06000FA1 RID: 4001 RVA: 0x0005A8C8 File Offset: 0x00058AC8
	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x41EDE0", Offset = "0x41D3E0", VA = "0x18041EDE0", Slot = "69")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
		}
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x0005A8E8 File Offset: 0x00058AE8
	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x41EFB0", Offset = "0x41D5B0", VA = "0x18041EFB0")]
	public CactusNut()
	{
		List<GameObject> list = new List();
		this.changeSprites = list;
		base..ctor();
	}

	// Token: 0x04000B50 RID: 2896
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B50")]
	public List<GameObject> changeSprites;
}
