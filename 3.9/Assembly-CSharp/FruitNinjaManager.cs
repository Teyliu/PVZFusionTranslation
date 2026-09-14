using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000B5 RID: 181
[Token(Token = "0x20000B5")]
public class FruitNinjaManager : MonoBehaviour
{
	// Token: 0x06000334 RID: 820 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x4101C0", Offset = "0x40E7C0", VA = "0x1804101C0")]
	public static ZombieType GetZombieType(int wave)
	{
		List<ZombieType> list = new List();
		int size = list._size;
		list._size = list;
		int size2 = list._size;
		list._size = list;
		int size3 = list._size;
		list._size = list;
		int size4 = list._size;
		list._size = list;
		return ListExtensions.GetRandom<ZombieType>(list);
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0000DE0C File Offset: 0x0000C00C
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x40F140", Offset = "0x40D740", VA = "0x18040F140")]
	private void Awake()
	{
		ulong num2;
		do
		{
			FruitNinjaManager.Instance = this;
			Board instance = Board.Instance;
			this.board = instance;
			Dictionary<FruitType, GameObject> dict = global::Core.Lawnf.GetDict<FruitType, GameObject>("FruitNinja/", true);
			this.FruitPrefabs = dict;
			Dictionary<FruitType, GameObject> fruitPrefabs = this.FruitPrefabs;
			bool flag;
			if (flag)
			{
				List<FruitType> list = this.allFruitTypes;
				int num = list._size + 1;
				list._size = num;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0000DE88 File Offset: 0x0000C088
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x4119C0", Offset = "0x40FFC0", VA = "0x1804119C0")]
	private void Start()
	{
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x411D50", Offset = "0x410350", VA = "0x180411D50")]
	private void Update()
	{
		while (!this.isGameOver && !this.board.over)
		{
			Board board = this.board;
			int num = board.theWave;
			if (board < 0)
			{
				num++;
			}
			int num2 = 0;
			if (num == 0)
			{
				Board board2 = this.board;
				int num3 = this.lastWave;
				if (board2.theWave != num3 && this.rogue)
				{
					int theWave = board2.theWave;
					this.lastWave = theWave;
					UIResourcesLoader uimanager = GameAPP.UIManager;
					Transform canvasUp = GameAPP.canvasUp;
					int num4 = 0;
					BaseMenu baseMenu = uimanager.Push((UIType)((uint)38), canvasUp, num4 != 0);
					Time.timeScale = (float)0;
				}
			}
			float deltaTime = Time.deltaTime;
			this.timer = deltaTime;
			ulong num5;
			if (this.buffCount.TryGetValue((uint)14, num5))
			{
				float deltaTime2 = Time.deltaTime;
				this.timer = deltaTime2;
			}
			float num6 = this.timer;
			this.SpawnObject();
			this.timer = 0f;
			Board board3 = this.board;
			if (this.rogue)
			{
				throw new NullReferenceException();
			}
			float num7;
			if (num2 > (int)num7 || num7 > 1f)
			{
				float num8 = (float)(0 * (int)(-0.8f));
				this.spawnRate = num8;
				break;
			}
		}
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
	[Token(Token = "0x6000338")]
	[Address(RVA = "0x411770", Offset = "0x40FD70", VA = "0x180411770")]
	private void SpawnObject()
	{
		float num = global::UnityEngine.Random.Range((float)0, 1f);
		int num2 = 0;
		if (num2 != 0)
		{
			return;
		}
		if ((this.rogue ? 1 : 0) != num2)
		{
			FruitType fruitType = this.GetFruitType();
			if (!this.buffCount.TryGetValue((uint)2, num2))
			{
			}
			if (1 > 0)
			{
			}
			return;
		}
		bool flag = this.allFruitTypes.Remove((uint)6);
		List<FruitType> list = this.allFruitTypes;
		int num3 = list._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		FruitType fruitType2 = list[num3];
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0000E054 File Offset: 0x0000C254
	[Token(Token = "0x6000339")]
	[Address(RVA = "0x40F3A0", Offset = "0x40D9A0", VA = "0x18040F3A0")]
	private FruitType GetFruitType()
	{
		List<FruitType> list = new List();
		int size = list._size;
		int num = 0;
		list._size = 1;
		list._syncRoot = num;
		int size2 = list._size;
		list._size = 1;
		bool flag = this.buffCount.TryGetValue((uint)11, num);
		if (flag)
		{
			int size3 = list._size;
			list._size = (flag ? 1 : 0);
		}
		bool flag2 = this.buffCount.TryGetValue((uint)10, num);
		if (flag2)
		{
			int size4 = list._size;
			list._size = (flag2 ? 1 : 0);
		}
		bool flag3 = this.buffCount.TryGetValue((uint)15, num);
		if (flag3)
		{
			int size5 = list._size;
			list._size = (flag3 ? 1 : 0);
		}
		bool flag4 = this.buffCount.TryGetValue((uint)22, num);
		if (flag4)
		{
			int size6 = list._size;
			list._size = (flag4 ? 1 : 0);
		}
		bool flag5 = this.buffCount.TryGetValue((uint)17, num);
		bool flag6;
		if (flag5)
		{
			int size7 = list._size;
			list._size = (flag5 ? 1 : 0);
			flag6 = list.Remove((uint)2);
		}
		return list[flag6 ? 1 : 0];
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0000E174 File Offset: 0x0000C374
	[Token(Token = "0x600033A")]
	[Address(RVA = "0x40FA30", Offset = "0x40E030", VA = "0x18040FA30")]
	private Vector4 GetSpawnData()
	{
		int num = 0;
		List<FruitNinjaManager.FruitStart> list = new List();
		int size = list._size;
		bool flag;
		if (flag)
		{
			int size2 = list._size;
			list._size = (flag ? 1 : 0);
		}
		bool flag2;
		if (flag2)
		{
			int size3 = list._size;
			list._size = (flag2 ? 1 : 0);
		}
		bool flag3;
		if (flag3)
		{
			int size4 = list._size;
			list._size = (flag3 ? 1 : 0);
		}
		Mouse instance = Mouse.Instance;
		bool flag4;
		if (typeof(Mouse).TypeHandle == 0 && flag4)
		{
			float num2 = global::UnityEngine.Random.Range((float)0, 0.5f);
		}
		bool flag5;
		FruitNinjaManager.FruitStart fruitStart = list[flag5 ? 1 : 0];
		float num7;
		float num10;
		if (fruitStart != FruitNinjaManager.FruitStart.上方)
		{
			float num11;
			if (fruitStart != FruitNinjaManager.FruitStart.上方)
			{
				int num3;
				float num6;
				if (fruitStart != FruitNinjaManager.FruitStart.左边)
				{
					Mouse instance2 = Mouse.Instance;
					num3 = 0;
					if (!(num != num3))
					{
					}
					float num5;
					float num4 = global::UnityEngine.Random.Range(num5, 1.05f);
					Vector2 gravity = Physics2D.gravity;
					Vector3 vector;
					num6 = vector.y;
					if (num3 <= 0)
					{
					}
				}
				num7 = Mouse.Instance.GetBoxXFromColumn(num3);
				Mouse instance3 = Mouse.Instance;
				uint num9;
				int num8 = global::UnityEngine.Random.Range(0, (int)num9);
				num6 = num7;
				num10 = instance3.GetLandY(num6, num8);
				num11 = global::UnityEngine.Random.Range(5f, 10f);
			}
			Mouse instance4 = Mouse.Instance;
			int num12 = 0;
			num7 = instance4.GetBoxXFromColumn(num12);
			Mouse instance5 = Mouse.Instance;
			uint num14;
			int num13 = global::UnityEngine.Random.Range(0, (int)num14);
			num10 = instance5.GetLandY(num7, num13);
			num11 = global::UnityEngine.Random.Range(6f, 11f);
		}
		Mouse instance6 = Mouse.Instance;
		int num15 = 0;
		num10 = instance6.GetLandY(num7, num15);
		throw new NullReferenceException();
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0000E304 File Offset: 0x0000C504
	[Token(Token = "0x600033B")]
	[Address(RVA = "0x4114C0", Offset = "0x40FAC0", VA = "0x1804114C0")]
	public FruitObject SpawnFruit(FruitType fruitType, Vector2 position, Vector2 force)
	{
		float plantMaxVisionX = this.board.plantMaxVisionX;
		if (position > plantMaxVisionX)
		{
		}
		Dictionary<FruitType, GameObject> fruitPrefabs = this.FruitPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject;
		FruitObject component = gameObject.GetComponent<FruitObject>();
		Rigidbody2D rb = component.rb;
		Rigidbody2D rb2 = component.rb;
		float num = global::UnityEngine.Random.Range(-5f, 5f);
		rb2.AddTorque(num, (ForceMode2D)((uint)1));
		component.AddComponent<SortingGroup>().sortingLayerName = "bullet11";
		component.manager = this;
		throw new NullReferenceException();
	}

	// Token: 0x0600033C RID: 828 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
	[Token(Token = "0x600033C")]
	[Address(RVA = "0x40EEE0", Offset = "0x40D4E0", VA = "0x18040EEE0")]
	public void AddScore(float points)
	{
		Dictionary<FruitBuffType, int> dictionary = this.buffCount;
		int num = 0;
		if (dictionary.TryGetValue((uint)3, num))
		{
		}
		if (this.buffCount.TryGetValue((uint)4, num))
		{
		}
		if (this.buffCount.TryGetValue((uint)5, num))
		{
		}
		if (this.buffCount.TryGetValue((uint)2, num))
		{
		}
		if (this.buffCount.TryGetValue((uint)14, num))
		{
		}
		if (this.buffCount.TryGetValue((uint)12, num))
		{
			float num2 = points * 0.1f;
		}
		Board board = this.board;
		int num3 = 0;
		board.GetPoint(points, num3 != 0);
	}

	// Token: 0x0600033D RID: 829 RVA: 0x0000E43C File Offset: 0x0000C63C
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x411070", Offset = "0x40F670", VA = "0x180411070")]
	public void LoseScore(float value)
	{
		ulong num;
		if (this.buffCount.TryGetValue((uint)13, num))
		{
			ulong num2 = num - 1UL;
			if (num > (ulong)0L)
			{
			}
		}
		Board board = this.board;
		int num3 = 0;
		board.GetPoint(value, num3 != 0);
		Board board2 = this.board;
		UIMgr.EnterLoseMenu("");
		this.isGameOver = true;
		Board board3 = this.board;
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x0600033E RID: 830 RVA: 0x0000E4AC File Offset: 0x0000C6AC
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x412020", Offset = "0x410620", VA = "0x180412020")]
	public void ZombieDeath(Zombie zombie)
	{
		Dictionary<FruitBuffType, int> dictionary = this.buffCount;
		bool flag;
		if (flag)
		{
			uint num;
			num += num;
			if ((flag ? 1U : 0U) < num)
			{
				FruitType fruitType = this.GetFruitType();
				Transform axis = zombie.axis;
				float num2 = global::UnityEngine.Random.Range(3f, 5f);
			}
		}
	}

	// Token: 0x0600033F RID: 831 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
	[Token(Token = "0x600033F")]
	[Address(RVA = "0x4111E0", Offset = "0x40F7E0", VA = "0x1804111E0")]
	public void ShowBuff()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)38), canvasUp, num != 0);
		Time.timeScale = (float)0;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0000E530 File Offset: 0x0000C730
	[Token(Token = "0x6000340")]
	[Address(RVA = "0x411A30", Offset = "0x410030", VA = "0x180411A30")]
	public bool TryGetBuffCount(FruitBuffType fruitBuffType, [Out] int count)
	{
		Dictionary<FruitBuffType, int> dictionary = this.buffCount;
		bool flag;
		if (!flag)
		{
			return flag;
		}
		ulong num;
		count.m_value = (int)num;
		return true;
	}

	// Token: 0x06000341 RID: 833 RVA: 0x0000E55C File Offset: 0x0000C75C
	[Token(Token = "0x6000341")]
	[Address(RVA = "0x40F850", Offset = "0x40DE50", VA = "0x18040F850")]
	public void GetNewBuff(FruitBuffType fruitBuffType)
	{
		Dictionary<FruitBuffType, int> dictionary = this.buffCount;
		Dictionary<FruitBuffType, int> dictionary2 = this.buffCount;
		bool flag;
		if (!flag)
		{
		}
		if (fruitBuffType == FruitBuffType.御剑飞行)
		{
			GameObject gameObject = Resources.Load<GameObject>("FruitNinja/Blade");
			Transform transform = base.transform;
			global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<FruitBlade>().auto = true;
			return;
		}
		TravelMgr instance = TravelMgr.Instance;
		int num = 0;
		instance.GetUltiBuff((UltiBuff)((uint)5), num != 0);
	}

	// Token: 0x06000342 RID: 834 RVA: 0x0000E5CC File Offset: 0x0000C7CC
	[Token(Token = "0x6000342")]
	[Address(RVA = "0x411280", Offset = "0x40F880", VA = "0x180411280")]
	private void SpawnBomb(Vector2 position, float force)
	{
		GameObject gameObject = this.bombPrefab;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		FruitBomb component = gameObject2.GetComponent<FruitBomb>();
		Rigidbody2D rb = component.rb;
		Rigidbody2D rb2 = component.rb;
		float num = global::UnityEngine.Random.Range(-5f, 5f);
		rb2.AddTorque(num, (ForceMode2D)((uint)1));
		component.AddComponent<SortingGroup>().sortingLayerName = "bullet11";
	}

	// Token: 0x06000343 RID: 835 RVA: 0x0000E644 File Offset: 0x0000C844
	[Token(Token = "0x6000343")]
	[Address(RVA = "0x411AC0", Offset = "0x4100C0", VA = "0x180411AC0")]
	private bool TryGetLeftZombieX([Out] Zombie leftZombie)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				float plantMaxVisionX = this.board.plantMaxVisionX;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06000344 RID: 836 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
	[Token(Token = "0x6000344")]
	[Address(RVA = "0x412180", Offset = "0x410780", VA = "0x180412180")]
	public FruitNinjaManager()
	{
		List<FruitType> list = new List();
		this.allFruitTypes = list;
		Dictionary<FruitBuffType, ValueTuple<string, int>> dictionary = new Dictionary();
		int num = 0;
		int num2 = 0;
		dictionary.Add(num2, num);
		int num3 = 0;
		dictionary.Add((uint)1, num3);
		int num4 = 0;
		dictionary.Add((uint)2, num4);
		int num5 = 0;
		dictionary.Add((uint)3, num5);
		int num6 = 0;
		dictionary.Add((uint)4, num6);
		int num7 = 0;
		dictionary.Add((uint)5, num7);
		int num8 = 0;
		dictionary.Add((uint)6, num8);
		int num9 = 0;
		dictionary.Add((uint)7, num9);
		int num10 = 0;
		dictionary.Add((uint)8, num10);
		int num11 = 0;
		dictionary.Add((uint)9, num11);
		int num12 = 0;
		dictionary.Add((uint)12, num12);
		int num13 = 0;
		dictionary.Add((uint)13, num13);
		int num14 = 0;
		dictionary.Add((uint)14, num14);
		int num15 = 0;
		dictionary.Add((uint)11, num15);
		int num16 = 0;
		dictionary.Add((uint)16, num16);
		int num17 = 0;
		dictionary.Add((uint)17, num17);
		int num18 = 0;
		dictionary.Add((uint)10, num18);
		int num19 = 0;
		dictionary.Add((uint)18, num19);
		int num20 = 0;
		dictionary.Add((uint)19, num20);
		int num21 = 0;
		dictionary.Add((uint)15, num21);
		int num22 = 0;
		dictionary.Add((uint)20, num22);
		int num23 = 0;
		dictionary.Add((uint)21, num23);
		int num24 = 0;
		dictionary.Add((uint)22, num24);
		int num25 = 0;
		dictionary.Add((uint)23, num25);
		int num26 = 0;
		dictionary.Add((uint)24, num26);
		this.BuffDescriptions = dictionary;
		Dictionary<FruitBuffType, int> dictionary2 = new Dictionary();
		this.buffCount = dictionary2;
		base..ctor();
	}

	// Token: 0x04000179 RID: 377
	[Token(Token = "0x4000179")]
	public static FruitNinjaManager Instance;

	// Token: 0x0400017A RID: 378
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400017A")]
	[Header("游戏设置")]
	public bool isGameOver;

	// Token: 0x0400017B RID: 379
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400017B")]
	public bool rogue;

	// Token: 0x0400017C RID: 380
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Token(Token = "0x400017C")]
	public bool combo;

	// Token: 0x0400017D RID: 381
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400017D")]
	public int comboCount;

	// Token: 0x0400017E RID: 382
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400017E")]
	[Header("水果设置")]
	public GameObject bombPrefab;

	// Token: 0x0400017F RID: 383
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017F")]
	public float spawnRate = 1f;

	// Token: 0x04000180 RID: 384
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000180")]
	public float minSpawnForce = 8f;

	// Token: 0x04000181 RID: 385
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000181")]
	public float maxSpawnForce = 10f;

	// Token: 0x04000182 RID: 386
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000182")]
	private Dictionary<FruitType, GameObject> FruitPrefabs;

	// Token: 0x04000183 RID: 387
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000183")]
	private readonly List<FruitType> allFruitTypes;

	// Token: 0x04000184 RID: 388
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000184")]
	private float timer;

	// Token: 0x04000185 RID: 389
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000185")]
	private Board board;

	// Token: 0x04000186 RID: 390
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000186")]
	private int lastWave;

	// Token: 0x04000187 RID: 391
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000187")]
	[TupleElementNames(new string[] { "description", "count" })]
	public readonly Dictionary<FruitBuffType, ValueTuple<string, int>> BuffDescriptions;

	// Token: 0x04000188 RID: 392
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000188")]
	private readonly Dictionary<FruitBuffType, int> buffCount;

	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	private enum FruitStart
	{
		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		上方,
		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		左边,
		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		右边,
		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		下方
	}
}
