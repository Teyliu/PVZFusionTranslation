using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BE RID: 1470
[Token(Token = "0x20005BE")]
public class Threekelp : Tanglekelp
{
	// Token: 0x06001B28 RID: 6952 RVA: 0x0009187C File Offset: 0x0008FA7C
	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x5503B0", Offset = "0x54E9B0", VA = "0x1805503B0", Slot = "16")]
	protected override void Update()
	{
		base.PlantShootUpdate();
		base.Update();
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x00091898 File Offset: 0x0008FA98
	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x54FE50", Offset = "0x54E450", VA = "0x18054FE50")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Vector3 vector;
		float z = vector.z;
		Transform shoot3 = this.shoot;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		int rowNum = this.board.rowNum;
		CreateBullet instance2 = CreateBullet.Instance;
		int num = this.thePlantRow;
		num++;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		CreateBullet instance3 = CreateBullet.Instance;
		int attackDamage3 = this.attackDamage;
		Bullet bullet3;
		bullet3.Damage = attackDamage3;
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x00091944 File Offset: 0x0008FB44
	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0x550150", Offset = "0x54E750", VA = "0x180550150", Slot = "43")]
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

	// Token: 0x06001B2B RID: 6955 RVA: 0x000919BC File Offset: 0x0008FBBC
	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x4466F0", Offset = "0x444CF0", VA = "0x1804466F0")]
	public Threekelp()
	{
	}
}
