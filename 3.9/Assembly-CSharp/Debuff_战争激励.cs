using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000027")]
public class Debuff_战争激励 : BaseDebuff
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000AE RID: 174 RVA: 0x00004624 File Offset: 0x00002824
	[Token(Token = "0x1700002D")]
	public override string Description
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3F2DC0", Offset = "0x3F13C0", VA = "0x1803F2DC0", Slot = "13")]
		get
		{
			return "战争激励：每3秒令全场僵尸攻击力翻倍，有上限";
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000AF RID: 175 RVA: 0x00004638 File Offset: 0x00002838
	[Token(Token = "0x1700002E")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3F2DB0", Offset = "0x3F13B0", VA = "0x1803F2DB0", Slot = "12")]
		get
		{
			return TravelDebuff.战争激励;
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0000464C File Offset: 0x0000284C
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0000465C File Offset: 0x0000285C
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x3F2CF0", Offset = "0x3F12F0", VA = "0x1803F2CF0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		CancellationToken cancellationTokenOnDestroy = board.GetCancellationTokenOnDestroy();
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00004688 File Offset: 0x00002888
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x3F2C40", Offset = "0x3F1240", VA = "0x1803F2C40")]
	private void Main(CancellationToken cancellationToken)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000046AC File Offset: 0x000028AC
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_战争激励()
	{
	}
}
