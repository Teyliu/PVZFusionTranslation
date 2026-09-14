using System;
using Cpp2IlInjected;

// Token: 0x020006E6 RID: 1766
[Token(Token = "0x20006E6")]
public class SuperPenguinZombie : PenguinZombie
{
	// Token: 0x060022E4 RID: 8932 RVA: 0x000B711C File Offset: 0x000B531C
	[Token(Token = "0x60022E4")]
	[Address(RVA = "0x57B5A0", Offset = "0x579BA0", VA = "0x18057B5A0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		SnowMap instance = SnowMap.Instance;
		int num = 0;
		if (instance != num)
		{
			this.anim.Play("skating");
			this.theStatus = (ZombieStatus)((ulong)43L);
			SnowMap.Instance.QuickSnow();
		}
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x000B716C File Offset: 0x000B536C
	[Token(Token = "0x60022E5")]
	[Address(RVA = "0x57B670", Offset = "0x579C70", VA = "0x18057B670")]
	public SuperPenguinZombie()
	{
	}
}
