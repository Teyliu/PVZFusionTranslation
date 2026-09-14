using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007AA RID: 1962
[Token(Token = "0x20007AA")]
public class PreludeMusic : MonoBehaviour
{
	// Token: 0x060027CF RID: 10191 RVA: 0x000D8190 File Offset: 0x000D6390
	[Token(Token = "0x60027CF")]
	[Address(RVA = "0x607FB0", Offset = "0x6065B0", VA = "0x180607FB0")]
	private void Awake()
	{
		AudioSource component = base.GetComponent<AudioSource>();
		this.audioSource = component;
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x000D81AC File Offset: 0x000D63AC
	[Token(Token = "0x60027D0")]
	[Address(RVA = "0x608000", Offset = "0x606600", VA = "0x180608000")]
	public void OnActive(MusicType musicType)
	{
		Dictionary<MusicType, AudioClip> musics = GameAPP.soundManager.musics;
		AudioSource audioSource = this.audioSource;
		this.audioSource.Play();
		PreludeMusic.<PreludeOver>d__3 <PreludeOver>d__;
		<PreludeOver>d__.System.IDisposable.Dispose();
		<PreludeOver>d__.<>1__state = (int)((ulong)0L);
		<PreludeOver>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<PreludeOver>d__);
		MusicType valueOrDefault = CollectionExtensions.GetValueOrDefault<MusicType, AudioClip>(GameAPP.soundManager.musics, (uint)10);
		MusicType valueOrDefault2 = CollectionExtensions.GetValueOrDefault<MusicType, AudioClip>(GameAPP.soundManager.musics, (uint)11);
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x000D8224 File Offset: 0x000D6424
	[Token(Token = "0x60027D1")]
	[Address(RVA = "0x6081A0", Offset = "0x6067A0", VA = "0x1806081A0")]
	private IEnumerator PreludeOver()
	{
		PreludeMusic.<PreludeOver>d__3 <PreludeOver>d__;
		<PreludeOver>d__.System.IDisposable.Dispose();
		<PreludeOver>d__.<>1__state = (int)((ulong)0L);
		<PreludeOver>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x000D8248 File Offset: 0x000D6448
	[Token(Token = "0x60027D2")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public PreludeMusic()
	{
	}

	// Token: 0x0400160C RID: 5644
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400160C")]
	public AudioSource audioSource;
}
