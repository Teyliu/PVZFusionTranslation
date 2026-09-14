using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
public class Bullet_spruceShulk : Bullet_spruce
{
	// Token: 0x0600075F RID: 1887 RVA: 0x00026068 File Offset: 0x00024268
	[Token(Token = "0x600075F")]
	[Address(RVA = "0x7E32D0", Offset = "0x7E18D0", VA = "0x1807E32D0", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		base.SetPenetrationTime();
		this.leaf.SetActive(true);
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00026094 File Offset: 0x00024294
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x7E2FD0", Offset = "0x7E15D0", VA = "0x1807E2FD0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		PlantType fromType = this.fromType;
		int num = 0;
		base.PlaySound(zombie);
		if (this.leaf.activeSelf)
		{
			int num2 = 0;
			Bullet_spruceShulk.<>c__DisplayClass2_0 CS$<>8__locals1;
			uint num3;
			CS$<>8__locals1.FieldGetter(num2, num, num3);
			CreateBullet instance = CreateBullet.Instance;
			Transform transform = base.transform;
			Vector2 velocity = this.rb.velocity;
			Transform transform2 = base.transform;
			Bullet bullet;
			CS$<>8__locals1.bullet = bullet;
			Bullet bullet2 = CS$<>8__locals1.bullet;
			bullet += bullet;
			uint num4;
			bullet2._damage = (int)num4;
			Bullet bullet3 = CS$<>8__locals1.bullet;
			PlantType fromType2 = this.fromType;
			bullet3.fromType = fromType2;
			DelayAction delayAction = GameAPP.delayAction;
			Action action = delegate
			{
				Bullet bullet4 = CS$<>8__locals1.bullet;
				int num6 = 0;
				if (bullet4 != num6)
				{
					CS$<>8__locals1.bullet.Die();
				}
			};
			delayAction.SetAction(action, 1.5f);
			GameObject gameObject = this.leaf;
			int num5 = 0;
			gameObject.SetActive(num5 != 0);
		}
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00026174 File Offset: 0x00024374
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_spruceShulk()
	{
	}

	// Token: 0x04000395 RID: 917
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000395")]
	public GameObject leaf;
}
