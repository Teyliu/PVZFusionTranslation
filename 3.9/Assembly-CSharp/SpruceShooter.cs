using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000596 RID: 1430
[Token(Token = "0x2000596")]
public class SpruceShooter : Shooter
{
	// Token: 0x06001A91 RID: 6801 RVA: 0x0008EA38 File Offset: 0x0008CC38
	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x543F60", Offset = "0x542560", VA = "0x180543F60", Slot = "15")]
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

	// Token: 0x06001A92 RID: 6802 RVA: 0x0008EAB4 File Offset: 0x0008CCB4
	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x543E10", Offset = "0x542410", VA = "0x180543E10", Slot = "68")]
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

	// Token: 0x06001A93 RID: 6803 RVA: 0x0008EB10 File Offset: 0x0008CD10
	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SpruceShooter()
	{
	}
}
