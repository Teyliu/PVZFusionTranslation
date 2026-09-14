using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008E9 RID: 2281
[Token(Token = "0x20008E9")]
public class MusicVolume : MonoBehaviour
{
	// Token: 0x06002E5A RID: 11866 RVA: 0x000FD794 File Offset: 0x000FB994
	[Token(Token = "0x6002E5A")]
	[Address(RVA = "0x6FDB20", Offset = "0x6FC120", VA = "0x1806FDB20")]
	private void Start()
	{
		Slider component = base.GetComponent<Slider>();
		this.slider = component;
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		throw new NullReferenceException();
	}

	// Token: 0x06002E5B RID: 11867 RVA: 0x000FD7C4 File Offset: 0x000FB9C4
	[Token(Token = "0x6002E5B")]
	[Address(RVA = "0x6FDBE0", Offset = "0x6FC1E0", VA = "0x1806FDBE0")]
	private void Update()
	{
		Slider slider = this.slider;
		GameConfig config = GameAPP.config;
		float value = slider.value;
		config.gameMusicVolume = value;
	}

	// Token: 0x06002E5C RID: 11868 RVA: 0x000FD7F4 File Offset: 0x000FB9F4
	[Token(Token = "0x6002E5C")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public MusicVolume()
	{
	}

	// Token: 0x04001C45 RID: 7237
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C45")]
	private Slider slider;
}
