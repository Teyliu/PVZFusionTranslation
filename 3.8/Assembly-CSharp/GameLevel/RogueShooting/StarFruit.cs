using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C8F RID: 3215
	[Token(Token = "0x2000C8F")]
	public class StarFruit : BaseConfig
	{
		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x0015ADCC File Offset: 0x00158FCC
		[Token(Token = "0x170006B2")]
		public override string Role
		{
			[Token(Token = "0x600435D")]
			[Address(RVA = "0x8395B0", Offset = "0x837BB0", VA = "0x1808395B0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x0015ADE0 File Offset: 0x00158FE0
		[Token(Token = "0x170006B3")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600435E")]
			[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "4")]
			get
			{
				return PlantType.StarFruit;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x0015ADF0 File Offset: 0x00158FF0
		[Token(Token = "0x170006B4")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600435F")]
			[Address(RVA = "0x839410", Offset = "0x837A10", VA = "0x180839410", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)23L);
				upgradeBuff.targetType = (PlantType)((ulong)1104L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)23L);
				upgradeBuff2.targetType = (PlantType)((ulong)249L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x0015AE54 File Offset: 0x00159054
		[Token(Token = "0x6004360")]
		[Address(RVA = "0x82E940", Offset = "0x82CF40", VA = "0x18082E940", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x0015AE88 File Offset: 0x00159088
		[Token(Token = "0x6004361")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public StarFruit()
		{
		}
	}
}
