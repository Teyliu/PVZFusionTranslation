using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F5 RID: 1013
[Token(Token = "0x20003F5")]
public class MagnetPumpkin : Pumpkin
{
	// Token: 0x060012A8 RID: 4776 RVA: 0x00068644 File Offset: 0x00066844
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 6f;
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x00068664 File Offset: 0x00066864
	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x4A55A0", Offset = "0x4A3BA0", VA = "0x1804A55A0", Slot = "39")]
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

	// Token: 0x060012AA RID: 4778 RVA: 0x000687DC File Offset: 0x000669DC
	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public MagnetPumpkin()
	{
	}
}
