using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C6 RID: 966
[Token(Token = "0x20003C6")]
public class JalaTorch : TorchWood
{
	// Token: 0x060011A4 RID: 4516 RVA: 0x00063B10 File Offset: 0x00061D10
	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x445FD0", Offset = "0x4445D0", VA = "0x180445FD0", Slot = "69")]
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

	// Token: 0x060011A5 RID: 4517 RVA: 0x00063B6C File Offset: 0x00061D6C
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x403E70", Offset = "0x402470", VA = "0x180403E70", Slot = "52")]
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

	// Token: 0x060011A6 RID: 4518 RVA: 0x00063BB4 File Offset: 0x00061DB4
	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public JalaTorch()
	{
	}
}
