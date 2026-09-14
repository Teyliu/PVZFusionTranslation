using System;
using Core;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D0F RID: 3343
	[Token(Token = "0x2000D0F")]
	public class Random_英雄契约 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060045E0 RID: 17888 RVA: 0x00161C2C File Offset: 0x0015FE2C
		[Token(Token = "0x170007D9")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045E0")]
			[Address(RVA = "0x84B6C0", Offset = "0x849CC0", VA = "0x18084B6C0", Slot = "12")]
			get
			{
				return AdvBuff.Random_英雄契约;
			}
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00161C40 File Offset: 0x0015FE40
		[Token(Token = "0x60045E1")]
		[Address(RVA = "0x84B4E0", Offset = "0x849AE0", VA = "0x18084B4E0", Slot = "13")]
		public override string GetDescription()
		{
			return "英雄契约：现在获得一张多功能南瓜卡牌，如果种下他则视为接受挑战：\n在接下来的20波内，全体僵尸的数量翻倍\n随后将该植物所在格的全部植物升至3星";
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00161C54 File Offset: 0x0015FE54
		[Token(Token = "0x60045E2")]
		[Address(RVA = "0x84B510", Offset = "0x849B10", VA = "0x18084B510", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Random_英雄契约.<>c__DisplayClass3_0().board = board;
			InGameText instance = InGameText.Instance;
			string description = this.GetDescription();
			int num = 0;
			instance.ShowText(description, 10f, num != 0);
			DroppedCard droppedCard;
			Action<Plant> action;
			droppedCard.plantAction = action;
			throw new NullReferenceException();
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x00161C9C File Offset: 0x0015FE9C
		[Token(Token = "0x60045E3")]
		[Address(RVA = "0x84B680", Offset = "0x849C80", VA = "0x18084B680")]
		public Random_英雄契约()
		{
		}
	}
}
