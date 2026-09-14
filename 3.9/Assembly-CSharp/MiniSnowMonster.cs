using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D9 RID: 1753
[Token(Token = "0x20006D9")]
public class MiniSnowMonster : Zombie
{
	// Token: 0x0600221B RID: 8731 RVA: 0x000B38BC File Offset: 0x000B1ABC
	[Token(Token = "0x600221B")]
	[Address(RVA = "0x58AAD0", Offset = "0x5890D0", VA = "0x18058AAD0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x000B38CC File Offset: 0x000B1ACC
	[Token(Token = "0x600221C")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x000B38E8 File Offset: 0x000B1AE8
	[Token(Token = "0x600221D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x000B38F8 File Offset: 0x000B1AF8
	[Token(Token = "0x600221E")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x000B3908 File Offset: 0x000B1B08
	[Token(Token = "0x600221F")]
	[Address(RVA = "0x5C3D10", Offset = "0x5C2310", VA = "0x1805C3D10")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Plant>(num))
		{
			int theZombieRow = this.theZombieRow;
			if (num == 0)
			{
				GameAPP.PlaySound(7, 0.5f, 1f);
				int num2 = this.theHealth.ToInt();
				int num3 = 0;
				base.Die(num3);
			}
		}
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x000B395C File Offset: 0x000B1B5C
	[Token(Token = "0x6002220")]
	[Address(RVA = "0x5C3C40", Offset = "0x5C2240", VA = "0x1805C3C40", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000B396C File Offset: 0x000B1B6C
	[Token(Token = "0x6002221")]
	[Address(RVA = "0x5C3EF0", Offset = "0x5C24F0", VA = "0x1805C3EF0")]
	public MiniSnowMonster()
	{
	}
}
