using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000661 RID: 1633
[Token(Token = "0x2000661")]
public class EndoFlameZombie : Zombie
{
	// Token: 0x06001F15 RID: 7957 RVA: 0x000A587C File Offset: 0x000A3A7C
	[Token(Token = "0x6001F15")]
	[Address(RVA = "0x543F30", Offset = "0x542530", VA = "0x180543F30", Slot = "15")]
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

	// Token: 0x06001F16 RID: 7958 RVA: 0x000A5984 File Offset: 0x000A3B84
	[Token(Token = "0x6001F16")]
	[Address(RVA = "0x544430", Offset = "0x542A30", VA = "0x180544430")]
	public EndoFlameZombie()
	{
	}
}
