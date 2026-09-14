using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA7 RID: 3239
	[Token(Token = "0x2000CA7")]
	public class Shooting_无理投资 : BaseDebuff
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06004315 RID: 17173 RVA: 0x0015D3AC File Offset: 0x0015B5AC
		[Token(Token = "0x170005D7")]
		public override int Point
		{
			[Token(Token = "0x6004315")]
			[Address(RVA = "0x88CDD0", Offset = "0x88B3D0", VA = "0x18088CDD0", Slot = "21")]
			get
			{
				return 250;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x0015D3C0 File Offset: 0x0015B5C0
		[Token(Token = "0x170005D8")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004316")]
			[Address(RVA = "0x89F680", Offset = "0x89DC80", VA = "0x18089F680", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_无理投资;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06004317 RID: 17175 RVA: 0x0015D3D4 File Offset: 0x0015B5D4
		[Token(Token = "0x170005D9")]
		public override string Description
		{
			[Token(Token = "0x6004317")]
			[Address(RVA = "0x89F690", Offset = "0x89DC90", VA = "0x18089F690", Slot = "13")]
			get
			{
				return "无理投资：刷新词条时降低25幸运";
			}
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x0015D3E8 File Offset: 0x0015B5E8
		[Token(Token = "0x6004318")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_无理投资()
		{
		}
	}
}
