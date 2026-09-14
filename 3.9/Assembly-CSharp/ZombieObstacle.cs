using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000769 RID: 1897
[Token(Token = "0x2000769")]
public class ZombieObstacle : Obstacle
{
	// Token: 0x06002698 RID: 9880 RVA: 0x000CA4D8 File Offset: 0x000C86D8
	[Token(Token = "0x6002698")]
	[Address(RVA = "0x636150", Offset = "0x634750", VA = "0x180636150", Slot = "7")]
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

	// Token: 0x06002699 RID: 9881 RVA: 0x000CA528 File Offset: 0x000C8728
	[Token(Token = "0x6002699")]
	[Address(RVA = "0x636270", Offset = "0x634870", VA = "0x180636270")]
	public ZombieObstacle()
	{
	}

	// Token: 0x040013A1 RID: 5025
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013A1")]
	public float theHealth;
}
