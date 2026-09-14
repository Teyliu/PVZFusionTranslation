using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002EE RID: 750
[Token(Token = "0x20002EE")]
public class TextParticle : Particle
{
	// Token: 0x06000D6A RID: 3434 RVA: 0x0004D4B8 File Offset: 0x0004B6B8
	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x3FD660", Offset = "0x3FBC60", VA = "0x1803FD660", Slot = "4")]
	protected override void Awake()
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
		Transform transform2 = base.transform;
		int num2 = 0;
		Transform child = transform2.GetChild(num2);
		this.text = child;
		throw new NullReferenceException();
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x0004D51C File Offset: 0x0004B71C
	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x3FD750", Offset = "0x3FBD50", VA = "0x1803FD750", Slot = "5")]
	protected override void Update()
	{
		int num;
		float existTimer;
		do
		{
			float deltaTime = Time.deltaTime;
			float maxTimer = this.maxTimer;
			num = 0;
			this.existTimer = deltaTime;
			if (maxTimer > (float)num && deltaTime > maxTimer)
			{
				base.Die();
			}
			Transform transform = this.text;
			float num2;
			if (num > (int)num2 || num2 > 1f)
			{
			}
			existTimer = this.existTimer;
		}
		while (num <= (int)existTimer && existTimer <= 1f);
		float num3 = (float)(0 * (int)0.7f);
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x0004D590 File Offset: 0x0004B790
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TextParticle()
	{
	}

	// Token: 0x04000A30 RID: 2608
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A30")]
	private Transform text;
}
