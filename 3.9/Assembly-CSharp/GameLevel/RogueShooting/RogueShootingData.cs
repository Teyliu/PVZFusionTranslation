using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DB5 RID: 3509
	[Token(Token = "0x2000DB5")]
	[Serializable]
	public class RogueShootingData
	{
		// Token: 0x06004907 RID: 18695 RVA: 0x0016AE9C File Offset: 0x0016909C
		[Token(Token = "0x6004907")]
		[Address(RVA = "0x8B3040", Offset = "0x8B1640", VA = "0x1808B3040")]
		public void OnBoardWin(ShootingManager manager)
		{
			int num2;
			do
			{
				int num = 0;
				List<TravelDebuff> list = this.randomDebuffs;
				num2 = 0;
				list._size = num2;
				List<PlantType> yourPlants = manager.YourPlants;
				bool flag;
				if (flag)
				{
					List<DataRecord<PlantType>> list2 = this.plant;
					this.Record<PlantType>(list2, (PlantType)num);
				}
			}
			while (num2 != 0);
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x0016AEE8 File Offset: 0x001690E8
		[Token(Token = "0x6004908")]
		[Address(RVA = "0xAB8AA0", Offset = "0xAB70A0", VA = "0x180AB8AA0")]
		public int GetValue<T>(List A_1, T element)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			base..ctor();
			List<DataRecord<int>> list = this.stageWins;
			throw new NullReferenceException();
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x0016AF14 File Offset: 0x00169114
		[Token(Token = "0x6004909")]
		[Address(RVA = "0x8B2D60", Offset = "0x8B1360", VA = "0x1808B2D60")]
		public string DifficultyDescription(int difficulty)
		{
			List<DataRecord<int>> list = this.difficultyWin;
			int value = this.GetValue<int>(list, difficulty);
			if (value != 0)
			{
				return string.Format("该难度已经通关了{0}次", value);
			}
			return "该难度下还没有通关过";
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x0016AF48 File Offset: 0x00169148
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x8B3200", Offset = "0x8B1800", VA = "0x1808B3200")]
		public string StageDescription(int difficulty)
		{
			List<DataRecord<int>> list = this.stageWins;
			int value = this.GetValue<int>(list, difficulty);
			if (value != 0)
			{
				return string.Format("该难度已经通关了{0}次", value);
			}
			return "该难度下还没有通关过";
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x0016AF7C File Offset: 0x0016917C
		[Token(Token = "0x600490B")]
		[Address(RVA = "0x8B2E10", Offset = "0x8B1410", VA = "0x1808B2E10")]
		public List<TravelDebuff> GetRandomZombieBuffs()
		{
			List<TravelDebuff> list = this.randomDebuffs;
			TravelDebuff[] enumValues = global::Core.Lawnf.GetEnumValues<TravelDebuff>();
			Func<TravelDebuff, bool> <>9__10_ = RogueShootingData.<>c.<>9__10_0;
			if (<>9__10_ == 0)
			{
				RogueShootingData.<>c.<>9__10_0 = (TravelDebuff a) => a >= TravelDebuff.Shooting_丢失幸运;
			}
			List<TravelDebuff> list2 = Enumerable.ToList<TravelDebuff>(Enumerable.Where<TravelDebuff>(enumValues, <>9__10_));
			ListExtensions.Shuffle<TravelDebuff>(list2);
			uint num;
			List<TravelDebuff> list3 = Enumerable.ToList<TravelDebuff>(Enumerable.Take<TravelDebuff>(list2, (int)num));
			this.randomDebuffs = list3;
			return this.randomDebuffs;
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x0016AFF8 File Offset: 0x001691F8
		[Token(Token = "0x600490C")]
		[Address(RVA = "0xAB8E30", Offset = "0xAB7430", VA = "0x180AB8E30")]
		private void Record<T>(List cpp2il__autoParamName__idx_0, T element)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			base..ctor();
			List<DataRecord<int>> list = this.stageWins;
			if (list == 0)
			{
				list._items = list;
				int size = cpp2il__autoParamName__idx_0._size;
				object syncRoot = list._syncRoot;
				return;
			}
			throw new NullReferenceException();
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x0016B04C File Offset: 0x0016924C
		[Token(Token = "0x600490D")]
		[Address(RVA = "0x8B32B0", Offset = "0x8B18B0", VA = "0x1808B32B0")]
		public RogueShootingData()
		{
			List<DataRecord<PlantType>> list = new List();
			this.plant = list;
			List<DataRecord<int>> list2 = new List();
			this.difficultyWin = list2;
			List<DataRecord<int>> list3 = new List();
			this.stageWins = list3;
			List<TravelDebuff> list4 = new List();
			this.randomDebuffs = list4;
			base..ctor();
		}

		// Token: 0x040033D8 RID: 13272
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40033D8")]
		public int victoryTimes;

		// Token: 0x040033D9 RID: 13273
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40033D9")]
		public List<DataRecord<PlantType>> plant;

		// Token: 0x040033DA RID: 13274
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40033DA")]
		public List<DataRecord<int>> difficultyWin;

		// Token: 0x040033DB RID: 13275
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40033DB")]
		public List<DataRecord<int>> stageWins;

		// Token: 0x040033DC RID: 13276
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40033DC")]
		public List<TravelDebuff> randomDebuffs;

		// Token: 0x040033DD RID: 13277
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40033DD")]
		public int maxStage;
	}
}
