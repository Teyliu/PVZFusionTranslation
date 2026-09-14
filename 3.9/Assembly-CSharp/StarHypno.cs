using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E8 RID: 744
[Token(Token = "0x20002E8")]
public class StarHypno : Plant
{
	// Token: 0x06000D5F RID: 3423 RVA: 0x0004C694 File Offset: 0x0004A894
	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x43F1B0", Offset = "0x43D7B0", VA = "0x18043F1B0", Slot = "63")]
	public override bool OnEat(Zombie zombie)
	{
		StarHypno.<>c__DisplayClass0_0 CS$<>8__locals1 = new StarHypno.<>c__DisplayClass0_0();
		CS$<>8__locals1.zombie = zombie;
		int num = 0;
		base.Die((Plant.DieReason)num);
		Zombie zombie2 = CS$<>8__locals1.zombie;
		PlantType thePlantType = this.thePlantType;
		int num2 = 0;
		CS$<>8__locals1.pt = thePlantType;
		int attackDamage = this.attackDamage;
		CS$<>8__locals1.at = attackDamage;
		int k = num2;
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			Zombie zombie3 = CS$<>8__locals1.zombie;
			int num3 = 0;
			if (zombie3 != num3)
			{
				Collider2D col = CS$<>8__locals1.zombie.col;
				int num4 = 0;
				if (col != num4 && CS$<>8__locals1.zombie.col.enabled)
				{
					Collider2D col2 = CS$<>8__locals1.zombie.col;
					int num5 = 0;
					Zombie zombie4 = CS$<>8__locals1.zombie;
					CreateBullet instance = CreateBullet.Instance;
					int theZombieRow = zombie4.theZombieRow;
					PlantType pt = CS$<>8__locals1.pt;
					Bullet bullet;
					bullet.fromType = pt;
					int at = CS$<>8__locals1.at;
					bullet.Damage = at;
					Transform transform = bullet.transform;
					int num6 = k;
					int num7 = 0;
					num6 += num5;
					int num8 = 0;
					transform.Rotate((float)num8, (float)num7, (float)theZombieRow);
					num5 += 3;
				}
			}
		};
		num2++;
		return true;
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x0004C720 File Offset: 0x0004A920
	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public StarHypno()
	{
	}
}
