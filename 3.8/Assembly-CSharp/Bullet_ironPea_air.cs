using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000157 RID: 343
[Token(Token = "0x2000157")]
public class Bullet_ironPea_air : Bullet
{
	// Token: 0x06000644 RID: 1604 RVA: 0x000215DC File Offset: 0x0001F7DC
	[Token(Token = "0x6000644")]
	[Address(RVA = "0x6C7970", Offset = "0x6C5F70", VA = "0x1806C7970", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int theZombieRow = zombie.theZombieRow;
		this.Bomb(theZombieRow);
		base.Die();
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00021604 File Offset: 0x0001F804
	[Token(Token = "0x6000645")]
	[Address(RVA = "0x6C7940", Offset = "0x6C5F40", VA = "0x1806C7940", Slot = "18")]
	public override void HitLand()
	{
		int theBulletRow = this.theBulletRow;
		this.Bomb(theBulletRow);
		base.Die();
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00021628 File Offset: 0x0001F828
	[Token(Token = "0x6000646")]
	[Address(RVA = "0x6C7630", Offset = "0x6C5C30", VA = "0x1806C7630")]
	private void Bomb(int row)
	{
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.2f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				num -= row;
				bool flag2;
				if (!flag2)
				{
					PlantType fromType = this.fromType;
				}
				PlantType fromType2 = this.fromType;
			}
			num++;
		}
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x0002169C File Offset: 0x0001F89C
	[Token(Token = "0x6000647")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_ironPea_air()
	{
	}
}
