using System;
using Core;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D07 RID: 3335
	[Token(Token = "0x2000D07")]
	public class Random_腐化契约 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x00161968 File Offset: 0x0015FB68
		[Token(Token = "0x170007D5")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045C7")]
			[Address(RVA = "0x84B4D0", Offset = "0x849AD0", VA = "0x18084B4D0", Slot = "12")]
			get
			{
				return AdvBuff.Random_腐化契约;
			}
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x0016197C File Offset: 0x0015FB7C
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x84B2F0", Offset = "0x8498F0", VA = "0x18084B2F0", Slot = "13")]
		public override string GetDescription()
		{
			return "腐化契约：现在获得一张究极忧郁菇卡牌，如果种下他则视为接受挑战：\n在每行召唤3~6个随机的究极僵尸（包含一切可能）\n全部击败后，获得词条【腐化】";
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00161990 File Offset: 0x0015FB90
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x84B320", Offset = "0x849920", VA = "0x18084B320", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Random_腐化契约.<>c__DisplayClass3_0().board = board;
			InGameText instance = InGameText.Instance;
			string description = this.GetDescription();
			int num = 0;
			instance.ShowText(description, 10f, num != 0);
			DroppedCard droppedCard;
			Action<Plant> action;
			droppedCard.plantAction = action;
			throw new NullReferenceException();
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x001619D8 File Offset: 0x0015FBD8
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x84B490", Offset = "0x849A90", VA = "0x18084B490")]
		public Random_腐化契约()
		{
		}
	}
}
