using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000207 RID: 519
[Token(Token = "0x2000207")]
public class StarDamageCard : SpecialCard
{
	// Token: 0x060008C5 RID: 2245 RVA: 0x0002D098 File Offset: 0x0002B298
	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x8FEE70", Offset = "0x8FD470", VA = "0x1808FEE70", Slot = "10")]
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
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x0002D128 File Offset: 0x0002B328
	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public StarDamageCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
