using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DE6 RID: 3558
	[Token(Token = "0x2000DE6")]
	public class 元素反应 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060049B5 RID: 18869 RVA: 0x0016C694 File Offset: 0x0016A894
		[Token(Token = "0x1700095B")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60049B5")]
			[Address(RVA = "0x8DBC30", Offset = "0x8DA230", VA = "0x1808DBC30", Slot = "12")]
			get
			{
				return AdvBuff.元素反应;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060049B6 RID: 18870 RVA: 0x0016C6A8 File Offset: 0x0016A8A8
		[Token(Token = "0x1700095C")]
		public override string Description
		{
			[Token(Token = "0x60049B6")]
			[Address(RVA = "0x8DBC40", Offset = "0x8DA240", VA = "0x1808DBC40", Slot = "13")]
			get
			{
				return "元素反应：究喷生成的雪爪改为黑曜石雪爪，火神攻击时还会附带黑曜石瓜，同时解锁冰火连携反应";
			}
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x0016C6BC File Offset: 0x0016A8BC
		[Token(Token = "0x60049B7")]
		[Address(RVA = "0x8DBBC0", Offset = "0x8DA1C0", VA = "0x1808DBBC0")]
		public static void Explode(Zombie zombie)
		{
			int num = 0;
			zombie.JalaedExplode(num != 0, 300, true);
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x0016C6E0 File Offset: 0x0016A8E0
		[Token(Token = "0x60049B8")]
		[Address(RVA = "0x8DBBF0", Offset = "0x8DA1F0", VA = "0x1808DBBF0")]
		public 元素反应()
		{
		}
	}
}
