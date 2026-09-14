using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DDB RID: 3547
	[Token(Token = "0x2000DDB")]
	public class Random_起死回生 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x0016C1C0 File Offset: 0x0016A3C0
		[Token(Token = "0x1700094D")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600498D")]
			[Address(RVA = "0x8A06C0", Offset = "0x89ECC0", VA = "0x1808A06C0", Slot = "12")]
			get
			{
				return AdvBuff.Random_起死回生;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600498E RID: 18830 RVA: 0x0016C1D4 File Offset: 0x0016A3D4
		[Token(Token = "0x1700094E")]
		public override string Description
		{
			[Token(Token = "0x600498E")]
			[Address(RVA = "0x8D0280", Offset = "0x8CE880", VA = "0x1808D0280", Slot = "13")]
			get
			{
				return "起死回生：在僵尸进家的1.5秒内击杀这个僵尸，则不会使游戏失败";
			}
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x0016C1E8 File Offset: 0x0016A3E8
		[Token(Token = "0x600498F")]
		[Address(RVA = "0x8D0240", Offset = "0x8CE840", VA = "0x1808D0240")]
		public Random_起死回生()
		{
		}
	}
}
