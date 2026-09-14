using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008B0 RID: 2224
[Token(Token = "0x20008B0")]
public class ZombieHead : MonoBehaviour
{
	// Token: 0x06002D2F RID: 11567 RVA: 0x000F8D28 File Offset: 0x000F6F28
	[Token(Token = "0x6002D2F")]
	[Address(RVA = "0x695DA0", Offset = "0x6943A0", VA = "0x180695DA0")]
	private void OnParticleCollision(GameObject other)
	{
		ParticleSystem component = base.GetComponent<ParticleSystem>();
		ParticleSystem.MainModule main = component.main;
		ParticleSystem.MainModule main2 = component.main;
		int num = 0;
		ParticleSystem.MainModule main3 = component.main;
		ParticleSystem.MinMaxCurve minMaxCurve = (float)num;
		ParticleSystem.MainModule main4 = component.main;
	}

	// Token: 0x06002D30 RID: 11568 RVA: 0x000F8D78 File Offset: 0x000F6F78
	[Token(Token = "0x6002D30")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ZombieHead()
	{
	}
}
