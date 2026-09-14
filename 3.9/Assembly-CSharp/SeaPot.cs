using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000435 RID: 1077
[Token(Token = "0x2000435")]
public class SeaPot : Pot
{
	// Token: 0x060013DE RID: 5086 RVA: 0x0006EEF4 File Offset: 0x0006D0F4
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x4BC450", Offset = "0x4BAA50", VA = "0x1804BC450", Slot = "38")]
	protected override void OnUpdate()
	{
		base.OnFixedUpdate();
		bool flag = this.CheckSurroundingWater();
		this.waterObj.SetActive(flag);
		if (flag != this.lastWaterState)
		{
			if (!flag)
			{
				this.RemoveWaterFromSurrounding();
				this.lastWaterState = flag;
				return;
			}
			this.AddWaterToSurrounding();
			this.lastWaterState = flag;
		}
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x0006EF48 File Offset: 0x0006D148
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x4BC360", Offset = "0x4BA960", VA = "0x1804BC360", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x0006EF6C File Offset: 0x0006D16C
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x4BC340", Offset = "0x4BA940", VA = "0x1804BC340", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		base.DieEventMustExecute(reason);
		this.RemoveWaterFromSurrounding();
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x0006EF88 File Offset: 0x0006D188
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x4BC2B0", Offset = "0x4BA8B0", VA = "0x1804BC2B0")]
	private bool CheckSurroundingWater()
	{
		Board board = this.board;
		int num = this.thePlantRow;
		int num2 = this.thePlantColumn;
		uint num3;
		num += (int)num3;
		uint num4;
		num2 += (int)num4;
		if (board.GetBoxType(num2, num) != BoxType.Water)
		{
			num3 += (uint)1;
			while (num3 <= (uint)1)
			{
			}
			num4 += (uint)1;
			while (num4 <= (uint)1)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x0006EFE0 File Offset: 0x0006D1E0
	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x4BC1A0", Offset = "0x4BA7A0", VA = "0x1804BC1A0")]
	private void AddWaterToSurrounding()
	{
		GridSystem gridSystem = this.board.gridSystem;
		int num = this.thePlantRow;
		int num2 = this.thePlantColumn;
		uint num3;
		num += (int)num3;
		uint num4;
		num2 += (int)num4;
		BoardGrid grid = gridSystem.GetGrid(num2, num);
		if (grid == 0 || ListExtensions.TryAddUnique<BoardGrid>(this.affectedGrids, grid))
		{
		}
		num3 += (uint)1;
		while (num3 <= (uint)1)
		{
		}
		num4 += (uint)1;
		while (num4 <= (uint)1)
		{
		}
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x0006F04C File Offset: 0x0006D24C
	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x4BC4D0", Offset = "0x4BAAD0", VA = "0x1804BC4D0")]
	private void RemoveWaterFromSurrounding()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<BoardGrid> list = Enumerable.ToList<BoardGrid>(this.affectedGrids);
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x0006F080 File Offset: 0x0006D280
	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x4BC660", Offset = "0x4BAC60", VA = "0x1804BC660")]
	public SeaPot()
	{
		List<BoardGrid> list = new List();
		this.affectedGrids = list;
		base..ctor();
	}

	// Token: 0x04000CE8 RID: 3304
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CE8")]
	public GameObject waterObj;

	// Token: 0x04000CE9 RID: 3305
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CE9")]
	public List<BoardGrid> affectedGrids;

	// Token: 0x04000CEA RID: 3306
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CEA")]
	private bool lastWaterState;
}
