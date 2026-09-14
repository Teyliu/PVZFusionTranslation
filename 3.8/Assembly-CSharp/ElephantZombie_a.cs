using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200065D RID: 1629
[Token(Token = "0x200065D")]
public class ElephantZombie_a : ElephantZombie
{
	// Token: 0x06001F05 RID: 7941 RVA: 0x000A556C File Offset: 0x000A376C
	[Token(Token = "0x6001F05")]
	[Address(RVA = "0x5434A0", Offset = "0x541AA0", VA = "0x1805434A0", Slot = "74")]
	protected override void KnockOthers()
	{
		Transform shoot = this.shoot;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				bool flag2;
				if (!Lawnf.InLandStatus((ZombieStatus)num) || !flag2)
				{
				}
			}
			num++;
		}
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x000A55C0 File Offset: 0x000A37C0
	[Token(Token = "0x6001F06")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x000A55D0 File Offset: 0x000A37D0
	[Token(Token = "0x6001F07")]
	[Address(RVA = "0x543450", Offset = "0x541A50", VA = "0x180543450")]
	public ElephantZombie_a()
	{
	}
}
