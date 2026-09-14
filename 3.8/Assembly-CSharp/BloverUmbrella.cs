using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200034D RID: 845
[Token(Token = "0x200034D")]
public class BloverUmbrella : Plant
{
	// Token: 0x06000F7D RID: 3965 RVA: 0x00059DE8 File Offset: 0x00057FE8
	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x41C130", Offset = "0x41A730", VA = "0x18041C130")]
	public void Block(Bullet bullet)
	{
		bullet.hit = true;
		this.anim.SetTrigger("block");
		this.theStatus = (PlantStatus)((ulong)19L);
		BulletType theBulletType = bullet.theBulletType;
		if (theBulletType != BulletType.Bullet_superCherry)
		{
			if (theBulletType != BulletType.Bullet_jackbox_black)
			{
				goto IL_004E;
			}
			bool flag = this.SetEffect((EffectType)((uint)103), 1f, 10f);
		}
		base.FlashOnce();
		IL_004E:
		float num = bullet.Vy * -1f;
		int num2 = 0;
		bullet.Vy = num;
		float vx = bullet.Vx;
		bullet.Vx = vx;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(num2, 3), 0.5f, 1f);
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x00059E8C File Offset: 0x0005808C
	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x41C060", Offset = "0x41A660", VA = "0x18041C060")]
	public void BlockBungi(BungiZombie zombie)
	{
		GameAPP.PlaySound(106, 0.5f, 1f);
		this.anim.SetTrigger("block");
		this.theStatus = (PlantStatus)((ulong)19L);
		throw new NullReferenceException();
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00059ECC File Offset: 0x000580CC
	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public BloverUmbrella()
	{
	}
}
