using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200046A RID: 1130
[Token(Token = "0x200046A")]
public class UltimateExplodeCannon : CobCannon
{
	// Token: 0x060014E6 RID: 5350 RVA: 0x0007427C File Offset: 0x0007247C
	[Token(Token = "0x60014E6")]
	[Address(RVA = "0x480340", Offset = "0x47E940", VA = "0x180480340", Slot = "71")]
	protected override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Mouse instance = Mouse.Instance;
		CreateBullet instance2 = CreateBullet.Instance;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		bullet.cannonPos = 0;
		bullet.cannonPos.y = (float)0;
		Board instance3 = Board.Instance;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x000742F4 File Offset: 0x000724F4
	[Token(Token = "0x60014E7")]
	[Address(RVA = "0x480510", Offset = "0x47EB10", VA = "0x180480510")]
	public void ReadySuperShoot()
	{
		int num2;
		do
		{
			int num = 0;
			Board board = this.board;
			List<Plant> plants = Lawnf.GetPlants(this.thePlantType, board, num != 0);
			num2 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x00074334 File Offset: 0x00072534
	[Token(Token = "0x60014E8")]
	[Address(RVA = "0x480690", Offset = "0x47EC90", VA = "0x180480690")]
	private void SuperShoot()
	{
		base.AttributeCountdown = 1f;
		Animator anim = this.anim;
		this.avaliable = false;
		anim.SetTrigger("shoot2");
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x0007436C File Offset: 0x0007256C
	[Token(Token = "0x60014E9")]
	[Address(RVA = "0x480240", Offset = "0x47E840", VA = "0x180480240")]
	private void AnimShoot2()
	{
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x000743A8 File Offset: 0x000725A8
	[Token(Token = "0x60014EA")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public UltimateExplodeCannon()
	{
	}
}
