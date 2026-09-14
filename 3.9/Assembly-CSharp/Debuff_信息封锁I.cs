using System;
using Cpp2IlInjected;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
public class Debuff_信息封锁I : BaseDebuff
{
	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004BE8 File Offset: 0x00002DE8
	[Token(Token = "0x1700003F")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x3F2A90", Offset = "0x3F1090", VA = "0x1803F2A90", Slot = "12")]
		get
		{
			return TravelDebuff.信息封锁I;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060000E4 RID: 228 RVA: 0x00004BFC File Offset: 0x00002DFC
	[Token(Token = "0x17000040")]
	public override string Description
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x3F2AA0", Offset = "0x3F10A0", VA = "0x1803F2AA0", Slot = "13")]
		get
		{
			return "信息封锁I：永久关闭植物显血";
		}
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00004C10 File Offset: 0x00002E10
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x3F2A70", Offset = "0x3F1070", VA = "0x1803F2A70", Slot = "17")]
	public override void OnSelect(Board board)
	{
		board.ShowPlantHealth();
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00004C2C File Offset: 0x00002E2C
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_信息封锁I()
	{
	}
}
