using System;
using Cpp2IlInjected;

// Token: 0x020003A7 RID: 935
[Token(Token = "0x20003A7")]
public class HypnoSquash : Squash
{
	// Token: 0x0600112E RID: 4398 RVA: 0x00061E74 File Offset: 0x00060074
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x43D970", Offset = "0x43BF70", VA = "0x18043D970", Slot = "72")]
	protected override void ActionOnZombie(Zombie zombie)
	{
		int num = 0;
		zombie.SetMindControl(num);
		if (!zombie.isMindControlled)
		{
			int attackDamage = this.attackDamage;
			PlantType thePlantType = this.thePlantType;
			ulong num2;
			zombie.TakeDamage(attackDamage, this, (DamageType)((uint)11), thePlantType, num2 != 0UL);
		}
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00061EB4 File Offset: 0x000600B4
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public HypnoSquash()
	{
	}
}
