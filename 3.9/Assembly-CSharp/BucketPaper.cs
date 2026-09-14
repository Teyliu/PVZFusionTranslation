using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200066B RID: 1643
[Token(Token = "0x200066B")]
public class BucketPaper : PaperZombie
{
	// Token: 0x06001F20 RID: 7968 RVA: 0x000A5684 File Offset: 0x000A3884
	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x58B410", Offset = "0x589A10", VA = "0x18058B410", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.ReinforcePaper(50f);
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x000A56A4 File Offset: 0x000A38A4
	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x58B3E0", Offset = "0x5899E0", VA = "0x18058B3E0", Slot = "66")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x000A56B4 File Offset: 0x000A38B4
	[Token(Token = "0x6001F22")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x000A56C4 File Offset: 0x000A38C4
	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x58B180", Offset = "0x589780", VA = "0x18058B180", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x000A5704 File Offset: 0x000A3904
	[Token(Token = "0x6001F24")]
	[Address(RVA = "0x58B140", Offset = "0x589740", VA = "0x18058B140", Slot = "76")]
	public override void AngrySound()
	{
		base.AngrySound();
		this.ReinforcePaper(100f);
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x000A5724 File Offset: 0x000A3924
	[Token(Token = "0x6001F25")]
	[Address(RVA = "0x58B220", Offset = "0x589820", VA = "0x18058B220")]
	private void ReinforcePaper(float value)
	{
		int num3;
		do
		{
			int num = 0;
			int num2 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(this.theZombieRow, num2 != 0);
			num3 = 0;
			bool flag;
			if (flag)
			{
				if (num != 0)
				{
				}
				while (flag)
				{
				}
				while (!flag)
				{
				}
			}
		}
		while (num3 != 0);
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x000A576C File Offset: 0x000A396C
	[Token(Token = "0x6001F26")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public BucketPaper()
	{
	}
}
