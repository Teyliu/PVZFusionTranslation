using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000486 RID: 1158
[Token(Token = "0x2000486")]
public class UltimateChomper : SuperChomper
{
	// Token: 0x1700014A RID: 330
	// (get) Token: 0x0600155A RID: 5466 RVA: 0x00075E40 File Offset: 0x00074040
	[Token(Token = "0x1700014A")]
	private bool Legendary
	{
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x4D8340", Offset = "0x4D6940", VA = "0x1804D8340")]
		get
		{
			bool flag;
			if (!flag)
			{
				return flag;
			}
			List<Plant> plantHead = this.board.boardEntity.plantHead;
			Func<Plant, bool> func;
			if (UltimateChomper.<>c.<>9__5_0 == 0)
			{
				func = (Plant p) => p.thePlantType == PlantType.UltimateTallNut || p.thePlantType == PlantType.UltimatePotatoNut;
				UltimateChomper.<>c.<>9__5_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, func);
			int num = 0;
			return plant != num;
		}
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x00075EA0 File Offset: 0x000740A0
	[Token(Token = "0x600155B")]
	[Address(RVA = "0x4D7AC0", Offset = "0x4D60C0", VA = "0x1804D7AC0", Slot = "77")]
	protected override void DecreaseHealth()
	{
		float num = this.undeadCD;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.undeadCD = num;
			this.undeadTimer = 0f;
			this.chomperUndead = true;
		}
		float num3 = this.undeadTimer;
		if (num3 > (float)num2)
		{
			float deltaTime2 = Time.deltaTime;
			this.undeadTimer = num3;
			this.undeadTimer = 0f;
			this.chomperUndead = false;
		}
		float timer = this.timer;
		float deltaTime3 = Time.deltaTime;
		this.timer = timer;
		if (num2 > (int)timer)
		{
			int thePlantMaxHealth = this.thePlantMaxHealth;
			this.timer = 1f;
			int num4 = this.thePlantHealth;
			num4 -= thePlantMaxHealth;
			this.thePlantHealth = num4;
			int thePlantMaxHealth2 = this.thePlantMaxHealth;
			this.thePlantHealth = thePlantMaxHealth2;
			base.UpdateText();
		}
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x00075F6C File Offset: 0x0007416C
	[Token(Token = "0x600155C")]
	[Address(RVA = "0x4D7EA0", Offset = "0x4D64A0", VA = "0x1804D7EA0", Slot = "25")]
	public override void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
		if (Lawnf.TravelUltimate(UltiBuff.嗜血如命))
		{
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)6001)))
		{
		}
		if (!this.eatRecover)
		{
		}
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x00075F9C File Offset: 0x0007419C
	[Token(Token = "0x600155D")]
	[Address(RVA = "0x4D7BE0", Offset = "0x4D61E0", VA = "0x1804D7BE0", Slot = "27")]
	protected override void LimHealth()
	{
		this.thePlantHealth = (int)((ulong)1000000000L);
		bool flag;
		if (flag)
		{
			List<Plant> plantHead = this.board.boardEntity.plantHead;
			Func<Plant, bool> func;
			if (UltimateChomper.<>c.<>9__5_0 == 0)
			{
				func = (Plant p) => p.thePlantType == PlantType.UltimateTallNut || p.thePlantType == PlantType.UltimatePotatoNut;
				UltimateChomper.<>c.<>9__5_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, func);
			int num = 0;
			if (plant != num)
			{
				return;
			}
		}
		base.LimHealth();
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x00076010 File Offset: 0x00074210
	[Token(Token = "0x600155E")]
	[Address(RVA = "0x4D7350", Offset = "0x4D5950", VA = "0x1804D7350", Slot = "73")]
	public override void BiteEvent()
	{
		int num = 0;
		Zombie targetZombie = this.targetZombie;
		int num2 = 0;
		if (targetZombie != num2 && (this.targetZombie.isMindControlled ? 1 : 0) == num)
		{
			Zombie targetZombie2 = this.targetZombie;
			this.Bite(targetZombie2);
		}
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		float chompRange = base.ChompRange;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				Zombie targetZombie3 = this.targetZombie;
				if (num != targetZombie3 && base.CheckZombie(num))
				{
					this.Bite(num);
				}
			}
			num++;
		}
		this.targetZombie = num;
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x000760D4 File Offset: 0x000742D4
	[Token(Token = "0x600155F")]
	[Address(RVA = "0x4D80F0", Offset = "0x4D66F0", VA = "0x1804D80F0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (this.chomperUndead)
		{
			this.thePlantHealth = (int)((ulong)1L);
			base.UpdateText();
			if (!this.chomperUndead)
			{
				this.undeadTimer = 5f;
				this.undeadCD = 10f;
			}
		}
	}

	// Token: 0x06001560 RID: 5472 RVA: 0x0007611C File Offset: 0x0007431C
	[Token(Token = "0x6001560")]
	[Address(RVA = "0x4D7190", Offset = "0x4D5790", VA = "0x1804D7190", Slot = "76")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		ulong num;
		num += num;
		Bullet bullet;
		bullet.Damage = (int)num;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		UltimateChomper.<Shooting>d__14 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		int num2 = 0;
		<Shooting>d__.<>4__this = this;
		<Shooting>d__.<>1__state = num2;
		Coroutine coroutine = base.StartCoroutine(<Shooting>d__);
		uint num3;
		uint num4;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num3, (int)num4), 0.5f, 1f);
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x000761A0 File Offset: 0x000743A0
	[Token(Token = "0x6001561")]
	[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "56")]
	protected override bool OnStarUp()
	{
		return true;
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x000761B0 File Offset: 0x000743B0
	[Token(Token = "0x6001562")]
	[Address(RVA = "0x4D79F0", Offset = "0x4D5FF0", VA = "0x1804D79F0")]
	private void CheatShoot()
	{
		UltimateChomper.<Shooting>d__14 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		<Shooting>d__.<>1__state = (int)((ulong)0L);
		<Shooting>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Shooting>d__);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x000761F4 File Offset: 0x000743F4
	[Token(Token = "0x6001563")]
	[Address(RVA = "0x4D7FB0", Offset = "0x4D65B0", VA = "0x1804D7FB0")]
	private IEnumerator Shooting()
	{
		UltimateChomper.<Shooting>d__14 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		<Shooting>d__.<>1__state = (int)((ulong)0L);
		<Shooting>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00076218 File Offset: 0x00074418
	[Token(Token = "0x6001564")]
	[Address(RVA = "0x4D8020", Offset = "0x4D6620", VA = "0x1804D8020")]
	private void SuperShoot()
	{
		UltimateChomper.<Shooting2>d__16 <Shooting2>d__;
		<Shooting2>d__.System.IDisposable.Dispose();
		<Shooting2>d__.<>1__state = (int)((ulong)0L);
		<Shooting2>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Shooting2>d__);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x0007625C File Offset: 0x0007445C
	[Token(Token = "0x6001565")]
	[Address(RVA = "0x4D7F40", Offset = "0x4D6540", VA = "0x1804D7F40")]
	private IEnumerator Shooting2()
	{
		UltimateChomper.<Shooting2>d__16 <Shooting2>d__;
		<Shooting2>d__.System.IDisposable.Dispose();
		<Shooting2>d__.<>1__state = (int)((ulong)0L);
		<Shooting2>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x00076280 File Offset: 0x00074480
	[Token(Token = "0x6001566")]
	[Address(RVA = "0x4D7710", Offset = "0x4D5D10", VA = "0x1804D7710", Slot = "78")]
	protected override void Bite(Zombie zombie)
	{
		if (zombie == 0)
		{
			int theZombieType = (int)zombie.theZombieType;
			bool flag;
			if (flag)
			{
			}
			zombie.Die(2);
			if (!Lawnf.TravelUltimate((UltiBuff)((uint)1)))
			{
			}
			base.AttributeCountdown = 15f;
			int num = 0;
			ulong num2;
			this.Recover(15f, (DamageType)num, true, num2 != 0UL);
			int num3 = 0;
			this.chomperUndead = true;
			this.undeadTimer = (float)num3;
			this.anim.SetTrigger("supershoot");
		}
		long totalFirstHealth = zombie.TotalFirstHealth;
		Board board = this.board;
		int num4 = 0;
		int num5 = 0;
		float num6 = (float)(num4 * (int)0.001f * (int)0.01f);
		float num7;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)6002)))
		{
			num7 = num6 * 1.5f;
		}
		PlantType thePlantType = this.thePlantType;
		ulong num8;
		zombie.TakeDamage(num5, this, (DamageType)((uint)1), thePlantType, num8 != 0UL);
		int num9 = 0;
		ulong num10;
		this.Recover(num7, (DamageType)num9, true, num10 != 0UL);
		GameAPP.PlaySound(49, 0.5f, 1f);
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x00076370 File Offset: 0x00074570
	[Token(Token = "0x6001567")]
	[Address(RVA = "0x4D7D90", Offset = "0x4D6390", VA = "0x1804D7D90", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x00076390 File Offset: 0x00074590
	[Token(Token = "0x6001568")]
	[Address(RVA = "0x4D8320", Offset = "0x4D6920", VA = "0x1804D8320")]
	public UltimateChomper()
	{
	}

	// Token: 0x04000D62 RID: 3426
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D62")]
	public bool eatRecover = true;

	// Token: 0x04000D63 RID: 3427
	[FieldOffset(Offset = "0x239")]
	[Token(Token = "0x4000D63")]
	private bool chomperUndead;

	// Token: 0x04000D64 RID: 3428
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000D64")]
	private float undeadTimer;

	// Token: 0x04000D65 RID: 3429
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000D65")]
	private float undeadCD = 10f;
}
