using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200040C RID: 1036
[Token(Token = "0x200040C")]
public class ObsidianPotatoNut : UltimateTallNut
{
	// Token: 0x06001314 RID: 4884 RVA: 0x0006ACDC File Offset: 0x00068EDC
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x4AD210", Offset = "0x4AB810", VA = "0x1804AD210", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		int num = 0;
		if (damage > 0)
		{
			Transform axis = this.axis;
			int num2 = 0;
			if (axis != num2)
			{
				Transform axis2 = this.axis;
				Vector3 vector;
				float z = vector.z;
				PlantType thePlantType = this.thePlantType;
				Transform axis3 = this.axis;
				ParticleManager instance = ParticleManager.Instance;
				int num3 = 0;
				int num4 = 0;
				ulong num5;
				Particle particle = instance.SetParticle((ParticleType)((uint)8), num3, 11, num5 != 0UL, (float)num4);
				GameAPP.PlaySound(47, 0.5f, 1f);
				this.storgedDamage = (float)num;
			}
		}
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x0006AD64 File Offset: 0x00068F64
	[Token(Token = "0x6001315")]
	[Address(RVA = "0x4AD050", Offset = "0x4AB650", VA = "0x1804AD050")]
	private void Storge(int damage)
	{
		Transform axis = this.axis;
		int num = 0;
		if (axis != num)
		{
			Transform axis2 = this.axis;
			int num2 = 0;
			Vector3 vector;
			float z = vector.z;
			PlantType thePlantType = this.thePlantType;
			Transform axis3 = this.axis;
			ParticleManager instance = ParticleManager.Instance;
			int num3 = 0;
			int num4 = 0;
			ulong num5;
			Particle particle = instance.SetParticle((ParticleType)((uint)8), num3, 11, num5 != 0UL, (float)num4);
			GameAPP.PlaySound(47, 0.5f, 1f);
			this.storgedDamage = (float)num2;
		}
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0006ADE8 File Offset: 0x00068FE8
	[Token(Token = "0x6001316")]
	[Address(RVA = "0x497370", Offset = "0x495970", VA = "0x180497370")]
	public ObsidianPotatoNut()
	{
	}

	// Token: 0x04000C96 RID: 3222
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C96")]
	private float storgedDamage;
}
