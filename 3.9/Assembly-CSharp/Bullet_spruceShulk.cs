using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001AE RID: 430
[Token(Token = "0x20001AE")]
public class Bullet_spruceShulk : Bullet_spruce
{
	// Token: 0x0600076C RID: 1900 RVA: 0x00025958 File Offset: 0x00023B58
	[Token(Token = "0x600076C")]
	[Address(RVA = "0x810990", Offset = "0x80EF90", VA = "0x180810990", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		base.SetPenetrationTime();
		this.leaf.SetActive(true);
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00025984 File Offset: 0x00023B84
	[Token(Token = "0x600076D")]
	[Address(RVA = "0x810690", Offset = "0x80EC90", VA = "0x180810690", Slot = "22")]
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

	// Token: 0x0600076E RID: 1902 RVA: 0x00025A64 File Offset: 0x00023C64
	[Token(Token = "0x600076E")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_spruceShulk()
	{
	}

	// Token: 0x0400039E RID: 926
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400039E")]
	public GameObject leaf;
}
