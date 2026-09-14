using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012A RID: 298
[Token(Token = "0x200012A")]
public class Bullet_cannon_sun : Bullet_cannon
{
	// Token: 0x060005AE RID: 1454 RVA: 0x0001EA60 File Offset: 0x0001CC60
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x6BEB30", Offset = "0x6BD130", VA = "0x1806BEB30", Slot = "18")]
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

	// Token: 0x060005AF RID: 1455 RVA: 0x0001EAC8 File Offset: 0x0001CCC8
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_cannon_sun()
	{
	}
}
