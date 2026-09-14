using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000859 RID: 2137
[Token(Token = "0x2000859")]
public class InGame_openBag : UIButton
{
	// Token: 0x06002BAC RID: 11180 RVA: 0x000EFB94 File Offset: 0x000EDD94
	[Token(Token = "0x6002BAC")]
	[Address(RVA = "0x66BF80", Offset = "0x66A580", VA = "0x18066BF80")]
	private void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
	}

	// Token: 0x06002BAD RID: 11181 RVA: 0x000EFBB0 File Offset: 0x000EDDB0
	[Token(Token = "0x6002BAD")]
	[Address(RVA = "0x66BFD0", Offset = "0x66A5D0", VA = "0x18066BFD0", Slot = "9")]
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

	// Token: 0x06002BAE RID: 11182 RVA: 0x000EFBD8 File Offset: 0x000EDDD8
	[Token(Token = "0x6002BAE")]
	[Address(RVA = "0x66C100", Offset = "0x66A700", VA = "0x18066C100")]
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

	// Token: 0x06002BAF RID: 11183 RVA: 0x000EFC1C File Offset: 0x000EDE1C
	[Token(Token = "0x6002BAF")]
	[Address(RVA = "0x66C050", Offset = "0x66A650", VA = "0x18066C050")]
	private void ShowCards()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002BB0 RID: 11184 RVA: 0x000EFC40 File Offset: 0x000EDE40
	[Token(Token = "0x6002BB0")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public InGame_openBag()
	{
	}

	// Token: 0x040019D9 RID: 6617
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40019D9")]
	private Collider2D col;

	// Token: 0x040019DA RID: 6618
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40019DA")]
	private bool busy;
}
