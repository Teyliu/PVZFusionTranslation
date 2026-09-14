using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FB RID: 763
[Token(Token = "0x20002FB")]
public class RainControl : MonoBehaviour
{
	// Token: 0x06000DAB RID: 3499 RVA: 0x0004E090 File Offset: 0x0004C290
	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x455CE0", Offset = "0x4542E0", VA = "0x180455CE0")]
	private void Update()
	{
		AudioSource audioSource2;
		for (;;)
		{
			AudioSource audioSource = this.audioSource;
			MusicUpdater musicUpdater = GameAPP.soundManager.musicUpdater;
			GameConfig config = GameAPP.config;
			float num = musicUpdater.musicVolume * 0.5f * config.gameMusicVolume;
			audioSource.volume = num;
			float timeScale = Time.timeScale;
			audioSource2 = this.audioSource;
			if (audioSource2 == 0)
			{
				break;
			}
			if (!audioSource2.isPlaying)
			{
				goto Block_2;
			}
		}
		if (audioSource2.isPlaying)
		{
			this.audioSource.Pause();
		}
		return;
		Block_2:
		this.audioSource.UnPause();
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x0004E118 File Offset: 0x0004C318
	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public RainControl()
	{
	}

	// Token: 0x04000A6D RID: 2669
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A6D")]
	public ParticleSystem particle;

	// Token: 0x04000A6E RID: 2670
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A6E")]
	public AudioSource audioSource;
}
