using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A3 RID: 419
[Token(Token = "0x20001A3")]
public class Bullet_springMelon : Bullet_fireMelon
{
	// Token: 0x0600074F RID: 1871 RVA: 0x00025B30 File Offset: 0x00023D30
	[Token(Token = "0x600074F")]
	[Address(RVA = "0x7E2470", Offset = "0x7E0A70", VA = "0x1807E2470", Slot = "18")]
	public override void HitLand()
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)12000)))
		{
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject;
			FireOcean component = gameObject.GetComponent<FireOcean>();
			component.theDamage = gameObject;
			int theBulletRow = this.theBulletRow;
			component.theRow = theBulletRow;
			PlantType fromType = this.fromType;
			component.fromType = fromType;
			float num;
			component.timer = num;
		}
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		int num2 = 0;
		base.AttackOtherZombie(num2, (MelonSputterType)((uint)5));
		GameAPP.PlaySound(40, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00025BD4 File Offset: 0x00023DD4
	[Token(Token = "0x6000750")]
	[Address(RVA = "0x7E2650", Offset = "0x7E0C50", VA = "0x1807E2650", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		this.ExtraDamage(zombie);
		Transform axis = zombie.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		FireOcean component = gameObject.GetComponent<FireOcean>();
		component.theDamage = gameObject;
		int theZombieRow = zombie.theZombieRow;
		component.theRow = theZombieRow;
		PlantType fromType = this.fromType;
		component.fromType = fromType;
		float num;
		component.timer = num;
		Transform transform = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		int damage = this._damage;
		PlantType fromType2 = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)((uint)6), fromType2, num2 != 0UL);
		zombie.SetJalaed();
		base.AttackOtherZombie(zombie, (MelonSputterType)((uint)5));
		GameAPP.PlaySound(40, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00025C90 File Offset: 0x00023E90
	[Token(Token = "0x6000751")]
	[Address(RVA = "0x7E1EA0", Offset = "0x7E04A0", VA = "0x1807E1EA0")]
	private void ExtraDamage(Zombie originalZombie)
	{
		Transform transform = base.transform;
		int num = this.zombieLayer;
		List<Zombie> list = new List();
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num3++;
		}
		bool flag2 = list.Remove(originalZombie);
		int num4 = list._size;
		int num5 = global::UnityEngine.Random.Range(0, num4);
		num4 = num5;
		Zombie zombie = list[num4];
		num4 = num5;
		list.RemoveAt(num4);
		CreateBullet instance = CreateBullet.Instance;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		int damage = this._damage;
		Bullet bullet;
		bullet.Damage = damage;
		Transform transform4 = bullet.transform;
		Vector2 velocity = zombie.Velocity;
		Vector2 colliderPosition = zombie.ColliderPosition;
		float num6 = global::UnityEngine.Random.Range(0.5f, 1f);
		float[] array2;
		float num7 = array2[0];
		bullet.Vx = num7;
		float num8 = array2[1];
		bullet.Vy = num8;
		float num9 = array2[1];
		bullet.detaVy = num9;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		bullet.theStatus = (BulletStatus)((ulong)7L);
		PlantType fromType = this.fromType;
		bullet.fromType = fromType;
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00025DD8 File Offset: 0x00023FD8
	[Token(Token = "0x6000752")]
	[Address(RVA = "0x7E2890", Offset = "0x7E0E90", VA = "0x1807E2890", Slot = "27")]
	public override void RotateUpdate()
	{
		Transform transform = this.spriteObject.transform;
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00025DF8 File Offset: 0x00023FF8
	[Token(Token = "0x6000753")]
	[Address(RVA = "0x7E2940", Offset = "0x7E0F40", VA = "0x1807E2940")]
	public Bullet_springMelon()
	{
	}
}
