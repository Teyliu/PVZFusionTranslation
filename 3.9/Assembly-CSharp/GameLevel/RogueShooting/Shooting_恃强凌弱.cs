using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000CA2")]
	public class Shooting_恃强凌弱 : BaseDebuff
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x0015D1D8 File Offset: 0x0015B3D8
		[Token(Token = "0x170005CB")]
		public override int Point
		{
			[Token(Token = "0x6004302")]
			[Address(RVA = "0x88CB90", Offset = "0x88B190", VA = "0x18088CB90", Slot = "21")]
			get
			{
				return 150;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x0015D1EC File Offset: 0x0015B3EC
		[Token(Token = "0x170005CC")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004303")]
			[Address(RVA = "0x89F200", Offset = "0x89D800", VA = "0x18089F200", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_恃强凌弱;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x0015D200 File Offset: 0x0015B400
		[Token(Token = "0x170005CD")]
		public override string Description
		{
			[Token(Token = "0x6004304")]
			[Address(RVA = "0x89F210", Offset = "0x89D810", VA = "0x18089F210", Slot = "13")]
			get
			{
				return "恃强凌弱：场上植物数量为0/1/2/3/4/5/6及以上时，僵尸受到75%/80%/85%/90%/95%/100%/105%伤害";
			}
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x0015D214 File Offset: 0x0015B414
		[Token(Token = "0x6004305")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_恃强凌弱()
		{
		}
	}
}
