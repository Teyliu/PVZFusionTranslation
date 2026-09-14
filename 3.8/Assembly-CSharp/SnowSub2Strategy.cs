using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000936 RID: 2358
[Token(Token = "0x2000936")]
public class SnowSub2Strategy : BaseLevelStrategy
{
	// Token: 0x06003083 RID: 12419 RVA: 0x00101B20 File Offset: 0x000FFD20
	[Token(Token = "0x6003083")]
	[Address(RVA = "0x6AC070", Offset = "0x6AA670", VA = "0x1806AC070", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub2;
	}

	// Token: 0x06003084 RID: 12420 RVA: 0x00101B30 File Offset: 0x000FFD30
	[Token(Token = "0x6003084")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003085 RID: 12421 RVA: 0x00101B40 File Offset: 0x000FFD40
	[Token(Token = "0x6003085")]
	[Address(RVA = "0x6AC080", Offset = "0x6AA680", VA = "0x1806AC080", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		return list;
	}

	// Token: 0x06003086 RID: 12422 RVA: 0x00101B94 File Offset: 0x000FFD94
	[Token(Token = "0x6003086")]
	[Address(RVA = "0x6A42A0", Offset = "0x6A28A0", VA = "0x1806A42A0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x06003087 RID: 12423 RVA: 0x00101BA4 File Offset: 0x000FFDA4
	[Token(Token = "0x6003087")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x06003088 RID: 12424 RVA: 0x00101BB4 File Offset: 0x000FFDB4
	[Token(Token = "0x6003088")]
	[Address(RVA = "0x6AC040", Offset = "0x6AA640", VA = "0x1806AC040", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：冷冻冬眠";
	}

	// Token: 0x06003089 RID: 12425 RVA: 0x00101BC8 File Offset: 0x000FFDC8
	[Token(Token = "0x6003089")]
	[Address(RVA = "0x6AC2A0", Offset = "0x6AA8A0", VA = "0x1806AC2A0", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		int num3;
		do
		{
			int num = 0;
			if (board.gridSystem.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
					}
				}
				GridItem gridItem;
				gridItem += gridItem;
				uint num2;
				num2 += (uint)312;
			}
			if ("{il2cpp array field local8->}" != (ulong)0L)
			{
			}
			if (num != 0)
			{
				goto IL_0082;
			}
			num3 = 0;
			HashSet<CardUI> cards = InGameUI.Instance.cards;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		while (num3 != 0);
		return;
		IL_0082:
		throw new NullReferenceException();
	}

	// Token: 0x0600308A RID: 12426 RVA: 0x00101C60 File Offset: 0x000FFE60
	[Token(Token = "0x600308A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SnowSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
