using System;
using Cpp2IlInjected;

// Token: 0x02000997 RID: 2455
[Token(Token = "0x2000997")]
public class SynergyLevelData
{
	// Token: 0x17000210 RID: 528
	// (get) Token: 0x060032B7 RID: 12983 RVA: 0x001099C8 File Offset: 0x00107BC8
	// (set) Token: 0x060032B8 RID: 12984 RVA: 0x001099DC File Offset: 0x00107BDC
	[Token(Token = "0x17000210")]
	public int ActiveCount
	{
		[Token(Token = "0x60032B7")]
		[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430")]
		get;
		[Token(Token = "0x60032B8")]
		[Address(RVA = "0x5159A0", Offset = "0x513FA0", VA = "0x1805159A0")]
		set;
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x060032B9 RID: 12985 RVA: 0x001099F0 File Offset: 0x00107BF0
	// (set) Token: 0x060032BA RID: 12986 RVA: 0x00109A04 File Offset: 0x00107C04
	[Token(Token = "0x17000211")]
	public string Description
	{
		[Token(Token = "0x60032B9")]
		[Address(RVA = "0x3FDA60", Offset = "0x3FC060", VA = "0x1803FDA60")]
		get;
		[Token(Token = "0x60032BA")]
		[Address(RVA = "0x515980", Offset = "0x513F80", VA = "0x180515980")]
		set;
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x060032BB RID: 12987 RVA: 0x00109A18 File Offset: 0x00107C18
	// (set) Token: 0x060032BC RID: 12988 RVA: 0x00109A2C File Offset: 0x00107C2C
	[Token(Token = "0x17000212")]
	public float Value
	{
		[Token(Token = "0x60032BB")]
		[Address(RVA = "0x7574D0", Offset = "0x755AD0", VA = "0x1807574D0")]
		get;
		[Token(Token = "0x60032BC")]
		[Address(RVA = "0x7574F0", Offset = "0x755AF0", VA = "0x1807574F0")]
		set;
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x060032BD RID: 12989 RVA: 0x00109A40 File Offset: 0x00107C40
	// (set) Token: 0x060032BE RID: 12990 RVA: 0x00109A54 File Offset: 0x00107C54
	[Token(Token = "0x17000213")]
	public float Value2
	{
		[Token(Token = "0x60032BD")]
		[Address(RVA = "0x7574C0", Offset = "0x755AC0", VA = "0x1807574C0")]
		get;
		[Token(Token = "0x60032BE")]
		[Address(RVA = "0x7574E0", Offset = "0x755AE0", VA = "0x1807574E0")]
		set;
	}

	// Token: 0x060032BF RID: 12991 RVA: 0x00109A68 File Offset: 0x00107C68
	[Token(Token = "0x60032BF")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SynergyLevelData()
	{
	}
}
