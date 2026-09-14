using System;
using Cpp2IlInjected;

// Token: 0x020001C1 RID: 449
[Token(Token = "0x20001C1")]
public class Bullet_steelPea_fire : Bullet_steelPea
{
	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060007AA RID: 1962 RVA: 0x00026A18 File Offset: 0x00024C18
	[Token(Token = "0x170000A8")]
	public override ParticleType ParticleType
	{
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x813850", Offset = "0x811E50", VA = "0x180813850", Slot = "7")]
		get
		{
			return ParticleType.SteelPeaSplat_fire;
		}
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00026A2C File Offset: 0x00024C2C
	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_steelPea_fire()
	{
	}
}
