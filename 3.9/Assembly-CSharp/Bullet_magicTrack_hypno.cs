using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016D RID: 365
[Token(Token = "0x200016D")]
public class Bullet_magicTrack_hypno : Bullet_magicTrack
{
	// Token: 0x06000680 RID: 1664 RVA: 0x00021940 File Offset: 0x0001FB40
	[Token(Token = "0x6000680")]
	[Address(RVA = "0x6F4D50", Offset = "0x6F3350", VA = "0x1806F4D50", Slot = "12")]
	protected override void Update()
	{
		int num;
		do
		{
			num = 0;
			base.Update();
			List<ParticleSystem> list = this.trails;
			bool flag;
			if (flag)
			{
				Transform transform = base.transform;
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num != 0);
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0002198C File Offset: 0x0001FB8C
	[Token(Token = "0x6000681")]
	[Address(RVA = "0x6F5020", Offset = "0x6F3620", VA = "0x1806F5020")]
	public Bullet_magicTrack_hypno()
	{
		List<ParticleSystem> list = new List();
		this.trails = list;
		base..ctor();
	}

	// Token: 0x0400037F RID: 895
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400037F")]
	public List<ParticleSystem> trails;
}
