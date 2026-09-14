using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000112 RID: 274
[Token(Token = "0x2000112")]
public class Bullet_butter_jala : Bullet_cabbage
{
	// Token: 0x06000558 RID: 1368 RVA: 0x0001D0CC File Offset: 0x0001B2CC
	[Token(Token = "0x6000558")]
	[Address(RVA = "0x6B81D0", Offset = "0x6B67D0", VA = "0x1806B81D0", Slot = "18")]
	public override void HitLand()
	{
		int num;
		do
		{
			bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)27));
			BoardAction boardAction = this.board.boardAction;
			if (!flag)
			{
			}
			num = 0;
			PlantType fromType = this.fromType;
			int theBulletRow = this.theBulletRow;
			int theBulletRow2 = this.theBulletRow;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(this.board, theBulletRow2);
			bool flag2;
			bool flag3;
			if (!flag2 || flag3)
			{
			}
		}
		while (num != 0);
		GameAPP.PlaySound(100, 0.5f, 1f);
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0001D15C File Offset: 0x0001B35C
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x6B84C0", Offset = "0x6B6AC0", VA = "0x1806B84C0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num;
		do
		{
			zombie.SetJalaed();
			bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)27));
			BoardAction boardAction = this.board.boardAction;
			if (!flag)
			{
			}
			num = 0;
			PlantType fromType = this.fromType;
			int theZombieRow = zombie.theZombieRow;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(this.board, theZombieRow);
			bool flag2;
			bool flag3;
			if (!flag2 || flag3)
			{
			}
		}
		while (num != 0);
		GameAPP.PlaySound(100, 0.5f, 1f);
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
	[Token(Token = "0x600055A")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_butter_jala()
	{
	}
}
