using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003DF RID: 991
[Token(Token = "0x20003DF")]
public class MagnetPumpkin : Pumpkin
{
	// Token: 0x06001244 RID: 4676 RVA: 0x00066CC4 File Offset: 0x00064EC4
	[Token(Token = "0x6001244")]
	[Address(RVA = "0x450FD0", Offset = "0x44F5D0", VA = "0x180450FD0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 6f;
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x00066CE4 File Offset: 0x00064EE4
	[Token(Token = "0x6001245")]
	[Address(RVA = "0x450A80", Offset = "0x44F080", VA = "0x180450A80", Slot = "40")]
	protected override void AttributeEvent()
	{
		ulong num4;
		do
		{
			base.AttributeCountdown = 6f;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num = this.zombieLayer;
			List<Zombie> list = new List();
			int num2 = 0;
			int num3 = 0;
			Collider2D[] array;
			if (num3 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && flag2)
				{
					if (flag2 <= true)
					{
					}
					if (!flag2 && !flag2 && !flag2 && flag2 > true)
					{
						if (this > (ulong)210L)
						{
							if (this > (ulong)222L)
							{
								if (this == (ulong)237L || flag2 <= true || flag2 <= true)
								{
									goto IL_0117;
								}
								num2++;
							}
							if (num2 == 219 || 18446744073709551395UL <= (ulong)1L)
							{
								goto IL_0117;
							}
							num2++;
						}
						if (num2 > 40)
						{
							if (num2 == 108 || 18446744073709551416UL <= (ulong)1L || num2 == 210)
							{
								goto IL_0117;
							}
							num2++;
						}
						if (-14 == 0 || -14 == 0 || -14 == 0 || -14 == 0 || 18446744073709551602UL == (ulong)1L || 18446744073709551578UL <= (ulong)2L)
						{
						}
					}
				}
				IL_0117:
				num2++;
			}
			bool flag3;
			if (flag3)
			{
				GridSystem gridSystem = this.board.gridSystem;
				PlantType thePlantType = this.thePlantType;
				BoardGrid boardGrid;
				if (boardGrid.boxType == BoxType.Water)
				{
				}
			}
		}
		while (num4 != (ulong)0L);
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x00066E5C File Offset: 0x0006505C
	[Token(Token = "0x6001246")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public MagnetPumpkin()
	{
	}
}
