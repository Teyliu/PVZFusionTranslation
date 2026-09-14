using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200013E RID: 318
[Token(Token = "0x200013E")]
public class Bullet_firePea_garlic : Bullet_firePea
{
	// Token: 0x060005F7 RID: 1527 RVA: 0x00020000 File Offset: 0x0001E200
	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x6C2EB0", Offset = "0x6C14B0", VA = "0x1806C2EB0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.FireZombie(zombie, num != 0);
		zombie.SetPoison(10f);
		Transform axis = zombie.axis;
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x0002005C File Offset: 0x0001E25C
	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_firePea_garlic()
	{
	}
}
