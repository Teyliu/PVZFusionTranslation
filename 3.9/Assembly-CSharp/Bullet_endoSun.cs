using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200013C RID: 316
[Token(Token = "0x200013C")]
public class Bullet_endoSun : Bullet
{
	// Token: 0x060005E2 RID: 1506 RVA: 0x0001F030 File Offset: 0x0001D230
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x6EC820", Offset = "0x6EAE20", VA = "0x1806EC820", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0001F08C File Offset: 0x0001D28C
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x6EC690", Offset = "0x6EAC90", VA = "0x1806EC690", Slot = "17")]
	public override void HitLand()
	{
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		CreateItem instance2 = CreateItem.Instance;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		base.Die();
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0001F0D8 File Offset: 0x0001D2D8
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x6EC5C0", Offset = "0x6EABC0", VA = "0x1806EC5C0", Slot = "15")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Vector2 velocity = this.rb.velocity;
		int num = 0;
		if (velocity <= num)
		{
			Transform transform = base.transform;
			int num2 = 0;
			Transform child = transform.GetChild(num2);
			float deltaTime = Time.deltaTime;
		}
		Transform transform2 = base.transform;
		int num3 = 0;
		Transform child2 = transform2.GetChild(num3);
		float num4 = Time.deltaTime * -600f;
		int num5 = 0;
		int num6 = 0;
		child2.Rotate((float)num6, (float)num5, num4);
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0001F15C File Offset: 0x0001D35C
	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_endoSun()
	{
	}
}
