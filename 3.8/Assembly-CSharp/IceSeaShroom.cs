using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B7 RID: 951
[Token(Token = "0x20003B7")]
public class IceSeaShroom : Plant
{
	// Token: 0x06001170 RID: 4464 RVA: 0x0006305C File Offset: 0x0006125C
	[Token(Token = "0x6001170")]
	[Address(RVA = "0x444290", Offset = "0x442890", VA = "0x180444290")]
	public void Eat()
	{
		this.anim.SetTrigger("eat");
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00063080 File Offset: 0x00061280
	[Token(Token = "0x6001171")]
	[Address(RVA = "0x443FE0", Offset = "0x4425E0", VA = "0x180443FE0")]
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

	// Token: 0x06001172 RID: 4466 RVA: 0x000630F0 File Offset: 0x000612F0
	[Token(Token = "0x6001172")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public IceSeaShroom()
	{
	}
}
