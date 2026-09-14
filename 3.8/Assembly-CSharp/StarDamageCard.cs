using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000200 RID: 512
[Token(Token = "0x2000200")]
public class StarDamageCard : SpecialCard
{
	// Token: 0x060008AB RID: 2219 RVA: 0x0002D06C File Offset: 0x0002B26C
	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x86F1D0", Offset = "0x86D7D0", VA = "0x18086F1D0", Slot = "10")]
	public override void ClickedEvent()
	{
		int num3;
		do
		{
			Board board = this.board;
			int num = this.theSeedCost;
			num += 50;
			this.theSeedCost = num;
			board.UseSun((float)num);
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			num3 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != 0);
		ParticleManager instance = ParticleManager.Instance;
		InGameText instance2 = InGameText.Instance;
		int num4 = 0;
		instance2.ShowText("已为在场的植物增加25%攻击力", 3f, num4 != 0);
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0002D114 File Offset: 0x0002B314
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public StarDamageCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
