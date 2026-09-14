using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004D1 RID: 1233
[Token(Token = "0x20004D1")]
public class CherryScaredy : ScaredyShroom
{
	// Token: 0x06001740 RID: 5952 RVA: 0x0007FD6C File Offset: 0x0007DF6C
	[Token(Token = "0x6001740")]
	[Address(RVA = "0x49F1B0", Offset = "0x49D7B0", VA = "0x18049F1B0")]
	private void AnimScaredy()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x0007FDA0 File Offset: 0x0007DFA0
	[Token(Token = "0x6001741")]
	[Address(RVA = "0x49F250", Offset = "0x49D850", VA = "0x18049F250", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001742 RID: 5954 RVA: 0x0007FDFC File Offset: 0x0007DFFC
	[Token(Token = "0x6001742")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public CherryScaredy()
	{
	}
}
