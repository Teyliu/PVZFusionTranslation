using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020004B5 RID: 1205
[Token(Token = "0x20004B5")]
public class UltimateTallNut : TallNutFootball
{
	// Token: 0x0600167E RID: 5758 RVA: 0x0007BE28 File Offset: 0x0007A028
	[Token(Token = "0x600167E")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x0007BE48 File Offset: 0x0007A048
	[Token(Token = "0x600167F")]
	[Address(RVA = "0x4AD5B0", Offset = "0x4ABBB0", VA = "0x1804AD5B0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		base.Recover(1500f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06001680 RID: 5760 RVA: 0x0007BE70 File Offset: 0x0007A070
	[Token(Token = "0x17000157")]
	public override int LimDamage
	{
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x480D00", Offset = "0x47F300", VA = "0x180480D00", Slot = "65")]
		get
		{
			return 200;
		}
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x0007BE84 File Offset: 0x0007A084
	[Token(Token = "0x6001681")]
	[Address(RVA = "0x4EE0F0", Offset = "0x4EC6F0", VA = "0x1804EE0F0", Slot = "12")]
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
						goto IL_015D;
					}
				}
				ulong num6;
				if (num6 != (ulong)0L)
				{
					goto IL_0169;
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
					UltimateTallNut.<>c.<>9__4_0 = (Plant p) => p.thePlantType == PlantType.UltimateChomper || p.thePlantType == PlantType.GarlicUltimateChomper;
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
		IL_015D:
		throw new NullReferenceException();
		IL_0169:
		throw new NullReferenceException();
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x0007C000 File Offset: 0x0007A200
	[Token(Token = "0x6001682")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x0007C010 File Offset: 0x0007A210
	[Token(Token = "0x6001683")]
	[Address(RVA = "0x4EDB70", Offset = "0x4EC170", VA = "0x1804EDB70")]
	private List<Plant> GetUltimateTallNuts()
	{
		List<Plant> plantHead = this.board.boardEntity.plantHead;
		Func<Plant, bool> <>9__6_ = UltimateTallNut.<>c.<>9__6_0;
		if (<>9__6_ == 0)
		{
			UltimateTallNut.<>c.<>9__6_0 = (Plant p) => p.thePlantType == PlantType.UltimateTallNut;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, <>9__6_);
		List<Plant> plantHead2 = this.board.boardEntity.plantHead;
		Func<Plant, bool> func;
		if (UltimateTallNut.<>c.<>9__6_1 == 0)
		{
			func = (Plant p) => p.thePlantType == PlantType.UltimatePotatoNut;
			UltimateTallNut.<>c.<>9__6_1 = func;
		}
		Plant plant2 = Enumerable.FirstOrDefault<Plant>(plantHead2, func);
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

	// Token: 0x06001684 RID: 5764 RVA: 0x0007C124 File Offset: 0x0007A324
	[Token(Token = "0x6001684")]
	[Address(RVA = "0x4EE0A0", Offset = "0x4EC6A0", VA = "0x1804EE0A0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
		int num = 0;
		float num2;
		ulong num3;
		ulong num4;
		base.Recover(num2, (DamageType)num, num3 != 0UL, num4 != 0UL);
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x0007C140 File Offset: 0x0007A340
	[Token(Token = "0x6001685")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public UltimateTallNut()
	{
	}
}
