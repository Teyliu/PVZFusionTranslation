using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C5 RID: 1477
[Token(Token = "0x20005C5")]
public class UltimateSunGatlingPuff : UltimateSnowGatlingPuff
{
	// Token: 0x06001B8B RID: 7051 RVA: 0x000938E4 File Offset: 0x00091AE4
	[Token(Token = "0x6001B8B")]
	[Address(RVA = "0x517BD0", Offset = "0x5161D0", VA = "0x180517BD0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_sunSpike;
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x000938F4 File Offset: 0x00091AF4
	[Token(Token = "0x6001B8C")]
	[Address(RVA = "0x517BE0", Offset = "0x5161E0", VA = "0x180517BE0", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x00093940 File Offset: 0x00091B40
	[Token(Token = "0x6001B8D")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public UltimateSunGatlingPuff()
	{
	}
}
