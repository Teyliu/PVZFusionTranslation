using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B05 RID: 2821
	[Token(Token = "0x2000B05")]
	public class HypnoEmperor : TravelAdvantureLevelData
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x00134ED0 File Offset: 0x001330D0
		[Token(Token = "0x1700044E")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003AB7")]
			[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "42")]
			get
			{
				return TravelAdvanture.HypnoEmperor;
			}
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x00134EE0 File Offset: 0x001330E0
		[Token(Token = "0x6003AB8")]
		[Address(RVA = "0x788F00", Offset = "0x787500", VA = "0x180788F00", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "魅惑菇 + 魅惑菇\n使用樱桃炸弹、魅惑菇进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x00134F0C File Offset: 0x0013310C
		[Token(Token = "0x6003AB9")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x00134F38 File Offset: 0x00133138
		[Token(Token = "0x1700044F")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003ABA")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x00134F50 File Offset: 0x00133150
		[Token(Token = "0x17000450")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003ABB")]
			[Address(RVA = "0x7890A0", Offset = "0x7876A0", VA = "0x1807890A0", Slot = "20")]
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

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06003ABC RID: 15036 RVA: 0x00134FA8 File Offset: 0x001331A8
		[Token(Token = "0x17000451")]
		public override int MaxWave
		{
			[Token(Token = "0x6003ABC")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06003ABD RID: 15037 RVA: 0x00134FB8 File Offset: 0x001331B8
		[Token(Token = "0x17000452")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003ABD")]
			[Address(RVA = "0x788F80", Offset = "0x787580", VA = "0x180788F80", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00134FF4 File Offset: 0x001331F4
		[Token(Token = "0x6003ABE")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public HypnoEmperor()
		{
		}
	}
}
