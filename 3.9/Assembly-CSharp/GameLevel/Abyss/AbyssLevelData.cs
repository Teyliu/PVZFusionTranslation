using System;
using Core;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C3C RID: 3132
	[Token(Token = "0x2000C3C")]
	public abstract class AbyssLevelData : LevelData
	{
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x0015777C File Offset: 0x0015597C
		[Token(Token = "0x17000513")]
		public override int LevelNumber
		{
			[Token(Token = "0x600413F")]
			[Address(RVA = "0x7EA480", Offset = "0x7E8A80", VA = "0x1807EA480", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x0015778C File Offset: 0x0015598C
		[Token(Token = "0x17000514")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6004140")]
			[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "14")]
			get
			{
				return LevelType.AbyssRealm;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06004141 RID: 16705
		[Token(Token = "0x17000515")]
		protected abstract AbyssLevel Level
		{
			[Token(Token = "0x6004141")]
			[Address(Slot = "42")]
			get;
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x0015779C File Offset: 0x0015599C
		[Token(Token = "0x17000516")]
		public override string Name
		{
			[Token(Token = "0x6004142")]
			[Address(RVA = "0x873D30", Offset = "0x872330", VA = "0x180873D30", Slot = "8")]
			get
			{
				int levelNumber = this.LevelNumber;
				return string.Format("冒险秘境：第{0}关", levelNumber);
			}
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x001577BC File Offset: 0x001559BC
		[Token(Token = "0x6004143")]
		[Address(RVA = "0x873B60", Offset = "0x872160", VA = "0x180873B60", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1006));
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x001577E8 File Offset: 0x001559E8
		[Token(Token = "0x6004144")]
		[Address(RVA = "0x873BE0", Offset = "0x8721E0", VA = "0x180873BE0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			Singleton.Instance.OnBoardStart(board);
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x00157810 File Offset: 0x00155A10
		[Token(Token = "0x6004145")]
		[Address(RVA = "0x873C50", Offset = "0x872250", VA = "0x180873C50", Slot = "37")]
		public override void OnBoardWin(Board board)
		{
			base.OnBoardStart(board);
			Singleton.Instance.OnBoardWin(board);
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x00157838 File Offset: 0x00155A38
		[Token(Token = "0x6004146")]
		[Address(RVA = "0x873CC0", Offset = "0x8722C0", VA = "0x180873CC0", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			base.ReinforcePlant(plant);
			Singleton.Instance.ReinforcePlant(plant);
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x00157860 File Offset: 0x00155A60
		[Token(Token = "0x6004147")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		protected AbyssLevelData()
		{
		}
	}
}
