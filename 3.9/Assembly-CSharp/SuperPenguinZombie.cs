using System;
using Cpp2IlInjected;

// Token: 0x0200071E RID: 1822
[Token(Token = "0x200071E")]
public class SuperPenguinZombie : PenguinZombie
{
	// Token: 0x06002400 RID: 9216 RVA: 0x000BBF64 File Offset: 0x000BA164
	[Token(Token = "0x6002400")]
	[Address(RVA = "0x5F5B80", Offset = "0x5F4180", VA = "0x1805F5B80", Slot = "16")]
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

	// Token: 0x06002401 RID: 9217 RVA: 0x000BBFB4 File Offset: 0x000BA1B4
	[Token(Token = "0x6002401")]
	[Address(RVA = "0x5F5C50", Offset = "0x5F4250", VA = "0x1805F5C50")]
	public SuperPenguinZombie()
	{
	}
}
