using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000578 RID: 1400
[Token(Token = "0x2000578")]
public class SunStar : Plant
{
	// Token: 0x060019E0 RID: 6624 RVA: 0x0008B580 File Offset: 0x00089780
	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x4E8370", Offset = "0x4E6970", VA = "0x1804E8370")]
	private void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot1");
		this.SetBullet(transform, (BulletMoveWay)((uint)2));
		Transform transform2 = base.transform.Find("Shoot2");
		this.SetBullet(transform2, (BulletMoveWay)((uint)2));
		Transform transform3 = base.transform.Find("Shoot3");
		this.SetBullet(transform3, (BulletMoveWay)((uint)9));
		Transform transform4 = base.transform.Find("Shoot4");
		this.SetBullet(transform4, (BulletMoveWay)((uint)2));
		Transform transform5 = base.transform.Find("Shoot5");
		this.SetBullet(transform5, (BulletMoveWay)((uint)2));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x0008B630 File Offset: 0x00089830
	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x4E8580", Offset = "0x4E6B80", VA = "0x1804E8580", Slot = "69")]
	protected virtual void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x0008B678 File Offset: 0x00089878
	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x4E8740", Offset = "0x4E6D40", VA = "0x1804E8740", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active && base.PumpkinType == PlantType.StarPumpkin)
		{
			Board board = this.board;
			if (board.theSun > 25)
			{
				board.UseSun(25f);
				this.anim.SetTrigger("shoot");
				this.theStatus = (PlantStatus)((ulong)25L);
			}
		}
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x0008B6E0 File Offset: 0x000898E0
	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x4E86B0", Offset = "0x4E6CB0", VA = "0x1804E86B0")]
	public void Shoot()
	{
		Board board = this.board;
		if (board.theSun > 25)
		{
			board.UseSun(25f);
			this.anim.SetTrigger("shoot");
			this.theStatus = (PlantStatus)((ulong)25L);
		}
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0008B72C File Offset: 0x0008992C
	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SunStar()
	{
	}
}
