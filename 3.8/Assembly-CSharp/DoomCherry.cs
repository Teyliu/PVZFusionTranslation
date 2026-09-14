using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000378 RID: 888
[Token(Token = "0x2000378")]
public class DoomCherry : Plant
{
	// Token: 0x0600104C RID: 4172 RVA: 0x0005DC78 File Offset: 0x0005BE78
	[Token(Token = "0x600104C")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x0005DC98 File Offset: 0x0005BE98
	[Token(Token = "0x600104D")]
	[Address(RVA = "0x430A40", Offset = "0x42F040", VA = "0x180430A40", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x0005DCD0 File Offset: 0x0005BED0
	[Token(Token = "0x600104E")]
	[Address(RVA = "0x430920", Offset = "0x42EF20", VA = "0x180430920", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x0005DD08 File Offset: 0x0005BF08
	[Token(Token = "0x600104F")]
	[Address(RVA = "0x430A10", Offset = "0x42F010", VA = "0x180430A10", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x0005DD20 File Offset: 0x0005BF20
	[Token(Token = "0x6001050")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomCherry()
	{
	}
}
