using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
[Serializable]
public abstract class BaseEffect
{
	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000031 RID: 49 RVA: 0x000029F0 File Offset: 0x00000BF0
	[Token(Token = "0x1700000B")]
	public virtual EffectType EffectType
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430", Slot = "4")]
		get;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002A04 File Offset: 0x00000C04
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "5")]
	public virtual void OnStart()
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002A14 File Offset: 0x00000C14
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x3EB750", Offset = "0x3E9D50", VA = "0x1803EB750", Slot = "6")]
	public virtual void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.totalDuration = deltaTime;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "7")]
	public virtual void OnFixedUpdate()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002A40 File Offset: 0x00000C40
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "8")]
	public virtual void OnRemove()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002A50 File Offset: 0x00000C50
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "9")]
	public virtual void OnCover()
	{
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000037 RID: 55 RVA: 0x00002A60 File Offset: 0x00000C60
	// (set) Token: 0x06000038 RID: 56 RVA: 0x00002A74 File Offset: 0x00000C74
	[Token(Token = "0x1700000C")]
	public virtual float Value
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3EB790", Offset = "0x3E9D90", VA = "0x1803EB790", Slot = "10")]
		get;
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3EB7A0", Offset = "0x3E9DA0", VA = "0x1803EB7A0", Slot = "11")]
		set;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002A88 File Offset: 0x00000C88
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x3EB780", Offset = "0x3E9D80", VA = "0x1803EB780")]
	protected BaseEffect()
	{
		this.OnStart();
	}

	// Token: 0x04000012 RID: 18
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000012")]
	public bool first = true;

	// Token: 0x04000013 RID: 19
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000013")]
	public float totalDuration;
}
