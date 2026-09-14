using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006AA RID: 1706
[Token(Token = "0x20006AA")]
public class GoldGargantuar : Gargantuar
{
	// Token: 0x0600208E RID: 8334 RVA: 0x000AC670 File Offset: 0x000AA870
	[Token(Token = "0x600208E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected override void SetWeapon()
	{
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x000AC680 File Offset: 0x000AA880
	[Token(Token = "0x600208F")]
	[Address(RVA = "0x5AE860", Offset = "0x5ACE60", VA = "0x1805AE860", Slot = "79")]
	protected override void CrashPlant(Plant plant, bool crash)
	{
		if (!crash)
		{
			plant.FlashOnce();
			return;
		}
		int num = 0;
		plant.Crashed(1, num, this);
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x000AC6AC File Offset: 0x000AA8AC
	[Token(Token = "0x6002090")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x000AC6BC File Offset: 0x000AA8BC
	[Token(Token = "0x6002091")]
	[Address(RVA = "0x5AE4B0", Offset = "0x5ACAB0", VA = "0x1805AE4B0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num7;
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			num -= (long)theDamage;
			long num2 = this.theMaxHealth;
			num2 -= (long)theDamage;
			if (num < num2 && !this.purified)
			{
				this.purified = true;
				int num3 = 0;
				bool flag = base.RemoveBuff((EffectType)num3);
				bool flag3;
				bool flag2 = flag3 + true;
				if (!flag)
				{
					flag2 = flag3;
				}
				bool flag4 = flag2 + true;
				bool flag5;
				if (!flag5)
				{
					flag4 = flag2;
				}
				bool flag6 = flag4 + true;
				bool flag7;
				if (!flag7)
				{
					flag6 = flag4;
				}
				bool flag8 = flag6 + true;
				bool flag9;
				if (!flag9)
				{
					flag8 = flag6;
				}
				bool flag10 = flag8 + true;
				bool flag11;
				if (!flag11)
				{
					flag10 = flag8;
				}
				bool flag12 = flag10 + true;
				bool flag13;
				if (!flag13)
				{
				}
				this.kelpTimes = (int)((ulong)0L);
				ulong num4;
				num4 += num4;
				this.anim.SetTrigger("rise");
			}
			int num5 = 0;
			if (0 * (int)0.01f > num5 && !this.pardoded)
			{
				this.pardoded = true;
				num = num2;
				this.theHealth = num;
			}
			List<Transform> changeSprites = this.changeSprites;
			bool flag14;
			if (flag14)
			{
				int num6 = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)0, (float)num6, gameObject);
			}
		}
		while (num7 != (ulong)0L);
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x000AC7EC File Offset: 0x000AA9EC
	[Token(Token = "0x6002092")]
	[Address(RVA = "0x5AEA50", Offset = "0x5AD050", VA = "0x1805AEA50")]
	private void PurifyDebuffs()
	{
		int num = 0;
		bool flag = base.RemoveBuff((EffectType)num);
		bool flag3;
		bool flag2 = flag3 + true;
		if (!flag)
		{
			flag2 = flag3;
		}
		bool flag4 = flag2 + true;
		bool flag5;
		if (!flag5)
		{
			flag4 = flag2;
		}
		bool flag6 = flag4 + true;
		bool flag7;
		if (!flag7)
		{
			flag6 = flag4;
		}
		bool flag8 = flag6 + true;
		bool flag9;
		if (!flag9)
		{
			flag8 = flag6;
		}
		bool flag10 = flag8 + true;
		bool flag11;
		if (!flag11)
		{
			flag10 = flag8;
		}
		bool flag12 = flag10 + true;
		bool flag13;
		if (!flag13)
		{
		}
		this.kelpTimes = (int)((ulong)0L);
		ulong num2;
		num2 += num2;
		this.anim.SetTrigger("rise");
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x000AC884 File Offset: 0x000AAA84
	[Token(Token = "0x6002093")]
	[Address(RVA = "0x5AEC40", Offset = "0x5AD240", VA = "0x1805AEC40")]
	private void StartBigger()
	{
		this.wudi = true;
		GoldGargantuar.<Bigger>d__13 <Bigger>d__;
		<Bigger>d__.System.IDisposable.Dispose();
		<Bigger>d__.<>1__state = (int)((ulong)0L);
		<Bigger>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Bigger>d__);
		this.bigger = coroutine;
		this.bigCrash = true;
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x000AC8C8 File Offset: 0x000AAAC8
	[Token(Token = "0x6002094")]
	[Address(RVA = "0x5AE930", Offset = "0x5ACF30", VA = "0x1805AE930")]
	private void EndABigger()
	{
		if (this.bigger != (ulong)0L)
		{
			Coroutine coroutine = this.bigger;
			base.StopCoroutine(coroutine);
		}
		long num = this.theHealth;
		num += num;
		this.theHealth = num;
		long num2 = this.theMaxHealth;
		num2 += num2;
		this.theMaxHealth = num2;
		int num3 = this.theAttackDamage;
		num3 += num3;
		this.theAttackDamage = num3;
		base.UpdateHealthText();
		this.wudi = false;
	}

	// Token: 0x06002095 RID: 8341 RVA: 0x000AC934 File Offset: 0x000AAB34
	[Token(Token = "0x6002095")]
	[Address(RVA = "0x5AE440", Offset = "0x5ACA40", VA = "0x1805AE440")]
	private IEnumerator Bigger()
	{
		GoldGargantuar.<Bigger>d__13 <Bigger>d__;
		<Bigger>d__.System.IDisposable.Dispose();
		<Bigger>d__.<>1__state = (int)((ulong)0L);
		<Bigger>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002096 RID: 8342 RVA: 0x000AC958 File Offset: 0x000AAB58
	[Token(Token = "0x6002096")]
	[Address(RVA = "0x5AE0E0", Offset = "0x5AC6E0", VA = "0x1805AE0E0")]
	private void AnimRise()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
			int num2 = 0;
			Zombie zombie;
			if (zombie != num2)
			{
				Zombie component = zombie.GetComponent<Zombie>();
				component.UpdateHealthText();
				List<Zombie> list = this.zombies;
				Transform axis2 = component.axis;
				ParticleManager instance2 = ParticleManager.Instance;
			}
			Board board2 = this.board;
			num++;
			uint num3;
			num3 += (uint)4;
		}
		GoldGargantuar.<CheckDie>d__15 <CheckDie>d__;
		<CheckDie>d__.System.IDisposable.Dispose();
		<CheckDie>d__.<>1__state = num;
		<CheckDie>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<CheckDie>d__);
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x000ACA08 File Offset: 0x000AAC08
	[Token(Token = "0x6002097")]
	[Address(RVA = "0x5AE7F0", Offset = "0x5ACDF0", VA = "0x1805AE7F0")]
	private IEnumerator CheckDie()
	{
		GoldGargantuar.<CheckDie>d__15 <CheckDie>d__;
		<CheckDie>d__.System.IDisposable.Dispose();
		<CheckDie>d__.<>1__state = (int)((ulong)0L);
		<CheckDie>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x000ACA2C File Offset: 0x000AAC2C
	[Token(Token = "0x6002098")]
	[Address(RVA = "0x5AE9B0", Offset = "0x5ACFB0", VA = "0x1805AE9B0", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		List<Zombie> list = this.zombies;
		if (!this.wudi)
		{
			long num;
			return num;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x000ACA54 File Offset: 0x000AAC54
	[Token(Token = "0x6002099")]
	[Address(RVA = "0x5ADCE0", Offset = "0x5AC2E0", VA = "0x1805ADCE0", Slot = "78")]
	protected override void AnimCrash()
	{
		int num;
		do
		{
			base.AnimCrash();
			if (!this.bigCrash)
			{
				return;
			}
			this.bigCrash = false;
			ParticleManager instance = ParticleManager.Instance;
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			num = 0;
			Board board = this.board;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
			if (num != 0)
			{
				goto IL_008E;
			}
			List<Plant> allPlants2 = Lawnf.GetAllPlants();
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num != 0);
		ScreenShake.TriggerShake(0.15f);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		return;
		IL_008E:
		throw new NullReferenceException();
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x000ACAF8 File Offset: 0x000AACF8
	[Token(Token = "0x600209A")]
	[Address(RVA = "0x5AE7D0", Offset = "0x5ACDD0", VA = "0x1805AE7D0", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		if (!this.purified)
		{
			base.Buttered(time, sprite);
			return;
		}
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x000ACB18 File Offset: 0x000AAD18
	[Token(Token = "0x600209B")]
	[Address(RVA = "0x5AEC00", Offset = "0x5AD200", VA = "0x1805AEC00", Slot = "51")]
	public override void SetJalaed()
	{
		if (!this.purified)
		{
			base.SetJalaed();
			return;
		}
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x000ACB38 File Offset: 0x000AAD38
	[Token(Token = "0x600209C")]
	[Address(RVA = "0x5AEBA0", Offset = "0x5AD1A0", VA = "0x1805AEBA0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (!this.purified)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x0600209D RID: 8349 RVA: 0x000ACB58 File Offset: 0x000AAD58
	[Token(Token = "0x600209D")]
	[Address(RVA = "0x5AEBE0", Offset = "0x5AD1E0", VA = "0x1805AEBE0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (!this.purified)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x000ACB7C File Offset: 0x000AAD7C
	[Token(Token = "0x600209E")]
	[Address(RVA = "0x5AEC20", Offset = "0x5AD220", VA = "0x1805AEC20", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
		if (!this.purified)
		{
			base.SetPoison(time);
			return;
		}
	}

	// Token: 0x0600209F RID: 8351 RVA: 0x000ACB9C File Offset: 0x000AAD9C
	[Token(Token = "0x600209F")]
	[Address(RVA = "0x5ADCC0", Offset = "0x5AC2C0", VA = "0x1805ADCC0", Slot = "55")]
	public override void AddPoisonLevel()
	{
		if (!this.purified)
		{
			base.AddPoisonLevel();
			return;
		}
	}

	// Token: 0x060020A0 RID: 8352 RVA: 0x000ACBBC File Offset: 0x000AADBC
	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x5AEBC0", Offset = "0x5AD1C0", VA = "0x1805AEBC0", Slot = "52")]
	public override void SetEmbered(bool ulti = false)
	{
		if (!this.purified)
		{
			base.SetEmbered(ulti);
			return;
		}
	}

	// Token: 0x060020A1 RID: 8353 RVA: 0x000ACBDC File Offset: 0x000AADDC
	[Token(Token = "0x60020A1")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x000ACBEC File Offset: 0x000AADEC
	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060020A3 RID: 8355 RVA: 0x000ACBFC File Offset: 0x000AADFC
	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x5AECE0", Offset = "0x5AD2E0", VA = "0x1805AECE0")]
	public GoldGargantuar()
	{
		List<Zombie> list = new List();
		this.zombies = list;
		base..ctor();
	}

	// Token: 0x0400115A RID: 4442
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400115A")]
	private bool purified;

	// Token: 0x0400115B RID: 4443
	[FieldOffset(Offset = "0x281")]
	[Token(Token = "0x400115B")]
	private bool pardoded;

	// Token: 0x0400115C RID: 4444
	[FieldOffset(Offset = "0x282")]
	[Token(Token = "0x400115C")]
	private bool bigCrash;

	// Token: 0x0400115D RID: 4445
	[FieldOffset(Offset = "0x283")]
	[Token(Token = "0x400115D")]
	private bool wudi;

	// Token: 0x0400115E RID: 4446
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400115E")]
	private readonly List<Zombie> zombies;

	// Token: 0x0400115F RID: 4447
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400115F")]
	private Coroutine bigger;
}
