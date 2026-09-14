using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200039A RID: 922
[Token(Token = "0x200039A")]
public class HolographicPlant : Plant
{
	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060010EA RID: 4330 RVA: 0x0006094C File Offset: 0x0005EB4C
	[Token(Token = "0x170000E6")]
	public override int LimDamage
	{
		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x3ACD90", Offset = "0x3AB390", VA = "0x1803ACD90", Slot = "66")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060010EB RID: 4331 RVA: 0x00060960 File Offset: 0x0005EB60
	[Token(Token = "0x170000E7")]
	public override PlantType PreviewType
	{
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x439570", Offset = "0x437B70", VA = "0x180439570", Slot = "65")]
		get
		{
			return this._holographicType;
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060010EC RID: 4332 RVA: 0x00060974 File Offset: 0x0005EB74
	// (set) Token: 0x060010ED RID: 4333 RVA: 0x00060988 File Offset: 0x0005EB88
	[Token(Token = "0x170000E8")]
	public PlantType HolographicType
	{
		[Token(Token = "0x60010EC")]
		[Address(RVA = "0x439570", Offset = "0x437B70", VA = "0x180439570")]
		get
		{
			return this._holographicType;
		}
		[Token(Token = "0x60010ED")]
		[Address(RVA = "0x439580", Offset = "0x437B80", VA = "0x180439580")]
		set
		{
			int num;
			do
			{
				Transform axis = this.axis;
				Vector3 vector;
				float z = vector.z;
				GameObject gameObject;
				this.root = gameObject;
				Transform transform = this.root.transform;
				Transform transform2 = base.transform;
				transform.parentInternal = transform2;
				this.uncrashable = true;
				List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
				int size = spriteRenderers._size;
				num = 0;
				spriteRenderers._size = num;
				if (size > 0)
				{
				}
				base.GetSpriteRenderers();
				this._holographicType = value;
				List<SpriteRenderer> spriteRenderers2 = this.spriteRenderers;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
		}
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00060A28 File Offset: 0x0005EC28
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x439280", Offset = "0x437880", VA = "0x180439280", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (this._holographicType == PlantType.Nothing)
		{
			int num = 0;
			base.Die((Plant.DieReason)num);
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00060A5C File Offset: 0x0005EC5C
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x439360", Offset = "0x437960", VA = "0x180439360", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		ulong num2;
		do
		{
			int num = 0;
			Board board = this.board;
			List<Plant> plants = Lawnf.GetPlants(this._holographicType, board, num != 0);
			PlantType holographicType = this._holographicType;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != (ulong)0L);
		int num3 = 0;
		base.Die((Plant.DieReason)num3);
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00060AB4 File Offset: 0x0005ECB4
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "19")]
	public override void SetColor(Color color)
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00060AC4 File Offset: 0x0005ECC4
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x439550", Offset = "0x437B50", VA = "0x180439550")]
	public HolographicPlant()
	{
	}

	// Token: 0x04000B9D RID: 2973
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B9D")]
	private PlantType _holographicType = (PlantType)((ulong)4294967295L);

	// Token: 0x04000B9E RID: 2974
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B9E")]
	private GameObject root;
}
