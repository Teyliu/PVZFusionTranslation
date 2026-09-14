using System;
using Core;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CD7 RID: 3287
	[Token(Token = "0x2000CD7")]
	public abstract class AbyssLevelData : LevelData
	{
		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x0015D7E4 File Offset: 0x0015B9E4
		[Token(Token = "0x17000789")]
		public override int LevelNumber
		{
			[Token(Token = "0x60044D5")]
			[Address(RVA = "0x783AC0", Offset = "0x7820C0", VA = "0x180783AC0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x0015D7F4 File Offset: 0x0015B9F4
		[Token(Token = "0x1700078A")]
		public override LevelType LevelType
		{
			[Token(Token = "0x60044D6")]
			[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "14")]
			get
			{
				return LevelType.AbyssRealm;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060044D7 RID: 17623
		[Token(Token = "0x1700078B")]
		protected abstract AbyssLevel Level
		{
			[Token(Token = "0x60044D7")]
			[Address(Slot = "42")]
			get;
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x0015D804 File Offset: 0x0015BA04
		[Token(Token = "0x1700078C")]
		public override string Name
		{
			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x8266F0", Offset = "0x824CF0", VA = "0x1808266F0", Slot = "8")]
			get
			{
				int levelNumber = this.LevelNumber;
				return string.Format("冒险秘境：第{0}关", levelNumber);
			}
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x0015D824 File Offset: 0x0015BA24
		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x826520", Offset = "0x824B20", VA = "0x180826520", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1006));
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x0015D850 File Offset: 0x0015BA50
		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x8265A0", Offset = "0x824BA0", VA = "0x1808265A0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			Singleton.Instance.OnBoardStart(board);
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x0015D878 File Offset: 0x0015BA78
		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x826610", Offset = "0x824C10", VA = "0x180826610", Slot = "37")]
		public override void OnBoardWin(Board board)
		{
			base.OnBoardStart(board);
			Singleton.Instance.OnBoardWin(board);
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x0015D8A0 File Offset: 0x0015BAA0
		[Token(Token = "0x60044DC")]
		[Address(RVA = "0x826680", Offset = "0x824C80", VA = "0x180826680", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			base.ReinforcePlant(plant);
			Singleton.Instance.ReinforcePlant(plant);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x0015D8C8 File Offset: 0x0015BAC8
		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		protected AbyssLevelData()
		{
		}
	}
}
