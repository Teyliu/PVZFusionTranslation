using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000711 RID: 1809
[Token(Token = "0x2000711")]
public class SuperBlackHorse : SuperHorse
{
	// Token: 0x060023A1 RID: 9121 RVA: 0x000B9C10 File Offset: 0x000B7E10
	[Token(Token = "0x60023A1")]
	[Address(RVA = "0x5D7BD0", Offset = "0x5D61D0", VA = "0x1805D7BD0", Slot = "76")]
	protected override void AnimFlagUp()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			CreateZombie instance = CreateZombie.Instance;
			Board board2 = this.board;
			num++;
			uint num2;
			num2 += (uint)4;
		}
	}

	// Token: 0x060023A2 RID: 9122 RVA: 0x000B9C5C File Offset: 0x000B7E5C
	[Token(Token = "0x60023A2")]
	[Address(RVA = "0x5D7D00", Offset = "0x5D6300", VA = "0x1805D7D00", Slot = "68")]
	protected override Plant CrashEntity(Collider2D collision, bool inWater = false, float knockBack = 1f)
	{
		Plant plant = base.CrashEntity(collision, inWater, knockBack);
		int num = 0;
		if (plant != num)
		{
			bool flag = plant.SetEffect((EffectType)((uint)103), 1f, 1f);
		}
		return plant;
	}

	// Token: 0x060023A3 RID: 9123 RVA: 0x000B9C98 File Offset: 0x000B7E98
	[Token(Token = "0x60023A3")]
	[Address(RVA = "0x5D7DC0", Offset = "0x5D63C0", VA = "0x1805D7DC0", Slot = "78")]
	protected override void ReviveZombie()
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		Transform child = axis.GetChild(num);
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			long theMaxHealth = this.theMaxHealth;
			zombie.theHealth = theMaxHealth;
			long theMaxHealth2 = this.theMaxHealth;
			zombie.theMaxHealth = theMaxHealth2;
		}
	}

	// Token: 0x060023A4 RID: 9124 RVA: 0x000B9CF4 File Offset: 0x000B7EF4
	[Token(Token = "0x60023A4")]
	[Address(RVA = "0x588EA0", Offset = "0x5874A0", VA = "0x180588EA0")]
	public SuperBlackHorse()
	{
	}
}
