using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
public class ZombieCardPackage : MonoBehaviour
{
	// Token: 0x060008AF RID: 2223 RVA: 0x0002D1F8 File Offset: 0x0002B3F8
	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x86F9E0", Offset = "0x86DFE0", VA = "0x18086F9E0")]
	private void Awake()
	{
		this.card.zombieCardPackage = this;
		throw new NullReferenceException();
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x0002D218 File Offset: 0x0002B418
	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x86FA10", Offset = "0x86E010", VA = "0x18086FA10")]
	public void UpdateSprite(Sprite sprite)
	{
		Image image = this.backgroundIcon;
		RectTransform component = image.GetComponent<RectTransform>();
		this.backgroundIcon.sprite = sprite;
		image.SetNativeSize();
		Vector2 sizeDelta = component.sizeDelta;
		int num = 0;
		Vector2 sizeDelta2 = component.sizeDelta;
		component.sizeDelta = num;
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x0002D264 File Offset: 0x0002B464
	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ZombieCardPackage()
	{
	}

	// Token: 0x04000444 RID: 1092
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000444")]
	public Image backgroundIcon;

	// Token: 0x04000445 RID: 1093
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000445")]
	public IZECard card;
}
