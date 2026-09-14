using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003CB RID: 971
[Token(Token = "0x20003CB")]
public class IceSeaShroom : Plant
{
	// Token: 0x060011CC RID: 4556 RVA: 0x0006467C File Offset: 0x0006287C
	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x4961E0", Offset = "0x4947E0", VA = "0x1804961E0")]
	public void Eat()
	{
		this.anim.SetTrigger("eat");
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x000646A0 File Offset: 0x000628A0
	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x495F30", Offset = "0x494530", VA = "0x180495F30")]
	private void AnimEat()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				PlantType thePlantType = this.thePlantType;
			}
			num3++;
		}
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00064710 File Offset: 0x00062910
	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public IceSeaShroom()
	{
	}
}
