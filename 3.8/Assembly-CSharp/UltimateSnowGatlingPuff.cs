using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BC RID: 1468
[Token(Token = "0x20005BC")]
public class UltimateSnowGatlingPuff : Shooter
{
	// Token: 0x06001B55 RID: 6997 RVA: 0x00092830 File Offset: 0x00090A30
	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x5025F0", Offset = "0x500BF0", VA = "0x1805025F0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		bool flag = this.CheckBuff();
		return BulletType.Bullet_smallIceSpark2;
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x0009284C File Offset: 0x00090A4C
	[Token(Token = "0x6001B56")]
	[Address(RVA = "0x502620", Offset = "0x500C20", VA = "0x180502620", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		bool flag = this.CheckBuff();
		Bullet bullet;
		bullet.Damage = 208;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x000928BC File Offset: 0x00090ABC
	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x502480", Offset = "0x500A80", VA = "0x180502480")]
	private bool CheckBuff()
	{
		bool flag;
		if (!flag)
		{
			return flag;
		}
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> func;
		if (UltimateSnowGatlingPuff.<>c.<>9__2_0 == 0)
		{
			UltimateSnowGatlingPuff.<>c.<>9__2_0 = func;
		}
		return Enumerable.FirstOrDefault<Plant>(list, func);
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x00092904 File Offset: 0x00090B04
	[Token(Token = "0x6001B58")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateSnowGatlingPuff()
	{
	}
}
