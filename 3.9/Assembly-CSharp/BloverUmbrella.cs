using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200035D RID: 861
[Token(Token = "0x200035D")]
public class BloverUmbrella : Plant
{
	// Token: 0x06000FC9 RID: 4041 RVA: 0x0005AD48 File Offset: 0x00058F48
	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x472FD0", Offset = "0x4715D0", VA = "0x180472FD0")]
	public void Block(Bullet bullet)
	{
		int maxHitCount = bullet.maxHitCount;
		bullet.hitCount = maxHitCount;
		this.anim.SetTrigger("block");
		this.theStatus = (PlantStatus)((ulong)19L);
		BulletType theBulletType = bullet.theBulletType;
		if (theBulletType != BulletType.Bullet_superCherry)
		{
			if (theBulletType != BulletType.Bullet_jackbox_black)
			{
				goto IL_0055;
			}
			bool flag = this.SetEffect((EffectType)((uint)103), 1f, 10f);
		}
		base.FlashOnce();
		IL_0055:
		float num = bullet.velocity.y * -1f;
		int num2 = 0;
		bullet.velocity.y = num;
		Vector2 velocity = bullet.velocity;
		bullet.velocity = velocity;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(num2, 3), 0.5f, 1f);
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x0005ADFC File Offset: 0x00058FFC
	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x472F00", Offset = "0x471500", VA = "0x180472F00")]
	public void BlockBungi(BungiZombie zombie)
	{
		GameAPP.PlaySound(106, 0.5f, 1f);
		this.anim.SetTrigger("block");
		this.theStatus = (PlantStatus)((ulong)19L);
		throw new NullReferenceException();
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x0005AE3C File Offset: 0x0005903C
	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public BloverUmbrella()
	{
	}
}
