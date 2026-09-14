using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B45 RID: 2885
	[Token(Token = "0x2000B45")]
	public class SuperSunNut : TravelAdvantureLevelData
	{
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x00139F80 File Offset: 0x00138180
		[Token(Token = "0x17000494")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003BF8")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "42")]
			get
			{
				return TravelAdvanture.SuperSunNut;
			}
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00139F90 File Offset: 0x00138190
		[Token(Token = "0x6003BF9")]
		[Address(RVA = "0x832A70", Offset = "0x831070", VA = "0x180832A70", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "阳光坚果 + 坚果墙\n使用火爆辣椒、向日葵进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x00139FBC File Offset: 0x001381BC
		[Token(Token = "0x6003BFA")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x00139FE8 File Offset: 0x001381E8
		[Token(Token = "0x17000495")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003BFB")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x0013A000 File Offset: 0x00138200
		[Token(Token = "0x17000496")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003BFC")]
			[Address(RVA = "0x832CC0", Offset = "0x8312C0", VA = "0x180832CC0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				return list;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06003BFD RID: 15357 RVA: 0x0013A060 File Offset: 0x00138260
		[Token(Token = "0x17000497")]
		public override int MaxWave
		{
			[Token(Token = "0x6003BFD")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06003BFE RID: 15358 RVA: 0x0013A070 File Offset: 0x00138270
		[Token(Token = "0x17000498")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003BFE")]
			[Address(RVA = "0x832AF0", Offset = "0x8310F0", VA = "0x180832AF0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x0013A0BC File Offset: 0x001382BC
		[Token(Token = "0x6003BFF")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public SuperSunNut()
		{
		}
	}
}
