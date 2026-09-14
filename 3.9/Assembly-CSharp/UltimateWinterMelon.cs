using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005F8 RID: 1528
[Token(Token = "0x20005F8")]
public class UltimateWinterMelon : Shooter
{
	// Token: 0x06001C81 RID: 7297 RVA: 0x000981E8 File Offset: 0x000963E8
	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x5368B0", Offset = "0x534EB0", VA = "0x1805368B0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001C82 RID: 7298 RVA: 0x000981F8 File Offset: 0x000963F8
	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x5368A0", Offset = "0x534EA0", VA = "0x1805368A0", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x00098210 File Offset: 0x00096410
	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x56E8A0", Offset = "0x56CEA0", VA = "0x18056E8A0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.UpdateStage();
	}

	// Token: 0x06001C84 RID: 7300 RVA: 0x0009822C File Offset: 0x0009642C
	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x56E8C0", Offset = "0x56CEC0", VA = "0x18056E8C0")]
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

	// Token: 0x06001C85 RID: 7301 RVA: 0x00098274 File Offset: 0x00096474
	[Token(Token = "0x6001C85")]
	[Address(RVA = "0x56DB60", Offset = "0x56C160", VA = "0x18056DB60")]
	private void AnimSummon()
	{
		UltimateWinterCloud.SetCloud(this.melonSputter);
		UltimateWinterCloud instance = UltimateWinterCloud.Instance;
		PlantStatus theStatus = this.theStatus;
		instance.theStatus = theStatus;
		this.UpdateStage();
	}

	// Token: 0x06001C86 RID: 7302 RVA: 0x000982AC File Offset: 0x000964AC
	[Token(Token = "0x6001C86")]
	[Address(RVA = "0x56E9F0", Offset = "0x56CFF0", VA = "0x18056E9F0")]
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

	// Token: 0x06001C87 RID: 7303 RVA: 0x00098324 File Offset: 0x00096524
	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x56E400", Offset = "0x56CA00", VA = "0x18056E400", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		bool flag = base.Shootable();
		anim.SetBool("shooting", flag);
	}

	// Token: 0x06001C88 RID: 7304 RVA: 0x00098374 File Offset: 0x00096574
	[Token(Token = "0x6001C88")]
	[Address(RVA = "0x56DC30", Offset = "0x56C230", VA = "0x18056DC30")]
	private void ExtraShoot()
	{
		List<Zombie> allZombies = Lawnf.GetAllZombies(false);
		Func<Zombie, bool> <>9__11_ = UltimateWinterMelon.<>c.<>9__11_0;
		if (<>9__11_ == 0)
		{
			UltimateWinterMelon.<>c.<>9__11_0 = delegate(Zombie z)
			{
				bool flag = Lawnf.InLandStatus(z.theStatus);
				if (!flag)
				{
					return flag;
				}
				throw new NullReferenceException();
			};
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
			int attackDamage = this.attackDamage;
			Bullet bullet;
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

	// Token: 0x06001C89 RID: 7305 RVA: 0x00098440 File Offset: 0x00096640
	[Token(Token = "0x6001C89")]
	[Address(RVA = "0x56E4D0", Offset = "0x56CAD0", VA = "0x18056E4D0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		Func<Zombie, bool> func = new Func(this.CheckZombie);
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
			bullet.velocity = num2;
			float num3 = array[1];
			bullet.velocity.y = num3;
			float num4 = array[1];
			bullet.acceleration.y = num4;
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

	// Token: 0x06001C8A RID: 7306 RVA: 0x0009856C File Offset: 0x0009676C
	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x56DFA0", Offset = "0x56C5A0", VA = "0x18056DFA0")]
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

	// Token: 0x06001C8B RID: 7307 RVA: 0x000985D0 File Offset: 0x000967D0
	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x56DBD0", Offset = "0x56C1D0", VA = "0x18056DBD0")]
	private bool CheckZombie(Zombie zombie)
	{
		int thePlantRow = this.thePlantRow;
		if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus) && !zombie.beforeDying)
		{
			return zombie.theStatus != ZombieStatus.Dying;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C8C RID: 7308 RVA: 0x00098624 File Offset: 0x00096824
	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x56E330", Offset = "0x56C930", VA = "0x18056E330", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x00098644 File Offset: 0x00096844
	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateWinterMelon()
	{
	}

	// Token: 0x04000FA1 RID: 4001
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000FA1")]
	public GameObject stage2;

	// Token: 0x04000FA2 RID: 4002
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FA2")]
	public GameObject stage3_1;

	// Token: 0x04000FA3 RID: 4003
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000FA3")]
	public GameObject stage3_2;

	// Token: 0x04000FA4 RID: 4004
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000FA4")]
	public bool summoning;
}
