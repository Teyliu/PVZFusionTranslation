using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200067C RID: 1660
[Token(Token = "0x200067C")]
public class HorseZombie : Zombie
{
	// Token: 0x06001FDB RID: 8155 RVA: 0x000A92EC File Offset: 0x000A74EC
	[Token(Token = "0x6001FDB")]
	[Address(RVA = "0x54F040", Offset = "0x54D640", VA = "0x18054F040")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
		int num2 = 0;
		if (plant != num2)
		{
			this.anim.SetTrigger("wait");
			this.theStatus = (ZombieStatus)((ulong)35L);
			GameAPP.PlaySound(141, 0.5f, 1f);
		}
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x000A934C File Offset: 0x000A754C
	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x000A935C File Offset: 0x000A755C
	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0x54EF80", Offset = "0x54D580", VA = "0x18054EF80", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		SuperHorse superHorse = this.superHorse;
		int num = 0;
		if (superHorse != num)
		{
		}
		int num2;
		return num2;
	}

	// Token: 0x06001FDE RID: 8158 RVA: 0x000A9380 File Offset: 0x000A7580
	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0x54EF20", Offset = "0x54D520", VA = "0x18054EF20", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(142, 0.5f, 1f);
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x000A93A4 File Offset: 0x000A75A4
	[Token(Token = "0x6001FDF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001FE0 RID: 8160 RVA: 0x000A93B4 File Offset: 0x000A75B4
	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0x54F140", Offset = "0x54D740", VA = "0x18054F140")]
	public HorseZombie()
	{
	}

	// Token: 0x040010B3 RID: 4275
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010B3")]
	public SuperHorse superHorse;
}
