using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045C RID: 1116
[Token(Token = "0x200045C")]
public class ThreeTorch : Plant
{
	// Token: 0x06001498 RID: 5272 RVA: 0x00072A00 File Offset: 0x00070C00
	[Token(Token = "0x6001498")]
	[Address(RVA = "0x47A5B0", Offset = "0x478BB0", VA = "0x18047A5B0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag && !(collision == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			int thePlantRow = this.thePlantRow;
		}
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x00072A30 File Offset: 0x00070C30
	[Token(Token = "0x6001499")]
	[Address(RVA = "0x47A0F0", Offset = "0x4786F0", VA = "0x18047A0F0")]
	private Bullet CreateInheritedBullet(Bullet sourceBullet, float x, float y, int row, BulletType bulletType, BulletMoveWay moveWay = BulletMoveWay.MoveRight)
	{
		CreateBullet instance = CreateBullet.Instance;
		int num = sourceBullet._damage;
		num += 20;
		Bullet bullet;
		bullet.Damage = num;
		bool shootByZombie = sourceBullet.shootByZombie;
		bullet.shootByZombie = shootByZombie;
		return bullet;
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x00072A74 File Offset: 0x00070C74
	[Token(Token = "0x600149A")]
	[Address(RVA = "0x47A1D0", Offset = "0x4787D0", VA = "0x18047A1D0")]
	private void FirePeas(Bullet bullet)
	{
		int rowNum2;
		do
		{
			Transform transform = base.transform;
			int num = 0;
			Transform child = transform.GetChild(num);
			if (Lawnf.EveBalaced())
			{
				goto IL_00EA;
			}
			int attributeCount = this.attributeCount;
			if (attributeCount == 0)
			{
				goto IL_00DF;
			}
			if (attributeCount != 0)
			{
				if (attributeCount != 1)
				{
					goto IL_00FD;
				}
				int thePlantRow = this.thePlantRow;
				if (this.thePlantRow == 0)
				{
				}
				int rowNum = this.board.rowNum;
				if (this.thePlantRow == rowNum)
				{
				}
				CreateBullet instance = CreateBullet.Instance;
			}
			int thePlantRow2 = this.thePlantRow;
			int num2 = 0;
			if (thePlantRow2 == num2)
			{
			}
			rowNum2 = this.board.rowNum;
		}
		while (this.thePlantRow == rowNum2);
		CreateBullet instance2 = CreateBullet.Instance;
		int num3 = bullet._damage;
		num3 += 20;
		Bullet bullet2;
		bullet2.Damage = num3;
		bool shootByZombie = bullet.shootByZombie;
		bullet2.shootByZombie = shootByZombie;
		int num4 = this.attributeCount;
		num4++;
		this.attributeCount = num4;
		IL_00DF:
		int thePlantRow3 = this.thePlantRow;
		IL_00EA:
		int thePlantRow4 = this.thePlantRow;
		int thePlantRow5 = this.thePlantRow;
		IL_00FD:
		int num5 = this.attributeCount;
		num5++;
		this.attributeCount = num5;
		bullet.Die();
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x00072BA4 File Offset: 0x00070DA4
	[Token(Token = "0x600149B")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public ThreeTorch()
	{
	}
}
