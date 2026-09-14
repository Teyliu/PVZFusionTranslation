using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000113 RID: 275
[Token(Token = "0x2000113")]
public class Bullet_butter_portal : Bullet_butter
{
	// Token: 0x0600055B RID: 1371 RVA: 0x0001D1FC File Offset: 0x0001B3FC
	[Token(Token = "0x600055B")]
	[Address(RVA = "0x6B8810", Offset = "0x6B6E10", VA = "0x1806B8810", Slot = "18")]
	public override void HitLand()
	{
		GameObject gameObject = this.holePrefab;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = Board.Instance.transform;
		GameObject gameObject2;
		BlackHole component = gameObject2.GetComponent<BlackHole>();
		int damage = this._damage;
		component.theDamage = damage;
		int theBulletRow = this.theBulletRow;
		component.Row = theBulletRow;
		component.main = true;
		PlantType fromType = this.fromType;
		component.fromType = fromType;
		int shootingLevel = this.shootingLevel;
		component.shootLevel = shootingLevel;
		GameAPP.PlaySound(100, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
	[Token(Token = "0x600055C")]
	[Address(RVA = "0x6B8A10", Offset = "0x6B7010", VA = "0x1806B8A10", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform axis = zombie.axis;
		Mouse instance = Mouse.Instance;
		GameObject gameObject = this.holePrefab;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = Board.Instance.transform;
		GameObject gameObject2;
		BlackHole component = gameObject2.GetComponent<BlackHole>();
		int damage = this._damage;
		component.theDamage = damage;
		int theZombieRow = zombie.theZombieRow;
		component.Row = theZombieRow;
		component.main = true;
		PlantType fromType = this.fromType;
		component.fromType = fromType;
		int shootingLevel = this.shootingLevel;
		component.shootLevel = shootingLevel;
		GameAPP.PlaySound(100, 0.5f, 1f);
		int damage2 = this._damage;
		PlantType fromType2 = this.fromType;
		ulong num;
		zombie.TakeDamage(damage2, this, (DamageType)((uint)4), fromType2, num != 0UL);
		base.Die();
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0001D370 File Offset: 0x0001B570
	[Token(Token = "0x600055D")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_butter_portal()
	{
	}

	// Token: 0x04000356 RID: 854
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000356")]
	public GameObject holePrefab;
}
