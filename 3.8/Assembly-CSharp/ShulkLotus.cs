using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200041C RID: 1052
[Token(Token = "0x200041C")]
public class ShulkLotus : IceLotus
{
	// Token: 0x0600136C RID: 4972 RVA: 0x0006D198 File Offset: 0x0006B398
	[Token(Token = "0x600136C")]
	[Address(RVA = "0x4657C0", Offset = "0x463DC0", VA = "0x1804657C0", Slot = "69")]
	protected override void AnimRecover()
	{
		ulong num;
		do
		{
			AdvantureMission.TryAddCount((AdvantureLevel)((uint)64));
			bool result = AdvantureConfig.data.GetResult((AdvantureLevel)((uint)64), (MissionResult)((uint)2));
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			if (result)
			{
				List<Plant> rangePlants = Lawnf.GetRangePlants(thePlantColumn, thePlantRow, 2);
			}
			List<Plant> list = Lawnf.Get3x3Plants(thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		ParticleManager instance = ParticleManager.Instance;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)85), num2, 1, num4 != 0UL, (float)num3);
		GameAPP.PlaySound(94, 0.5f, 1f);
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x0006D234 File Offset: 0x0006B434
	[Token(Token = "0x600136D")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ShulkLotus()
	{
	}
}
