using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200047C RID: 1148
[Token(Token = "0x200047C")]
public class ThreeTorch : Plant
{
	// Token: 0x06001528 RID: 5416 RVA: 0x00074D5C File Offset: 0x00072F5C
	[Token(Token = "0x6001528")]
	[Address(RVA = "0x4D1E70", Offset = "0x4D0470", VA = "0x1804D1E70")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag && !(collision == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			int thePlantRow = this.thePlantRow;
		}
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x00074D8C File Offset: 0x00072F8C
	[Token(Token = "0x6001529")]
	[Address(RVA = "0x4D19B0", Offset = "0x4CFFB0", VA = "0x1804D19B0")]
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

	// Token: 0x0600152A RID: 5418 RVA: 0x00074DD0 File Offset: 0x00072FD0
	[Token(Token = "0x600152A")]
	[Address(RVA = "0x4D1A90", Offset = "0x4D0090", VA = "0x1804D1A90")]
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

	// Token: 0x0600152B RID: 5419 RVA: 0x00074F00 File Offset: 0x00073100
	[Token(Token = "0x600152B")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public ThreeTorch()
	{
	}
}
