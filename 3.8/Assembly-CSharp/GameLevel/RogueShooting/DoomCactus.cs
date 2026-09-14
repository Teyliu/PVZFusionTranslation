using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C8C RID: 3212
	[Token(Token = "0x2000C8C")]
	public class DoomCactus : BaseConfig
	{
		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x0015ABBC File Offset: 0x00158DBC
		[Token(Token = "0x170006A7")]
		public override string Role
		{
			[Token(Token = "0x600434C")]
			[Address(RVA = "0x830400", Offset = "0x82EA00", VA = "0x180830400", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x0015ABD0 File Offset: 0x00158DD0
		[Token(Token = "0x170006A8")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600434D")]
			[Address(RVA = "0x8303F0", Offset = "0x82E9F0", VA = "0x1808303F0", Slot = "4")]
			get
			{
				return PlantType.DoomCactus;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x0015ABE4 File Offset: 0x00158DE4
		[Token(Token = "0x170006A9")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600434E")]
			[Address(RVA = "0x8302D0", Offset = "0x82E8D0", VA = "0x1808302D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1191L);
				upgradeBuff.targetType = (PlantType)((ulong)933L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x0015AC2C File Offset: 0x00158E2C
		[Token(Token = "0x600434F")]
		[Address(RVA = "0x82E940", Offset = "0x82CF40", VA = "0x18082E940", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x0015AC60 File Offset: 0x00158E60
		[Token(Token = "0x6004350")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public DoomCactus()
		{
		}
	}
}
