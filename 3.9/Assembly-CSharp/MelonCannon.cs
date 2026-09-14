using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F9 RID: 1017
[Token(Token = "0x20003F9")]
public class MelonCannon : CobCannon
{
	// Token: 0x060012C1 RID: 4801 RVA: 0x00069174 File Offset: 0x00067374
	[Token(Token = "0x60012C1")]
	[Address(RVA = "0x4A77D0", Offset = "0x4A5DD0", VA = "0x1804A77D0", Slot = "70")]
	protected override void AnimShoot()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 1f, 1f);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Mouse instance2 = Mouse.Instance;
		BulletType bulletType = this.GetBulletType();
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		bullet.cannonPos = 0;
		bullet.cannonPos.y = (float)0;
		Board instance3 = Board.Instance;
		bullet.theStatus = (BulletStatus)((ulong)1L);
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00069214 File Offset: 0x00067414
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x4A7A60", Offset = "0x4A6060", VA = "0x1804A7A60", Slot = "71")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_melonCannon;
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00069224 File Offset: 0x00067424
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x4A7A10", Offset = "0x4A6010", VA = "0x1804A7A10", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("charge");
		this.avaliable = true;
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00069250 File Offset: 0x00067450
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public MelonCannon()
	{
	}
}
