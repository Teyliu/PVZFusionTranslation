using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200039B RID: 923
[Token(Token = "0x200039B")]
public class HugeWallNut : WallNut
{
	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00060AE8 File Offset: 0x0005ECE8
	[Token(Token = "0x170000E9")]
	public override int LimDamage
	{
		[Token(Token = "0x60010F2")]
		[Address(RVA = "0x42B670", Offset = "0x429C70", VA = "0x18042B670", Slot = "66")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00060AF8 File Offset: 0x0005ECF8
	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00060B18 File Offset: 0x0005ED18
	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x4398A0", Offset = "0x437EA0", VA = "0x1804398A0", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.CheckNut();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00060B38 File Offset: 0x0005ED38
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x4398D0", Offset = "0x437ED0", VA = "0x1804398D0")]
	private void CheckNut()
	{
		int num;
		do
		{
			num = 0;
			List<Plant> plantHead = this.board.boardEntity.plantHead;
			bool flag;
			if (flag)
			{
				num++;
			}
		}
		while (num != 0);
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00060B78 File Offset: 0x0005ED78
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x439A40", Offset = "0x438040", VA = "0x180439A40", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		int num = this.attributeCount;
		num += 10;
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00060B94 File Offset: 0x0005ED94
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public HugeWallNut()
	{
	}
}
