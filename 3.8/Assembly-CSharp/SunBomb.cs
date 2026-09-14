using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000334 RID: 820
[Token(Token = "0x2000334")]
public class SunBomb : Plant
{
	// Token: 0x06000EF8 RID: 3832 RVA: 0x0005783C File Offset: 0x00055A3C
	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0x429830", Offset = "0x427E30", VA = "0x180429830", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("Bomb");
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00057868 File Offset: 0x00055A68
	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0x429640", Offset = "0x427C40", VA = "0x180429640")]
	public void Bomb()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
		throw new NullReferenceException();
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x000578A4 File Offset: 0x00055AA4
	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x4297D0", Offset = "0x427DD0", VA = "0x1804297D0")]
	public void PlaySoundStart()
	{
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x000578C4 File Offset: 0x00055AC4
	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x429700", Offset = "0x427D00", VA = "0x180429700", Slot = "36")]
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

	// Token: 0x06000EFC RID: 3836 RVA: 0x00057910 File Offset: 0x00055B10
	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SunBomb()
	{
	}
}
