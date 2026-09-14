using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C77 RID: 3191
	[Token(Token = "0x2000C77")]
	public class BigGatling : BaseConfig
	{
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x001599B0 File Offset: 0x00157BB0
		[Token(Token = "0x17000666")]
		public override string Role
		{
			[Token(Token = "0x60042D7")]
			[Address(RVA = "0x82E3E0", Offset = "0x82C9E0", VA = "0x18082E3E0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x001599C4 File Offset: 0x00157BC4
		[Token(Token = "0x17000667")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60042D8")]
			[Address(RVA = "0x82E3D0", Offset = "0x82C9D0", VA = "0x18082E3D0", Slot = "4")]
			get
			{
				return PlantType.BigGatling;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060042D9 RID: 17113 RVA: 0x001599D8 File Offset: 0x00157BD8
		[Token(Token = "0x17000668")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60042D9")]
			[Address(RVA = "0x82E2B0", Offset = "0x82C8B0", VA = "0x18082E2B0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1161L);
				upgradeBuff.targetType = (PlantType)((ulong)927L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x00159A20 File Offset: 0x00157C20
		[Token(Token = "0x60042DA")]
		[Address(RVA = "0x82E270", Offset = "0x82C870", VA = "0x18082E270", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x00159A48 File Offset: 0x00157C48
		[Token(Token = "0x60042DB")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public BigGatling()
		{
		}
	}
}
