using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C40 RID: 3136
	[Token(Token = "0x2000C40")]
	public class SmallPuff : BaseConfig
	{
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x00157634 File Offset: 0x00155834
		[Token(Token = "0x1700059F")]
		public override string Role
		{
			[Token(Token = "0x600419C")]
			[Address(RVA = "0x838A60", Offset = "0x837060", VA = "0x180838A60", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x00157648 File Offset: 0x00155848
		[Token(Token = "0x170005A0")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600419D")]
			[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "4")]
			get
			{
				return PlantType.SmallPuff;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600419E RID: 16798 RVA: 0x00157658 File Offset: 0x00155858
		[Token(Token = "0x170005A1")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600419E")]
			[Address(RVA = "0x8388C0", Offset = "0x836EC0", VA = "0x1808388C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)6L);
				upgradeBuff.targetType = (PlantType)((ulong)1035L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)6L);
				upgradeBuff2.targetType = (PlantType)((ulong)1152L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x001576B8 File Offset: 0x001558B8
		[Token(Token = "0x600419F")]
		[Address(RVA = "0x82FD50", Offset = "0x82E350", VA = "0x18082FD50", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x001576EC File Offset: 0x001558EC
		[Token(Token = "0x60041A0")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SmallPuff()
		{
		}
	}
}
