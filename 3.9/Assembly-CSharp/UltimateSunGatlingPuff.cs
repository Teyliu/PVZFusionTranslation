using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005F7 RID: 1527
[Token(Token = "0x20005F7")]
public class UltimateSunGatlingPuff : UltimateSnowGatlingPuff
{
	// Token: 0x06001C7E RID: 7294 RVA: 0x00098178 File Offset: 0x00096378
	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x56D0B0", Offset = "0x56B6B0", VA = "0x18056D0B0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_sunSpike;
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x00098188 File Offset: 0x00096388
	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x56D0C0", Offset = "0x56B6C0", VA = "0x18056D0C0", Slot = "69")]
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

	// Token: 0x06001C80 RID: 7296 RVA: 0x000981D4 File Offset: 0x000963D4
	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateSunGatlingPuff()
	{
	}
}
