using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007BD RID: 1981
[Token(Token = "0x20007BD")]
public class SoundManager
{
	// Token: 0x06002803 RID: 10243 RVA: 0x000D45A0 File Offset: 0x000D27A0
	[Token(Token = "0x6002803")]
	[Address(RVA = "0x670620", Offset = "0x66EC20", VA = "0x180670620")]
	public SoundManager(AudioSource a1, AudioSource a2)
	{
		Dictionary<SoundType, AudioClip> dictionary = new Dictionary();
		this.sounds = dictionary;
		Dictionary<MusicType, AudioClip> dictionary2 = new Dictionary();
		this.musics = dictionary2;
		this.drumPairs = new Dictionary
		{
			{
				(uint)2,
				(uint)3
			},
			{
				(uint)4,
				(uint)5
			},
			{
				(uint)6,
				(uint)7
			},
			{
				(uint)8,
				(uint)9
			},
			{
				(uint)10,
				(uint)11
			},
			{
				(uint)19,
				(uint)20
			},
			{
				(uint)22,
				(uint)23
			},
			{
				(uint)24,
				(uint)25
			}
		};
		base..ctor();
		SoundManager.currentSoundCount = new Dictionary();
		Dictionary<SoundType, AudioClip> dict = global::Core.Lawnf.GetDict<SoundType, AudioClip>("Audio/Sound/", true);
		this.sounds = dict;
		Dictionary<MusicType, AudioClip> dict2 = global::Core.Lawnf.GetDict<MusicType, AudioClip>("Audio/Music/", true);
		this.musics = dict2;
		MusicUpdater musicUpdater;
		musicUpdater.music = a1;
		musicUpdater.musicDrum = a2;
		float volume = a1.volume;
		musicUpdater.musicVolume = volume;
		float volume2 = a2.volume;
		musicUpdater.drumVolume = volume2;
		this.musicUpdater = musicUpdater;
		throw new NullReferenceException();
	}

	// Token: 0x06002804 RID: 10244 RVA: 0x000D46A8 File Offset: 0x000D28A8
	[Token(Token = "0x6002804")]
	[Address(RVA = "0x66FEC0", Offset = "0x66E4C0", VA = "0x18066FEC0")]
	private void LoadSound()
	{
		Dictionary<SoundType, AudioClip> dict = global::Core.Lawnf.GetDict<SoundType, AudioClip>("Audio/Sound/", true);
		this.sounds = dict;
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x000D46C8 File Offset: 0x000D28C8
	[Token(Token = "0x6002805")]
	[Address(RVA = "0x66FE40", Offset = "0x66E440", VA = "0x18066FE40")]
	private void LoadMusic()
	{
		Dictionary<MusicType, AudioClip> dict = global::Core.Lawnf.GetDict<MusicType, AudioClip>("Audio/Music/", true);
		this.musics = dict;
	}

	// Token: 0x06002806 RID: 10246 RVA: 0x000D46E8 File Offset: 0x000D28E8
	[Token(Token = "0x6002806")]
	[Address(RVA = "0x670080", Offset = "0x66E680", VA = "0x180670080")]
	public bool TryGetMusicDrum(MusicType theMusicType, [Out] AudioClip drumMusicType)
	{
		Dictionary<MusicType, MusicType> dictionary = this.drumPairs;
		bool flag;
		if (!flag)
		{
		}
		Dictionary<MusicType, AudioClip> dictionary2 = this.musics;
		return true;
	}

	// Token: 0x06002807 RID: 10247 RVA: 0x000D4714 File Offset: 0x000D2914
	[Token(Token = "0x6002807")]
	[Address(RVA = "0x66FCB0", Offset = "0x66E2B0", VA = "0x18066FCB0")]
	public static float GetSoundPitch(int soundID, float defaultPitch)
	{
		if (soundID > 57)
		{
			if (soundID > 105)
			{
				return global::UnityEngine.Random.Range(1f, 1.3f);
			}
			if (soundID != 80)
			{
				return global::UnityEngine.Random.Range(0.8f, 1.2f);
			}
			float num;
			return global::UnityEngine.Random.Range(num, 1.4f);
		}
		else
		{
			if (soundID <= 17)
			{
				return global::UnityEngine.Random.Range(1f, 1.7f);
			}
			float num = global::UnityEngine.Random.Range(0.9f, 1.1f);
			return num;
		}
	}

	// Token: 0x06002808 RID: 10248 RVA: 0x000D47B0 File Offset: 0x000D29B0
	[Token(Token = "0x6002808")]
	[Address(RVA = "0x66FE10", Offset = "0x66E410", VA = "0x18066FE10")]
	public static float GetSoundStartTime(int soundID)
	{
		if (soundID > 2)
		{
		}
		if (soundID != 138)
		{
			return 0f;
		}
		return 0f;
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x000D47D8 File Offset: 0x000D29D8
	[Token(Token = "0x6002809")]
	[Address(RVA = "0x66FF40", Offset = "0x66E540", VA = "0x18066FF40")]
	public static Task<bool> PlaySound(AudioClip clip, float volume = 1f, float pitch = 1f, float startTime = 0f)
	{
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		Task task;
		return task;
	}

	// Token: 0x0600280A RID: 10250 RVA: 0x000D47FC File Offset: 0x000D29FC
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600280A")]
	[Address(RVA = "0x670150", Offset = "0x66E750", VA = "0x180670150")]
	static SoundManager()
	{
		Dictionary<MusicType, string> dictionary = new Dictionary();
		int num = 0;
		dictionary[num] = "主菜单";
		SoundManager.MusicNames = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x0400158A RID: 5514
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400158A")]
	public Dictionary<SoundType, AudioClip> sounds;

	// Token: 0x0400158B RID: 5515
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400158B")]
	public Dictionary<MusicType, AudioClip> musics;

	// Token: 0x0400158C RID: 5516
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400158C")]
	public MusicUpdater musicUpdater;

	// Token: 0x0400158D RID: 5517
	[Token(Token = "0x400158D")]
	[TupleElementNames(new string[] { "count", "time" })]
	public static Dictionary<SoundType, ValueTuple<int, float>> currentSoundCount;

	// Token: 0x0400158E RID: 5518
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400158E")]
	private readonly Dictionary<MusicType, MusicType> drumPairs;

	// Token: 0x0400158F RID: 5519
	[Token(Token = "0x400158F")]
	public static Dictionary<MusicType, string> MusicNames;
}
