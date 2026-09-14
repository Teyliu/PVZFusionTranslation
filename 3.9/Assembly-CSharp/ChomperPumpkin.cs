using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200037B RID: 891
[Token(Token = "0x200037B")]
public class ChomperPumpkin : Pumpkin
{
	// Token: 0x06001059 RID: 4185 RVA: 0x0005D838 File Offset: 0x0005BA38
	[Token(Token = "0x6001059")]
	[Address(RVA = "0x47C890", Offset = "0x47AE90", VA = "0x18047C890", Slot = "10")]
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

	// Token: 0x0600105A RID: 4186 RVA: 0x0005D978 File Offset: 0x0005BB78
	[Token(Token = "0x600105A")]
	[Address(RVA = "0x47C5B0", Offset = "0x47ABB0", VA = "0x18047C5B0", Slot = "39")]
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
				ChomperPumpkin.<>c.<>9__4_0 = delegate(Plant p)
				{
					int num2 = 0;
					if (p != 0)
					{
					}
					return num2 != 0;
				};
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

	// Token: 0x0600105B RID: 4187 RVA: 0x0005DA10 File Offset: 0x0005BC10
	[Token(Token = "0x600105B")]
	[Address(RVA = "0x47CBB0", Offset = "0x47B1B0", VA = "0x18047CBB0", Slot = "16")]
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

	// Token: 0x0600105C RID: 4188 RVA: 0x0005DAA4 File Offset: 0x0005BCA4
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x47C1F0", Offset = "0x47A7F0", VA = "0x18047C1F0")]
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
				ChomperPumpkin.<>c.<>9__6_0 = delegate(Plant p)
				{
					int num7 = 0;
					if (p != 0)
					{
					}
					return num7 != 0;
				};
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

	// Token: 0x0600105D RID: 4189 RVA: 0x0005DBA4 File Offset: 0x0005BDA4
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x47CD30", Offset = "0x47B330", VA = "0x18047CD30")]
	public ChomperPumpkin()
	{
		List<GameObject> list = new List();
		this.stomach = list;
		List<GameObject> list2 = new List();
		this.hideStomach = list2;
		base..ctor();
	}

	// Token: 0x04000BBA RID: 3002
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BBA")]
	public List<GameObject> stomach;

	// Token: 0x04000BBB RID: 3003
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BBB")]
	private readonly List<GameObject> hideStomach;

	// Token: 0x04000BBC RID: 3004
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BBC")]
	public float supplyTimer;
}
