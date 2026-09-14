using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200038D RID: 909
[Token(Token = "0x200038D")]
public class DoomPumpkin : Pumpkin
{
	// Token: 0x060010AF RID: 4271 RVA: 0x0005F0FC File Offset: 0x0005D2FC
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x481D70", Offset = "0x480370", VA = "0x180481D70", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.1f, 0.5f);
		base.AttributeCountdown = num;
		int num2 = global::UnityEngine.Random.Range(80, 96);
		this.attributeCount = num2;
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x0005F138 File Offset: 0x0005D338
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x481AA0", Offset = "0x4800A0", VA = "0x180481AA0", Slot = "39")]
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

	// Token: 0x060010B1 RID: 4273 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x481DD0", Offset = "0x4803D0", VA = "0x180481DD0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x0005F1C0 File Offset: 0x0005D3C0
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public DoomPumpkin()
	{
	}
}
