using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005FE RID: 1534
[Token(Token = "0x20005FE")]
public class WaterSpruce : SpruceShooter
{
	// Token: 0x06001CA2 RID: 7330 RVA: 0x00098BA8 File Offset: 0x00096DA8
	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0x56F500", Offset = "0x56DB00", VA = "0x18056F500", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		Bullet bullet;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001CA3 RID: 7331 RVA: 0x00098C0C File Offset: 0x00096E0C
	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0x56F3F0", Offset = "0x56D9F0", VA = "0x18056F3F0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_water_big;
	}

	// Token: 0x06001CA4 RID: 7332 RVA: 0x00098C2C File Offset: 0x00096E2C
	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0x56F430", Offset = "0x56DA30", VA = "0x18056F430", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x00098C4C File Offset: 0x00096E4C
	[Token(Token = "0x6001CA5")]
	[Address(RVA = "0x56F6E0", Offset = "0x56DCE0", VA = "0x18056F6E0", Slot = "24")]
	public override void UpdateText()
	{
		base.UpdateText();
		GameObject gameObject = this.ice;
		int num = 0;
		if (gameObject != num)
		{
			this.ice.SetActive(num != 0);
		}
	}

	// Token: 0x06001CA6 RID: 7334 RVA: 0x00098C84 File Offset: 0x00096E84
	[Token(Token = "0x6001CA6")]
	[Address(RVA = "0x4A12B0", Offset = "0x49F8B0", VA = "0x1804A12B0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x06001CA7 RID: 7335 RVA: 0x00098C94 File Offset: 0x00096E94
	[Token(Token = "0x6001CA7")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public WaterSpruce()
	{
	}

	// Token: 0x04000FB2 RID: 4018
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000FB2")]
	public GameObject ice;
}
