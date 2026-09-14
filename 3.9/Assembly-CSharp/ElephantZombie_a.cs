using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000693 RID: 1683
[Token(Token = "0x2000693")]
public class ElephantZombie_a : ElephantZombie
{
	// Token: 0x06002007 RID: 8199 RVA: 0x000A9CE4 File Offset: 0x000A7EE4
	[Token(Token = "0x6002007")]
	[Address(RVA = "0x5A5AC0", Offset = "0x5A40C0", VA = "0x1805A5AC0", Slot = "76")]
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

	// Token: 0x06002008 RID: 8200 RVA: 0x000A9D38 File Offset: 0x000A7F38
	[Token(Token = "0x6002008")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x000A9D48 File Offset: 0x000A7F48
	[Token(Token = "0x6002009")]
	[Address(RVA = "0x5A5A70", Offset = "0x5A4070", VA = "0x1805A5A70")]
	public ElephantZombie_a()
	{
	}
}
