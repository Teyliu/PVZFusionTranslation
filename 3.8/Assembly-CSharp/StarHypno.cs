using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002DA RID: 730
[Token(Token = "0x20002DA")]
public class StarHypno : Plant
{
	// Token: 0x06000D1C RID: 3356 RVA: 0x0004BA88 File Offset: 0x00049C88
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x3FB5B0", Offset = "0x3F9BB0", VA = "0x1803FB5B0", Slot = "64")]
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

	// Token: 0x06000D1D RID: 3357 RVA: 0x0004BB14 File Offset: 0x00049D14
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public StarHypno()
	{
	}
}
