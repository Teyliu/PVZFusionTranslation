using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DE9 RID: 3561
	[Token(Token = "0x2000DE9")]
	public class Shooting_护盾保护 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x0016C828 File Offset: 0x0016AA28
		[Token(Token = "0x17000961")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60049C1")]
			[Address(RVA = "0x8D0E60", Offset = "0x8CF460", VA = "0x1808D0E60", Slot = "12")]
			get
			{
				return AdvBuff.Shooting_护盾保护;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060049C2 RID: 18882 RVA: 0x0016C83C File Offset: 0x0016AA3C
		[Token(Token = "0x17000962")]
		public override string Description
		{
			[Token(Token = "0x60049C2")]
			[Address(RVA = "0x8D0E70", Offset = "0x8CF470", VA = "0x1808D0E70", Slot = "13")]
			get
			{
				return "护盾保护：持有护盾的植物每秒回复0.1%护盾量的生命值";
			}
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x0016C850 File Offset: 0x0016AA50
		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x8D0D70", Offset = "0x8CF370", VA = "0x1808D0D70", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x0016C874 File Offset: 0x0016AA74
		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x8D0E20", Offset = "0x8CF420", VA = "0x1808D0E20")]
		public Shooting_护盾保护()
		{
		}

		// Token: 0x0400340F RID: 13327
		[Token(Token = "0x400340F")]
		private static CancellationTokenSource _cts;
	}
}
