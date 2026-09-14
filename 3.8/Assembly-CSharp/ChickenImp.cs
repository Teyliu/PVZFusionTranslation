using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000640 RID: 1600
[Token(Token = "0x2000640")]
public class ChickenImp : Zombie
{
	// Token: 0x06001E66 RID: 7782 RVA: 0x000A28D8 File Offset: 0x000A0AD8
	[Token(Token = "0x6001E66")]
	[Address(RVA = "0x533DF0", Offset = "0x5323F0", VA = "0x180533DF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06001E67 RID: 7783 RVA: 0x000A28E8 File Offset: 0x000A0AE8
	[Token(Token = "0x6001E67")]
	[Address(RVA = "0x533270", Offset = "0x531870", VA = "0x180533270", Slot = "27")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x000A2908 File Offset: 0x000A0B08
	[Token(Token = "0x6001E68")]
	[Address(RVA = "0x5394C0", Offset = "0x537AC0", VA = "0x1805394C0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		Transform axis3 = this.axis;
		ParticleManager instance3 = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance3.SetParticle((ParticleType)((uint)11), num, theZombieRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x06001E69 RID: 7785 RVA: 0x000A296C File Offset: 0x000A0B6C
	[Token(Token = "0x6001E69")]
	[Address(RVA = "0x539680", Offset = "0x537C80", VA = "0x180539680")]
	public ChickenImp()
	{
	}
}
