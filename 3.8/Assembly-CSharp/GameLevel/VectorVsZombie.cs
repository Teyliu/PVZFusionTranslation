using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000AE9 RID: 2793
	[Token(Token = "0x2000AE9")]
	public class VectorVsZombie : ChallengeLevelData
	{
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x00132528 File Offset: 0x00130728
		[Token(Token = "0x170003F9")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003A07")]
			[Address(RVA = "0x4E6050", Offset = "0x4E4650", VA = "0x1804E6050", Slot = "42")]
			get
			{
				return ChallengeLevel.VectorVsZombie;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06003A08 RID: 14856 RVA: 0x0013253C File Offset: 0x0013073C
		[Token(Token = "0x170003FA")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A08")]
			[Address(RVA = "0x6A1E90", Offset = "0x6A0490", VA = "0x1806A1E90", Slot = "12")]
			get
			{
				return SceneType.MidMap;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x0013254C File Offset: 0x0013074C
		[Token(Token = "0x170003FB")]
		public override string Name
		{
			[Token(Token = "0x6003A09")]
			[Address(RVA = "0x79D2C0", Offset = "0x79B8C0", VA = "0x18079D2C0", Slot = "8")]
			get
			{
				return "僵尸分拣大挑战";
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x00132560 File Offset: 0x00130760
		[Token(Token = "0x170003FC")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A0A")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00132570 File Offset: 0x00130770
		[Token(Token = "0x6003A0B")]
		[Address(RVA = "0x79CD80", Offset = "0x79B380", VA = "0x18079CD80", Slot = "39")]
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
			board.boardTag.disableSelectCard = true;
			board.fallSun = false;
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x001325D4 File Offset: 0x001307D4
		[Token(Token = "0x6003A0C")]
		[Address(RVA = "0x79CE50", Offset = "0x79B450", VA = "0x18079CE50", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			board.theSun = (int)((ulong)3L);
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x00132614 File Offset: 0x00130814
		[Token(Token = "0x6003A0D")]
		[Address(RVA = "0x79CAF0", Offset = "0x79B0F0", VA = "0x18079CAF0")]
		private void FixZombieBack(object obj)
		{
			CreateZombie instance = CreateZombie.Instance;
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x00132630 File Offset: 0x00130830
		[Token(Token = "0x6003A0E")]
		[Address(RVA = "0x79CCB0", Offset = "0x79B2B0", VA = "0x18079CCB0", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x00132654 File Offset: 0x00130854
		[Token(Token = "0x6003A0F")]
		[Address(RVA = "0x79CFB0", Offset = "0x79B5B0", VA = "0x18079CFB0", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			BoardConfig config = plant.board.config;
			if (config.applyRandomData)
			{
				float num = config.plantModifyMin;
				float plantModifyMax = config.plantModifyMax;
				float num2 = global::Core.Lawnf.GetRandomLogSymmetric(num, plantModifyMax);
				int num3 = 0;
				num = num2;
				plant.ModifyHealth((PlantHealthAdder)((uint)5), num2, num3 != 0);
				int num4 = 0;
				int num5 = 0;
				num2 = num;
				plant.ModifyDamage((PlantDamageAdder)((uint)44), num2, num5 != 0, num4);
				float plantSpeedAvg = config.plantSpeedAvg;
				float num6 = config.plantSpeedMax;
				float randomWithMean = global::Core.Lawnf.GetRandomWithMean(config.plantSpeedMin, num6, plantSpeedAvg);
				num6 = randomWithMean;
				plant.attributeSpeed = randomWithMean;
				plant.attackSpeedAdder = num6;
				num6 = randomWithMean;
				float num7 = num6 * plant.thePlantSpeed;
				plant.thePlantSpeed = num7;
				float num8;
				plant.thePlantProduceInterval = num8;
			}
			if (plant.thePlantType == PlantType.VectorPlant)
			{
				plant.theStatus = (PlantStatus)((ulong)25L);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x00132728 File Offset: 0x00130928
		[Token(Token = "0x170003FD")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003A10")]
			[Address(RVA = "0x79D2F0", Offset = "0x79B8F0", VA = "0x18079D2F0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				int size9 = list._size;
				int size10 = list._size;
				int size11 = list._size;
				int size12 = list._size;
				int size13 = list._size;
				int size14 = list._size;
				return list;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06003A11 RID: 14865 RVA: 0x001327C4 File Offset: 0x001309C4
		[Token(Token = "0x170003FE")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A11")]
			[Address(RVA = "0x79D810", Offset = "0x79BE10", VA = "0x18079D810", Slot = "20")]
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

		// Token: 0x06003A12 RID: 14866 RVA: 0x0013281C File Offset: 0x00130A1C
		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x79CBE0", Offset = "0x79B1E0", VA = "0x18079CBE0")]
		public void GameLogic(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00132840 File Offset: 0x00130A40
		[Token(Token = "0x6003A13")]
		[Address(RVA = "0x79D130", Offset = "0x79B730", VA = "0x18079D130")]
		public VectorVsZombie()
		{
			Dictionary<Vector2Int, ZombieType> dictionary = new Dictionary();
			this.recyclc = dictionary;
			base..ctor();
		}

		// Token: 0x04002B48 RID: 11080
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002B48")]
		private readonly Dictionary<Vector2Int, ZombieType> recyclc;
	}
}
