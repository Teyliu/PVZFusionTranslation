using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000719 RID: 1817
[Token(Token = "0x2000719")]
public class SuperLadderZombie : LadderZombie
{
	// Token: 0x060023DE RID: 9182 RVA: 0x000BB528 File Offset: 0x000B9728
	[Token(Token = "0x60023DE")]
	[Address(RVA = "0x5F3C70", Offset = "0x5F2270", VA = "0x1805F3C70", Slot = "77")]
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

	// Token: 0x060023DF RID: 9183 RVA: 0x000BB678 File Offset: 0x000B9878
	[Token(Token = "0x60023DF")]
	[Address(RVA = "0x5883F0", Offset = "0x5869F0", VA = "0x1805883F0")]
	public SuperLadderZombie()
	{
	}

	// Token: 0x04001207 RID: 4615
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4001207")]
	public Sprite redLadder;

	// Token: 0x04001208 RID: 4616
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4001208")]
	private GridLadder ladder;
}
