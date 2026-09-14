using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000475 RID: 1141
[Token(Token = "0x2000475")]
public class ThornsLotus : IceLotus
{
	// Token: 0x06001503 RID: 5379 RVA: 0x00074444 File Offset: 0x00072644
	[Token(Token = "0x6001503")]
	[Address(RVA = "0x4CF440", Offset = "0x4CDA40", VA = "0x1804CF440", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		float attributeSpeed = this.attributeSpeed;
		this.attributeSpeed = attributeSpeed;
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x00074468 File Offset: 0x00072668
	[Token(Token = "0x6001504")]
	[Address(RVA = "0x4CF0C0", Offset = "0x4CD6C0", VA = "0x1804CF0C0", Slot = "68")]
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
		GameAPP.PlaySound(94, 0.5f, 1f);
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x000744F8 File Offset: 0x000726F8
	[Token(Token = "0x6001505")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ThornsLotus()
	{
	}
}
