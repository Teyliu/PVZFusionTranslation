using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C9 RID: 1737
[Token(Token = "0x20006C9")]
public class SnowNormalZombie : ConeZombie
{
	// Token: 0x0600222D RID: 8749 RVA: 0x000B36F4 File Offset: 0x000B18F4
	[Token(Token = "0x600222D")]
	[Address(RVA = "0x56FCF0", Offset = "0x56E2F0", VA = "0x18056FCF0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000B3734 File Offset: 0x000B1934
	[Token(Token = "0x600222E")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000B3744 File Offset: 0x000B1944
	[Token(Token = "0x600222F")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, fromFreeze);
			return;
		}
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x000B3760 File Offset: 0x000B1960
	[Token(Token = "0x6002230")]
	[Address(RVA = "0x56FD90", Offset = "0x56E390", VA = "0x18056FD90", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			base.SetFreeze(time, theFreezeLevel);
			return;
		}
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x000B377C File Offset: 0x000B197C
	[Token(Token = "0x6002231")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public SnowNormalZombie()
	{
	}
}
