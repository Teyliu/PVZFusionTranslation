using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DD RID: 1757
[Token(Token = "0x20006DD")]
public class SuperGargantuar : Gargantuar
{
	// Token: 0x0600229B RID: 8859 RVA: 0x000B57BC File Offset: 0x000B39BC
	[Token(Token = "0x600229B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected override void SetWeapon()
	{
	}

	// Token: 0x0600229C RID: 8860 RVA: 0x000B57CC File Offset: 0x000B39CC
	[Token(Token = "0x600229C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600229D RID: 8861 RVA: 0x000B57DC File Offset: 0x000B39DC
	[Token(Token = "0x600229D")]
	[Address(RVA = "0x576660", Offset = "0x574C60", VA = "0x180576660", Slot = "76")]
	protected override void AnimCrash()
	{
		base.AnimCrash();
		this.SetImps();
	}

	// Token: 0x0600229E RID: 8862 RVA: 0x000B57F8 File Offset: 0x000B39F8
	[Token(Token = "0x600229E")]
	[Address(RVA = "0x577CB0", Offset = "0x5762B0", VA = "0x180577CB0", Slot = "79")]
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

	// Token: 0x0600229F RID: 8863 RVA: 0x000B5860 File Offset: 0x000B3A60
	[Token(Token = "0x600229F")]
	[Address(RVA = "0x577440", Offset = "0x575A40", VA = "0x180577440", Slot = "61")]
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

	// Token: 0x060022A0 RID: 8864 RVA: 0x000B5934 File Offset: 0x000B3B34
	[Token(Token = "0x60022A0")]
	[Address(RVA = "0x5769B0", Offset = "0x574FB0", VA = "0x1805769B0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num = this.theHealth;
		num -= theDamage;
		this.theHealth = num;
		float num2;
		float num3;
		if (global::Core.Lawnf.ValueBetween(num2, (float)theDamage, num3))
		{
			Transform transform = base.transform;
			int num4 = 0;
			SpriteRenderer component = transform.GetChild(num4).GetComponent<SpriteRenderer>();
			int num5 = 0;
			component.enabled = num5 != 0;
			Transform transform2 = base.transform;
			int num6 = 0;
			Transform child = transform2.GetChild(num6);
			int num7 = 0;
			ulong num8;
			child.GetChild(num7).gameObject.SetActive(num8 != 0UL);
			Transform transform3 = base.transform;
			int num9 = 0;
			uint num10;
			GameObject gameObject = transform3.GetChild(num9).GetChild((int)num10).gameObject;
			int num11 = 0;
			gameObject.SetActive(num11 != 0);
			uint num12;
			SpriteRenderer component2 = base.transform.GetChild((int)num12).GetComponent<SpriteRenderer>();
			int num13 = 0;
			component2.enabled = num13 != 0;
			uint num14;
			Transform child2 = base.transform.GetChild((int)num14);
			int num15 = 0;
			ulong num16;
			child2.GetChild(num15).gameObject.SetActive(num16 != 0UL);
			uint num17;
			uint num18;
			GameObject gameObject2 = base.transform.GetChild((int)num17).GetChild((int)num18).gameObject;
			int num19 = 0;
			gameObject2.SetActive(num19 != 0);
			uint num20;
			SpriteRenderer component3 = base.transform.GetChild((int)num20).GetComponent<SpriteRenderer>();
			int num21 = 0;
			component3.enabled = num21 != 0;
			uint num22;
			Transform child3 = base.transform.GetChild((int)num22);
			int num23 = 0;
			ulong num24;
			child3.GetChild(num23).gameObject.SetActive(num24 != 0UL);
			uint num25;
			Transform child4 = base.transform.GetChild((int)num25);
			int num26 = 0;
			GameObject gameObject3 = child4.GetChild(num26).gameObject;
			int num27 = 0;
			gameObject3.SetActive(num27 != 0);
			uint num28;
			uint num29;
			ulong num30;
			base.transform.GetChild((int)num28).GetChild((int)num29).gameObject.SetActive(num30 != 0UL);
			uint num31;
			uint num32;
			GameObject gameObject4 = base.transform.GetChild((int)num31).GetChild((int)num32).gameObject;
			int num33 = 0;
			gameObject4.SetActive(num33 != 0);
		}
		float num34 = num2 * 0.5f;
		Transform axis = this.axis;
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)0L);
		anim.SetTrigger("throw");
		Transform transform4 = base.transform;
		int num35 = 0;
		SpriteRenderer component4 = transform4.GetChild(num35).GetComponent<SpriteRenderer>();
		int num36 = 0;
		component4.enabled = num36 != 0;
		Transform transform5 = base.transform;
		int num37 = 0;
		Transform child5 = transform5.GetChild(num37);
		int num38 = 0;
		GameObject gameObject5 = child5.GetChild(num38).gameObject;
		int num39 = 0;
		gameObject5.SetActive(num39 != 0);
		Transform transform6 = base.transform;
		int num40 = 0;
		uint num41;
		ulong num42;
		transform6.GetChild(num40).GetChild((int)num41).gameObject.SetActive(num42 != 0UL);
		uint num43;
		SpriteRenderer component5 = base.transform.GetChild((int)num43).GetComponent<SpriteRenderer>();
		int num44 = 0;
		component5.enabled = num44 != 0;
		uint num45;
		Transform child6 = base.transform.GetChild((int)num45);
		int num46 = 0;
		ulong num47;
		child6.GetChild(num46).gameObject.SetActive(num47 != 0UL);
		uint num48;
		SpriteRenderer component6 = base.transform.GetChild((int)num48).GetComponent<SpriteRenderer>();
		int num49 = 0;
		component6.enabled = num49 != 0;
		uint num50;
		Transform child7 = base.transform.GetChild((int)num50);
		int num51 = 0;
		GameObject gameObject6 = child7.GetChild(num51).gameObject;
		int num52 = 0;
		gameObject6.SetActive(num52 != 0);
		uint num53;
		uint num54;
		ulong num55;
		base.transform.GetChild((int)num53).GetChild((int)num54).gameObject.SetActive(num55 != 0UL);
		uint num56;
		SpriteRenderer component7 = base.transform.GetChild((int)num56).GetComponent<SpriteRenderer>();
		int num57 = 0;
		component7.enabled = num57 != 0;
		uint num58;
		Transform child8 = base.transform.GetChild((int)num58);
		int num59 = 0;
		ulong num60;
		child8.GetChild(num59).gameObject.SetActive(num60 != 0UL);
		uint num61;
		Transform child9 = base.transform.GetChild((int)num61);
		int num62 = 0;
		GameObject gameObject7 = child9.GetChild(num62).gameObject;
		int num63 = 0;
		gameObject7.SetActive(num63 != 0);
		uint num64;
		uint num65;
		GameObject gameObject8 = base.transform.GetChild((int)num64).GetChild((int)num65).gameObject;
		int num66 = 0;
		gameObject8.SetActive(num66 != 0);
		uint num67;
		uint num68;
		ulong num69;
		base.transform.GetChild((int)num67).GetChild((int)num68).gameObject.SetActive(num69 != 0UL);
	}

	// Token: 0x060022A1 RID: 8865 RVA: 0x000B5D38 File Offset: 0x000B3F38
	[Token(Token = "0x60022A1")]
	[Address(RVA = "0x5766B0", Offset = "0x574CB0", VA = "0x1805766B0", Slot = "75")]
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

	// Token: 0x060022A2 RID: 8866 RVA: 0x000B5E0C File Offset: 0x000B400C
	[Token(Token = "0x60022A2")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x000B5E28 File Offset: 0x000B4028
	[Token(Token = "0x60022A3")]
	[Address(RVA = "0x5773F0", Offset = "0x5759F0", VA = "0x1805773F0", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060022A4 RID: 8868 RVA: 0x000B5E38 File Offset: 0x000B4038
	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x5776B0", Offset = "0x575CB0", VA = "0x1805776B0", Slot = "62")]
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

	// Token: 0x060022A5 RID: 8869 RVA: 0x000B5F54 File Offset: 0x000B4154
	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x000B5F64 File Offset: 0x000B4164
	[Token(Token = "0x60022A6")]
	[Address(RVA = "0x5773D0", Offset = "0x5759D0", VA = "0x1805773D0", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		int num = 0;
		if (time > (float)num)
		{
		}
		base.Buttered(time, sprite);
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x000B5F80 File Offset: 0x000B4180
	[Token(Token = "0x60022A7")]
	[Address(RVA = "0x577C90", Offset = "0x576290", VA = "0x180577C90", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		if (time > (float)num)
		{
		}
		int num2 = 0;
		base.SetFreeze(time, num2);
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x000B5FA0 File Offset: 0x000B41A0
	[Token(Token = "0x60022A8")]
	[Address(RVA = "0x577C70", Offset = "0x576270", VA = "0x180577C70", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		int num = 0;
		if (time > (float)num)
		{
		}
		base.SetCold(time, coldLevel, freeze);
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x000B5FC0 File Offset: 0x000B41C0
	[Token(Token = "0x60022A9")]
	[Address(RVA = "0x577AD0", Offset = "0x5760D0", VA = "0x180577AD0", Slot = "78")]
	protected override int GetCols()
	{
		Transform axis = this.axis;
		int num = this._LayerMask;
		Collider2D[] sharedCols = Gargantuar.sharedCols;
		return Gargantuar.sharedCols.Length;
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x000B6000 File Offset: 0x000B4200
	[Token(Token = "0x60022AA")]
	[Address(RVA = "0x577E60", Offset = "0x576460", VA = "0x180577E60")]
	public SuperGargantuar()
	{
	}
}
