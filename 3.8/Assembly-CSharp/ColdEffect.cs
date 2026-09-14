using System;
using AdvBuffData;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
[Serializable]
public class ColdEffect : ZombieEffect
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000051 RID: 81 RVA: 0x0000336C File Offset: 0x0000156C
	[Token(Token = "0x17000012")]
	public override bool SoftControl
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "12")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000052 RID: 82 RVA: 0x0000337C File Offset: 0x0000157C
	[Token(Token = "0x17000013")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
		get
		{
			return EffectType.Cold;
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00003394 File Offset: 0x00001594
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x3A6970", Offset = "0x3A4F70", VA = "0x1803A6970")]
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

	// Token: 0x06000054 RID: 84 RVA: 0x000033DC File Offset: 0x000015DC
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x3A6840", Offset = "0x3A4E40", VA = "0x1803A6840", Slot = "5")]
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

	// Token: 0x06000055 RID: 85 RVA: 0x00003454 File Offset: 0x00001654
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x3A6910", Offset = "0x3A4F10", VA = "0x1803A6910", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00003488 File Offset: 0x00001688
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x3A67F0", Offset = "0x3A4DF0", VA = "0x1803A67F0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		int num = 0;
		zombie.UpdateColor((Zombie.ZombieColor)num);
		this.zombie.coldSpeed = 1f;
	}

	// Token: 0x04000032 RID: 50
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000032")]
	public float duration;

	// Token: 0x04000033 RID: 51
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000033")]
	public float coldSpeed;
}
