using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005EE RID: 1518
[Token(Token = "0x20005EE")]
public class UltimateSnowGatlingPuff : Shooter
{
	// Token: 0x06001C48 RID: 7240 RVA: 0x00096F54 File Offset: 0x00095154
	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x569CC0", Offset = "0x5682C0", VA = "0x180569CC0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		bool flag = this.CheckBuff();
		return BulletType.Bullet_smallIceSpark2;
	}

	// Token: 0x06001C49 RID: 7241 RVA: 0x00096F70 File Offset: 0x00095170
	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x569CF0", Offset = "0x5682F0", VA = "0x180569CF0", Slot = "69")]
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

	// Token: 0x06001C4A RID: 7242 RVA: 0x00096FE0 File Offset: 0x000951E0
	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x569B50", Offset = "0x568150", VA = "0x180569B50")]
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
			func = (Plant p) => p.thePlantType == PlantType.UltimateMelonPuff;
			UltimateSnowGatlingPuff.<>c.<>9__2_0 = func;
		}
		return Enumerable.FirstOrDefault<Plant>(list, func);
	}

	// Token: 0x06001C4B RID: 7243 RVA: 0x00097038 File Offset: 0x00095238
	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateSnowGatlingPuff()
	{
	}
}
