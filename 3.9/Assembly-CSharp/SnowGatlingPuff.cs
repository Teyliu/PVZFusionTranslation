using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058C RID: 1420
[Token(Token = "0x200058C")]
public class SnowGatlingPuff : IcePuff
{
	// Token: 0x06001A65 RID: 6757 RVA: 0x0008DCC4 File Offset: 0x0008BEC4
	[Token(Token = "0x6001A65")]
	[Address(RVA = "0x540980", Offset = "0x53EF80", VA = "0x180540980", Slot = "68")]
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

	// Token: 0x06001A66 RID: 6758 RVA: 0x0008DD28 File Offset: 0x0008BF28
	[Token(Token = "0x6001A66")]
	[Address(RVA = "0x540AB0", Offset = "0x53F0B0", VA = "0x180540AB0")]
	public SnowGatlingPuff()
	{
	}

	// Token: 0x04000F03 RID: 3843
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F03")]
	public bool skin;
}
