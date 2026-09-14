using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B8 RID: 952
[Token(Token = "0x20003B8")]
public class IceShroom : Plant
{
	// Token: 0x06001173 RID: 4467 RVA: 0x00063104 File Offset: 0x00061304
	[Token(Token = "0x6001173")]
	[Address(RVA = "0x444300", Offset = "0x442900", VA = "0x180444300", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 1.5f;
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00063124 File Offset: 0x00061324
	[Token(Token = "0x6001174")]
	[Address(RVA = "0x4442E0", Offset = "0x4428E0", VA = "0x1804442E0", Slot = "40")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00063134 File Offset: 0x00061334
	[Token(Token = "0x6001175")]
	[Address(RVA = "0x444320", Offset = "0x442920", VA = "0x180444320", Slot = "69")]
	protected virtual void Explode()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		throw new NullReferenceException();
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x0006315C File Offset: 0x0006135C
	[Token(Token = "0x6001176")]
	[Address(RVA = "0x402950", Offset = "0x400F50", VA = "0x180402950", Slot = "36")]
	protected override bool OnCrash()
	{
		this.Explode();
		return true;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00063170 File Offset: 0x00061370
	[Token(Token = "0x6001177")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public IceShroom()
	{
	}
}
