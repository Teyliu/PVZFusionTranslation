using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000550 RID: 1360
[Token(Token = "0x2000550")]
public class ScaredyHypno : ScaredyShroom
{
	// Token: 0x06001940 RID: 6464 RVA: 0x00088698 File Offset: 0x00086898
	[Token(Token = "0x6001940")]
	[Address(RVA = "0x4DE040", Offset = "0x4DC640", VA = "0x1804DE040", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x00088700 File Offset: 0x00086900
	[Token(Token = "0x6001941")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ScaredyHypno()
	{
	}
}
