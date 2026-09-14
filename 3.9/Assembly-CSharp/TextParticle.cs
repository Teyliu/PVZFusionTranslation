using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FC RID: 764
[Token(Token = "0x20002FC")]
public class TextParticle : Particle
{
	// Token: 0x06000DAD RID: 3501 RVA: 0x0004E12C File Offset: 0x0004C32C
	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x455DF0", Offset = "0x4543F0", VA = "0x180455DF0", Slot = "4")]
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

	// Token: 0x06000DAE RID: 3502 RVA: 0x0004E190 File Offset: 0x0004C390
	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x455EE0", Offset = "0x4544E0", VA = "0x180455EE0", Slot = "5")]
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

	// Token: 0x06000DAF RID: 3503 RVA: 0x0004E204 File Offset: 0x0004C404
	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TextParticle()
	{
	}

	// Token: 0x04000A6F RID: 2671
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A6F")]
	private Transform text;
}
