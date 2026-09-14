using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C5E RID: 3166
	[Token(Token = "0x2000C5E")]
	public class ScaredyShroom : BaseConfig
	{
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06004246 RID: 16966 RVA: 0x001588E0 File Offset: 0x00156AE0
		[Token(Token = "0x17000609")]
		public override string Role
		{
			[Token(Token = "0x6004246")]
			[Address(RVA = "0x838610", Offset = "0x836C10", VA = "0x180838610", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x001588F4 File Offset: 0x00156AF4
		[Token(Token = "0x1700060A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004247")]
			[Address(RVA = "0x3AC960", Offset = "0x3AAF60", VA = "0x1803AC960", Slot = "4")]
			get
			{
				return PlantType.ScaredyShroom;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x00158904 File Offset: 0x00156B04
		[Token(Token = "0x1700060B")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004248")]
			[Address(RVA = "0x838470", Offset = "0x836A70", VA = "0x180838470", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)9L);
				upgradeBuff.targetType = (PlantType)((ulong)1026L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)9L);
				upgradeBuff2.targetType = (PlantType)((ulong)1042L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00158968 File Offset: 0x00156B68
		[Token(Token = "0x6004249")]
		[Address(RVA = "0x82E720", Offset = "0x82CD20", VA = "0x18082E720", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x0015899C File Offset: 0x00156B9C
		[Token(Token = "0x600424A")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ScaredyShroom()
		{
		}
	}
}
