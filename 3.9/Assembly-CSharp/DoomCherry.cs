using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000388 RID: 904
[Token(Token = "0x2000388")]
public class DoomCherry : Plant
{
	// Token: 0x06001098 RID: 4248 RVA: 0x0005EC40 File Offset: 0x0005CE40
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x0005EC60 File Offset: 0x0005CE60
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x481330", Offset = "0x47F930", VA = "0x180481330", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x0005EC98 File Offset: 0x0005CE98
	[Token(Token = "0x600109A")]
	[Address(RVA = "0x481210", Offset = "0x47F810", VA = "0x180481210", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x0005ECD0 File Offset: 0x0005CED0
	[Token(Token = "0x600109B")]
	[Address(RVA = "0x481300", Offset = "0x47F900", VA = "0x180481300", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x0005ECE8 File Offset: 0x0005CEE8
	[Token(Token = "0x600109C")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomCherry()
	{
	}
}
