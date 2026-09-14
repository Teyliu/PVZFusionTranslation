using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F1 RID: 1265
[Token(Token = "0x20004F1")]
public class FlyingThreePeater : ThreePeater
{
	// Token: 0x060017B5 RID: 6069 RVA: 0x00081678 File Offset: 0x0007F878
	[Token(Token = "0x60017B5")]
	[Address(RVA = "0x4C8540", Offset = "0x4C6B40", VA = "0x1804C8540", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_firePea_super;
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00081688 File Offset: 0x0007F888
	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x4C84A0", Offset = "0x4C6AA0", VA = "0x1804C84A0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int i = this.thePlantRow;
		int num = this.thePlantRow;
		num++;
		int num2 = 0;
		Board board = this.board;
		if (i < board.rowNum)
		{
			BoardAction boardAction = board.boardAction;
			PlantType thePlantType = this.thePlantType;
			int num3 = 0;
			ulong num4;
			boardAction.CreateFireLine(i, 1800, num3 != 0, num2 != 0, num4 != 0UL, num2, thePlantType);
		}
		int num5 = this.thePlantRow;
		i++;
		num5++;
		while (i <= num5)
		{
		}
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00081700 File Offset: 0x0007F900
	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x4C8440", Offset = "0x4C6A40", VA = "0x1804C8440", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform shoot = this.shoot;
			return;
		}
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00081720 File Offset: 0x0007F920
	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public FlyingThreePeater()
	{
	}
}
