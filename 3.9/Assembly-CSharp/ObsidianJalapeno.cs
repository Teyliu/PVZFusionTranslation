using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200040B RID: 1035
[Token(Token = "0x200040B")]
public class ObsidianJalapeno : Plant
{
	// Token: 0x0600130E RID: 4878 RVA: 0x0006ABF8 File Offset: 0x00068DF8
	[Token(Token = "0x600130E")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x0006AC18 File Offset: 0x00068E18
	[Token(Token = "0x600130F")]
	[Address(RVA = "0x4ACEB0", Offset = "0x4AB4B0", VA = "0x1804ACEB0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.OnFixedUpdate();
		base.AttributeCountdown = 1f;
		num += num;
		base.RealTakeDamage(num);
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x0006AC44 File Offset: 0x00068E44
	[Token(Token = "0x6001310")]
	[Address(RVA = "0x4ACFD0", Offset = "0x4AB5D0", VA = "0x1804ACFD0", Slot = "16")]
	protected override void Update()
	{
		int num = 0;
		base.Update();
		num += num;
		this.anim.SetTrigger("shake");
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x0006AC78 File Offset: 0x00068E78
	[Token(Token = "0x6001311")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x0006AC88 File Offset: 0x00068E88
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x4ACF00", Offset = "0x4AB500", VA = "0x1804ACF00", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction2 = board.boardAction;
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x0006ACC8 File Offset: 0x00068EC8
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public ObsidianJalapeno()
	{
	}
}
