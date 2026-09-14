using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200062A RID: 1578
[Token(Token = "0x200062A")]
public class BlackFootballZombie_b : BlackFootballZombie_a
{
	// Token: 0x06001DDA RID: 7642 RVA: 0x000A0138 File Offset: 0x0009E338
	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x531BD0", Offset = "0x5301D0", VA = "0x180531BD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x000A0158 File Offset: 0x0009E358
	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x531B30", Offset = "0x530130", VA = "0x180531B30", Slot = "23")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		GameObject theFirstArmor = this.theFirstArmor;
		int num = 0;
		if (theFirstArmor != num)
		{
			float num2 = base.TotalFirstHealth * 0.05f;
			base.Recover(num2);
			this.attributeCountDown = 3f;
		}
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x000A01A0 File Offset: 0x0009E3A0
	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x000A01DC File Offset: 0x0009E3DC
	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x531AE0", Offset = "0x5300E0", VA = "0x180531AE0")]
	public BlackFootballZombie_b()
	{
	}
}
