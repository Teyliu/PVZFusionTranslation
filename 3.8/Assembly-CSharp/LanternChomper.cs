using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C9 RID: 969
[Token(Token = "0x20003C9")]
public class LanternChomper : Chomper
{
	// Token: 0x060011AD RID: 4525 RVA: 0x00063CC0 File Offset: 0x00061EC0
	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x446280", Offset = "0x444880", VA = "0x180446280", Slot = "74")]
	protected override void Chomp(Zombie zombie)
	{
		base.Chomp(zombie);
		int currentLightLevel = this.currentLightLevel;
		float attributeCountdown = this.attributeCountdown;
		base.AttributeCountdown = attributeCountdown;
		base.AttributeCountdown = 10f;
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00063CF8 File Offset: 0x00061EF8
	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x4462F0", Offset = "0x4448F0", VA = "0x1804462F0")]
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
		if (num3 == 0 && num5 < array.Length)
		{
			bool flag2;
			bool flag3;
			bool flag4;
			bool flag5;
			BoxType boxType;
			BoardGrid boardGrid;
			if (!flag2 || !flag2 || !flag3 || flag4 || flag5 || boxType != boardGrid.boxType)
			{
				num5++;
			}
			bool flag6 = num2.Equals(num2);
		}
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00063D98 File Offset: 0x00061F98
	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x430E90", Offset = "0x42F490", VA = "0x180430E90")]
	public LanternChomper()
	{
	}
}
