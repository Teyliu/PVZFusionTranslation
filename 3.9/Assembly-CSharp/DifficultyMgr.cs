using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200077D RID: 1917
[Token(Token = "0x200077D")]
public class DifficultyMgr : MonoBehaviour
{
	// Token: 0x060026F7 RID: 9975 RVA: 0x000CC3F0 File Offset: 0x000CA5F0
	[Token(Token = "0x60026F7")]
	[Address(RVA = "0x622440", Offset = "0x620A40", VA = "0x180622440")]
	private void Start()
	{
		Slider component = base.GetComponent<Slider>();
		this.slider = component;
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		TextMeshProUGUI component2 = base.transform.GetChild(3).GetComponent<TextMeshProUGUI>();
		this.t = component2;
		throw new NullReferenceException();
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x000CC438 File Offset: 0x000CA638
	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x622550", Offset = "0x620B50", VA = "0x180622550")]
	private void Update()
	{
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		float value = slider.value;
		float value2 = this.slider.value;
		TextMeshProUGUI textMeshProUGUI = this.t;
		textMeshProUGUI.text = "困难模式";
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x000CC4EC File Offset: 0x000CA6EC
	[Token(Token = "0x60026F9")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public DifficultyMgr()
	{
	}

	// Token: 0x0400140F RID: 5135
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400140F")]
	private Slider slider;

	// Token: 0x04001410 RID: 5136
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001410")]
	private TextMeshProUGUI t;
}
