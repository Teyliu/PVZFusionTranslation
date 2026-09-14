using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200047D RID: 1149
[Token(Token = "0x200047D")]
public class ThronsShulk : Shulkflower
{
	// Token: 0x0600152C RID: 5420 RVA: 0x00074F14 File Offset: 0x00073114
	[Token(Token = "0x600152C")]
	[Address(RVA = "0x4D1F60", Offset = "0x4D0560", VA = "0x1804D1F60", Slot = "72")]
	protected override void AttackUpdate()
	{
		base.AttackUpdate();
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		float num2 = this.angle;
		this.attributeCount = num;
		if (this.angle > 270f)
		{
		}
		float num3 = this.angle;
		this.angle = num3;
		this.angle = num3;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		Transform transform = bullet.transform;
		float num4 = this.angle * 0.017453292f;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bullet.from = this;
		int attackDamage;
		if ((ulong)1L == 0UL)
		{
			attackDamage = this.attackDamage;
		}
		bullet.Damage = attackDamage;
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x00074FD8 File Offset: 0x000731D8
	[Token(Token = "0x600152D")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public ThronsShulk()
	{
	}

	// Token: 0x04000D59 RID: 3417
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D59")]
	private float angle;
}
