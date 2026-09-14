using System;
using Cpp2IlInjected;
using UnityEngine;

namespace AdvBuffData
{
	// Token: 0x02000DE1 RID: 3553
	[Token(Token = "0x2000DE1")]
	public class Random_回收计划 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060049A2 RID: 18850 RVA: 0x0016C3E4 File Offset: 0x0016A5E4
		[Token(Token = "0x17000955")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60049A2")]
			[Address(RVA = "0x89EA70", Offset = "0x89D070", VA = "0x18089EA70", Slot = "12")]
			get
			{
				return AdvBuff.Random_回收计划;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x0016C3F8 File Offset: 0x0016A5F8
		[Token(Token = "0x17000956")]
		public override string Description
		{
			[Token(Token = "0x60049A3")]
			[Address(RVA = "0x8CFB60", Offset = "0x8CE160", VA = "0x1808CFB60", Slot = "13")]
			get
			{
				return "回收计划：立即获得10个超级黄金罐子卡牌，然后每一小波都获得1个，每一大波获得5个";
			}
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x0016C40C File Offset: 0x0016A60C
		[Token(Token = "0x60049A4")]
		[Address(RVA = "0x8CF9A0", Offset = "0x8CDFA0", VA = "0x1808CF9A0", Slot = "17")]
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

		// Token: 0x060049A5 RID: 18853 RVA: 0x0016C46C File Offset: 0x0016A66C
		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x8CF7F0", Offset = "0x8CDDF0", VA = "0x1808CF7F0", Slot = "15")]
		public override void OnBoardStart(Board board)
		{
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x0016C47C File Offset: 0x0016A67C
		[Token(Token = "0x60049A6")]
		[Address(RVA = "0x8CFB20", Offset = "0x8CE120", VA = "0x1808CFB20")]
		public Random_回收计划()
		{
		}
	}
}
