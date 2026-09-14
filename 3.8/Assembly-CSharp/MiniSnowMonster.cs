using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A2 RID: 1698
[Token(Token = "0x20006A2")]
public class MiniSnowMonster : Zombie
{
	// Token: 0x06002104 RID: 8452 RVA: 0x000AEC20 File Offset: 0x000ACE20
	[Token(Token = "0x6002104")]
	[Address(RVA = "0x533DF0", Offset = "0x5323F0", VA = "0x180533DF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000AEC30 File Offset: 0x000ACE30
	[Token(Token = "0x6002105")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x000AEC4C File Offset: 0x000ACE4C
	[Token(Token = "0x6002106")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x000AEC5C File Offset: 0x000ACE5C
	[Token(Token = "0x6002107")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000AEC6C File Offset: 0x000ACE6C
	[Token(Token = "0x6002108")]
	[Address(RVA = "0x560F60", Offset = "0x55F560", VA = "0x180560F60")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Plant>(num))
		{
			int theZombieRow = this.theZombieRow;
			if (num == 0)
			{
				GameAPP.PlaySound(7, 0.5f, 1f);
				int num2 = 0;
				base.Die(num2);
			}
		}
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x000AECB0 File Offset: 0x000ACEB0
	[Token(Token = "0x6002109")]
	[Address(RVA = "0x560E90", Offset = "0x55F490", VA = "0x180560E90", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000AECC0 File Offset: 0x000ACEC0
	[Token(Token = "0x600210A")]
	[Address(RVA = "0x561100", Offset = "0x55F700", VA = "0x180561100")]
	public MiniSnowMonster()
	{
	}
}
