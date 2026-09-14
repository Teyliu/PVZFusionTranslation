using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000674 RID: 1652
[Token(Token = "0x2000674")]
public class GoldGargantuar : Gargantuar
{
	// Token: 0x06001F8C RID: 8076 RVA: 0x000A7DA0 File Offset: 0x000A5FA0
	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected override void SetWeapon()
	{
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000A7DB0 File Offset: 0x000A5FB0
	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0x54C140", Offset = "0x54A740", VA = "0x18054C140", Slot = "77")]
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

	// Token: 0x06001F8E RID: 8078 RVA: 0x000A7DDC File Offset: 0x000A5FDC
	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x000A7DEC File Offset: 0x000A5FEC
	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0x54BDB0", Offset = "0x54A3B0", VA = "0x18054BDB0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num8;
		do
		{
			int num = 0;
			int num2 = this.theHealth;
			num2 -= theDamage;
			this.theHealth = num2;
			num2 -= theDamage;
			int num3 = this.theMaxHealth;
			num3 -= theDamage;
			if (num2 < num3 && !this.purified)
			{
				this.purified = true;
				int num4 = 0;
				bool flag = base.RemoveBuff((EffectType)num4);
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
				ulong num5;
				num5 += num5;
				this.anim.SetTrigger("rise");
			}
			float num6 = (float)(num * (int)0.01f);
			if (!this.pardoded)
			{
				this.pardoded = true;
				this.theHealth = num3;
			}
			List<Transform> changeSprites = this.changeSprites;
			bool flag14;
			if (flag14)
			{
				int num7 = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)num8, (float)num7, gameObject);
			}
		}
		while (num8 != (ulong)0L);
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x000A7F14 File Offset: 0x000A6114
	[Token(Token = "0x6001F90")]
	[Address(RVA = "0x54C320", Offset = "0x54A920", VA = "0x18054C320")]
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

	// Token: 0x06001F91 RID: 8081 RVA: 0x000A7FAC File Offset: 0x000A61AC
	[Token(Token = "0x6001F91")]
	[Address(RVA = "0x54C500", Offset = "0x54AB00", VA = "0x18054C500")]
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

	// Token: 0x06001F92 RID: 8082 RVA: 0x000A7FF0 File Offset: 0x000A61F0
	[Token(Token = "0x6001F92")]
	[Address(RVA = "0x54C210", Offset = "0x54A810", VA = "0x18054C210")]
	private void EndABigger()
	{
		if (this.bigger != (ulong)0L)
		{
			Coroutine coroutine = this.bigger;
			base.StopCoroutine(coroutine);
		}
		int num = this.theHealth;
		num += num;
		this.theHealth = num;
		int num2 = this.theMaxHealth;
		num2 += num2;
		this.theMaxHealth = num2;
		int num3 = this.theAttackDamage;
		num3 += num3;
		this.theAttackDamage = num3;
		base.UpdateHealthText();
		this.wudi = false;
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x000A805C File Offset: 0x000A625C
	[Token(Token = "0x6001F93")]
	[Address(RVA = "0x54BD40", Offset = "0x54A340", VA = "0x18054BD40")]
	private IEnumerator Bigger()
	{
		GoldGargantuar.<Bigger>d__13 <Bigger>d__;
		<Bigger>d__.System.IDisposable.Dispose();
		<Bigger>d__.<>1__state = (int)((ulong)0L);
		<Bigger>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x000A8080 File Offset: 0x000A6280
	[Token(Token = "0x6001F94")]
	[Address(RVA = "0x54BA00", Offset = "0x54A000", VA = "0x18054BA00")]
	private void AnimRise()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			if ("{il2cpp array field local6->}" != (ulong)1L)
			{
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

	// Token: 0x06001F95 RID: 8085 RVA: 0x000A8138 File Offset: 0x000A6338
	[Token(Token = "0x6001F95")]
	[Address(RVA = "0x54C0D0", Offset = "0x54A6D0", VA = "0x18054C0D0")]
	private IEnumerator CheckDie()
	{
		GoldGargantuar.<CheckDie>d__15 <CheckDie>d__;
		<CheckDie>d__.System.IDisposable.Dispose();
		<CheckDie>d__.<>1__state = (int)((ulong)0L);
		<CheckDie>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x000A815C File Offset: 0x000A635C
	[Token(Token = "0x6001F96")]
	[Address(RVA = "0x54C280", Offset = "0x54A880", VA = "0x18054C280", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		List<Zombie> list = this.zombies;
		if (!this.wudi)
		{
			int num;
			return num;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x000A8184 File Offset: 0x000A6384
	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x54B600", Offset = "0x549C00", VA = "0x18054B600", Slot = "76")]
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

	// Token: 0x06001F98 RID: 8088 RVA: 0x000A8228 File Offset: 0x000A6428
	[Token(Token = "0x6001F98")]
	[Address(RVA = "0x54C0B0", Offset = "0x54A6B0", VA = "0x18054C0B0", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		if (!this.purified)
		{
			base.Buttered(time, sprite);
			return;
		}
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x000A8248 File Offset: 0x000A6448
	[Token(Token = "0x6001F99")]
	[Address(RVA = "0x54C4C0", Offset = "0x54AAC0", VA = "0x18054C4C0", Slot = "49")]
	public override void SetJalaed()
	{
		if (!this.purified)
		{
			base.SetJalaed();
			return;
		}
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x000A8268 File Offset: 0x000A6468
	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x54C460", Offset = "0x54AA60", VA = "0x18054C460", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (!this.purified)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x000A8288 File Offset: 0x000A6488
	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0x54C4A0", Offset = "0x54AAA0", VA = "0x18054C4A0", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (!this.purified)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x000A82AC File Offset: 0x000A64AC
	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x54C4E0", Offset = "0x54AAE0", VA = "0x18054C4E0", Slot = "52")]
	public override void SetPoison(float time = 10f)
	{
		if (!this.purified)
		{
			base.SetPoison(time);
			return;
		}
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x000A82CC File Offset: 0x000A64CC
	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x54B5E0", Offset = "0x549BE0", VA = "0x18054B5E0", Slot = "53")]
	public override void AddPoisonLevel()
	{
		if (!this.purified)
		{
			base.AddPoisonLevel();
			return;
		}
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x000A82EC File Offset: 0x000A64EC
	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0x54C480", Offset = "0x54AA80", VA = "0x18054C480", Slot = "50")]
	public override void SetEmbered(bool ulti = false)
	{
		if (!this.purified)
		{
			base.SetEmbered(ulti);
			return;
		}
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x000A830C File Offset: 0x000A650C
	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x000A831C File Offset: 0x000A651C
	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x000A832C File Offset: 0x000A652C
	[Token(Token = "0x6001FA1")]
	[Address(RVA = "0x54C5A0", Offset = "0x54ABA0", VA = "0x18054C5A0")]
	public GoldGargantuar()
	{
		List<Zombie> list = new List();
		this.zombies = list;
		base..ctor();
	}

	// Token: 0x0400108D RID: 4237
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400108D")]
	private bool purified;

	// Token: 0x0400108E RID: 4238
	[FieldOffset(Offset = "0x261")]
	[Token(Token = "0x400108E")]
	private bool pardoded;

	// Token: 0x0400108F RID: 4239
	[FieldOffset(Offset = "0x262")]
	[Token(Token = "0x400108F")]
	private bool bigCrash;

	// Token: 0x04001090 RID: 4240
	[FieldOffset(Offset = "0x263")]
	[Token(Token = "0x4001090")]
	private bool wudi;

	// Token: 0x04001091 RID: 4241
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001091")]
	private readonly List<Zombie> zombies;

	// Token: 0x04001092 RID: 4242
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001092")]
	private Coroutine bigger;
}
