using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x2000CD0")]
	[Serializable]
	public class RogueShootingData
	{
		// Token: 0x060044BA RID: 17594 RVA: 0x0015D2E4 File Offset: 0x0015B4E4
		[Token(Token = "0x60044BA")]
		[Address(RVA = "0x835CC0", Offset = "0x8342C0", VA = "0x180835CC0")]
		public void OnBoardWin(ShootingManager manager)
		{
			ulong num2;
			do
			{
				int num = 0;
				List<PlantType> yourPlants = manager.YourPlants;
				bool flag;
				if (flag)
				{
					List<DataRecord<PlantType>> list = this.plant;
					this.Record<PlantType>(list, (PlantType)num);
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x0015D320 File Offset: 0x0015B520
		[Token(Token = "0x60044BB")]
		[Address(RVA = "0xA05EB0", Offset = "0xA044B0", VA = "0x180A05EB0")]
		public int GetValue<T>(List A_1, T element)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			base..ctor();
			throw new NullReferenceException();
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x0015D344 File Offset: 0x0015B544
		[Token(Token = "0x60044BC")]
		[Address(RVA = "0x835C10", Offset = "0x834210", VA = "0x180835C10")]
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

		// Token: 0x060044BD RID: 17597 RVA: 0x0015D378 File Offset: 0x0015B578
		[Token(Token = "0x60044BD")]
		[Address(RVA = "0x835E60", Offset = "0x834460", VA = "0x180835E60")]
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

		// Token: 0x060044BE RID: 17598 RVA: 0x0015D3AC File Offset: 0x0015B5AC
		[Token(Token = "0x60044BE")]
		[Address(RVA = "0xA06240", Offset = "0xA04840", VA = "0x180A06240")]
		private void Record<T>(List cpp2il__autoParamName__idx_0, T element)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			base..ctor();
			List<DataRecord<int>> list = this.stageWins;
			!0 !;
			if (! == 0)
			{
				int size = cpp2il__autoParamName__idx_0._size;
				return;
			}
			throw new NullReferenceException();
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x0015D3EC File Offset: 0x0015B5EC
		[Token(Token = "0x60044BF")]
		[Address(RVA = "0x835F10", Offset = "0x834510", VA = "0x180835F10")]
		public RogueShootingData()
		{
			List<DataRecord<PlantType>> list = new List();
			this.plant = list;
			List<DataRecord<int>> list2 = new List();
			this.difficultyWin = list2;
			List<DataRecord<int>> list3 = new List();
			this.stageWins = list3;
			base..ctor();
		}

		// Token: 0x04003147 RID: 12615
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003147")]
		public int victoryTimes;

		// Token: 0x04003148 RID: 12616
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003148")]
		public List<DataRecord<PlantType>> plant;

		// Token: 0x04003149 RID: 12617
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003149")]
		public List<DataRecord<int>> difficultyWin;

		// Token: 0x0400314A RID: 12618
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400314A")]
		public List<DataRecord<int>> stageWins;

		// Token: 0x0400314B RID: 12619
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400314B")]
		public int maxStage;
	}
}
