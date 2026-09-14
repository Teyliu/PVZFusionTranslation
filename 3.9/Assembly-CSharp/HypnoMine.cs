using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000319 RID: 793
[Token(Token = "0x2000319")]
public class HypnoMine : PotatoMine
{
	// Token: 0x06000E6F RID: 3695 RVA: 0x00052700 File Offset: 0x00050900
	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x446F30", Offset = "0x445530", VA = "0x180446F30", Slot = "73")]
	protected override void BombEffect()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x0005274C File Offset: 0x0005094C
	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x446250", Offset = "0x444850", VA = "0x180446250")]
	public HypnoMine()
	{
	}
}
