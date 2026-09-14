using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003DA RID: 986
[Token(Token = "0x20003DA")]
public class JalaTorch : TorchWood
{
	// Token: 0x06001200 RID: 4608 RVA: 0x00065130 File Offset: 0x00063330
	[Token(Token = "0x6001200")]
	[Address(RVA = "0x49A460", Offset = "0x498A60", VA = "0x18049A460", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		if (flag)
		{
			bool flag2 = base.CheckFire(num);
			if (flag2)
			{
				if (flag2 <= true || !flag2)
				{
					if (flag)
					{
						while (!flag)
						{
						}
					}
					throw new NullReferenceException();
				}
				BoardAction boardAction = this.board.boardAction;
				int num2 = 0;
				ulong num3;
				Bullet bullet = boardAction.FirePeas(num, this, num2, (BulletType)num, num3 != 0UL);
			}
		}
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x0006518C File Offset: 0x0006338C
	[Token(Token = "0x6001201")]
	[Address(RVA = "0x4480A0", Offset = "0x4466A0", VA = "0x1804480A0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		boardAction.CreateFireLine(thePlantRow, 1800, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x000651D4 File Offset: 0x000633D4
	[Token(Token = "0x6001202")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public JalaTorch()
	{
	}
}
