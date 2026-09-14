using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F1 RID: 1009
[Token(Token = "0x20003F1")]
public class ObsidianJalapeno : Plant
{
	// Token: 0x0600129B RID: 4763 RVA: 0x00068E4C File Offset: 0x0006704C
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00068E6C File Offset: 0x0006706C
	[Token(Token = "0x600129C")]
	[Address(RVA = "0x458AE0", Offset = "0x4570E0", VA = "0x180458AE0", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.OnFixedUpdate();
		base.AttributeCountdown = 1f;
		num += num;
		base.RealTakeDamage(num);
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x00068E98 File Offset: 0x00067098
	[Token(Token = "0x600129D")]
	[Address(RVA = "0x458BF0", Offset = "0x4571F0", VA = "0x180458BF0", Slot = "16")]
	protected override void Update()
	{
		int num = 0;
		base.Update();
		num += num;
		this.anim.SetTrigger("shake");
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x00068ECC File Offset: 0x000670CC
	[Token(Token = "0x600129E")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x00068EDC File Offset: 0x000670DC
	[Token(Token = "0x600129F")]
	[Address(RVA = "0x458B30", Offset = "0x457130", VA = "0x180458B30", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		ulong num4;
		boardAction.CreateFireLine(thePlantRow, attackDamage, num2 != 0, num3 != 0UL, num4 != 0UL, num, thePlantType);
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction2 = board.boardAction;
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x00068F44 File Offset: 0x00067144
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public ObsidianJalapeno()
	{
	}
}
