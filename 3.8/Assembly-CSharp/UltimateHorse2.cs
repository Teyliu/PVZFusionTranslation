using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FA RID: 1786
[Token(Token = "0x20006FA")]
public class UltimateHorse2 : Zombie
{
	// Token: 0x0600237D RID: 9085 RVA: 0x000B98F0 File Offset: 0x000B7AF0
	[Token(Token = "0x600237D")]
	[Address(RVA = "0x531EB0", Offset = "0x5304B0", VA = "0x180531EB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.1f;
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x000B9910 File Offset: 0x000B7B10
	[Token(Token = "0x600237E")]
	[Address(RVA = "0x585E40", Offset = "0x584440", VA = "0x180585E40", Slot = "19")]
	protected override void OverRangeDie()
	{
		Transform axis = this.axis;
		float deadRight = this.deadRight;
		Transform axis2 = this.axis;
		float deadLeft = this.deadLeft;
	}

	// Token: 0x0600237F RID: 9087 RVA: 0x000B9944 File Offset: 0x000B7B44
	[Token(Token = "0x600237F")]
	[Address(RVA = "0x586470", Offset = "0x584A70", VA = "0x180586470", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)3021));
		this.reinforced = flag;
		if (!flag)
		{
			this.anim.Play("walk2");
			return;
		}
	}

	// Token: 0x06002380 RID: 9088 RVA: 0x000B9988 File Offset: 0x000B7B88
	[Token(Token = "0x6002380")]
	[Address(RVA = "0x585ED0", Offset = "0x5844D0", VA = "0x180585ED0", Slot = "43")]
	public override void PlayEatSound()
	{
		int num5;
		do
		{
			int num = 0;
			if ((this.reinforced ? 1 : 0) == num)
			{
				goto IL_00CE;
			}
			int theZombieRow = this.theZombieRow;
			Func<Plant, bool> func;
			if (Enumerable.Where<Plant>(Lawnf.GetPlantsByRow(this.board, theZombieRow), func) != 0)
			{
				int num2 = 0;
				bool flag;
				while (flag)
				{
				}
				int num3 = this.theAttackDamage;
				num3 -= num2;
				int num4 = this.theAttackDamage;
				num4 += num4;
				base.Recover((float)num4);
			}
			if ("{il2cpp array field local10->}" != (ulong)0L)
			{
			}
			if (num != 0)
			{
				goto IL_00E7;
			}
			num5 = 0;
			ulong num6;
			Func<Zombie, bool> func2;
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(Lawnf.GetZombiesByRow(num, num6 != 0UL), func2);
			if (num5 < typeof(IEnumerable<Zombie>).TypeHandle)
			{
				num5 += num5;
				num5++;
			}
			if (num5 < num5)
			{
				num5 += num5;
				if (num5 == 0)
				{
					goto IL_00B4;
				}
				num5++;
			}
			bool flag2;
			while (!flag2)
			{
			}
			uint num7;
			num7 += num7;
			IL_00B4:
			num7 += num7;
			if ("{il2cpp array field local32->}" != (ulong)0L)
			{
			}
		}
		while (num5 != 0);
		return;
		IL_00CE:
		base.PlayEatSound();
		return;
		IL_00E7:
		throw new NullReferenceException();
	}

	// Token: 0x06002381 RID: 9089 RVA: 0x000B9A90 File Offset: 0x000B7C90
	[Token(Token = "0x6002381")]
	[Address(RVA = "0x5864E0", Offset = "0x584AE0", VA = "0x1805864E0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06002382 RID: 9090 RVA: 0x000B9AA0 File Offset: 0x000B7CA0
	[Token(Token = "0x6002382")]
	[Address(RVA = "0x5857B0", Offset = "0x583DB0", VA = "0x1805857B0", Slot = "23")]
	protected override void AttributeEvent()
	{
		float theSpeed = this.theSpeed;
		if (0 > (int)theSpeed || theSpeed > 1f)
		{
		}
		this.anim.SetTrigger("shoot");
		GameObject theFirstArmor = this.theFirstArmor;
		int num = 0;
		if (theFirstArmor != num && this.reinforced)
		{
			base.Recover(200f);
		}
		Transform axis = this.axis;
		if (this.reinforced)
		{
			int attributeCount = this.attributeCount;
			int num2 = attributeCount + 1;
			this.attributeCount = num2;
			if (attributeCount + 1 > 100)
			{
				this.attributeCount = (int)((ulong)0L);
				this.theStatus = (ZombieStatus)((ulong)43L);
				this.anim.SetTrigger("jump");
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}
		}
	}

	// Token: 0x06002383 RID: 9091 RVA: 0x000B9B6C File Offset: 0x000B7D6C
	[Token(Token = "0x6002383")]
	[Address(RVA = "0x585D80", Offset = "0x584380", VA = "0x180585D80")]
	private void JumpUpdate()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002384 RID: 9092 RVA: 0x000B9B90 File Offset: 0x000B7D90
	[Token(Token = "0x6002384")]
	[Address(RVA = "0x585CB0", Offset = "0x5842B0", VA = "0x180585CB0")]
	private void Impact(Vector2 center)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002385 RID: 9093 RVA: 0x000B9BB4 File Offset: 0x000B7DB4
	[Token(Token = "0x6002385")]
	[Address(RVA = "0x585A00", Offset = "0x584000", VA = "0x180585A00")]
	private void CreateExplode(Vector2 center, float scale)
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		LayerMask plantLayer = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			LayerMask layerMask;
			int mask = layerMask.m_Mask;
			Particle particle;
			if (layerMask != 0 && particle.TryGetComponent<Plant>(num))
			{
				int num2 = 0;
				Plant plant;
				if (plant != num2)
				{
				}
				int num3 = this.theAttackDamage;
				num3 += num3;
				int num4 = num.System.IConvertible.ToInt32(num2);
			}
			num++;
		}
	}

	// Token: 0x06002386 RID: 9094 RVA: 0x000B9C28 File Offset: 0x000B7E28
	[Token(Token = "0x6002386")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06002387 RID: 9095 RVA: 0x000B9C44 File Offset: 0x000B7E44
	[Token(Token = "0x6002387")]
	[Address(RVA = "0x5855F0", Offset = "0x583BF0", VA = "0x1805855F0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Transform shoot2 = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			int num2 = 0;
			num2 += num2;
			Bullet bullet;
			bullet.Damage = num2;
			bullet.shootByZombie = true;
			GameAPP.PlaySound(num2, 0.5f, 1f);
		}
	}

	// Token: 0x06002388 RID: 9096 RVA: 0x000B9CA8 File Offset: 0x000B7EA8
	[Token(Token = "0x6002388")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002389 RID: 9097 RVA: 0x000B9CB8 File Offset: 0x000B7EB8
	[Token(Token = "0x6002389")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x0600238A RID: 9098 RVA: 0x000B9CF4 File Offset: 0x000B7EF4
	[Token(Token = "0x600238A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x0600238B RID: 9099 RVA: 0x000B9D04 File Offset: 0x000B7F04
	[Token(Token = "0x600238B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600238C RID: 9100 RVA: 0x000B9D14 File Offset: 0x000B7F14
	[Token(Token = "0x600238C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600238D RID: 9101 RVA: 0x000B9D24 File Offset: 0x000B7F24
	[Token(Token = "0x600238D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x0600238E RID: 9102 RVA: 0x000B9D34 File Offset: 0x000B7F34
	[Token(Token = "0x600238E")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600238F RID: 9103 RVA: 0x000B9D44 File Offset: 0x000B7F44
	[Token(Token = "0x600238F")]
	[Address(RVA = "0x586760", Offset = "0x584D60", VA = "0x180586760")]
	public UltimateHorse2()
	{
	}

	// Token: 0x04001185 RID: 4485
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001185")]
	public bool reinforced;
}
