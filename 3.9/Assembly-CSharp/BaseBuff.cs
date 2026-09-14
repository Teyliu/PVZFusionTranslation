using System;
using Cpp2IlInjected;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000037")]
public abstract class BaseBuff<T> : IBuff<T> where T : Enum
{
	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000F3 RID: 243 RVA: 0x00004C98 File Offset: 0x00002E98
	[Token(Token = "0x17000045")]
	public virtual T BuffType
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xD78090", Offset = "0xD76690", VA = "0x180D78090", Slot = "12")]
		get
		{
			NotImplementedException ex = new NotImplementedException();
			return default(T);
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x00004CB4 File Offset: 0x00002EB4
	[Token(Token = "0x17000046")]
	public virtual string Description
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1093CD0", Offset = "0x10922D0", VA = "0x181093CD0", Slot = "13")]
		get
		{
			return string.Empty;
		}
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00004CC8 File Offset: 0x00002EC8
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "14")]
	public virtual void OnBoardEnd(Board board)
	{
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00004CD8 File Offset: 0x00002ED8
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "15")]
	public virtual void OnBoardStart(Board board)
	{
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00004CE8 File Offset: 0x00002EE8
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "16")]
	public virtual void OnBoardLateStart(Board board)
	{
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00004CF8 File Offset: 0x00002EF8
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "17")]
	public virtual void OnSelect(Board board)
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00004D08 File Offset: 0x00002F08
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "18")]
	public virtual void ReinforcePlant(Board board, Plant plant)
	{
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00004D18 File Offset: 0x00002F18
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "19")]
	public virtual void ReinforceZombie(Zombie zombie)
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00004D28 File Offset: 0x00002F28
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	protected BaseBuff()
	{
		int num = 0;
		this.OnBoardEnd(num);
	}
}
