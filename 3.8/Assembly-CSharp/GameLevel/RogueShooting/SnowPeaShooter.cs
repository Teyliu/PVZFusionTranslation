using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C23 RID: 3107
	[Token(Token = "0x2000C23")]
	public class SnowPeaShooter : BaseConfig
	{
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060040EC RID: 16620 RVA: 0x0015632C File Offset: 0x0015452C
		[Token(Token = "0x17000530")]
		public override string Role
		{
			[Token(Token = "0x60040EC")]
			[Address(RVA = "0x838F50", Offset = "0x837550", VA = "0x180838F50", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x00156340 File Offset: 0x00154540
		[Token(Token = "0x17000531")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60040ED")]
			[Address(RVA = "0x7785A0", Offset = "0x776BA0", VA = "0x1807785A0", Slot = "4")]
			get
			{
				return PlantType.SnowPeaShooter;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060040EE RID: 16622 RVA: 0x00156354 File Offset: 0x00154554
		[Token(Token = "0x17000532")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60040EE")]
			[Address(RVA = "0x838E30", Offset = "0x837430", VA = "0x180838E30", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1034L);
				upgradeBuff.targetType = (PlantType)((ulong)5001L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x0015639C File Offset: 0x0015459C
		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x838DE0", Offset = "0x8373E0", VA = "0x180838DE0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 39f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x001563D0 File Offset: 0x001545D0
		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SnowPeaShooter()
		{
		}
	}
}
