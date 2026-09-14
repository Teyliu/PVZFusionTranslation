using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000550 RID: 1360
[Token(Token = "0x2000550")]
public class KelpFume : FumeShroom
{
	// Token: 0x06001943 RID: 6467 RVA: 0x00088AA4 File Offset: 0x00086CA4
	[Token(Token = "0x6001943")]
	[Address(RVA = "0x52D180", Offset = "0x52B780", VA = "0x18052D180", Slot = "10")]
	protected override void Awake()
	{
		ulong num;
		do
		{
			base.Awake();
			List<SortingGroup> childs = global::Core.Lawnf.GetChilds<SortingGroup>(base.transform);
			this.groups = childs;
			List<SortingGroup> list = this.groups;
			bool flag;
			if (flag)
			{
				SpriteRenderer spriteRenderer;
				int sortingOrder = spriteRenderer.sortingOrder;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x00088AF8 File Offset: 0x00086CF8
	[Token(Token = "0x6001944")]
	[Address(RVA = "0x52D4E0", Offset = "0x52BAE0", VA = "0x18052D4E0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		do
		{
			List<SortingGroup> list = this.groups;
			bool flag;
			if (flag)
			{
				string text = string.Format("bullet{0}", flag);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x00088B34 File Offset: 0x00086D34
	[Token(Token = "0x6001945")]
	[Address(RVA = "0x52D350", Offset = "0x52B950", VA = "0x18052D350", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		do
		{
			List<SortingGroup> list = this.groups;
			bool flag;
			if (flag)
			{
				string text = string.Format("bullet{0}", flag);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00088B70 File Offset: 0x00086D70
	[Token(Token = "0x6001946")]
	[Address(RVA = "0x52D6C0", Offset = "0x52BCC0", VA = "0x18052D6C0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		base.AttackZombie();
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num == 3)
		{
			this.attributeCount = (int)((ulong)0L);
		}
		return null;
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00088BBC File Offset: 0x00086DBC
	[Token(Token = "0x6001947")]
	[Address(RVA = "0x52D050", Offset = "0x52B650", VA = "0x18052D050", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		int num = 0;
		zombie.SetKelped(10f, num != 0);
		PlantType thePlantType = this.thePlantType;
		int attributeCount = this.attributeCount;
		if (attributeCount == 0)
		{
			throw new NullReferenceException();
		}
		if (attributeCount != 0)
		{
			if (attributeCount == 1)
			{
			}
			return;
		}
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x00088BFC File Offset: 0x00086DFC
	[Token(Token = "0x6001948")]
	[Address(RVA = "0x52D6A0", Offset = "0x52BCA0", VA = "0x18052D6A0", Slot = "47")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		return global::Lawnf.ThrowLandStatus(zombie.theStatus);
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x00088C1C File Offset: 0x00086E1C
	[Token(Token = "0x6001949")]
	[Address(RVA = "0x52D780", Offset = "0x52BD80", VA = "0x18052D780")]
	public KelpFume()
	{
		List<SortingGroup> list = new List();
		this.groups = list;
		this.range = 7f;
		base..ctor();
	}

	// Token: 0x04000EC7 RID: 3783
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EC7")]
	private List<SortingGroup> groups;
}
