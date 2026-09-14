using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000524 RID: 1316
[Token(Token = "0x2000524")]
public class GarlicSniper : SniperPea
{
	// Token: 0x06001897 RID: 6295 RVA: 0x000853FC File Offset: 0x000835FC
	[Token(Token = "0x6001897")]
	[Address(RVA = "0x525180", Offset = "0x523780", VA = "0x180525180", Slot = "72")]
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

	// Token: 0x06001898 RID: 6296 RVA: 0x00085464 File Offset: 0x00083664
	[Token(Token = "0x6001898")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public GarlicSniper()
	{
	}
}
