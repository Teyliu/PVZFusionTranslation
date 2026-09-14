using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C2B RID: 3115
	[Token(Token = "0x2000C2B")]
	public class SuperChomper : BaseConfig
	{
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x0015681C File Offset: 0x00154A1C
		[Token(Token = "0x1700054C")]
		public override string Role
		{
			[Token(Token = "0x600411F")]
			[Address(RVA = "0x83A870", Offset = "0x838E70", VA = "0x18083A870", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x00156830 File Offset: 0x00154A30
		[Token(Token = "0x1700054D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004120")]
			[Address(RVA = "0x3A7750", Offset = "0x3A5D50", VA = "0x1803A7750", Slot = "4")]
			get
			{
				return PlantType.SuperChomper;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06004121 RID: 16673 RVA: 0x00156844 File Offset: 0x00154A44
		[Token(Token = "0x1700054E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004121")]
			[Address(RVA = "0x83A750", Offset = "0x838D50", VA = "0x18083A750", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1013L);
				upgradeBuff.targetType = (PlantType)((ulong)903L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x0015688C File Offset: 0x00154A8C
		[Token(Token = "0x6004122")]
		[Address(RVA = "0x83A700", Offset = "0x838D00", VA = "0x18083A700", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(1f);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x001568B0 File Offset: 0x00154AB0
		[Token(Token = "0x6004123")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SuperChomper()
		{
		}
	}
}
