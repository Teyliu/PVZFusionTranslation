using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000732 RID: 1842
[Token(Token = "0x2000732")]
public class UltimateHorse2 : Zombie
{
	// Token: 0x06002498 RID: 9368 RVA: 0x000BE4A8 File Offset: 0x000BC6A8
	[Token(Token = "0x6002498")]
	[Address(RVA = "0x588A00", Offset = "0x587000", VA = "0x180588A00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.1f;
	}

	// Token: 0x06002499 RID: 9369 RVA: 0x000BE4C8 File Offset: 0x000BC6C8
	[Token(Token = "0x6002499")]
	[Address(RVA = "0x5FEC00", Offset = "0x5FD200", VA = "0x1805FEC00", Slot = "20")]
	protected override void OverRangeDie()
	{
		Transform axis = this.axis;
		float deadRight = this.deadRight;
		Transform axis2 = this.axis;
		float deadLeft = this.deadLeft;
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x000BE4FC File Offset: 0x000BC6FC
	[Token(Token = "0x600249A")]
	[Address(RVA = "0x5FF3B0", Offset = "0x5FD9B0", VA = "0x1805FF3B0", Slot = "16")]
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

	// Token: 0x0600249B RID: 9371 RVA: 0x000BE540 File Offset: 0x000BC740
	[Token(Token = "0x600249B")]
	[Address(RVA = "0x5FEC90", Offset = "0x5FD290", VA = "0x1805FEC90", Slot = "45")]
	public override void PlayEatSound()
	{
		int num5;
		do
		{
			int num = 0;
			if ((this.reinforced ? 1 : 0) == num)
			{
				goto IL_013B;
			}
			if (!base.Alive)
			{
				return;
			}
			if ((this.reinforced ? 1 : 0) == num)
			{
				int theZombieRow = this.theZombieRow;
				List<Plant> plantsByRow = Lawnf.GetPlantsByRow(this.board, theZombieRow);
				Func<Plant, bool> func = delegate(Plant plant)
				{
					int num8 = base.Column;
					int thePlantColumn = plant.thePlantColumn;
					num8 -= thePlantColumn;
					bool flag4;
					if (!flag4)
					{
						return flag4;
					}
					return plant.plantTag == (ulong)0L;
				};
				if (Enumerable.Where<Plant>(plantsByRow, func) != 0)
				{
					bool flag;
					while (flag)
					{
					}
				}
				if ("{il2cpp array field local11->}" != (ulong)0L)
				{
				}
				if (num != 0)
				{
					goto IL_0154;
				}
			}
			int theZombieRow2 = this.theZombieRow;
			List<Plant> plantsByRow2 = Lawnf.GetPlantsByRow(this.board, theZombieRow2);
			Func<Plant, bool> func2 = delegate(Plant plant)
			{
				int num9 = base.Column;
				int thePlantColumn2 = plant.thePlantColumn;
				num9 -= thePlantColumn2;
				bool flag5;
				if (!flag5)
				{
					return flag5;
				}
				return plant.plantTag == (ulong)0L;
			};
			if (Enumerable.Where<Plant>(plantsByRow2, func2) != 0)
			{
				int num2 = 0;
				bool flag2;
				while (flag2)
				{
				}
				int num3 = this.theAttackDamage;
				num3 -= num2;
				int num4 = this.theAttackDamage;
				num4 += num4;
				base.Recover((float)num4);
			}
			if ("{il2cpp array field local31->}" != (ulong)0L)
			{
			}
			if (num != 0)
			{
				goto IL_0166;
			}
			num5 = 0;
			ulong num6;
			Func<Zombie, bool> func3;
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(Lawnf.GetZombiesByRow(num, num6 != 0UL), func3);
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
					goto IL_0121;
				}
				num5++;
			}
			bool flag3;
			while (!flag3)
			{
			}
			uint num7;
			num7 += num7;
			IL_0121:
			num7 += num7;
			if ("{il2cpp array field local53->}" != (ulong)0L)
			{
			}
		}
		while (num5 != 0);
		return;
		IL_013B:
		base.PlayEatSound();
		return;
		IL_0154:
		throw new NullReferenceException();
		IL_0166:
		throw new NullReferenceException();
	}

	// Token: 0x0600249C RID: 9372 RVA: 0x000BE6C8 File Offset: 0x000BC8C8
	[Token(Token = "0x600249C")]
	[Address(RVA = "0x5FF420", Offset = "0x5FDA20", VA = "0x1805FF420", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600249D RID: 9373 RVA: 0x000BE6D8 File Offset: 0x000BC8D8
	[Token(Token = "0x600249D")]
	[Address(RVA = "0x5FE580", Offset = "0x5FCB80", VA = "0x1805FE580", Slot = "24")]
	protected override void AttributeEvent()
	{
		int num = 0;
		this.SetMindControl(num);
		float theSpeed = this.theSpeed;
		if (0 > (int)theSpeed || theSpeed > 1f)
		{
		}
		this.anim.SetTrigger("shoot");
		GameObject theFirstArmor = this.theFirstArmor;
		int num2 = 0;
		if (theFirstArmor != num2 && this.reinforced)
		{
			base.Recover(200f);
		}
		int column = base.Column;
		if (this.reinforced)
		{
			int attributeCount = this.attributeCount;
			int num3 = attributeCount + 1;
			this.attributeCount = num3;
			if (attributeCount + 1 > 100)
			{
				this.attributeCount = (int)((ulong)0L);
				base.ChangeStatus((ZombieStatus)((uint)43));
				this.anim.SetTrigger("jump");
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}
		}
	}

	// Token: 0x0600249E RID: 9374 RVA: 0x000BE7AC File Offset: 0x000BC9AC
	[Token(Token = "0x600249E")]
	[Address(RVA = "0x5FEB40", Offset = "0x5FD140", VA = "0x1805FEB40")]
	private void JumpUpdate()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600249F RID: 9375 RVA: 0x000BE7D0 File Offset: 0x000BC9D0
	[Token(Token = "0x600249F")]
	[Address(RVA = "0x5FEA70", Offset = "0x5FD070", VA = "0x1805FEA70")]
	private void Impact(Vector2 center)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060024A0 RID: 9376 RVA: 0x000BE7F4 File Offset: 0x000BC9F4
	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x5FE7C0", Offset = "0x5FCDC0", VA = "0x1805FE7C0")]
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

	// Token: 0x060024A1 RID: 9377 RVA: 0x000BE868 File Offset: 0x000BCA68
	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x060024A2 RID: 9378 RVA: 0x000BE87C File Offset: 0x000BCA7C
	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x5FE3C0", Offset = "0x5FC9C0", VA = "0x1805FE3C0")]
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

	// Token: 0x060024A3 RID: 9379 RVA: 0x000BE8E0 File Offset: 0x000BCAE0
	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060024A4 RID: 9380 RVA: 0x000BE8F0 File Offset: 0x000BCAF0
	[Token(Token = "0x60024A4")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x000BE92C File Offset: 0x000BCB2C
	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060024A6 RID: 9382 RVA: 0x000BE93C File Offset: 0x000BCB3C
	[Token(Token = "0x60024A6")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060024A7 RID: 9383 RVA: 0x000BE94C File Offset: 0x000BCB4C
	[Token(Token = "0x60024A7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x060024A8 RID: 9384 RVA: 0x000BE95C File Offset: 0x000BCB5C
	[Token(Token = "0x60024A8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x000BE96C File Offset: 0x000BCB6C
	[Token(Token = "0x60024A9")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x000BE97C File Offset: 0x000BCB7C
	[Token(Token = "0x60024AA")]
	[Address(RVA = "0x5FF630", Offset = "0x5FDC30", VA = "0x1805FF630")]
	public UltimateHorse2()
	{
	}

	// Token: 0x0400124F RID: 4687
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400124F")]
	public bool reinforced;
}
