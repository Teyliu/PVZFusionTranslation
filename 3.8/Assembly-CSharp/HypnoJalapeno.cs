using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

// Token: 0x02000308 RID: 776
[Token(Token = "0x2000308")]
public class HypnoJalapeno : Jalapeno
{
	// Token: 0x06000E22 RID: 3618 RVA: 0x000516F8 File Offset: 0x0004F8F8
	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x402AE0", Offset = "0x4010E0", VA = "0x180402AE0", Slot = "69")]
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

	// Token: 0x06000E23 RID: 3619 RVA: 0x0005173C File Offset: 0x0004F93C
	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x402BD0", Offset = "0x4011D0", VA = "0x180402BD0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00051754 File Offset: 0x0004F954
	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public HypnoJalapeno()
	{
	}
}
