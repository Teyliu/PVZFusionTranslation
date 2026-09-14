using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
public class Invest_风暴骑士 : InvestBuffData
{
	// Token: 0x06000168 RID: 360 RVA: 0x000059F0 File Offset: 0x00003BF0
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x3FA410", Offset = "0x3F8A10", VA = "0x1803FA410", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.风暴骑士;
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000169 RID: 361 RVA: 0x00005A04 File Offset: 0x00003C04
	[Token(Token = "0x1700005B")]
	public override string Description
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x3FA730", Offset = "0x3F8D30", VA = "0x1803FA730", Slot = "13")]
		get
		{
			return "每一轮开始时，每行最靠左的常规植物获得150%攻速加成，每一小波开始时，受到等同于生命值上限1000%的伤害";
		}
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00005A18 File Offset: 0x00003C18
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x3FA420", Offset = "0x3F8A20", VA = "0x1803FA420", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		Invest_风暴骑士.<>c__DisplayClass3_0 CS$<>8__locals1;
		int num;
		ulong num2;
		do
		{
			List<Plant> list = new List();
			CS$<>8__locals1.plants = list;
			num = 0;
			if (num >= board.rowNum)
			{
				goto IL_0042;
			}
			List<Plant> list2 = Lawnf.Get1x1Plants(0, num);
			bool flag;
			if (flag)
			{
				List<Plant> plants = CS$<>8__locals1.plants;
			}
		}
		while (num2 != (ulong)0L);
		num++;
		IL_0042:
		Action action = delegate
		{
			ulong num7;
			do
			{
				int num4 = 0;
				List<Plant> plants2 = CS$<>8__locals1.plants;
				bool flag2;
				if (flag2)
				{
					int num5 = 0;
					if (!(num4 != num5))
					{
						continue;
					}
					num5 += num5;
					int num6 = num4.System.IConvertible.ToInt32(num5);
				}
			}
			while (num7 != (ulong)0L);
		};
		int num3 = 0;
		EventManager.AddListener(GameEvent.BoardWaveAdd, action, num3 != 0);
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00005A98 File Offset: 0x00003C98
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00005AA8 File Offset: 0x00003CA8
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_风暴骑士()
	{
	}
}
