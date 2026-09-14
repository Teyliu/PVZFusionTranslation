using System;
using Cpp2IlInjected;
using UnityEngine;

namespace AdvBuffData
{
	// Token: 0x02000D19 RID: 3353
	[Token(Token = "0x2000D19")]
	public class Random_回收计划 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06004601 RID: 17921 RVA: 0x00161F90 File Offset: 0x00160190
		[Token(Token = "0x170007DF")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004601")]
			[Address(RVA = "0x84AA60", Offset = "0x849060", VA = "0x18084AA60", Slot = "12")]
			get
			{
				return AdvBuff.Random_回收计划;
			}
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00161FA4 File Offset: 0x001601A4
		[Token(Token = "0x6004602")]
		[Address(RVA = "0x84A870", Offset = "0x848E70", VA = "0x18084A870", Slot = "13")]
		public override string GetDescription()
		{
			return "回收计划：立即获得10个超级黄金罐子卡牌，然后每一小波都获得1个，每一大波获得5个";
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00161FB8 File Offset: 0x001601B8
		[Token(Token = "0x6004603")]
		[Address(RVA = "0x84A8A0", Offset = "0x848EA0", VA = "0x18084A8A0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Board board = board;
			Board board2 = board;
			int num;
			num -= board;
			Vector2 vector;
			Vector2 Position = vector;
			Position.y = (float)0;
			Action action = delegate
			{
				int theWave = board.theWave;
				ulong num3;
				num3 += num3;
				num3 += num3;
				if ((ulong)theWave == num3)
				{
					while ((ulong)theWave != num3)
					{
					}
				}
			};
			int num2 = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num2 != 0);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x00162018 File Offset: 0x00160218
		[Token(Token = "0x6004604")]
		[Address(RVA = "0x84A4D0", Offset = "0x848AD0", VA = "0x18084A4D0", Slot = "15")]
		public override void OnBoardStart(Board board)
		{
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x00162028 File Offset: 0x00160228
		[Token(Token = "0x6004605")]
		[Address(RVA = "0x84AA20", Offset = "0x849020", VA = "0x18084AA20")]
		public Random_回收计划()
		{
		}
	}
}
