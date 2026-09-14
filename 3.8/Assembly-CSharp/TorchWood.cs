using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045F RID: 1119
[Token(Token = "0x200045F")]
public class TorchWood : Plant
{
	// Token: 0x060014A2 RID: 5282 RVA: 0x00072E60 File Offset: 0x00071060
	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x47B000", Offset = "0x479600", VA = "0x18047B000", Slot = "69")]
	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		bool flag2;
		if (flag && !flag2)
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (typeof(global::UnityEngine.Object).TypeHandle != (ulong)2L && typeof(global::UnityEngine.Object).TypeHandle != (ulong)6L)
			{
				if (<Team>k__BackingField <= (Team)5)
				{
				}
				int thePlantRow = this.thePlantRow;
			}
			if (<Team>k__BackingField != Team.Player)
			{
				while (!flag)
				{
				}
				BoardAction boardAction = this.board.boardAction;
				throw new NullReferenceException();
			}
			BoardAction boardAction2 = this.board.boardAction;
		}
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x00072ED0 File Offset: 0x000710D0
	[Token(Token = "0x60014A3")]
	[Address(RVA = "0x47AF10", Offset = "0x479510", VA = "0x18047AF10")]
	protected bool CheckFire(Bullet bullet)
	{
		if (!(bullet.torchWood == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (bullet.<Team>k__BackingField == <Team>k__BackingField)
			{
				BulletMoveWay moveWay = bullet._moveWay;
				if (moveWay != BulletMoveWay.Free && moveWay != BulletMoveWay.Track)
				{
					if (<Team>k__BackingField <= (Team)5)
					{
					}
					int thePlantRow = this.thePlantRow;
					if (bullet.theBulletRow == thePlantRow)
					{
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x00072F2C File Offset: 0x0007112C
	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public TorchWood()
	{
	}
}
