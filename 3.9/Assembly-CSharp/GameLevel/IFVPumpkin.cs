using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B4B RID: 2891
	[Token(Token = "0x2000B4B")]
	public class IFVPumpkin : TravelAdvantureLevelData
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06003C28 RID: 15400 RVA: 0x0013A748 File Offset: 0x00138948
		[Token(Token = "0x170004B2")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C28")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "42")]
			get
			{
				return TravelAdvanture.IFVPumpkin;
			}
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x0013A758 File Offset: 0x00138958
		[Token(Token = "0x6003C29")]
		[Address(RVA = "0x82C020", Offset = "0x82A620", VA = "0x18082C020", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "磁力南瓜 + 磁力菇\n使用杨桃、南瓜头进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x0013A784 File Offset: 0x00138984
		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x0013A7B0 File Offset: 0x001389B0
		[Token(Token = "0x170004B3")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C2B")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x0013A7C0 File Offset: 0x001389C0
		[Token(Token = "0x170004B4")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C2C")]
			[Address(RVA = "0x82C270", Offset = "0x82A870", VA = "0x18082C270", Slot = "20")]
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x0013A830 File Offset: 0x00138A30
		[Token(Token = "0x170004B5")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C2D")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x0013A840 File Offset: 0x00138A40
		[Token(Token = "0x170004B6")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C2E")]
			[Address(RVA = "0x82C0A0", Offset = "0x82A6A0", VA = "0x18082C0A0", Slot = "22")]
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

		// Token: 0x06003C2F RID: 15407 RVA: 0x0013A88C File Offset: 0x00138A8C
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public IFVPumpkin()
		{
		}
	}
}
