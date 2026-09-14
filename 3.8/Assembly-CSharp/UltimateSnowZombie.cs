using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000705 RID: 1797
[Token(Token = "0x2000705")]
public class UltimateSnowZombie : Zombie
{
	// Token: 0x060023FC RID: 9212 RVA: 0x000BBC90 File Offset: 0x000B9E90
	[Token(Token = "0x60023FC")]
	[Address(RVA = "0x58D7E0", Offset = "0x58BDE0", VA = "0x18058D7E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)100L);
		this.attributeCountDown = 3f;
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x000BBCB8 File Offset: 0x000B9EB8
	[Token(Token = "0x60023FD")]
	[Address(RVA = "0x5824D0", Offset = "0x580AD0", VA = "0x1805824D0", Slot = "15")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x000BBCE4 File Offset: 0x000B9EE4
	[Token(Token = "0x60023FE")]
	[Address(RVA = "0x58DDC0", Offset = "0x58C3C0", VA = "0x18058DDC0", Slot = "20")]
	protected override void MoveUpdate()
	{
		base.MoveUpdate();
		if (this.boss)
		{
			Transform axis = this.axis;
			Animator anim = this.anim;
			int num;
			bool flag = num <= 9;
			anim.SetBool("stand", flag);
			float num2 = this.bossTimer;
			float deltaTime = Time.deltaTime;
			int num3 = 0;
			this.bossTimer = num2;
			if (num3 > (int)num2)
			{
				int num4 = 0;
				int num5 = 0;
				base.Garliced(num5 != 0, num4 != 0);
				this.bossTimer = 30f;
			}
		}
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x000BBD6C File Offset: 0x000B9F6C
	[Token(Token = "0x60023FF")]
	[Address(RVA = "0x58D600", Offset = "0x58BC00", VA = "0x18058D600", Slot = "23")]
	protected override void AttributeEvent()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num == 5)
		{
			SnowMap instance = SnowMap.Instance;
			int num2 = 0;
			if (instance != num2)
			{
				this.anim.SetTrigger("shoot3");
			}
		}
		int theMaxHealth = this.theMaxHealth;
		uint num3;
		num3 += num3;
		Plant plant = this.SearchPlant();
		int num4 = 0;
		if (plant != num4)
		{
			this.anim.SetTrigger("shoot1");
			Animator anim = this.anim;
			this.attributeCount = (int)((ulong)0L);
			anim.SetTrigger("shoot2");
			uint num5;
			GameAPP.PlaySound((int)num5, 0.5f, 1f);
		}
		this.attributeCountDown = 3f;
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x000BBE28 File Offset: 0x000BA028
	[Token(Token = "0x6002400")]
	[Address(RVA = "0x58DEB0", Offset = "0x58C4B0", VA = "0x18058DEB0")]
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
		throw new NullReferenceException();
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x000BBEAC File Offset: 0x000BA0AC
	[Token(Token = "0x6002401")]
	[Address(RVA = "0x58CD70", Offset = "0x58B370", VA = "0x18058CD70")]
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
				Vector3 vector;
				float z = vector.z;
				Transform axis = plant.axis;
				Vector3 vector2;
				float z2 = vector2.z;
				float[] array;
				float num3 = array[0];
				bullet.Vx = num3;
				float num4 = array[1];
				bullet.Vy = num4;
				float num5 = array[1];
				bullet.detaVy = num5;
				Transform transform = bullet.transform;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
	[Token(Token = "0x6002402")]
	[Address(RVA = "0x58D220", Offset = "0x58B820", VA = "0x18058D220")]
	private void AnimShoot2()
	{
		int num;
		int num3;
		do
		{
			num = 0;
			float num2 = global::UnityEngine.Random.Range(1.3f, 1.8f);
			GameAPP.PlaySound(133, 0.5f, num2);
			List<Plant> allPlants = Lawnf.GetAllPlants();
			num3 = 0;
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
				int num4 = 0;
				Plant plant;
				if (!(plant == num4))
				{
					continue;
				}
			}
		}
		while (num3 != 0);
		if (num != 0)
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		}
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x000BC044 File Offset: 0x000BA244
	[Token(Token = "0x6002403")]
	[Address(RVA = "0x58C9B0", Offset = "0x58AFB0", VA = "0x18058C9B0")]
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

	// Token: 0x06002404 RID: 9220 RVA: 0x000BC150 File Offset: 0x000BA350
	[Token(Token = "0x6002404")]
	[Address(RVA = "0x58D560", Offset = "0x58BB60", VA = "0x18058D560")]
	private void AnimShoot3()
	{
		SnowMap instance = SnowMap.Instance;
		int num = 0;
		if (instance != num)
		{
			SnowMap.Instance.HugeWave();
			return;
		}
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x000BC184 File Offset: 0x000BA384
	[Token(Token = "0x6002405")]
	[Address(RVA = "0x58D810", Offset = "0x58BE10", VA = "0x18058D810", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		for (;;)
		{
			int num = 0;
			int num2 = this.theHealth;
			num2 -= theDamage;
			this.theHealth = num2;
			num2 -= theDamage;
			CrackStatus crackStatus = Lawnf.GetCrackStatus((float)num, (float)theDamage);
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus == CrackStatus.Good)
				{
					goto IL_008D;
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
					goto IL_008D;
				}
				goto IL_0161;
			}
			IL_00DC:
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
			IL_008D:
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
				goto IL_00DC;
			}
			goto IL_0191;
		}
		return;
		Block_6:
		throw new NullReferenceException();
		IL_0161:
		throw new NullReferenceException();
		IL_0191:
		throw new NullReferenceException();
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x000BC354 File Offset: 0x000BA554
	[Token(Token = "0x6002406")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x000BC364 File Offset: 0x000BA564
	[Token(Token = "0x6002407")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x000BC384 File Offset: 0x000BA584
	[Token(Token = "0x6002408")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x000BC394 File Offset: 0x000BA594
	[Token(Token = "0x6002409")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x000BC3A4 File Offset: 0x000BA5A4
	[Token(Token = "0x600240A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x000BC3B4 File Offset: 0x000BA5B4
	[Token(Token = "0x600240B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x000BC3C4 File Offset: 0x000BA5C4
	[Token(Token = "0x600240C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000BC3D4 File Offset: 0x000BA5D4
	[Token(Token = "0x600240D")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x000BC3F0 File Offset: 0x000BA5F0
	[Token(Token = "0x600240E")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x000BC400 File Offset: 0x000BA600
	[Token(Token = "0x600240F")]
	[Address(RVA = "0x58E140", Offset = "0x58C740", VA = "0x18058E140")]
	public UltimateSnowZombie()
	{
		List<Transform> list = new List();
		this.shoots = list;
		this.bossTimer = 30f;
		base..ctor();
	}

	// Token: 0x0400119D RID: 4509
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400119D")]
	public List<Transform> shoots;

	// Token: 0x0400119E RID: 4510
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400119E")]
	public GameObject bigSnowBall;

	// Token: 0x0400119F RID: 4511
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400119F")]
	public bool boss;

	// Token: 0x040011A0 RID: 4512
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x40011A0")]
	private float bossTimer;
}
