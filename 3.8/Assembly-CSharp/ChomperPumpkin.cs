using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200036B RID: 875
[Token(Token = "0x200036B")]
public class ChomperPumpkin : Pumpkin
{
	// Token: 0x0600100E RID: 4110 RVA: 0x0005C8D0 File Offset: 0x0005AAD0
	[Token(Token = "0x600100E")]
	[Address(RVA = "0x425BA0", Offset = "0x4241A0", VA = "0x180425BA0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
		List<GameObject> list = this.stomach;
		List<GameObject> list2 = this.hideStomach;
		this.supplyTimer = 40f;
		int num = 0;
		GameObject gameObject = list[num];
		int size = list2._size;
		List<GameObject> list3 = this.stomach;
		int num2 = 0;
		GameObject gameObject2 = list3[num2];
		int num3 = 0;
		gameObject2.SetActive(num3 != 0);
		List<GameObject> list4 = this.stomach;
		int num4 = 0;
		list4.RemoveAt(num4);
		List<GameObject> list5 = this.stomach;
		List<GameObject> list6 = this.hideStomach;
		int num5 = 0;
		GameObject gameObject3 = list5[num5];
		int size2 = list6._size;
		List<GameObject> list7 = this.stomach;
		int num6 = 0;
		GameObject gameObject4 = list7[num6];
		int num7 = 0;
		gameObject4.SetActive(num7 != 0);
		List<GameObject> list8 = this.stomach;
		int num8 = 0;
		list8.RemoveAt(num8);
		List<GameObject> list9 = this.stomach;
		List<GameObject> list10 = this.hideStomach;
		int num9 = 0;
		GameObject gameObject5 = list9[num9];
		int size3 = list10._size;
		List<GameObject> list11 = this.stomach;
		int num10 = 0;
		GameObject gameObject6 = list11[num10];
		int num11 = 0;
		gameObject6.SetActive(num11 != 0);
		List<GameObject> list12 = this.stomach;
		int num12 = 0;
		list12.RemoveAt(num12);
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x0005CA10 File Offset: 0x0005AC10
	[Token(Token = "0x600100F")]
	[Address(RVA = "0x4258C0", Offset = "0x423EC0", VA = "0x1804258C0", Slot = "40")]
	protected override void AttributeEvent()
	{
		ulong num;
		do
		{
			List<GameObject> list = this.stomach;
			int thePlantRow = this.thePlantRow;
			List<Plant> list2 = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			Func<Plant, bool> <>9__4_ = ChomperPumpkin.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				Func<Plant, bool> func;
				ChomperPumpkin.<>c.<>9__4_0 = func;
			}
			List<Plant> list3 = Enumerable.ToList<Plant>(Enumerable.Where<Plant>(list2, <>9__4_));
			bool flag;
			if (flag)
			{
				this.anim.SetTrigger("chomp");
			}
		}
		while (num != (ulong)0L);
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x0005CA9C File Offset: 0x0005AC9C
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x425EC0", Offset = "0x4244C0", VA = "0x180425EC0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		List<GameObject> list = this.hideStomach;
		float num = this.supplyTimer;
		float deltaTime = Time.deltaTime;
		this.supplyTimer = num;
		List<GameObject> list2 = this.hideStomach;
		this.supplyTimer = 40f;
		int num2 = 0;
		list2[num2].SetActive(true);
		List<GameObject> list3 = this.hideStomach;
		List<GameObject> list4 = this.stomach;
		int num3 = 0;
		GameObject gameObject = list3[num3];
		List<GameObject> list5 = this.hideStomach;
		int num4 = 0;
		list5.RemoveAt(num4);
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x0005CB30 File Offset: 0x0005AD30
	[Token(Token = "0x6001011")]
	[Address(RVA = "0x425500", Offset = "0x423B00", VA = "0x180425500")]
	private void AnimChomp()
	{
		ulong num5;
		do
		{
			List<GameObject> list = this.stomach;
			int thePlantRow = this.thePlantRow;
			List<Plant> list2 = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			Func<Plant, bool> <>9__6_ = ChomperPumpkin.<>c.<>9__6_0;
			if (<>9__6_ == 0)
			{
				Func<Plant, bool> func;
				ChomperPumpkin.<>c.<>9__6_0 = func;
			}
			List<Plant> list3 = Enumerable.ToList<Plant>(Enumerable.Where<Plant>(list2, <>9__6_));
			bool flag;
			if (flag)
			{
				List<GameObject> list4 = this.hideStomach;
				List<GameObject> list5 = this.stomach;
				int num = 0;
				GameObject gameObject = list5[num];
				List<GameObject> list6 = this.stomach;
				int num2 = 0;
				GameObject gameObject2 = list6[num2];
				int num3 = 0;
				gameObject2.SetActive(num3 != 0);
				List<GameObject> list7 = this.stomach;
				int num4 = 0;
				list7.RemoveAt(num4);
			}
		}
		while (num5 != (ulong)0L);
		uint num6;
		GameAPP.PlaySound((int)num6, 0.5f, 1f);
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x0005CC20 File Offset: 0x0005AE20
	[Token(Token = "0x6001012")]
	[Address(RVA = "0x426040", Offset = "0x424640", VA = "0x180426040")]
	public ChomperPumpkin()
	{
		List<GameObject> list = new List();
		this.stomach = list;
		List<GameObject> list2 = new List();
		this.hideStomach = list2;
		base..ctor();
	}

	// Token: 0x04000B6A RID: 2922
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B6A")]
	public List<GameObject> stomach;

	// Token: 0x04000B6B RID: 2923
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B6B")]
	private readonly List<GameObject> hideStomach;

	// Token: 0x04000B6C RID: 2924
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B6C")]
	public float supplyTimer;
}
