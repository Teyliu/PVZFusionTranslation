using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000487 RID: 1159
[Token(Token = "0x2000487")]
public class UltimatePortalNut : WallNut
{
	// Token: 0x1700010E RID: 270
	// (get) Token: 0x0600159C RID: 5532 RVA: 0x00077C88 File Offset: 0x00075E88
	[Token(Token = "0x1700010E")]
	public override int LimDamage
	{
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x3ACD90", Offset = "0x3AB390", VA = "0x1803ACD90", Slot = "66")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x00077C9C File Offset: 0x00075E9C
	[Token(Token = "0x600159D")]
	[Address(RVA = "0x4905B0", Offset = "0x48EBB0", VA = "0x1804905B0", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		int num = 0;
		this.OnTriggerStay2D(num);
		ValueTuple<int, int> valueTuple = this.records.Dequeue();
		int theShieldHealth = this.theShieldHealth;
		int thePlantHealth = this.thePlantHealth;
		Queue<ValueTuple<int, int>> queue = this.records;
		float num2 = this.blackHoleCD;
		int num3 = 0;
		if (num2 > (float)num3)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.blackHoleCD = num2;
			GameObject gameObject = this.holeVision;
			this.blackHoleCD = 0f;
			gameObject.SetActive(true);
			if (this.autoMode)
			{
				int num4 = 0;
				bool flag = this.OnClicked(num4);
			}
		}
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x00077D30 File Offset: 0x00075F30
	[Token(Token = "0x600159E")]
	[Address(RVA = "0x490130", Offset = "0x48E730", VA = "0x180490130")]
	private void Backtrack()
	{
		ValueTuple<int, int> valueTuple = this.records.Dequeue();
		this.thePlantHealth = valueTuple;
		this.theShieldHealth = valueTuple;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.attributeCountdown = 10f;
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x00077D70 File Offset: 0x00075F70
	[Token(Token = "0x600159F")]
	[Address(RVA = "0x490DB0", Offset = "0x48F3B0", VA = "0x180490DB0")]
	private void OpenBlackHole()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x00077D94 File Offset: 0x00075F94
	[Token(Token = "0x60015A0")]
	[Address(RVA = "0x490710", Offset = "0x48ED10", VA = "0x180490710")]
	private void OnGetBullet(Bullet bullet)
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Board board = this.board;
			List<Plant> plants = global::Lawnf.GetPlants(this.thePlantType, board, num3 != 0);
			Func<Plant, bool> <>9__15_ = UltimatePortalNut.<>c.<>9__15_0;
			if (<>9__15_ == 0)
			{
				Func<Plant, bool> func;
				UltimatePortalNut.<>c.<>9__15_0 = func;
			}
			IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(plants, <>9__15_);
			int num4 = bullet._damage;
			int num5 = num4.MultiplyPercent(12f);
			int thePlantMaxHealth = this.thePlantMaxHealth;
			num4 = num5;
			num4 = Mathf.Min(num4, thePlantMaxHealth);
			int num6 = Enumerable.Count<Plant>(enumerable);
			uint num8;
			int num7 = Mathf.Max(num6, (int)num8);
			num7 = num4;
			num6 = num7;
			uint num10;
			int num9 = Mathf.Max(num6, (int)num10);
			if (num >= (int)num10)
			{
				goto IL_00A8;
			}
			num += num;
			if (num != (int)num10)
			{
				num++;
				goto IL_00A8;
			}
			goto IL_00CA;
			IL_00D2:
			num += 312;
			if (num != 0)
			{
				goto IL_013A;
			}
			int num11 = 0;
			List<BlackHole> list = UltimatePortalNut.blackHoles;
			Predicate<BlackHole> predicate;
			if (UltimatePortalNut.<>c.<>9__15_1 == 0)
			{
				UltimatePortalNut.<>c.<>9__15_1 = predicate;
			}
			int num12 = list.RemoveAll(predicate);
			List<BlackHole> list2 = UltimatePortalNut.blackHoles;
			bool flag;
			if (flag)
			{
				int num13 = 0;
				if (!(num2 != num13))
				{
					continue;
				}
			}
			if (num11 == 0)
			{
				break;
			}
			continue;
			IL_00A8:
			if (num < typeof(IEnumerable<Plant>).TypeHandle)
			{
				num += num;
				num++;
			}
			if (num < num)
			{
				num += num;
				if (num == 0)
				{
					goto IL_00D2;
				}
				num++;
			}
			IL_00CA:
			num += 312;
			goto IL_00D2;
		}
		return;
		IL_013A:
		throw new NullReferenceException();
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x00077EE4 File Offset: 0x000760E4
	[Token(Token = "0x60015A1")]
	[Address(RVA = "0x490E70", Offset = "0x48F470", VA = "0x180490E70")]
	private void RecordHealth()
	{
		ValueTuple<int, int> valueTuple = this.records.Dequeue();
		int theShieldHealth = this.theShieldHealth;
		int thePlantHealth = this.thePlantHealth;
		Queue<ValueTuple<int, int>> queue = this.records;
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x00077F1C File Offset: 0x0007611C
	[Token(Token = "0x60015A2")]
	[Address(RVA = "0x4901F0", Offset = "0x48E7F0", VA = "0x1804901F0", Slot = "30")]
	protected override void DecreateShield(int value)
	{
		base.DecreateShield(value);
		int num = this.loseSheildCount;
		int num2 = this.thePlantMaxHealth;
		num += value;
		this.loseSheildCount = num;
		num2 -= value;
		this.Backtrack();
		this.loseSheildCount = (int)((ulong)0L);
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x00077F5C File Offset: 0x0007615C
	[Token(Token = "0x60015A3")]
	[Address(RVA = "0x490290", Offset = "0x48E890", VA = "0x180490290", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		int num = damage.Multiply(0.8f);
		int num2 = Mathf.Max(damage, 1);
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)30)))
		{
			int num3 = damage.Multiply(0.67f);
			int num4 = Mathf.Max(damage, 1);
		}
		float attributeCountdown = this.attributeCountdown;
		int num5 = 0;
		if (attributeCountdown > (float)num5)
		{
			int num6 = damage.Multiply(0.67f);
			int num7 = Mathf.Max(damage, 1);
		}
		return base.GetDamage(damage);
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x00077FCC File Offset: 0x000761CC
	[Token(Token = "0x60015A4")]
	[Address(RVA = "0x490260", Offset = "0x48E860", VA = "0x180490260", Slot = "34")]
	public override void Die(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.Default)
		{
			this.Backtrack();
			return;
		}
		base.Die(reason);
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x00077FEC File Offset: 0x000761EC
	[Token(Token = "0x60015A5")]
	[Address(RVA = "0x490480", Offset = "0x48EA80", VA = "0x180490480", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		if (this.holeVision.activeSelf)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			return true;
		}
		bool flag = !this.autoMode;
		this.autoMode = flag;
		base.UpdateText();
		return true;
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x00078040 File Offset: 0x00076240
	[Token(Token = "0x60015A6")]
	[Address(RVA = "0x4903B0", Offset = "0x48E9B0", VA = "0x1804903B0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x00078060 File Offset: 0x00076260
	[Token(Token = "0x60015A7")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "69")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x00078070 File Offset: 0x00076270
	[Token(Token = "0x60015A8")]
	[Address(RVA = "0x491020", Offset = "0x48F620", VA = "0x180491020")]
	public UltimatePortalNut()
	{
		Queue<ValueTuple<int, int>> queue = new Queue();
		this.records = queue;
		this.blackHoleCD = 1f;
		base..ctor();
	}

	// Token: 0x04000D36 RID: 3382
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D36")]
	public BlackHole blackHolePrefab;

	// Token: 0x04000D37 RID: 3383
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D37")]
	public GameObject holeVision;

	// Token: 0x04000D38 RID: 3384
	[Token(Token = "0x4000D38")]
	private const int BulletDamageToShieldPersent = 12;

	// Token: 0x04000D39 RID: 3385
	[Token(Token = "0x4000D39")]
	private const int RecordDuring = 3;

	// Token: 0x04000D3A RID: 3386
	[Token(Token = "0x4000D3A")]
	private const int RecordTimesPerSecond = 50;

	// Token: 0x04000D3B RID: 3387
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D3B")]
	[TupleElementNames(new string[] { "health", "shield" })]
	private readonly Queue<ValueTuple<int, int>> records;

	// Token: 0x04000D3C RID: 3388
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D3C")]
	private int loseSheildCount;

	// Token: 0x04000D3D RID: 3389
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000D3D")]
	private float blackHoleCD;

	// Token: 0x04000D3E RID: 3390
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D3E")]
	private bool autoMode;

	// Token: 0x04000D3F RID: 3391
	[Token(Token = "0x4000D3F")]
	private static readonly List<BlackHole> blackHoles = new List();
}
