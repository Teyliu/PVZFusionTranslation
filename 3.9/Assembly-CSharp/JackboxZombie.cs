using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C0 RID: 1728
[Token(Token = "0x20006C0")]
public class JackboxZombie : Zombie
{
	// Token: 0x0600213D RID: 8509 RVA: 0x000AF3C4 File Offset: 0x000AD5C4
	[Token(Token = "0x600213D")]
	[Address(RVA = "0x5B6B80", Offset = "0x5B5180", VA = "0x1805B6B80", Slot = "10")]
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

	// Token: 0x0600213E RID: 8510 RVA: 0x000AF450 File Offset: 0x000AD650
	[Token(Token = "0x600213E")]
	[Address(RVA = "0x5B7360", Offset = "0x5B5960", VA = "0x1805B7360", Slot = "17")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x000AF464 File Offset: 0x000AD664
	[Token(Token = "0x600213F")]
	[Address(RVA = "0x5B6EA0", Offset = "0x5B54A0", VA = "0x1805B6EA0", Slot = "76")]
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

	// Token: 0x06002140 RID: 8512 RVA: 0x000AF54C File Offset: 0x000AD74C
	[Token(Token = "0x6002140")]
	[Address(RVA = "0x5B70F0", Offset = "0x5B56F0", VA = "0x1805B70F0")]
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

	// Token: 0x06002141 RID: 8513 RVA: 0x000AF5B0 File Offset: 0x000AD7B0
	[Token(Token = "0x6002141")]
	[Address(RVA = "0x5B6E50", Offset = "0x5B5450", VA = "0x1805B6E50", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix = false, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x000AF5C4 File Offset: 0x000AD7C4
	[Token(Token = "0x6002142")]
	[Address(RVA = "0x5B6860", Offset = "0x5B4E60", VA = "0x1805B6860", Slot = "77")]
	protected virtual void AnimExplode()
	{
		base.Die(2);
		Transform axis = this.axis;
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x000AF5E8 File Offset: 0x000AD7E8
	[Token(Token = "0x6002143")]
	[Address(RVA = "0x5B6DC0", Offset = "0x5B53C0", VA = "0x1805B6DC0")]
	protected void Explode()
	{
		Transform axis = this.axis;
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x000AF608 File Offset: 0x000AD808
	[Token(Token = "0x6002144")]
	[Address(RVA = "0x5B7210", Offset = "0x5B5810", VA = "0x1805B7210", Slot = "16")]
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

	// Token: 0x06002145 RID: 8517 RVA: 0x000AF650 File Offset: 0x000AD850
	[Token(Token = "0x6002145")]
	[Address(RVA = "0x5B71C0", Offset = "0x5B57C0", VA = "0x1805B71C0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x000AF680 File Offset: 0x000AD880
	[Token(Token = "0x6002146")]
	[Address(RVA = "0x5B7310", Offset = "0x5B5910", VA = "0x1805B7310", Slot = "49")]
	public override void Unfreezing()
	{
		base.Unfreezing();
		if (this.AvaliableToPlay())
		{
			this.audioSource.UnPause();
			this.audioSourcePlaying = true;
		}
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x000AF6B4 File Offset: 0x000AD8B4
	[Token(Token = "0x6002147")]
	[Address(RVA = "0x5B6CC0", Offset = "0x5B52C0", VA = "0x1805B6CC0", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
		base.Buttered(time, true);
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x000AF6E4 File Offset: 0x000AD8E4
	[Token(Token = "0x6002148")]
	[Address(RVA = "0x5B72C0", Offset = "0x5B58C0", VA = "0x1805B72C0", Slot = "59")]
	protected override void UnButtered()
	{
		base.UnButtered();
		if (this.AvaliableToPlay())
		{
			this.audioSource.UnPause();
			this.audioSourcePlaying = true;
		}
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x000AF718 File Offset: 0x000AD918
	[Token(Token = "0x6002149")]
	[Address(RVA = "0x5B6D10", Offset = "0x5B5310", VA = "0x1805B6D10", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[58];
		component.sprite = sprite;
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x000AF748 File Offset: 0x000AD948
	[Token(Token = "0x600214A")]
	[Address(RVA = "0x5B6910", Offset = "0x5B4F10", VA = "0x1805B6910")]
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

	// Token: 0x0600214B RID: 8523 RVA: 0x000AF7CC File Offset: 0x000AD9CC
	[Token(Token = "0x600214B")]
	[Address(RVA = "0x5B6E70", Offset = "0x5B5470", VA = "0x1805B6E70", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x000AF7F4 File Offset: 0x000AD9F4
	[Token(Token = "0x600214C")]
	[Address(RVA = "0x5B73E0", Offset = "0x5B59E0", VA = "0x1805B73E0")]
	public JackboxZombie()
	{
	}

	// Token: 0x04001192 RID: 4498
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001192")]
	public AudioSource audioSource;

	// Token: 0x04001193 RID: 4499
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001193")]
	public bool audioSourcePlaying;

	// Token: 0x04001194 RID: 4500
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4001194")]
	public float popCountDown;

	// Token: 0x04001195 RID: 4501
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001195")]
	protected float originalCountDown;
}
