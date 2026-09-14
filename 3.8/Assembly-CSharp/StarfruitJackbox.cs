using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200056D RID: 1389
[Token(Token = "0x200056D")]
public class StarfruitJackbox : StarFruit
{
	// Token: 0x060019C4 RID: 6596 RVA: 0x0008AEC8 File Offset: 0x000890C8
	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x4E7E60", Offset = "0x4E6460", VA = "0x1804E7E60", Slot = "73")]
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

	// Token: 0x060019C5 RID: 6597 RVA: 0x0008AF10 File Offset: 0x00089110
	[Token(Token = "0x60019C5")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public StarfruitJackbox()
	{
	}
}
