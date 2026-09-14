using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E4 RID: 740
[Token(Token = "0x20002E4")]
public class Solar : MonoBehaviour
{
	// Token: 0x06000D4D RID: 3405 RVA: 0x0004BECC File Offset: 0x0004A0CC
	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0x43E440", Offset = "0x43CA40", VA = "0x18043E440")]
	private void Awake()
	{
		Solar.Instance = this;
		Transform transform = base.transform;
		int num = 0;
		ParticleSystem component = transform.GetChild(num).GetComponent<ParticleSystem>();
		this.particleSystem1 = component;
		ParticleSystem component2 = base.transform.GetChild(1).GetComponent<ParticleSystem>();
		this.particleSystem2 = component2;
		this.deathTime = 15f;
		Board instance = Board.Instance;
		this.board = instance;
		if (GameAPP.config.disableSolarStarEffect)
		{
			Transform transform2 = base.transform;
			int num2 = 0;
			GameObject gameObject = transform2.GetChild(num2).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			GameObject gameObject2 = base.transform.GetChild(1).gameObject;
			int num4 = 0;
			gameObject2.SetActive(num4 != 0);
			GameObject gameObject3 = base.transform.GetChild(2).gameObject;
			int num5 = 0;
			gameObject3.SetActive(num5 != 0);
			base.transform.GetChild(3).gameObject.SetActive(true);
			return;
		}
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x0004BFC0 File Offset: 0x0004A1C0
	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0x43E750", Offset = "0x43CD50", VA = "0x18043E750")]
	public void SetDamage()
	{
		float num = this.deathTime;
		int num2 = 0;
		Board board = this.board;
		this.deathTime = num;
		List<Plant> plantHead = board.boardEntity.plantHead;
		Func<Plant, bool> <>9__12_ = Solar.<>c.<>9__12_0;
		if (<>9__12_ == 0)
		{
			Solar.<>c.<>9__12_0 = (Plant p) => p.thePlantType == PlantType.UltimateCabbage;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, <>9__12_);
		int num3 = 0;
		if (plant != num3)
		{
			num2++;
		}
		this.damage = 0;
		List<Plant> plantHead2 = this.board.boardEntity.plantHead;
		Func<Plant, bool> func;
		if (Solar.<>c.<>9__12_1 == 0)
		{
			func = (Plant p) => p.thePlantType == PlantType.UltimateCabbage;
			Solar.<>c.<>9__12_1 = func;
		}
		Plant plant2 = Enumerable.FirstOrDefault<Plant>(plantHead2, func);
		int num4 = 0;
		if (plant2 != num4)
		{
			int num5 = plant2.attributeCount;
			num5++;
			this.damage = num5;
		}
		this.deathTime = 1000000f;
		ParticleSystem.MainModule main = this.particleSystem1.main;
		ParticleSystem.MainModule main2 = this.particleSystem2.main;
		bool flag;
		if (flag)
		{
			int num6 = this.damage;
			uint num7;
			this.damage = (int)num7;
		}
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x0004C0DC File Offset: 0x0004A2DC
	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0x43E6D0", Offset = "0x43CCD0", VA = "0x18043E6D0")]
	private bool God()
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)3001)))
		{
			Board board = this.board;
			int plantCount = Lawnf.GetPlantCount((PlantType)((uint)909), board);
			Board board2 = this.board;
			int plantCount2 = Lawnf.GetPlantCount((PlantType)((uint)920), board2);
			Board board3 = this.board;
			return Lawnf.GetPlantCount((PlantType)((uint)934), board3) >= 10;
		}
		return false;
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x0004C140 File Offset: 0x0004A340
	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x43EB00", Offset = "0x43D100", VA = "0x18043EB00")]
	private void Update()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		float deltaTime = Time.deltaTime;
		int num = 0;
		float num2 = deltaTime * 5f;
		if (num > (int)num2 || num2 > 1f)
		{
		}
		Transform transform3 = base.transform;
		this.arrived = true;
		if (this.arrived)
		{
			float num3 = this.timer;
			float deltaTime2 = Time.deltaTime;
			this.timer = num3;
			float num4 = this.timer2;
			float deltaTime3 = Time.deltaTime;
			this.timer2 = num4;
			if (num > (int)num4)
			{
				this.timer2 = 3f;
				if (this.God())
				{
					Transform transform4 = global::UnityEngine.Object.Instantiate<GameObject>(GameAPP.itemPrefab[47]).transform;
					Transform transform5 = this.board.transform;
					transform4.parentInternal = transform5;
				}
			}
			if (num > (int)this.timer)
			{
				Board board = this.board;
				this.timer = 0.5f;
				List<Zombie> zombieArray = board.zombieArray;
				int num5 = this.damage;
				int size = zombieArray._size;
				num5 += 60;
				if (board.theSun > 15000)
				{
					board.UseSun(200f);
				}
				bool flag;
				if (flag)
				{
				}
				if (size > 0)
				{
					Zombie zombie = Board.Instance.zombieArray[size];
					int num6 = 0;
					bool flag2 = zombie != num6;
					if (flag2 && !zombie.isMindControlled)
					{
						ZombieStatus theStatus = zombie.theStatus;
						if (theStatus == ZombieStatus.Dying || flag2 <= true || theStatus != ZombieStatus.Boss)
						{
						}
					}
				}
			}
			float num7 = this.deathTime;
			float deltaTime4 = Time.deltaTime;
			this.deathTime = num7;
			ParticleSystem.MainModule main = this.particleSystem1.main;
			ParticleSystem.MainModule main2 = this.particleSystem2.main;
			bool flag3;
			if (!flag3)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
				throw new NullReferenceException();
			}
			int num8;
			int num9;
			num8 += num9;
			float num10 = this.deathTime;
			this.deathTime = num10;
		}
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x0004C334 File Offset: 0x0004A534
	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x43F190", Offset = "0x43D790", VA = "0x18043F190")]
	public Solar()
	{
		this.targetPosition.y = 7.5f;
		base..ctor();
	}

	// Token: 0x04000971 RID: 2417
	[Token(Token = "0x4000971")]
	public static Solar Instance;

	// Token: 0x04000972 RID: 2418
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000972")]
	public int damage;

	// Token: 0x04000973 RID: 2419
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000973")]
	public float deathTime = 15f;

	// Token: 0x04000974 RID: 2420
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000974")]
	public GameObject solarBomb;

	// Token: 0x04000975 RID: 2421
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000975")]
	private float timer;

	// Token: 0x04000976 RID: 2422
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000976")]
	private float timer2;

	// Token: 0x04000977 RID: 2423
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000977")]
	private readonly Vector2 targetPosition = (ulong)3240624128L;

	// Token: 0x04000978 RID: 2424
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000978")]
	private bool arrived;

	// Token: 0x04000979 RID: 2425
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000979")]
	private ParticleSystem particleSystem1;

	// Token: 0x0400097A RID: 2426
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400097A")]
	private ParticleSystem particleSystem2;

	// Token: 0x0400097B RID: 2427
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400097B")]
	private Board board;
}
