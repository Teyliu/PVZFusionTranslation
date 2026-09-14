using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200066A RID: 1642
[Token(Token = "0x200066A")]
public class FootballDolphin : Zombie
{
	// Token: 0x06001F4F RID: 8015 RVA: 0x000A6A88 File Offset: 0x000A4C88
	[Token(Token = "0x6001F4F")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000A6A98 File Offset: 0x000A4C98
	[Token(Token = "0x6001F50")]
	[Address(RVA = "0x547A90", Offset = "0x546090", VA = "0x180547A90", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		GameObject theFirstArmor = this.theFirstArmor;
		int num = 0;
		bool flag = theFirstArmor == num;
		if (!flag)
		{
			return flag;
		}
		return base.CanAttack(target);
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x000A6AC4 File Offset: 0x000A4CC4
	[Token(Token = "0x6001F51")]
	[Address(RVA = "0x547B20", Offset = "0x546120", VA = "0x180547B20", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Column > 1)
		{
			int column = base.Column;
			Transform transform = base.transform;
			GameObject theFirstArmor = this.theFirstArmor;
			int num = 0;
			if (theFirstArmor != num)
			{
				Transform transform2 = this.healthText.transform;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				transform2.rotation = identityQuaternion;
				int theFirstArmorMaxHealth = this.theFirstArmorMaxHealth;
				this.theFirstArmorHealth = theFirstArmorMaxHealth;
				this.FirstArmorBroken();
				base.UpdateHealthText();
			}
			this.towards = (Towards)((ulong)0L);
			return;
		}
		GameObject theFirstArmor2 = this.theFirstArmor;
		int num2 = 0;
		if (theFirstArmor2 != num2)
		{
			Transform transform3 = this.healthText.transform;
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			transform3.rotation = identityQuaternion2;
			int theFirstArmorMaxHealth2 = this.theFirstArmorMaxHealth;
			this.theFirstArmorHealth = theFirstArmorMaxHealth2;
			this.FirstArmorBroken();
			base.UpdateHealthText();
		}
		this.towards = (Towards)((ulong)1L);
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x000A6BB0 File Offset: 0x000A4DB0
	[Token(Token = "0x6001F52")]
	[Address(RVA = "0x547E50", Offset = "0x546450", VA = "0x180547E50")]
	public FootballDolphin()
	{
	}
}
