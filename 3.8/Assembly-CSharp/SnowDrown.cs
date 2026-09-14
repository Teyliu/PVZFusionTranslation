using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C5 RID: 1733
[Token(Token = "0x20006C5")]
public class SnowDrown : DrownZombie
{
	// Token: 0x0600220C RID: 8716 RVA: 0x000B2D44 File Offset: 0x000B0F44
	[Token(Token = "0x600220C")]
	[Address(RVA = "0x56D8A0", Offset = "0x56BEA0", VA = "0x18056D8A0", Slot = "74")]
	protected override DrownProjectile GetDrownWeapon()
	{
		Transform shoot = this.shoot;
		GameObject gameObject = this.weaponPrefab;
		Vector3 vector;
		float z = vector.z;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		DrownProjectile drownProjectile = gameObject2.AddComponent<DrownProjectile>();
		int theZombieRow = this.theZombieRow;
		drownProjectile.theRow = theZombieRow;
		drownProjectile.cold = true;
		return drownProjectile;
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x000B2DA0 File Offset: 0x000B0FA0
	[Token(Token = "0x600220D")]
	[Address(RVA = "0x56D800", Offset = "0x56BE00", VA = "0x18056D800", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000B2DE0 File Offset: 0x000B0FE0
	[Token(Token = "0x600220E")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x000B2DFC File Offset: 0x000B0FFC
	[Token(Token = "0x600220F")]
	[Address(RVA = "0x550040", Offset = "0x54E640", VA = "0x180550040", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x000B2E18 File Offset: 0x000B1018
	[Token(Token = "0x6002210")]
	[Address(RVA = "0x548110", Offset = "0x546710", VA = "0x180548110")]
	public SnowDrown()
	{
	}

	// Token: 0x0400112B RID: 4395
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400112B")]
	public GameObject weaponPrefab;
}
