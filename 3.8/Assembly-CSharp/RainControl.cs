using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002ED RID: 749
[Token(Token = "0x20002ED")]
public class RainControl : MonoBehaviour
{
	// Token: 0x06000D68 RID: 3432 RVA: 0x0004D41C File Offset: 0x0004B61C
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x3F9C90", Offset = "0x3F8290", VA = "0x1803F9C90")]
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

	// Token: 0x06000D69 RID: 3433 RVA: 0x0004D4A4 File Offset: 0x0004B6A4
	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public RainControl()
	{
	}

	// Token: 0x04000A2E RID: 2606
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A2E")]
	public ParticleSystem particle;

	// Token: 0x04000A2F RID: 2607
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A2F")]
	public AudioSource audioSource;
}
