using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000121 RID: 289
[Token(Token = "0x2000121")]
public class Bullet_cabbage_explode : Bullet_cabbage
{
	// Token: 0x06000588 RID: 1416 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
	[Token(Token = "0x6000588")]
	[Address(RVA = "0x6E5880", Offset = "0x6E3E80", VA = "0x1806E5880", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		zombie.SetJalaed();
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0001D430 File Offset: 0x0001B630
	[Token(Token = "0x6000589")]
	[Address(RVA = "0x6E57D0", Offset = "0x6E3DD0", VA = "0x1806E57D0", Slot = "17")]
	public override void HitLand()
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0001D470 File Offset: 0x0001B670
	[Token(Token = "0x600058A")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cabbage_explode()
	{
	}
}
