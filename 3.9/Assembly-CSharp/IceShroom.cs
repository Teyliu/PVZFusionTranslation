using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003CC RID: 972
[Token(Token = "0x20003CC")]
public class IceShroom : Plant
{
	// Token: 0x060011CF RID: 4559 RVA: 0x00064724 File Offset: 0x00062924
	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x496250", Offset = "0x494850", VA = "0x180496250", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 1.5f;
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x00064744 File Offset: 0x00062944
	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x496230", Offset = "0x494830", VA = "0x180496230", Slot = "39")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00064754 File Offset: 0x00062954
	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x496270", Offset = "0x494870", VA = "0x180496270", Slot = "68")]
	protected virtual void Explode()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		throw new NullReferenceException();
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x0006477C File Offset: 0x0006297C
	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x446BA0", Offset = "0x4451A0", VA = "0x180446BA0", Slot = "35")]
	protected override bool OnCrash()
	{
		this.Explode();
		return true;
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00064790 File Offset: 0x00062990
	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public IceShroom()
	{
	}
}
