using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000591 RID: 1425
[Token(Token = "0x2000591")]
public class ThreePeater : Shooter
{
	// Token: 0x06001A5A RID: 6746 RVA: 0x0008DC8C File Offset: 0x0008BE8C
	[Token(Token = "0x6001A5A")]
	[Address(RVA = "0x4F0EC0", Offset = "0x4EF4C0", VA = "0x1804F0EC0", Slot = "69")]
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

	// Token: 0x06001A5B RID: 6747 RVA: 0x0008DD04 File Offset: 0x0008BF04
	[Token(Token = "0x6001A5B")]
	[Address(RVA = "0x4F11D0", Offset = "0x4EF7D0", VA = "0x1804F11D0")]
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

	// Token: 0x06001A5C RID: 6748 RVA: 0x0008DD48 File Offset: 0x0008BF48
	[Token(Token = "0x6001A5C")]
	[Address(RVA = "0x4F10F0", Offset = "0x4EF6F0", VA = "0x1804F10F0")]
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

	// Token: 0x06001A5D RID: 6749 RVA: 0x0008DD8C File Offset: 0x0008BF8C
	[Token(Token = "0x6001A5D")]
	[Address(RVA = "0x4F0B50", Offset = "0x4EF150", VA = "0x1804F0B50")]
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

	// Token: 0x06001A5E RID: 6750 RVA: 0x0008DDE0 File Offset: 0x0008BFE0
	[Token(Token = "0x6001A5E")]
	[Address(RVA = "0x4F0C60", Offset = "0x4EF260", VA = "0x1804F0C60", Slot = "44")]
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

	// Token: 0x06001A5F RID: 6751 RVA: 0x0008DE58 File Offset: 0x0008C058
	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x0008DE70 File Offset: 0x0008C070
	[Token(Token = "0x6001A60")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ThreePeater()
	{
	}
}
