using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000490 RID: 1168
[Token(Token = "0x2000490")]
public class UltimateHugeNut : WallNut
{
	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06001597 RID: 5527 RVA: 0x000770C4 File Offset: 0x000752C4
	[Token(Token = "0x17000150")]
	public override int LimDamage
	{
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "65")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x000770D8 File Offset: 0x000752D8
	[Token(Token = "0x6001598")]
	[Address(RVA = "0x4DF0C0", Offset = "0x4DD6C0", VA = "0x1804DF0C0")]
	public void GetMultiplier(float value)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x000770FC File Offset: 0x000752FC
	[Token(Token = "0x6001599")]
	[Address(RVA = "0x4DF1E0", Offset = "0x4DD7E0", VA = "0x1804DF1E0", Slot = "59")]
	public override void InfluenceByJalapeno()
	{
		this.GetMultiplier(0.1f);
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x00077114 File Offset: 0x00075314
	[Token(Token = "0x600159A")]
	[Address(RVA = "0x4DF1E0", Offset = "0x4DD7E0", VA = "0x1804DF1E0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
		this.GetMultiplier(0.1f);
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x0007712C File Offset: 0x0007532C
	[Token(Token = "0x600159B")]
	[Address(RVA = "0x4DEC90", Offset = "0x4DD290", VA = "0x1804DEC90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 15f;
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x0007714C File Offset: 0x0007534C
	[Token(Token = "0x600159C")]
	[Address(RVA = "0x4DF2C0", Offset = "0x4DD8C0", VA = "0x1804DF2C0", Slot = "18")]
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

	// Token: 0x0600159D RID: 5533 RVA: 0x00077188 File Offset: 0x00075388
	[Token(Token = "0x600159D")]
	[Address(RVA = "0x4DFAA0", Offset = "0x4DE0A0", VA = "0x1804DFAA0", Slot = "15")]
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

	// Token: 0x0600159E RID: 5534 RVA: 0x000771C4 File Offset: 0x000753C4
	[Token(Token = "0x600159E")]
	[Address(RVA = "0x4DEEC0", Offset = "0x4DD4C0", VA = "0x1804DEEC0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)5), action);
		Action<object> action2;
		EventManager.RemoveListener((GameEvent)((uint)15), action2);
		Action<object> action3;
		EventManager.RemoveListener((GameEvent)((uint)16), action3);
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x000771EC File Offset: 0x000753EC
	[Token(Token = "0x600159F")]
	[Address(RVA = "0x4DF8C0", Offset = "0x4DDEC0", VA = "0x1804DF8C0")]
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

	// Token: 0x060015A0 RID: 5536 RVA: 0x00077230 File Offset: 0x00075430
	[Token(Token = "0x60015A0")]
	[Address(RVA = "0x4DF4E0", Offset = "0x4DDAE0", VA = "0x1804DF4E0")]
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
						UltimateHugeNut.<>c.<>9__24_0 = delegate(Plant p)
						{
							HashSet<PlantType> obsidianPlants3 = UltimateHugeNut.ObsidianPlants;
							PlantType thePlantType = p.thePlantType;
							return obsidianPlants3.Contains(thePlantType);
						};
					}
					int num = Enumerable.Count<Plant>(Enumerable.Where<Plant>(plantHead, <>9__24_));
					HashSet<PlantType> obsidianPlants2 = UltimateHugeNut.ObsidianPlants;
					int num2;
					num2 += num;
				}
			}
		}
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x000772C4 File Offset: 0x000754C4
	[Token(Token = "0x60015A1")]
	[Address(RVA = "0x4DF320", Offset = "0x4DD920", VA = "0x1804DF320")]
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

	// Token: 0x060015A2 RID: 5538 RVA: 0x000772F4 File Offset: 0x000754F4
	[Token(Token = "0x60015A2")]
	[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		ulong num2;
		base.Recover(1500f, (DamageType)num, true, num2 != 0UL);
		this.attributeCountdown = 15f;
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x0007731C File Offset: 0x0007551C
	[Token(Token = "0x60015A3")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "28")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x0007732C File Offset: 0x0007552C
	[Token(Token = "0x60015A4")]
	[Address(RVA = "0x4DEFE0", Offset = "0x4DD5E0", VA = "0x1804DEFE0")]
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

	// Token: 0x060015A5 RID: 5541 RVA: 0x0007738C File Offset: 0x0007558C
	[Token(Token = "0x60015A5")]
	[Address(RVA = "0x4DFBD0", Offset = "0x4DE1D0", VA = "0x1804DFBD0")]
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

	// Token: 0x060015A6 RID: 5542 RVA: 0x000773C0 File Offset: 0x000755C0
	[Token(Token = "0x60015A6")]
	[Address(RVA = "0x4DECB0", Offset = "0x4DD2B0", VA = "0x1804DECB0")]
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

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00077428 File Offset: 0x00075628
	[Token(Token = "0x17000151")]
	private int TemperDamage
	{
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x4DFF80", Offset = "0x4DE580", VA = "0x1804DFF80")]
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
					UltimateHugeNut.<>c.<>9__21_0 = delegate(Plant p)
					{
						HashSet<PlantType> obsidianPlants = UltimateHugeNut.ObsidianPlants;
						PlantType thePlantType = p.thePlantType;
						return obsidianPlants.Contains(thePlantType);
					};
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

	// Token: 0x060015A8 RID: 5544 RVA: 0x000774C0 File Offset: 0x000756C0
	[Token(Token = "0x60015A8")]
	[Address(RVA = "0x4DF190", Offset = "0x4DD790", VA = "0x1804DF190")]
	private int GetValue(int value)
	{
		Board board = this.board;
		return Lawnf.GetPlantCount(this.thePlantType, board);
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x060015A9 RID: 5545 RVA: 0x000774E0 File Offset: 0x000756E0
	[Token(Token = "0x17000152")]
	private int ObsidianTypes
	{
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x4DFE30", Offset = "0x4DE430", VA = "0x1804DFE30")]
		get
		{
			List<Plant> plantHead = this.board.boardEntity.plantHead;
			Func<Plant, bool> <>9__24_ = UltimateHugeNut.<>c.<>9__24_0;
			if (<>9__24_ == 0)
			{
				UltimateHugeNut.<>c.<>9__24_0 = delegate(Plant p)
				{
					HashSet<PlantType> obsidianPlants = UltimateHugeNut.ObsidianPlants;
					PlantType thePlantType = p.thePlantType;
					return obsidianPlants.Contains(thePlantType);
				};
			}
			return Enumerable.Count<Plant>(Enumerable.Where<Plant>(plantHead, <>9__24_));
		}
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x00077534 File Offset: 0x00075734
	[Token(Token = "0x60015AA")]
	[Address(RVA = "0x4DF1F0", Offset = "0x4DD7F0", VA = "0x1804DF1F0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00077554 File Offset: 0x00075754
	[Token(Token = "0x60015AB")]
	[Address(RVA = "0x4DFE10", Offset = "0x4DE410", VA = "0x1804DFE10")]
	public UltimateHugeNut()
	{
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x00077574 File Offset: 0x00075774
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x4DFC90", Offset = "0x4DE290", VA = "0x1804DFC90")]
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

	// Token: 0x04000D7E RID: 3454
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D7E")]
	private float cd;

	// Token: 0x04000D7F RID: 3455
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000D7F")]
	private float temperMultiplier = 1f;

	// Token: 0x04000D80 RID: 3456
	[Token(Token = "0x4000D80")]
	private const int tempNeedCount = 300;

	// Token: 0x04000D81 RID: 3457
	[Token(Token = "0x4000D81")]
	public static HashSet<PlantType> ObsidianPlants;
}
