using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A9 RID: 1193
[Token(Token = "0x20004A9")]
public class UltimatePortalNut : WallNut
{
	// Token: 0x17000154 RID: 340
	// (get) Token: 0x0600163C RID: 5692 RVA: 0x0007A614 File Offset: 0x00078814
	[Token(Token = "0x17000154")]
	public override int LimDamage
	{
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "65")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0007A628 File Offset: 0x00078828
	[Token(Token = "0x600163D")]
	[Address(RVA = "0x4E9B30", Offset = "0x4E8130", VA = "0x1804E9B30", Slot = "18")]
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

	// Token: 0x0600163E RID: 5694 RVA: 0x0007A6BC File Offset: 0x000788BC
	[Token(Token = "0x600163E")]
	[Address(RVA = "0x4E96B0", Offset = "0x4E7CB0", VA = "0x1804E96B0")]
	private void Backtrack()
	{
		ValueTuple<int, int> valueTuple = this.records.Dequeue();
		this.thePlantHealth = valueTuple;
		this.theShieldHealth = valueTuple;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.attributeCountdown = 10f;
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x0007A6FC File Offset: 0x000788FC
	[Token(Token = "0x600163F")]
	[Address(RVA = "0x4EA260", Offset = "0x4E8860", VA = "0x1804EA260")]
	private void OpenBlackHole()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x0007A720 File Offset: 0x00078920
	[Token(Token = "0x6001640")]
	[Address(RVA = "0x4E9C90", Offset = "0x4E8290", VA = "0x1804E9C90")]
	private void OnGetBullet(Bullet bullet)
	{
		int num10;
		do
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Board board = this.board;
			List<Plant> plants = global::Lawnf.GetPlants(this.thePlantType, board, num3 != 0);
			Func<Plant, bool> <>9__15_ = UltimatePortalNut.<>c.<>9__15_0;
			if (<>9__15_ == 0)
			{
				UltimatePortalNut.<>c.<>9__15_0 = (Plant a) => a.theStatus == PlantStatus.Raised;
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
			uint num9;
			if (Mathf.Max(num6, (int)num9) != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
					}
				}
				IL_00C0:
				num += 312;
				goto IL_00C8;
				goto IL_00C0;
			}
			IL_00C8:
			if ("{il2cpp array field local29->}" != (ulong)0L)
			{
			}
			if (num != 0)
			{
				goto IL_0132;
			}
			num10 = 0;
			List<BlackHole> list = UltimatePortalNut.blackHoles;
			Predicate<BlackHole> predicate;
			if (UltimatePortalNut.<>c.<>9__15_1 == 0)
			{
				UltimatePortalNut.<>c.<>9__15_1 = predicate;
			}
			int num11 = list.RemoveAll(predicate);
			List<BlackHole> list2 = UltimatePortalNut.blackHoles;
			bool flag;
			if (flag)
			{
				int num12 = 0;
				if (!(num2 != num12))
				{
					continue;
				}
			}
		}
		while (num10 != 0);
		return;
		IL_0132:
		throw new NullReferenceException();
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x0007A868 File Offset: 0x00078A68
	[Token(Token = "0x6001641")]
	[Address(RVA = "0x4EA320", Offset = "0x4E8920", VA = "0x1804EA320")]
	private void RecordHealth()
	{
		ValueTuple<int, int> valueTuple = this.records.Dequeue();
		int theShieldHealth = this.theShieldHealth;
		int thePlantHealth = this.thePlantHealth;
		Queue<ValueTuple<int, int>> queue = this.records;
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x0007A8A0 File Offset: 0x00078AA0
	[Token(Token = "0x6001642")]
	[Address(RVA = "0x4E9770", Offset = "0x4E7D70", VA = "0x1804E9770", Slot = "29")]
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

	// Token: 0x06001643 RID: 5699 RVA: 0x0007A8E0 File Offset: 0x00078AE0
	[Token(Token = "0x6001643")]
	[Address(RVA = "0x4E9810", Offset = "0x4E7E10", VA = "0x1804E9810", Slot = "31")]
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

	// Token: 0x06001644 RID: 5700 RVA: 0x0007A950 File Offset: 0x00078B50
	[Token(Token = "0x6001644")]
	[Address(RVA = "0x4E97E0", Offset = "0x4E7DE0", VA = "0x1804E97E0", Slot = "33")]
	public override void Die(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.Default)
		{
			this.Backtrack();
			return;
		}
		base.Die(reason);
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x0007A970 File Offset: 0x00078B70
	[Token(Token = "0x6001645")]
	[Address(RVA = "0x4E9A00", Offset = "0x4E8000", VA = "0x1804E9A00", Slot = "61")]
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

	// Token: 0x06001646 RID: 5702 RVA: 0x0007A9C4 File Offset: 0x00078BC4
	[Token(Token = "0x6001646")]
	[Address(RVA = "0x4E9930", Offset = "0x4E7F30", VA = "0x1804E9930", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x0007A9E4 File Offset: 0x00078BE4
	[Token(Token = "0x6001647")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "68")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x0007A9F4 File Offset: 0x00078BF4
	[Token(Token = "0x6001648")]
	[Address(RVA = "0x4EA4D0", Offset = "0x4E8AD0", VA = "0x1804EA4D0")]
	public UltimatePortalNut()
	{
		Queue<ValueTuple<int, int>> queue = new Queue();
		this.records = queue;
		this.blackHoleCD = 1f;
		base..ctor();
	}

	// Token: 0x04000DCF RID: 3535
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000DCF")]
	public BlackHole blackHolePrefab;

	// Token: 0x04000DD0 RID: 3536
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000DD0")]
	public GameObject holeVision;

	// Token: 0x04000DD1 RID: 3537
	[Token(Token = "0x4000DD1")]
	private const int BulletDamageToShieldPersent = 12;

	// Token: 0x04000DD2 RID: 3538
	[Token(Token = "0x4000DD2")]
	private const int RecordDuring = 3;

	// Token: 0x04000DD3 RID: 3539
	[Token(Token = "0x4000DD3")]
	private const int RecordTimesPerSecond = 50;

	// Token: 0x04000DD4 RID: 3540
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DD4")]
	[TupleElementNames(new string[] { "health", "shield" })]
	private readonly Queue<ValueTuple<int, int>> records;

	// Token: 0x04000DD5 RID: 3541
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DD5")]
	private int loseSheildCount;

	// Token: 0x04000DD6 RID: 3542
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000DD6")]
	private float blackHoleCD;

	// Token: 0x04000DD7 RID: 3543
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000DD7")]
	private bool autoMode;

	// Token: 0x04000DD8 RID: 3544
	[Token(Token = "0x4000DD8")]
	private static readonly List<BlackHole> blackHoles = new List();
}
