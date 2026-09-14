using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A8 RID: 1448
[Token(Token = "0x20005A8")]
public class SunStar : Plant
{
	// Token: 0x06001AC0 RID: 6848 RVA: 0x0008F648 File Offset: 0x0008D848
	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x5477A0", Offset = "0x545DA0", VA = "0x1805477A0")]
	private void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot1");
		this.SetBullet(transform, (BulletMoveWay)((uint)5));
		Transform transform2 = base.transform.Find("Shoot2");
		this.SetBullet(transform2, (BulletMoveWay)((uint)5));
		Transform transform3 = base.transform.Find("Shoot3");
		this.SetBullet(transform3, (BulletMoveWay)((uint)6));
		Transform transform4 = base.transform.Find("Shoot4");
		this.SetBullet(transform4, (BulletMoveWay)((uint)5));
		Transform transform5 = base.transform.Find("Shoot5");
		this.SetBullet(transform5, (BulletMoveWay)((uint)5));
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x0008F6F8 File Offset: 0x0008D8F8
	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x5479B0", Offset = "0x545FB0", VA = "0x1805479B0", Slot = "68")]
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

	// Token: 0x06001AC2 RID: 6850 RVA: 0x0008F740 File Offset: 0x0008D940
	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x547B70", Offset = "0x546170", VA = "0x180547B70", Slot = "16")]
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

	// Token: 0x06001AC3 RID: 6851 RVA: 0x0008F7A8 File Offset: 0x0008D9A8
	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x547AE0", Offset = "0x5460E0", VA = "0x180547AE0")]
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

	// Token: 0x06001AC4 RID: 6852 RVA: 0x0008F7F4 File Offset: 0x0008D9F4
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SunStar()
	{
	}
}
