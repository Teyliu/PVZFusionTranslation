using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A1 RID: 1697
[Token(Token = "0x20006A1")]
public class MiniSandMonster : Zombie
{
	// Token: 0x060020FF RID: 8447 RVA: 0x000AEB7C File Offset: 0x000ACD7C
	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x533DF0", Offset = "0x5323F0", VA = "0x180533DF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x000AEB8C File Offset: 0x000ACD8C
	[Token(Token = "0x6002100")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000AEB9C File Offset: 0x000ACD9C
	[Token(Token = "0x6002101")]
	[Address(RVA = "0x560C90", Offset = "0x55F290", VA = "0x180560C90")]
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
					return;
				}
				Physics2D.IgnoreCollision(this.col, collision);
			}
		}
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000AEBF4 File Offset: 0x000ACDF4
	[Token(Token = "0x6002102")]
	[Address(RVA = "0x560E90", Offset = "0x55F490", VA = "0x180560E90", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x000AEC04 File Offset: 0x000ACE04
	[Token(Token = "0x6002103")]
	[Address(RVA = "0x560F00", Offset = "0x55F500", VA = "0x180560F00")]
	public MiniSandMonster()
	{
	}

	// Token: 0x040010EE RID: 4334
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010EE")]
	private int restIgnore = (int)((ulong)3L);
}
