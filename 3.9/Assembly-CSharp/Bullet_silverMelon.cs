using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A1 RID: 417
[Token(Token = "0x20001A1")]
public class Bullet_silverMelon : Bullet_melon
{
	// Token: 0x0600073B RID: 1851 RVA: 0x00024AA0 File Offset: 0x00022CA0
	[Token(Token = "0x600073B")]
	[Address(RVA = "0x80D660", Offset = "0x80BC60", VA = "0x18080D660", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		int num2 = 0;
		base.AttackOtherZombie(num2, (MelonSputterType)num);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00024AF8 File Offset: 0x00022CF8
	[Token(Token = "0x600073C")]
	[Address(RVA = "0x80D780", Offset = "0x80BD80", VA = "0x18080D780", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		int num2 = 0;
		base.AttackOtherZombie(zombie, (MelonSputterType)num2);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00024B6C File Offset: 0x00022D6C
	[Token(Token = "0x600073D")]
	[Address(RVA = "0x80D8F0", Offset = "0x80BEF0", VA = "0x18080D8F0")]
	public Bullet_silverMelon()
	{
	}
}
