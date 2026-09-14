using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C72 RID: 3186
	[Token(Token = "0x2000C72")]
	public class ThreePeater : BaseConfig
	{
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x00159620 File Offset: 0x00157820
		[Token(Token = "0x17000652")]
		public override string Role
		{
			[Token(Token = "0x60042B8")]
			[Address(RVA = "0x83BCF0", Offset = "0x83A2F0", VA = "0x18083BCF0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x00159634 File Offset: 0x00157834
		[Token(Token = "0x17000653")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60042B9")]
			[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "4")]
			get
			{
				return PlantType.ThreePeater;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x00159644 File Offset: 0x00157844
		[Token(Token = "0x17000654")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60042BA")]
			[Address(RVA = "0x83BB50", Offset = "0x83A150", VA = "0x18083BB50", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)14L);
				upgradeBuff.targetType = (PlantType)((ulong)1047L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)14L);
				upgradeBuff2.targetType = (PlantType)((ulong)1161L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x001596A8 File Offset: 0x001578A8
		[Token(Token = "0x60042BB")]
		[Address(RVA = "0x82E270", Offset = "0x82C870", VA = "0x18082E270", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x001596D0 File Offset: 0x001578D0
		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ThreePeater()
		{
		}
	}
}
