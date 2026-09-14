using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000493 RID: 1171
[Token(Token = "0x2000493")]
public class UltimateTallNut : TallNutFootball
{
	// Token: 0x060015DE RID: 5598 RVA: 0x00079494 File Offset: 0x00077694
	[Token(Token = "0x60015DE")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x000794B4 File Offset: 0x000776B4
	[Token(Token = "0x60015DF")]
	[Address(RVA = "0x4591D0", Offset = "0x4577D0", VA = "0x1804591D0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		base.Recover(1500f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x060015E0 RID: 5600 RVA: 0x000794DC File Offset: 0x000776DC
	[Token(Token = "0x17000111")]
	public override int LimDamage
	{
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x430540", Offset = "0x42EB40", VA = "0x180430540", Slot = "66")]
		get
		{
			return 200;
		}
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x000794F0 File Offset: 0x000776F0
	[Token(Token = "0x60015E1")]
	[Address(RVA = "0x494C40", Offset = "0x493240", VA = "0x180494C40", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		ulong num9;
		do
		{
			int num = 0;
			float num2 = base.Timers[1];
			int num3 = 0;
			if (num2 > (float)num3)
			{
				return;
			}
			int limDamage = this.LimDamage;
			if (damageType == DamageType.JackboxExplode)
			{
				GridSystem gridSystem = this.board.gridSystem;
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					bool flag2 = num != num4;
					while (!flag2)
					{
					}
					if (flag2 > true && !flag2 && !flag2)
					{
						while (!flag2)
						{
						}
					}
					if (!flag2)
					{
						while (!flag2)
						{
						}
					}
					List<Plant> plants2 = MagnetSystem.GetPlants(num);
					bool flag3;
					if (flag3)
					{
					}
					ulong num5;
					if (num5 != (ulong)0L)
					{
						goto IL_014F;
					}
				}
				ulong num6;
				if (num6 != (ulong)0L)
				{
					goto IL_015B;
				}
			}
			if (damageType == DamageType.UltimateTallNutAll)
			{
				break;
			}
			List<Plant> ultimateTallNuts = this.GetUltimateTallNuts();
			bool flag4;
			if (flag4)
			{
				List<Plant> plantHead = this.board.boardEntity.plantHead;
				Func<Plant, bool> <>9__4_ = UltimateTallNut.<>c.<>9__4_0;
				if (<>9__4_ == 0)
				{
					Func<Plant, bool> func;
					UltimateTallNut.<>c.<>9__4_0 = func;
				}
				Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, <>9__4_);
				int num7 = 0;
				if (plant != num7)
				{
					ulong num8;
					num8 += num8;
				}
			}
			bool flag5;
			if (flag5)
			{
			}
		}
		while (num9 != (ulong)0L);
		int num10 = base.GetDamage(damage);
		int theShieldHealth = this.theShieldHealth;
		num10 -= damage;
		base.DecreaseHealth(damage);
		base.UpdateText();
		base.ReplaceSprite();
		return;
		IL_014F:
		throw new NullReferenceException();
		IL_015B:
		throw new NullReferenceException();
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x00079660 File Offset: 0x00077860
	[Token(Token = "0x60015E2")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x00079670 File Offset: 0x00077870
	[Token(Token = "0x60015E3")]
	[Address(RVA = "0x4946C0", Offset = "0x492CC0", VA = "0x1804946C0")]
	private List<Plant> GetUltimateTallNuts()
	{
		List<Plant> plantHead = this.board.boardEntity.plantHead;
		Func<Plant, bool> <>9__6_ = UltimateTallNut.<>c.<>9__6_0;
		if (<>9__6_ == 0)
		{
			Func<Plant, bool> func;
			UltimateTallNut.<>c.<>9__6_0 = func;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, <>9__6_);
		List<Plant> plantHead2 = this.board.boardEntity.plantHead;
		Func<Plant, bool> func2;
		if (UltimateTallNut.<>c.<>9__6_1 == 0)
		{
			UltimateTallNut.<>c.<>9__6_1 = func2;
		}
		Plant plant2 = Enumerable.FirstOrDefault<Plant>(plantHead2, func2);
		int num = 0;
		if (plant == num)
		{
			int num2 = 0;
			if (plant2 == num2)
			{
				return new List();
			}
		}
		List<Plant> list = new List();
		bool flag;
		if (flag)
		{
			int num3 = 0;
			bool flag2 = this != num3;
			if (flag2)
			{
				int size = list._size;
				list._size = (flag2 ? 1 : 0);
			}
		}
		bool flag3;
		while (!flag3)
		{
		}
		int size2 = list._size;
		list._size = (flag3 ? 1 : 0);
		bool flag4;
		while (!flag4)
		{
		}
		int size3 = list._size;
		list._syncRoot = 0;
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x00079768 File Offset: 0x00077968
	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x494BF0", Offset = "0x4931F0", VA = "0x180494BF0", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
		int num = 0;
		float num2;
		ulong num3;
		ulong num4;
		base.Recover(num2, (DamageType)num, num3 != 0UL, num4 != 0UL);
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x00079784 File Offset: 0x00077984
	[Token(Token = "0x60015E5")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public UltimateTallNut()
	{
	}
}
