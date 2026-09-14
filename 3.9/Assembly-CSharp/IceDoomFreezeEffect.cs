using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
[Serializable]
public class IceDoomFreezeEffect : ZombieEffect
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600007B RID: 123 RVA: 0x00003B18 File Offset: 0x00001D18
	[Token(Token = "0x1700001D")]
	public override bool HardControl
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "13")]
		get
		{
			return true;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600007C RID: 124 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x1700001E")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "4")]
		get
		{
			return EffectType.IceDoomFreeze;
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00003B38 File Offset: 0x00001D38
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x3F62C0", Offset = "0x3F48C0", VA = "0x1803F62C0")]
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

	// Token: 0x0600007E RID: 126 RVA: 0x00003B74 File Offset: 0x00001D74
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x3F6230", Offset = "0x3F4830", VA = "0x1803F6230", Slot = "5")]
	public override void OnStart()
	{
		bool flag = global::Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		bool flag2 = zombie.RemoveBuff((EffectType)((uint)1));
		GameMaterial.SetMaterial(this.zombie.spriteRenderers, (MaterialType)((uint)4));
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00003BBC File Offset: 0x00001DBC
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x3F28A0", Offset = "0x3F0EA0", VA = "0x1803F28A0", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00003BF0 File Offset: 0x00001DF0
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x3F61C0", Offset = "0x3F47C0", VA = "0x1803F61C0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		List<SpriteRenderer> spriteRenderers = this.zombie.spriteRenderers;
		int num = 0;
		GameMaterial.SetMaterial(spriteRenderers, (MaterialType)num);
	}

	// Token: 0x0400003F RID: 63
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003F")]
	public float duration;
}
