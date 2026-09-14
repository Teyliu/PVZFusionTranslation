using System;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002E")]
public class Debuff_急行军 : BaseDebuff
{
	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x000048F8 File Offset: 0x00002AF8
	[Token(Token = "0x17000033")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x3F2C00", Offset = "0x3F1200", VA = "0x1803F2C00", Slot = "12")]
		get
		{
			return TravelDebuff.急行军;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000490C File Offset: 0x00002B0C
	[Token(Token = "0x17000034")]
	public override string Description
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x3F2C10", Offset = "0x3F1210", VA = "0x1803F2C10", Slot = "13")]
		get
		{
			return "急行军：第一波僵尸到达时间降低至5秒，僵尸刷新间隔降低至15秒";
		}
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00004920 File Offset: 0x00002B20
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00004930 File Offset: 0x00002B30
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x3F2BB0", Offset = "0x3F11B0", VA = "0x1803F2BB0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		BoardConfig config = board.config;
		board.timeUntilNextWave = 5f;
		config.waveInterval = 15f;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00004960 File Offset: 0x00002B60
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_急行军()
	{
	}
}
