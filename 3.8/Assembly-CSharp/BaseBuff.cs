using System;
using Cpp2IlInjected;

// Token: 0x02000033 RID: 51
[Token(Token = "0x2000033")]
public abstract class BaseBuff<T> : IBuff<T> where T : Enum
{
	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000DC RID: 220 RVA: 0x00004A08 File Offset: 0x00002C08
	[Token(Token = "0x17000033")]
	public virtual T BuffType
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xB9A690", Offset = "0xB98C90", VA = "0x180B9A690", Slot = "12")]
		get
		{
			NotImplementedException ex = new NotImplementedException();
			return default(T);
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00004A24 File Offset: 0x00002C24
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xD9FD40", Offset = "0xD9E340", VA = "0x180D9FD40", Slot = "13")]
	public virtual string GetDescription()
	{
		return string.Empty;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00004A38 File Offset: 0x00002C38
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "14")]
	public virtual void OnBoardEnd(Board board)
	{
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00004A48 File Offset: 0x00002C48
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "15")]
	public virtual void OnBoardStart(Board board)
	{
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "16")]
	public virtual void OnBoardLateStart(Board board)
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00004A68 File Offset: 0x00002C68
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "17")]
	public virtual void OnSelect(Board board)
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00004A78 File Offset: 0x00002C78
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "18")]
	public virtual void ReinforcePlant(Board board, Plant plant)
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00004A88 File Offset: 0x00002C88
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "19")]
	public virtual void ReinforceZombie(Zombie zombie)
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00004A98 File Offset: 0x00002C98
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	protected BaseBuff()
	{
		int num = 0;
		this.OnBoardEnd(num);
	}
}
