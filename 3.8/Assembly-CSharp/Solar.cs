using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D6 RID: 726
[Token(Token = "0x20002D6")]
public class Solar : MonoBehaviour
{
	// Token: 0x06000D0A RID: 3338 RVA: 0x0004B2F8 File Offset: 0x000494F8
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x3FA840", Offset = "0x3F8E40", VA = "0x1803FA840")]
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

	// Token: 0x06000D0B RID: 3339 RVA: 0x0004B3EC File Offset: 0x000495EC
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x3FAB50", Offset = "0x3F9150", VA = "0x1803FAB50")]
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
			Func<Plant, bool> func;
			Solar.<>c.<>9__12_0 = func;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, <>9__12_);
		int num3 = 0;
		if (plant != num3)
		{
			num2++;
		}
		this.damage = 0;
		List<Plant> plantHead2 = this.board.boardEntity.plantHead;
		Func<Plant, bool> func2;
		if (Solar.<>c.<>9__12_1 == 0)
		{
			Solar.<>c.<>9__12_1 = func2;
		}
		Plant plant2 = Enumerable.FirstOrDefault<Plant>(plantHead2, func2);
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

	// Token: 0x06000D0C RID: 3340 RVA: 0x0004B4E8 File Offset: 0x000496E8
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x3FAAD0", Offset = "0x3F90D0", VA = "0x1803FAAD0")]
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

	// Token: 0x06000D0D RID: 3341 RVA: 0x0004B54C File Offset: 0x0004974C
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x3FAF00", Offset = "0x3F9500", VA = "0x1803FAF00")]
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

	// Token: 0x06000D0E RID: 3342 RVA: 0x0004B740 File Offset: 0x00049940
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x3FB590", Offset = "0x3F9B90", VA = "0x1803FB590")]
	public Solar()
	{
		this.targetPosition.y = 7.5f;
		base..ctor();
	}

	// Token: 0x04000934 RID: 2356
	[Token(Token = "0x4000934")]
	public static Solar Instance;

	// Token: 0x04000935 RID: 2357
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000935")]
	public int damage;

	// Token: 0x04000936 RID: 2358
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000936")]
	public float deathTime = 15f;

	// Token: 0x04000937 RID: 2359
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000937")]
	public GameObject solarBomb;

	// Token: 0x04000938 RID: 2360
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000938")]
	private float timer;

	// Token: 0x04000939 RID: 2361
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000939")]
	private float timer2;

	// Token: 0x0400093A RID: 2362
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400093A")]
	private readonly Vector2 targetPosition = (ulong)3240624128L;

	// Token: 0x0400093B RID: 2363
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400093B")]
	private bool arrived;

	// Token: 0x0400093C RID: 2364
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400093C")]
	private ParticleSystem particleSystem1;

	// Token: 0x0400093D RID: 2365
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400093D")]
	private ParticleSystem particleSystem2;

	// Token: 0x0400093E RID: 2366
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400093E")]
	private Board board;
}
