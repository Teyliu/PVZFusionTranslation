using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007F2 RID: 2034
[Token(Token = "0x20007F2")]
public class SoundCtrl : MonoBehaviour
{
	// Token: 0x06002933 RID: 10547 RVA: 0x000DEAE4 File Offset: 0x000DCCE4
	[Token(Token = "0x6002933")]
	[Address(RVA = "0x694D90", Offset = "0x693390", VA = "0x180694D90")]
	private void Start()
	{
		AudioSource component = base.GetComponent<AudioSource>();
		this.audioSource = component;
	}

	// Token: 0x06002934 RID: 10548 RVA: 0x000DEB00 File Offset: 0x000DCD00
	[Token(Token = "0x6002934")]
	[Address(RVA = "0x694DE0", Offset = "0x6933E0", VA = "0x180694DE0")]
	private void Update()
	{
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		AudioSource audioSource = this.audioSource;
		this.existTime = unscaledDeltaTime;
		AudioClip clip = audioSource.clip;
		int num = 0;
		if (!(clip == num))
		{
			AudioSource audioSource2 = this.audioSource;
			float num2 = this.existTime;
			float length = audioSource2.clip.length;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x000DEB68 File Offset: 0x000DCD68
	[Token(Token = "0x6002935")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SoundCtrl()
	{
	}

	// Token: 0x0400174D RID: 5965
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400174D")]
	public int theSoundID;

	// Token: 0x0400174E RID: 5966
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400174E")]
	public float existTime;

	// Token: 0x0400174F RID: 5967
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400174F")]
	private AudioSource audioSource;
}
