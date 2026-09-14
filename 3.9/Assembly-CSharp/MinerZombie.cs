using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D7 RID: 1751
[Token(Token = "0x20006D7")]
public class MinerZombie : Zombie
{
	// Token: 0x0600220A RID: 8714 RVA: 0x000B3408 File Offset: 0x000B1608
	[Token(Token = "0x600220A")]
	[Address(RVA = "0x5C36B0", Offset = "0x5C1CB0", VA = "0x1805C36B0", Slot = "16")]
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

	// Token: 0x0600220B RID: 8715 RVA: 0x000B3488 File Offset: 0x000B1688
	[Token(Token = "0x600220B")]
	[Address(RVA = "0x5C2D30", Offset = "0x5C1330", VA = "0x1805C2D30")]
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

	// Token: 0x0600220C RID: 8716 RVA: 0x000B350C File Offset: 0x000B170C
	[Token(Token = "0x600220C")]
	[Address(RVA = "0x5C3690", Offset = "0x5C1C90", VA = "0x1805C3690", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x000B3528 File Offset: 0x000B1728
	[Token(Token = "0x600220D")]
	[Address(RVA = "0x5C3670", Offset = "0x5C1C70", VA = "0x1805C3670", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		base.SetCold(time, coldLevel, freeze);
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000B3540 File Offset: 0x000B1740
	[Token(Token = "0x600220E")]
	[Address(RVA = "0x5C38B0", Offset = "0x5C1EB0", VA = "0x1805C38B0", Slot = "17")]
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

	// Token: 0x0600220F RID: 8719 RVA: 0x000B3594 File Offset: 0x000B1794
	[Token(Token = "0x600220F")]
	[Address(RVA = "0x5C3040", Offset = "0x5C1640", VA = "0x1805C3040")]
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

	// Token: 0x06002210 RID: 8720 RVA: 0x000B3670 File Offset: 0x000B1870
	[Token(Token = "0x6002210")]
	[Address(RVA = "0x5C32D0", Offset = "0x5C18D0", VA = "0x1805C32D0")]
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

	// Token: 0x06002211 RID: 8721 RVA: 0x000B36E8 File Offset: 0x000B18E8
	[Token(Token = "0x6002211")]
	[Address(RVA = "0x5C3810", Offset = "0x5C1E10", VA = "0x1805C3810")]
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

	// Token: 0x06002212 RID: 8722 RVA: 0x000B373C File Offset: 0x000B193C
	[Token(Token = "0x6002212")]
	[Address(RVA = "0x5C2F90", Offset = "0x5C1590", VA = "0x1805C2F90", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x000B377C File Offset: 0x000B197C
	[Token(Token = "0x6002213")]
	[Address(RVA = "0x5C3030", Offset = "0x5C1630", VA = "0x1805C3030")]
	private void ChangeStatus()
	{
		this.theStatus = (ZombieStatus)((ulong)0L);
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x000B3794 File Offset: 0x000B1994
	[Token(Token = "0x6002214")]
	[Address(RVA = "0x5C34E0", Offset = "0x5C1AE0", VA = "0x1805C34E0")]
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

	// Token: 0x06002215 RID: 8725 RVA: 0x000B3804 File Offset: 0x000B1A04
	[Token(Token = "0x6002215")]
	[Address(RVA = "0x5C39C0", Offset = "0x5C1FC0", VA = "0x1805C39C0")]
	public MinerZombie()
	{
	}

	// Token: 0x040011B9 RID: 4537
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011B9")]
	public AudioSource audioSource;

	// Token: 0x040011BA RID: 4538
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011BA")]
	public bool audioSourcePlaying;
}
