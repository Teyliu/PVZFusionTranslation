using System;
using Cpp2IlInjected;

// Token: 0x02000811 RID: 2065
[Token(Token = "0x2000811")]
public class PageBtn : UIBtn
{
	// Token: 0x06002A09 RID: 10761 RVA: 0x000E5CA0 File Offset: 0x000E3EA0
	[Token(Token = "0x6002A09")]
	[Address(RVA = "0x63FF50", Offset = "0x63E550", VA = "0x18063FF50", Slot = "7")]
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

	// Token: 0x06002A0A RID: 10762 RVA: 0x000E5CF8 File Offset: 0x000E3EF8
	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0x63FFB0", Offset = "0x63E5B0", VA = "0x18063FFB0")]
	public PageBtn()
	{
	}

	// Token: 0x04001851 RID: 6225
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001851")]
	public bool next;

	// Token: 0x04001852 RID: 6226
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001852")]
	public int maxPage = (int)((ulong)1L);

	// Token: 0x04001853 RID: 6227
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001853")]
	public ClgLevelMgr clgLevel;
}
