using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000114 RID: 276
[Token(Token = "0x2000114")]
public class Bullet_butter_squash : Bullet_squashMelon
{
	// Token: 0x0600055E RID: 1374 RVA: 0x0001D384 File Offset: 0x0001B584
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x6B8EB0", Offset = "0x6B74B0", VA = "0x1806B8EB0", Slot = "27")]
	protected override void ExtraEffect(GameObject obj)
	{
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			global::UnityEngine.Object.Destroy(obj);
		};
		delayAction.SetAction(action, 1f);
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
	[Token(Token = "0x600055F")]
	[Address(RVA = "0x6B8CC0", Offset = "0x6B72C0", VA = "0x1806B8CC0", Slot = "28")]
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

	// Token: 0x06000560 RID: 1376 RVA: 0x0001D410 File Offset: 0x0001B610
	[Token(Token = "0x6000560")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_butter_squash()
	{
	}
}
