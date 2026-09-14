using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DDF RID: 3551
	[Token(Token = "0x2000DDF")]
	public class Random_融合召唤 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600499A RID: 18842 RVA: 0x0016C30C File Offset: 0x0016A50C
		[Token(Token = "0x17000953")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600499A")]
			[Address(RVA = "0x89F9D0", Offset = "0x89DFD0", VA = "0x18089F9D0", Slot = "12")]
			get
			{
				return AdvBuff.Random_融合召唤;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600499B RID: 18843 RVA: 0x0016C320 File Offset: 0x0016A520
		[Token(Token = "0x17000954")]
		public override string Description
		{
			[Token(Token = "0x600499B")]
			[Address(RVA = "0x8D0210", Offset = "0x8CE810", VA = "0x1808D0210", Slot = "13")]
			get
			{
				return "融合召唤：使用手套将一个植物移动到其他同星级同类型的植物上时，会将该植物提升1级";
			}
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x0016C334 File Offset: 0x0016A534
		[Token(Token = "0x600499C")]
		[Address(RVA = "0x8D00B0", Offset = "0x8CE6B0", VA = "0x1808D00B0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			if (Random_融合召唤.<>c.<>9__4_0 == 0)
			{
				Action<object> action;
				Random_融合召唤.<>c.<>9__4_0 = action;
			}
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x0016C350 File Offset: 0x0016A550
		[Token(Token = "0x600499D")]
		[Address(RVA = "0x8CF7F0", Offset = "0x8CDDF0", VA = "0x1808CF7F0", Slot = "15")]
		public override void OnBoardStart(Board board)
		{
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x0016C360 File Offset: 0x0016A560
		[Token(Token = "0x600499E")]
		[Address(RVA = "0x8D01D0", Offset = "0x8CE7D0", VA = "0x1808D01D0")]
		public Random_融合召唤()
		{
		}
	}
}
