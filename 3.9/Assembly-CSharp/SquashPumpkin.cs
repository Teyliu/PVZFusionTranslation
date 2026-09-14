using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200044C RID: 1100
[Token(Token = "0x200044C")]
public class SquashPumpkin : Pumpkin
{
	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06001449 RID: 5193 RVA: 0x00070D3C File Offset: 0x0006EF3C
	[Token(Token = "0x17000142")]
	private Plant Squash
	{
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x4C4D50", Offset = "0x4C3350", VA = "0x1804C4D50")]
		get
		{
			ulong num;
			do
			{
				GridSystem gridSystem = this.board.gridSystem;
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
				bool flag;
				if (flag)
				{
					if (flag > true)
					{
						if ((flag > true && ((flag > true && (flag || flag)) || flag)) || (flag > true && flag) || flag)
						{
							goto IL_0091;
						}
						while (flag > true)
						{
						}
					}
					if ((flag <= true || ((flag <= true || !flag) && !flag)) && (flag <= true || !flag) && !flag)
					{
						while (!flag)
						{
						}
					}
				}
				IL_0091:;
			}
			while (num != (ulong)0L);
			throw new NullReferenceException();
		}
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x00070DF4 File Offset: 0x0006EFF4
	[Token(Token = "0x600144A")]
	[Address(RVA = "0x47E710", Offset = "0x47CD10", VA = "0x18047E710", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x00070E14 File Offset: 0x0006F014
	[Token(Token = "0x600144B")]
	[Address(RVA = "0x4C4470", Offset = "0x4C2A70", VA = "0x1804C4470", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 3f;
		Plant squash = this.Squash;
		int num = 0;
		if (!(squash == num))
		{
			LittleSquash littleSquash = this.littleSquash;
			int num2 = 0;
			if (!(littleSquash != num2))
			{
				GridSystem gridSystem = this.board.gridSystem;
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				if (gridSystem.GetGrid(thePlantColumn, thePlantRow).boxType != BoxType.Water)
				{
					PlantType thePlantType = squash.thePlantType;
					PlantType fromType = thePlantType;
					if (thePlantType > PlantType.NuclearSquash)
					{
						if (thePlantType == PlantType.SquashTorch)
						{
							Transform axis = this.axis;
							GameObject gameObject = this.squashPrefab;
							Transform transform = this.board.transform;
							GameObject gameObject2;
							LittleSquash component = gameObject2.GetComponent<LittleSquash>();
							this.littleSquash = component;
							this.littleSquash.theDamage = (int)((ulong)225L);
						}
						if (thePlantType == PlantType.SquashMelon)
						{
							Transform axis2 = this.axis;
							GameObject gameObject3 = this.squashPrefab_melon;
							Transform transform2 = this.board.transform;
							GameObject gameObject4;
							LittleSquash component2 = gameObject4.GetComponent<LittleSquash>();
							this.littleSquash = component2;
							LittleSquash littleSquash2 = this.littleSquash;
							int attackDamage = squash.attackDamage;
							littleSquash2.theDamage = attackDamage;
							Action<int, int> action;
							this.littleSquash.crashAction = action;
						}
						if (thePlantType != PlantType.SquashCorn)
						{
							goto IL_0209;
						}
						Transform axis3 = this.axis;
						GameObject gameObject5 = this.squashPrefab_corn;
						Transform transform3 = this.board.transform;
						GameObject gameObject6;
						LittleSquash component3 = gameObject6.GetComponent<LittleSquash>();
						this.littleSquash = component3;
						LittleSquash littleSquash3 = this.littleSquash;
						int attackDamage2 = squash.attackDamage;
						littleSquash3.theDamage = attackDamage2;
						Action<int, int> action2;
						this.littleSquash.crashAction = action2;
					}
					if (thePlantType == PlantType.Squalour)
					{
					}
					if (thePlantType == PlantType.UltimateTorch)
					{
						Transform axis4 = this.axis;
						GameObject gameObject7 = this.squashPrefab_jala;
						Transform transform4 = this.board.transform;
						GameObject gameObject8;
						LittleSquash component4 = gameObject8.GetComponent<LittleSquash>();
						this.littleSquash = component4;
						this.littleSquash.theDamage = (int)((ulong)1800L);
						Action<int, int> action3;
						this.littleSquash.crashAction = action3;
					}
					if (thePlantType == PlantType.NuclearSquash)
					{
					}
					IL_0209:
					GameObject gameObject9 = this.squashPrefab;
					Transform axis5 = this.axis;
					Transform transform5 = this.board.transform;
					GameObject gameObject10;
					LittleSquash component5 = gameObject10.GetComponent<LittleSquash>();
					this.littleSquash = component5;
					LittleSquash littleSquash4 = this.littleSquash;
					int num3 = squash.attackDamage;
					num3 += component5;
					littleSquash4.theDamage = num3;
					LittleSquash littleSquash5 = this.littleSquash;
					int thePlantRow2 = this.thePlantRow;
					littleSquash5.theRow = thePlantRow2;
					LittleSquash littleSquash6 = this.littleSquash;
					PlantType fromType2 = fromType;
					littleSquash6.thePlantType = fromType2;
					LittleSquash littleSquash7 = this.littleSquash;
					Board board = this.board;
					littleSquash7.board = board;
					Transform axis6 = this.axis;
					uint num4;
					GameAPP.PlaySound((int)num4, 0.5f, 1f);
				}
			}
		}
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x000710E4 File Offset: 0x0006F2E4
	[Token(Token = "0x600144C")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public SquashPumpkin()
	{
	}

	// Token: 0x04000D14 RID: 3348
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D14")]
	public GameObject squashPrefab;

	// Token: 0x04000D15 RID: 3349
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D15")]
	public GameObject squashPrefab_jala;

	// Token: 0x04000D16 RID: 3350
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D16")]
	public GameObject squashPrefab_lour;

	// Token: 0x04000D17 RID: 3351
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D17")]
	public GameObject squashPrefab_melon;

	// Token: 0x04000D18 RID: 3352
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D18")]
	public GameObject squashPrefab_nuclear;

	// Token: 0x04000D19 RID: 3353
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000D19")]
	public GameObject squashPrefab_corn;

	// Token: 0x04000D1A RID: 3354
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000D1A")]
	private LittleSquash littleSquash;
}
