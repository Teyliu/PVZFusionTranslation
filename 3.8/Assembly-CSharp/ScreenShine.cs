using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E7 RID: 1511
[Token(Token = "0x20005E7")]
public class ScreenShine : MonoBehaviour
{
	// Token: 0x06001C79 RID: 7289 RVA: 0x000982E8 File Offset: 0x000964E8
	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x509F60", Offset = "0x508560", VA = "0x180509F60")]
	private void Awake()
	{
		ScreenShine.Instance = this;
		ParticleSystem component = base.GetComponent<ParticleSystem>();
		this.particle = component;
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x0009830C File Offset: 0x0009650C
	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x50A080", Offset = "0x508680", VA = "0x18050A080")]
	public void StartEmit()
	{
		Camera main = Camera.main;
		float orthographicSize = main.orthographicSize;
		if (main == 0)
		{
			ParticleSystem.MainModule main2 = this.particle.main;
		}
	}

	// Token: 0x06001C7B RID: 7291 RVA: 0x00098340 File Offset: 0x00096540
	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x509FE0", Offset = "0x5085E0", VA = "0x180509FE0")]
	public void EndEmit()
	{
		ParticleSystem particleSystem = this.particle;
		int num = 0;
		if (particleSystem != num)
		{
			ParticleSystem.MainModule main = this.particle.main;
		}
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x00098374 File Offset: 0x00096574
	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ScreenShine()
	{
	}

	// Token: 0x04000F32 RID: 3890
	[Token(Token = "0x4000F32")]
	public static ScreenShine Instance;

	// Token: 0x04000F33 RID: 3891
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F33")]
	private ParticleSystem particle;
}
