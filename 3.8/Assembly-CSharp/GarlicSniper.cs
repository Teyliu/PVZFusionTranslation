using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004FA RID: 1274
[Token(Token = "0x20004FA")]
public class GarlicSniper : SniperPea
{
	// Token: 0x060017D1 RID: 6097 RVA: 0x00081C3C File Offset: 0x0007FE3C
	[Token(Token = "0x60017D1")]
	[Address(RVA = "0x4C8F90", Offset = "0x4C7590", VA = "0x1804C8F90", Slot = "73")]
	protected override void AttackZombie(Zombie zombie, int damage, DamageType theDamageType = DamageType.Shieldless)
	{
		Transform shoot = this.shoot;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theZombieRow, num3 != 0UL, (float)num2);
		PlantType thePlantType = this.thePlantType;
		Transform axis = zombie.axis;
		bool flag = theDamageType == DamageType.MaxDamage;
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x00081CA4 File Offset: 0x0007FEA4
	[Token(Token = "0x60017D2")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public GarlicSniper()
	{
	}
}
