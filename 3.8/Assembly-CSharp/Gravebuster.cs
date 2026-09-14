using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000398 RID: 920
[Token(Token = "0x2000398")]
public class Gravebuster : Plant
{
	// Token: 0x060010DD RID: 4317 RVA: 0x0006053C File Offset: 0x0005E73C
	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x439100", Offset = "0x437700", VA = "0x180439100", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("bust");
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00060568 File Offset: 0x0005E768
	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x438D80", Offset = "0x437380", VA = "0x180438D80")]
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

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060010DF RID: 4319 RVA: 0x000605D0 File Offset: 0x0005E7D0
	[Token(Token = "0x170000E3")]
	private GridItem GridItem_
	{
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x439160", Offset = "0x437760", VA = "0x180439160")]
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

	// Token: 0x060010E0 RID: 4320 RVA: 0x00060648 File Offset: 0x0005E848
	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x438EB0", Offset = "0x4374B0", VA = "0x180438EB0")]
	private IEnumerator Busting()
	{
		Gravebuster.<Busting>d__5 <Busting>d__;
		<Busting>d__.System.IDisposable.Dispose();
		<Busting>d__.<>1__state = (int)((ulong)0L);
		<Busting>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0006066C File Offset: 0x0005E86C
	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x438F20", Offset = "0x437520", VA = "0x180438F20", Slot = "52")]
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

	// Token: 0x060010E2 RID: 4322 RVA: 0x000606C8 File Offset: 0x0005E8C8
	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x439020", Offset = "0x437620", VA = "0x180439020", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		GridItem gridItem_ = this.GridItem_;
		int num = 0;
		if (gridItem_ != num)
		{
			Transform transform = this.GridItem_.transform.Find("mask");
		}
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00060708 File Offset: 0x0005E908
	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Gravebuster()
	{
	}

	// Token: 0x04000B98 RID: 2968
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B98")]
	private Coroutine bust;
}
