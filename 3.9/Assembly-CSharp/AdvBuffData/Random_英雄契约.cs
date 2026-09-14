using System;
using Core;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DD7 RID: 3543
	[Token(Token = "0x2000DD7")]
	public class Random_英雄契约 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x0016C090 File Offset: 0x0016A290
		[Token(Token = "0x17000949")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004981")]
			[Address(RVA = "0x89F520", Offset = "0x89DB20", VA = "0x18089F520", Slot = "12")]
			get
			{
				return AdvBuff.Random_英雄契约;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06004982 RID: 18818 RVA: 0x0016C0A4 File Offset: 0x0016A2A4
		[Token(Token = "0x1700094A")]
		public override string Description
		{
			[Token(Token = "0x6004982")]
			[Address(RVA = "0x8CFE30", Offset = "0x8CE430", VA = "0x1808CFE30", Slot = "13")]
			get
			{
				return "英雄契约：现在获得一张多功能南瓜卡牌，如果种下他则视为接受挑战：\n在接下来的20波内，全体僵尸的数量翻倍\n随后将该植物所在格的全部植物升至3星";
			}
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x0016C0B8 File Offset: 0x0016A2B8
		[Token(Token = "0x6004983")]
		[Address(RVA = "0x8CFC70", Offset = "0x8CE270", VA = "0x1808CFC70", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Random_英雄契约.<>c__DisplayClass4_0().board = board;
			InGameText instance = InGameText.Instance;
			string description = this.Description;
			DroppedCard droppedCard;
			Action<Plant> action;
			droppedCard.plantAction = action;
			throw new NullReferenceException();
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x0016C0F0 File Offset: 0x0016A2F0
		[Token(Token = "0x6004984")]
		[Address(RVA = "0x8CFDF0", Offset = "0x8CE3F0", VA = "0x1808CFDF0")]
		public Random_英雄契约()
		{
		}
	}
}
