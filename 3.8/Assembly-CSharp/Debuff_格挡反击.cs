using System;
using Cpp2IlInjected;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
public class Debuff_格挡反击 : BaseDebuff
{
	// Token: 0x060000A3 RID: 163 RVA: 0x000044B4 File Offset: 0x000026B4
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x3A6E60", Offset = "0x3A5460", VA = "0x1803A6E60", Slot = "13")]
	public override string GetDescription()
	{
		return "格挡反击：僵尸闪避时对附近植物造成100%反伤";
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000A4 RID: 164 RVA: 0x000044C8 File Offset: 0x000026C8
	[Token(Token = "0x17000028")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x3A6FB0", Offset = "0x3A55B0", VA = "0x1803A6FB0", Slot = "12")]
		get
		{
			return TravelDebuff.格挡反击;
		}
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x000044DC File Offset: 0x000026DC
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000044EC File Offset: 0x000026EC
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x3A6E90", Offset = "0x3A5490", VA = "0x1803A6E90", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Debuff_格挡反击.<>c.<>9__4_0 == 0)
		{
			Action<object> action;
			Debuff_格挡反击.<>c.<>9__4_0 = action;
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00004508 File Offset: 0x00002708
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_格挡反击()
	{
	}
}
