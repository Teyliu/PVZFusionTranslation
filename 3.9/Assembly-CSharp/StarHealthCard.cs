using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000208 RID: 520
[Token(Token = "0x2000208")]
public class StarHealthCard : SpecialCard
{
	// Token: 0x060008C7 RID: 2247 RVA: 0x0002D148 File Offset: 0x0002B348
	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x8FF160", Offset = "0x8FD760", VA = "0x1808FF160", Slot = "10")]
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
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x0002D1D4 File Offset: 0x0002B3D4
	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public StarHealthCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
