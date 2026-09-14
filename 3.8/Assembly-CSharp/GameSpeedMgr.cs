using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200074A RID: 1866
[Token(Token = "0x200074A")]
public class GameSpeedMgr : MonoBehaviour
{
	// Token: 0x060025EB RID: 9707 RVA: 0x000C9234 File Offset: 0x000C7434
	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x5C9840", Offset = "0x5C7E40", VA = "0x1805C9840")]
	private void Start()
	{
		Slider component = base.GetComponent<Slider>();
		this.slider = component;
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		throw new NullReferenceException();
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x000C9264 File Offset: 0x000C7464
	[Token(Token = "0x60025EC")]
	[Address(RVA = "0x5C9900", Offset = "0x5C7F00", VA = "0x1805C9900")]
	private void Update()
	{
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		float value = slider.value;
		config.gameSpeed = value;
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x000C9294 File Offset: 0x000C7494
	[Token(Token = "0x60025ED")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GameSpeedMgr()
	{
	}

	// Token: 0x04001388 RID: 5000
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001388")]
	private Slider slider;
}
