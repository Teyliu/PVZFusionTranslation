using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000972 RID: 2418
[Token(Token = "0x2000972")]
public class SnowSub2Strategy : BaseLevelStrategy
{
	// Token: 0x060031B6 RID: 12726 RVA: 0x00106890 File Offset: 0x00104A90
	[Token(Token = "0x60031B6")]
	[Address(RVA = "0x7261F0", Offset = "0x7247F0", VA = "0x1807261F0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub2;
	}

	// Token: 0x060031B7 RID: 12727 RVA: 0x001068A0 File Offset: 0x00104AA0
	[Token(Token = "0x60031B7")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060031B8 RID: 12728 RVA: 0x001068B0 File Offset: 0x00104AB0
	[Token(Token = "0x60031B8")]
	[Address(RVA = "0x726200", Offset = "0x724800", VA = "0x180726200", Slot = "24")]
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

	// Token: 0x060031B9 RID: 12729 RVA: 0x00106904 File Offset: 0x00104B04
	[Token(Token = "0x60031B9")]
	[Address(RVA = "0x71E400", Offset = "0x71CA00", VA = "0x18071E400", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PineFurnace;
	}

	// Token: 0x060031BA RID: 12730 RVA: 0x00106914 File Offset: 0x00104B14
	[Token(Token = "0x60031BA")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x060031BB RID: 12731 RVA: 0x00106924 File Offset: 0x00104B24
	[Token(Token = "0x60031BB")]
	[Address(RVA = "0x7261C0", Offset = "0x7247C0", VA = "0x1807261C0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：冷冻冬眠";
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x00106938 File Offset: 0x00104B38
	[Token(Token = "0x60031BC")]
	[Address(RVA = "0x726420", Offset = "0x724A20", VA = "0x180726420", Slot = "34")]
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

	// Token: 0x060031BD RID: 12733 RVA: 0x001069D0 File Offset: 0x00104BD0
	[Token(Token = "0x60031BD")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SnowSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
