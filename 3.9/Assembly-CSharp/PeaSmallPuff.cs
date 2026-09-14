using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000573 RID: 1395
[Token(Token = "0x2000573")]
public class PeaSmallPuff : Shooter
{
	// Token: 0x060019E9 RID: 6633 RVA: 0x0008B87C File Offset: 0x00089A7C
	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x539190", Offset = "0x537790", VA = "0x180539190", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x0008B8D4 File Offset: 0x00089AD4
	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PeaSmallPuff()
	{
	}
}
