using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000369 RID: 873
[Token(Token = "0x2000369")]
public class CherryUmbrella : CornUmbrella
{
	// Token: 0x06000FFA RID: 4090 RVA: 0x0005C3DC File Offset: 0x0005A5DC
	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x425310", Offset = "0x423910", VA = "0x180425310", Slot = "69")]
	public override void Block(Bullet bullet)
	{
		bullet.hit = true;
		IEnumerator enumerator = base.DelayBlock(bullet);
		Coroutine coroutine = base.StartCoroutine(enumerator);
		this.anim.SetTrigger("block");
		this.blocking = true;
		bullet.sortingGroup.sortingLayerName = "bullet11";
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x0005C430 File Offset: 0x0005A630
	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x4251E0", Offset = "0x4237E0", VA = "0x1804251E0", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		Plant umbrellaPot = base.UmbrellaPot;
		int num = 0;
		bool flag = umbrellaPot == num;
		int num2 = 0;
		if (!flag)
		{
		}
		zombie.KnockBack((float)num, (Zombie.KnockBackReason)num2);
		Board board = this.board;
		Collider2D col = zombie.col;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x0005C490 File Offset: 0x0005A690
	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x4253C0", Offset = "0x4239C0", VA = "0x1804253C0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x0005C4B0 File Offset: 0x0005A6B0
	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public CherryUmbrella()
	{
	}
}
