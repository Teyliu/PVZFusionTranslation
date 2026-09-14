using System;
using Cpp2IlInjected;

// Token: 0x020004F0 RID: 1264
[Token(Token = "0x20004F0")]
public class FireSniper : SniperPea
{
	// Token: 0x060017B3 RID: 6067 RVA: 0x0008162C File Offset: 0x0007F82C
	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x4C83C0", Offset = "0x4C69C0", VA = "0x1804C83C0", Slot = "73")]
	protected override void AttackZombie(Zombie zombie, int damage, DamageType theDamageType = DamageType.Shieldless)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(damage, this, theDamageType, thePlantType, num != 0UL);
		zombie.SetJalaed();
		int num2 = 0;
		zombie.JalaedExplode(true, 100, num2 != 0);
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00081664 File Offset: 0x0007F864
	[Token(Token = "0x60017B4")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public FireSniper()
	{
	}
}
