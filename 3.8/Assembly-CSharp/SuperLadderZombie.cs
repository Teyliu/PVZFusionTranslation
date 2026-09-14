using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E1 RID: 1761
[Token(Token = "0x20006E1")]
public class SuperLadderZombie : LadderZombie
{
	// Token: 0x060022C2 RID: 8898 RVA: 0x000B674C File Offset: 0x000B494C
	[Token(Token = "0x60022C2")]
	[Address(RVA = "0x579690", Offset = "0x577C90", VA = "0x180579690", Slot = "75")]
	protected override void AnimSetLadder()
	{
		Plant ladderTarget = this.ladderTarget;
		int num = 0;
		if (ladderTarget != num)
		{
			GridItem gridItem = this.ladderTarget.Ladder;
			int num2 = 0;
			if (gridItem == num2)
			{
				Plant ladderTarget2 = this.ladderTarget;
				int num3 = 0;
				int thePlantColumn = ladderTarget2.thePlantColumn;
				GridItem gridItem2;
				if (gridItem2 == 0)
				{
					this.ladder = num3;
				}
				this.ladder = gridItem2;
				SpriteRenderer component = this.ladder.GetComponent<SpriteRenderer>();
				Sprite sprite = this.redLadder;
				component.sprite = sprite;
				this.ladder.red = true;
				Plant ladderTarget3 = this.ladderTarget;
				GameObject theSecondArmor = this.theSecondArmor;
				this.theStatus = (ZombieStatus)num3;
				global::UnityEngine.Object.Destroy(theSecondArmor);
				this.theSecondArmor = num3;
				Animator anim = this.anim;
				this.theSecondArmorHealth = num3;
				this.theSecondArmorType = (Zombie.SecondArmorType)num3;
				anim.SetTrigger("ladderOver");
				Mouse instance = Mouse.Instance;
				Plant ladderTarget4 = this.ladderTarget;
				if (instance.thePlantOnGlove == ladderTarget4)
				{
					global::UnityEngine.Object.Destroy(Mouse.Instance.theItemOnMouse);
					Mouse.Instance.theItemOnMouse = num3;
					Mouse.Instance.thePlantTypeOnMouse = (PlantType)((ulong)4294967295L);
					Mouse.Instance.thePlantOnGlove = num3;
				}
			}
		}
		this.anim.SetTrigger("back");
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x000B689C File Offset: 0x000B4A9C
	[Token(Token = "0x60022C3")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public SuperLadderZombie()
	{
	}

	// Token: 0x0400113A RID: 4410
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400113A")]
	public Sprite redLadder;

	// Token: 0x0400113B RID: 4411
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400113B")]
	private GridLadder ladder;
}
