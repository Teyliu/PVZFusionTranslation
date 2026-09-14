using System;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public class Debuff_急行军 : BaseDebuff
{
	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000AD RID: 173 RVA: 0x0000456C File Offset: 0x0000276C
	[Token(Token = "0x17000029")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x3A6CA0", Offset = "0x3A52A0", VA = "0x1803A6CA0", Slot = "12")]
		get
		{
			return TravelDebuff.急行军;
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00004580 File Offset: 0x00002780
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x3A6C20", Offset = "0x3A5220", VA = "0x1803A6C20", Slot = "13")]
	public override string GetDescription()
	{
		return "急行军：第一波僵尸到达时间降低至5秒，僵尸刷新间隔降低至15秒";
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00004594 File Offset: 0x00002794
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000045A4 File Offset: 0x000027A4
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x3A6C50", Offset = "0x3A5250", VA = "0x1803A6C50", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		BoardConfig config = board.config;
		board.timeUntilNextWave = 5f;
		config.waveInterval = 15f;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000045D4 File Offset: 0x000027D4
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_急行军()
	{
	}
}
