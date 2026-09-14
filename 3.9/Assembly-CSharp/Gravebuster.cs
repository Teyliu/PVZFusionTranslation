using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003AC RID: 940
[Token(Token = "0x20003AC")]
public class Gravebuster : Plant
{
	// Token: 0x06001139 RID: 4409 RVA: 0x00061B9C File Offset: 0x0005FD9C
	[Token(Token = "0x6001139")]
	[Address(RVA = "0x48C980", Offset = "0x48AF80", VA = "0x18048C980", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("bust");
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00061BC8 File Offset: 0x0005FDC8
	[Token(Token = "0x600113A")]
	[Address(RVA = "0x48C600", Offset = "0x48AC00", VA = "0x18048C600")]
	private void AnimBustUp()
	{
		Gravebuster.<Busting>d__5 <Busting>d__;
		<Busting>d__.System.IDisposable.Dispose();
		<Busting>d__.<>1__state = (int)((ulong)0L);
		<Busting>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Busting>d__);
		this.bust = coroutine;
		GameAPP.PlaySound(132, 0.5f, 1f);
		base.transform.Find("GraveSplat").gameObject.SetActive(true);
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x0600113B RID: 4411 RVA: 0x00061C30 File Offset: 0x0005FE30
	[Token(Token = "0x17000126")]
	private GridItem GridItem_
	{
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x48C9E0", Offset = "0x48AFE0", VA = "0x18048C9E0")]
		get
		{
			GridItem gridItem;
			int num;
			do
			{
				int size = this.board.griditemArray._size;
				if (size <= 0)
				{
					goto IL_0060;
				}
				gridItem = this.board.griditemArray[size];
				num = 0;
			}
			while (!(gridItem != num));
			while (gridItem.theItemType != GridItemType.Grave)
			{
			}
			int thePlantColumn = this.thePlantColumn;
			while (gridItem.theItemColumn != thePlantColumn)
			{
			}
			int thePlantRow = this.thePlantRow;
			while (gridItem.theItemRow != thePlantRow)
			{
			}
			return gridItem;
			IL_0060:
			throw new NullReferenceException();
		}
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00061CA8 File Offset: 0x0005FEA8
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x48C730", Offset = "0x48AD30", VA = "0x18048C730")]
	private IEnumerator Busting()
	{
		Gravebuster.<Busting>d__5 <Busting>d__;
		<Busting>d__.System.IDisposable.Dispose();
		<Busting>d__.<>1__state = (int)((ulong)0L);
		<Busting>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00061CCC File Offset: 0x0005FECC
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x48C7A0", Offset = "0x48ADA0", VA = "0x18048C7A0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (this.bust != (ulong)0L)
		{
			Coroutine coroutine = this.bust;
			base.StopCoroutine(coroutine);
		}
		GridItem gridItem_ = this.GridItem_;
		int num = 0;
		if (gridItem_ != num)
		{
			Transform transform = this.GridItem_.transform.Find("mask");
		}
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00061D28 File Offset: 0x0005FF28
	[Token(Token = "0x600113E")]
	[Address(RVA = "0x48C8A0", Offset = "0x48AEA0", VA = "0x18048C8A0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		GridItem gridItem_ = this.GridItem_;
		int num = 0;
		if (gridItem_ != num)
		{
			Transform transform = this.GridItem_.transform.Find("mask");
		}
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x00061D68 File Offset: 0x0005FF68
	[Token(Token = "0x600113F")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Gravebuster()
	{
	}

	// Token: 0x04000BFE RID: 3070
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BFE")]
	private Coroutine bust;
}
