using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000573 RID: 1395
[Token(Token = "0x2000573")]
public class StarScaredyShroom : ScaredyShroom
{
	// Token: 0x060019D1 RID: 6609 RVA: 0x0008B0B4 File Offset: 0x000892B4
	[Token(Token = "0x60019D1")]
	[Address(RVA = "0x4E6CF0", Offset = "0x4E52F0", VA = "0x1804E6CF0", Slot = "73")]
	protected override void GetNearZombies()
	{
		int i;
		do
		{
			i = 0;
			List<Transform> list = this.shoots;
			bool flag;
			if (flag)
			{
				Vector3 vector;
				float z = vector.z;
				int num = this.zombieLayer;
				RaycastHit2D[] array;
				while (i >= array.Length)
				{
				}
				Collider2D collider2D;
				if (collider2D.TryGetComponent<Zombie>(i))
				{
					Transform axis = this.axis;
					int thePlantRow = this.thePlantRow;
				}
				i++;
				this.anim.SetBool("NearZombie", true);
			}
		}
		while (i != 0);
	}

	// Token: 0x060019D2 RID: 6610 RVA: 0x0008B168 File Offset: 0x00089368
	[Token(Token = "0x60019D2")]
	[Address(RVA = "0x4E7190", Offset = "0x4E5790", VA = "0x1804E7190", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num;
		do
		{
			num = 0;
			List<Transform> list = this.shoots;
			bool flag;
			if (flag)
			{
				CreateBullet instance = CreateBullet.Instance;
				Bullet bullet;
				Transform transform = bullet.transform;
				int attackDamage = this.attackDamage;
				bullet.Damage = attackDamage;
				PlantType thePlantType = this.thePlantType;
				bullet.fromType = thePlantType;
			}
		}
		while (num != 0);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x0008B1F4 File Offset: 0x000893F4
	[Token(Token = "0x60019D3")]
	[Address(RVA = "0x4E70E0", Offset = "0x4E56E0", VA = "0x1804E70E0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		anim.SetTrigger("shoot");
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x0008B23C File Offset: 0x0008943C
	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x4E7450", Offset = "0x4E5A50", VA = "0x1804E7450")]
	public StarScaredyShroom()
	{
		List<Transform> list = new List();
		this.shoots = list;
		base..ctor();
	}

	// Token: 0x04000E49 RID: 3657
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E49")]
	public List<Transform> shoots;
}
