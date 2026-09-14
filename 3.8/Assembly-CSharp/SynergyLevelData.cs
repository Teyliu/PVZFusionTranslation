using System;
using Cpp2IlInjected;

// Token: 0x0200095B RID: 2395
[Token(Token = "0x200095B")]
public class SynergyLevelData
{
	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06003184 RID: 12676 RVA: 0x00104C48 File Offset: 0x00102E48
	// (set) Token: 0x06003185 RID: 12677 RVA: 0x00104C5C File Offset: 0x00102E5C
	[Token(Token = "0x170001C8")]
	public int ActiveCount
	{
		[Token(Token = "0x6003184")]
		[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420")]
		get;
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x4A9D70", Offset = "0x4A8370", VA = "0x1804A9D70")]
		set;
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06003186 RID: 12678 RVA: 0x00104C70 File Offset: 0x00102E70
	// (set) Token: 0x06003187 RID: 12679 RVA: 0x00104C84 File Offset: 0x00102E84
	[Token(Token = "0x170001C9")]
	public string Description
	{
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x3C9940", Offset = "0x3C7F40", VA = "0x1803C9940")]
		get;
		[Token(Token = "0x6003187")]
		[Address(RVA = "0x4A9D50", Offset = "0x4A8350", VA = "0x1804A9D50")]
		set;
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06003188 RID: 12680 RVA: 0x00104C98 File Offset: 0x00102E98
	// (set) Token: 0x06003189 RID: 12681 RVA: 0x00104CAC File Offset: 0x00102EAC
	[Token(Token = "0x170001CA")]
	public float Value
	{
		[Token(Token = "0x6003188")]
		[Address(RVA = "0x6F2140", Offset = "0x6F0740", VA = "0x1806F2140")]
		get;
		[Token(Token = "0x6003189")]
		[Address(RVA = "0x6F2160", Offset = "0x6F0760", VA = "0x1806F2160")]
		set;
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x0600318A RID: 12682 RVA: 0x00104CC0 File Offset: 0x00102EC0
	// (set) Token: 0x0600318B RID: 12683 RVA: 0x00104CD4 File Offset: 0x00102ED4
	[Token(Token = "0x170001CB")]
	public float Value2
	{
		[Token(Token = "0x600318A")]
		[Address(RVA = "0x6F2130", Offset = "0x6F0730", VA = "0x1806F2130")]
		get;
		[Token(Token = "0x600318B")]
		[Address(RVA = "0x6F2150", Offset = "0x6F0750", VA = "0x1806F2150")]
		set;
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x00104CE8 File Offset: 0x00102EE8
	[Token(Token = "0x600318C")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SynergyLevelData()
	{
	}
}
