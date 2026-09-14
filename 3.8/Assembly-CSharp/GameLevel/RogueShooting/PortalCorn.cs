using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CAD RID: 3245
	[Token(Token = "0x2000CAD")]
	public class PortalCorn : BaseConfig
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x0015C1E0 File Offset: 0x0015A3E0
		[Token(Token = "0x1700071F")]
		public override string Role
		{
			[Token(Token = "0x6004408")]
			[Address(RVA = "0x835900", Offset = "0x833F00", VA = "0x180835900", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06004409 RID: 17417 RVA: 0x0015C1F4 File Offset: 0x0015A3F4
		[Token(Token = "0x17000720")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004409")]
			[Address(RVA = "0x8358F0", Offset = "0x833EF0", VA = "0x1808358F0", Slot = "4")]
			get
			{
				return PlantType.PortalCorn;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x0015C208 File Offset: 0x0015A408
		[Token(Token = "0x17000721")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600440A")]
			[Address(RVA = "0x8357D0", Offset = "0x833DD0", VA = "0x1808357D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1210L);
				upgradeBuff.targetType = (PlantType)((ulong)943L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x0015C250 File Offset: 0x0015A450
		[Token(Token = "0x600440B")]
		[Address(RVA = "0x82FD50", Offset = "0x82E350", VA = "0x18082FD50", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x0015C284 File Offset: 0x0015A484
		[Token(Token = "0x600440C")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public PortalCorn()
		{
		}
	}
}
