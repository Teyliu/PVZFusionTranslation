using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200030E RID: 782
[Token(Token = "0x200030E")]
public class CherryBomb : Plant
{
	// Token: 0x06000E45 RID: 3653 RVA: 0x00051D5C File Offset: 0x0004FF5C
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x445410", Offset = "0x443A10", VA = "0x180445410", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("Bomb");
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00051D88 File Offset: 0x0004FF88
	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x445230", Offset = "0x443830", VA = "0x180445230")]
	public void Bomb()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
		throw new NullReferenceException();
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00051DC4 File Offset: 0x0004FFC4
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x4453B0", Offset = "0x4439B0", VA = "0x1804453B0")]
	public void PlaySoundStart()
	{
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00051DE4 File Offset: 0x0004FFE4
	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x4452F0", Offset = "0x4438F0", VA = "0x1804452F0", Slot = "35")]
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

	// Token: 0x06000E49 RID: 3657 RVA: 0x00051E30 File Offset: 0x00050030
	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CherryBomb()
	{
	}
}
