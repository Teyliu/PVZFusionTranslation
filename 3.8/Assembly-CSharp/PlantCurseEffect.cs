using System;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
[Serializable]
public class PlantCurseEffect : PlantEffect
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000033 RID: 51 RVA: 0x00002B28 File Offset: 0x00000D28
	[Token(Token = "0x1700000A")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3AFD80", Offset = "0x3AE380", VA = "0x1803AFD80", Slot = "4")]
		get
		{
			return EffectType.Curse;
		}
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3AFC10", Offset = "0x3AE210", VA = "0x1803AFC10")]
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

	// Token: 0x06000035 RID: 53 RVA: 0x00002B7C File Offset: 0x00000D7C
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x3AF7A0", Offset = "0x3ADDA0", VA = "0x1803AF7A0", Slot = "5")]
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

	// Token: 0x06000036 RID: 54 RVA: 0x00002BC0 File Offset: 0x00000DC0
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x3AF840", Offset = "0x3ADE40", VA = "0x1803AF840", Slot = "6")]
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
		Func<GridItem, bool> func;
		if (!Enumerable.Any<GridItem>(this.plant.board.griditemArray, func))
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

	// Token: 0x06000037 RID: 55 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x3AF6D0", Offset = "0x3ADCD0", VA = "0x1803AF6D0", Slot = "8")]
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
