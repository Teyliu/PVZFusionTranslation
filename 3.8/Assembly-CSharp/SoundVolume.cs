using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008AF RID: 2223
[Token(Token = "0x20008AF")]
public class SoundVolume : MonoBehaviour
{
	// Token: 0x06002D2C RID: 11564 RVA: 0x000F8CB4 File Offset: 0x000F6EB4
	[Token(Token = "0x6002D2C")]
	[Address(RVA = "0x685130", Offset = "0x683730", VA = "0x180685130")]
	private void Start()
	{
		Slider component = base.GetComponent<Slider>();
		this.slider = component;
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		throw new NullReferenceException();
	}

	// Token: 0x06002D2D RID: 11565 RVA: 0x000F8CE4 File Offset: 0x000F6EE4
	[Token(Token = "0x6002D2D")]
	[Address(RVA = "0x6851F0", Offset = "0x6837F0", VA = "0x1806851F0")]
	private void Update()
	{
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		float value = slider.value;
		config.gameSoundVolume = value;
	}

	// Token: 0x06002D2E RID: 11566 RVA: 0x000F8D14 File Offset: 0x000F6F14
	[Token(Token = "0x6002D2E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SoundVolume()
	{
	}

	// Token: 0x04001B57 RID: 6999
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B57")]
	private Slider slider;
}
