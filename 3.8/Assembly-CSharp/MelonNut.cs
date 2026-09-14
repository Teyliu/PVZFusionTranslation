using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003E4 RID: 996
[Token(Token = "0x20003E4")]
public class MelonNut : WallNut
{
	// Token: 0x06001261 RID: 4705 RVA: 0x000678E4 File Offset: 0x00065AE4
	[Token(Token = "0x6001261")]
	[Address(RVA = "0x453490", Offset = "0x451A90", VA = "0x180453490", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		int damage2 = base.GetDamage(damage);
		this.SaveDamage(damage);
		return damage2;
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x00067904 File Offset: 0x00065B04
	[Token(Token = "0x6001262")]
	[Address(RVA = "0x453880", Offset = "0x451E80", VA = "0x180453880", Slot = "70")]
	protected virtual void SaveDamage(int damage)
	{
		if (damage <= 100 || damage <= 500 || damage > 1000)
		{
		}
		int attributeCount = this.attributeCount;
		this.attributeCount = attributeCount;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.attributeCount = thePlantMaxHealth;
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x00067944 File Offset: 0x00065B44
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x453330", Offset = "0x451930", VA = "0x180453330", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			Zombie targetZombie = this.GetTargetZombie();
			int num = 0;
			if (targetZombie != num)
			{
				this.anim.SetTrigger("shoot");
				int attributeCount = this.attributeCount;
				this.theStatus = (PlantStatus)((ulong)33L);
				MelonNut.<GetTempShield>d__4 <GetTempShield>d__;
				<GetTempShield>d__.System.IDisposable.Dispose();
				<GetTempShield>d__.<>1__state = (int)((ulong)0L);
				<GetTempShield>d__.<>4__this = this;
				<GetTempShield>d__.value = attributeCount;
				Coroutine coroutine = base.StartCoroutine(<GetTempShield>d__);
			}
		}
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x000679C4 File Offset: 0x00065BC4
	[Token(Token = "0x6001264")]
	[Address(RVA = "0x453900", Offset = "0x451F00", VA = "0x180453900")]
	private void SearchUpdate()
	{
		Zombie targetZombie = this.GetTargetZombie();
		int num = 0;
		if (targetZombie != num)
		{
			this.anim.SetTrigger("shoot");
			int attributeCount = this.attributeCount;
			this.theStatus = (PlantStatus)((ulong)33L);
			MelonNut.<GetTempShield>d__4 <GetTempShield>d__;
			<GetTempShield>d__.System.IDisposable.Dispose();
			<GetTempShield>d__.<>1__state = (int)((ulong)0L);
			<GetTempShield>d__.<>4__this = this;
			<GetTempShield>d__.value = attributeCount;
			Coroutine coroutine = base.StartCoroutine(<GetTempShield>d__);
		}
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00067A34 File Offset: 0x00065C34
	[Token(Token = "0x6001265")]
	[Address(RVA = "0x453710", Offset = "0x451D10", VA = "0x180453710")]
	private IEnumerator GetTempShield(int value)
	{
		MelonNut.<GetTempShield>d__4 <GetTempShield>d__;
		<GetTempShield>d__.System.IDisposable.Dispose();
		<GetTempShield>d__.<>1__state = (int)((ulong)0L);
		<GetTempShield>d__.<>4__this = this;
		<GetTempShield>d__.value = value;
		return null;
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00067A60 File Offset: 0x00065C60
	[Token(Token = "0x6001266")]
	[Address(RVA = "0x453860", Offset = "0x451E60", VA = "0x180453860", Slot = "69")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
		base.OnTriggerStay2D(collision);
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x00067A78 File Offset: 0x00065C78
	[Token(Token = "0x6001267")]
	[Address(RVA = "0x4534D0", Offset = "0x451AD0", VA = "0x1804534D0")]
	private Zombie GetTargetZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				if (!Lawnf.InLandStatus((ZombieStatus)num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00067AE4 File Offset: 0x00065CE4
	[Token(Token = "0x6001268")]
	[Address(RVA = "0x453480", Offset = "0x451A80", VA = "0x180453480", Slot = "71")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_melon;
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00067AF4 File Offset: 0x00065CF4
	[Token(Token = "0x6001269")]
	[Address(RVA = "0x452F20", Offset = "0x451520", VA = "0x180452F20")]
	private void AnimShoot()
	{
		GameAPP.PlaySound(3, 5f, 1f);
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot3 = this.shoot;
		BulletType bulletType = this.GetBulletType();
		int num = 0;
		int attributeCount = this.attributeCount;
		Bullet bullet;
		bullet.Damage = attributeCount;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		this.attributeCount = num;
		base.UpdateText();
		Zombie targetZombie = this.GetTargetZombie();
		int num2 = 0;
		if (!(targetZombie != num2))
		{
			Board board = this.board;
			Mouse instance2 = Mouse.Instance;
			int columnNum = board.columnNum;
			float boxXFromColumn = instance2.GetBoxXFromColumn(columnNum);
			Mouse instance3 = Mouse.Instance;
			int thePlantRow = this.thePlantRow;
			float landY = instance3.GetLandY(boxXFromColumn, thePlantRow);
			float[] array;
			float num3 = array[0];
			bullet.Vx = num3;
			float num4 = array[1];
			bullet.Vy = num4;
			float num5 = array[1];
			bullet.detaVy = num5;
			return;
		}
		Vector2 velocity = targetZombie.Velocity;
		Vector2 colliderPosition = targetZombie.ColliderPosition;
		throw new NullReferenceException();
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00067C14 File Offset: 0x00065E14
	[Token(Token = "0x600126A")]
	[Address(RVA = "0x453790", Offset = "0x451D90", VA = "0x180453790", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x00067C34 File Offset: 0x00065E34
	[Token(Token = "0x600126B")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public MelonNut()
	{
	}
}
