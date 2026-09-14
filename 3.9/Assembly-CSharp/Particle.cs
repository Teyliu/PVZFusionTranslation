using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Pool;

// Token: 0x020002F7 RID: 759
[Token(Token = "0x20002F7")]
public class Particle : MonoBehaviour
{
	// Token: 0x06000D9B RID: 3483 RVA: 0x0004DCD0 File Offset: 0x0004BED0
	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x4498E0", Offset = "0x447EE0", VA = "0x1804498E0", Slot = "4")]
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

	// Token: 0x06000D9C RID: 3484 RVA: 0x0004DD18 File Offset: 0x0004BF18
	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x449A90", Offset = "0x448090", VA = "0x180449A90")]
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

	// Token: 0x06000D9D RID: 3485 RVA: 0x0004DD48 File Offset: 0x0004BF48
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x449A80", Offset = "0x448080", VA = "0x180449A80")]
	private void OnParticleSystemStopped()
	{
		this.Die();
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x0004DD5C File Offset: 0x0004BF5C
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x449A30", Offset = "0x448030", VA = "0x180449A30")]
	public void InitParticle()
	{
		this.existTimer = 0f;
		Transform transform = base.transform;
		float z = this.originalScale.z;
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x0004DD90 File Offset: 0x0004BF90
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x449C20", Offset = "0x448220", VA = "0x180449C20", Slot = "5")]
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

	// Token: 0x06000DA0 RID: 3488 RVA: 0x0004DDC4 File Offset: 0x0004BFC4
	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x4499A0", Offset = "0x447FA0", VA = "0x1804499A0")]
	public void Die()
	{
		Dictionary<ParticleType, ObjectPool<Particle>> pools = ParticleManager.Instance.pools;
		ParticleType particleType = this.theParticleType;
		pools[particleType].Release(this);
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x0004DDF8 File Offset: 0x0004BFF8
	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Particle()
	{
	}

	// Token: 0x040009C1 RID: 2497
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009C1")]
	public ParticleType theParticleType;

	// Token: 0x040009C2 RID: 2498
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009C2")]
	public Vector3 originalScale;

	// Token: 0x040009C3 RID: 2499
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009C3")]
	protected float existTimer;

	// Token: 0x040009C4 RID: 2500
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009C4")]
	private float maxTimer;
}
