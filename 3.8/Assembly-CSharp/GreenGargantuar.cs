using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000678 RID: 1656
[Token(Token = "0x2000678")]
public class GreenGargantuar : Gargantuar
{
	// Token: 0x06001FB1 RID: 8113 RVA: 0x000A8630 File Offset: 0x000A6830
	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x54C670", Offset = "0x54AC70", VA = "0x18054C670", Slot = "77")]
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

	// Token: 0x06001FB2 RID: 8114 RVA: 0x000A86A4 File Offset: 0x000A68A4
	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x54C890", Offset = "0x54AE90", VA = "0x18054C890")]
	public GreenGargantuar()
	{
	}
}
