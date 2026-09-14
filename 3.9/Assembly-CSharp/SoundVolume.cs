using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008EB RID: 2283
[Token(Token = "0x20008EB")]
public class SoundVolume : MonoBehaviour
{
	// Token: 0x06002E5F RID: 11871 RVA: 0x000FD838 File Offset: 0x000FBA38
	[Token(Token = "0x6002E5F")]
	[Address(RVA = "0x6FE6F0", Offset = "0x6FCCF0", VA = "0x1806FE6F0")]
	private void Start()
	{
		Slider component = base.GetComponent<Slider>();
		this.slider = component;
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		throw new NullReferenceException();
	}

	// Token: 0x06002E60 RID: 11872 RVA: 0x000FD868 File Offset: 0x000FBA68
	[Token(Token = "0x6002E60")]
	[Address(RVA = "0x6FE7B0", Offset = "0x6FCDB0", VA = "0x1806FE7B0")]
	private void Update()
	{
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		float value = slider.value;
		config.gameSoundVolume = value;
	}

	// Token: 0x06002E61 RID: 11873 RVA: 0x000FD898 File Offset: 0x000FBA98
	[Token(Token = "0x6002E61")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SoundVolume()
	{
	}

	// Token: 0x04001C47 RID: 7239
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C47")]
	private Slider slider;
}
