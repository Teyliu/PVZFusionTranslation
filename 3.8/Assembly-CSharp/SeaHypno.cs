using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000414 RID: 1044
[Token(Token = "0x2000414")]
public class SeaHypno : Plant
{
	// Token: 0x06001347 RID: 4935 RVA: 0x0006C938 File Offset: 0x0006AB38
	[Token(Token = "0x6001347")]
	[Address(RVA = "0x464930", Offset = "0x462F30", VA = "0x180464930")]
	public void Eat()
	{
		this.anim.SetTrigger("eat");
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x0006C95C File Offset: 0x0006AB5C
	[Token(Token = "0x6001348")]
	[Address(RVA = "0x4647E0", Offset = "0x462DE0", VA = "0x1804647E0")]
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

	// Token: 0x06001349 RID: 4937 RVA: 0x0006C9B4 File Offset: 0x0006ABB4
	[Token(Token = "0x6001349")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SeaHypno()
	{
	}
}
