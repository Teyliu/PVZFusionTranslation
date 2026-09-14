using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BE RID: 1214
[Token(Token = "0x20004BE")]
public class BambooSpruce : SpruceShooter
{
	// Token: 0x060016F4 RID: 5876 RVA: 0x0007E630 File Offset: 0x0007C830
	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x499FA0", Offset = "0x4985A0", VA = "0x180499FA0", Slot = "69")]
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

	// Token: 0x060016F5 RID: 5877 RVA: 0x0007E6A4 File Offset: 0x0007C8A4
	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x499E00", Offset = "0x498400", VA = "0x180499E00")]
	public void CrashWithZombie(Zombie zombie)
	{
		if (zombie.theZombieType != ZombieType.UltimateSwordZombie)
		{
			int currentFirstHealth = zombie.CurrentFirstHealth;
			int currentFirstHealth2 = zombie.CurrentFirstHealth;
			int num = 0;
			zombie.theHealth = num;
			zombie.theFirstArmorHealth = num;
			zombie.theSecondArmorHealth = num;
			int num2 = 0;
			zombie.Die(num2);
			PlantType thePlantType = this.thePlantType;
			base.UpdateText();
			base.FlashOnce();
		}
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x0007E710 File Offset: 0x0007C910
	[Token(Token = "0x60016F6")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public BambooSpruce()
	{
	}
}
