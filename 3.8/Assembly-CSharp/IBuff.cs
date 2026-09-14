using System;
using Cpp2IlInjected;

// Token: 0x02000032 RID: 50
[Token(Token = "0x2000032")]
public interface IBuff<T> where T : Enum
{
	// Token: 0x060000D4 RID: 212
	[Token(Token = "0x60000D4")]
	[Address(Slot = "0")]
	string GetDescription();

	// Token: 0x060000D5 RID: 213
	[Token(Token = "0x60000D5")]
	[Address(Slot = "1")]
	void OnBoardStart(Board board);

	// Token: 0x060000D6 RID: 214
	[Token(Token = "0x60000D6")]
	[Address(Slot = "2")]
	void OnBoardLateStart(Board board);

	// Token: 0x060000D7 RID: 215
	[Token(Token = "0x60000D7")]
	[Address(Slot = "3")]
	void OnBoardEnd(Board board);

	// Token: 0x060000D8 RID: 216
	[Token(Token = "0x60000D8")]
	[Address(Slot = "4")]
	void OnSelect(Board board);

	// Token: 0x060000D9 RID: 217
	[Token(Token = "0x60000D9")]
	[Address(Slot = "5")]
	void ReinforcePlant(Board board, Plant plant);

	// Token: 0x060000DA RID: 218
	[Token(Token = "0x60000DA")]
	[Address(Slot = "6")]
	void ReinforceZombie(Zombie zombie);

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000DB RID: 219
	[Token(Token = "0x17000032")]
	T BuffType
	{
		[Token(Token = "0x60000DB")]
		[Address(Slot = "7")]
		get;
	}
}
