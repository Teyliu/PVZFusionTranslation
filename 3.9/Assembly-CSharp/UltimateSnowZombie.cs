using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using GameLevel.RogueShooting;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200073D RID: 1853
[Token(Token = "0x200073D")]
public class UltimateSnowZombie : Zombie
{
	// Token: 0x06002517 RID: 9495 RVA: 0x000C085C File Offset: 0x000BEA5C
	[Token(Token = "0x6002517")]
	[Address(RVA = "0x6063E0", Offset = "0x6049E0", VA = "0x1806063E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)100L);
		this.attributeCountDown = 3f;
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x000C0884 File Offset: 0x000BEA84
	[Token(Token = "0x6002518")]
	[Address(RVA = "0x5FD9F0", Offset = "0x5FBFF0", VA = "0x1805FD9F0", Slot = "16")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x06002519 RID: 9497 RVA: 0x000C08B0 File Offset: 0x000BEAB0
	[Token(Token = "0x6002519")]
	[Address(RVA = "0x6069C0", Offset = "0x604FC0", VA = "0x1806069C0", Slot = "21")]
	protected override void MoveUpdate()
	{
		base.MoveUpdate();
		if (this.boss)
		{
			Animator anim = this.anim;
			bool flag = base.Column <= 9;
			anim.SetBool("stand", flag);
			float num = this.bossTimer;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			this.bossTimer = num;
			if (num2 > (int)num)
			{
				int num3 = 0;
				int num4 = 0;
				base.Garliced(num4 != 0, num3 != 0);
				this.bossTimer = 30f;
			}
		}
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x000C0930 File Offset: 0x000BEB30
	[Token(Token = "0x600251A")]
	[Address(RVA = "0x606200", Offset = "0x604800", VA = "0x180606200", Slot = "24")]
	protected override void AttributeEvent()
	{
		int num = 0;
		this.SetMindControl(num);
		int num2 = this.attributeCount;
		num2++;
		this.attributeCount = num2;
		if (num2 == 5)
		{
			this.anim.SetTrigger("shoot3");
		}
		long num3 = this.theMaxHealth;
		num3 -= (long)num;
		uint num4;
		num4 += num4;
		Plant plant = this.SearchPlant();
		int num5 = 0;
		if (plant != num5)
		{
			this.anim.SetTrigger("shoot1");
			Animator anim = this.anim;
			this.attributeCount = (int)((ulong)0L);
			anim.SetTrigger("shoot2");
			uint num6;
			GameAPP.PlaySound((int)num6, 0.5f, 1f);
		}
		Board board = this.board;
		this.attributeCountDown = 3f;
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x000C09F8 File Offset: 0x000BEBF8
	[Token(Token = "0x600251B")]
	[Address(RVA = "0x606A90", Offset = "0x605090", VA = "0x180606A90")]
	private Plant SearchPlant()
	{
		ulong num3;
		do
		{
			int num = 0;
			int columnNum = this.board.columnNum;
			GridSystem gridSystem = this.board.gridSystem;
			int theZombieRow = this.theZombieRow;
			List<Plant> plants = gridSystem.GetGrid(columnNum, theZombieRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				bool flag2;
				while (flag2)
				{
				}
				Transform axis = this.axis;
			}
		}
		while (num3 != (ulong)0L);
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, bool> func = delegate(Plant plant)
		{
			if (plant.plantTag == (ulong)0L)
			{
				int thePlantType = (int)plant.thePlantType;
				bool flag3;
				if (!flag3)
				{
					Transform axis2 = plant.axis;
					Transform axis3 = this.axis;
				}
			}
			throw new NullReferenceException();
		};
		Plant plant2 = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(allPlants, func));
		throw new NullReferenceException();
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x000C0AA4 File Offset: 0x000BECA4
	[Token(Token = "0x600251C")]
	[Address(RVA = "0x605A00", Offset = "0x604000", VA = "0x180605A00")]
	private void AnimShoot1()
	{
		int num2;
		do
		{
			GameAPP.PlaySound(68, 0.5f, 1f);
			Plant plant = this.SearchPlant();
			int num = 0;
			if (!(plant != num))
			{
				break;
			}
			List<Transform> list = this.shoots;
			num2 = 0;
			bool flag;
			if (flag)
			{
				CreateBullet instance = CreateBullet.Instance;
				int theAttackDamage = this.theAttackDamage;
				Bullet bullet;
				bullet.Damage = theAttackDamage;
				Transform transform = bullet.transform;
			}
		}
		while (num2 != 0);
		ShootingManager instance2 = ShootingManager.Instance;
		int num3 = 0;
		if (instance2 != num3)
		{
			ShootingManager instance3 = ShootingManager.Instance;
			int num4 = 0;
			instance3.BossSpawn(num4);
		}
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x000C0B60 File Offset: 0x000BED60
	[Token(Token = "0x600251D")]
	[Address(RVA = "0x605E10", Offset = "0x604410", VA = "0x180605E10")]
	private void AnimShoot2()
	{
		int num2;
		int num4;
		do
		{
			int num = 0;
			num2 = 0;
			float num3 = global::UnityEngine.Random.Range(1.3f, 1.8f);
			GameAPP.PlaySound(133, 0.5f, num3);
			List<Plant> allPlants = Lawnf.GetAllPlants();
			num4 = 0;
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
				int num5 = 0;
				Plant plant;
				if (!(plant == num5))
				{
					continue;
				}
				int num6 = 0;
				string text = num.ToString(num, num6);
			}
		}
		while (num4 != 0);
		if (num2 != 0)
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		}
	}

	// Token: 0x0600251E RID: 9502 RVA: 0x000C0C04 File Offset: 0x000BEE04
	[Token(Token = "0x600251E")]
	[Address(RVA = "0x605640", Offset = "0x603C40", VA = "0x180605640")]
	private void AnimGetSword()
	{
		Collider2D col = this.col;
		int num = 0;
		float num2 = global::UnityEngine.Random.Range(1.3f, 1.8f);
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, num2);
		Board board = this.board;
		if (num < board.rowNum)
		{
			Transform axis = this.axis;
			GameObject gameObject = this.bigSnowBall;
			float num4 = global::UnityEngine.Random.Range(3f, 5f);
			float num5 = global::UnityEngine.Random.Range(5f, 7f);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			num5 = num4;
			GameObject gameObject2;
			BigSnowBall bigSnowBall = gameObject2.GetComponent<BigSnowBall>();
			bigSnowBall += num;
			bigSnowBall.velocity = num5;
			bigSnowBall.velocity.y = -15f;
			bigSnowBall.theRow = num;
			int theAttackDamage = this.theAttackDamage;
			bigSnowBall.damage = theAttackDamage;
			SortingGroup sortingGroup = bigSnowBall.AddComponent<SortingGroup>();
			int num6;
			string text = string.Format("bullet{0}", num6);
			sortingGroup.sortingLayerName = text;
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x000C0D10 File Offset: 0x000BEF10
	[Token(Token = "0x600251F")]
	[Address(RVA = "0x606150", Offset = "0x604750", VA = "0x180606150")]
	private void AnimShoot3()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x000C0D30 File Offset: 0x000BEF30
	[Token(Token = "0x6002520")]
	[Address(RVA = "0x606410", Offset = "0x604A10", VA = "0x180606410", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		for (;;)
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			int num2 = 0;
			num -= (long)theDamage;
			CrackStatus crackStatus = Lawnf.GetCrackStatus((float)0, (float)num2);
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus == CrackStatus.Good)
				{
					goto IL_0093;
				}
				if (crackStatus != CrackStatus.Normal)
				{
					break;
				}
			}
			else
			{
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
				if (num8 == (ulong)0L)
				{
					goto IL_0093;
				}
				goto IL_0167;
			}
			IL_00E2:
			bool flag2;
			if (flag2)
			{
				int num9 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num9 != 0;
				int num10 = 0;
				Transform transform3;
				GameObject gameObject3 = transform3.GetChild(num10).gameObject;
				int num11 = 0;
				gameObject3.SetActive(num11 != 0);
				Transform transform4;
				uint num12;
				ulong num13;
				transform4.GetChild((int)num12).gameObject.SetActive(num13 != 0UL);
			}
			ulong num14;
			if (num14 == (ulong)0L)
			{
				goto Block_6;
			}
			continue;
			IL_0093:
			bool flag3;
			if (flag3)
			{
				int num15 = 0;
				SpriteRenderer spriteRenderer3;
				spriteRenderer3.enabled = num15 != 0;
				int num16 = 0;
				Transform transform5;
				ulong num17;
				transform5.GetChild(num16).gameObject.SetActive(num17 != 0UL);
				Transform transform6;
				uint num18;
				GameObject gameObject4 = transform6.GetChild((int)num18).gameObject;
				int num19 = 0;
				gameObject4.SetActive(num19 != 0);
			}
			ulong num20;
			if (num20 == (ulong)0L)
			{
				goto IL_00E2;
			}
			goto IL_0197;
		}
		return;
		Block_6:
		throw new NullReferenceException();
		IL_0167:
		throw new NullReferenceException();
		IL_0197:
		throw new NullReferenceException();
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x000C0F04 File Offset: 0x000BF104
	[Token(Token = "0x6002521")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x000C0F14 File Offset: 0x000BF114
	[Token(Token = "0x6002522")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x000C0F34 File Offset: 0x000BF134
	[Token(Token = "0x6002523")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x000C0F44 File Offset: 0x000BF144
	[Token(Token = "0x6002524")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x000C0F54 File Offset: 0x000BF154
	[Token(Token = "0x6002525")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002526 RID: 9510 RVA: 0x000C0F64 File Offset: 0x000BF164
	[Token(Token = "0x6002526")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x000C0F74 File Offset: 0x000BF174
	[Token(Token = "0x6002527")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002528 RID: 9512 RVA: 0x000C0F84 File Offset: 0x000BF184
	[Token(Token = "0x6002528")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x000C0F98 File Offset: 0x000BF198
	[Token(Token = "0x6002529")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x000C0FA8 File Offset: 0x000BF1A8
	[Token(Token = "0x600252A")]
	[Address(RVA = "0x606E90", Offset = "0x605490", VA = "0x180606E90")]
	public UltimateSnowZombie()
	{
		List<Transform> list = new List();
		this.shoots = list;
		this.bossTimer = 30f;
		base..ctor();
	}

	// Token: 0x04001267 RID: 4711
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001267")]
	public List<Transform> shoots;

	// Token: 0x04001268 RID: 4712
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001268")]
	public GameObject bigSnowBall;

	// Token: 0x04001269 RID: 4713
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001269")]
	public bool boss;

	// Token: 0x0400126A RID: 4714
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x400126A")]
	private float bossTimer;
}
