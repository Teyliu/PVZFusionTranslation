using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B1 RID: 1457
[Token(Token = "0x20005B1")]
public class UltimateHelmetGatling : SuperGatling
{
	// Token: 0x06001B18 RID: 6936 RVA: 0x00091524 File Offset: 0x0008F724
	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x4FF360", Offset = "0x4FD960", VA = "0x1804FF360", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_helmetPea_black;
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x00091538 File Offset: 0x0008F738
	[Token(Token = "0x6001B19")]
	[Address(RVA = "0x4FF1D0", Offset = "0x4FD7D0", VA = "0x1804FF1D0", Slot = "40")]
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

	// Token: 0x06001B1A RID: 6938 RVA: 0x000915BC File Offset: 0x0008F7BC
	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public UltimateHelmetGatling()
	{
	}
}
