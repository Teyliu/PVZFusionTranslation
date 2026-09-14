using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C6F RID: 3183
	[Token(Token = "0x2000C6F")]
	public class CherrySquash : BaseConfig
	{
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x00159420 File Offset: 0x00157620
		[Token(Token = "0x17000647")]
		public override string Role
		{
			[Token(Token = "0x60042A7")]
			[Address(RVA = "0x82F620", Offset = "0x82DC20", VA = "0x18082F620", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x00159434 File Offset: 0x00157634
		[Token(Token = "0x17000648")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60042A8")]
			[Address(RVA = "0x82F610", Offset = "0x82DC10", VA = "0x18082F610", Slot = "4")]
			get
			{
				return PlantType.CherrySquash;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060042A9 RID: 17065 RVA: 0x00159448 File Offset: 0x00157648
		[Token(Token = "0x17000649")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60042A9")]
			[Address(RVA = "0x82F4F0", Offset = "0x82DAF0", VA = "0x18082F4F0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1344L);
				upgradeBuff.targetType = (PlantType)((ulong)965L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x00159490 File Offset: 0x00157690
		[Token(Token = "0x60042AA")]
		[Address(RVA = "0x82EE90", Offset = "0x82D490", VA = "0x18082EE90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x001594B8 File Offset: 0x001576B8
		[Token(Token = "0x60042AB")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public CherrySquash()
		{
		}
	}
}
