using System;
using System.Collections;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200031F RID: 799
[Token(Token = "0x200031F")]
public class SquashKelp : Tanglekelp
{
	// Token: 0x06000E89 RID: 3721 RVA: 0x00053334 File Offset: 0x00051534
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x413740", Offset = "0x411D40", VA = "0x180413740", Slot = "71")]
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
			Func<AnimatorControllerParameter, bool> func;
			SquashKelp.<>c.<>9__0_0 = func;
		}
		if (Enumerable.Any<AnimatorControllerParameter>(parameters, <>9__0_))
		{
			this.anim.SetTrigger("down");
		}
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x000533CC File Offset: 0x000515CC
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x4135A0", Offset = "0x411BA0", VA = "0x1804135A0")]
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

	// Token: 0x06000E8B RID: 3723 RVA: 0x00053418 File Offset: 0x00051618
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x413970", Offset = "0x411F70", VA = "0x180413970", Slot = "72")]
	protected override IEnumerator Moving()
	{
		SquashKelp.<Moving>d__2 <Moving>d__;
		<Moving>d__.System.IDisposable.Dispose();
		<Moving>d__.<>1__state = (int)((ulong)0L);
		<Moving>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x0005343C File Offset: 0x0005163C
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x402450", Offset = "0x400A50", VA = "0x180402450")]
	public SquashKelp()
	{
		this.range = (ulong)1073741824L;
		this.range.y = 2f;
		base..ctor();
	}
}
