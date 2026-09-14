using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
public class Bullet_springMelon : Bullet_fireMelon
{
	// Token: 0x0600075C RID: 1884 RVA: 0x00025480 File Offset: 0x00023680
	[Token(Token = "0x600075C")]
	[Address(RVA = "0x80FB40", Offset = "0x80E140", VA = "0x18080FB40", Slot = "17")]
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

	// Token: 0x0600075D RID: 1885 RVA: 0x00025524 File Offset: 0x00023724
	[Token(Token = "0x600075D")]
	[Address(RVA = "0x80FD20", Offset = "0x80E320", VA = "0x18080FD20", Slot = "22")]
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

	// Token: 0x0600075E RID: 1886 RVA: 0x000255E0 File Offset: 0x000237E0
	[Token(Token = "0x600075E")]
	[Address(RVA = "0x80F610", Offset = "0x80DC10", VA = "0x18080F610")]
	private void ExtraDamage(Zombie originalZombie)
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		List<Zombie> list = new List();
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num++;
		}
		bool flag2 = list.Remove(originalZombie);
		int num3 = list._size;
		int num4 = global::UnityEngine.Random.Range(0, num3);
		num3 = num4;
		Zombie zombie = list[num3];
		num3 = num4;
		list.RemoveAt(num3);
		CreateBullet instance = CreateBullet.Instance;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		int damage = this._damage;
		Bullet bullet;
		bullet.Damage = damage;
		Transform transform4 = bullet.transform;
		Vector2 velocity = zombie.Velocity;
		Vector2 colliderPosition = zombie.ColliderPosition;
		float num5 = global::UnityEngine.Random.Range(0.5f, 1f);
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		bullet.theStatus = (BulletStatus)((ulong)7L);
		PlantType fromType = this.fromType;
		bullet.fromType = fromType;
		bullet.maxHitCount = (int)((ulong)99999L);
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x000256F0 File Offset: 0x000238F0
	[Token(Token = "0x600075F")]
	[Address(RVA = "0x80FF60", Offset = "0x80E560", VA = "0x18080FF60", Slot = "25")]
	public override void RotateUpdate()
	{
		Transform transform = this.spriteObject.transform;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00025710 File Offset: 0x00023910
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x810010", Offset = "0x80E610", VA = "0x180810010")]
	public Bullet_springMelon()
	{
	}
}
