using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A9 RID: 1193
[Token(Token = "0x20004A9")]
public class DoomSunflower : SunFlower
{
	// Token: 0x06001686 RID: 5766 RVA: 0x0007C778 File Offset: 0x0007A978
	[Token(Token = "0x6001686")]
	[Address(RVA = "0x4A2930", Offset = "0x4A0F30", VA = "0x1804A2930", Slot = "70")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
		List<Vector2Int> list = new List();
		int num = this.thePlantColumn;
		int i = this.thePlantColumn;
		num++;
		int j = this.thePlantRow;
		int num2 = this.thePlantRow;
		num2++;
		Board board = this.board;
		if (i >= board.columnNum || j < board.rowNum)
		{
		}
		int num3 = this.thePlantRow;
		j++;
		num3++;
		while (j <= num3)
		{
		}
		int num4 = this.thePlantColumn;
		i++;
		num4++;
		while (i <= num4)
		{
		}
		int num5 = list._size;
		i = global::UnityEngine.Random.Range(0, num5);
		num5 = i;
		CreatePlant instance2 = CreatePlant.Instance;
		Vector2Int vector2Int = list[num5];
		num5 = i;
		Vector2Int vector2Int2 = list[num5];
		int num6 = 0;
		Plant plant;
		if (!(plant != num6))
		{
			list.RemoveAt(i);
		}
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x0007C884 File Offset: 0x0007AA84
	[Token(Token = "0x6001687")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomSunflower()
	{
	}
}
