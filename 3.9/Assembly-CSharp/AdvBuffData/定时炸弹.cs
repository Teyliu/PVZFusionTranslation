using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DE4 RID: 3556
	[Token(Token = "0x2000DE4")]
	public class 定时炸弹 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060049AD RID: 18861 RVA: 0x0016C590 File Offset: 0x0016A790
		[Token(Token = "0x17000959")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60049AD")]
			[Address(RVA = "0x3F9C20", Offset = "0x3F8220", VA = "0x1803F9C20", Slot = "12")]
			get
			{
				return AdvBuff.定时炸弹;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060049AE RID: 18862 RVA: 0x0016C5A4 File Offset: 0x0016A7A4
		[Token(Token = "0x1700095A")]
		public override string Description
		{
			[Token(Token = "0x60049AE")]
			[Address(RVA = "0x8DBDD0", Offset = "0x8DA3D0", VA = "0x1808DBDD0", Slot = "13")]
			get
			{
				return "定时炸弹：魅惑僵尸死亡时，对附近释放爆炸对附近僵尸造成150%生命值上限的伤害";
			}
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x0016C5B8 File Offset: 0x0016A7B8
		[Token(Token = "0x60049AF")]
		[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
		public override void OnSelect(Board board)
		{
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x0016C5C8 File Offset: 0x0016A7C8
		[Token(Token = "0x60049B0")]
		[Address(RVA = "0x8DBC70", Offset = "0x8DA270", VA = "0x1808DBC70", Slot = "15")]
		public override void OnBoardStart(Board board)
		{
			if (定时炸弹.<>c.<>9__5_0 == 0)
			{
				Action<object> action;
				定时炸弹.<>c.<>9__5_0 = action;
			}
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x0016C5E4 File Offset: 0x0016A7E4
		[Token(Token = "0x60049B1")]
		[Address(RVA = "0x8DBD90", Offset = "0x8DA390", VA = "0x1808DBD90")]
		public 定时炸弹()
		{
		}
	}
}
