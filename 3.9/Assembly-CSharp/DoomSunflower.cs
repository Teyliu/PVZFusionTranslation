using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004CD RID: 1229
[Token(Token = "0x20004CD")]
public class DoomSunflower : SunFlower
{
	// Token: 0x0600172F RID: 5935 RVA: 0x0007F3D0 File Offset: 0x0007D5D0
	[Token(Token = "0x600172F")]
	[Address(RVA = "0x50E3D0", Offset = "0x50C9D0", VA = "0x18050E3D0", Slot = "69")]
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

	// Token: 0x06001730 RID: 5936 RVA: 0x0007F4DC File Offset: 0x0007D6DC
	[Token(Token = "0x6001730")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomSunflower()
	{
	}
}
