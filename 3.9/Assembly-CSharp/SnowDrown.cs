using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FD RID: 1789
[Token(Token = "0x20006FD")]
public class SnowDrown : DrownZombie
{
	// Token: 0x06002327 RID: 8999 RVA: 0x000B7B38 File Offset: 0x000B5D38
	[Token(Token = "0x6002327")]
	[Address(RVA = "0x5D1560", Offset = "0x5CFB60", VA = "0x1805D1560", Slot = "76")]
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

	// Token: 0x06002328 RID: 9000 RVA: 0x000B7B94 File Offset: 0x000B5D94
	[Token(Token = "0x6002328")]
	[Address(RVA = "0x5D14C0", Offset = "0x5CFAC0", VA = "0x1805D14C0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x000B7BD4 File Offset: 0x000B5DD4
	[Token(Token = "0x6002329")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x000B7BF0 File Offset: 0x000B5DF0
	[Token(Token = "0x600232A")]
	[Address(RVA = "0x5B3BD0", Offset = "0x5B21D0", VA = "0x1805B3BD0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x0600232B RID: 9003 RVA: 0x000B7C0C File Offset: 0x000B5E0C
	[Token(Token = "0x600232B")]
	[Address(RVA = "0x5D16D0", Offset = "0x5CFCD0", VA = "0x1805D16D0")]
	public SnowDrown()
	{
	}

	// Token: 0x040011F9 RID: 4601
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011F9")]
	public GameObject weaponPrefab;
}
