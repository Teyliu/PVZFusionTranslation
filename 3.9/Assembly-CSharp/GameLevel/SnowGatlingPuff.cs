using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B43 RID: 2883
	[Token(Token = "0x2000B43")]
	public class SnowGatlingPuff : TravelAdvantureLevelData
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x00139CE8 File Offset: 0x00137EE8
		[Token(Token = "0x1700048A")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003BE8")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "42")]
			get
			{
				return TravelAdvanture.SnowGatlingPuff;
			}
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00139CF8 File Offset: 0x00137EF8
		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x7F9E40", Offset = "0x7F8440", VA = "0x1807F9E40", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "机枪小喷菇 + 寒冰菇\n使用向日葵、寒冰菇进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00139D24 File Offset: 0x00137F24
		[Token(Token = "0x6003BEA")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x00139D50 File Offset: 0x00137F50
		[Token(Token = "0x1700048B")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003BEB")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x00139D68 File Offset: 0x00137F68
		[Token(Token = "0x1700048C")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003BEC")]
			[Address(RVA = "0x7FA030", Offset = "0x7F8630", VA = "0x1807FA030", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x00139DC0 File Offset: 0x00137FC0
		[Token(Token = "0x1700048D")]
		public override int MaxWave
		{
			[Token(Token = "0x6003BED")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x00139DD0 File Offset: 0x00137FD0
		[Token(Token = "0x1700048E")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003BEE")]
			[Address(RVA = "0x7F9EC0", Offset = "0x7F84C0", VA = "0x1807F9EC0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x00139E14 File Offset: 0x00138014
		[Token(Token = "0x6003BEF")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public SnowGatlingPuff()
		{
		}
	}
}
