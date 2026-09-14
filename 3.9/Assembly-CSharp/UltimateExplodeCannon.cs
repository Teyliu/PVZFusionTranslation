using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200048A RID: 1162
[Token(Token = "0x200048A")]
public class UltimateExplodeCannon : CobCannon
{
	// Token: 0x06001579 RID: 5497 RVA: 0x00076780 File Offset: 0x00074980
	[Token(Token = "0x6001579")]
	[Address(RVA = "0x4D85C0", Offset = "0x4D6BC0", VA = "0x1804D85C0", Slot = "70")]
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

	// Token: 0x0600157A RID: 5498 RVA: 0x000767F8 File Offset: 0x000749F8
	[Token(Token = "0x600157A")]
	[Address(RVA = "0x4D8790", Offset = "0x4D6D90", VA = "0x1804D8790")]
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

	// Token: 0x0600157B RID: 5499 RVA: 0x00076838 File Offset: 0x00074A38
	[Token(Token = "0x600157B")]
	[Address(RVA = "0x4D8910", Offset = "0x4D6F10", VA = "0x1804D8910")]
	private void SuperShoot()
	{
		base.AttributeCountdown = 1f;
		Animator anim = this.anim;
		this.avaliable = false;
		anim.SetTrigger("shoot2");
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x00076870 File Offset: 0x00074A70
	[Token(Token = "0x600157C")]
	[Address(RVA = "0x4D84C0", Offset = "0x4D6AC0", VA = "0x1804D84C0")]
	private void AnimShoot2()
	{
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x000768AC File Offset: 0x00074AAC
	[Token(Token = "0x600157D")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public UltimateExplodeCannon()
	{
	}
}
