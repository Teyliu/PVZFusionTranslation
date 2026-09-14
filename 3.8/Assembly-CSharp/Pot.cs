using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000401 RID: 1025
[Token(Token = "0x2000401")]
public class Pot : Plant
{
	// Token: 0x060012E6 RID: 4838 RVA: 0x0006A5F8 File Offset: 0x000687F8
	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x43BA20", Offset = "0x43A020", VA = "0x18043BA20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0006A618 File Offset: 0x00068818
	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x45D4A0", Offset = "0x45BAA0", VA = "0x18045D4A0", Slot = "22")]
	public override void TryBeDisable(float timer = 0f)
	{
		base.TryBeDisable(timer);
		int num = 0;
		base.AttributeCountdown = (float)num;
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x0006A638 File Offset: 0x00068838
	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x45C9C0", Offset = "0x45AFC0", VA = "0x18045C9C0", Slot = "17")]
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

	// Token: 0x060012E9 RID: 4841 RVA: 0x0006A70C File Offset: 0x0006890C
	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x45C760", Offset = "0x45AD60", VA = "0x18045C760", Slot = "35")]
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

	// Token: 0x060012EA RID: 4842 RVA: 0x0006A730 File Offset: 0x00068930
	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x45D460", Offset = "0x45BA60", VA = "0x18045D460", Slot = "12")]
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

	// Token: 0x060012EB RID: 4843 RVA: 0x0006A75C File Offset: 0x0006895C
	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x45CD60", Offset = "0x45B360", VA = "0x18045CD60", Slot = "55")]
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

	// Token: 0x060012EC RID: 4844 RVA: 0x0006A7BC File Offset: 0x000689BC
	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x45CFD0", Offset = "0x45B5D0", VA = "0x18045CFD0", Slot = "54")]
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

	// Token: 0x060012ED RID: 4845 RVA: 0x0006A894 File Offset: 0x00068A94
	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x45C780", Offset = "0x45AD80", VA = "0x18045C780", Slot = "53")]
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

	// Token: 0x060012EE RID: 4846 RVA: 0x0006A900 File Offset: 0x00068B00
	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x45D4D0", Offset = "0x45BAD0", VA = "0x18045D4D0")]
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

	// Token: 0x060012EF RID: 4847 RVA: 0x0006AAB8 File Offset: 0x00068CB8
	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Pot()
	{
	}

	// Token: 0x04000C3C RID: 3132
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C3C")]
	public bool carry;

	// Token: 0x04000C3D RID: 3133
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x219")]
	[Token(Token = "0x4000C3D")]
	public bool lowerPot;
}
