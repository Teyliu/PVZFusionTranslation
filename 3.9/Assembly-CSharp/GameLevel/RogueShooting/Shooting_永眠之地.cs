using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C84 RID: 3204
	[Token(Token = "0x2000C84")]
	public class Shooting_永眠之地 : BaseDebuff
	{
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x0015C514 File Offset: 0x0015A714
		[Token(Token = "0x1700059B")]
		public override int Point
		{
			[Token(Token = "0x6004291")]
			[Address(RVA = "0x720BB0", Offset = "0x71F1B0", VA = "0x180720BB0", Slot = "21")]
			get
			{
				return 50;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x0015C524 File Offset: 0x0015A724
		[Token(Token = "0x1700059C")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004292")]
			[Address(RVA = "0x89FC10", Offset = "0x89E210", VA = "0x18089FC10", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_永眠之地;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x0015C538 File Offset: 0x0015A738
		[Token(Token = "0x1700059D")]
		public override string Description
		{
			[Token(Token = "0x6004293")]
			[Address(RVA = "0x89FC20", Offset = "0x89E220", VA = "0x18089FC20", Slot = "13")]
			get
			{
				return "永眠之地：开局场上获得三列墓碑";
			}
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x0015C54C File Offset: 0x0015A74C
		[Token(Token = "0x6004294")]
		[Address(RVA = "0x89FB70", Offset = "0x89E170", VA = "0x18089FB70", Slot = "17")]
		public override void OnSelect(Board board)
		{
			int num = 0;
			if (num < board.rowNum)
			{
				int columnNum = board.columnNum;
				int columnNum2 = board.columnNum;
				int columnNum3 = board.columnNum;
				num++;
			}
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x0015C588 File Offset: 0x0015A788
		[Token(Token = "0x6004295")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_永眠之地()
		{
		}
	}
}
