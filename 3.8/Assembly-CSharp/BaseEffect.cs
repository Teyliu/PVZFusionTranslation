using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
[Serializable]
public abstract class BaseEffect
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000017 RID: 23 RVA: 0x000026A8 File Offset: 0x000008A8
	[Token(Token = "0x17000005")]
	public virtual EffectType EffectType
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420", Slot = "4")]
		get;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000026BC File Offset: 0x000008BC
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "5")]
	public virtual void OnStart()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000026CC File Offset: 0x000008CC
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x39F720", Offset = "0x39DD20", VA = "0x18039F720", Slot = "6")]
	public virtual void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.totalDuration = deltaTime;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "7")]
	public virtual void OnFixedUpdate()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000026F8 File Offset: 0x000008F8
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "8")]
	public virtual void OnRemove()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002708 File Offset: 0x00000908
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "9")]
	public virtual void OnCover()
	{
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600001D RID: 29 RVA: 0x00002718 File Offset: 0x00000918
	// (set) Token: 0x0600001E RID: 30 RVA: 0x0000272C File Offset: 0x0000092C
	[Token(Token = "0x17000006")]
	public virtual float Value
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x39F760", Offset = "0x39DD60", VA = "0x18039F760", Slot = "10")]
		get;
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x39F770", Offset = "0x39DD70", VA = "0x18039F770", Slot = "11")]
		set;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002740 File Offset: 0x00000940
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x39F750", Offset = "0x39DD50", VA = "0x18039F750")]
	protected BaseEffect()
	{
		this.OnStart();
	}

	// Token: 0x04000009 RID: 9
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000009")]
	public bool first = true;

	// Token: 0x0400000A RID: 10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400000A")]
	public float totalDuration;
}
