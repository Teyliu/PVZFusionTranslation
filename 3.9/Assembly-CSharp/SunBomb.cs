using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000344 RID: 836
[Token(Token = "0x2000344")]
public class SunBomb : Plant
{
	// Token: 0x06000F43 RID: 3907 RVA: 0x000587F8 File Offset: 0x000569F8
	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x469F50", Offset = "0x468550", VA = "0x180469F50", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("Bomb");
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00058824 File Offset: 0x00056A24
	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x469D60", Offset = "0x468360", VA = "0x180469D60")]
	public void Bomb()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
		throw new NullReferenceException();
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00058860 File Offset: 0x00056A60
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x469EF0", Offset = "0x4684F0", VA = "0x180469EF0")]
	public void PlaySoundStart()
	{
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00058880 File Offset: 0x00056A80
	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x469E20", Offset = "0x468420", VA = "0x180469E20", Slot = "35")]
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

	// Token: 0x06000F47 RID: 3911 RVA: 0x000588CC File Offset: 0x00056ACC
	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SunBomb()
	{
	}
}
