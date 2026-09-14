using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000465 RID: 1125
[Token(Token = "0x2000465")]
public class UltimateCannon : CobCannon
{
	// Token: 0x060014C0 RID: 5312 RVA: 0x00073764 File Offset: 0x00071964
	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x47ED00", Offset = "0x47D300", VA = "0x18047ED00", Slot = "70")]
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

	// Token: 0x060014C1 RID: 5313 RVA: 0x000737B0 File Offset: 0x000719B0
	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x47ECF0", Offset = "0x47D2F0", VA = "0x18047ECF0", Slot = "69")]
	protected override void FirstLoad()
	{
		base.AttributeCountdown = 1f;
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x000737C8 File Offset: 0x000719C8
	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x47E9E0", Offset = "0x47CFE0", VA = "0x18047E9E0", Slot = "71")]
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

	// Token: 0x060014C3 RID: 5315 RVA: 0x00073840 File Offset: 0x00071A40
	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x47EED0", Offset = "0x47D4D0", VA = "0x18047EED0", Slot = "16")]
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

	// Token: 0x060014C4 RID: 5316 RVA: 0x000738BC File Offset: 0x00071ABC
	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x47EDA0", Offset = "0x47D3A0", VA = "0x18047EDA0")]
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

	// Token: 0x060014C5 RID: 5317 RVA: 0x00073930 File Offset: 0x00071B30
	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x47EBB0", Offset = "0x47D1B0", VA = "0x18047EBB0", Slot = "72")]
	protected virtual void AnimSubShoot()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		Transform child = base.transform.GetChild(1);
		CreateBullet instance = CreateBullet.Instance;
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x00073970 File Offset: 0x00071B70
	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public UltimateCannon()
	{
	}
}
