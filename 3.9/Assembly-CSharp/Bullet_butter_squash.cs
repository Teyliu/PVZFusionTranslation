using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011A RID: 282
[Token(Token = "0x200011A")]
public class Bullet_butter_squash : Bullet_squashMelon
{
	// Token: 0x0600056F RID: 1391 RVA: 0x0001CD08 File Offset: 0x0001AF08
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x6E3DA0", Offset = "0x6E23A0", VA = "0x1806E3DA0", Slot = "25")]
	protected override void ExtraEffect(GameObject obj)
	{
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			global::UnityEngine.Object.Destroy(obj);
		};
		delayAction.SetAction(action, 1f);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0001CD48 File Offset: 0x0001AF48
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x6E3BB0", Offset = "0x6E21B0", VA = "0x1806E3BB0", Slot = "26")]
	protected override void AttackZombies(Vector2 center, int row, int maxRow)
	{
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				num -= row;
				if (Lawnf.ThrowLandStatus((ZombieStatus)num))
				{
					PlantType fromType = this.fromType;
					num++;
					if (num < 3)
					{
					}
				}
			}
			num++;
		}
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0001CD94 File Offset: 0x0001AF94
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_butter_squash()
	{
	}
}
