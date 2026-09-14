using System;
using Cpp2IlInjected;

// Token: 0x020001B8 RID: 440
[Token(Token = "0x20001B8")]
public class Bullet_steelPea_fire : Bullet_steelPea
{
	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000798 RID: 1944 RVA: 0x00026FCC File Offset: 0x000251CC
	[Token(Token = "0x1700006B")]
	public override ParticleType ParticleType
	{
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x7E5FD0", Offset = "0x7E45D0", VA = "0x1807E5FD0", Slot = "7")]
		get
		{
			return ParticleType.SteelPeaSplat_fire;
		}
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00026FE0 File Offset: 0x000251E0
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_steelPea_fire()
	{
	}
}
