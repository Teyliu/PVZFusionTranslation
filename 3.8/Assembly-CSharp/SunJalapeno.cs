using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000322 RID: 802
[Token(Token = "0x2000322")]
public class SunJalapeno : Jalapeno
{
	// Token: 0x06000E96 RID: 3734 RVA: 0x00053648 File Offset: 0x00051848
	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x413AB0", Offset = "0x4120B0", VA = "0x180413AB0")]
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

	// Token: 0x06000E97 RID: 3735 RVA: 0x000536FC File Offset: 0x000518FC
	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x4139E0", Offset = "0x411FE0", VA = "0x1804139E0")]
	private void Action(Zombie zombie)
	{
		CreateItem instance = CreateItem.Instance;
		Transform axis = zombie.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00053728 File Offset: 0x00051928
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x413E50", Offset = "0x412450", VA = "0x180413E50", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
		this.AnimExplode();
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00053744 File Offset: 0x00051944
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SunJalapeno()
	{
	}
}
