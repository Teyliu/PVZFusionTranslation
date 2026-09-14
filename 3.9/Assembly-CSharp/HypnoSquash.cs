using System;
using Cpp2IlInjected;

// Token: 0x020003BB RID: 955
[Token(Token = "0x20003BB")]
public class HypnoSquash : Squash
{
	// Token: 0x0600118A RID: 4490 RVA: 0x000634D0 File Offset: 0x000616D0
	[Token(Token = "0x600118A")]
	[Address(RVA = "0x4911D0", Offset = "0x48F7D0", VA = "0x1804911D0", Slot = "71")]
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

	// Token: 0x0600118B RID: 4491 RVA: 0x00063510 File Offset: 0x00061710
	[Token(Token = "0x600118B")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public HypnoSquash()
	{
	}
}
