using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200034C RID: 844
[Token(Token = "0x200034C")]
public class BloverPumpkin : Pumpkin
{
	// Token: 0x06000F7A RID: 3962 RVA: 0x00059D44 File Offset: 0x00057F44
	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x41C020", Offset = "0x41A620", VA = "0x18041C020", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 30f;
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00059D64 File Offset: 0x00057F64
	[Token(Token = "0x6000F7B")]
	[Address(RVA = "0x41BDE0", Offset = "0x41A3E0", VA = "0x18041BDE0", Slot = "40")]
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

	// Token: 0x06000F7C RID: 3964 RVA: 0x00059DD4 File Offset: 0x00057FD4
	[Token(Token = "0x6000F7C")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public BloverPumpkin()
	{
	}
}
