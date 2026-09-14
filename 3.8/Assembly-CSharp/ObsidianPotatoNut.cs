using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F2 RID: 1010
[Token(Token = "0x20003F2")]
public class ObsidianPotatoNut : UltimateTallNut
{
	// Token: 0x060012A1 RID: 4769 RVA: 0x00068F58 File Offset: 0x00067158
	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x458E30", Offset = "0x457430", VA = "0x180458E30", Slot = "12")]
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

	// Token: 0x060012A2 RID: 4770 RVA: 0x00068FE0 File Offset: 0x000671E0
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x458C70", Offset = "0x457270", VA = "0x180458C70")]
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

	// Token: 0x060012A3 RID: 4771 RVA: 0x00069064 File Offset: 0x00067264
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x41A9A0", Offset = "0x418FA0", VA = "0x18041A9A0")]
	public ObsidianPotatoNut()
	{
	}

	// Token: 0x04000C1F RID: 3103
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C1F")]
	private float storgedDamage;
}
