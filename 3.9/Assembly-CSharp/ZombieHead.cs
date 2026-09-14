using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008EC RID: 2284
[Token(Token = "0x20008EC")]
public class ZombieHead : MonoBehaviour
{
	// Token: 0x06002E62 RID: 11874 RVA: 0x000FD8AC File Offset: 0x000FBAAC
	[Token(Token = "0x6002E62")]
	[Address(RVA = "0x70FE00", Offset = "0x70E400", VA = "0x18070FE00")]
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

	// Token: 0x06002E63 RID: 11875 RVA: 0x000FD8FC File Offset: 0x000FBAFC
	[Token(Token = "0x6002E63")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ZombieHead()
	{
	}
}
