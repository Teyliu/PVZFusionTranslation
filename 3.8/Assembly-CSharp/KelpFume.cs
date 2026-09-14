using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000523 RID: 1315
[Token(Token = "0x2000523")]
public class KelpFume : FumeShroom
{
	// Token: 0x06001874 RID: 6260 RVA: 0x00084F10 File Offset: 0x00083110
	[Token(Token = "0x6001874")]
	[Address(RVA = "0x4D0850", Offset = "0x4CEE50", VA = "0x1804D0850", Slot = "10")]
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

	// Token: 0x06001875 RID: 6261 RVA: 0x00084F64 File Offset: 0x00083164
	[Token(Token = "0x6001875")]
	[Address(RVA = "0x4D0BB0", Offset = "0x4CF1B0", VA = "0x1804D0BB0", Slot = "54")]
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

	// Token: 0x06001876 RID: 6262 RVA: 0x00084FA0 File Offset: 0x000831A0
	[Token(Token = "0x6001876")]
	[Address(RVA = "0x4D0A20", Offset = "0x4CF020", VA = "0x1804D0A20", Slot = "55")]
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

	// Token: 0x06001877 RID: 6263 RVA: 0x00084FDC File Offset: 0x000831DC
	[Token(Token = "0x6001877")]
	[Address(RVA = "0x4D0D90", Offset = "0x4CF390", VA = "0x1804D0D90", Slot = "69")]
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

	// Token: 0x06001878 RID: 6264 RVA: 0x00085028 File Offset: 0x00083228
	[Token(Token = "0x6001878")]
	[Address(RVA = "0x4D0720", Offset = "0x4CED20", VA = "0x1804D0720", Slot = "74")]
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

	// Token: 0x06001879 RID: 6265 RVA: 0x00085068 File Offset: 0x00083268
	[Token(Token = "0x6001879")]
	[Address(RVA = "0x4D0D70", Offset = "0x4CF370", VA = "0x1804D0D70", Slot = "48")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		return global::Lawnf.ThrowLandStatus(zombie.theStatus);
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x00085088 File Offset: 0x00083288
	[Token(Token = "0x600187A")]
	[Address(RVA = "0x4D0E50", Offset = "0x4CF450", VA = "0x1804D0E50")]
	public KelpFume()
	{
		List<SortingGroup> list = new List();
		this.groups = list;
		this.range = 7f;
		base..ctor();
	}

	// Token: 0x04000E0E RID: 3598
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E0E")]
	private List<SortingGroup> groups;
}
