using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003DD RID: 989
[Token(Token = "0x20003DD")]
public class LanternChomper : Chomper
{
	// Token: 0x06001209 RID: 4617 RVA: 0x000652E0 File Offset: 0x000634E0
	[Token(Token = "0x6001209")]
	[Address(RVA = "0x49A710", Offset = "0x498D10", VA = "0x18049A710", Slot = "74")]
	protected override void Chomp(Zombie zombie)
	{
		base.Chomp(zombie);
		int currentLightLevel = this.currentLightLevel;
		float attributeCountdown = this.attributeCountdown;
		base.AttributeCountdown = attributeCountdown;
		base.AttributeCountdown = 10f;
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x00065318 File Offset: 0x00063518
	[Token(Token = "0x600120A")]
	[Address(RVA = "0x49A780", Offset = "0x498D80", VA = "0x18049A780")]
	private void SwallowEvent()
	{
		int num2;
		int num3;
		do
		{
			int num = 0;
			num2 = 0;
			num3 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4) || !base.CheckZombie(num))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
			}
		}
		while (num2 != 0);
		int num5 = 0;
		Collider2D[] array;
		bool flag2;
		bool flag3;
		bool flag4;
		bool flag5;
		BoxType boxType;
		BoardGrid boardGrid;
		if (num3 == 0 && num5 < array.Length && (!flag2 || !flag2 || !flag3 || flag4 || flag5 || boxType != boardGrid.boxType))
		{
			num5++;
		}
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x000653B0 File Offset: 0x000635B0
	[Token(Token = "0x600120B")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public LanternChomper()
	{
	}
}
