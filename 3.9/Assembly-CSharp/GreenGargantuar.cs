using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006AE RID: 1710
[Token(Token = "0x20006AE")]
public class GreenGargantuar : Gargantuar
{
	// Token: 0x060020B3 RID: 8371 RVA: 0x000ACEF4 File Offset: 0x000AB0F4
	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x5AEDB0", Offset = "0x5AD3B0", VA = "0x1805AEDB0", Slot = "79")]
	protected override void CrashPlant(Plant plant, bool crash)
	{
		if (!crash)
		{
			plant.FlashOnce();
		}
		int num = 0;
		bool flag = plant == num;
		if (flag || plant.isCrashed != flag)
		{
			Transform axis = plant.axis;
			CreateZombie instance = CreateZombie.Instance;
			Transform axis2 = plant.axis;
			ParticleManager instance2 = ParticleManager.Instance;
			int num2 = 0;
			int num3 = 0;
			int thePlantRow = plant.thePlantRow;
			ulong num4;
			Particle particle = instance2.SetParticle((ParticleType)((uint)11), num2, thePlantRow, num4 != 0UL, (float)num3);
		}
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x000ACF68 File Offset: 0x000AB168
	[Token(Token = "0x60020B4")]
	[Address(RVA = "0x5AEFD0", Offset = "0x5AD5D0", VA = "0x1805AEFD0")]
	public GreenGargantuar()
	{
	}
}
