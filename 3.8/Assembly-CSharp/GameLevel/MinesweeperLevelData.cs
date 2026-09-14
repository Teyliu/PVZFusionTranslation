using System;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;

namespace GameLevel
{
	// Token: 0x02000ADA RID: 2778
	[Token(Token = "0x2000ADA")]
	public class MinesweeperLevelData : ChallengeLevelData
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x00130330 File Offset: 0x0012E530
		[Token(Token = "0x170003D4")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60039A0")]
			[Address(RVA = "0x49F740", Offset = "0x49DD40", VA = "0x18049F740", Slot = "42")]
			get
			{
				return ChallengeLevel.Minesweeper;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060039A1 RID: 14753 RVA: 0x00130344 File Offset: 0x0012E544
		// (set) Token: 0x060039A2 RID: 14754 RVA: 0x00130358 File Offset: 0x0012E558
		[Token(Token = "0x170003D5")]
		public override string Name
		{
			[Token(Token = "0x60039A1")]
			[Address(RVA = "0x78B5C0", Offset = "0x789BC0", VA = "0x18078B5C0", Slot = "8")]
			get
			{
				return "扫雷";
			}
			[Token(Token = "0x60039A2")]
			[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50", Slot = "9")]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0013036C File Offset: 0x0012E56C
		[Token(Token = "0x60039A3")]
		[Address(RVA = "0x78AFF0", Offset = "0x7895F0", VA = "0x18078AFF0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			if (base.CardCount != 0)
			{
				int cardCount = base.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig = base.Config.Copy();
			board.config = boardConfig;
			float firstWaveArrivedTimer = base.Config.firstWaveArrivedTimer;
			board.timeUntilNextWave = firstWaveArrivedTimer;
			MinesweeperManager minesweeperManager = board.AddComponent<MinesweeperManager>();
			board.boardTag.disableInInterlude = true;
			board.boardTag.disableNormalSun = true;
			board.boardTag.disableSummonZombie = true;
			board.showPlantHealth = (int)((ulong)1L);
			board.boardTag.is2048 = true;
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x001303FC File Offset: 0x0012E5FC
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x78B110", Offset = "0x789710", VA = "0x18078B110", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			int num2 = 0;
			instance.ShowText("坚果血量/价格为周围8格子内雷的数量，如果开到地雷则游戏失败\n左键坚果时，如果周围已经有该坚果对应数量的标记，则自动打开剩余罐子\n可以使用极寒冰豆标记地雷，樱桃三叶草作为备用标记\n路灯花可以照亮周围8格的罐子，上面的数字为5x5范围内地雷的数量", 20f, num2 != 0);
			InGameUI.Instance.UpperUI();
			InitBoard instance2 = InitBoard.Instance;
			CardUI cardUI;
			cardUI.theSeedCost = num;
			cardUI.CD = (float)num;
			InitBoard instance3 = InitBoard.Instance;
			CardUI cardUI2;
			cardUI2.theSeedCost = num;
			cardUI2.CD = (float)num;
			InitBoard instance4 = InitBoard.Instance;
			CardUI cardUI3;
			cardUI3.theSeedCost = (int)((ulong)100L);
			cardUI3.CD = (float)num;
			int num3 = GameAPP.config.difficulty;
			num3 += 5;
			long num4 = (long)(num3 * (int)((uint)100));
			board.theSun = (int)num4;
			PlantType[] numberPlantTypes = MinesweeperManager.NumberPlantTypes;
			if (num < numberPlantTypes.Length)
			{
				InitBoard instance5 = InitBoard.Instance;
				PlantType[] numberPlantTypes2 = MinesweeperManager.NumberPlantTypes;
				int num5 = 0;
				PlantType plantType;
				ulong num6;
				CardUI cardUI4 = instance5.CreateCard(plantType, num6 != 0UL, num5 != 0);
				num++;
				uint num7;
				num7 += (uint)4;
				cardUI4.theSeedCost = 1;
			}
			GameAPP instance6 = GameAPP.Instance;
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x001304EC File Offset: 0x0012E6EC
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x78AFB0", Offset = "0x7895B0", VA = "0x18078AFB0", Slot = "33")]
		public override bool ClickCard(CardUI card)
		{
			PlantType thePlantType = card.thePlantType;
			if (thePlantType != PlantType.Plantern && thePlantType != PlantType.IceBean)
			{
				return thePlantType != PlantType.CherryBlover;
			}
			throw new NullReferenceException();
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060039A6 RID: 14758 RVA: 0x00130524 File Offset: 0x0012E724
		// (set) Token: 0x060039A7 RID: 14759 RVA: 0x00130534 File Offset: 0x0012E734
		[Token(Token = "0x170003D6")]
		public override int MaxWave
		{
			[Token(Token = "0x60039A6")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
			[Token(Token = "0x60039A7")]
			[Address(RVA = "0x783390", Offset = "0x781990", VA = "0x180783390", Slot = "11")]
			set
			{
				this.<MaxWave>k__BackingField = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x00130548 File Offset: 0x0012E748
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x00130558 File Offset: 0x0012E758
		[Token(Token = "0x170003D7")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60039A8")]
			[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "12")]
			get
			{
				return SceneType.SuperDay;
			}
			[Token(Token = "0x60039A9")]
			[Address(RVA = "0x6FBEA0", Offset = "0x6FA4A0", VA = "0x1806FBEA0", Slot = "13")]
			set
			{
				this.<SceneType>k__BackingField = value;
			}
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x0013056C File Offset: 0x0012E76C
		[Token(Token = "0x60039AA")]
		[Address(RVA = "0x78B3F0", Offset = "0x7899F0", VA = "0x18078B3F0", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			PlantType thePlantType = plant.thePlantType;
			int num = 0;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				int num3 = plant.thePlantColumn;
				int num4 = plant.thePlantColumn;
				num4 += 2;
				int num5 = plant.thePlantRow;
				int num6 = plant.thePlantRow;
				num6 += 2;
				num6 = num5;
				int num7 = num6 * num;
				num7 += num3;
				num2++;
				num5++;
				num3++;
			}
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x001305FC File Offset: 0x0012E7FC
		[Token(Token = "0x60039AB")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public MinesweeperLevelData()
		{
		}
	}
}
