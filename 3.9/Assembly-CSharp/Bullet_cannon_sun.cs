using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012F RID: 303
[Token(Token = "0x200012F")]
public class Bullet_cannon_sun : Bullet_cannon
{
	// Token: 0x060005B5 RID: 1461 RVA: 0x0001E230 File Offset: 0x0001C430
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x6E98F0", Offset = "0x6E7EF0", VA = "0x1806E98F0", Slot = "17")]
	public override void HitLand()
	{
		int num = 0;
		ScreenShake.TriggerShake(0.15f);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num++;
		}
		CreateItem instance = CreateItem.Instance;
		base.Die();
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0001E298 File Offset: 0x0001C498
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cannon_sun()
	{
	}
}
