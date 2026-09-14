using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000209 RID: 521
[Token(Token = "0x2000209")]
public class ZombieCardPackage : MonoBehaviour
{
	// Token: 0x060008C9 RID: 2249 RVA: 0x0002D1F4 File Offset: 0x0002B3F4
	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x8FF6A0", Offset = "0x8FDCA0", VA = "0x1808FF6A0")]
	private void Awake()
	{
		this.card.zombieCardPackage = this;
		throw new NullReferenceException();
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x0002D214 File Offset: 0x0002B414
	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x8FF6D0", Offset = "0x8FDCD0", VA = "0x1808FF6D0")]
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

	// Token: 0x060008CB RID: 2251 RVA: 0x0002D260 File Offset: 0x0002B460
	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ZombieCardPackage()
	{
	}

	// Token: 0x0400044E RID: 1102
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400044E")]
	public Image backgroundIcon;

	// Token: 0x0400044F RID: 1103
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400044F")]
	public IZECard card;
}
