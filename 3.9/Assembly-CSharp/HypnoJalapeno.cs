using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

// Token: 0x02000318 RID: 792
[Token(Token = "0x2000318")]
public class HypnoJalapeno : Jalapeno
{
	// Token: 0x06000E6B RID: 3691 RVA: 0x00052664 File Offset: 0x00050864
	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x446D30", Offset = "0x445330", VA = "0x180446D30", Slot = "68")]
	public override void AnimExplode()
	{
		BoardAction boardAction = this.board.boardAction;
		int thePlantRow = this.thePlantRow;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int num2 = 0;
		ulong num3;
		ulong num4;
		Action<Zombie> action;
		boardAction.CreateFireLine(thePlantRow, num2, num != 0, num3 != 0UL, num4 != 0UL, action, thePlantType);
		throw new NullReferenceException();
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x000526A8 File Offset: 0x000508A8
	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x446E20", Offset = "0x445420", VA = "0x180446E20", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x000526C0 File Offset: 0x000508C0
	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public HypnoJalapeno()
	{
	}
}
