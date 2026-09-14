using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C13 RID: 3091
	[Token(Token = "0x2000C13")]
	public class CherryGatling : BaseConfig
	{
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06004087 RID: 16519 RVA: 0x001557EC File Offset: 0x001539EC
		[Token(Token = "0x170004EB")]
		public override string Role
		{
			[Token(Token = "0x6004087")]
			[Address(RVA = "0x82F4C0", Offset = "0x82DAC0", VA = "0x18082F4C0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x00155800 File Offset: 0x00153A00
		[Token(Token = "0x170004EC")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004088")]
			[Address(RVA = "0x3A6C10", Offset = "0x3A5210", VA = "0x1803A6C10", Slot = "4")]
			get
			{
				return PlantType.CherryGatling;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06004089 RID: 16521 RVA: 0x00155814 File Offset: 0x00153A14
		[Token(Token = "0x170004ED")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004089")]
			[Address(RVA = "0x82F3A0", Offset = "0x82D9A0", VA = "0x18082F3A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1017L);
				upgradeBuff.targetType = (PlantType)((ulong)901L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x0015585C File Offset: 0x00153A5C
		[Token(Token = "0x600408A")]
		[Address(RVA = "0x82E940", Offset = "0x82CF40", VA = "0x18082E940", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00155890 File Offset: 0x00153A90
		[Token(Token = "0x600408B")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public CherryGatling()
		{
		}
	}
}
