using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C57 RID: 3159
	[Token(Token = "0x2000C57")]
	public class HypnoShroom : BaseConfig
	{
		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06004223 RID: 16931 RVA: 0x00158528 File Offset: 0x00156728
		[Token(Token = "0x170005F6")]
		public override string Role
		{
			[Token(Token = "0x6004223")]
			[Address(RVA = "0x832A40", Offset = "0x831040", VA = "0x180832A40", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x0015853C File Offset: 0x0015673C
		[Token(Token = "0x170005F7")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004224")]
			[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "4")]
			get
			{
				return PlantType.HypnoShroom;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x0015854C File Offset: 0x0015674C
		[Token(Token = "0x170005F8")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004225")]
			[Address(RVA = "0x832920", Offset = "0x830F20", VA = "0x180832920", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)8L);
				upgradeBuff.targetType = (PlantType)((ulong)1147L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x00158590 File Offset: 0x00156790
		[Token(Token = "0x6004226")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x001585A0 File Offset: 0x001567A0
		[Token(Token = "0x6004227")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public HypnoShroom()
		{
		}
	}
}
