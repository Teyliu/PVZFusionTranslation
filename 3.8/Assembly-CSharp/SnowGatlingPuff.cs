using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200055C RID: 1372
[Token(Token = "0x200055C")]
public class SnowGatlingPuff : IcePuff
{
	// Token: 0x06001985 RID: 6533 RVA: 0x00089C3C File Offset: 0x00087E3C
	[Token(Token = "0x6001985")]
	[Address(RVA = "0x4E2520", Offset = "0x4E0B20", VA = "0x1804E2520", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(68, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x00089CA0 File Offset: 0x00087EA0
	[Token(Token = "0x6001986")]
	[Address(RVA = "0x4C8690", Offset = "0x4C6C90", VA = "0x1804C8690")]
	public SnowGatlingPuff()
	{
	}

	// Token: 0x04000E45 RID: 3653
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E45")]
	public bool skin;
}
