using System;
using System.Collections;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200032F RID: 815
[Token(Token = "0x200032F")]
public class SquashKelp : Tanglekelp
{
	// Token: 0x06000ED3 RID: 3795 RVA: 0x0005433C File Offset: 0x0005253C
	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x469AC0", Offset = "0x4680C0", VA = "0x180469AC0", Slot = "70")]
	protected override void GrabPrepare()
	{
		int thePlantRow = this.thePlantRow;
		SortingGroup grabSort = this.grabSort;
		string text = string.Format("zombie{0}", thePlantRow);
		grabSort.sortingLayerName = text;
		Zombie targetZombie = this.targetZombie;
		SortingGroup grabSort2 = this.grabSort;
		int num = targetZombie.sortingGroup.sortingOrder + 1;
		grabSort2.sortingOrder = num;
		AnimatorControllerParameter[] parameters = this.anim.parameters;
		Func<AnimatorControllerParameter, bool> <>9__0_ = SquashKelp.<>c.<>9__0_0;
		if (<>9__0_ == 0)
		{
			SquashKelp.<>c.<>9__0_0 = (AnimatorControllerParameter param) => string.Equals(param.name, "down");
		}
		if (Enumerable.Any<AnimatorControllerParameter>(parameters, <>9__0_))
		{
			this.anim.SetTrigger("down");
		}
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x000543E4 File Offset: 0x000525E4
	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x469920", Offset = "0x467F20", VA = "0x180469920")]
	private void AnimSquash()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00054430 File Offset: 0x00052630
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x469CF0", Offset = "0x4682F0", VA = "0x180469CF0", Slot = "71")]
	protected override IEnumerator Moving()
	{
		SquashKelp.<Moving>d__2 <Moving>d__;
		<Moving>d__.System.IDisposable.Dispose();
		<Moving>d__.<>1__state = (int)((ulong)0L);
		<Moving>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00054454 File Offset: 0x00052654
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x459540", Offset = "0x457B40", VA = "0x180459540")]
	public SquashKelp()
	{
		this.range = (ulong)1073741824L;
		this.range.y = 2f;
		base..ctor();
	}
}
