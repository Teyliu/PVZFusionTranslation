using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200055E RID: 1374
[Token(Token = "0x200055E")]
public class SnowSplit : SplitPea
{
	// Token: 0x0600198A RID: 6538 RVA: 0x00089D8C File Offset: 0x00087F8C
	[Token(Token = "0x600198A")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x00089DAC File Offset: 0x00087FAC
	[Token(Token = "0x600198B")]
	[Address(RVA = "0x4E2AA0", Offset = "0x4E10A0", VA = "0x1804E2AA0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform child = base.transform.GetChild(1);
		int num = 0;
		Transform child2 = child.GetChild(num);
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance2 = CreateBullet.Instance;
		BulletType bulletType2 = this.GetBulletType();
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		GameAPP.PlaySound(68, 0.5f, 1f);
		PlantType thePlantType2 = this.thePlantType;
		bullet2.fromType = thePlantType2;
		return bullet;
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x00089E64 File Offset: 0x00088064
	[Token(Token = "0x600198C")]
	[Address(RVA = "0x4E2D20", Offset = "0x4E1320", VA = "0x1804E2D20", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform child = base.transform.GetChild(1);
		int num = 0;
		Transform child2 = child.GetChild(num);
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x00089EC4 File Offset: 0x000880C4
	[Token(Token = "0x600198D")]
	[Address(RVA = "0x4E2920", Offset = "0x4E0F20", VA = "0x1804E2920", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		for (;;)
		{
			int num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				return BulletType.Bullet_snowPea;
			}
		}
		return BulletType.Bullet_extremeSnowPea;
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x00089F20 File Offset: 0x00088120
	[Token(Token = "0x600198E")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SnowSplit()
	{
	}
}
