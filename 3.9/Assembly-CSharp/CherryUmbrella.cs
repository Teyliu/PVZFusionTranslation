using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000379 RID: 889
[Token(Token = "0x2000379")]
public class CherryUmbrella : CornUmbrella
{
	// Token: 0x06001046 RID: 4166 RVA: 0x0005D39C File Offset: 0x0005B59C
	[Token(Token = "0x6001046")]
	[Address(RVA = "0x47BFF0", Offset = "0x47A5F0", VA = "0x18047BFF0", Slot = "68")]
	public override void Block(Bullet bullet)
	{
		int maxHitCount = bullet.maxHitCount;
		bullet.hitCount = maxHitCount;
		IEnumerator enumerator = base.DelayBlock(bullet);
		Coroutine coroutine = base.StartCoroutine(enumerator);
		this.anim.SetTrigger("block");
		this.blocking = true;
		bullet.sortingGroup.sortingLayerName = "bullet11";
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x0005D3F8 File Offset: 0x0005B5F8
	[Token(Token = "0x6001047")]
	[Address(RVA = "0x47BEC0", Offset = "0x47A4C0", VA = "0x18047BEC0", Slot = "70")]
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

	// Token: 0x06001048 RID: 4168 RVA: 0x0005D458 File Offset: 0x0005B658
	[Token(Token = "0x6001048")]
	[Address(RVA = "0x47C0B0", Offset = "0x47A6B0", VA = "0x18047C0B0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x0005D478 File Offset: 0x0005B678
	[Token(Token = "0x6001049")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CherryUmbrella()
	{
	}
}
