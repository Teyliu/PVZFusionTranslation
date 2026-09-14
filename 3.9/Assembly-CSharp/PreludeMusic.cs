using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007E3 RID: 2019
[Token(Token = "0x20007E3")]
public class PreludeMusic : MonoBehaviour
{
	// Token: 0x060028FE RID: 10494 RVA: 0x000DD14C File Offset: 0x000DB34C
	[Token(Token = "0x60028FE")]
	[Address(RVA = "0x66B800", Offset = "0x669E00", VA = "0x18066B800")]
	private void Awake()
	{
		AudioSource component = base.GetComponent<AudioSource>();
		this.audioSource = component;
	}

	// Token: 0x060028FF RID: 10495 RVA: 0x000DD168 File Offset: 0x000DB368
	[Token(Token = "0x60028FF")]
	[Address(RVA = "0x66B850", Offset = "0x669E50", VA = "0x18066B850")]
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

	// Token: 0x06002900 RID: 10496 RVA: 0x000DD1E0 File Offset: 0x000DB3E0
	[Token(Token = "0x6002900")]
	[Address(RVA = "0x66B9F0", Offset = "0x669FF0", VA = "0x18066B9F0")]
	private IEnumerator PreludeOver()
	{
		PreludeMusic.<PreludeOver>d__3 <PreludeOver>d__;
		<PreludeOver>d__.System.IDisposable.Dispose();
		<PreludeOver>d__.<>1__state = (int)((ulong)0L);
		<PreludeOver>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002901 RID: 10497 RVA: 0x000DD204 File Offset: 0x000DB404
	[Token(Token = "0x6002901")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public PreludeMusic()
	{
	}

	// Token: 0x040016E8 RID: 5864
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016E8")]
	public AudioSource audioSource;
}
