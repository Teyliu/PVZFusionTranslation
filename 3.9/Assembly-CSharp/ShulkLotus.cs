using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200043B RID: 1083
[Token(Token = "0x200043B")]
public class ShulkLotus : IceLotus
{
	// Token: 0x060013F6 RID: 5110 RVA: 0x0006F440 File Offset: 0x0006D640
	[Token(Token = "0x60013F6")]
	[Address(RVA = "0x4BC7B0", Offset = "0x4BADB0", VA = "0x1804BC7B0", Slot = "68")]
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

	// Token: 0x060013F7 RID: 5111 RVA: 0x0006F4DC File Offset: 0x0006D6DC
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ShulkLotus()
	{
	}
}
