using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
[Serializable]
public class PortalEffect : ZombieEffect
{
	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x00004464 File Offset: 0x00002664
	[Token(Token = "0x17000029")]
	public override bool HardControl
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "13")]
		get
		{
			return true;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004474 File Offset: 0x00002674
	[Token(Token = "0x1700002A")]
	public override EffectType EffectType
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "4")]
		get
		{
			return EffectType.Portal;
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00004484 File Offset: 0x00002684
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x3FCF30", Offset = "0x3FB530", VA = "0x1803FCF30")]
	public PortalEffect(Zombie zombie, float duration)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
			ulong num;
			this.portalGlow = num;
		}
		this.duration = duration;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000044C8 File Offset: 0x000026C8
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x3FCD60", Offset = "0x3FB360", VA = "0x1803FCD60", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		Collider2D col = zombie.col;
		Zombie zombie2 = this.zombie;
		GameObject gameObject;
		this.portalGlow = gameObject;
		Transform transform = this.portalGlow.transform;
		Transform transform2 = this.zombie.transform;
		transform.parentInternal = transform2;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00004530 File Offset: 0x00002730
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x3FCE50", Offset = "0x3FB450", VA = "0x1803FCE50", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		Zombie zombie = this.zombie;
		this.duration = num;
		int theFirstArmorHealth = zombie.theFirstArmorHealth;
		int num2 = zombie.theSecondArmorHealth;
		int num3 = 0;
		float totalDuration = this.totalDuration;
		num2 += theFirstArmorHealth;
		ulong num4;
		num4 += num4;
		if (totalDuration <= (float)num3)
		{
			this.OnRemove();
			return;
		}
		uint num5;
		zombie.Die((int)num5);
		this.duration = 0f;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000045B4 File Offset: 0x000027B4
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x3FCCB0", Offset = "0x3FB2B0", VA = "0x1803FCCB0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		float totalDuration = this.totalDuration;
		global::UnityEngine.Object.Destroy(this.portalGlow);
	}

	// Token: 0x04000049 RID: 73
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000049")]
	public float duration;

	// Token: 0x0400004A RID: 74
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400004A")]
	public GameObject portalGlow;
}
