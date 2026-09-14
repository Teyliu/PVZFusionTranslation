using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC6 RID: 2758
	[Token(Token = "0x2000AC6")]
	public class JackboxStar : PlantData
	{
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x0012CEC8 File Offset: 0x0012B0C8
		[Token(Token = "0x1700032E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038A6")]
			[Address(RVA = "0x7D2A80", Offset = "0x7D1080", VA = "0x1807D2A80", Slot = "4")]
			get
			{
				return PlantType.JackboxStar;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060038A7 RID: 14503 RVA: 0x0012CEDC File Offset: 0x0012B0DC
		[Token(Token = "0x1700032F")]
		public override string Title
		{
			[Token(Token = "0x60038A7")]
			[Address(RVA = "0x7D2BB0", Offset = "0x7D11B0", VA = "0x1807D2BB0", Slot = "5")]
			get
			{
				return "冷月寒光";
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x0012CEF0 File Offset: 0x0012B0F0
		[Token(Token = "0x17000330")]
		public override string Description
		{
			[Token(Token = "0x60038A8")]
			[Address(RVA = "0x7D2A50", Offset = "0x7D1050", VA = "0x1807D2A50", Slot = "6")]
			get
			{
				return "消耗自身生命值和周围3x3植物血量生命值攻击敌人，击中敌人会回复自身生命值";
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x0012CF04 File Offset: 0x0012B104
		[Token(Token = "0x17000331")]
		public override int Cost
		{
			[Token(Token = "0x60038A9")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x0012CF14 File Offset: 0x0012B114
		[Token(Token = "0x17000332")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038AA")]
			[Address(RVA = "0x7D2A90", Offset = "0x7D1090", VA = "0x1807D2A90", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x0012CF50 File Offset: 0x0012B150
		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public JackboxStar()
		{
		}
	}
}
