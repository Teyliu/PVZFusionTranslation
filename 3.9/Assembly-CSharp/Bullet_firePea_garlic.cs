using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000143 RID: 323
[Token(Token = "0x2000143")]
public class Bullet_firePea_garlic : Bullet_firePea
{
	// Token: 0x060005FE RID: 1534 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x6EDC90", Offset = "0x6EC290", VA = "0x1806EDC90", Slot = "22")]
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

	// Token: 0x060005FF RID: 1535 RVA: 0x0001F844 File Offset: 0x0001DA44
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_firePea_garlic()
	{
	}
}
