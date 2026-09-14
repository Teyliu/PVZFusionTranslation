using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C38 RID: 3128
	[Token(Token = "0x2000C38")]
	public class CherryChomper : BaseConfig
	{
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x001570CC File Offset: 0x001552CC
		[Token(Token = "0x1700057E")]
		public override string Role
		{
			[Token(Token = "0x600416B")]
			[Address(RVA = "0x82F370", Offset = "0x82D970", VA = "0x18082F370", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x001570E0 File Offset: 0x001552E0
		[Token(Token = "0x1700057F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600416C")]
			[Address(RVA = "0x3A7670", Offset = "0x3A5C70", VA = "0x1803A7670", Slot = "4")]
			get
			{
				return PlantType.CherryChomper;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x001570F4 File Offset: 0x001552F4
		[Token(Token = "0x17000580")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600416D")]
			[Address(RVA = "0x82F250", Offset = "0x82D850", VA = "0x18082F250", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1016L);
				upgradeBuff.targetType = (PlantType)((ulong)1192L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x0015713C File Offset: 0x0015533C
		[Token(Token = "0x600416E")]
		[Address(RVA = "0x82F1B0", Offset = "0x82D7B0", VA = "0x18082F1B0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x00157160 File Offset: 0x00155360
		[Token(Token = "0x600416F")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public CherryChomper()
		{
		}
	}
}
