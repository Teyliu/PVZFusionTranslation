using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200069B RID: 1691
[Token(Token = "0x200069B")]
public class LegionZombie : Zombie
{
	// Token: 0x060020C3 RID: 8387 RVA: 0x000AD3A0 File Offset: 0x000AB5A0
	[Token(Token = "0x60020C3")]
	[Address(RVA = "0x55CCD0", Offset = "0x55B2D0", VA = "0x18055CCD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)28L);
		this.isSplited = true;
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000AD3C4 File Offset: 0x000AB5C4
	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x55DE00", Offset = "0x55C400", VA = "0x18055DE00", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		if ((this.leader ? 1 : 0) != num)
		{
			this.theStatus = (ZombieStatus)((ulong)29L);
		}
		Board board = this.board;
		if (num < board.rowNum)
		{
			Transform axis = this.axis;
			ZombieType theZombieType = this.theZombieType;
			CreateZombie instance = CreateZombie.Instance;
			float num2 = global::UnityEngine.Random.Range(-1f, 1f);
			int num3 = 0;
			Zombie zombie;
			if (zombie != num3)
			{
				zombie.GetComponent<Zombie>().theStatus = (ZombieStatus)num;
			}
			num++;
			Board board2 = this.board;
			num++;
			Transform axis2 = this.axis;
			ZombieType theZombieType2 = this.theZombieType;
			CreateZombie instance2 = CreateZombie.Instance;
			num2 = global::UnityEngine.Random.Range(-1f, 1f);
			int num4 = 0;
			Zombie zombie2;
			if (zombie2 != num4)
			{
				LegionZombie component = zombie2.GetComponent<LegionZombie>();
				component.theStatus = (ZombieStatus)num;
				this.teammate = component;
				component.teammate = this;
			}
		}
		this.theStatus = (ZombieStatus)num;
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000AD4B8 File Offset: 0x000AB6B8
	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000AD4C8 File Offset: 0x000AB6C8
	[Token(Token = "0x60020C6")]
	[Address(RVA = "0x55E1E0", Offset = "0x55C7E0", VA = "0x18055E1E0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000AD4E4 File Offset: 0x000AB6E4
	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x000AD4F4 File Offset: 0x000AB6F4
	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x55D520", Offset = "0x55BB20", VA = "0x18055D520", Slot = "27")]
	public override void Die(int reason = 0)
	{
		if (!this.CheckAllLegionFall() && reason == 0)
		{
			if (Lawnf.TravelDebuff((TravelDebuff)((uint)21)))
			{
				base.ChangeStatus((ZombieStatus)((uint)27));
				this.anim.SetTrigger("fakeDie");
				this.theHealth = (int)((ulong)1L);
				this.attributeCountDown = 10f;
				base.UpdateHealthText();
				return;
			}
		}
		else if (reason == 3)
		{
			goto IL_006F;
		}
		LegionZombie legionZombie = this.teammate;
		int num = 0;
		if (!(legionZombie != num))
		{
			goto IL_0071;
		}
		this.teammate.Die(3);
		IL_006F:
		int num2 = 0;
		IL_0071:
		List<Transform> changeSprites = this.changeSprites;
		int num3 = 0;
		global::UnityEngine.Object.Destroy(changeSprites[num3].gameObject);
		List<Transform> changeSprites2 = this.changeSprites;
		int size = changeSprites2._size;
		changeSprites2._size = (int)((ulong)0L);
		if (size > 0)
		{
		}
		base.Die(num2);
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x000AD5C0 File Offset: 0x000AB7C0
	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x55D330", Offset = "0x55B930", VA = "0x18055D330")]
	private bool CheckAllLegionFall()
	{
		LegionZombie legionZombie = this.teammate;
		int num = 0;
		if (!(legionZombie != num))
		{
			Func<Zombie, bool> func;
			Zombie zombie = Enumerable.FirstOrDefault<Zombie>(this.board.zombieHead, func);
			int num2 = 0;
			if (!(zombie != num2) || zombie.theStatus == ZombieStatus.Dying || zombie.theStatus == ZombieStatus.Legion_fall || !(zombie != this))
			{
			}
			return true;
		}
		LegionZombie legionZombie2 = this.teammate;
		throw new NullReferenceException();
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x000AD630 File Offset: 0x000AB830
	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x55CBE0", Offset = "0x55B1E0", VA = "0x18055CBE0", Slot = "23")]
	protected override void AttributeEvent()
	{
		if (!this.CheckAllLegionFall())
		{
			Animator anim = this.anim;
			this.theStatus = (ZombieStatus)((ulong)0L);
			anim.SetTrigger("rise");
			int theMaxHealth = this.theMaxHealth;
			this.theHealth = theMaxHealth;
			base.KillDebuff();
			int num = 0;
			this.BodyTakeDamage(num);
			base.UpdateHealthText();
			this.attributeCountDown = 3f;
			return;
		}
		this.Die(3);
		this.attributeCountDown = 3f;
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x000AD6AC File Offset: 0x000AB8AC
	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x000AD6BC File Offset: 0x000AB8BC
	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x55D730", Offset = "0x55BD30", VA = "0x18055D730", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		base.KnockBack(x, reason);
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000AD6D4 File Offset: 0x000AB8D4
	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x55D740", Offset = "0x55BD40", VA = "0x18055D740", Slot = "64")]
	protected override void SecondArmorBroken()
	{
		GameObject theSecondArmor = this.theSecondArmor;
		bool flag;
		if (!flag)
		{
			ulong num;
			theSecondArmor.GetComponent<SpriteRenderer>().enabled = num != 0UL;
			Transform transform = this.theSecondArmor.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			SpriteRenderer spriteRenderer;
			spriteRenderer.enabled = num3 != 0;
			Transform transform2 = this.theSecondArmor.transform;
			int num4 = 0;
			GameObject gameObject2 = transform2.GetChild(num4).gameObject;
			int num5 = 0;
			gameObject2.SetActive(num5 != 0);
			uint num6;
			ulong num7;
			this.theSecondArmor.transform.GetChild((int)num6).gameObject.SetActive(num7 != 0UL);
			return;
		}
		SpriteRenderer component = theSecondArmor.GetComponent<SpriteRenderer>();
		int num8 = 0;
		component.enabled = num8 != 0;
		Transform transform3 = this.theSecondArmor.transform;
		int num9 = 0;
		ulong num10;
		transform3.GetChild(num9).gameObject.SetActive(num10 != 0UL);
		uint num11;
		GameObject gameObject3 = this.theSecondArmor.transform.GetChild((int)num11).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000AD7C8 File Offset: 0x000AB9C8
	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x55CD00", Offset = "0x55B300", VA = "0x18055CD00", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num20;
		do
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			int num2 = this.theMaxHealth;
			num2 += num2;
			num -= theDamage;
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				SpriteRenderer spriteRenderer;
				ulong num3;
				spriteRenderer.enabled = num3 != 0UL;
				int num4 = 0;
				Transform transform;
				GameObject gameObject = transform.GetChild(num4).gameObject;
				int num5 = 0;
				gameObject.SetActive(num5 != 0);
				Transform transform2;
				uint num6;
				GameObject gameObject2 = transform2.GetChild((int)num6).gameObject;
				int num7 = 0;
				gameObject2.SetActive(num7 != 0);
			}
			ulong num8;
			if (num8 != (ulong)0L)
			{
				goto IL_015C;
			}
			bool flag2;
			if (flag2)
			{
				List<Transform> changeSprites2 = this.changeSprites;
				bool flag3;
				if (flag3)
				{
					int num9 = 0;
					SpriteRenderer spriteRenderer2;
					spriteRenderer2.enabled = num9 != 0;
					int num10 = 0;
					Transform transform3;
					ulong num11;
					transform3.GetChild(num10).gameObject.SetActive(num11 != 0UL);
					Transform transform4;
					uint num12;
					GameObject gameObject3 = transform4.GetChild((int)num12).gameObject;
					int num13 = 0;
					gameObject3.SetActive(num13 != 0);
				}
				ulong num14;
				if (num14 != (ulong)0L)
				{
					goto IL_018C;
				}
			}
			bool flag4;
			if (flag4)
			{
				int num15 = 0;
				SpriteRenderer spriteRenderer3;
				spriteRenderer3.enabled = num15 != 0;
				int num16 = 0;
				Transform transform5;
				GameObject gameObject4 = transform5.GetChild(num16).gameObject;
				int num17 = 0;
				gameObject4.SetActive(num17 != 0);
				Transform transform6;
				uint num18;
				ulong num19;
				transform6.GetChild((int)num18).gameObject.SetActive(num19 != 0UL);
			}
		}
		while (num20 != (ulong)0L);
		return;
		IL_015C:
		throw new NullReferenceException();
		IL_018C:
		throw new NullReferenceException();
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x000AD994 File Offset: 0x000ABB94
	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x55DA10", Offset = "0x55C010", VA = "0x18055DA10", Slot = "34")]
	protected override void SecondArmorFall()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				GameObject gameObject;
				ulong num2;
				gameObject.SetActive(num2 != 0UL);
				GameObject gameObject2;
				ParticleSystemRenderer component = gameObject2.GetComponent<ParticleSystemRenderer>();
				int theZombieRow = this.theZombieRow;
				string text2 = string.Format("zombie{0}", component);
				component.sortingLayerName = text2;
				GameObject gameObject3;
				ParticleSystemRenderer component2 = gameObject3.GetComponent<ParticleSystemRenderer>();
				int num3 = this.sortingGroup.sortingOrder + 1;
				component2.sortingOrder = num3;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x000ADA70 File Offset: 0x000ABC70
	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x55CAF0", Offset = "0x55B0F0", VA = "0x18055CAF0")]
	private void AnimQuickMove()
	{
		Mouse instance = Mouse.Instance;
		Transform axis = this.axis;
		int num;
		this.startColumn = num;
		GameAPP.PlaySound(42, 0.3f, 1.6f);
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x000ADAB8 File Offset: 0x000ABCB8
	[Token(Token = "0x60020D1")]
	[Address(RVA = "0x55C840", Offset = "0x55AE40", VA = "0x18055C840")]
	private void AnimQuickMoveOver()
	{
		int num;
		int num2;
		do
		{
			num = 0;
			Mouse instance = Mouse.Instance;
			Transform axis = this.axis;
			this.endColumn = num2;
			int num3 = this.startColumn;
			if (num3 < num2)
			{
				num2 = num3;
			}
			int num4 = this.startColumn;
			int num5 = this.endColumn;
			if (num4 <= num5)
			{
			}
			int theZombieRow = this.theZombieRow;
			num4 = num2;
			List<Plant> list = Lawnf.Get1x1Plants(num4, theZombieRow);
			bool flag;
			if (flag)
			{
				int num6 = 0;
				Plant plant;
				if (plant != num6)
				{
					continue;
				}
			}
		}
		while (num != 0);
		num2++;
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x000ADB54 File Offset: 0x000ABD54
	[Token(Token = "0x60020D2")]
	[Address(RVA = "0x55C7C0", Offset = "0x55ADC0", VA = "0x18055C7C0")]
	private void AnimExplode()
	{
		LegionZombie.<DelayExplode>d__21 <DelayExplode>d__;
		<DelayExplode>d__.System.IDisposable.Dispose();
		<DelayExplode>d__.<>1__state = (int)((ulong)0L);
		<DelayExplode>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<DelayExplode>d__);
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x000ADB80 File Offset: 0x000ABD80
	[Token(Token = "0x60020D3")]
	[Address(RVA = "0x55D4B0", Offset = "0x55BAB0", VA = "0x18055D4B0")]
	private IEnumerator DelayExplode()
	{
		LegionZombie.<DelayExplode>d__21 <DelayExplode>d__;
		<DelayExplode>d__.System.IDisposable.Dispose();
		<DelayExplode>d__.<>1__state = (int)((ulong)0L);
		<DelayExplode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x000ADBA4 File Offset: 0x000ABDA4
	[Token(Token = "0x60020D4")]
	[Address(RVA = "0x55E250", Offset = "0x55C850", VA = "0x18055E250")]
	public LegionZombie()
	{
	}

	// Token: 0x040010DD RID: 4317
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010DD")]
	public ParticleSystem particle;

	// Token: 0x040010DE RID: 4318
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010DE")]
	public bool leader;

	// Token: 0x040010DF RID: 4319
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x40010DF")]
	private int startColumn;

	// Token: 0x040010E0 RID: 4320
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40010E0")]
	private int endColumn;

	// Token: 0x040010E1 RID: 4321
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40010E1")]
	private LegionZombie teammate;
}
