using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000730 RID: 1840
[Token(Token = "0x2000730")]
public class ZombieObstacle : Obstacle
{
	// Token: 0x06002573 RID: 9587 RVA: 0x000C55AC File Offset: 0x000C37AC
	[Token(Token = "0x6002573")]
	[Address(RVA = "0x5D4CF0", Offset = "0x5D32F0", VA = "0x1805D4CF0", Slot = "7")]
	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Bullet>(num))
		{
			int theBallRow = this.theBallRow;
			float num2 = this.theHealth;
			this.flashTime = 0.3f;
			int num3 = 0;
			this.theHealth = num2;
			if (num3 > (int)num2)
			{
				base.Die();
			}
		}
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x000C55FC File Offset: 0x000C37FC
	[Token(Token = "0x6002574")]
	[Address(RVA = "0x5D4E20", Offset = "0x5D3420", VA = "0x1805D4E20")]
	public ZombieObstacle()
	{
	}

	// Token: 0x040012CC RID: 4812
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012CC")]
	public float theHealth;
}
