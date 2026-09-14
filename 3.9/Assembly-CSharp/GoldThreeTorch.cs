using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003AA RID: 938
[Token(Token = "0x20003AA")]
public class GoldThreeTorch : TorchWood
{
	// Token: 0x06001133 RID: 4403 RVA: 0x000618D8 File Offset: 0x0005FAD8
	[Token(Token = "0x6001133")]
	[Address(RVA = "0x48C220", Offset = "0x48A820", VA = "0x18048C220", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Bullet>(num))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (collision != this)
			{
				int thePlantRow = this.thePlantRow;
				if (thePlantRow > 1 && ((thePlantRow > 2 && thePlantRow == 6) || thePlantRow == -3))
				{
					bool flag;
					if (flag)
					{
						Board board = this.board;
					}
					int thePlantRow2 = this.thePlantRow;
					if (thePlantRow2 == num)
					{
					}
					int rowNum = this.board.rowNum;
					int num2 = this.thePlantRow;
					if (num2 == rowNum)
					{
					}
					num2++;
				}
			}
		}
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x00061968 File Offset: 0x0005FB68
	[Token(Token = "0x6001134")]
	[Address(RVA = "0x48C060", Offset = "0x48A660", VA = "0x18048C060")]
	private void FireBullet(Bullet bullet)
	{
		bullet.Die();
		float normalSpeed = bullet.normalSpeed;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)20)))
		{
			Board board = this.board;
		}
		int thePlantRow = this.thePlantRow;
		int num = 0;
		if (thePlantRow == num)
		{
		}
		int rowNum = this.board.rowNum;
		int num2 = this.thePlantRow;
		if (num2 == rowNum)
		{
		}
		num2++;
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x000619D4 File Offset: 0x0005FBD4
	[Token(Token = "0x6001135")]
	[Address(RVA = "0x48C4E0", Offset = "0x48AAE0", VA = "0x18048C4E0")]
	private void SetBullet(int theRow, BulletType theBulletType, float theDamage, float speed, BulletMoveWay theMoveWay, float offset = 0f)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x000619F8 File Offset: 0x0005FBF8
	[Token(Token = "0x6001136")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public GoldThreeTorch()
	{
	}
}
