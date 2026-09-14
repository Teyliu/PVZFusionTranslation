using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000397 RID: 919
[Token(Token = "0x2000397")]
public class GoldThreeTorch : TorchWood
{
	// Token: 0x060010D9 RID: 4313 RVA: 0x000603D8 File Offset: 0x0005E5D8
	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x438970", Offset = "0x436F70", VA = "0x180438970", Slot = "69")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		if (flag)
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (collision != this)
			{
				int thePlantRow = this.thePlantRow;
				if (thePlantRow > 1)
				{
					if (thePlantRow > 5)
					{
						if (thePlantRow != 9 && thePlantRow != 15 && thePlantRow != 24)
						{
							return;
						}
					}
					else if (flag)
					{
						while (flag > true)
						{
						}
					}
					bool flag2;
					if (flag2)
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
					throw new NullReferenceException();
				}
			}
		}
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00060478 File Offset: 0x0005E678
	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x4387B0", Offset = "0x436DB0", VA = "0x1804387B0")]
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

	// Token: 0x060010DB RID: 4315 RVA: 0x000604E4 File Offset: 0x0005E6E4
	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x438C30", Offset = "0x437230", VA = "0x180438C30")]
	private void SetBullet(int theRow, BulletType theBulletType, float theDamage, float speed, BulletMoveWay theMoveWay, float offset = 0f)
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.torchWood = this;
		bullet.normalSpeed = (float)0;
		bullet.goldMagneted = true;
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00060528 File Offset: 0x0005E728
	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public GoldThreeTorch()
	{
	}
}
