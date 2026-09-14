using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000272 RID: 626
[Token(Token = "0x2000272")]
public class RiverWater : MonoBehaviour
{
	// Token: 0x06000B3F RID: 2879 RVA: 0x00040024 File Offset: 0x0003E224
	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x938A70", Offset = "0x937070", VA = "0x180938A70")]
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

	// Token: 0x06000B40 RID: 2880 RVA: 0x000400BC File Offset: 0x0003E2BC
	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public RiverWater()
	{
	}

	// Token: 0x04000748 RID: 1864
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000748")]
	public Vector2Int min;

	// Token: 0x04000749 RID: 1865
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000749")]
	public Vector2Int max;
}
