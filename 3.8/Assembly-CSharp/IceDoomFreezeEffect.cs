using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
[Serializable]
public class IceDoomFreezeEffect : ZombieEffect
{
	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000061 RID: 97 RVA: 0x000037BC File Offset: 0x000019BC
	[Token(Token = "0x17000017")]
	public override bool HardControl
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "13")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000062 RID: 98 RVA: 0x000037CC File Offset: 0x000019CC
	[Token(Token = "0x17000018")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "4")]
		get
		{
			return EffectType.IceDoomFreeze;
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000037DC File Offset: 0x000019DC
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x3AA4C0", Offset = "0x3A8AC0", VA = "0x1803AA4C0")]
	public IceDoomFreezeEffect(Zombie zombie, float duration)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
		}
		this.duration = duration;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003818 File Offset: 0x00001A18
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x3AA430", Offset = "0x3A8A30", VA = "0x1803AA430", Slot = "5")]
	public override void OnStart()
	{
		bool flag = global::Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		bool flag2 = zombie.RemoveBuff((EffectType)((uint)1));
		GameMaterial.SetMaterial(this.zombie.spriteRenderers, (MaterialType)((uint)4));
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00003860 File Offset: 0x00001A60
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x3A6910", Offset = "0x3A4F10", VA = "0x1803A6910", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00003894 File Offset: 0x00001A94
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x3AA3C0", Offset = "0x3A89C0", VA = "0x1803AA3C0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		List<SpriteRenderer> spriteRenderers = this.zombie.spriteRenderers;
		int num = 0;
		GameMaterial.SetMaterial(spriteRenderers, (MaterialType)num);
	}

	// Token: 0x04000036 RID: 54
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000036")]
	public float duration;
}
