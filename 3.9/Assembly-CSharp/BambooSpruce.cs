using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E3 RID: 1251
[Token(Token = "0x20004E3")]
public class BambooSpruce : SpruceShooter
{
	// Token: 0x060017A2 RID: 6050 RVA: 0x00081578 File Offset: 0x0007F778
	[Token(Token = "0x60017A2")]
	[Address(RVA = "0x509300", Offset = "0x507900", VA = "0x180509300", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		bullet.from = this;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x000815EC File Offset: 0x0007F7EC
	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x509110", Offset = "0x507710", VA = "0x180509110")]
	public void CrashWithZombie(Zombie zombie)
	{
		if (zombie.theZombieType != ZombieType.UltimateSwordZombie)
		{
			long currentFirstHealth = zombie.CurrentFirstHealth;
			int thePlantHealth = this.thePlantHealth;
			int num = zombie.CurrentFirstHealth.ToInt();
			int num2 = 0;
			zombie.theHealth = (long)num2;
			zombie.theFirstArmorHealth = num2;
			zombie.theSecondArmorHealth = num2;
			int num3 = 0;
			zombie.Die(num3);
			PlantType thePlantType = this.thePlantType;
			base.UpdateText();
			base.FlashOnce();
		}
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x00081664 File Offset: 0x0007F864
	[Token(Token = "0x60017A4")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public BambooSpruce()
	{
	}
}
