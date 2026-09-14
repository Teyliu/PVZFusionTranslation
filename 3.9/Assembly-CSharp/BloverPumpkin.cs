using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200035C RID: 860
[Token(Token = "0x200035C")]
public class BloverPumpkin : Pumpkin
{
	// Token: 0x06000FC6 RID: 4038 RVA: 0x0005ACA4 File Offset: 0x00058EA4
	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x472EC0", Offset = "0x4714C0", VA = "0x180472EC0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 30f;
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x0005ACC4 File Offset: 0x00058EC4
	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x472C80", Offset = "0x471280", VA = "0x180472C80", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = this.thePlantColumn;
		int num2 = 0;
		if (num < 10)
		{
			CreatePlant instance = CreatePlant.Instance;
			int num3 = 0;
			Plant plant;
			if (plant != num3)
			{
				ParticleManager instance2 = ParticleManager.Instance;
				Vector3 vector;
				float z = vector.z;
				int num4 = 0;
				ulong num5;
				Particle particle = instance2.SetParticle((ParticleType)((uint)11), num2, num2, num5 != 0UL, (float)num4);
				throw new NullReferenceException();
			}
			num++;
		}
		base.AttributeCountdown = 30f;
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x0005AD34 File Offset: 0x00058F34
	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public BloverPumpkin()
	{
	}
}
