using System;
using Cpp2IlInjected;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
public class Debuff_格挡反击 : BaseDebuff
{
	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000BE RID: 190 RVA: 0x00004840 File Offset: 0x00002A40
	[Token(Token = "0x17000031")]
	public override string Description
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x3F2F20", Offset = "0x3F1520", VA = "0x1803F2F20", Slot = "13")]
		get
		{
			return "格挡反击：僵尸闪避时对附近植物造成100%反伤";
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000BF RID: 191 RVA: 0x00004854 File Offset: 0x00002A54
	[Token(Token = "0x17000032")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3F2F10", Offset = "0x3F1510", VA = "0x1803F2F10", Slot = "12")]
		get
		{
			return TravelDebuff.格挡反击;
		}
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00004868 File Offset: 0x00002A68
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00004878 File Offset: 0x00002A78
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x3F2DF0", Offset = "0x3F13F0", VA = "0x1803F2DF0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Debuff_格挡反击.<>c.<>9__5_0 == 0)
		{
			Action<object> action;
			Debuff_格挡反击.<>c.<>9__5_0 = action;
		}
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00004894 File Offset: 0x00002A94
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_格挡反击()
	{
	}
}
