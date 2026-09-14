using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DDA RID: 3546
	[Token(Token = "0x2000DDA")]
	public class Random_草坪清理大师 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x0016C138 File Offset: 0x0016A338
		[Token(Token = "0x1700094B")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004989")]
			[Address(RVA = "0x89FED0", Offset = "0x89E4D0", VA = "0x18089FED0", Slot = "12")]
			get
			{
				return AdvBuff.Random_草坪清理大师;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x0016C14C File Offset: 0x0016A34C
		[Token(Token = "0x1700094C")]
		public override string Description
		{
			[Token(Token = "0x600498A")]
			[Address(RVA = "0x8D0080", Offset = "0x8CE680", VA = "0x1808D0080", Slot = "13")]
			get
			{
				return "草坪清理大师：释放当前小推车，并重新获得一列小推车";
			}
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x0016C160 File Offset: 0x0016A360
		[Token(Token = "0x600498B")]
		[Address(RVA = "0x8CFE60", Offset = "0x8CE460", VA = "0x1808CFE60", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ulong num3;
			do
			{
				int num = 0;
				List<Mower> mowerArray = board.mowerArray;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
				}
			}
			while (num3 != (ulong)0L);
			InitBoard.Instance.InitMower();
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x0016C1AC File Offset: 0x0016A3AC
		[Token(Token = "0x600498C")]
		[Address(RVA = "0x8D0040", Offset = "0x8CE640", VA = "0x1808D0040")]
		public Random_草坪清理大师()
		{
		}
	}
}
