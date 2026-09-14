using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000786 RID: 1926
[Token(Token = "0x2000786")]
public class MusicUpdater
{
	// Token: 0x060026DE RID: 9950 RVA: 0x000CF9A4 File Offset: 0x000CDBA4
	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x603E70", Offset = "0x602470", VA = "0x180603E70")]
	public MusicUpdater(AudioSource a, AudioSource b)
	{
		this.music = a;
		this.musicDrum = b;
		float volume = a.volume;
		this.musicVolume = volume;
		float volume2 = b.volume;
		this.drumVolume = volume2;
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x000CF9E8 File Offset: 0x000CDBE8
	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x603E60", Offset = "0x602460", VA = "0x180603E60")]
	public void StopDrum()
	{
		int num = 0;
		this.needPlayDrum = false;
		this.drumVolume = (float)num;
		this.keepDrumingTime = (float)num;
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x000CFA0C File Offset: 0x000CDC0C
	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x6039C0", Offset = "0x601FC0", VA = "0x1806039C0")]
	public void MusicUpdate()
	{
		Board instance = Board.Instance;
		int num = 0;
		if (!(instance != num))
		{
			this.musicVolume = 1f;
		}
		if (Board.Instance.enermyCount < 10)
		{
			float num2 = this.keepDrumingTime;
			int num3 = 0;
			if (num2 > (float)num3)
			{
				float deltaTime = Time.deltaTime;
				this.keepDrumingTime = num2;
			}
			int num4 = 0;
			this.needPlayDrum = false;
			this.keepDrumingTime = (float)num4;
		}
		this.needPlayDrum = true;
		this.keepDrumingTime = 7.5f;
		int musicType = Board.Instance.musicType;
		if (musicType == 1)
		{
			this.DayMusicUpdate();
		}
		if (musicType == 2)
		{
			this.NightMusicUpdate();
		}
		this.drumVolume = 1f;
		this.musicVolume = 1f;
		int num5 = 0;
		this.needPlayDrum = false;
		this.drumVolume = (float)num5;
		this.keepDrumingTime = (float)num5;
		AudioSource audioSource = this.music;
		float num6 = this.musicVolume;
		GameConfig config = GameAPP.config;
		float num7 = num6 * config.gameMusicVolume;
		audioSource.volume = num7;
		GameConfig config2 = GameAPP.config;
		AudioSource audioSource2 = this.musicDrum;
		float num8 = config2.gameMusicVolume * this.drumVolume;
		audioSource2.volume = num8;
		PreludeMusic prelude = GameAPP.prelude;
		AudioSource audioSource3 = this.music;
		AudioSource audioSource4 = prelude.audioSource;
		num8 = audioSource3.volume;
		audioSource4.volume = num8;
	}

	// Token: 0x060026E1 RID: 9953 RVA: 0x000CFB5C File Offset: 0x000CDD5C
	[Token(Token = "0x60026E1")]
	[Address(RVA = "0x603550", Offset = "0x601B50", VA = "0x180603550")]
	private void DayMusicUpdate()
	{
		int num = 0;
		if ((this.needPlayDrum ? 1 : 0) == num)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			int num2 = 0;
			if (num2 != 0)
			{
			}
			this.musicVolume = 1f;
			float unscaledDeltaTime2 = Time.unscaledDeltaTime;
			if (num2 != 0)
			{
			}
		}
		float unscaledDeltaTime3 = Time.unscaledDeltaTime;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		if (num3 != 0)
		{
		}
		float num6 = this.drumVolume;
		this.musicVolume = (float)num5;
		float unscaledDeltaTime4 = Time.unscaledDeltaTime;
		if (num3 == 0 || 1f < (float)num4)
		{
		}
		float num7 = Time.time;
		ulong num8;
		num8 += num8;
		num8 += num8;
		if (typeof(Math).TypeHandle == num8)
		{
			AudioSource audioSource = this.music;
			int num9 = 0;
			if (audioSource != num9)
			{
				AudioSource audioSource2 = this.musicDrum;
				int num10 = 0;
				if (audioSource2 != num10)
				{
					AudioClip clip = this.music.clip;
					int num11 = 0;
					if (clip != num11)
					{
						AudioClip clip2 = this.musicDrum.clip;
						int num12 = 0;
						if (clip2 != num12)
						{
							float time = this.musicDrum.time;
							AudioSource audioSource3 = this.musicDrum;
							num6 = time;
							float length = audioSource3.clip.length;
							int num13;
							if (num4 > (int)num6 || num6 > length)
							{
								num13 = 0;
							}
							float time2 = this.music.time;
							AudioSource audioSource4 = this.music;
							num7 = time2;
							float length2 = audioSource4.clip.length;
							int num14;
							if (num4 > (int)num7 || num7 > length2)
							{
								num14 = 0;
							}
							float epsilon = Mathf.Epsilon;
							if (num14 * (int)1E-06f <= num13)
							{
								float length3 = this.music.clip.length;
								this.music.time = (float)num13;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060026E2 RID: 9954 RVA: 0x000CFD24 File Offset: 0x000CDF24
	[Token(Token = "0x60026E2")]
	[Address(RVA = "0x603C30", Offset = "0x602230", VA = "0x180603C30")]
	private void NightMusicUpdate()
	{
		while (this.needPlayDrum)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (num != 0)
			{
			}
			this.musicVolume = (float)num3;
			float unscaledDeltaTime2 = Time.unscaledDeltaTime;
			if (num == 0 || 1f < (float)num2)
			{
			}
			while (1f != (float)num2)
			{
			}
			this.music.Stop();
			if (!this.musicDrum.isPlaying)
			{
				throw new NullReferenceException();
			}
		}
		float unscaledDeltaTime3 = Time.unscaledDeltaTime;
		int num4 = 0;
		int num5 = 0;
		if (num4 != 0)
		{
		}
		this.musicVolume = 1f;
		float unscaledDeltaTime4 = Time.unscaledDeltaTime;
		int num6;
		if (num4 != 0)
		{
			num6 = 0;
			if (num6 < num5)
			{
			}
		}
		int num7 = 0;
		this.drumVolume = (float)num7;
		if (num6 == num5)
		{
			this.musicDrum.Stop();
			if (!this.music.isPlaying)
			{
				this.music.Play();
			}
		}
	}

	// Token: 0x040014BC RID: 5308
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014BC")]
	public float musicVolume;

	// Token: 0x040014BD RID: 5309
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40014BD")]
	public float drumVolume;

	// Token: 0x040014BE RID: 5310
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014BE")]
	private readonly AudioSource music;

	// Token: 0x040014BF RID: 5311
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014BF")]
	private readonly AudioSource musicDrum;

	// Token: 0x040014C0 RID: 5312
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014C0")]
	private bool needPlayDrum;

	// Token: 0x040014C1 RID: 5313
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40014C1")]
	private float keepDrumingTime;
}
