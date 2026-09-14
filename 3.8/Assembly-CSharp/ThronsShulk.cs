using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045D RID: 1117
[Token(Token = "0x200045D")]
public class ThronsShulk : Shulkflower
{
	// Token: 0x0600149C RID: 5276 RVA: 0x00072BB8 File Offset: 0x00070DB8
	[Token(Token = "0x600149C")]
	[Address(RVA = "0x47A6A0", Offset = "0x478CA0", VA = "0x18047A6A0", Slot = "73")]
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

	// Token: 0x0600149D RID: 5277 RVA: 0x00072C7C File Offset: 0x00070E7C
	[Token(Token = "0x600149D")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public ThronsShulk()
	{
	}

	// Token: 0x04000CCD RID: 3277
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CCD")]
	private float angle;
}
