using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D1D RID: 3357
	[Token(Token = "0x2000D1D")]
	public class 元素反应 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06004610 RID: 17936 RVA: 0x00162184 File Offset: 0x00160384
		[Token(Token = "0x170007E1")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004610")]
			[Address(RVA = "0x850130", Offset = "0x84E730", VA = "0x180850130", Slot = "12")]
			get
			{
				return AdvBuff.元素反应;
			}
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00162198 File Offset: 0x00160398
		[Token(Token = "0x6004611")]
		[Address(RVA = "0x8500C0", Offset = "0x84E6C0", VA = "0x1808500C0", Slot = "13")]
		public override string GetDescription()
		{
			return "元素反应：究喷生成的雪爪改为黑曜石雪爪，火神攻击时还会附带黑曜石瓜，同时解锁冰火连携反应";
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x001621AC File Offset: 0x001603AC
		[Token(Token = "0x6004612")]
		[Address(RVA = "0x850090", Offset = "0x84E690", VA = "0x180850090")]
		public static void Explode(Zombie zombie)
		{
			int num = 0;
			zombie.JalaedExplode(num != 0, 300, true);
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x001621D0 File Offset: 0x001603D0
		[Token(Token = "0x6004613")]
		[Address(RVA = "0x8500F0", Offset = "0x84E6F0", VA = "0x1808500F0")]
		public 元素反应()
		{
		}
	}
}
