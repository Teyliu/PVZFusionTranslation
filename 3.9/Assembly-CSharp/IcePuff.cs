using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000540 RID: 1344
[Token(Token = "0x2000540")]
public class IcePuff : PeaSmallPuff
{
	// Token: 0x06001907 RID: 6407 RVA: 0x00087210 File Offset: 0x00085410
	[Token(Token = "0x6001907")]
	[Address(RVA = "0x52B820", Offset = "0x529E20", VA = "0x18052B820", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(68, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x00087278 File Offset: 0x00085478
	[Token(Token = "0x6001908")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public IcePuff()
	{
	}
}
