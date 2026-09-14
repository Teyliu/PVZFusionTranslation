using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000455 RID: 1109
[Token(Token = "0x2000455")]
public class ThornsLotus : IceLotus
{
	// Token: 0x06001473 RID: 5235 RVA: 0x000720D8 File Offset: 0x000702D8
	[Token(Token = "0x6001473")]
	[Address(RVA = "0x477B80", Offset = "0x476180", VA = "0x180477B80", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		float attributeSpeed = this.attributeSpeed;
		this.attributeSpeed = attributeSpeed;
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x000720FC File Offset: 0x000702FC
	[Token(Token = "0x6001474")]
	[Address(RVA = "0x477810", Offset = "0x475E10", VA = "0x180477810", Slot = "69")]
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
				PlantType thePlantType = this.thePlantType;
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

	// Token: 0x06001475 RID: 5237 RVA: 0x000721A0 File Offset: 0x000703A0
	[Token(Token = "0x6001475")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ThornsLotus()
	{
	}
}
