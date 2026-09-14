using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000744 RID: 1860
[Token(Token = "0x2000744")]
public class DifficultyMgr : MonoBehaviour
{
	// Token: 0x060025D2 RID: 9682 RVA: 0x000C74F4 File Offset: 0x000C56F4
	[Token(Token = "0x60025D2")]
	[Address(RVA = "0x5C18C0", Offset = "0x5BFEC0", VA = "0x1805C18C0")]
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

	// Token: 0x060025D3 RID: 9683 RVA: 0x000C753C File Offset: 0x000C573C
	[Token(Token = "0x60025D3")]
	[Address(RVA = "0x5C19D0", Offset = "0x5BFFD0", VA = "0x1805C19D0")]
	private void Update()
	{
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		float value = slider.value;
		float value2 = this.slider.value;
		TextMeshProUGUI textMeshProUGUI = this.t;
		textMeshProUGUI.text = "困难模式";
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x000C75F0 File Offset: 0x000C57F0
	[Token(Token = "0x60025D4")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public DifficultyMgr()
	{
	}

	// Token: 0x04001339 RID: 4921
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001339")]
	private Slider slider;

	// Token: 0x0400133A RID: 4922
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400133A")]
	private TextMeshProUGUI t;
}
