using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D8 RID: 1752
[Token(Token = "0x20006D8")]
public class MiniSandMonster : Zombie
{
	// Token: 0x06002216 RID: 8726 RVA: 0x000B3818 File Offset: 0x000B1A18
	[Token(Token = "0x6002216")]
	[Address(RVA = "0x58AAD0", Offset = "0x5890D0", VA = "0x18058AAD0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x000B3828 File Offset: 0x000B1A28
	[Token(Token = "0x6002217")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000B3838 File Offset: 0x000B1A38
	[Token(Token = "0x6002218")]
	[Address(RVA = "0x5C3A10", Offset = "0x5C2010", VA = "0x1805C3A10")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Plant>(num))
		{
			int theZombieRow = this.theZombieRow;
			if (num == 0)
			{
				if (theZombieRow == 0 || this.restIgnore <= num)
				{
					GameAPP.PlaySound(7, 0.5f, 1f);
					throw new NullReferenceException();
				}
				Physics2D.IgnoreCollision(this.col, collision);
			}
		}
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x000B3890 File Offset: 0x000B1A90
	[Token(Token = "0x6002219")]
	[Address(RVA = "0x5C3C40", Offset = "0x5C2240", VA = "0x1805C3C40", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x000B38A0 File Offset: 0x000B1AA0
	[Token(Token = "0x600221A")]
	[Address(RVA = "0x5C3CB0", Offset = "0x5C22B0", VA = "0x1805C3CB0")]
	public MiniSandMonster()
	{
	}

	// Token: 0x040011BB RID: 4539
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011BB")]
	private int restIgnore = (int)((ulong)3L);
}
