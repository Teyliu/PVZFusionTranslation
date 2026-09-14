using System;
using AdvBuffData;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
[Serializable]
public class ColdEffect : ZombieEffect
{
	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600006B RID: 107 RVA: 0x000036C4 File Offset: 0x000018C4
	[Token(Token = "0x17000018")]
	public override bool SoftControl
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "12")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600006C RID: 108 RVA: 0x000036D4 File Offset: 0x000018D4
	[Token(Token = "0x17000019")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
		get
		{
			return EffectType.Cold;
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000036EC File Offset: 0x000018EC
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x3F2900", Offset = "0x3F0F00", VA = "0x1803F2900")]
	public ColdEffect(Zombie zombie, float coldSpeed, float duration)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
		}
		this.coldSpeed = coldSpeed;
		this.duration = duration;
		zombie.coldSpeed = coldSpeed;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00003734 File Offset: 0x00001934
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x3F27D0", Offset = "0x3F0DD0", VA = "0x1803F27D0", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		this.rwkr = flag;
		bool flag2 = Lawnf.TravelAdvanced((AdvBuff)((uint)3009));
		Zombie zombie = this.zombie;
		if (!flag2)
		{
			bool flag3 = zombie.RemoveBuff((EffectType)((uint)1));
		}
		if (zombie.RemoveBuff((EffectType)((uint)1)))
		{
			元素反应.Explode(this.zombie);
		}
		GameAPP.PlaySound((SoundType)((uint)67), 0.5f, 1f);
		Zombie zombie2 = this.zombie;
		throw new NullReferenceException();
	}

	// Token: 0x0600006F RID: 111 RVA: 0x000037AC File Offset: 0x000019AC
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x3F28A0", Offset = "0x3F0EA0", VA = "0x1803F28A0", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x3F2780", Offset = "0x3F0D80", VA = "0x1803F2780", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		int num = 0;
		zombie.UpdateColor((Zombie.ZombieColor)num);
		this.zombie.coldSpeed = 1f;
	}

	// Token: 0x0400003B RID: 59
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003B")]
	public float duration;

	// Token: 0x0400003C RID: 60
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400003C")]
	public float coldSpeed;
}
