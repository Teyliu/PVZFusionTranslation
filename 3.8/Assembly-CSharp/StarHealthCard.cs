using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000201 RID: 513
[Token(Token = "0x2000201")]
public class StarHealthCard : SpecialCard
{
	// Token: 0x060008AD RID: 2221 RVA: 0x0002D134 File Offset: 0x0002B334
	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x86F4B0", Offset = "0x86DAB0", VA = "0x18086F4B0", Slot = "10")]
	public override void ClickedEvent()
	{
		ulong num3;
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
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != (ulong)0L);
		ParticleManager instance = ParticleManager.Instance;
		InGameText instance2 = InGameText.Instance;
		int num4 = 0;
		instance2.ShowText("已为在场的植物回复20%最大生命值以及50点血量上限", 3f, num4 != 0);
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0002D1D8 File Offset: 0x0002B3D8
	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public StarHealthCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
