using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000466 RID: 1126
[Token(Token = "0x2000466")]
public class UltimateChomper : SuperChomper
{
	// Token: 0x17000105 RID: 261
	// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00073984 File Offset: 0x00071B84
	[Token(Token = "0x17000105")]
	private bool Legendary
	{
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x4800C0", Offset = "0x47E6C0", VA = "0x1804800C0")]
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
				UltimateChomper.<>c.<>9__5_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, func);
			int num = 0;
			return plant != num;
		}
	}

	// Token: 0x060014C8 RID: 5320 RVA: 0x000739D4 File Offset: 0x00071BD4
	[Token(Token = "0x60014C8")]
	[Address(RVA = "0x47F840", Offset = "0x47DE40", VA = "0x18047F840", Slot = "77")]
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

	// Token: 0x060014C9 RID: 5321 RVA: 0x00073AA0 File Offset: 0x00071CA0
	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x47FC20", Offset = "0x47E220", VA = "0x18047FC20", Slot = "26")]
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

	// Token: 0x060014CA RID: 5322 RVA: 0x00073AD0 File Offset: 0x00071CD0
	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x47F960", Offset = "0x47DF60", VA = "0x18047F960", Slot = "28")]
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

	// Token: 0x060014CB RID: 5323 RVA: 0x00073B34 File Offset: 0x00071D34
	[Token(Token = "0x60014CB")]
	[Address(RVA = "0x47F1D0", Offset = "0x47D7D0", VA = "0x18047F1D0", Slot = "73")]
	public override void BiteEvent()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num && !this.targetZombie.isMindControlled)
		{
			Zombie targetZombie2 = this.targetZombie;
			this.Bite(targetZombie2);
		}
		Vector2 pos = base.Pos;
		int num2 = this.zombieLayer;
		int num3 = 0;
		int num4 = 0;
		Collider2D[] array;
		if (num3 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				bool flag3;
				if (!flag2 || flag3)
				{
				}
			}
			num4++;
		}
		this.targetZombie = (ulong)0L;
		uint num5;
		GameAPP.PlaySound((int)num5, 0.5f, 1f);
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x00073BD8 File Offset: 0x00071DD8
	[Token(Token = "0x60014CC")]
	[Address(RVA = "0x47FE70", Offset = "0x47E470", VA = "0x18047FE70", Slot = "12")]
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

	// Token: 0x060014CD RID: 5325 RVA: 0x00073C20 File Offset: 0x00071E20
	[Token(Token = "0x60014CD")]
	[Address(RVA = "0x47F010", Offset = "0x47D610", VA = "0x18047F010", Slot = "76")]
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

	// Token: 0x060014CE RID: 5326 RVA: 0x00073CA4 File Offset: 0x00071EA4
	[Token(Token = "0x60014CE")]
	[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "57")]
	protected override bool OnStarUp()
	{
		return true;
	}

	// Token: 0x060014CF RID: 5327 RVA: 0x00073CB4 File Offset: 0x00071EB4
	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x47F770", Offset = "0x47DD70", VA = "0x18047F770")]
	private void CheatShoot()
	{
		UltimateChomper.<Shooting>d__14 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		<Shooting>d__.<>1__state = (int)((ulong)0L);
		<Shooting>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Shooting>d__);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x00073CF8 File Offset: 0x00071EF8
	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x47FD30", Offset = "0x47E330", VA = "0x18047FD30")]
	private IEnumerator Shooting()
	{
		UltimateChomper.<Shooting>d__14 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		<Shooting>d__.<>1__state = (int)((ulong)0L);
		<Shooting>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060014D1 RID: 5329 RVA: 0x00073D1C File Offset: 0x00071F1C
	[Token(Token = "0x60014D1")]
	[Address(RVA = "0x47FDA0", Offset = "0x47E3A0", VA = "0x18047FDA0")]
	private void SuperShoot()
	{
		UltimateChomper.<Shooting2>d__16 <Shooting2>d__;
		<Shooting2>d__.System.IDisposable.Dispose();
		<Shooting2>d__.<>1__state = (int)((ulong)0L);
		<Shooting2>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Shooting2>d__);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x00073D60 File Offset: 0x00071F60
	[Token(Token = "0x60014D2")]
	[Address(RVA = "0x47FCC0", Offset = "0x47E2C0", VA = "0x18047FCC0")]
	private IEnumerator Shooting2()
	{
		UltimateChomper.<Shooting2>d__16 <Shooting2>d__;
		<Shooting2>d__.System.IDisposable.Dispose();
		<Shooting2>d__.<>1__state = (int)((ulong)0L);
		<Shooting2>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x00073D84 File Offset: 0x00071F84
	[Token(Token = "0x60014D3")]
	[Address(RVA = "0x47F490", Offset = "0x47DA90", VA = "0x18047F490", Slot = "78")]
	protected override void Bite(Zombie zombie)
	{
		float attributeCountdown = this.attributeCountdown;
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
		float totalFirstHealth = zombie.TotalFirstHealth;
		Board board = this.board;
		int num4 = 0;
		int num5 = 0;
		float num6 = (float)(num4 * (int)0.001f);
		float num7 = num6 * 0.01f;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)6002)))
		{
		}
		PlantType thePlantType = this.thePlantType;
		ulong num8;
		zombie.TakeDamage(num5, this, (DamageType)((uint)1), thePlantType, num8 != 0UL);
		int num9 = 0;
		ulong num10;
		this.Recover(attributeCountdown, (DamageType)num9, true, num10 != 0UL);
		GameAPP.PlaySound(49, 0.5f, 1f);
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x00073E74 File Offset: 0x00072074
	[Token(Token = "0x60014D4")]
	[Address(RVA = "0x47FB10", Offset = "0x47E110", VA = "0x18047FB10", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x00073E94 File Offset: 0x00072094
	[Token(Token = "0x60014D5")]
	[Address(RVA = "0x4800A0", Offset = "0x47E6A0", VA = "0x1804800A0")]
	public UltimateChomper()
	{
	}

	// Token: 0x04000CD3 RID: 3283
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000CD3")]
	public bool eatRecover = true;

	// Token: 0x04000CD4 RID: 3284
	[FieldOffset(Offset = "0x241")]
	[Token(Token = "0x4000CD4")]
	private bool chomperUndead;

	// Token: 0x04000CD5 RID: 3285
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000CD5")]
	private float undeadTimer;

	// Token: 0x04000CD6 RID: 3286
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000CD6")]
	private float undeadCD = 10f;
}
