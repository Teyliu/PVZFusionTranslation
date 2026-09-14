using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000CB RID: 203
[Token(Token = "0x20000CB")]
public class MinesweeperCell : MonoBehaviour
{
	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060003A9 RID: 937 RVA: 0x000111A8 File Offset: 0x0000F3A8
	[Token(Token = "0x1700008A")]
	public bool IsMine
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x400CB0", Offset = "0x3FF2B0", VA = "0x180400CB0")]
		get
		{
			return this.isMine;
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060003AA RID: 938 RVA: 0x000111BC File Offset: 0x0000F3BC
	[Token(Token = "0x1700008B")]
	public int SurroundingMines
	{
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4F65C0", Offset = "0x4F4BC0", VA = "0x1804F65C0")]
		get
		{
			return this.surroundingMines;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060003AB RID: 939 RVA: 0x000111D0 File Offset: 0x0000F3D0
	[Token(Token = "0x1700008C")]
	public bool IsRevealed
	{
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4F65B0", Offset = "0x4F4BB0", VA = "0x1804F65B0")]
		get
		{
			return this.isRevealed;
		}
	}

	// Token: 0x060003AC RID: 940 RVA: 0x000111E4 File Offset: 0x0000F3E4
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x4F5BE0", Offset = "0x4F41E0", VA = "0x1804F5BE0")]
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

	// Token: 0x060003AD RID: 941 RVA: 0x00011230 File Offset: 0x0000F430
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x4F61E0", Offset = "0x4F47E0", VA = "0x1804F61E0")]
	private void Update()
	{
		ScaryPot scaryPot = this.scaryPot;
		int theItemRow = scaryPot.theItemRow;
		List<Plant> list = Lawnf.Get1x1Plants(scaryPot.theItemColumn, theItemRow);
		Func<Plant, bool> <>9__14_ = MinesweeperCell.<>c.<>9__14_0;
		if (<>9__14_ == 0)
		{
			MinesweeperCell.<>c.<>9__14_0 = (Plant p) => p.thePlantType == PlantType.IceBean;
		}
		if (!Enumerable.FirstOrDefault<Plant>(list, <>9__14_))
		{
			ScaryPot scaryPot2 = this.scaryPot;
			int theItemRow2 = scaryPot2.theItemRow;
			List<Plant> list2 = Lawnf.Get1x1Plants(scaryPot2.theItemColumn, theItemRow2);
			Func<Plant, bool> func;
			if (MinesweeperCell.<>c.<>9__14_1 == 0)
			{
				func = (Plant p) => p.thePlantType == PlantType.CherryBlover;
				MinesweeperCell.<>c.<>9__14_1 = func;
			}
			if (!Enumerable.FirstOrDefault<Plant>(list2, func))
			{
				ScaryPot scaryPot3 = this.scaryPot;
				int theItemRow3 = scaryPot3.theItemRow;
				uint num;
				List<Plant> rangePlants = Lawnf.GetRangePlants(scaryPot3.theItemColumn, theItemRow3, (int)num);
				Func<Plant, bool> func2;
				if (MinesweeperCell.<>c.<>9__14_2 == 0)
				{
					func2 = delegate(Plant p)
					{
						int thePlantType = (int)p.thePlantType;
						bool flag;
						return flag;
					};
					MinesweeperCell.<>c.<>9__14_2 = func2;
				}
				if (!Enumerable.FirstOrDefault<Plant>(rangePlants, func2))
				{
				}
			}
		}
		SpriteRenderer spriteRenderer = this.r;
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00011340 File Offset: 0x0000F540
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x4F5D70", Offset = "0x4F4370", VA = "0x1804F5D70")]
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

	// Token: 0x060003AF RID: 943 RVA: 0x0001140C File Offset: 0x0000F60C
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x4F5D10", Offset = "0x4F4310", VA = "0x1804F5D10")]
	private void OnMineHit()
	{
		GameAPP.PlaySound(93, 0.5f, 1f);
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x0001142C File Offset: 0x0000F62C
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x4F6080", Offset = "0x4F4680", VA = "0x1804F6080")]
	private void OnSafeHit()
	{
		if (this.surroundingMines == 0)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00011458 File Offset: 0x0000F658
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x4F6130", Offset = "0x4F4730", VA = "0x1804F6130")]
	private void RevealSurroundingCellsNow()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x0001147C File Offset: 0x0000F67C
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x4F5C90", Offset = "0x4F4290", VA = "0x1804F5C90")]
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

	// Token: 0x060003B3 RID: 947 RVA: 0x000114B8 File Offset: 0x0000F6B8
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public MinesweeperCell()
	{
	}

	// Token: 0x040001F6 RID: 502
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001F6")]
	private int row;

	// Token: 0x040001F7 RID: 503
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001F7")]
	private int col;

	// Token: 0x040001F8 RID: 504
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001F8")]
	private bool isMine;

	// Token: 0x040001F9 RID: 505
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001F9")]
	private int surroundingMines;

	// Token: 0x040001FA RID: 506
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001FA")]
	private bool isRevealed;

	// Token: 0x040001FB RID: 507
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001FB")]
	private ScaryPot scaryPot;

	// Token: 0x040001FC RID: 508
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001FC")]
	private SpriteRenderer r;
}
