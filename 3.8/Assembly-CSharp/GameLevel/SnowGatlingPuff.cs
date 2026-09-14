using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B01 RID: 2817
	[Token(Token = "0x2000B01")]
	public class SnowGatlingPuff : TravelAdvantureLevelData
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x00134998 File Offset: 0x00132B98
		[Token(Token = "0x1700043A")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003A97")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "42")]
			get
			{
				return TravelAdvanture.SnowGatlingPuff;
			}
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x001349A8 File Offset: 0x00132BA8
		[Token(Token = "0x6003A98")]
		[Address(RVA = "0x792C00", Offset = "0x791200", VA = "0x180792C00", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "机枪小喷菇 + 寒冰菇\n使用向日葵、寒冰菇进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x001349D4 File Offset: 0x00132BD4
		[Token(Token = "0x6003A99")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x00134A00 File Offset: 0x00132C00
		[Token(Token = "0x1700043B")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A9A")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06003A9B RID: 15003 RVA: 0x00134A18 File Offset: 0x00132C18
		[Token(Token = "0x1700043C")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A9B")]
			[Address(RVA = "0x792DF0", Offset = "0x7913F0", VA = "0x180792DF0", Slot = "20")]
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

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06003A9C RID: 15004 RVA: 0x00134A70 File Offset: 0x00132C70
		[Token(Token = "0x1700043D")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A9C")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06003A9D RID: 15005 RVA: 0x00134A80 File Offset: 0x00132C80
		[Token(Token = "0x1700043E")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003A9D")]
			[Address(RVA = "0x792C80", Offset = "0x791280", VA = "0x180792C80", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x00134AC4 File Offset: 0x00132CC4
		[Token(Token = "0x6003A9E")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public SnowGatlingPuff()
		{
		}
	}
}
