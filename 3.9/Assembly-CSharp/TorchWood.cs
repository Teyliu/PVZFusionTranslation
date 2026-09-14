using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200047F RID: 1151
[Token(Token = "0x200047F")]
public class TorchWood : Plant
{
	// Token: 0x06001532 RID: 5426 RVA: 0x000751A4 File Offset: 0x000733A4
	[Token(Token = "0x6001532")]
	[Address(RVA = "0x4D2850", Offset = "0x4D0E50", VA = "0x1804D2850", Slot = "68")]
	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		Team <Team>k__BackingField;
		do
		{
			int num = 0;
			flag = collision.TryGetComponent<Bullet>(num);
			bool flag2;
			if (!flag || flag2)
			{
				return;
			}
			<Team>k__BackingField = this.<Team>k__BackingField;
			if (<Team>k__BackingField > (Team)5)
			{
			}
		}
		while (<Team>k__BackingField == (Team)(-3));
		if (this.thePlantRow != 0)
		{
			while (!flag)
			{
			}
			BoardAction boardAction = this.board.boardAction;
			throw new NullReferenceException();
		}
		BoardAction boardAction2 = this.board.boardAction;
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x00075204 File Offset: 0x00073404
	[Token(Token = "0x6001533")]
	[Address(RVA = "0x4D2780", Offset = "0x4D0D80", VA = "0x1804D2780")]
	protected bool CheckFire(Bullet bullet)
	{
		if (!(bullet.torchWood == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (bullet.<Team>k__BackingField == <Team>k__BackingField)
			{
				BulletMoveWay moveWay = bullet._moveWay;
				if (moveWay > BulletMoveWay.Free)
				{
				}
				if (moveWay != (BulletMoveWay)(-3))
				{
					int thePlantRow = this.thePlantRow;
					if (bullet.theBulletRow == thePlantRow)
					{
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x0007525C File Offset: 0x0007345C
	[Token(Token = "0x6001534")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public TorchWood()
	{
	}
}
