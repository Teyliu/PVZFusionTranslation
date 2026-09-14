using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C6 RID: 1478
[Token(Token = "0x20005C6")]
public class UltimateWinterMelon : Shooter
{
	// Token: 0x06001B8E RID: 7054 RVA: 0x00093954 File Offset: 0x00091B54
	[Token(Token = "0x6001B8E")]
	[Address(RVA = "0x4D5FA0", Offset = "0x4D45A0", VA = "0x1804D5FA0", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001B8F RID: 7055 RVA: 0x00093964 File Offset: 0x00091B64
	[Token(Token = "0x6001B8F")]
	[Address(RVA = "0x4D5F90", Offset = "0x4D4590", VA = "0x1804D5F90", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x06001B90 RID: 7056 RVA: 0x0009397C File Offset: 0x00091B7C
	[Token(Token = "0x6001B90")]
	[Address(RVA = "0x519460", Offset = "0x517A60", VA = "0x180519460", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.UpdateStage();
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x00093998 File Offset: 0x00091B98
	[Token(Token = "0x6001B91")]
	[Address(RVA = "0x519480", Offset = "0x517A80", VA = "0x180519480")]
	public void TrySummon()
	{
		UltimateWinterCloud instance = UltimateWinterCloud.Instance;
		int num = 0;
		if (instance == num && !this.summoning)
		{
			Animator anim = this.anim;
			this.summoning = true;
			anim.SetTrigger("summon");
		}
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x000939E0 File Offset: 0x00091BE0
	[Token(Token = "0x6001B92")]
	[Address(RVA = "0x518680", Offset = "0x516C80", VA = "0x180518680")]
	private void AnimSummon()
	{
		UltimateWinterCloud.SetCloud(this.melonSputter);
		UltimateWinterCloud instance = UltimateWinterCloud.Instance;
		PlantStatus theStatus = this.theStatus;
		instance.theStatus = theStatus;
		this.UpdateStage();
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x00093A18 File Offset: 0x00091C18
	[Token(Token = "0x6001B93")]
	[Address(RVA = "0x5195B0", Offset = "0x517BB0", VA = "0x1805195B0")]
	public void UpdateStage()
	{
		GameObject gameObject = this.stage2;
		this.theStatus = (PlantStatus)((ulong)35L);
		int num = 0;
		gameObject.SetActive(num != 0);
		GameObject gameObject2 = this.stage3_1;
		int num2 = 0;
		gameObject2.SetActive(num2 != 0);
		GameObject gameObject3 = this.stage3_2;
		this.theStatus = (PlantStatus)((ulong)36L);
		this.theStatus = (PlantStatus)((ulong)37L);
		gameObject3.SetActive(true);
		this.stage3_1.SetActive(true);
		this.stage3_2.SetActive(true);
		throw new NullReferenceException();
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x00093A90 File Offset: 0x00091C90
	[Token(Token = "0x6001B94")]
	[Address(RVA = "0x518FB0", Offset = "0x5175B0", VA = "0x180518FB0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		bool flag = base.Shootable();
		anim.SetBool("shooting", flag);
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x00093AE0 File Offset: 0x00091CE0
	[Token(Token = "0x6001B95")]
	[Address(RVA = "0x518750", Offset = "0x516D50", VA = "0x180518750")]
	private void ExtraShoot()
	{
		List<Zombie> allZombies = Lawnf.GetAllZombies(false);
		Func<Zombie, bool> <>9__11_ = UltimateWinterMelon.<>c.<>9__11_0;
		if (<>9__11_ == 0)
		{
			Func<Zombie, bool> func;
			UltimateWinterMelon.<>c.<>9__11_0 = func;
		}
		List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__11_));
		float attributeFloat = this.attributeFloat;
		int num = 0;
		int num2 = 0;
		if (attributeFloat > (float)num2)
		{
			Transform shoot = this.shoot;
			Zombie random = ListExtensions.GetRandom<Zombie>(list);
			CreateBullet instance = CreateBullet.Instance;
			Vector2 velocity = random.Velocity;
			Vector2 colliderPosition = random.ColliderPosition;
			float[] array;
			float num3 = array[0];
			Bullet bullet;
			bullet.Vx = num3;
			float num4 = array[1];
			bullet.Vy = num4;
			float num5 = array[1];
			bullet.detaVy = num5;
			int attackDamage = this.attackDamage;
			bullet.Damage = attackDamage;
			bullet.from = this;
			bool melonSputter = this.melonSputter;
			num++;
			bullet.melonSputter = melonSputter;
			PlantType thePlantType = this.thePlantType;
			bullet.fromType = thePlantType;
			float attributeFloat2 = this.attributeFloat;
		}
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x00093BDC File Offset: 0x00091DDC
	[Token(Token = "0x6001B96")]
	[Address(RVA = "0x519080", Offset = "0x517680", VA = "0x180519080", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		int num = 0;
		Zombie zombie;
		if (zombie != num)
		{
			Transform shoot2 = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			bool flag;
			if (flag)
			{
				Vector2 velocity = zombie.Velocity;
				Vector2 colliderPosition = zombie.ColliderPosition;
			}
			float[] array;
			float num2 = array[0];
			Bullet bullet;
			bullet.Vx = num2;
			float num3 = array[1];
			bullet.Vy = num3;
			float num4 = array[1];
			bullet.detaVy = num4;
			int attackDamage = this.attackDamage;
			bullet.Damage = attackDamage;
			bullet.from = this;
			bool melonSputter = this.melonSputter;
			bullet.melonSputter = melonSputter;
			PlantType thePlantType = this.thePlantType;
			bullet.fromType = thePlantType;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
			if (Lawnf.TravelUltimate((UltiBuff)((uint)41)))
			{
				bullet.theStatus = (BulletStatus)((ulong)9L);
			}
			float attributeFloat = this.attributeFloat;
			int num5 = 0;
			if (attributeFloat > (float)num5)
			{
				this.ExtraShoot();
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x00093CF0 File Offset: 0x00091EF0
	[Token(Token = "0x6001B97")]
	[Address(RVA = "0x518B50", Offset = "0x517150", VA = "0x180518B50")]
	private ValueTuple<float[], Plant> FindUmbrella(Vector2 startPosition)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			BoardGrid boardGrid;
			List<Plant> plants = boardGrid.plants;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num2 != 0);
		if (num2 == 0)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x00093D54 File Offset: 0x00091F54
	[Token(Token = "0x6001B98")]
	[Address(RVA = "0x5186F0", Offset = "0x516CF0", VA = "0x1805186F0")]
	private bool CheckZombie(Zombie zombie)
	{
		int thePlantRow = this.thePlantRow;
		if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus) && !zombie.beforeDying)
		{
			return zombie.theStatus != ZombieStatus.Dying;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x00093DA8 File Offset: 0x00091FA8
	[Token(Token = "0x6001B99")]
	[Address(RVA = "0x518EE0", Offset = "0x5174E0", VA = "0x180518EE0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x00093DC8 File Offset: 0x00091FC8
	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateWinterMelon()
	{
	}

	// Token: 0x04000EE2 RID: 3810
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EE2")]
	public GameObject stage2;

	// Token: 0x04000EE3 RID: 3811
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EE3")]
	public GameObject stage3_1;

	// Token: 0x04000EE4 RID: 3812
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000EE4")]
	public GameObject stage3_2;

	// Token: 0x04000EE5 RID: 3813
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000EE5")]
	public bool summoning;
}
