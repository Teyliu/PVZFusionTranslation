using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A3 RID: 1443
[Token(Token = "0x20005A3")]
public class StarScaredyShroom : ScaredyShroom
{
	// Token: 0x06001AB1 RID: 6833 RVA: 0x0008F168 File Offset: 0x0008D368
	[Token(Token = "0x6001AB1")]
	[Address(RVA = "0x545160", Offset = "0x543760", VA = "0x180545160", Slot = "72")]
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

	// Token: 0x06001AB2 RID: 6834 RVA: 0x0008F21C File Offset: 0x0008D41C
	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x545600", Offset = "0x543C00", VA = "0x180545600", Slot = "68")]
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

	// Token: 0x06001AB3 RID: 6835 RVA: 0x0008F2A8 File Offset: 0x0008D4A8
	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x545550", Offset = "0x543B50", VA = "0x180545550", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		anim.SetTrigger("shoot");
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x0008F2F0 File Offset: 0x0008D4F0
	[Token(Token = "0x6001AB4")]
	[Address(RVA = "0x5458C0", Offset = "0x543EC0", VA = "0x1805458C0")]
	public StarScaredyShroom()
	{
		List<Transform> list = new List();
		this.shoots = list;
		base..ctor();
	}

	// Token: 0x04000F07 RID: 3847
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F07")]
	public List<Transform> shoots;
}
