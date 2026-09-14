using System;
using Core;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DCF RID: 3535
	[Token(Token = "0x2000DCF")]
	public class Random_腐化契约 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06004968 RID: 18792 RVA: 0x0016BDDC File Offset: 0x00169FDC
		[Token(Token = "0x17000941")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004968")]
			[Address(RVA = "0x88CCC0", Offset = "0x88B2C0", VA = "0x18088CCC0", Slot = "12")]
			get
			{
				return AdvBuff.Random_腐化契约;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x0016BDF0 File Offset: 0x00169FF0
		[Token(Token = "0x17000942")]
		public override string Description
		{
			[Token(Token = "0x6004969")]
			[Address(RVA = "0x8B2090", Offset = "0x8B0690", VA = "0x1808B2090", Slot = "13")]
			get
			{
				return "腐化契约：现在获得一张究极忧郁菇卡牌，如果种下他则视为接受挑战：\n在每行召唤3~6个随机的究极僵尸（包含一切可能）\n全部击败后，获得词条【腐化】";
			}
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x0016BE04 File Offset: 0x0016A004
		[Token(Token = "0x600496A")]
		[Address(RVA = "0x8B1ED0", Offset = "0x8B04D0", VA = "0x1808B1ED0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Random_腐化契约.<>c__DisplayClass4_0().board = board;
			InGameText instance = InGameText.Instance;
			string description = this.Description;
			DroppedCard droppedCard;
			Action<Plant> action;
			droppedCard.plantAction = action;
			throw new NullReferenceException();
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x0016BE3C File Offset: 0x0016A03C
		[Token(Token = "0x600496B")]
		[Address(RVA = "0x8B2050", Offset = "0x8B0650", VA = "0x1808B2050")]
		public Random_腐化契约()
		{
		}
	}
}
