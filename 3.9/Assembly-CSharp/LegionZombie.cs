using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D2 RID: 1746
[Token(Token = "0x20006D2")]
public class LegionZombie : Zombie
{
	// Token: 0x060021DA RID: 8666 RVA: 0x000B1FF8 File Offset: 0x000B01F8
	[Token(Token = "0x60021DA")]
	[Address(RVA = "0x5BFA10", Offset = "0x5BE010", VA = "0x1805BFA10", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)28L);
		this.isSplited = true;
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x000B201C File Offset: 0x000B021C
	[Token(Token = "0x60021DB")]
	[Address(RVA = "0x5C0B60", Offset = "0x5BF160", VA = "0x1805C0B60", Slot = "16")]
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

	// Token: 0x060021DC RID: 8668 RVA: 0x000B2110 File Offset: 0x000B0310
	[Token(Token = "0x60021DC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x000B2120 File Offset: 0x000B0320
	[Token(Token = "0x60021DD")]
	[Address(RVA = "0x5C0F40", Offset = "0x5BF540", VA = "0x1805C0F40", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060021DE RID: 8670 RVA: 0x000B213C File Offset: 0x000B033C
	[Token(Token = "0x60021DE")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x000B214C File Offset: 0x000B034C
	[Token(Token = "0x60021DF")]
	[Address(RVA = "0x5C0280", Offset = "0x5BE880", VA = "0x1805C0280", Slot = "28")]
	public override void Die(int reason = 0)
	{
		if (!this.CheckAllLegionFall() && reason == 0)
		{
			if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)21)))
			{
				base.ChangeStatus((ZombieStatus)((uint)27));
				this.anim.SetTrigger("fakeDie");
				this.theHealth = (long)((ulong)1L);
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

	// Token: 0x060021E0 RID: 8672 RVA: 0x000B2218 File Offset: 0x000B0418
	[Token(Token = "0x60021E0")]
	[Address(RVA = "0x5C0090", Offset = "0x5BE690", VA = "0x1805C0090")]
	private bool CheckAllLegionFall()
	{
		LegionZombie legionZombie = this.teammate;
		int num = 0;
		if (!(legionZombie != num))
		{
			List<Zombie> zombieHead = this.board.zombieHead;
			Func<Zombie, bool> func = delegate(Zombie z)
			{
				ZombieType theZombieType = this.theZombieType;
				if (z.theZombieType != theZombieType)
				{
				}
				return !z.isMindControlled;
			};
			Zombie zombie = Enumerable.FirstOrDefault<Zombie>(zombieHead, func);
			int num2 = 0;
			if (!(zombie != num2) || zombie.theStatus == ZombieStatus.Dying || zombie.theStatus == ZombieStatus.Legion_fall || !(zombie != this))
			{
			}
			return true;
		}
		LegionZombie legionZombie2 = this.teammate;
		throw new NullReferenceException();
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x000B229C File Offset: 0x000B049C
	[Token(Token = "0x60021E1")]
	[Address(RVA = "0x5BF920", Offset = "0x5BDF20", VA = "0x1805BF920", Slot = "24")]
	protected override void AttributeEvent()
	{
		if (!this.CheckAllLegionFall())
		{
			Animator anim = this.anim;
			this.theStatus = (ZombieStatus)((ulong)0L);
			anim.SetTrigger("rise");
			long theMaxHealth = this.theMaxHealth;
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

	// Token: 0x060021E2 RID: 8674 RVA: 0x000B2318 File Offset: 0x000B0518
	[Token(Token = "0x60021E2")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x000B2328 File Offset: 0x000B0528
	[Token(Token = "0x60021E3")]
	[Address(RVA = "0x5C0490", Offset = "0x5BEA90", VA = "0x1805C0490", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		base.KnockBack(x, reason);
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x000B2340 File Offset: 0x000B0540
	[Token(Token = "0x60021E4")]
	[Address(RVA = "0x5C04A0", Offset = "0x5BEAA0", VA = "0x1805C04A0", Slot = "66")]
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

	// Token: 0x060021E5 RID: 8677 RVA: 0x000B2434 File Offset: 0x000B0634
	[Token(Token = "0x60021E5")]
	[Address(RVA = "0x5BFA40", Offset = "0x5BE040", VA = "0x1805BFA40", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num24;
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			num -= (long)theDamage;
			long num2 = this.theMaxHealth;
			num2 += num2;
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
				goto IL_0173;
			}
			int num9 = 0;
			int num10 = 0;
			if (global::Core.Lawnf.ValueBetween((float)0, (float)num10, (float)num9))
			{
				List<Transform> changeSprites2 = this.changeSprites;
				bool flag2;
				if (flag2)
				{
					int num11 = 0;
					SpriteRenderer spriteRenderer2;
					spriteRenderer2.enabled = num11 != 0;
					int num12 = 0;
					Transform transform3;
					ulong num13;
					transform3.GetChild(num12).gameObject.SetActive(num13 != 0UL);
					Transform transform4;
					uint num14;
					GameObject gameObject3 = transform4.GetChild((int)num14).gameObject;
					int num15 = 0;
					gameObject3.SetActive(num15 != 0);
				}
				ulong num16;
				if (num16 != (ulong)0L)
				{
					goto IL_01A3;
				}
			}
			int num17 = 0;
			float num18;
			if (num18 <= (float)num17)
			{
				break;
			}
			bool flag3;
			if (flag3)
			{
				int num19 = 0;
				SpriteRenderer spriteRenderer3;
				spriteRenderer3.enabled = num19 != 0;
				int num20 = 0;
				Transform transform5;
				GameObject gameObject4 = transform5.GetChild(num20).gameObject;
				int num21 = 0;
				gameObject4.SetActive(num21 != 0);
				Transform transform6;
				uint num22;
				ulong num23;
				transform6.GetChild((int)num22).gameObject.SetActive(num23 != 0UL);
			}
		}
		while (num24 != (ulong)0L);
		return;
		IL_0173:
		throw new NullReferenceException();
		IL_01A3:
		throw new NullReferenceException();
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x000B2614 File Offset: 0x000B0814
	[Token(Token = "0x60021E6")]
	[Address(RVA = "0x5C0770", Offset = "0x5BED70", VA = "0x1805C0770", Slot = "35")]
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

	// Token: 0x060021E7 RID: 8679 RVA: 0x000B26F0 File Offset: 0x000B08F0
	[Token(Token = "0x60021E7")]
	[Address(RVA = "0x5BF830", Offset = "0x5BDE30", VA = "0x1805BF830")]
	private void AnimQuickMove()
	{
		Mouse instance = Mouse.Instance;
		Transform axis = this.axis;
		int num;
		this.startColumn = num;
		GameAPP.PlaySound(42, 0.3f, 1.6f);
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000B2738 File Offset: 0x000B0938
	[Token(Token = "0x60021E8")]
	[Address(RVA = "0x5BF580", Offset = "0x5BDB80", VA = "0x1805BF580")]
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
			List<Plant> list = global::Lawnf.Get1x1Plants(num4, theZombieRow);
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

	// Token: 0x060021E9 RID: 8681 RVA: 0x000B27D4 File Offset: 0x000B09D4
	[Token(Token = "0x60021E9")]
	[Address(RVA = "0x5BF500", Offset = "0x5BDB00", VA = "0x1805BF500")]
	private void AnimExplode()
	{
		LegionZombie.<DelayExplode>d__21 <DelayExplode>d__;
		<DelayExplode>d__.System.IDisposable.Dispose();
		<DelayExplode>d__.<>1__state = (int)((ulong)0L);
		<DelayExplode>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<DelayExplode>d__);
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x000B2800 File Offset: 0x000B0A00
	[Token(Token = "0x60021EA")]
	[Address(RVA = "0x5C0210", Offset = "0x5BE810", VA = "0x1805C0210")]
	private IEnumerator DelayExplode()
	{
		LegionZombie.<DelayExplode>d__21 <DelayExplode>d__;
		<DelayExplode>d__.System.IDisposable.Dispose();
		<DelayExplode>d__.<>1__state = (int)((ulong)0L);
		<DelayExplode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000B2824 File Offset: 0x000B0A24
	[Token(Token = "0x60021EB")]
	[Address(RVA = "0x5C0FB0", Offset = "0x5BF5B0", VA = "0x1805C0FB0")]
	public LegionZombie()
	{
	}

	// Token: 0x040011AA RID: 4522
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011AA")]
	public ParticleSystem particle;

	// Token: 0x040011AB RID: 4523
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011AB")]
	public bool leader;

	// Token: 0x040011AC RID: 4524
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x40011AC")]
	private int startColumn;

	// Token: 0x040011AD RID: 4525
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40011AD")]
	private int endColumn;

	// Token: 0x040011AE RID: 4526
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40011AE")]
	private LegionZombie teammate;
}
