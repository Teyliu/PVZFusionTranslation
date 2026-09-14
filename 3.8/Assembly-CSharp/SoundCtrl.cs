using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007B9 RID: 1977
[Token(Token = "0x20007B9")]
public class SoundCtrl : MonoBehaviour
{
	// Token: 0x06002804 RID: 10244 RVA: 0x000D9B28 File Offset: 0x000D7D28
	[Token(Token = "0x6002804")]
	[Address(RVA = "0x630FC0", Offset = "0x62F5C0", VA = "0x180630FC0")]
	private void Start()
	{
		AudioSource component = base.GetComponent<AudioSource>();
		this.audioSource = component;
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x000D9B44 File Offset: 0x000D7D44
	[Token(Token = "0x6002805")]
	[Address(RVA = "0x631010", Offset = "0x62F610", VA = "0x180631010")]
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

	// Token: 0x06002806 RID: 10246 RVA: 0x000D9BAC File Offset: 0x000D7DAC
	[Token(Token = "0x6002806")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SoundCtrl()
	{
	}

	// Token: 0x04001671 RID: 5745
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001671")]
	public int theSoundID;

	// Token: 0x04001672 RID: 5746
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001672")]
	public float existTime;

	// Token: 0x04001673 RID: 5747
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001673")]
	private AudioSource audioSource;
}
