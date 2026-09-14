using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003E3 RID: 995
[Token(Token = "0x20003E3")]
public class MelonCannon : CobCannon
{
	// Token: 0x0600125D RID: 4701 RVA: 0x000677F4 File Offset: 0x000659F4
	[Token(Token = "0x600125D")]
	[Address(RVA = "0x452C80", Offset = "0x451280", VA = "0x180452C80", Slot = "71")]
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

	// Token: 0x0600125E RID: 4702 RVA: 0x00067894 File Offset: 0x00065A94
	[Token(Token = "0x600125E")]
	[Address(RVA = "0x452F10", Offset = "0x451510", VA = "0x180452F10", Slot = "72")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_melonCannon;
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x000678A4 File Offset: 0x00065AA4
	[Token(Token = "0x600125F")]
	[Address(RVA = "0x452EC0", Offset = "0x4514C0", VA = "0x180452EC0", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("charge");
		this.avaliable = true;
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x000678D0 File Offset: 0x00065AD0
	[Token(Token = "0x6001260")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public MelonCannon()
	{
	}
}
