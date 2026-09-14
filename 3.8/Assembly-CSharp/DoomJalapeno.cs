using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000302 RID: 770
[Token(Token = "0x2000302")]
public class DoomJalapeno : Plant
{
	// Token: 0x06000E12 RID: 3602 RVA: 0x00051350 File Offset: 0x0004F550
	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x401FB0", Offset = "0x4005B0", VA = "0x180401FB0")]
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

	// Token: 0x06000E13 RID: 3603 RVA: 0x00051428 File Offset: 0x0004F628
	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x4023A0", Offset = "0x4009A0", VA = "0x1804023A0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
		this.AnimExplode();
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00051444 File Offset: 0x0004F644
	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomJalapeno()
	{
	}
}
