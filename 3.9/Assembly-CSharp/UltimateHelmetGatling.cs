using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E2 RID: 1506
[Token(Token = "0x20005E2")]
public class UltimateHelmetGatling : SuperGatling
{
	// Token: 0x06001BFF RID: 7167 RVA: 0x00095924 File Offset: 0x00093B24
	[Token(Token = "0x6001BFF")]
	[Address(RVA = "0x565EA0", Offset = "0x5644A0", VA = "0x180565EA0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_helmetPea_black;
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x00095938 File Offset: 0x00093B38
	[Token(Token = "0x6001C00")]
	[Address(RVA = "0x565D10", Offset = "0x564310", VA = "0x180565D10", Slot = "39")]
	protected override void AttributeEvent()
	{
		bool flag;
		if (!flag)
		{
			base.AttributeEvent();
			return;
		}
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = this.shoot;
		transform += transform;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		Bullet bullet;
		bullet.fromType = thePlantType;
		if (bullet == 0)
		{
			base.AttributeCountdown = (float)num;
			Animator anim = this.anim;
			int num2 = 0;
			anim.SetBool("shooting", num2 != 0);
			return;
		}
		base.AttributeCountdown = 0.2f;
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x000959BC File Offset: 0x00093BBC
	[Token(Token = "0x6001C01")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public UltimateHelmetGatling()
	{
	}
}
