using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A0 RID: 1696
[Token(Token = "0x20006A0")]
public class MinerZombie : Zombie
{
	// Token: 0x060020F3 RID: 8435 RVA: 0x000AE76C File Offset: 0x000AC96C
	[Token(Token = "0x60020F3")]
	[Address(RVA = "0x560930", Offset = "0x55EF30", VA = "0x180560930", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		AudioSource component = base.GetComponent<AudioSource>();
		this.audioSource = component;
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)12L);
		anim.Play("mine");
		if (this.AvaliableToPlay())
		{
			this.audioSource.Play();
			AudioSource audioSource = this.audioSource;
			this.audioSourcePlaying = true;
			float gameSoundVolume = GameAPP.config.gameSoundVolume;
			audioSource.volume = gameSoundVolume;
		}
		base.SetMaskLayer();
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x000AE7EC File Offset: 0x000AC9EC
	[Token(Token = "0x60020F4")]
	[Address(RVA = "0x55FFB0", Offset = "0x55E5B0", VA = "0x18055FFB0")]
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
				goto IL_005E;
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
		IL_005E:
		throw new NullReferenceException();
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x000AE870 File Offset: 0x000ACA70
	[Token(Token = "0x60020F5")]
	[Address(RVA = "0x560910", Offset = "0x55EF10", VA = "0x180560910", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000AE88C File Offset: 0x000ACA8C
	[Token(Token = "0x60020F6")]
	[Address(RVA = "0x5608F0", Offset = "0x55EEF0", VA = "0x1805608F0", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		base.SetCold(time, coldLevel, freeze);
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000AE8A4 File Offset: 0x000ACAA4
	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x560B30", Offset = "0x55F130", VA = "0x180560B30", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.MinerUpdate();
		AudioSource audioSource = this.audioSource;
		float gameSoundVolume = GameAPP.config.gameSoundVolume;
		audioSource.volume = gameSoundVolume;
		if (this.audioSourcePlaying)
		{
			this.audioSource.Pause();
			this.audioSourcePlaying = false;
		}
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x000AE8F8 File Offset: 0x000ACAF8
	[Token(Token = "0x60020F8")]
	[Address(RVA = "0x5602C0", Offset = "0x55E8C0", VA = "0x1805602C0")]
	private void MinerUpdate()
	{
		if (Lawnf.EveBalaced())
		{
		}
		Transform axis = this.axis;
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num = 0;
		GameObject gameObject = theUniqueItems[num];
		int num2 = 0;
		if (gameObject == num2)
		{
			Animator anim = this.anim;
			this.theStatus = (ZombieStatus)((ulong)13L);
			anim.SetTrigger("surprise");
			this.audioSource.Pause();
			this.audioSourcePlaying = false;
		}
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000AE9D4 File Offset: 0x000ACBD4
	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x560550", Offset = "0x55EB50", VA = "0x180560550")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int theZombieRow;
		for (;;)
		{
			int num = 0;
			bool flag;
			if (!flag)
			{
				return;
			}
			theZombieRow = this.theZombieRow;
			if (theZombieRow > 922)
			{
				break;
			}
			if (num != 911)
			{
				while (num != 922)
				{
				}
			}
			bool flag2;
			if (flag2)
			{
				this.Surprised();
			}
			ulong num2;
			if (num2 == (ulong)0L)
			{
				goto Block_5;
			}
		}
		if (theZombieRow == 925 || theZombieRow == 935 || theZombieRow == 1099)
		{
			this.Surprised();
		}
		return;
		Block_5:
		throw new NullReferenceException();
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000AEA4C File Offset: 0x000ACC4C
	[Token(Token = "0x60020FA")]
	[Address(RVA = "0x560A90", Offset = "0x55F090", VA = "0x180560A90")]
	private void Surprised()
	{
		List<GameObject> theUniqueItems = this.theUniqueItems;
		this.theStatus = (ZombieStatus)((ulong)13L);
		int num = 0;
		int num2 = 0;
		theUniqueItems[num2] = num;
		this.anim.SetTrigger("surprise");
		this.audioSource.Pause();
		this.audioSourcePlaying = false;
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x000AEAA0 File Offset: 0x000ACCA0
	[Token(Token = "0x60020FB")]
	[Address(RVA = "0x560210", Offset = "0x55E810", VA = "0x180560210", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x000AEAE0 File Offset: 0x000ACCE0
	[Token(Token = "0x60020FC")]
	[Address(RVA = "0x5602B0", Offset = "0x55E8B0", VA = "0x1805602B0")]
	private void ChangeStatus()
	{
		this.theStatus = (ZombieStatus)((ulong)0L);
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x000AEAF8 File Offset: 0x000ACCF8
	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x560760", Offset = "0x55ED60", VA = "0x180560760")]
	public void Rise()
	{
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)13L);
		anim.SetTrigger("rise");
		GameAPP.PlaySound(94, 0.5f, 1f);
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num = 0;
		int num2 = 0;
		theUniqueItems[num2] = num;
		Transform axis = this.axis;
		this.theUniqueItemType = (Zombie.UniqueItemType)((ulong)0L);
		Transform transform = base.transform;
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x000AEB68 File Offset: 0x000ACD68
	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x560C40", Offset = "0x55F240", VA = "0x180560C40")]
	public MinerZombie()
	{
	}

	// Token: 0x040010EC RID: 4332
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010EC")]
	public AudioSource audioSource;

	// Token: 0x040010ED RID: 4333
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010ED")]
	public bool audioSourcePlaying;
}
