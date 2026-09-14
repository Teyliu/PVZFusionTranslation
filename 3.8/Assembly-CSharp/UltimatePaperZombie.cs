using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000704 RID: 1796
[Token(Token = "0x2000704")]
public class UltimatePaperZombie : Zombie
{
	// Token: 0x060023E3 RID: 9187 RVA: 0x000BB4A4 File Offset: 0x000B96A4
	[Token(Token = "0x60023E3")]
	[Address(RVA = "0x58B340", Offset = "0x589940", VA = "0x18058B340", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.125f;
		this.theStatus = (ZombieStatus)((ulong)4L);
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x000BB4CC File Offset: 0x000B96CC
	[Token(Token = "0x60023E4")]
	[Address(RVA = "0x5824D0", Offset = "0x580AD0", VA = "0x1805824D0", Slot = "15")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x000BB4F8 File Offset: 0x000B96F8
	[Token(Token = "0x60023E5")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x000BB508 File Offset: 0x000B9708
	[Token(Token = "0x60023E6")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x000BB528 File Offset: 0x000B9728
	[Token(Token = "0x60023E7")]
	[Address(RVA = "0x533270", Offset = "0x531870", VA = "0x180533270", Slot = "27")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x000BB548 File Offset: 0x000B9748
	[Token(Token = "0x60023E8")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x000BB564 File Offset: 0x000B9764
	[Token(Token = "0x60023E9")]
	[Address(RVA = "0x5773F0", Offset = "0x5759F0", VA = "0x1805773F0", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x000BB574 File Offset: 0x000B9774
	[Token(Token = "0x60023EA")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x000BB584 File Offset: 0x000B9784
	[Token(Token = "0x60023EB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x000BB594 File Offset: 0x000B9794
	[Token(Token = "0x60023EC")]
	[Address(RVA = "0x58B5B0", Offset = "0x589BB0", VA = "0x18058B5B0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x000BB5EC File Offset: 0x000B97EC
	[Token(Token = "0x60023ED")]
	[Address(RVA = "0x58B210", Offset = "0x589810", VA = "0x18058B210", Slot = "23")]
	protected override void AttributeEvent()
	{
		float theSpeed = this.theSpeed;
		if (0 > (int)theSpeed || theSpeed > 1f)
		{
		}
		this.anim.SetTrigger("shoot");
		Plant targetPlant = this.GetTargetPlant();
		int num = 0;
		if (targetPlant != num)
		{
			Animator anim = this.anim;
			this.attributeCount = (int)((ulong)0L);
			anim.SetTrigger("shoot2");
			return;
		}
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x000BB658 File Offset: 0x000B9858
	[Token(Token = "0x60023EE")]
	[Address(RVA = "0x58B080", Offset = "0x589680", VA = "0x18058B080")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.shootByZombie = true;
		bullet.Damage = 300;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x000BB6A8 File Offset: 0x000B98A8
	[Token(Token = "0x60023EF")]
	[Address(RVA = "0x58BC40", Offset = "0x58A240", VA = "0x18058BC40")]
	private Plant GetTargetPlant()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int theZombieRow = this.theZombieRow;
				bool flag2;
				while (flag2)
				{
				}
				Transform axis = this.axis;
				Transform axis2 = this.axis;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x000BB728 File Offset: 0x000B9928
	[Token(Token = "0x60023F0")]
	[Address(RVA = "0x58AE30", Offset = "0x589430", VA = "0x18058AE30")]
	private void AnimShoot2()
	{
		Plant targetPlant = this.GetTargetPlant();
		int num = 0;
		if (targetPlant != num)
		{
			Transform transform = this.shoot2;
			Vector3 vector;
			float z = vector.z;
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 60;
			int num2 = 0;
			bullet.shootByZombie = true;
			GameAPP.PlaySound(num2, 0.5f, 1f);
		}
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x000BB790 File Offset: 0x000B9990
	[Token(Token = "0x60023F1")]
	[Address(RVA = "0x58B510", Offset = "0x589B10", VA = "0x18058B510", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x000BB7D0 File Offset: 0x000B99D0
	[Token(Token = "0x60023F2")]
	[Address(RVA = "0x58BF10", Offset = "0x58A510", VA = "0x18058BF10", Slot = "73")]
	public override void KillByCaltrop()
	{
		this.anim.SetTrigger("stop");
		this.theSecondArmorHealth = (int)((ulong)1L);
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x000BB800 File Offset: 0x000B9A00
	[Token(Token = "0x60023F3")]
	[Address(RVA = "0x58BF90", Offset = "0x58A590", VA = "0x18058BF90", Slot = "64")]
	protected override void SecondArmorBroken()
	{
		bool flag;
		if (!flag)
		{
			SpriteRenderer component = this.theSecondArmor.GetComponent<SpriteRenderer>();
			int num = 0;
			component.enabled = num != 0;
			uint num2;
			ulong num3;
			this.theSecondArmor.transform.GetChild((int)num2).gameObject.SetActive(num3 != 0UL);
			Transform transform = this.theSecondArmor.transform;
			int num4 = 0;
			GameObject gameObject = transform.GetChild(num4).gameObject;
			int num5 = 0;
			gameObject.SetActive(num5 != 0);
			return;
		}
		SpriteRenderer component2 = this.theSecondArmor.GetComponent<SpriteRenderer>();
		int num6 = 0;
		component2.enabled = num6 != 0;
		Transform transform2 = this.theSecondArmor.transform;
		int num7 = 0;
		ulong num8;
		transform2.GetChild(num7).gameObject.SetActive(num8 != 0UL);
		Transform transform3 = this.theSecondArmor.transform;
		throw new NullReferenceException();
	}

	// Token: 0x060023F4 RID: 9204 RVA: 0x000BB8C4 File Offset: 0x000B9AC4
	[Token(Token = "0x60023F4")]
	[Address(RVA = "0x58C1E0", Offset = "0x58A7E0", VA = "0x18058C1E0", Slot = "34")]
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
		int num4 = 0;
		uint num5;
		GameAPP.PlaySound((int)num5, 0.5f, 1f);
		if (num4 < 30)
		{
			int num6 = 0;
			Zombie zombie;
			if (zombie != num6)
			{
				int theZombieType = (int)zombie.theZombieType;
				bool flag;
				if (!flag)
				{
					int theZombieType2 = (int)zombie.theZombieType;
					bool flag2;
					if (!flag2)
					{
						int theZombieType3 = (int)zombie.theZombieType;
						bool flag3;
						uint num7;
						if (!flag3 && zombie.theZombieType != (ZombieType)num7 && zombie.theZombieType != ZombieType.DoomPaper && zombie.BoxType != BoxType.Water)
						{
							CreateZombie instance = CreateZombie.Instance;
							Transform axis = zombie.axis;
							Zombie zombie2;
							if (zombie2.read == 0)
							{
							}
							Transform axis2 = zombie.axis;
							int num8 = 0;
							Zombie zombie3;
							if (zombie3 != num8)
							{
								zombie3.theSecondArmorHealth = num4;
								uint num9;
								zombie.Die((int)num9);
								num4++;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x000BBA68 File Offset: 0x000B9C68
	[Token(Token = "0x60023F5")]
	[Address(RVA = "0x58B770", Offset = "0x589D70", VA = "0x18058B770", Slot = "61")]
	protected override void FirstArmorBroken()
	{
		ulong num12;
		do
		{
			bool flag;
			if (flag)
			{
				List<Transform> changeSprites = this.changeSprites;
				bool flag2;
				if (flag2)
				{
					int num = 0;
					SpriteRenderer spriteRenderer;
					spriteRenderer.enabled = num != 0;
					int num2 = 0;
					Transform transform;
					ulong num3;
					transform.GetChild(num2).gameObject.SetActive(num3 != 0UL);
					Transform transform2;
					uint num4;
					GameObject gameObject = transform2.GetChild((int)num4).gameObject;
					int num5 = 0;
					gameObject.SetActive(num5 != 0);
				}
				ulong num6;
				if (num6 != (ulong)0L)
				{
					goto IL_00E6;
				}
			}
			List<Transform> changeSprites2 = this.changeSprites;
			bool flag3;
			if (flag3)
			{
				int num7 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num7 != 0;
				int num8 = 0;
				Transform transform3;
				ulong num9;
				transform3.GetChild(num8).gameObject.SetActive(num9 != 0UL);
				Transform transform4;
				uint num10;
				GameObject gameObject2 = transform4.GetChild((int)num10).gameObject;
				int num11 = 0;
				gameObject2.SetActive(num11 != 0);
			}
		}
		while (num12 != (ulong)0L);
		return;
		IL_00E6:
		throw new NullReferenceException();
	}

	// Token: 0x060023F6 RID: 9206 RVA: 0x000BBB8C File Offset: 0x000B9D8C
	[Token(Token = "0x60023F6")]
	[Address(RVA = "0x58BBC0", Offset = "0x58A1C0", VA = "0x18058BBC0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x060023F7 RID: 9207 RVA: 0x000BBBC8 File Offset: 0x000B9DC8
	[Token(Token = "0x60023F7")]
	[Address(RVA = "0x58C930", Offset = "0x58AF30", VA = "0x18058C930", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x000BBBD8 File Offset: 0x000B9DD8
	[Token(Token = "0x60023F8")]
	[Address(RVA = "0x543C10", Offset = "0x542210", VA = "0x180543C10", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
	}

	// Token: 0x060023F9 RID: 9209 RVA: 0x000BBBF0 File Offset: 0x000B9DF0
	[Token(Token = "0x60023F9")]
	[Address(RVA = "0x58B370", Offset = "0x589970", VA = "0x18058B370", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		ZombieType theZombieType = this.theZombieType;
		if (theZombieType > ZombieType.ZombieBoss2 && theZombieType > ZombieType.UltimateJacksonDriver)
		{
			if (theZombieType == ZombieType.CherrySubmarine || typeof(AdvantureConfig).TypeHandle <= (ulong)4L)
			{
				return;
			}
		}
		else
		{
			while (this == 0)
			{
			}
			if (this != 0)
			{
				while (this == 0)
				{
				}
				if (this != 0)
				{
					while (this == (ulong)1L)
					{
					}
				}
			}
		}
		ZombieStatus theStatus = this.theStatus;
		while (theStatus == ZombieStatus.Pol_jump)
		{
		}
		while (theStatus == ZombieStatus.Bungi_awake)
		{
		}
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
		bool flag2;
		while (!flag2)
		{
		}
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x000BBC60 File Offset: 0x000B9E60
	[Token(Token = "0x60023FA")]
	[Address(RVA = "0x543EE0", Offset = "0x5424E0", VA = "0x180543EE0", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x000BBC7C File Offset: 0x000B9E7C
	[Token(Token = "0x60023FB")]
	[Address(RVA = "0x58C960", Offset = "0x58AF60", VA = "0x18058C960")]
	public UltimatePaperZombie()
	{
	}

	// Token: 0x0400119B RID: 4507
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400119B")]
	public Transform shoot2;

	// Token: 0x0400119C RID: 4508
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400119C")]
	private bool a;
}
