using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000167 RID: 359
[Token(Token = "0x2000167")]
public class Bullet_magicTrack_hypno : Bullet_magicTrack
{
	// Token: 0x06000675 RID: 1653 RVA: 0x00021F98 File Offset: 0x00020198
	[Token(Token = "0x6000675")]
	[Address(RVA = "0x6C9450", Offset = "0x6C7A50", VA = "0x1806C9450", Slot = "11")]
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

	// Token: 0x06000676 RID: 1654 RVA: 0x00021FE4 File Offset: 0x000201E4
	[Token(Token = "0x6000676")]
	[Address(RVA = "0x6C9720", Offset = "0x6C7D20", VA = "0x1806C9720")]
	public Bullet_magicTrack_hypno()
	{
		List<ParticleSystem> list = new List();
		this.trails = list;
		base..ctor();
	}

	// Token: 0x04000376 RID: 886
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000376")]
	public List<ParticleSystem> trails;
}
