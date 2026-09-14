using System;
using Cpp2IlInjected;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
public class Debuff_信息封锁I : BaseDebuff
{
	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000CC RID: 204 RVA: 0x00004958 File Offset: 0x00002B58
	[Token(Token = "0x17000030")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3A6B30", Offset = "0x3A5130", VA = "0x1803A6B30", Slot = "12")]
		get
		{
			return TravelDebuff.信息封锁I;
		}
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0000496C File Offset: 0x00002B6C
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x3A6AE0", Offset = "0x3A50E0", VA = "0x1803A6AE0", Slot = "13")]
	public override string GetDescription()
	{
		return "信息封锁I：永久关闭植物显血";
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00004980 File Offset: 0x00002B80
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x3A6B10", Offset = "0x3A5110", VA = "0x1803A6B10", Slot = "17")]
	public override void OnSelect(Board board)
	{
		board.ShowPlantHealth();
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000499C File Offset: 0x00002B9C
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_信息封锁I()
	{
	}
}
