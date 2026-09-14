using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DF RID: 1759
[Token(Token = "0x20006DF")]
public class SuperJackboxZombie : JackboxZombie
{
	// Token: 0x060022B9 RID: 8889 RVA: 0x000B6388 File Offset: 0x000B4588
	[Token(Token = "0x60022B9")]
	[Address(RVA = "0x578ED0", Offset = "0x5774D0", VA = "0x180578ED0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[64];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[65];
		component2.sprite = sprite2;
	}

	// Token: 0x060022BA RID: 8890 RVA: 0x000B6404 File Offset: 0x000B4604
	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x579060", Offset = "0x577660", VA = "0x180579060", Slot = "62")]
	protected override void FirstArmorFall()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				GameObject gameObject;
				ulong num2;
				gameObject.SetActive(num2 != 0UL);
				GameObject gameObject2;
				ParticleSystemRenderer component = gameObject2.GetComponent<ParticleSystemRenderer>();
				int theZombieRow = this.theZombieRow;
				string text2 = string.Format("zombie{0}", component);
				component.sortingLayerName = text2;
				GameObject gameObject3;
				ParticleSystemRenderer component2 = gameObject3.GetComponent<ParticleSystemRenderer>();
				int num3 = this.sortingGroup.sortingOrder + 1;
				component2.sortingOrder = num3;
				GameObject gameObject4;
				ParticleSystem.MainModule main = gameObject4.GetComponent<ParticleSystem>().main;
				List<Transform> plane = this.board.plane;
				int theZombieRow2 = this.theZombieRow;
				Transform transform = plane[theZombieRow2];
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x000B6520 File Offset: 0x000B4720
	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x578AA0", Offset = "0x5770A0", VA = "0x180578AA0", Slot = "75")]
	protected override void AnimExplode()
	{
		base.Explode();
		Animator anim = this.anim;
		int num = 0;
		anim.Play("walk", num);
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num2 = 0;
		global::UnityEngine.Object.Destroy(theUniqueItems[num2]);
		global::UnityEngine.Object.Destroy(this.theUniqueItems[1]);
		List<GameObject> theUniqueItems2 = this.theUniqueItems;
		int num3 = 0;
		int num4 = 0;
		theUniqueItems2[num4] = num3;
		List<GameObject> theUniqueItems3 = this.theUniqueItems;
		int num5 = 0;
		theUniqueItems3[1] = num5;
		AudioSource audioSource = this.audioSource;
		int num6 = 0;
		this.theUniqueItemType = (Zombie.UniqueItemType)num6;
		this.audioSourcePlaying = num6 != 0;
		audioSource.Pause();
		float theOriginSpeed = this.theOriginSpeed;
		this.theStatus = (ZombieStatus)num6;
		this.theOriginSpeed = theOriginSpeed;
		AdvantureMission.TryAddCount((AdvantureLevel)((uint)42));
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x000B65E4 File Offset: 0x000B47E4
	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x578C20", Offset = "0x577220", VA = "0x180578C20", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		float originalCountDown = this.originalCountDown;
		float num = global::UnityEngine.Random.Range((float)0, originalCountDown);
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num2 = 0;
		GameObject gameObject = theUniqueItems[num2];
		int num3 = 0;
		if (gameObject != num3 && reason == 0)
		{
			base.Explode();
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
			Transform axis2 = this.axis;
			CreateZombie instance2 = CreateZombie.Instance;
			int num4 = 0;
			Zombie zombie;
			if (zombie != num4)
			{
				Corner targetCorner = this.targetCorner;
				zombie.targetCorner = targetCorner;
				float num5 = global::UnityEngine.Random.Range(4.4f, 7.54f);
			}
		}
	}

	// Token: 0x060022BD RID: 8893 RVA: 0x000B6688 File Offset: 0x000B4888
	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x532C60", Offset = "0x531260", VA = "0x180532C60")]
	public SuperJackboxZombie()
	{
	}
}
