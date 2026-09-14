using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C65 RID: 3173
	[Token(Token = "0x2000C65")]
	public class ScaredyDoom : BaseConfig
	{
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x00158DBC File Offset: 0x00156FBC
		[Token(Token = "0x17000622")]
		public override string Role
		{
			[Token(Token = "0x600426D")]
			[Address(RVA = "0x838440", Offset = "0x836A40", VA = "0x180838440", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x00158DD0 File Offset: 0x00156FD0
		[Token(Token = "0x17000623")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600426E")]
			[Address(RVA = "0x838430", Offset = "0x836A30", VA = "0x180838430", Slot = "4")]
			get
			{
				return PlantType.ScaredyDoom;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x00158DE4 File Offset: 0x00156FE4
		[Token(Token = "0x17000624")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600426F")]
			[Address(RVA = "0x838310", Offset = "0x836910", VA = "0x180838310", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1042L);
				upgradeBuff.targetType = (PlantType)((ulong)972L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00158E2C File Offset: 0x0015702C
		[Token(Token = "0x6004270")]
		[Address(RVA = "0x8382D0", Offset = "0x8368D0", VA = "0x1808382D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x00158E54 File Offset: 0x00157054
		[Token(Token = "0x6004271")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ScaredyDoom()
		{
		}
	}
}
