using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200026C RID: 620
[Token(Token = "0x200026C")]
public class RiverWater : MonoBehaviour
{
	// Token: 0x06000B23 RID: 2851 RVA: 0x00040164 File Offset: 0x0003E364
	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x8A8A50", Offset = "0x8A7050", VA = "0x1808A8A50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int y = this.max.m_Y;
			int y2 = this.min.m_Y;
			bool flag2;
			if (y2 != 10 && y2 != 16 && y2 != 20 && !flag2 && !flag2 && !flag2 && !flag2)
			{
				Vector3 vector;
				float z = vector.z;
				int num = 0;
				ParticleManager instance = ParticleManager.Instance;
				int num2 = 0;
				ulong num3;
				ulong num4;
				Particle particle = instance.SetParticle((ParticleType)((uint)32), num2, (int)num3, num4 != 0UL, (float)num);
				GameAPP.PlaySound(75, 0.5f, 1f);
			}
		}
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x000401FC File Offset: 0x0003E3FC
	[Token(Token = "0x6000B24")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public RiverWater()
	{
	}

	// Token: 0x0400073C RID: 1852
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400073C")]
	public Vector2Int min;

	// Token: 0x0400073D RID: 1853
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400073D")]
	public Vector2Int max;
}
