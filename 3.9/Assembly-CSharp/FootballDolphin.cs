using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A0 RID: 1696
[Token(Token = "0x20006A0")]
public class FootballDolphin : Zombie
{
	// Token: 0x06002050 RID: 8272 RVA: 0x000AB338 File Offset: 0x000A9538
	[Token(Token = "0x6002050")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x000AB348 File Offset: 0x000A9548
	[Token(Token = "0x6002051")]
	[Address(RVA = "0x5AA120", Offset = "0x5A8720", VA = "0x1805AA120", Slot = "13")]
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

	// Token: 0x06002052 RID: 8274 RVA: 0x000AB374 File Offset: 0x000A9574
	[Token(Token = "0x6002052")]
	[Address(RVA = "0x5AA1B0", Offset = "0x5A87B0", VA = "0x1805AA1B0", Slot = "18")]
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

	// Token: 0x06002053 RID: 8275 RVA: 0x000AB460 File Offset: 0x000A9660
	[Token(Token = "0x6002053")]
	[Address(RVA = "0x5AA4E0", Offset = "0x5A8AE0", VA = "0x1805AA4E0")]
	public FootballDolphin()
	{
	}
}
