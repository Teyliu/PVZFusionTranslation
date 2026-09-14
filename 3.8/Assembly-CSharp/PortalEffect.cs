using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
[Serializable]
public class PortalEffect : ZombieEffect
{
	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600008B RID: 139 RVA: 0x00004108 File Offset: 0x00002308
	[Token(Token = "0x17000023")]
	public override bool HardControl
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "13")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600008C RID: 140 RVA: 0x00004118 File Offset: 0x00002318
	[Token(Token = "0x17000024")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "4")]
		get
		{
			return EffectType.Portal;
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x3B0C70", Offset = "0x3AF270", VA = "0x1803B0C70")]
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

	// Token: 0x0600008E RID: 142 RVA: 0x0000416C File Offset: 0x0000236C
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x3B0AA0", Offset = "0x3AF0A0", VA = "0x1803B0AA0", Slot = "5")]
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

	// Token: 0x0600008F RID: 143 RVA: 0x000041D4 File Offset: 0x000023D4
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x3B0B90", Offset = "0x3AF190", VA = "0x1803B0B90", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		Zombie zombie = this.zombie;
		this.duration = num;
		int theSecondArmorHealth = zombie.theSecondArmorHealth;
		float totalDuration = this.totalDuration;
		ulong num2;
		num2 += num2;
		this.OnRemove();
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00004240 File Offset: 0x00002440
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x3B09F0", Offset = "0x3AEFF0", VA = "0x1803B09F0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		float totalDuration = this.totalDuration;
		global::UnityEngine.Object.Destroy(this.portalGlow);
	}

	// Token: 0x04000040 RID: 64
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000040")]
	public float duration;

	// Token: 0x04000041 RID: 65
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000041")]
	public GameObject portalGlow;
}
