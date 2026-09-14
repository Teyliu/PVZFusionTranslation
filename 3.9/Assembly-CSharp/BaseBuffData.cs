using System;
using Cpp2IlInjected;

// Token: 0x02000994 RID: 2452
[Token(Token = "0x2000994")]
public abstract class BaseBuffData
{
	// Token: 0x060032AB RID: 12971 RVA: 0x00109868 File Offset: 0x00107A68
	[Token(Token = "0x60032AB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "4")]
	public virtual void OnBoardStart(Board board)
	{
	}

	// Token: 0x060032AC RID: 12972 RVA: 0x00109878 File Offset: 0x00107A78
	[Token(Token = "0x60032AC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "5")]
	public virtual void ReinforcePlant(Board board, Plant plant)
	{
	}

	// Token: 0x060032AD RID: 12973 RVA: 0x00109888 File Offset: 0x00107A88
	[Token(Token = "0x60032AD")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	protected BaseBuffData()
	{
		int num = 0;
		this.OnBoardStart(num);
	}
}
