using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000C6 RID: 198
[Token(Token = "0x20000C6")]
public class MinesweeperCell : MonoBehaviour
{
	// Token: 0x1700004D RID: 77
	// (get) Token: 0x0600038E RID: 910 RVA: 0x00010E64 File Offset: 0x0000F064
	[Token(Token = "0x1700004D")]
	public bool IsMine
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x3B3F20", Offset = "0x3B2520", VA = "0x1803B3F20")]
		get
		{
			return this.isMine;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x0600038F RID: 911 RVA: 0x00010E78 File Offset: 0x0000F078
	[Token(Token = "0x1700004E")]
	public int SurroundingMines
	{
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x4B6F00", Offset = "0x4B5500", VA = "0x1804B6F00")]
		get
		{
			return this.surroundingMines;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000390 RID: 912 RVA: 0x00010E8C File Offset: 0x0000F08C
	[Token(Token = "0x1700004F")]
	public bool IsRevealed
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x4B6EF0", Offset = "0x4B54F0", VA = "0x1804B6EF0")]
		get
		{
			return this.isRevealed;
		}
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00010EA0 File Offset: 0x0000F0A0
	[Token(Token = "0x6000391")]
	[Address(RVA = "0x4B6520", Offset = "0x4B4B20", VA = "0x1804B6520")]
	public void Initialize(int row, int col, bool isMine, int surroundingMines)
	{
		this.surroundingMines = 0;
		this.row = row;
		this.col = col;
		this.isMine = isMine;
		this.isRevealed = false;
		ScaryPot component = base.GetComponent<ScaryPot>();
		this.scaryPot = component;
		SpriteRenderer component2 = base.GetComponent<SpriteRenderer>();
		this.r = component2;
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00010EEC File Offset: 0x0000F0EC
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x4B6B20", Offset = "0x4B5120", VA = "0x1804B6B20")]
	private void Update()
	{
		ScaryPot scaryPot = this.scaryPot;
		int theItemRow = scaryPot.theItemRow;
		List<Plant> list = Lawnf.Get1x1Plants(scaryPot.theItemColumn, theItemRow);
		Func<Plant, bool> <>9__14_ = MinesweeperCell.<>c.<>9__14_0;
		if (<>9__14_ == 0)
		{
			Func<Plant, bool> func;
			MinesweeperCell.<>c.<>9__14_0 = func;
		}
		if (!Enumerable.FirstOrDefault<Plant>(list, <>9__14_))
		{
			ScaryPot scaryPot2 = this.scaryPot;
			int theItemRow2 = scaryPot2.theItemRow;
			List<Plant> list2 = Lawnf.Get1x1Plants(scaryPot2.theItemColumn, theItemRow2);
			Func<Plant, bool> func2;
			if (MinesweeperCell.<>c.<>9__14_1 == 0)
			{
				MinesweeperCell.<>c.<>9__14_1 = func2;
			}
			if (!Enumerable.FirstOrDefault<Plant>(list2, func2))
			{
				ScaryPot scaryPot3 = this.scaryPot;
				int theItemRow3 = scaryPot3.theItemRow;
				uint num;
				List<Plant> rangePlants = Lawnf.GetRangePlants(scaryPot3.theItemColumn, theItemRow3, (int)num);
				Func<Plant, bool> func3;
				if (MinesweeperCell.<>c.<>9__14_2 == 0)
				{
					MinesweeperCell.<>c.<>9__14_2 = func3;
				}
				if (!Enumerable.FirstOrDefault<Plant>(rangePlants, func3))
				{
				}
			}
		}
		SpriteRenderer spriteRenderer = this.r;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00010FCC File Offset: 0x0000F1CC
	[Token(Token = "0x6000393")]
	[Address(RVA = "0x4B66B0", Offset = "0x4B4CB0", VA = "0x1804B66B0")]
	public void OnPotDestroyed()
	{
		if (!this.isRevealed)
		{
			this.isRevealed = true;
			if (!this.isMine)
			{
				if (this.surroundingMines != 0)
				{
					goto IL_004A;
				}
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			IL_004A:
			MinesweeperManager <Instance>k__BackingField = MinesweeperManager.<Instance>k__BackingField;
			int num2 = 0;
			if (<Instance>k__BackingField != num2)
			{
				bool flag = this.isMine;
				MinesweeperManager <Instance>k__BackingField2 = MinesweeperManager.<Instance>k__BackingField;
				if (!<Instance>k__BackingField2.hasGenerated)
				{
					int num3 = this.col;
					int num4 = this.row;
					<Instance>k__BackingField2.GenerateMinesOnFirstClick(num4, num3);
				}
				if (!flag)
				{
					int num6;
					int num7;
					int num5 = num6 * num7;
					throw new NullReferenceException();
				}
				if (!<Instance>k__BackingField2.wined)
				{
					UIMgr.EnterLoseMenu("你踩到了地雷！");
				}
			}
		}
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00011098 File Offset: 0x0000F298
	[Token(Token = "0x6000394")]
	[Address(RVA = "0x4B6650", Offset = "0x4B4C50", VA = "0x1804B6650")]
	private void OnMineHit()
	{
		GameAPP.PlaySound(93, 0.5f, 1f);
	}

	// Token: 0x06000395 RID: 917 RVA: 0x000110B8 File Offset: 0x0000F2B8
	[Token(Token = "0x6000395")]
	[Address(RVA = "0x4B69C0", Offset = "0x4B4FC0", VA = "0x1804B69C0")]
	private void OnSafeHit()
	{
		if (this.surroundingMines == 0)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}
	}

	// Token: 0x06000396 RID: 918 RVA: 0x000110E4 File Offset: 0x0000F2E4
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x4B6A70", Offset = "0x4B5070", VA = "0x1804B6A70")]
	private void RevealSurroundingCellsNow()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00011108 File Offset: 0x0000F308
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x4B65D0", Offset = "0x4B4BD0", VA = "0x1804B65D0")]
	public void ManualReveal()
	{
		if (!this.isRevealed)
		{
			ScaryPot scaryPot = this.scaryPot;
			int num = 0;
			if (scaryPot != num)
			{
				this.scaryPot.Hitted();
				return;
			}
		}
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00011144 File Offset: 0x0000F344
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public MinesweeperCell()
	{
	}

	// Token: 0x040001E9 RID: 489
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E9")]
	private int row;

	// Token: 0x040001EA RID: 490
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001EA")]
	private int col;

	// Token: 0x040001EB RID: 491
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001EB")]
	private bool isMine;

	// Token: 0x040001EC RID: 492
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001EC")]
	private int surroundingMines;

	// Token: 0x040001ED RID: 493
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001ED")]
	private bool isRevealed;

	// Token: 0x040001EE RID: 494
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001EE")]
	private ScaryPot scaryPot;

	// Token: 0x040001EF RID: 495
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001EF")]
	private SpriteRenderer r;
}
