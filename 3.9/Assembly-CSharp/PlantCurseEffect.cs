using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
[Serializable]
public class PlantCurseEffect : PlantEffect
{
	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600004D RID: 77 RVA: 0x00002E70 File Offset: 0x00001070
	[Token(Token = "0x17000010")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x3FC040", Offset = "0x3FA640", VA = "0x1803FC040", Slot = "4")]
		get
		{
			return EffectType.Curse;
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002E80 File Offset: 0x00001080
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x3FBED0", Offset = "0x3FA4D0", VA = "0x1803FBED0")]
	public PlantCurseEffect(Plant plant, float value)
	{
		this.first = true;
		base.OnStart();
		this.plant = plant;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
		}
		base.Value = 1f;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002EC4 File Offset: 0x000010C4
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x3FBA60", Offset = "0x3FA060", VA = "0x1803FBA60", Slot = "5")]
	public override void OnStart()
	{
		HealthSlider healthSlider = this.plant.healthSlider;
		int num = 0;
		if (healthSlider != num)
		{
			this.plant.healthSlider.curseFill.enabled = true;
			return;
		}
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002F08 File Offset: 0x00001108
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x3FBB00", Offset = "0x3FA100", VA = "0x1803FBB00", Slot = "6")]
	public override void OnUpdate()
	{
		float num = this.totalDuration;
		float deltaTime = Time.deltaTime;
		this.totalDuration = deltaTime;
		float value = base.Value;
		this.OnRemove();
		float value2 = base.Value;
		Plant plant = this.plant;
		num = value2;
		int num2 = 0;
		plant.Die((Plant.DieReason)num2);
		this.OnRemove();
		HealthSlider healthSlider = this.plant.healthSlider;
		int num3 = 0;
		if (healthSlider != num3)
		{
			this.plant.healthSlider.CurseFill = num;
		}
		Plant plant2 = this.plant;
		List<GridItem> griditemArray = this.plant.board.griditemArray;
		Func<GridItem, bool> func = delegate(GridItem a)
		{
			int num5 = 0;
			if (a != num5)
			{
				int thePlantColumn = this.plant.thePlantColumn;
				if (a.theItemColumn == thePlantColumn)
				{
					int thePlantRow = this.plant.thePlantRow;
					if (a.theItemRow == thePlantRow)
					{
					}
				}
			}
			throw new NullReferenceException();
		};
		if (!Enumerable.Any<GridItem>(griditemArray, func))
		{
			float value3 = base.Value;
			float deltaTime2 = Time.deltaTime;
		}
		float num4 = Time.deltaTime * 100f;
		base.Value = num4;
		Plant plant3 = this.plant;
		int thePlantMaxHealth = plant3.thePlantMaxHealth;
		if (plant3.thePlantHealth == thePlantMaxHealth)
		{
			plant3.thePlantHealth = thePlantMaxHealth;
			this.plant.UpdateText();
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00003028 File Offset: 0x00001228
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x3FB990", Offset = "0x3F9F90", VA = "0x1803FB990", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		HealthSlider healthSlider = this.plant.healthSlider;
		int num = 0;
		if (healthSlider != num)
		{
			Image curseFill = this.plant.healthSlider.curseFill;
			int num2 = 0;
			curseFill.enabled = num2 != 0;
		}
		Plant plant = this.plant;
	}
}
