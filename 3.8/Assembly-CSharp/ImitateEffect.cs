using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public class ImitateEffect : BaseEffect
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600002B RID: 43 RVA: 0x000028F4 File Offset: 0x00000AF4
	[Token(Token = "0x17000009")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "4")]
		get
		{
			return EffectType.Imitate;
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002904 File Offset: 0x00000B04
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3AAC30", Offset = "0x3A9230", VA = "0x1803AAC30")]
	public ImitateEffect(Plant plant, float timer)
	{
		this.first = true;
		base.OnStart();
		this.plant = plant;
		this.timer = timer;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000292C File Offset: 0x00000B2C
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3AA610", Offset = "0x3A8C10", VA = "0x1803AA610")]
	private void TimeUp()
	{
		Plant plant = this.plant;
		int thePlantRow = plant.thePlantRow;
		List<Plant> list = Lawnf.Get3x3Plants(plant.thePlantColumn, thePlantRow);
		Predicate<Plant> predicate;
		int num = list.RemoveAll(predicate);
		Predicate<Plant> <>9__6_ = ImitateEffect.<>c.<>9__6_1;
		if (<>9__6_ == 0)
		{
			Predicate<Plant> predicate2;
			ImitateEffect.<>c.<>9__6_1 = predicate2;
		}
		int num2 = list.RemoveAll(<>9__6_);
		this.timer = 3f;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002A4C File Offset: 0x00000C4C
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x3AA5B0", Offset = "0x3A8BB0", VA = "0x1803AA5B0", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		float num = this.timer;
		this.totalDuration = deltaTime;
		float deltaTime2 = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			this.TimeUp();
		}
	}

	// Token: 0x04000026 RID: 38
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000026")]
	[SerializeField]
	private Plant plant;

	// Token: 0x04000027 RID: 39
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000027")]
	[SerializeField]
	private float timer;

	// Token: 0x04000028 RID: 40
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000028")]
	[SerializeField]
	private int count;
}
