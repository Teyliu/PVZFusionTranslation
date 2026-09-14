using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200037D RID: 893
[Token(Token = "0x200037D")]
public class DoomPumpkin : Pumpkin
{
	// Token: 0x06001063 RID: 4195 RVA: 0x0005E0B4 File Offset: 0x0005C2B4
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x431450", Offset = "0x42FA50", VA = "0x180431450", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.1f, 0.5f);
		base.AttributeCountdown = num;
		int num2 = global::UnityEngine.Random.Range(80, 96);
		this.attributeCount = num2;
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x0005E0F0 File Offset: 0x0005C2F0
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x431180", Offset = "0x42F780", VA = "0x180431180", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num;
		do
		{
			num = 0;
			base.AttributeCountdown = 0.5f;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				if (Lawnf.IsUltiPlant((PlantType)num))
				{
					continue;
				}
				CreatePlant instance = CreatePlant.Instance;
			}
		}
		while (num != 0);
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x0005E158 File Offset: 0x0005C358
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x4314B0", Offset = "0x42FAB0", VA = "0x1804314B0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x0005E178 File Offset: 0x0005C378
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public DoomPumpkin()
	{
	}
}
