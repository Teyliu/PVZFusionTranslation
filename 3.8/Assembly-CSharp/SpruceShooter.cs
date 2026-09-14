using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000566 RID: 1382
[Token(Token = "0x2000566")]
public class SpruceShooter : Shooter
{
	// Token: 0x060019B1 RID: 6577 RVA: 0x0008A984 File Offset: 0x00088B84
	[Token(Token = "0x60019B1")]
	[Address(RVA = "0x4E5AF0", Offset = "0x4E40F0", VA = "0x1804E5AF0", Slot = "15")]
	protected override void Start()
	{
		ulong num2;
		do
		{
			int num = 0;
			base.Start();
			if (!AdvantureConfig.data.GetResult((AdvantureLevel)((uint)62), (MissionResult)((uint)2)))
			{
				return;
			}
			List<PlantType> allMixablePlantsCombined = PlantMixTreeManager.GetAllMixablePlantsCombined(this.thePlantType);
			bool flag;
			if (flag)
			{
				TravelMgr.Instance.data.AddDamage((PlantType)num, 0.3f);
			}
		}
		while (num2 != (ulong)0L);
		TravelData data = TravelMgr.Instance.data;
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x0008AA00 File Offset: 0x00088C00
	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x4E59A0", Offset = "0x4E3FA0", VA = "0x1804E59A0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x0008AA5C File Offset: 0x00088C5C
	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SpruceShooter()
	{
	}
}
