using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041C RID: 1052
[Token(Token = "0x200041C")]
public class Pot : Plant
{
	// Token: 0x0600135C RID: 4956 RVA: 0x0006C42C File Offset: 0x0006A62C
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x48F270", Offset = "0x48D870", VA = "0x18048F270", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x0006C44C File Offset: 0x0006A64C
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x4B3990", Offset = "0x4B1F90", VA = "0x1804B3990", Slot = "22")]
	public override void TryBeDisable(float timer = 0f, bool force = false)
	{
		base.TryBeDisable(timer, force);
		int num = 0;
		base.AttributeCountdown = (float)num;
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x0006C46C File Offset: 0x0006A66C
	[Token(Token = "0x600135E")]
	[Address(RVA = "0x4B2EB0", Offset = "0x4B14B0", VA = "0x1804B2EB0", Slot = "17")]
	protected override void FixedUpdate()
	{
		ulong num5;
		do
		{
			int num = 0;
			base.FixedUpdate();
			this.carry = false;
			Rigidbody2D rb = this.rb;
			LayerMask plantLayer = this.plantLayer;
			rb.excludeLayers = plantLayer;
			float theOriginSpeed = this.theOriginSpeed;
			this.thePlantSpeed = theOriginSpeed;
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_00BE;
			}
			BoardGrid boardGrid;
			List<Plant> plants2 = boardGrid.plants;
			bool flag2;
			if (flag2)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
			}
		}
		while (num5 != (ulong)0L);
		Rigidbody2D rb2 = this.rb;
		return;
		IL_00BE:
		throw new NullReferenceException();
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x0006C540 File Offset: 0x0006A740
	[Token(Token = "0x600135F")]
	[Address(RVA = "0x4B2C50", Offset = "0x4B1250", VA = "0x1804B2C50", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		float attributeCountdown = this.attributeCountdown;
		int num = 0;
		if (attributeCountdown <= (float)num)
		{
			base.Crashed(level, soundID, zombie);
			return;
		}
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x0006C564 File Offset: 0x0006A764
	[Token(Token = "0x6001360")]
	[Address(RVA = "0x4B3950", Offset = "0x4B1F50", VA = "0x1804B3950", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType == DamageType.Normal || !this.carry)
		{
			float attributeCountdown = this.attributeCountdown;
			int num = 0;
			if (attributeCountdown <= (float)num)
			{
				return;
			}
		}
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x0006C590 File Offset: 0x0006A790
	[Token(Token = "0x6001361")]
	[Address(RVA = "0x4B3250", Offset = "0x4B1850", VA = "0x1804B3250", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plants = this.board.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x0006C5F0 File Offset: 0x0006A7F0
	[Token(Token = "0x6001362")]
	[Address(RVA = "0x4B34C0", Offset = "0x4B1AC0", VA = "0x1804B34C0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num5;
		do
		{
			int num = 0;
			if (this.board.gridSystem.GetGrid(originalColumn, originalRow).potNum == 1)
			{
				List<Plant> plants = this.board.gridSystem.GetGrid(originalColumn, originalRow).plants;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
					Vector3 vector;
					float z = vector.z;
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_00BD;
				}
			}
			GridSystem gridSystem = this.board.gridSystem;
			bool flag2;
			if (flag2)
			{
				break;
			}
			GridSystem gridSystem2 = this.board.gridSystem;
			BoardGrid boardGrid;
			List<Plant> plants2 = boardGrid.plants;
			bool flag3;
			if (flag3)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				Vector3 vector2;
				float z2 = vector2.z;
			}
		}
		while (num5 != (ulong)0L);
		return;
		IL_00BD:
		throw new NullReferenceException();
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x0006C6C8 File Offset: 0x0006A8C8
	[Token(Token = "0x6001363")]
	[Address(RVA = "0x4B2C70", Offset = "0x4B1270", VA = "0x1804B2C70", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		ulong num3;
		do
		{
			int num = 0;
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x0006C734 File Offset: 0x0006A934
	[Token(Token = "0x6001364")]
	[Address(RVA = "0x4B39C0", Offset = "0x4B1FC0", VA = "0x1804B39C0")]
	private void UniqueEffect(int theColumn, int theRow)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Plant> plants = this.board.gridSystem.GetGrid(theColumn, theRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				PlantType thePlantType = this.thePlantType;
				if (thePlantType > PlantType.CabbagePot)
				{
					if (thePlantType == PlantType.CornPot)
					{
					}
					while (thePlantType != PlantType.MelonPot)
					{
					}
				}
				bool flag2;
				if (thePlantType == PlantType.SuperCaltropPot)
				{
					flag2 = Lawnf.TravelAdvanced((AdvBuff)((uint)33));
				}
				while (!flag2)
				{
				}
				if ((ulong)((uint)33) <= (ulong)1118L)
				{
					goto IL_0105;
				}
				if ((ulong)((uint)33) > (ulong)1281L)
				{
					if ((ulong)((uint)33) > (ulong)1378L)
					{
						if ((ulong)((uint)33) == (ulong)1398L)
						{
							goto IL_017A;
						}
						if ((ulong)((uint)33) == (ulong)1399L)
						{
						}
						while ((ulong)((uint)33) != (ulong)1439L)
						{
						}
					}
					if ((ulong)((uint)33) == (ulong)1375L)
					{
						goto IL_017A;
					}
					while ((ulong)((uint)33) != (ulong)1378L)
					{
					}
				}
				if ((ulong)((uint)33) > (ulong)1126L)
				{
					if (flag2 <= true)
					{
						goto IL_017A;
					}
					while ((ulong)((uint)33) != (ulong)1281L)
					{
					}
				}
				if ((ulong)((uint)33) != (ulong)1124L)
				{
					goto IL_0105;
				}
				IL_017A:
				while ((ulong)((uint)33) != (ulong)914L)
				{
				}
				goto IL_0186;
				IL_0105:
				if ((ulong)((uint)33) > (ulong)952L)
				{
					if ((ulong)((uint)33) > (ulong)1111L)
					{
						if ((ulong)((uint)33) == (ulong)1113L)
						{
							goto IL_017A;
						}
						while ((ulong)((uint)33) != (ulong)1118L)
						{
						}
					}
					if ((ulong)((uint)33) == (ulong)955L)
					{
						goto IL_0186;
					}
					while ((ulong)((uint)33) != (ulong)1111L)
					{
					}
				}
				if ((ulong)((uint)33) > (ulong)914L)
				{
					if ((ulong)((uint)33) == (ulong)934L)
					{
						goto IL_0186;
					}
					while ((ulong)((uint)33) != (ulong)952L)
					{
					}
				}
				if ((ulong)((uint)33) == (ulong)26L)
				{
					goto IL_017A;
				}
				goto IL_017A;
			}
			IL_0186:;
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0006C8EC File Offset: 0x0006AAEC
	[Token(Token = "0x6001365")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Pot()
	{
	}

	// Token: 0x04000CB7 RID: 3255
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CB7")]
	public bool carry;

	// Token: 0x04000CB8 RID: 3256
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x219")]
	[Token(Token = "0x4000CB8")]
	public bool lowerPot;
}
