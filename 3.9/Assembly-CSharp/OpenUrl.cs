using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020007CB RID: 1995
[Token(Token = "0x20007CB")]
public class OpenUrl : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x06002890 RID: 10384 RVA: 0x000DA958 File Offset: 0x000D8B58
	[Token(Token = "0x6002890")]
	[Address(RVA = "0x667700", Offset = "0x665D00", VA = "0x180667700", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
		Application.OpenURL(this.url);
	}

	// Token: 0x06002891 RID: 10385 RVA: 0x000DA970 File Offset: 0x000D8B70
	[Token(Token = "0x6002891")]
	[Address(RVA = "0x667750", Offset = "0x665D50", VA = "0x180667750")]
	public OpenUrl()
	{
	}

	// Token: 0x04001699 RID: 5785
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001699")]
	public string url = "https://space.bilibili.com/3546619314178489";
}
