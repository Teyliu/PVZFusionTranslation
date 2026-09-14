using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000118 RID: 280
[Token(Token = "0x2000118")]
public class Bullet_butter_jala : Bullet_cabbage
{
	// Token: 0x06000569 RID: 1385 RVA: 0x0001CA50 File Offset: 0x0001AC50
	[Token(Token = "0x6000569")]
	[Address(RVA = "0x6E30C0", Offset = "0x6E16C0", VA = "0x1806E30C0", Slot = "17")]
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

	// Token: 0x0600056A RID: 1386 RVA: 0x0001CAE0 File Offset: 0x0001ACE0
	[Token(Token = "0x600056A")]
	[Address(RVA = "0x6E33B0", Offset = "0x6E19B0", VA = "0x1806E33B0", Slot = "22")]
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

	// Token: 0x0600056B RID: 1387 RVA: 0x0001CB6C File Offset: 0x0001AD6C
	[Token(Token = "0x600056B")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_butter_jala()
	{
	}
}
