using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000332 RID: 818
[Token(Token = "0x2000332")]
public class SunJalapeno : Jalapeno
{
	// Token: 0x06000EE0 RID: 3808 RVA: 0x00054660 File Offset: 0x00052860
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x46A3A0", Offset = "0x4689A0", VA = "0x18046A3A0")]
	public new void AnimExplode()
	{
		int num3;
		do
		{
			int num = 0;
			base.Die((Plant.DieReason)num);
			Predicate<Plant> predicate;
			List<Plant> list = Lawnf.GetAllPlants().FindAll(predicate);
			BoardAction boardAction = this.board.boardAction;
			int thePlantRow = this.thePlantRow;
			int attackDamage = this.attackDamage;
			int size = list._size;
			PlantType thePlantType = this.thePlantType;
			long num2 = (long)(size * (int)((uint)500));
			num2 += (long)attackDamage;
			num3 = 0;
			int num4 = 0;
			ulong num5;
			Action<Zombie> action;
			boardAction.CreateFireLine(thePlantRow, (int)num2, num4 != 0, num3 != 0, num5 != 0UL, action, thePlantType);
			bool flag;
			if (flag)
			{
				uint num6;
				if (global::UnityEngine.Random.Range(0, (int)num6) == 0)
				{
				}
				CreateItem instance = CreateItem.Instance;
			}
		}
		while (num3 != 0);
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00054714 File Offset: 0x00052914
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x46A2D0", Offset = "0x4688D0", VA = "0x18046A2D0")]
	private void Action(Zombie zombie)
	{
		CreateItem instance = CreateItem.Instance;
		Transform axis = zombie.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00054740 File Offset: 0x00052940
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x46A740", Offset = "0x468D40", VA = "0x18046A740", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
		this.AnimExplode();
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x0005475C File Offset: 0x0005295C
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SunJalapeno()
	{
	}
}
