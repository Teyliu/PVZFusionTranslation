using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
public class ImitateEffect : BaseEffect
{
	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000045 RID: 69 RVA: 0x00002C3C File Offset: 0x00000E3C
	[Token(Token = "0x1700000F")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "4")]
		get
		{
			return EffectType.Imitate;
		}
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002C4C File Offset: 0x00000E4C
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3F6A30", Offset = "0x3F5030", VA = "0x1803F6A30")]
	public ImitateEffect(Plant plant, float timer)
	{
		this.first = true;
		base.OnStart();
		this.plant = plant;
		this.timer = timer;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002C74 File Offset: 0x00000E74
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x3F6410", Offset = "0x3F4A10", VA = "0x1803F6410")]
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

	// Token: 0x06000048 RID: 72 RVA: 0x00002D94 File Offset: 0x00000F94
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3F63B0", Offset = "0x3F49B0", VA = "0x1803F63B0", Slot = "6")]
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

	// Token: 0x0400002F RID: 47
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002F")]
	[SerializeField]
	private Plant plant;

	// Token: 0x04000030 RID: 48
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000030")]
	[SerializeField]
	private float timer;

	// Token: 0x04000031 RID: 49
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000031")]
	[SerializeField]
	private int count;
}
