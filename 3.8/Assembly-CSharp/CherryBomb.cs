using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FE RID: 766
[Token(Token = "0x20002FE")]
public class CherryBomb : Plant
{
	// Token: 0x06000DFC RID: 3580 RVA: 0x00050DF8 File Offset: 0x0004EFF8
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x401350", Offset = "0x3FF950", VA = "0x180401350", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("Bomb");
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00050E24 File Offset: 0x0004F024
	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x401170", Offset = "0x3FF770", VA = "0x180401170")]
	public void Bomb()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
		throw new NullReferenceException();
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00050E60 File Offset: 0x0004F060
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x4012F0", Offset = "0x3FF8F0", VA = "0x1804012F0")]
	public void PlaySoundStart()
	{
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00050E80 File Offset: 0x0004F080
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x401230", Offset = "0x3FF830", VA = "0x180401230", Slot = "36")]
	protected override bool OnCrash()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
		int num = 0;
		base.Die((Plant.DieReason)num);
		return true;
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00050ECC File Offset: 0x0004F0CC
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CherryBomb()
	{
	}
}
