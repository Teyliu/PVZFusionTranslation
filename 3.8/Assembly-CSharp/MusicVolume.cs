using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008AD RID: 2221
[Token(Token = "0x20008AD")]
public class MusicVolume : MonoBehaviour
{
	// Token: 0x06002D27 RID: 11559 RVA: 0x000F8C10 File Offset: 0x000F6E10
	[Token(Token = "0x6002D27")]
	[Address(RVA = "0x684560", Offset = "0x682B60", VA = "0x180684560")]
	private void Start()
	{
		Slider component = base.GetComponent<Slider>();
		this.slider = component;
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		throw new NullReferenceException();
	}

	// Token: 0x06002D28 RID: 11560 RVA: 0x000F8C40 File Offset: 0x000F6E40
	[Token(Token = "0x6002D28")]
	[Address(RVA = "0x684620", Offset = "0x682C20", VA = "0x180684620")]
	private void Update()
	{
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		float value = slider.value;
		config.gameMusicVolume = value;
	}

	// Token: 0x06002D29 RID: 11561 RVA: 0x000F8C70 File Offset: 0x000F6E70
	[Token(Token = "0x6002D29")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public MusicVolume()
	{
	}

	// Token: 0x04001B55 RID: 6997
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B55")]
	private Slider slider;
}
