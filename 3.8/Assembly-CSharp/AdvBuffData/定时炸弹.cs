using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D1B RID: 3355
	[Token(Token = "0x2000D1B")]
	public class 定时炸弹 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06004608 RID: 17928 RVA: 0x00162080 File Offset: 0x00160280
		[Token(Token = "0x170007E0")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004608")]
			[Address(RVA = "0x3A6AD0", Offset = "0x3A50D0", VA = "0x1803A6AD0", Slot = "12")]
			get
			{
				return AdvBuff.定时炸弹;
			}
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00162094 File Offset: 0x00160294
		[Token(Token = "0x6004609")]
		[Address(RVA = "0x850140", Offset = "0x84E740", VA = "0x180850140", Slot = "13")]
		public override string GetDescription()
		{
			return "定时炸弹：魅惑僵尸死亡时，对附近释放爆炸对附近僵尸造成150%生命值上限的伤害";
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x001620A8 File Offset: 0x001602A8
		[Token(Token = "0x600460A")]
		[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
		public override void OnSelect(Board board)
		{
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x001620B8 File Offset: 0x001602B8
		[Token(Token = "0x600460B")]
		[Address(RVA = "0x850170", Offset = "0x84E770", VA = "0x180850170", Slot = "15")]
		public override void OnBoardStart(Board board)
		{
			if (定时炸弹.<>c.<>9__4_0 == 0)
			{
				Action<object> action;
				定时炸弹.<>c.<>9__4_0 = action;
			}
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x001620D4 File Offset: 0x001602D4
		[Token(Token = "0x600460C")]
		[Address(RVA = "0x850290", Offset = "0x84E890", VA = "0x180850290")]
		public 定时炸弹()
		{
		}
	}
}
