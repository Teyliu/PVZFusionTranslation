using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000148 RID: 328
[Token(Token = "0x2000148")]
public class Bullet_goldSquashKelp : Bullet_squashKelp
{
	// Token: 0x06000616 RID: 1558 RVA: 0x000207B8 File Offset: 0x0001E9B8
	[Token(Token = "0x6000616")]
	[Address(RVA = "0x6C45F0", Offset = "0x6C2BF0", VA = "0x1806C45F0", Slot = "27")]
	protected override void AttackZombie()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		int num3 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theBulletRow = this.theBulletRow;
				PlantType fromType = this.fromType;
			}
			num++;
		}
		if (num3 != 0)
		{
			uint num4;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
		}
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x00020824 File Offset: 0x0001EA24
	[Token(Token = "0x6000617")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_goldSquashKelp()
	{
	}
}
