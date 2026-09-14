using System;
using Cpp2IlInjected;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
public interface IBuff<T> where T : Enum
{
	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000EB RID: 235
	[Token(Token = "0x17000043")]
	string Description
	{
		[Token(Token = "0x60000EB")]
		[Address(Slot = "0")]
		get;
	}

	// Token: 0x060000EC RID: 236
	[Token(Token = "0x60000EC")]
	[Address(Slot = "1")]
	void OnBoardStart(Board board);

	// Token: 0x060000ED RID: 237
	[Token(Token = "0x60000ED")]
	[Address(Slot = "2")]
	void OnBoardLateStart(Board board);

	// Token: 0x060000EE RID: 238
	[Token(Token = "0x60000EE")]
	[Address(Slot = "3")]
	void OnBoardEnd(Board board);

	// Token: 0x060000EF RID: 239
	[Token(Token = "0x60000EF")]
	[Address(Slot = "4")]
	void OnSelect(Board board);

	// Token: 0x060000F0 RID: 240
	[Token(Token = "0x60000F0")]
	[Address(Slot = "5")]
	void ReinforcePlant(Board board, Plant plant);

	// Token: 0x060000F1 RID: 241
	[Token(Token = "0x60000F1")]
	[Address(Slot = "6")]
	void ReinforceZombie(Zombie zombie);

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000F2 RID: 242
	[Token(Token = "0x17000044")]
	T BuffType
	{
		[Token(Token = "0x60000F2")]
		[Address(Slot = "7")]
		get;
	}
}
