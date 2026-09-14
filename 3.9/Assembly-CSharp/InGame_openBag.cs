using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000895 RID: 2197
[Token(Token = "0x2000895")]
public class InGame_openBag : UIButton
{
	// Token: 0x06002CDE RID: 11486 RVA: 0x000F47EC File Offset: 0x000F29EC
	[Token(Token = "0x6002CDE")]
	[Address(RVA = "0x6D0A90", Offset = "0x6CF090", VA = "0x1806D0A90")]
	private void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
	}

	// Token: 0x06002CDF RID: 11487 RVA: 0x000F4808 File Offset: 0x000F2A08
	[Token(Token = "0x6002CDF")]
	[Address(RVA = "0x6D0AE0", Offset = "0x6CF0E0", VA = "0x1806D0AE0", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		GameStatus theGameStatus = GameAPP.theGameStatus;
		if (theGameStatus == GameStatus.InGame || theGameStatus == GameStatus.Selecting)
		{
			this.ShowCards();
			return;
		}
	}

	// Token: 0x06002CE0 RID: 11488 RVA: 0x000F4830 File Offset: 0x000F2A30
	[Token(Token = "0x6002CE0")]
	[Address(RVA = "0x6D0C10", Offset = "0x6CF210", VA = "0x1806D0C10")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)98)) && this.col.enabled)
		{
			GameStatus theGameStatus = GameAPP.theGameStatus;
			if (theGameStatus == GameStatus.InGame || theGameStatus == GameStatus.Selecting)
			{
				this.ShowCards();
				return;
			}
		}
	}

	// Token: 0x06002CE1 RID: 11489 RVA: 0x000F4874 File Offset: 0x000F2A74
	[Token(Token = "0x6002CE1")]
	[Address(RVA = "0x6D0B60", Offset = "0x6CF160", VA = "0x1806D0B60")]
	private void ShowCards()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002CE2 RID: 11490 RVA: 0x000F4898 File Offset: 0x000F2A98
	[Token(Token = "0x6002CE2")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public InGame_openBag()
	{
	}

	// Token: 0x04001AC7 RID: 6855
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001AC7")]
	private Collider2D col;

	// Token: 0x04001AC8 RID: 6856
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001AC8")]
	private bool busy;
}
