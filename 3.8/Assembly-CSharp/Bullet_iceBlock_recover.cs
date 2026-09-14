using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000150 RID: 336
[Token(Token = "0x2000150")]
public class Bullet_iceBlock_recover : Bullet_cabbage
{
	// Token: 0x0600062B RID: 1579 RVA: 0x00020E78 File Offset: 0x0001F078
	[Token(Token = "0x600062B")]
	[Address(RVA = "0x6C5B30", Offset = "0x6C4130", VA = "0x1806C5B30", Slot = "18")]
	public override void HitLand()
	{
		int num3;
		do
		{
			int num = 0;
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			int num2 = 0;
			Vector3 vector;
			float z = vector.z;
			num3 = 0;
			int num4 = 0;
			int theBulletRow = this.theBulletRow;
			ulong num5;
			Particle particle = instance.SetParticle((ParticleType)((uint)24), num2, theBulletRow, num5 != 0UL, (float)num4);
			Plant targetPlant = this.targetPlant;
			int num6 = 0;
			if (!(targetPlant != num6))
			{
				Mouse instance2 = Mouse.Instance;
				Transform transform2 = base.transform;
			}
			Plant targetPlant2 = this.targetPlant;
			int thePlantColumn = targetPlant2.thePlantColumn;
			int thePlantRow = targetPlant2.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				bool flag2 = num.SetEffect((EffectType)((uint)107), 5f, 0.3f);
				ParticleManager instance3 = ParticleManager.Instance;
				int num7 = 0;
				ulong num8;
				Particle particle2 = instance3.SetParticle((ParticleType)((uint)103), num7, 1, num8 != 0UL, (float)num4);
			}
		}
		while (num3 != 0);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00020F6C File Offset: 0x0001F16C
	[Token(Token = "0x600062C")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_iceBlock_recover()
	{
	}
}
