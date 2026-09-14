using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000309 RID: 777
[Token(Token = "0x2000309")]
public class HypnoMine : PotatoMine
{
	// Token: 0x06000E26 RID: 3622 RVA: 0x00051790 File Offset: 0x0004F990
	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x402CB0", Offset = "0x4012B0", VA = "0x180402CB0", Slot = "74")]
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

	// Token: 0x06000E27 RID: 3623 RVA: 0x000517DC File Offset: 0x0004F9DC
	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x401F90", Offset = "0x400590", VA = "0x180401F90")]
	public HypnoMine()
	{
		this.flashInterval = 3f;
		base..ctor();
	}
}
