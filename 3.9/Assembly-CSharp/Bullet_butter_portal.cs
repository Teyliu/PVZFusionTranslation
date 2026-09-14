using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000119 RID: 281
[Token(Token = "0x2000119")]
public class Bullet_butter_portal : Bullet_butter
{
	// Token: 0x0600056C RID: 1388 RVA: 0x0001CB80 File Offset: 0x0001AD80
	[Token(Token = "0x600056C")]
	[Address(RVA = "0x6E3700", Offset = "0x6E1D00", VA = "0x1806E3700", Slot = "17")]
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

	// Token: 0x0600056D RID: 1389 RVA: 0x0001CC28 File Offset: 0x0001AE28
	[Token(Token = "0x600056D")]
	[Address(RVA = "0x6E3900", Offset = "0x6E1F00", VA = "0x1806E3900", Slot = "22")]
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

	// Token: 0x0600056E RID: 1390 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
	[Token(Token = "0x600056E")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_butter_portal()
	{
	}

	// Token: 0x04000365 RID: 869
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000365")]
	public GameObject holePrefab;
}
