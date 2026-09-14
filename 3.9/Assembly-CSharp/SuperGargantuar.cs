using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000715 RID: 1813
[Token(Token = "0x2000715")]
public class SuperGargantuar : Gargantuar
{
	// Token: 0x060023B5 RID: 9141 RVA: 0x000BA528 File Offset: 0x000B8728
	[Token(Token = "0x60023B5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected override void SetWeapon()
	{
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x000BA538 File Offset: 0x000B8738
	[Token(Token = "0x60023B6")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x000BA548 File Offset: 0x000B8748
	[Token(Token = "0x60023B7")]
	[Address(RVA = "0x5D9BE0", Offset = "0x5D81E0", VA = "0x1805D9BE0", Slot = "78")]
	protected override void AnimCrash()
	{
		base.AnimCrash();
		this.SetImps();
	}

	// Token: 0x060023B8 RID: 9144 RVA: 0x000BA564 File Offset: 0x000B8764
	[Token(Token = "0x60023B8")]
	[Address(RVA = "0x5DB240", Offset = "0x5D9840", VA = "0x1805DB240", Slot = "81")]
	protected virtual void SetImps()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		GameObject gameObject;
		if (gameObject > 0)
		{
			int theZombieRow = this.theZombieRow;
			CreateZombie instance = CreateZombie.Instance;
			float num2 = global::UnityEngine.Random.Range(-1f, 1f);
			Zombie zombie = instance.SetZombie(theZombieRow, (ZombieType)((uint)37), float.Epsilon, num != 0);
			num++;
		}
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x000BA5CC File Offset: 0x000B87CC
	[Token(Token = "0x60023B9")]
	[Address(RVA = "0x5DA9D0", Offset = "0x5D8FD0", VA = "0x1805DA9D0", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		bool flag;
		if (flag)
		{
			SpriteRenderer component = this.theFirstArmor.GetComponent<SpriteRenderer>();
			int num = 0;
			component.enabled = num != 0;
			Transform transform = this.theFirstArmor.transform;
			int num2 = 0;
			transform.GetChild(num2).gameObject.SetActive(true);
			GameObject gameObject = this.theFirstArmor.transform.GetChild(1).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
		}
		SpriteRenderer component2 = this.theFirstArmor.GetComponent<SpriteRenderer>();
		int num4 = 0;
		component2.enabled = num4 != 0;
		Transform transform2 = this.theFirstArmor.transform;
		int num5 = 0;
		GameObject gameObject2 = transform2.GetChild(num5).gameObject;
		int num6 = 0;
		gameObject2.SetActive(num6 != 0);
		this.theFirstArmor.transform.GetChild(1).gameObject.SetActive(true);
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x000BA6A0 File Offset: 0x000B88A0
	[Token(Token = "0x60023BA")]
	[Address(RVA = "0x5D9F30", Offset = "0x5D8530", VA = "0x1805D9F30", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		long num = this.theHealth;
		num -= (long)theDamage;
		this.theHealth = num;
		int num2 = 0;
		int num3 = 0;
		float num4 = (float)(num2 * (int)0.6666667f);
		int num5 = 0;
		if (global::Core.Lawnf.ValueBetween((float)(num3 * (int)0.33333334f), (float)num5, num4))
		{
			Transform transform = base.transform;
			int num6 = 0;
			SpriteRenderer component = transform.GetChild(num6).GetComponent<SpriteRenderer>();
			int num7 = 0;
			component.enabled = num7 != 0;
			Transform transform2 = base.transform;
			int num8 = 0;
			Transform child = transform2.GetChild(num8);
			int num9 = 0;
			ulong num10;
			child.GetChild(num9).gameObject.SetActive(num10 != 0UL);
			Transform transform3 = base.transform;
			int num11 = 0;
			uint num12;
			GameObject gameObject = transform3.GetChild(num11).GetChild((int)num12).gameObject;
			int num13 = 0;
			gameObject.SetActive(num13 != 0);
			uint num14;
			SpriteRenderer component2 = base.transform.GetChild((int)num14).GetComponent<SpriteRenderer>();
			int num15 = 0;
			component2.enabled = num15 != 0;
			uint num16;
			Transform child2 = base.transform.GetChild((int)num16);
			int num17 = 0;
			ulong num18;
			child2.GetChild(num17).gameObject.SetActive(num18 != 0UL);
			uint num19;
			uint num20;
			GameObject gameObject2 = base.transform.GetChild((int)num19).GetChild((int)num20).gameObject;
			int num21 = 0;
			gameObject2.SetActive(num21 != 0);
			uint num22;
			SpriteRenderer component3 = base.transform.GetChild((int)num22).GetComponent<SpriteRenderer>();
			int num23 = 0;
			component3.enabled = num23 != 0;
			uint num24;
			Transform child3 = base.transform.GetChild((int)num24);
			int num25 = 0;
			ulong num26;
			child3.GetChild(num25).gameObject.SetActive(num26 != 0UL);
			uint num27;
			Transform child4 = base.transform.GetChild((int)num27);
			int num28 = 0;
			GameObject gameObject3 = child4.GetChild(num28).gameObject;
			int num29 = 0;
			gameObject3.SetActive(num29 != 0);
			uint num30;
			uint num31;
			ulong num32;
			base.transform.GetChild((int)num30).GetChild((int)num31).gameObject.SetActive(num32 != 0UL);
			uint num33;
			uint num34;
			GameObject gameObject4 = base.transform.GetChild((int)num33).GetChild((int)num34).gameObject;
			int num35 = 0;
			gameObject4.SetActive(num35 != 0);
		}
		int num36 = 0;
		int num37 = 0;
		if (num36 * (int)0.5f > num37)
		{
			Transform axis = this.axis;
			Animator anim = this.anim;
			this.theStatus = (ZombieStatus)((ulong)0L);
			anim.SetTrigger("throw");
		}
		int num38 = 0;
		float num39;
		if (num39 > (float)num38)
		{
			Transform transform4 = base.transform;
			int num40 = 0;
			SpriteRenderer component4 = transform4.GetChild(num40).GetComponent<SpriteRenderer>();
			int num41 = 0;
			component4.enabled = num41 != 0;
			Transform transform5 = base.transform;
			int num42 = 0;
			Transform child5 = transform5.GetChild(num42);
			int num43 = 0;
			GameObject gameObject5 = child5.GetChild(num43).gameObject;
			int num44 = 0;
			gameObject5.SetActive(num44 != 0);
			Transform transform6 = base.transform;
			int num45 = 0;
			uint num46;
			ulong num47;
			transform6.GetChild(num45).GetChild((int)num46).gameObject.SetActive(num47 != 0UL);
			uint num48;
			SpriteRenderer component5 = base.transform.GetChild((int)num48).GetComponent<SpriteRenderer>();
			int num49 = 0;
			component5.enabled = num49 != 0;
			uint num50;
			Transform child6 = base.transform.GetChild((int)num50);
			int num51 = 0;
			ulong num52;
			child6.GetChild(num51).gameObject.SetActive(num52 != 0UL);
			uint num53;
			SpriteRenderer component6 = base.transform.GetChild((int)num53).GetComponent<SpriteRenderer>();
			int num54 = 0;
			component6.enabled = num54 != 0;
			uint num55;
			Transform child7 = base.transform.GetChild((int)num55);
			int num56 = 0;
			GameObject gameObject6 = child7.GetChild(num56).gameObject;
			int num57 = 0;
			gameObject6.SetActive(num57 != 0);
			uint num58;
			uint num59;
			ulong num60;
			base.transform.GetChild((int)num58).GetChild((int)num59).gameObject.SetActive(num60 != 0UL);
			uint num61;
			SpriteRenderer component7 = base.transform.GetChild((int)num61).GetComponent<SpriteRenderer>();
			int num62 = 0;
			component7.enabled = num62 != 0;
			uint num63;
			Transform child8 = base.transform.GetChild((int)num63);
			int num64 = 0;
			ulong num65;
			child8.GetChild(num64).gameObject.SetActive(num65 != 0UL);
			uint num66;
			Transform child9 = base.transform.GetChild((int)num66);
			int num67 = 0;
			GameObject gameObject7 = child9.GetChild(num67).gameObject;
			int num68 = 0;
			gameObject7.SetActive(num68 != 0);
			uint num69;
			uint num70;
			GameObject gameObject8 = base.transform.GetChild((int)num69).GetChild((int)num70).gameObject;
			int num71 = 0;
			gameObject8.SetActive(num71 != 0);
			uint num72;
			uint num73;
			ulong num74;
			base.transform.GetChild((int)num72).GetChild((int)num73).gameObject.SetActive(num74 != 0UL);
		}
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x000BAAD0 File Offset: 0x000B8CD0
	[Token(Token = "0x60023BB")]
	[Address(RVA = "0x5D9C30", Offset = "0x5D8230", VA = "0x1805D9C30", Slot = "77")]
	protected override Zombie AnimThrow()
	{
		Transform transform = base.transform.Find("Shoot");
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Zombies/Gargantuar/SuperGargantuar/SuperBall");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		SpriteRenderer component = gameObject2.GetComponent<SpriteRenderer>();
		int sortingLayerID = this.sortingGroup.sortingLayerID;
		component.sortingLayerID = sortingLayerID;
		SpriteRenderer component2 = gameObject2.GetComponent<SpriteRenderer>();
		int num = this.sortingGroup.sortingOrder + 1;
		component2.sortingOrder = num;
		SuperBall component3 = gameObject2.GetComponent<SuperBall>();
		int theZombieRow = this.theZombieRow;
		component3.theRow = theZombieRow;
		Transform transform3 = base.transform;
		int num2 = 0;
		global::UnityEngine.Object.Destroy(transform3.GetChild(num2).GetChild(2).gameObject);
		throw new NullReferenceException();
	}

	// Token: 0x060023BC RID: 9148 RVA: 0x000BABA4 File Offset: 0x000B8DA4
	[Token(Token = "0x60023BC")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x060023BD RID: 9149 RVA: 0x000BABB8 File Offset: 0x000B8DB8
	[Token(Token = "0x60023BD")]
	[Address(RVA = "0x5DA980", Offset = "0x5D8F80", VA = "0x1805DA980", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060023BE RID: 9150 RVA: 0x000BABC8 File Offset: 0x000B8DC8
	[Token(Token = "0x60023BE")]
	[Address(RVA = "0x5DAC40", Offset = "0x5D9240", VA = "0x1805DAC40", Slot = "64")]
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

	// Token: 0x060023BF RID: 9151 RVA: 0x000BACE4 File Offset: 0x000B8EE4
	[Token(Token = "0x60023BF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x000BACF4 File Offset: 0x000B8EF4
	[Token(Token = "0x60023C0")]
	[Address(RVA = "0x5DA960", Offset = "0x5D8F60", VA = "0x1805DA960", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		int num = 0;
		if (time > (float)num)
		{
		}
		base.Buttered(time, sprite);
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x000BAD10 File Offset: 0x000B8F10
	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x5DB220", Offset = "0x5D9820", VA = "0x1805DB220", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		if (time > (float)num)
		{
		}
		int num2 = 0;
		base.SetFreeze(time, num2);
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x000BAD30 File Offset: 0x000B8F30
	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x5DB200", Offset = "0x5D9800", VA = "0x1805DB200", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		int num = 0;
		if (time > (float)num)
		{
		}
		base.SetCold(time, coldLevel, freeze);
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x000BAD50 File Offset: 0x000B8F50
	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x5DB060", Offset = "0x5D9660", VA = "0x1805DB060", Slot = "80")]
	protected override int GetCols()
	{
		Transform axis = this.axis;
		int num = this._LayerMask;
		Collider2D[] sharedCols = Gargantuar.sharedCols;
		return Gargantuar.sharedCols.Length;
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x000BAD90 File Offset: 0x000B8F90
	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x5DB3F0", Offset = "0x5D99F0", VA = "0x1805DB3F0")]
	public SuperGargantuar()
	{
	}
}
