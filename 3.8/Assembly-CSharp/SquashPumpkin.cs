using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200042D RID: 1069
[Token(Token = "0x200042D")]
public class SquashPumpkin : Pumpkin
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x060013BF RID: 5055 RVA: 0x0006EAAC File Offset: 0x0006CCAC
	[Token(Token = "0x170000FD")]
	private Plant Squash
	{
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x46A1A0", Offset = "0x4687A0", VA = "0x18046A1A0")]
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

	// Token: 0x060013C0 RID: 5056 RVA: 0x0006EB64 File Offset: 0x0006CD64
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x42DFB0", Offset = "0x42C5B0", VA = "0x18042DFB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x0006EB84 File Offset: 0x0006CD84
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x4698C0", Offset = "0x467EC0", VA = "0x1804698C0", Slot = "40")]
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

	// Token: 0x060013C2 RID: 5058 RVA: 0x0006EE54 File Offset: 0x0006D054
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SquashPumpkin()
	{
	}

	// Token: 0x04000C8A RID: 3210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C8A")]
	public GameObject squashPrefab;

	// Token: 0x04000C8B RID: 3211
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C8B")]
	public GameObject squashPrefab_jala;

	// Token: 0x04000C8C RID: 3212
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C8C")]
	public GameObject squashPrefab_lour;

	// Token: 0x04000C8D RID: 3213
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C8D")]
	public GameObject squashPrefab_melon;

	// Token: 0x04000C8E RID: 3214
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C8E")]
	public GameObject squashPrefab_nuclear;

	// Token: 0x04000C8F RID: 3215
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C8F")]
	public GameObject squashPrefab_corn;

	// Token: 0x04000C90 RID: 3216
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000C90")]
	private LittleSquash littleSquash;
}
