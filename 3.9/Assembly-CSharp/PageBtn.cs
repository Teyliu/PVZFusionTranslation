using System;
using Cpp2IlInjected;

// Token: 0x0200084F RID: 2127
[Token(Token = "0x200084F")]
public class PageBtn : UIBtn
{
	// Token: 0x06002B47 RID: 11079 RVA: 0x000EAFE0 File Offset: 0x000E91E0
	[Token(Token = "0x6002B47")]
	[Address(RVA = "0x6A4600", Offset = "0x6A2C00", VA = "0x1806A4600", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		int num = this.clgLevel.currentPage;
		if (!this.next)
		{
			if (num > 0)
			{
				this.clgLevel.ChangePage(num);
				return;
			}
		}
		else if (num < this.maxPage)
		{
			num++;
		}
		this.clgLevel.ChangePage(num);
	}

	// Token: 0x06002B48 RID: 11080 RVA: 0x000EB038 File Offset: 0x000E9238
	[Token(Token = "0x6002B48")]
	[Address(RVA = "0x6A4660", Offset = "0x6A2C60", VA = "0x1806A4660")]
	public PageBtn()
	{
	}

	// Token: 0x0400194D RID: 6477
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400194D")]
	public bool next;

	// Token: 0x0400194E RID: 6478
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400194E")]
	public int maxPage = (int)((ulong)1L);

	// Token: 0x0400194F RID: 6479
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400194F")]
	public ClgLevelMgr clgLevel;
}
