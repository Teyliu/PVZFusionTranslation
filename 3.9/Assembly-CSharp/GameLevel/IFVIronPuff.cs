using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B4D RID: 2893
	[Token(Token = "0x2000B4D")]
	public class IFVIronPuff : TravelAdvantureLevelData
	{
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06003C38 RID: 15416 RVA: 0x0013A9F8 File Offset: 0x00138BF8
		[Token(Token = "0x170004BC")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C38")]
			[Address(RVA = "0x3F72C0", Offset = "0x3F58C0", VA = "0x1803F72C0", Slot = "42")]
			get
			{
				return TravelAdvanture.IFVIronPuff;
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x0013AA08 File Offset: 0x00138C08
		[Token(Token = "0x6003C39")]
		[Address(RVA = "0x82BB10", Offset = "0x82A110", VA = "0x18082BB10", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "铁豆x3 + 磁力菇\n使用三叶草、磁力菇进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x0013AA34 File Offset: 0x00138C34
		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x0013AA60 File Offset: 0x00138C60
		[Token(Token = "0x170004BD")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C3B")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06003C3C RID: 15420 RVA: 0x0013AA70 File Offset: 0x00138C70
		[Token(Token = "0x170004BE")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C3C")]
			[Address(RVA = "0x82BD00", Offset = "0x82A300", VA = "0x18082BD00", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				return list;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x0013AAE0 File Offset: 0x00138CE0
		[Token(Token = "0x170004BF")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C3D")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06003C3E RID: 15422 RVA: 0x0013AAF0 File Offset: 0x00138CF0
		[Token(Token = "0x170004C0")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C3E")]
			[Address(RVA = "0x82BB90", Offset = "0x82A190", VA = "0x18082BB90", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x0013AB34 File Offset: 0x00138D34
		[Token(Token = "0x6003C3F")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public IFVIronPuff()
		{
		}
	}
}
