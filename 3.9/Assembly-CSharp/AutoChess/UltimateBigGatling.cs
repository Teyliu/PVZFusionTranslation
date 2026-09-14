using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD4 RID: 2772
	[Token(Token = "0x2000AD4")]
	public class UltimateBigGatling : PlantData
	{
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x0012D770 File Offset: 0x0012B970
		[Token(Token = "0x17000374")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038FA")]
			[Address(RVA = "0x7E7CD0", Offset = "0x7E62D0", VA = "0x1807E7CD0", Slot = "4")]
			get
			{
				return PlantType.UltimateBigGatling;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x0012D784 File Offset: 0x0012B984
		[Token(Token = "0x17000375")]
		public override string Title
		{
			[Token(Token = "0x60038FB")]
			[Address(RVA = "0x7E7E00", Offset = "0x7E6400", VA = "0x1807E7E00", Slot = "5")]
			get
			{
				return "荒芜流淌";
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x0012D798 File Offset: 0x0012B998
		[Token(Token = "0x17000376")]
		public override string Description
		{
			[Token(Token = "0x60038FC")]
			[Address(RVA = "0x7E7CA0", Offset = "0x7E62A0", VA = "0x1807E7CA0", Slot = "6")]
			get
			{
				return "大招回复的生命值提高，普通攻击获得更多能量，造成更高的伤害";
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x0012D7AC File Offset: 0x0012B9AC
		[Token(Token = "0x17000377")]
		public override int Cost
		{
			[Token(Token = "0x60038FD")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060038FE RID: 14590 RVA: 0x0012D7BC File Offset: 0x0012B9BC
		[Token(Token = "0x17000378")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038FE")]
			[Address(RVA = "0x7E7CE0", Offset = "0x7E62E0", VA = "0x1807E7CE0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0012D7F8 File Offset: 0x0012B9F8
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateBigGatling()
		{
		}
	}
}
