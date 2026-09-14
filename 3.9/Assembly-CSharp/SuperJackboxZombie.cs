using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000717 RID: 1815
[Token(Token = "0x2000717")]
public class SuperJackboxZombie : JackboxZombie
{
	// Token: 0x060023D5 RID: 9173 RVA: 0x000BB164 File Offset: 0x000B9364
	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x5F34B0", Offset = "0x5F1AB0", VA = "0x1805F34B0", Slot = "63")]
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

	// Token: 0x060023D6 RID: 9174 RVA: 0x000BB1E0 File Offset: 0x000B93E0
	[Token(Token = "0x60023D6")]
	[Address(RVA = "0x5F3640", Offset = "0x5F1C40", VA = "0x1805F3640", Slot = "64")]
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

	// Token: 0x060023D7 RID: 9175 RVA: 0x000BB2FC File Offset: 0x000B94FC
	[Token(Token = "0x60023D7")]
	[Address(RVA = "0x5F3080", Offset = "0x5F1680", VA = "0x1805F3080", Slot = "77")]
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

	// Token: 0x060023D8 RID: 9176 RVA: 0x000BB3C0 File Offset: 0x000B95C0
	[Token(Token = "0x60023D8")]
	[Address(RVA = "0x5F3200", Offset = "0x5F1800", VA = "0x1805F3200", Slot = "29")]
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

	// Token: 0x060023D9 RID: 9177 RVA: 0x000BB464 File Offset: 0x000B9664
	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x589930", Offset = "0x587F30", VA = "0x180589930")]
	public SuperJackboxZombie()
	{
	}
}
