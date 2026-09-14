using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C2A RID: 3114
	[Token(Token = "0x2000C2A")]
	public class WallNut : BaseConfig
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600411A RID: 16666 RVA: 0x00156774 File Offset: 0x00154974
		[Token(Token = "0x17000549")]
		public override string Role
		{
			[Token(Token = "0x600411A")]
			[Address(RVA = "0x846D40", Offset = "0x845340", VA = "0x180846D40", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x00156788 File Offset: 0x00154988
		[Token(Token = "0x1700054A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600411B")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "4")]
			get
			{
				return PlantType.WallNut;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x00156798 File Offset: 0x00154998
		[Token(Token = "0x1700054B")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600411C")]
			[Address(RVA = "0x846BA0", Offset = "0x8451A0", VA = "0x180846BA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)3L);
				upgradeBuff.targetType = (PlantType)((ulong)1013L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)3L);
				upgradeBuff2.targetType = (PlantType)((ulong)1027L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x001567F8 File Offset: 0x001549F8
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00156808 File Offset: 0x00154A08
		[Token(Token = "0x600411E")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public WallNut()
		{
		}
	}
}
