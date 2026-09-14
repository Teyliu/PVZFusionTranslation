using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000485 RID: 1157
[Token(Token = "0x2000485")]
public class UltimateCannon : CobCannon
{
	// Token: 0x06001553 RID: 5459 RVA: 0x00075C24 File Offset: 0x00073E24
	[Token(Token = "0x6001553")]
	[Address(RVA = "0x4D6E80", Offset = "0x4D5480", VA = "0x1804D6E80", Slot = "69")]
	public override void StartShoot()
	{
		this.anim.SetTrigger("shoot");
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.avaliable = false;
		base.AttributeCountdown = thePlantAttackInterval;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)15)))
		{
			float num;
			base.AttributeCountdown = num;
			return;
		}
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00075C70 File Offset: 0x00073E70
	[Token(Token = "0x6001554")]
	[Address(RVA = "0x4D6E70", Offset = "0x4D5470", VA = "0x1804D6E70", Slot = "68")]
	protected override void FirstLoad()
	{
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00075C88 File Offset: 0x00073E88
	[Token(Token = "0x6001555")]
	[Address(RVA = "0x4D6B60", Offset = "0x4D5160", VA = "0x1804D6B60", Slot = "70")]
	protected override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Mouse instance = Mouse.Instance;
		CreateBullet instance2 = CreateBullet.Instance;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		bullet.cannonPos = 0;
		bullet.cannonPos.y = (float)0;
		Board instance3 = Board.Instance;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00075D00 File Offset: 0x00073F00
	[Token(Token = "0x6001556")]
	[Address(RVA = "0x4D7050", Offset = "0x4D5650", VA = "0x1804D7050", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f) * 1.5f;
		this.thePlantAttackCountDown = num;
		GameObject gameObject = base.SearchZombie();
		int num2 = 0;
		if (!(gameObject != num2))
		{
			Zombie zombie = base.SearchBoss();
			int num3 = 0;
			if (!(zombie != num3))
			{
				return;
			}
		}
		this.anim.SetTrigger("subshoot");
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x00075D78 File Offset: 0x00073F78
	[Token(Token = "0x6001557")]
	[Address(RVA = "0x4D6F20", Offset = "0x4D5520", VA = "0x1804D6F20")]
	private void SubShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f) * 1.5f;
		this.thePlantAttackCountDown = num;
		GameObject gameObject = base.SearchZombie();
		int num2 = 0;
		if (!(gameObject != num2))
		{
			Zombie zombie = base.SearchBoss();
			int num3 = 0;
			if (!(zombie != num3))
			{
				return;
			}
		}
		this.anim.SetTrigger("subshoot");
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x00075DEC File Offset: 0x00073FEC
	[Token(Token = "0x6001558")]
	[Address(RVA = "0x4D6D30", Offset = "0x4D5330", VA = "0x1804D6D30", Slot = "71")]
	protected virtual void AnimSubShoot()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		Transform child = base.transform.GetChild(1);
		CreateBullet instance = CreateBullet.Instance;
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00075E2C File Offset: 0x0007402C
	[Token(Token = "0x6001559")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public UltimateCannon()
	{
	}
}
