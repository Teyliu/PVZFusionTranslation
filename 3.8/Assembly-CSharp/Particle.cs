using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Pool;

// Token: 0x020002E9 RID: 745
[Token(Token = "0x20002E9")]
public class Particle : MonoBehaviour
{
	// Token: 0x06000D58 RID: 3416 RVA: 0x0004D05C File Offset: 0x0004B25C
	[Token(Token = "0x6000D58")]
	[Address(RVA = "0x3ECEC0", Offset = "0x3EB4C0", VA = "0x1803ECEC0", Slot = "4")]
	protected virtual void Awake()
	{
		int num = 0;
		if (!base.TryGetComponent<ParticleSystem>(num))
		{
			this.maxTimer = 1f;
		}
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.originalScale.z = z;
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x0004D0A4 File Offset: 0x0004B2A4
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x3ED070", Offset = "0x3EB670", VA = "0x1803ED070")]
	public void SetSpeed(float value)
	{
		ulong num;
		do
		{
			List<ParticleSystem> childs = global::Core.Lawnf.GetChilds<ParticleSystem>(base.transform);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x0004D0D4 File Offset: 0x0004B2D4
	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x3ED060", Offset = "0x3EB660", VA = "0x1803ED060")]
	private void OnParticleSystemStopped()
	{
		this.Die();
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x0004D0E8 File Offset: 0x0004B2E8
	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0x3ED010", Offset = "0x3EB610", VA = "0x1803ED010")]
	public void InitParticle()
	{
		this.existTimer = 0f;
		Transform transform = base.transform;
		float z = this.originalScale.z;
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x0004D11C File Offset: 0x0004B31C
	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x3ED200", Offset = "0x3EB800", VA = "0x1803ED200", Slot = "5")]
	protected virtual void Update()
	{
		float deltaTime = Time.deltaTime;
		float num = this.maxTimer;
		int num2 = 0;
		this.existTimer = deltaTime;
		if (num > (float)num2 && deltaTime > num)
		{
			this.Die();
		}
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x0004D150 File Offset: 0x0004B350
	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x3ECF80", Offset = "0x3EB580", VA = "0x1803ECF80")]
	public void Die()
	{
		Dictionary<ParticleType, ObjectPool<Particle>> pools = ParticleManager.Instance.pools;
		ParticleType particleType = this.theParticleType;
		pools[particleType].Release(this);
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x0004D184 File Offset: 0x0004B384
	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Particle()
	{
	}

	// Token: 0x04000984 RID: 2436
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000984")]
	public ParticleType theParticleType;

	// Token: 0x04000985 RID: 2437
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000985")]
	public Vector3 originalScale;

	// Token: 0x04000986 RID: 2438
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000986")]
	protected float existTimer;

	// Token: 0x04000987 RID: 2439
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000987")]
	private float maxTimer;
}
