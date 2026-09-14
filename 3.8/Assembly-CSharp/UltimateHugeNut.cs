using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200046E RID: 1134
[Token(Token = "0x200046E")]
public class UltimateHugeNut : WallNut
{
	// Token: 0x1700010A RID: 266
	// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0007476C File Offset: 0x0007296C
	[Token(Token = "0x1700010A")]
	public override int LimDamage
	{
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x3ACD90", Offset = "0x3AB390", VA = "0x1803ACD90", Slot = "66")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x00074780 File Offset: 0x00072980
	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x4817F0", Offset = "0x47FDF0", VA = "0x1804817F0")]
	public void GetMultiplier(float value)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x000747A4 File Offset: 0x000729A4
	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x481910", Offset = "0x47FF10", VA = "0x180481910", Slot = "60")]
	public override void InfluenceByJalapeno()
	{
		this.GetMultiplier(0.1f);
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x000747BC File Offset: 0x000729BC
	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x481910", Offset = "0x47FF10", VA = "0x180481910", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
		this.GetMultiplier(0.1f);
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x000747D4 File Offset: 0x000729D4
	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x4813C0", Offset = "0x47F9C0", VA = "0x1804813C0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 15f;
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x000747F4 File Offset: 0x000729F4
	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x4819F0", Offset = "0x47FFF0", VA = "0x1804819F0", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		this.ReplaceSprite();
		float num = this.cd;
		int num2 = 0;
		if (num > (float)num2)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.cd = num;
			this.cd = 0f;
		}
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00074830 File Offset: 0x00072A30
	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x4821B0", Offset = "0x4807B0", VA = "0x1804821B0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
		int num2 = 0;
		Action<object> action2;
		EventManager.AddListener_obj((GameEvent)((uint)15), action2, num2 != 0);
		int num3 = 0;
		Action<object> action3;
		EventManager.AddListener_obj((GameEvent)((uint)16), action3, num3 != 0);
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x0007486C File Offset: 0x00072A6C
	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x4815F0", Offset = "0x47FBF0", VA = "0x1804815F0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)5), action);
		Action<object> action2;
		EventManager.RemoveListener((GameEvent)((uint)15), action2);
		Action<object> action3;
		EventManager.RemoveListener((GameEvent)((uint)16), action3);
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00074894 File Offset: 0x00072A94
	[Token(Token = "0x6001500")]
	[Address(RVA = "0x481FF0", Offset = "0x4805F0", VA = "0x180481FF0")]
	private void OnZombieTakeDamage(object obj)
	{
		int num = 0;
		if (obj != 0 && obj != 0)
		{
			HashSet<PlantType> obsidianPlants = UltimateHugeNut.ObsidianPlants;
			bool flag;
			if (flag)
			{
				Vector3 vector;
				float z = vector.z;
				int num2 = 0;
				this.GetEnergy(300, num, num2 != 0);
			}
		}
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x000748D8 File Offset: 0x00072AD8
	[Token(Token = "0x6001501")]
	[Address(RVA = "0x481C10", Offset = "0x480210", VA = "0x180481C10")]
	private void OnPlantTakeDamage(object obj)
	{
		if (obj != 0 && obj != 0)
		{
			HashSet<PlantType> obsidianPlants = UltimateHugeNut.ObsidianPlants;
			bool flag;
			if (flag)
			{
				Vector3 vector;
				float z = vector.z;
				bool flag2;
				if (flag2 && !flag2)
				{
					List<Plant> plantHead = this.board.boardEntity.plantHead;
					Func<Plant, bool> <>9__24_ = UltimateHugeNut.<>c.<>9__24_0;
					if (<>9__24_ == 0)
					{
						Func<Plant, bool> func;
						UltimateHugeNut.<>c.<>9__24_0 = func;
					}
					int num = Enumerable.Count<Plant>(Enumerable.Where<Plant>(plantHead, <>9__24_));
					HashSet<PlantType> obsidianPlants2 = UltimateHugeNut.ObsidianPlants;
					int num2;
					num2 += num;
				}
			}
		}
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x0007495C File Offset: 0x00072B5C
	[Token(Token = "0x6001502")]
	[Address(RVA = "0x481A50", Offset = "0x480050", VA = "0x180481A50")]
	private void OnPlantRecover(object obj)
	{
		if (obj != 0 && obj != 0)
		{
			HashSet<PlantType> obsidianPlants = UltimateHugeNut.ObsidianPlants;
			bool flag;
			if (flag)
			{
				Vector3 vector;
				float z = vector.z;
			}
		}
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x0007498C File Offset: 0x00072B8C
	[Token(Token = "0x6001503")]
	[Address(RVA = "0x481370", Offset = "0x47F970", VA = "0x180481370", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		ulong num2;
		base.Recover(1500f, (DamageType)num, true, num2 != 0UL);
		this.attributeCountdown = 15f;
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x000749B4 File Offset: 0x00072BB4
	[Token(Token = "0x6001504")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "29")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x000749C4 File Offset: 0x00072BC4
	[Token(Token = "0x6001505")]
	[Address(RVA = "0x481710", Offset = "0x47FD10", VA = "0x180481710")]
	private void GetEnergy(int value, Vector2 position, bool hasCD = true)
	{
		int attributeCount = this.attributeCount;
		Board board = this.board;
		int num = Lawnf.GetPlantCount(this.thePlantType, board);
		num += attributeCount;
		this.attributeCount = num;
		num += -300;
		this.attributeCount = num;
		if (hasCD)
		{
			float num2 = this.cd;
			int num3 = 0;
			if (num2 <= (float)num3)
			{
				this.cd = 0.02f;
			}
		}
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00074A24 File Offset: 0x00072C24
	[Token(Token = "0x6001506")]
	[Address(RVA = "0x4822E0", Offset = "0x4808E0", VA = "0x1804822E0")]
	private bool TryUseEnergy(Vector2 position, bool hasCD)
	{
		if (hasCD)
		{
			float num = this.cd;
			int num2 = 0;
			if (num > (float)num2)
			{
				return false;
			}
			this.cd = 0.02f;
		}
		this.CreateTemp(position);
		return false;
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x00074A58 File Offset: 0x00072C58
	[Token(Token = "0x6001507")]
	[Address(RVA = "0x4813E0", Offset = "0x47F9E0", VA = "0x1804813E0")]
	private void CreateTemp(Vector2 position)
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		int temperDamage = this.TemperDamage;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		PlantType thePlantType;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || !Lawnf.InLandStatus((ZombieStatus)num))
			{
				num++;
			}
			thePlantType = this.thePlantType;
		}
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06001508 RID: 5384 RVA: 0x00074AC0 File Offset: 0x00072CC0
	[Token(Token = "0x1700010B")]
	private int TemperDamage
	{
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x482690", Offset = "0x480C90", VA = "0x180482690")]
		get
		{
			int num;
			do
			{
				num = 0;
				List<Plant> allPlants = Lawnf.GetAllPlants();
				Func<Plant, bool> <>9__21_ = UltimateHugeNut.<>c.<>9__21_0;
				if (<>9__21_ == 0)
				{
					Func<Plant, bool> func;
					UltimateHugeNut.<>c.<>9__21_0 = func;
				}
				IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(allPlants, <>9__21_);
				if (enumerable != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						if (num != typeof(IEnumerator).TypeHandle)
						{
							num++;
						}
					}
					enumerable += enumerable;
					num += 312;
				}
				if ("{il2cpp array field local11->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
			throw new NullReferenceException();
		}
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00074B4C File Offset: 0x00072D4C
	[Token(Token = "0x6001509")]
	[Address(RVA = "0x4818C0", Offset = "0x47FEC0", VA = "0x1804818C0")]
	private int GetValue(int value)
	{
		Board board = this.board;
		return Lawnf.GetPlantCount(this.thePlantType, board);
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x0600150A RID: 5386 RVA: 0x00074B6C File Offset: 0x00072D6C
	[Token(Token = "0x1700010C")]
	private int ObsidianTypes
	{
		[Token(Token = "0x600150A")]
		[Address(RVA = "0x482540", Offset = "0x480B40", VA = "0x180482540")]
		get
		{
			List<Plant> plantHead = this.board.boardEntity.plantHead;
			Func<Plant, bool> <>9__24_ = UltimateHugeNut.<>c.<>9__24_0;
			if (<>9__24_ == 0)
			{
				Func<Plant, bool> func;
				UltimateHugeNut.<>c.<>9__24_0 = func;
			}
			return Enumerable.Count<Plant>(Enumerable.Where<Plant>(plantHead, <>9__24_));
		}
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00074BB0 File Offset: 0x00072DB0
	[Token(Token = "0x600150B")]
	[Address(RVA = "0x481920", Offset = "0x47FF20", VA = "0x180481920", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x00074BD0 File Offset: 0x00072DD0
	[Token(Token = "0x600150C")]
	[Address(RVA = "0x482520", Offset = "0x480B20", VA = "0x180482520")]
	public UltimateHugeNut()
	{
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x00074BF0 File Offset: 0x00072DF0
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600150D")]
	[Address(RVA = "0x4823A0", Offset = "0x4809A0", VA = "0x1804823A0")]
	static UltimateHugeNut()
	{
		HashSet<PlantType> hashSet = new HashSet();
		bool flag = hashSet.Add((uint)1173);
		bool flag2 = hashSet.Add((uint)906);
		bool flag3 = hashSet.Add((uint)931);
		bool flag4 = hashSet.Add((uint)240);
		bool flag5 = hashSet.Add((uint)913);
		bool flag6 = hashSet.Add((uint)977);
		bool flag7 = hashSet.Add((uint)997);
		bool flag8 = hashSet.Add((uint)946);
		bool flag9 = hashSet.Add((uint)927);
		bool flag10 = hashSet.Add((uint)925);
		bool flag11 = hashSet.Add((uint)990);
		UltimateHugeNut.ObsidianPlants = hashSet;
		throw new NullReferenceException();
	}

	// Token: 0x04000CE6 RID: 3302
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CE6")]
	private float cd;

	// Token: 0x04000CE7 RID: 3303
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000CE7")]
	private float temperMultiplier = 1f;

	// Token: 0x04000CE8 RID: 3304
	[Token(Token = "0x4000CE8")]
	private const int tempNeedCount = 300;

	// Token: 0x04000CE9 RID: 3305
	[Token(Token = "0x4000CE9")]
	public static HashSet<PlantType> ObsidianPlants;
}
