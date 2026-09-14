using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068A RID: 1674
[Token(Token = "0x200068A")]
public class JackboxZombie : Zombie
{
	// Token: 0x0600203B RID: 8251 RVA: 0x000AAA9C File Offset: 0x000A8C9C
	[Token(Token = "0x600203B")]
	[Address(RVA = "0x552FE0", Offset = "0x5515E0", VA = "0x180552FE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		int num = global::UnityEngine.Random.Range(0, 100);
		float num2 = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.popCountDown = num2;
		float num3 = this.popCountDown;
		AudioSource audioSource = this.audioSource;
		this.originalCountDown = num3;
		AudioClip audioClip = GameAPP.soundManager.sounds[(uint)89];
		audioSource.clip = audioClip;
		GameConfig config = GameAPP.config;
		AudioSource audioSource2 = this.audioSource;
		float gameSoundVolume = config.gameSoundVolume;
		audioSource2.volume = gameSoundVolume;
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000AAB28 File Offset: 0x000A8D28
	[Token(Token = "0x600203C")]
	[Address(RVA = "0x5537C0", Offset = "0x551DC0", VA = "0x1805537C0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x000AAB3C File Offset: 0x000A8D3C
	[Token(Token = "0x600203D")]
	[Address(RVA = "0x553300", Offset = "0x551900", VA = "0x180553300", Slot = "74")]
	protected virtual void PopUpdate()
	{
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num = 0;
		GameObject gameObject = theUniqueItems[num];
		int num2 = 0;
		if (gameObject != num2)
		{
			float num3 = this.popCountDown;
			int num4 = 0;
			if (num3 > (float)num4)
			{
				float num5 = this.popCountDown;
				float deltaTime = Time.deltaTime;
				this.popCountDown = num5;
				this.anim.SetTrigger("pop");
				this.theUniqueItemType = (Zombie.UniqueItemType)((ulong)0L);
				GameAPP.PlaySound(global::UnityEngine.Random.Range(90, 92), 0.5f, 1f);
				AudioSource audioSource = this.audioSource;
				this.theStatus = (ZombieStatus)((ulong)11L);
				audioSource.Pause();
				this.audioSourcePlaying = false;
			}
		}
		AudioSource audioSource2 = this.audioSource;
		float gameSoundVolume = GameAPP.config.gameSoundVolume;
		audioSource2.volume = gameSoundVolume;
		if (this.audioSourcePlaying)
		{
			this.audioSource.Pause();
			this.audioSourcePlaying = false;
		}
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x000AAC24 File Offset: 0x000A8E24
	[Token(Token = "0x600203E")]
	[Address(RVA = "0x553550", Offset = "0x551B50", VA = "0x180553550")]
	public void Pop()
	{
		this.anim.SetTrigger("pop");
		this.theUniqueItemType = (Zombie.UniqueItemType)((ulong)0L);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(90, 92), 0.5f, 1f);
		AudioSource audioSource = this.audioSource;
		this.theStatus = (ZombieStatus)((ulong)11L);
		audioSource.Pause();
		this.audioSourcePlaying = false;
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000AAC88 File Offset: 0x000A8E88
	[Token(Token = "0x600203F")]
	[Address(RVA = "0x5532B0", Offset = "0x5518B0", VA = "0x1805532B0", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix = false, PlantType fromType = PlantType.Nothing)
	{
		int num;
		return num;
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x000AAC98 File Offset: 0x000A8E98
	[Token(Token = "0x6002040")]
	[Address(RVA = "0x552CC0", Offset = "0x5512C0", VA = "0x180552CC0", Slot = "75")]
	protected virtual void AnimExplode()
	{
		base.Die(2);
		Transform axis = this.axis;
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x000AACBC File Offset: 0x000A8EBC
	[Token(Token = "0x6002041")]
	[Address(RVA = "0x553220", Offset = "0x551820", VA = "0x180553220")]
	protected void Explode()
	{
		Transform axis = this.axis;
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x000AACDC File Offset: 0x000A8EDC
	[Token(Token = "0x6002042")]
	[Address(RVA = "0x553670", Offset = "0x551C70", VA = "0x180553670", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		this.popCountDown = 0.01f;
		if (this.AvaliableToPlay())
		{
			this.audioSource.Play();
			this.audioSourcePlaying = true;
		}
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x000AAD24 File Offset: 0x000A8F24
	[Token(Token = "0x6002043")]
	[Address(RVA = "0x553620", Offset = "0x551C20", VA = "0x180553620", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x000AAD54 File Offset: 0x000A8F54
	[Token(Token = "0x6002044")]
	[Address(RVA = "0x553770", Offset = "0x551D70", VA = "0x180553770", Slot = "47")]
	public override void Unfreezing()
	{
		base.Unfreezing();
		if (this.AvaliableToPlay())
		{
			this.audioSource.UnPause();
			this.audioSourcePlaying = true;
		}
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000AAD88 File Offset: 0x000A8F88
	[Token(Token = "0x6002045")]
	[Address(RVA = "0x553120", Offset = "0x551720", VA = "0x180553120", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
		base.Buttered(time, true);
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x000AADB8 File Offset: 0x000A8FB8
	[Token(Token = "0x6002046")]
	[Address(RVA = "0x553720", Offset = "0x551D20", VA = "0x180553720", Slot = "57")]
	protected override void UnButtered()
	{
		base.UnButtered();
		if (this.AvaliableToPlay())
		{
			this.audioSource.UnPause();
			this.audioSourcePlaying = true;
		}
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x000AADEC File Offset: 0x000A8FEC
	[Token(Token = "0x6002047")]
	[Address(RVA = "0x553170", Offset = "0x551770", VA = "0x180553170", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[58];
		component.sprite = sprite;
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x000AAE1C File Offset: 0x000A901C
	[Token(Token = "0x6002048")]
	[Address(RVA = "0x552D70", Offset = "0x551370", VA = "0x180552D70")]
	private bool AvaliableToPlay()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<GameObject> theUniqueItems = this.theUniqueItems;
			int num3 = 0;
			GameObject gameObject = theUniqueItems[num3];
			int num4 = 0;
			if (gameObject == num4)
			{
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
				if (!(num2 != this))
				{
					continue;
				}
			}
		}
		while (num2 != 0);
		return true;
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x000AAEA0 File Offset: 0x000A90A0
	[Token(Token = "0x6002049")]
	[Address(RVA = "0x5532D0", Offset = "0x5518D0", VA = "0x1805532D0", Slot = "33")]
	protected override void LoseHeadEvent()
	{
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x000AAEC8 File Offset: 0x000A90C8
	[Token(Token = "0x600204A")]
	[Address(RVA = "0x553840", Offset = "0x551E40", VA = "0x180553840")]
	public JackboxZombie()
	{
	}

	// Token: 0x040010C5 RID: 4293
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010C5")]
	public AudioSource audioSource;

	// Token: 0x040010C6 RID: 4294
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010C6")]
	public bool audioSourcePlaying;

	// Token: 0x040010C7 RID: 4295
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x40010C7")]
	public float popCountDown;

	// Token: 0x040010C8 RID: 4296
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40010C8")]
	protected float originalCountDown;
}
