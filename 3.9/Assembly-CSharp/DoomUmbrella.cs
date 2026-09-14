using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000392 RID: 914
[Token(Token = "0x2000392")]
public class DoomUmbrella : CornUmbrella
{
	// Token: 0x060010C5 RID: 4293 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x4852B0", Offset = "0x4838B0", VA = "0x1804852B0", Slot = "70")]
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
		throw new NullReferenceException();
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x0005F6E8 File Offset: 0x0005D8E8
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x485370", Offset = "0x483970", VA = "0x180485370", Slot = "69")]
	protected override void BlockStart()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x0005F70C File Offset: 0x0005D90C
	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public DoomUmbrella()
	{
	}
}
