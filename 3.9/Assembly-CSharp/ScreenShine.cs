using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200061C RID: 1564
[Token(Token = "0x200061C")]
public class ScreenShine : MonoBehaviour
{
	// Token: 0x06001D78 RID: 7544 RVA: 0x0009CE50 File Offset: 0x0009B050
	[Token(Token = "0x6001D78")]
	[Address(RVA = "0x576FE0", Offset = "0x5755E0", VA = "0x180576FE0")]
	private void Awake()
	{
		ScreenShine.Instance = this;
		ParticleSystem component = base.GetComponent<ParticleSystem>();
		this.particle = component;
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x0009CE74 File Offset: 0x0009B074
	[Token(Token = "0x6001D79")]
	[Address(RVA = "0x577100", Offset = "0x575700", VA = "0x180577100")]
	public void StartEmit()
	{
		Camera main = Camera.main;
		float orthographicSize = main.orthographicSize;
		if (main == 0)
		{
			ParticleSystem.MainModule main2 = this.particle.main;
		}
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x0009CEA8 File Offset: 0x0009B0A8
	[Token(Token = "0x6001D7A")]
	[Address(RVA = "0x577060", Offset = "0x575660", VA = "0x180577060")]
	public void EndEmit()
	{
		ParticleSystem particleSystem = this.particle;
		int num = 0;
		if (particleSystem != num)
		{
			ParticleSystem.MainModule main = this.particle.main;
		}
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x0009CEDC File Offset: 0x0009B0DC
	[Token(Token = "0x6001D7B")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ScreenShine()
	{
	}

	// Token: 0x04000FFA RID: 4090
	[Token(Token = "0x4000FFA")]
	public static ScreenShine Instance;

	// Token: 0x04000FFB RID: 4091
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FFB")]
	private ParticleSystem particle;
}
