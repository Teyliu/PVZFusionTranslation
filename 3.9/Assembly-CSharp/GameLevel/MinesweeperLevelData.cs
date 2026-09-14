using System;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;

namespace GameLevel
{
	// Token: 0x02000B1A RID: 2842
	[Token(Token = "0x2000B1A")]
	public class MinesweeperLevelData : ChallengeLevelData
	{
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x00135470 File Offset: 0x00133670
		[Token(Token = "0x1700041C")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003AE4")]
			[Address(RVA = "0x51EF10", Offset = "0x51D510", VA = "0x18051EF10", Slot = "42")]
			get
			{
				return ChallengeLevel.Minesweeper;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x00135484 File Offset: 0x00133684
		// (set) Token: 0x06003AE6 RID: 15078 RVA: 0x00135498 File Offset: 0x00133698
		[Token(Token = "0x1700041D")]
		public override string Name
		{
			[Token(Token = "0x6003AE5")]
			[Address(RVA = "0x7F1C40", Offset = "0x7F0240", VA = "0x1807F1C40", Slot = "8")]
			get
			{
				return "扫雷";
			}
			[Token(Token = "0x6003AE6")]
			[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980", Slot = "9")]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x001354AC File Offset: 0x001336AC
		[Token(Token = "0x6003AE7")]
		[Address(RVA = "0x7F1660", Offset = "0x7EFC60", VA = "0x1807F1660", Slot = "39")]
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

		// Token: 0x06003AE8 RID: 15080 RVA: 0x0013553C File Offset: 0x0013373C
		[Token(Token = "0x6003AE8")]
		[Address(RVA = "0x7F1780", Offset = "0x7EFD80", VA = "0x1807F1780", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
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
			int num2 = GameAPP.config.difficulty;
			num2 += 5;
			long num3 = (long)(num2 * (int)((uint)100));
			board.theSun = (int)num3;
			PlantType[] numberPlantTypes = MinesweeperManager.NumberPlantTypes;
			if (num < numberPlantTypes.Length)
			{
				InitBoard instance5 = InitBoard.Instance;
				PlantType[] numberPlantTypes2 = MinesweeperManager.NumberPlantTypes;
				int num4 = 0;
				PlantType plantType;
				ulong num5;
				CardUI cardUI4 = instance5.CreateCard(plantType, num5 != 0UL, num4 != 0);
				num++;
				uint num6;
				num6 += (uint)4;
				cardUI4.theSeedCost = 1;
			}
			GameAPP instance6 = GameAPP.Instance;
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00135618 File Offset: 0x00133818
		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x7F1620", Offset = "0x7EFC20", VA = "0x1807F1620", Slot = "33")]
		public override bool ClickCard(CardUI card)
		{
			PlantType thePlantType = card.thePlantType;
			if (thePlantType != PlantType.Plantern && thePlantType != PlantType.IceBean)
			{
				return thePlantType != PlantType.CherryBlover;
			}
			throw new NullReferenceException();
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x00135650 File Offset: 0x00133850
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x00135660 File Offset: 0x00133860
		[Token(Token = "0x1700041E")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
			[Token(Token = "0x6003AEB")]
			[Address(RVA = "0x7EA240", Offset = "0x7E8840", VA = "0x1807EA240", Slot = "11")]
			set
			{
				this.<MaxWave>k__BackingField = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x00135674 File Offset: 0x00133874
		// (set) Token: 0x06003AED RID: 15085 RVA: 0x00135684 File Offset: 0x00133884
		[Token(Token = "0x1700041F")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AEC")]
			[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "12")]
			get
			{
				return SceneType.SuperDay;
			}
			[Token(Token = "0x6003AED")]
			[Address(RVA = "0x761240", Offset = "0x75F840", VA = "0x180761240", Slot = "13")]
			set
			{
				this.<SceneType>k__BackingField = value;
			}
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x00135698 File Offset: 0x00133898
		[Token(Token = "0x6003AEE")]
		[Address(RVA = "0x7F1A70", Offset = "0x7F0070", VA = "0x1807F1A70", Slot = "34")]
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

		// Token: 0x06003AEF RID: 15087 RVA: 0x00135728 File Offset: 0x00133928
		[Token(Token = "0x6003AEF")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public MinesweeperLevelData()
		{
		}
	}
}
