using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UI;
using UnityEngine;

namespace GameLevel.Abyss
{
	// Token: 0x02000C4D RID: 3149
	[Token(Token = "0x2000C4D")]
	public class AbyssManager : Singleton<AbyssManager>
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x001581F0 File Offset: 0x001563F0
		[Token(Token = "0x17000553")]
		public static AbyssData Data
		{
			[Token(Token = "0x6004193")]
			[Address(RVA = "0x87B330", Offset = "0x879930", VA = "0x18087B330")]
			get
			{
				return GameAPP.config.abyssData;
			}
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x00158210 File Offset: 0x00156410
		[Token(Token = "0x6004194")]
		[Address(RVA = "0x87ACE0", Offset = "0x8792E0", VA = "0x18087ACE0")]
		public void StartNewAdventure()
		{
			GameConfig config = GameAPP.config;
			AbyssData abyssData = new AbyssData();
			config.abyssData = abyssData;
			this.UpdateZombieBuff();
			SaveInfo.Instance.SavePlayerData();
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x00158248 File Offset: 0x00156448
		[Token(Token = "0x6004195")]
		[Address(RVA = "0x87A250", Offset = "0x878850", VA = "0x18087A250")]
		public void OnBoardStart(Board board)
		{
			SeedLibrary.Instance.DeleteCards("NormalCards");
			SeedLibrary.Instance.DeleteCards("ColorCards");
			SeedLibrary instance = SeedLibrary.Instance;
			AbyssData abyssData = GameAPP.config.abyssData;
			SeedLibrary.Instance.ShowCards("abyssCards");
			board.theSun = (int)((ulong)50L);
			board.theMoney = (int)((ulong)0L);
			this.ApplyBuffEffect(board);
			int difficulty = GameAPP.config.difficulty;
			board.lockedDifficulty = difficulty;
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x001582C8 File Offset: 0x001564C8
		[Token(Token = "0x6004196")]
		[Address(RVA = "0x87A860", Offset = "0x878E60", VA = "0x18087A860")]
		private void OnCardCreate(CardUI card)
		{
			CardUI card2 = card;
			CardUI card3 = card;
			PlantDataManager.PlantData plantData;
			float cd = plantData.cd;
			card3.fullCD = cd;
			int cost = plantData.cost;
			card3.theSeedCost = cost;
			CardUI card4 = card;
			float fullCD = card4.fullCD;
			card4.CD = fullCD;
			List<ReinforceData> reinforceDatas = GameAPP.config.abyssData.reinforceDatas;
			Func<ReinforceData, bool> func = delegate(ReinforceData a)
			{
				PlantType thePlantType = card.thePlantType;
				return a.thePlantType == thePlantType;
			};
			if (Enumerable.FirstOrDefault<ReinforceData>(reinforceDatas, func) != 0)
			{
				CardUI card5 = card;
				uint num2;
				int num = card5.theSeedCost.MultiplyPercent((float)num2);
				card5.theSeedCost = num;
			}
			Action<Plant> action;
			card.plantAction = action;
			throw new NullReferenceException();
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x00158390 File Offset: 0x00156590
		[Token(Token = "0x6004197")]
		[Address(RVA = "0x87A4E0", Offset = "0x878AE0", VA = "0x18087A4E0")]
		public void OnBoardWin(Board board)
		{
			int num;
			do
			{
				BoardStatistics boardStatistics = board.boardStatistics;
				List<ZombieBuff> zombieBuffs = AbyssManager.Data.zombieBuffs;
				num = 0;
				bool flag;
				if (flag)
				{
					Dictionary<ZombieBuff, ValueTuple<string, int>> zombieBuffDescription = this.ZombieBuffDescription;
				}
			}
			while (num != 0);
			int num2 = 0;
			uint num3;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0050;
					}
					num3 += (uint)5;
				}
				num3 += (uint)3;
			}
			num3 += (uint)1;
			IL_0050:
			if (num3 > (uint)0)
			{
				while (num3 != (uint)0)
				{
				}
			}
			int arrivedLevel = GameAPP.config.abyssData.arrivedLevel;
			AbyssData abyssData = GameAPP.config.abyssData;
			uint num5;
			int num4 = Mathf.Max((int)num3, (int)num5);
			if (num2 < num4)
			{
				num2++;
			}
			SaveInfo.Instance.SavePlayerData();
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00158444 File Offset: 0x00156644
		[Token(Token = "0x6004198")]
		[Address(RVA = "0x87AAD0", Offset = "0x8790D0", VA = "0x18087AAD0")]
		public void ReinforcePlant(Plant plant)
		{
			List<ReinforceData> reinforceDatas = GameAPP.config.abyssData.reinforceDatas;
			Func<ReinforceData, bool> func = delegate(ReinforceData a)
			{
				PlantType thePlantType = plant.thePlantType;
				return a.thePlantType == thePlantType;
			};
			if (Enumerable.FirstOrDefault<ReinforceData>(reinforceDatas, func) != 0)
			{
				TravelMgr instance = TravelMgr.Instance;
				Plant plant2 = plant;
				PlantType plantType;
				float num;
				instance.data.SetDamage(plantType, num);
				float num2;
				plant.AddSpeed(num2);
				Plant plant3 = plant;
				int num3 = 0;
				float num4 = num * 0.15f;
				plant3.ModifyHealth((PlantHealthAdder)((uint)13), num4, num3 != 0);
			}
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x001584E0 File Offset: 0x001566E0
		[Token(Token = "0x6004199")]
		[Address(RVA = "0x879C60", Offset = "0x878260", VA = "0x180879C60")]
		private void CreateItem()
		{
			int i = GameAPP.theBoardLevel;
			Dictionary<Quality, int> dictionary = new Dictionary();
			int num = 0;
			uint num2;
			dictionary[num] = num2;
			Dictionary<Quality, int> dictionary2 = new Dictionary();
			int num3 = 0;
			uint num4;
			dictionary2[num3] = num4;
			Dictionary<Quality, int> dictionary3 = new Dictionary();
			int num5 = 0;
			uint num6;
			dictionary3[num5] = num6;
			Quality randomKeyByWeight = DictionaryExtensions.GetRandomKeyByWeight<Quality>(dictionary3);
			Quality quality = randomKeyByWeight;
			if (randomKeyByWeight != Quality.Default && randomKeyByWeight != Quality.Default && randomKeyByWeight != Quality.Default && randomKeyByWeight == Quality.silver)
			{
				while (i >= 20)
				{
				}
				if (i < 15)
				{
					if (i < 10)
					{
						Dictionary<Quality, int> dictionary4 = new Dictionary();
						int num7 = 0;
						uint num8;
						dictionary4[num7] = num8;
					}
					Dictionary<Quality, int> dictionary5 = new Dictionary();
					int num9 = 0;
					uint num10;
					dictionary5[num9] = num10;
				}
				Dictionary<Quality, int> dictionary6 = new Dictionary();
				int num11 = 0;
				uint num12;
				dictionary6[num11] = num12;
			}
			DroppedItem droppedItem = Resources.Load<DroppedItem>("UI/Abyss/SilverTicket");
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Board instance = Board.Instance;
			DroppedItem droppedItem2;
			Action<DroppedItem> onClick = droppedItem2.onClick;
			droppedItem2.landY = -1f;
			Action<DroppedItem> action;
			Delegate @delegate = Delegate.Combine(onClick, action);
			if (@delegate == 0)
			{
				droppedItem2.onClick = @delegate;
			}
			if (@delegate != 0)
			{
				droppedItem2.onClick = @delegate;
				if (@delegate != 0)
				{
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x00158610 File Offset: 0x00156810
		[Token(Token = "0x600419A")]
		[Address(RVA = "0x87ADC0", Offset = "0x8793C0", VA = "0x18087ADC0")]
		private void UpdateZombieBuff()
		{
			AbyssData abyssData = GameAPP.config.abyssData;
			ulong num;
			num += num;
			if (num > (ulong)0L)
			{
				List<ZombieBuff> list = Enumerable.ToList<ZombieBuff>(global::Core.Lawnf.GetEnumValues<ZombieBuff>());
				int num2 = 0;
				bool flag = list.Remove(num2);
				ListExtensions.Shuffle<ZombieBuff>(list);
				AbyssData data = AbyssManager.Data;
				List<ZombieBuff> list2 = Enumerable.ToList<ZombieBuff>(Enumerable.Take<ZombieBuff>(list, (int)num));
				data.zombieBuffs = list2;
			}
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x00158678 File Offset: 0x00156878
		[Token(Token = "0x600419B")]
		[Address(RVA = "0x879870", Offset = "0x877E70", VA = "0x180879870")]
		private void ApplyBuffEffect(Board board)
		{
			ulong num;
			do
			{
				List<ZombieBuff> zombieBuffs = GameAPP.config.abyssData.zombieBuffs;
				bool flag;
				if (flag)
				{
					while (18446744073709551615UL > (ulong)8L)
					{
					}
					BoardConfig config = board.config;
					float zombieHealthMultiplier = config.zombieHealthMultiplier;
					config.zombieHealthMultiplier = zombieHealthMultiplier;
					BoardConfig config2 = board.config;
					float zombieHealthMultiplier2 = config2.zombieHealthMultiplier;
					config2.zombieHealthMultiplier = zombieHealthMultiplier2;
					BoardConfig config3 = board.config;
					float zombieHealthMultiplier3 = config3.zombieHealthMultiplier;
					config3.zombieHealthMultiplier = zombieHealthMultiplier3;
					BoardConfig config4 = board.config;
					float zombieDamageMultiplier = config4.zombieDamageMultiplier;
					config4.zombieDamageMultiplier = zombieDamageMultiplier;
					BoardConfig config5 = board.config;
					float zombieDamageMultiplier2 = config5.zombieDamageMultiplier;
					config5.zombieDamageMultiplier = zombieDamageMultiplier2;
					BoardConfig config6 = board.config;
					float zombieDamageMultiplier3 = config6.zombieDamageMultiplier;
					config6.zombieDamageMultiplier = zombieDamageMultiplier3;
					BoardConfig config7 = board.config;
					float zombieSpeedMultiplier = config7.zombieSpeedMultiplier;
					config7.zombieSpeedMultiplier = zombieSpeedMultiplier;
					BoardConfig config8 = board.config;
					float zombieSpeedMultiplier2 = config8.zombieSpeedMultiplier;
					config8.zombieSpeedMultiplier = zombieSpeedMultiplier2;
					BoardConfig config9 = board.config;
					float zombieSpeedMultiplier3 = config9.zombieSpeedMultiplier;
					config9.zombieSpeedMultiplier = zombieSpeedMultiplier3;
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x00158808 File Offset: 0x00156A08
		[Token(Token = "0x600419C")]
		[Address(RVA = "0x87AF80", Offset = "0x879580", VA = "0x18087AF80")]
		public AbyssManager()
		{
			Dictionary<ZombieBuff, ValueTuple<string, int>> dictionary = new Dictionary();
			this.ZombieBuffDescription = dictionary;
			base..ctor();
		}

		// Token: 0x0400321D RID: 12829
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400321D")]
		[TupleElementNames(new string[] { "desciption", "points" })]
		public readonly Dictionary<ZombieBuff, ValueTuple<string, int>> ZombieBuffDescription;
	}
}
