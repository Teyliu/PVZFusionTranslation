using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200056E RID: 1390
[Token(Token = "0x200056E")]
public class StarfruitMagnet : StarFruit
{
	// Token: 0x060019C6 RID: 6598 RVA: 0x0008AF24 File Offset: 0x00089124
	[Token(Token = "0x60019C6")]
	[Address(RVA = "0x4E7F90", Offset = "0x4E6590", VA = "0x1804E7F90", Slot = "73")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x0008AF6C File Offset: 0x0008916C
	[Token(Token = "0x60019C7")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public StarfruitMagnet()
	{
	}
}
