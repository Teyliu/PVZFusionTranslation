using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000431 RID: 1073
[Token(Token = "0x2000431")]
public class SeaHypno : Plant
{
	// Token: 0x060013C7 RID: 5063 RVA: 0x0006E984 File Offset: 0x0006CB84
	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x4BB3E0", Offset = "0x4B99E0", VA = "0x1804BB3E0")]
	public void Eat()
	{
		this.anim.SetTrigger("eat");
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x0006E9A8 File Offset: 0x0006CBA8
	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x4BB290", Offset = "0x4B9890", VA = "0x1804BB290")]
	private void AnimEat()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, thePlantRow, num3 != 0UL, (float)num2);
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x0006EA00 File Offset: 0x0006CC00
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SeaHypno()
	{
	}
}
