using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;

// Token: 0x02000022 RID: 34
[Token(Token = "0x2000022")]
public class Debuff_战争激励 : BaseDebuff
{
	// Token: 0x06000093 RID: 147 RVA: 0x0000429C File Offset: 0x0000249C
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x3A6CB0", Offset = "0x3A52B0", VA = "0x1803A6CB0", Slot = "13")]
	public override string GetDescription()
	{
		return "战争激励：每3秒令全场僵尸攻击力翻倍，有上限";
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000094 RID: 148 RVA: 0x000042B0 File Offset: 0x000024B0
	[Token(Token = "0x17000026")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x3A6E50", Offset = "0x3A5450", VA = "0x1803A6E50", Slot = "12")]
		get
		{
			return TravelDebuff.战争激励;
		}
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000042C4 File Offset: 0x000024C4
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000096 RID: 150 RVA: 0x000042D4 File Offset: 0x000024D4
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x3A6D90", Offset = "0x3A5390", VA = "0x1803A6D90", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		CancellationToken cancellationTokenOnDestroy = board.GetCancellationTokenOnDestroy();
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004300 File Offset: 0x00002500
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x3A6CE0", Offset = "0x3A52E0", VA = "0x1803A6CE0")]
	private void Main(CancellationToken cancellationToken)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00004324 File Offset: 0x00002524
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_战争激励()
	{
	}
}
