using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000792 RID: 1938
[Token(Token = "0x2000792")]
public class OpenUrl : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x06002761 RID: 10081 RVA: 0x000D5970 File Offset: 0x000D3B70
	[Token(Token = "0x6002761")]
	[Address(RVA = "0x603EF0", Offset = "0x6024F0", VA = "0x180603EF0", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
		Application.OpenURL(this.url);
	}

	// Token: 0x06002762 RID: 10082 RVA: 0x000D5988 File Offset: 0x000D3B88
	[Token(Token = "0x6002762")]
	[Address(RVA = "0x603F40", Offset = "0x602540", VA = "0x180603F40")]
	public OpenUrl()
	{
	}

	// Token: 0x040015BD RID: 5565
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40015BD")]
	public string url = "https://space.bilibili.com/3546619314178489";
}
