using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000676 RID: 1654
[Token(Token = "0x2000676")]
public class ChickenImp : Zombie
{
	// Token: 0x06001F68 RID: 8040 RVA: 0x000A7024 File Offset: 0x000A5224
	[Token(Token = "0x6001F68")]
	[Address(RVA = "0x58AAD0", Offset = "0x5890D0", VA = "0x18058AAD0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x000A7034 File Offset: 0x000A5234
	[Token(Token = "0x6001F69")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x000A7054 File Offset: 0x000A5254
	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0x59BA90", Offset = "0x59A090", VA = "0x18059BA90", Slot = "29")]
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

	// Token: 0x06001F6B RID: 8043 RVA: 0x000A70B8 File Offset: 0x000A52B8
	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x59BC50", Offset = "0x59A250", VA = "0x18059BC50")]
	public ChickenImp()
	{
	}
}
