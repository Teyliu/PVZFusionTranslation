using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C7D RID: 3197
	[Token(Token = "0x2000C7D")]
	public class SpikeRock : BaseConfig
	{
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x00159E84 File Offset: 0x00158084
		[Token(Token = "0x17000681")]
		public override string Role
		{
			[Token(Token = "0x60042FF")]
			[Address(RVA = "0x8390B0", Offset = "0x8376B0", VA = "0x1808390B0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x00159E98 File Offset: 0x00158098
		[Token(Token = "0x17000682")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004300")]
			[Address(RVA = "0x8390A0", Offset = "0x8376A0", VA = "0x1808390A0", Slot = "4")]
			get
			{
				return PlantType.SpikeRock;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06004301 RID: 17153 RVA: 0x00159EAC File Offset: 0x001580AC
		[Token(Token = "0x17000683")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004301")]
			[Address(RVA = "0x838F80", Offset = "0x837580", VA = "0x180838F80", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1060L);
				upgradeBuff.targetType = (PlantType)((ulong)906L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00159EF4 File Offset: 0x001580F4
		[Token(Token = "0x6004302")]
		[Address(RVA = "0x82E720", Offset = "0x82CD20", VA = "0x18082E720", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x00159F28 File Offset: 0x00158128
		[Token(Token = "0x6004303")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SpikeRock()
		{
		}
	}
}
