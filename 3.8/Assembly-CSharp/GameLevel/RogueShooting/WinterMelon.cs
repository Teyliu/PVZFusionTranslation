using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA9 RID: 3241
	[Token(Token = "0x2000CA9")]
	public class WinterMelon : BaseConfig
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x0015BF44 File Offset: 0x0015A144
		[Token(Token = "0x17000711")]
		public override string Role
		{
			[Token(Token = "0x60043F2")]
			[Address(RVA = "0x846EA0", Offset = "0x8454A0", VA = "0x180846EA0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x0015BF58 File Offset: 0x0015A158
		[Token(Token = "0x17000712")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043F3")]
			[Address(RVA = "0x846E90", Offset = "0x845490", VA = "0x180846E90", Slot = "4")]
			get
			{
				return PlantType.WinterMelon;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x0015BF6C File Offset: 0x0015A16C
		[Token(Token = "0x17000713")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043F4")]
			[Address(RVA = "0x846D70", Offset = "0x845370", VA = "0x180846D70", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1116L);
				upgradeBuff.targetType = (PlantType)((ulong)957L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x0015BFB4 File Offset: 0x0015A1B4
		[Token(Token = "0x60043F5")]
		[Address(RVA = "0x82E940", Offset = "0x82CF40", VA = "0x18082E940", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x0015BFE8 File Offset: 0x0015A1E8
		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public WinterMelon()
		{
		}
	}
}
