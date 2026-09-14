using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC2 RID: 2754
	[Token(Token = "0x2000AC2")]
	public class IceScaredy : PlantData
	{
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x0012CC58 File Offset: 0x0012AE58
		[Token(Token = "0x1700031A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600388E")]
			[Address(RVA = "0x7D28F0", Offset = "0x7D0EF0", VA = "0x1807D28F0", Slot = "4")]
			get
			{
				return PlantType.IceScaredyShroom;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x0012CC6C File Offset: 0x0012AE6C
		[Token(Token = "0x1700031B")]
		public override string Title
		{
			[Token(Token = "0x600388F")]
			[Address(RVA = "0x7D2A20", Offset = "0x7D1020", VA = "0x1807D2A20", Slot = "5")]
			get
			{
				return "石破天惊";
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x0012CC80 File Offset: 0x0012AE80
		[Token(Token = "0x1700031C")]
		public override string Description
		{
			[Token(Token = "0x6003890")]
			[Address(RVA = "0x7D28C0", Offset = "0x7D0EC0", VA = "0x1807D28C0", Slot = "6")]
			get
			{
				return "攻击附带1级寒冷，敌人被冻结后受到的伤害提高";
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x0012CC94 File Offset: 0x0012AE94
		[Token(Token = "0x1700031D")]
		public override int Cost
		{
			[Token(Token = "0x6003891")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x0012CCA4 File Offset: 0x0012AEA4
		[Token(Token = "0x1700031E")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003892")]
			[Address(RVA = "0x7D2900", Offset = "0x7D0F00", VA = "0x1807D2900", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0012CCE0 File Offset: 0x0012AEE0
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public IceScaredy()
		{
		}
	}
}
