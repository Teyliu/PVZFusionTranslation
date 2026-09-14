using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058E RID: 1422
[Token(Token = "0x200058E")]
public class SnowSplit : SplitPea
{
	// Token: 0x06001A6A RID: 6762 RVA: 0x0008DE14 File Offset: 0x0008C014
	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x0008DE34 File Offset: 0x0008C034
	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0x540F10", Offset = "0x53F510", VA = "0x180540F10", Slot = "68")]
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

	// Token: 0x06001A6C RID: 6764 RVA: 0x0008DEEC File Offset: 0x0008C0EC
	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0x541190", Offset = "0x53F790", VA = "0x180541190", Slot = "69")]
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

	// Token: 0x06001A6D RID: 6765 RVA: 0x0008DF4C File Offset: 0x0008C14C
	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0x540D90", Offset = "0x53F390", VA = "0x180540D90", Slot = "70")]
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

	// Token: 0x06001A6E RID: 6766 RVA: 0x0008DFA8 File Offset: 0x0008C1A8
	[Token(Token = "0x6001A6E")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SnowSplit()
	{
	}
}
