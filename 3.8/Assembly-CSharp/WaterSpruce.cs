using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C9 RID: 1481
[Token(Token = "0x20005C9")]
public class WaterSpruce : SpruceShooter
{
	// Token: 0x06001BA3 RID: 7075 RVA: 0x00093FB4 File Offset: 0x000921B4
	[Token(Token = "0x6001BA3")]
	[Address(RVA = "0x519BB0", Offset = "0x5181B0", VA = "0x180519BB0", Slot = "69")]
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

	// Token: 0x06001BA4 RID: 7076 RVA: 0x00094018 File Offset: 0x00092218
	[Token(Token = "0x6001BA4")]
	[Address(RVA = "0x519AA0", Offset = "0x5180A0", VA = "0x180519AA0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_water_big;
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x00094038 File Offset: 0x00092238
	[Token(Token = "0x6001BA5")]
	[Address(RVA = "0x519AE0", Offset = "0x5180E0", VA = "0x180519AE0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x00094058 File Offset: 0x00092258
	[Token(Token = "0x6001BA6")]
	[Address(RVA = "0x519D90", Offset = "0x518390", VA = "0x180519D90", Slot = "25")]
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

	// Token: 0x06001BA7 RID: 7079 RVA: 0x00094090 File Offset: 0x00092290
	[Token(Token = "0x6001BA7")]
	[Address(RVA = "0x44CAF0", Offset = "0x44B0F0", VA = "0x18044CAF0", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x000940A0 File Offset: 0x000922A0
	[Token(Token = "0x6001BA8")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public WaterSpruce()
	{
	}

	// Token: 0x04000EEA RID: 3818
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EEA")]
	public GameObject ice;
}
