using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C2 RID: 1474
[Token(Token = "0x20005C2")]
public class ThreePeater : Shooter
{
	// Token: 0x06001B40 RID: 6976 RVA: 0x00092038 File Offset: 0x00090238
	[Token(Token = "0x6001B40")]
	[Address(RVA = "0x54F460", Offset = "0x54DA60", VA = "0x18054F460", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		int thePlantRow = this.thePlantRow;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int rowNum = this.board.rowNum;
		base.Invoke("ExtraBullet", 0.2f);
		return bullet;
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x000920B0 File Offset: 0x000902B0
	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x54F770", Offset = "0x54DD70", VA = "0x18054F770")]
	private void ShootUpper(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x000920F4 File Offset: 0x000902F4
	[Token(Token = "0x6001B42")]
	[Address(RVA = "0x54F690", Offset = "0x54DC90", VA = "0x18054F690")]
	private void ShootLower(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x00092138 File Offset: 0x00090338
	[Token(Token = "0x6001B43")]
	[Address(RVA = "0x54F0F0", Offset = "0x54D6F0", VA = "0x18054F0F0")]
	private void ExtraBullet()
	{
		Transform transform = this.shoot.transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x0009218C File Offset: 0x0009038C
	[Token(Token = "0x6001B44")]
	[Address(RVA = "0x54F200", Offset = "0x54D800", VA = "0x18054F200", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					float vision = this.vision;
					Transform axis = this.axis;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x00092204 File Offset: 0x00090404
	[Token(Token = "0x6001B45")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x0009221C File Offset: 0x0009041C
	[Token(Token = "0x6001B46")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ThreePeater()
	{
	}
}
