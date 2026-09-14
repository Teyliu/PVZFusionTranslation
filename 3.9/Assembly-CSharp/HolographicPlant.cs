using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003AE RID: 942
[Token(Token = "0x20003AE")]
public class HolographicPlant : Plant
{
	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06001146 RID: 4422 RVA: 0x00061F94 File Offset: 0x00060194
	[Token(Token = "0x17000129")]
	public override int LimDamage
	{
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "65")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06001147 RID: 4423 RVA: 0x00061FA8 File Offset: 0x000601A8
	[Token(Token = "0x1700012A")]
	public override PlantType PreviewType
	{
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x48CDF0", Offset = "0x48B3F0", VA = "0x18048CDF0", Slot = "64")]
		get
		{
			return this._holographicType;
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06001148 RID: 4424 RVA: 0x00061FBC File Offset: 0x000601BC
	// (set) Token: 0x06001149 RID: 4425 RVA: 0x00061FD0 File Offset: 0x000601D0
	[Token(Token = "0x1700012B")]
	public PlantType HolographicType
	{
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x48CDF0", Offset = "0x48B3F0", VA = "0x18048CDF0")]
		get
		{
			return this._holographicType;
		}
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x48CE00", Offset = "0x48B400", VA = "0x18048CE00")]
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

	// Token: 0x0600114A RID: 4426 RVA: 0x00062070 File Offset: 0x00060270
	[Token(Token = "0x600114A")]
	[Address(RVA = "0x48CB00", Offset = "0x48B100", VA = "0x18048CB00", Slot = "15")]
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

	// Token: 0x0600114B RID: 4427 RVA: 0x000620A4 File Offset: 0x000602A4
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x48CBE0", Offset = "0x48B1E0", VA = "0x18048CBE0", Slot = "12")]
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

	// Token: 0x0600114C RID: 4428 RVA: 0x000620FC File Offset: 0x000602FC
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "19")]
	public override void SetColor(Color color)
	{
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x0006210C File Offset: 0x0006030C
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x48CDD0", Offset = "0x48B3D0", VA = "0x18048CDD0")]
	public HolographicPlant()
	{
	}

	// Token: 0x04000C03 RID: 3075
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C03")]
	private PlantType _holographicType = (PlantType)((ulong)4294967295L);

	// Token: 0x04000C04 RID: 3076
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C04")]
	private GameObject root;
}
