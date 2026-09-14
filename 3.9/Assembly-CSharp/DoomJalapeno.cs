using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000312 RID: 786
[Token(Token = "0x2000312")]
public class DoomJalapeno : Plant
{
	// Token: 0x06000E5B RID: 3675 RVA: 0x000522F0 File Offset: 0x000504F0
	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x446260", Offset = "0x444860", VA = "0x180446260")]
	public void AnimExplode()
	{
		int num;
		do
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
			num = 0;
			int num2 = 0;
			int attackDamage = this.attackDamage;
			int thePlantRow = this.thePlantRow;
			ulong num3;
			boardAction.CreateFireLine(thePlantRow, attackDamage, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
			int num4 = 0;
			base.Die((Plant.DieReason)num4);
			BoardAction boardAction2 = this.board.boardAction;
			int attackDamage2 = this.attackDamage;
			PlantType thePlantType2 = this.thePlantType;
			Board board = this.board;
			if (num >= board.columnNum)
			{
				return;
			}
			int thePlantRow2 = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(num, thePlantRow2);
			bool flag;
			if (flag)
			{
				while (flag)
				{
				}
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num != 0);
		num++;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x000523C8 File Offset: 0x000505C8
	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x446650", Offset = "0x444C50", VA = "0x180446650", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
		this.AnimExplode();
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x000523E4 File Offset: 0x000505E4
	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomJalapeno()
	{
	}
}
