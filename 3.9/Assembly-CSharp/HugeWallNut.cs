using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020003AF RID: 943
[Token(Token = "0x20003AF")]
public class HugeWallNut : WallNut
{
	// Token: 0x1700012C RID: 300
	// (get) Token: 0x0600114E RID: 4430 RVA: 0x00062130 File Offset: 0x00060330
	[Token(Token = "0x1700012C")]
	public override int LimDamage
	{
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x46C280", Offset = "0x46A880", VA = "0x18046C280", Slot = "65")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x00062140 File Offset: 0x00060340
	[Token(Token = "0x600114F")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00062160 File Offset: 0x00060360
	[Token(Token = "0x6001150")]
	[Address(RVA = "0x48D120", Offset = "0x48B720", VA = "0x18048D120", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.CheckNut();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00062180 File Offset: 0x00060380
	[Token(Token = "0x6001151")]
	[Address(RVA = "0x48D150", Offset = "0x48B750", VA = "0x18048D150")]
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

	// Token: 0x06001152 RID: 4434 RVA: 0x000621C0 File Offset: 0x000603C0
	[Token(Token = "0x6001152")]
	[Address(RVA = "0x48D2C0", Offset = "0x48B8C0", VA = "0x18048D2C0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		int num = this.attributeCount;
		num += 10;
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x000621DC File Offset: 0x000603DC
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public HugeWallNut()
	{
	}
}
