using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200073C RID: 1852
[Token(Token = "0x200073C")]
public class UltimatePaperZombie : Zombie
{
	// Token: 0x060024FE RID: 9470 RVA: 0x000C00C8 File Offset: 0x000BE2C8
	[Token(Token = "0x60024FE")]
	[Address(RVA = "0x604170", Offset = "0x602770", VA = "0x180604170", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.125f;
		this.theStatus = (ZombieStatus)((ulong)4L);
	}

	// Token: 0x060024FF RID: 9471 RVA: 0x000C00F0 File Offset: 0x000BE2F0
	[Token(Token = "0x60024FF")]
	[Address(RVA = "0x5FD9F0", Offset = "0x5FBFF0", VA = "0x1805FD9F0", Slot = "16")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x06002500 RID: 9472 RVA: 0x000C011C File Offset: 0x000BE31C
	[Token(Token = "0x6002500")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002501 RID: 9473 RVA: 0x000C012C File Offset: 0x000BE32C
	[Token(Token = "0x6002501")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06002502 RID: 9474 RVA: 0x000C014C File Offset: 0x000BE34C
	[Token(Token = "0x6002502")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x06002503 RID: 9475 RVA: 0x000C016C File Offset: 0x000BE36C
	[Token(Token = "0x6002503")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002504 RID: 9476 RVA: 0x000C0180 File Offset: 0x000BE380
	[Token(Token = "0x6002504")]
	[Address(RVA = "0x5DA980", Offset = "0x5D8F80", VA = "0x1805DA980", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002505 RID: 9477 RVA: 0x000C0190 File Offset: 0x000BE390
	[Token(Token = "0x6002505")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002506 RID: 9478 RVA: 0x000C01A0 File Offset: 0x000BE3A0
	[Token(Token = "0x6002506")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002507 RID: 9479 RVA: 0x000C01B0 File Offset: 0x000BE3B0
	[Token(Token = "0x6002507")]
	[Address(RVA = "0x604240", Offset = "0x602840", VA = "0x180604240", Slot = "29")]
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

	// Token: 0x06002508 RID: 9480 RVA: 0x000C0208 File Offset: 0x000BE408
	[Token(Token = "0x6002508")]
	[Address(RVA = "0x604040", Offset = "0x602640", VA = "0x180604040", Slot = "24")]
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

	// Token: 0x06002509 RID: 9481 RVA: 0x000C0274 File Offset: 0x000BE474
	[Token(Token = "0x6002509")]
	[Address(RVA = "0x603EB0", Offset = "0x6024B0", VA = "0x180603EB0")]
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

	// Token: 0x0600250A RID: 9482 RVA: 0x000C02C4 File Offset: 0x000BE4C4
	[Token(Token = "0x600250A")]
	[Address(RVA = "0x6048D0", Offset = "0x602ED0", VA = "0x1806048D0")]
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

	// Token: 0x0600250B RID: 9483 RVA: 0x000C0344 File Offset: 0x000BE544
	[Token(Token = "0x600250B")]
	[Address(RVA = "0x603C60", Offset = "0x602260", VA = "0x180603C60")]
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

	// Token: 0x0600250C RID: 9484 RVA: 0x000C03AC File Offset: 0x000BE5AC
	[Token(Token = "0x600250C")]
	[Address(RVA = "0x6041A0", Offset = "0x6027A0", VA = "0x1806041A0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600250D RID: 9485 RVA: 0x000C03EC File Offset: 0x000BE5EC
	[Token(Token = "0x600250D")]
	[Address(RVA = "0x604BA0", Offset = "0x6031A0", VA = "0x180604BA0", Slot = "75")]
	public override void KillByCaltrop()
	{
		this.anim.SetTrigger("stop");
		this.theSecondArmorHealth = (int)((ulong)1L);
	}

	// Token: 0x0600250E RID: 9486 RVA: 0x000C041C File Offset: 0x000BE61C
	[Token(Token = "0x600250E")]
	[Address(RVA = "0x604C20", Offset = "0x603220", VA = "0x180604C20", Slot = "66")]
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

	// Token: 0x0600250F RID: 9487 RVA: 0x000C04E0 File Offset: 0x000BE6E0
	[Token(Token = "0x600250F")]
	[Address(RVA = "0x604E70", Offset = "0x603470", VA = "0x180604E70", Slot = "35")]
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
							if (zombie2.takeDmgMultiplier == 0f)
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

	// Token: 0x06002510 RID: 9488 RVA: 0x000C068C File Offset: 0x000BE88C
	[Token(Token = "0x6002510")]
	[Address(RVA = "0x604400", Offset = "0x602A00", VA = "0x180604400", Slot = "63")]
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

	// Token: 0x06002511 RID: 9489 RVA: 0x000C07B0 File Offset: 0x000BE9B0
	[Token(Token = "0x6002511")]
	[Address(RVA = "0x604850", Offset = "0x602E50", VA = "0x180604850", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x000C07EC File Offset: 0x000BE9EC
	[Token(Token = "0x6002512")]
	[Address(RVA = "0x6055C0", Offset = "0x603BC0", VA = "0x1806055C0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x000C07FC File Offset: 0x000BE9FC
	[Token(Token = "0x6002513")]
	[Address(RVA = "0x5A6230", Offset = "0x5A4830", VA = "0x1805A6230", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
	}

	// Token: 0x06002514 RID: 9492 RVA: 0x000C0814 File Offset: 0x000BEA14
	[Token(Token = "0x6002514")]
	[Address(RVA = "0x5A6240", Offset = "0x5A4840", VA = "0x1805A6240", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		base.Buttered(time, true);
	}

	// Token: 0x06002515 RID: 9493 RVA: 0x000C082C File Offset: 0x000BEA2C
	[Token(Token = "0x6002515")]
	[Address(RVA = "0x5A6500", Offset = "0x5A4B00", VA = "0x1805A6500", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x000C0848 File Offset: 0x000BEA48
	[Token(Token = "0x6002516")]
	[Address(RVA = "0x6055F0", Offset = "0x603BF0", VA = "0x1806055F0")]
	public UltimatePaperZombie()
	{
	}

	// Token: 0x04001265 RID: 4709
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001265")]
	public Transform shoot2;

	// Token: 0x04001266 RID: 4710
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001266")]
	private bool a;
}
