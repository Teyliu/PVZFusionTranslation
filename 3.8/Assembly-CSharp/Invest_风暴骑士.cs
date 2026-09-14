using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000050 RID: 80
[Token(Token = "0x2000050")]
public class Invest_风暴骑士 : InvestBuffData
{
	// Token: 0x06000151 RID: 337 RVA: 0x0000576C File Offset: 0x0000396C
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x3AE5A0", Offset = "0x3ACBA0", VA = "0x1803AE5A0", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.风暴骑士;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00005780 File Offset: 0x00003980
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x3AE5B0", Offset = "0x3ACBB0", VA = "0x1803AE5B0", Slot = "13")]
	public override string GetDescription()
	{
		return "每一轮开始时，每行最靠左的常规植物获得150%攻速加成，每一小波开始时，受到等同于生命值上限1000%的伤害";
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00005794 File Offset: 0x00003994
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x3AE5E0", Offset = "0x3ACBE0", VA = "0x1803AE5E0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		Invest_风暴骑士.<>c__DisplayClass2_0 CS$<>8__locals1;
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

	// Token: 0x06000154 RID: 340 RVA: 0x00005814 File Offset: 0x00003A14
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00005824 File Offset: 0x00003A24
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_风暴骑士()
	{
	}
}
