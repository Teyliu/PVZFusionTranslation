using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008DA RID: 2266
[Token(Token = "0x20008DA")]
public class UIDifficulty : MonoBehaviour
{
	// Token: 0x06002E28 RID: 11816 RVA: 0x000FC984 File Offset: 0x000FAB84
	[Token(Token = "0x6002E28")]
	[Address(RVA = "0x70EB20", Offset = "0x70D120", VA = "0x18070EB20")]
	private void Start()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.t = component;
	}

	// Token: 0x06002E29 RID: 11817 RVA: 0x000FC9A0 File Offset: 0x000FABA0
	[Token(Token = "0x6002E29")]
	[Address(RVA = "0x70EB70", Offset = "0x70D170", VA = "0x18070EB70")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.t;
		int difficulty = GameAPP.config.difficulty;
		string text = string.Format("难度：{0}", difficulty);
		textMeshProUGUI.text = text;
	}

	// Token: 0x06002E2A RID: 11818 RVA: 0x000FC9E0 File Offset: 0x000FABE0
	[Token(Token = "0x6002E2A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public UIDifficulty()
	{
	}

	// Token: 0x04001C06 RID: 7174
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C06")]
	private TextMeshProUGUI t;
}
