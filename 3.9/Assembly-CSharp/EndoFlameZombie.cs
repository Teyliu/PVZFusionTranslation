using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000697 RID: 1687
[Token(Token = "0x2000697")]
public class EndoFlameZombie : Zombie
{
	// Token: 0x06002017 RID: 8215 RVA: 0x000A9FF4 File Offset: 0x000A81F4
	[Token(Token = "0x6002017")]
	[Address(RVA = "0x5A6550", Offset = "0x5A4B50", VA = "0x1805A6550", Slot = "16")]
	protected override void Start()
	{
		int num3;
		do
		{
			base.Start();
			uint num;
			base.Die((int)num);
			List<Vector2Int> list = new List();
			int num2 = this.board.columnNum;
			Board board = this.board;
			num3 = 0;
			if (num2 < board.columnNum)
			{
				Board board2 = this.board;
				if (num3 < board2.rowNum)
				{
					if (board2.gridSystem.GetGrid(num2, num3).boxType != BoxType.Water)
					{
					}
					num3++;
				}
				num2++;
			}
			Func<Vector2Int, bool> func;
			if (EndoFlameZombie.<>c.<>9__0_0 == 0)
			{
				func = delegate(Vector2Int box)
				{
					int x2 = box.m_X;
					bool flag2;
					return flag2;
				};
				EndoFlameZombie.<>c.<>9__0_0 = func;
			}
			List<Vector2Int> list2 = Enumerable.ToList<Vector2Int>(Enumerable.Where<Vector2Int>(list, func));
			int num4 = list._size;
			num4 = global::UnityEngine.Random.Range(0, num4);
			int x = list[num4].m_X;
			bool flag;
			if (flag)
			{
				CreatePlant instance = CreatePlant.Instance;
			}
		}
		while (num3 != 0);
		CreatePlant instance2 = CreatePlant.Instance;
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x000AA0FC File Offset: 0x000A82FC
	[Token(Token = "0x6002018")]
	[Address(RVA = "0x5A6A50", Offset = "0x5A5050", VA = "0x1805A6A50")]
	public EndoFlameZombie()
	{
	}
}
