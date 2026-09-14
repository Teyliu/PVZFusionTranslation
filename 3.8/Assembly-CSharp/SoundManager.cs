using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000784 RID: 1924
[Token(Token = "0x2000784")]
public class SoundManager
{
	// Token: 0x060026D4 RID: 9940 RVA: 0x000CF574 File Offset: 0x000CD774
	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x60CDD0", Offset = "0x60B3D0", VA = "0x18060CDD0")]
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

	// Token: 0x060026D5 RID: 9941 RVA: 0x000CF67C File Offset: 0x000CD87C
	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x60C670", Offset = "0x60AC70", VA = "0x18060C670")]
	private void LoadSound()
	{
		Dictionary<SoundType, AudioClip> dict = global::Core.Lawnf.GetDict<SoundType, AudioClip>("Audio/Sound/", true);
		this.sounds = dict;
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x000CF69C File Offset: 0x000CD89C
	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x60C5F0", Offset = "0x60ABF0", VA = "0x18060C5F0")]
	private void LoadMusic()
	{
		Dictionary<MusicType, AudioClip> dict = global::Core.Lawnf.GetDict<MusicType, AudioClip>("Audio/Music/", true);
		this.musics = dict;
	}

	// Token: 0x060026D7 RID: 9943 RVA: 0x000CF6BC File Offset: 0x000CD8BC
	[Token(Token = "0x60026D7")]
	[Address(RVA = "0x60C830", Offset = "0x60AE30", VA = "0x18060C830")]
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

	// Token: 0x060026D8 RID: 9944 RVA: 0x000CF6E8 File Offset: 0x000CD8E8
	[Token(Token = "0x60026D8")]
	[Address(RVA = "0x60C460", Offset = "0x60AA60", VA = "0x18060C460")]
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

	// Token: 0x060026D9 RID: 9945 RVA: 0x000CF784 File Offset: 0x000CD984
	[Token(Token = "0x60026D9")]
	[Address(RVA = "0x60C5C0", Offset = "0x60ABC0", VA = "0x18060C5C0")]
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

	// Token: 0x060026DA RID: 9946 RVA: 0x000CF7AC File Offset: 0x000CD9AC
	[Token(Token = "0x60026DA")]
	[Address(RVA = "0x60C6F0", Offset = "0x60ACF0", VA = "0x18060C6F0")]
	public static Task<bool> PlaySound(AudioClip clip, float volume = 1f, float pitch = 1f, float startTime = 0f)
	{
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		Task task;
		return task;
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x000CF7D0 File Offset: 0x000CD9D0
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60026DB")]
	[Address(RVA = "0x60C900", Offset = "0x60AF00", VA = "0x18060C900")]
	static SoundManager()
	{
		Dictionary<MusicType, string> dictionary = new Dictionary();
		int num = 0;
		dictionary[num] = "主菜单";
		SoundManager.MusicNames = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x040014AE RID: 5294
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014AE")]
	public Dictionary<SoundType, AudioClip> sounds;

	// Token: 0x040014AF RID: 5295
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014AF")]
	public Dictionary<MusicType, AudioClip> musics;

	// Token: 0x040014B0 RID: 5296
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014B0")]
	public MusicUpdater musicUpdater;

	// Token: 0x040014B1 RID: 5297
	[Token(Token = "0x40014B1")]
	[TupleElementNames(new string[] { "count", "time" })]
	public static Dictionary<SoundType, ValueTuple<int, float>> currentSoundCount;

	// Token: 0x040014B2 RID: 5298
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014B2")]
	private readonly Dictionary<MusicType, MusicType> drumPairs;

	// Token: 0x040014B3 RID: 5299
	[Token(Token = "0x40014B3")]
	public static Dictionary<MusicType, string> MusicNames;
}
