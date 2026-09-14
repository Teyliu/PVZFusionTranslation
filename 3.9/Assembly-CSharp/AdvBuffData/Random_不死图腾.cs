using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DC6 RID: 3526
	[Token(Token = "0x2000DC6")]
	public class Random_不死图腾 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x0016B9D8 File Offset: 0x00169BD8
		[Token(Token = "0x17000937")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004949")]
			[Address(RVA = "0x88D060", Offset = "0x88B660", VA = "0x18088D060", Slot = "12")]
			get
			{
				return AdvBuff.Random_不死图腾;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x0016B9EC File Offset: 0x00169BEC
		[Token(Token = "0x17000938")]
		public override string Description
		{
			[Token(Token = "0x600494A")]
			[Address(RVA = "0x8B1550", Offset = "0x8AFB50", VA = "0x1808B1550", Slot = "13")]
			get
			{
				return "不死图腾：下一次僵尸进家时，无视僵尸进家，持续3秒，并强制击退全场僵尸至底线";
			}
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x0016BA00 File Offset: 0x00169C00
		[Token(Token = "0x600494B")]
		[Address(RVA = "0x8B1510", Offset = "0x8AFB10", VA = "0x1808B1510")]
		public Random_不死图腾()
		{
		}
	}
}
