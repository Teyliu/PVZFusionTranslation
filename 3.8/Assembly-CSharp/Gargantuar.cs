using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200066C RID: 1644
[Token(Token = "0x200066C")]
public class Gargantuar : Zombie
{
	// Token: 0x06001F57 RID: 8023 RVA: 0x000A6CF0 File Offset: 0x000A4EF0
	[Token(Token = "0x6001F57")]
	[Address(RVA = "0x548D60", Offset = "0x547360", VA = "0x180548D60", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Plant", "TorchWood", "Zombie" });
		this._LayerMask = layerMask;
		throw new NullReferenceException();
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000A6D48 File Offset: 0x000A4F48
	[Token(Token = "0x6001F58")]
	[Address(RVA = "0x549D50", Offset = "0x548350", VA = "0x180549D50", Slot = "74")]
	protected virtual void SetWeapon()
	{
		int num = global::UnityEngine.Random.Range(0, 3);
		if (num == 0)
		{
			SpriteRenderer component = base.transform.GetChild(4).GetComponent<SpriteRenderer>();
			int num2 = 0;
			component.enabled = num2 != 0;
			Transform child = base.transform.GetChild(4);
			int num3 = 0;
			child.GetChild(num3).gameObject.SetActive(true);
			return;
		}
		while (num != 1)
		{
		}
		SpriteRenderer component2 = base.transform.GetChild(4).GetComponent<SpriteRenderer>();
		int num4 = 0;
		component2.enabled = num4 != 0;
		Transform child2 = base.transform.GetChild(4);
		throw new NullReferenceException();
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000A6DD8 File Offset: 0x000A4FD8
	[Token(Token = "0x6001F59")]
	[Address(RVA = "0x549ED0", Offset = "0x5484D0", VA = "0x180549ED0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.theStatus = (ZombieStatus)((ulong)15L);
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x000A6DF8 File Offset: 0x000A4FF8
	[Token(Token = "0x6001F5A")]
	[Address(RVA = "0x5496D0", Offset = "0x547CD0", VA = "0x1805496D0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.GargantuarAttackUpdate();
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x000A6E14 File Offset: 0x000A5014
	[Token(Token = "0x6001F5B")]
	[Address(RVA = "0x548E70", Offset = "0x547470", VA = "0x180548E70", Slot = "29")]
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
			SpriteRenderer component3 = base.transform.GetChild((int)num17).GetComponent<SpriteRenderer>();
			int num18 = 0;
			component3.enabled = num18 != 0;
			uint num19;
			Transform child3 = base.transform.GetChild((int)num19);
			int num20 = 0;
			ulong num21;
			child3.GetChild(num20).gameObject.SetActive(num21 != 0UL);
		}
		float num22 = num2 * 0.5f;
		Transform axis = this.axis;
		Board board = this.board;
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)0L);
		anim.SetTrigger("throw");
		Transform transform4 = base.transform;
		int num23 = 0;
		SpriteRenderer component4 = transform4.GetChild(num23).GetComponent<SpriteRenderer>();
		int num24 = 0;
		component4.enabled = num24 != 0;
		Transform transform5 = base.transform;
		int num25 = 0;
		Transform child4 = transform5.GetChild(num25);
		int num26 = 0;
		GameObject gameObject2 = child4.GetChild(num26).gameObject;
		int num27 = 0;
		gameObject2.SetActive(num27 != 0);
		Transform transform6 = base.transform;
		int num28 = 0;
		uint num29;
		ulong num30;
		transform6.GetChild(num28).GetChild((int)num29).gameObject.SetActive(num30 != 0UL);
		uint num31;
		SpriteRenderer component5 = base.transform.GetChild((int)num31).GetComponent<SpriteRenderer>();
		int num32 = 0;
		component5.enabled = num32 != 0;
		uint num33;
		Transform child5 = base.transform.GetChild((int)num33);
		int num34 = 0;
		ulong num35;
		child5.GetChild(num34).gameObject.SetActive(num35 != 0UL);
		uint num36;
		SpriteRenderer component6 = base.transform.GetChild((int)num36).GetComponent<SpriteRenderer>();
		int num37 = 0;
		component6.enabled = num37 != 0;
		uint num38;
		Transform child6 = base.transform.GetChild((int)num38);
		int num39 = 0;
		ulong num40;
		child6.GetChild(num39).gameObject.SetActive(num40 != 0UL);
		uint num41;
		SpriteRenderer component7 = base.transform.GetChild((int)num41).GetComponent<SpriteRenderer>();
		int num42 = 0;
		component7.enabled = num42 != 0;
		uint num43;
		Transform child7 = base.transform.GetChild((int)num43);
		int num44 = 0;
		ulong num45;
		child7.GetChild(num44).gameObject.SetActive(num45 != 0UL);
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000A70E8 File Offset: 0x000A52E8
	[Token(Token = "0x6001F5C")]
	[Address(RVA = "0x5496F0", Offset = "0x547CF0", VA = "0x1805496F0")]
	private void GargantuarAttackUpdate()
	{
		Animator anim = this.anim;
		int num = 0;
		int num2 = 0;
		anim.SetBool("isAttacking", num2 != 0);
		Transform axis = this.axis;
		Board board = this.board;
		if (this.GetCols() > 0)
		{
			Collider2D[] array = Gargantuar.sharedCols;
			Collider2D collider2D;
			if (collider2D.TryGetComponent<Plant>(num))
			{
				int theZombieRow = this.theZombieRow;
				bool flag;
				if (!flag)
				{
					Board board2 = this.board;
					BoxType boxType;
					if (boxType == BoxType.Dirt)
					{
						ulong num3;
						this.anim.SetBool("isAttacking", num3 != 0UL);
						return;
					}
					goto IL_00C7;
				}
			}
			bool flag2;
			if (!flag2)
			{
				Board board3 = this.board;
				bool flag3;
				if (flag3)
				{
					int i = this.theZombieRow;
					while (i <= 2)
					{
					}
					while (i <= 3)
					{
					}
				}
				bool flag4;
				if (!flag4)
				{
					goto IL_00C7;
				}
				int theZombieRow2 = this.theZombieRow;
				ulong num4;
				this.anim.SetBool("isAttacking", num4 != 0UL);
			}
			int theZombieRow3 = this.theZombieRow;
			bool isMindControlled = this.isMindControlled;
			bool flag5;
			if (flag5 == isMindControlled)
			{
			}
			IL_00C7:
			throw new NullReferenceException();
		}
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x000A71C4 File Offset: 0x000A53C4
	[Token(Token = "0x6001F5D")]
	[Address(RVA = "0x548970", Offset = "0x546F70", VA = "0x180548970", Slot = "75")]
	protected virtual Zombie AnimThrow()
	{
		Transform transform = base.transform.Find("Shoot");
		Vector3 vector;
		float z = vector.z;
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		int theZombieRow = this.theZombieRow;
		Zombie zombie = instance.SetZombie(theZombieRow, (ZombieType)((uint)37), 9.9f, num != 0);
		Board board = this.board;
		Transform transform2 = zombie.transform;
		Transform transform3 = zombie.transform;
		Transform transform4 = zombie.transform;
		Transform transform5 = zombie.transform;
		ImpZombie component = zombie.GetComponent<ImpZombie>();
		Transform transform6 = component.transform;
		int num2 = 0;
		int num3 = 0;
		transform6.Translate((float)num3, 1.5f, (float)num2);
		component.anim.Play("thrown");
		int theZombieRow2 = component.theZombieRow;
		int num4 = 0;
		component.fromRow = theZombieRow2;
		component.theStatus = (ZombieStatus)((ulong)16L);
		if (base.HasBuff((EffectType)num4))
		{
			int num5 = 0;
			int num6 = 0;
			component.SetCold(15f, num6, num5 != 0);
		}
		if (base.HasBuff((EffectType)((uint)4)))
		{
			component.SetPoison(10f);
		}
		if (base.HasBuff((EffectType)((uint)1)))
		{
			component.SetJalaed();
		}
		GameAPP.PlaySound(global::UnityEngine.Random.Range(110, 112), 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.transform.GetChild(6).gameObject);
		while (6UL <= (ulong)20L)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x000A7320 File Offset: 0x000A5520
	[Token(Token = "0x6001F5E")]
	[Address(RVA = "0x548120", Offset = "0x546720", VA = "0x180548120", Slot = "76")]
	protected virtual void AnimCrash()
	{
		ulong num11;
		do
		{
			int num = 0;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			ScreenShake.TriggerShake(0.05f);
			HashSet<int> hashSet = new HashSet();
			int cols = this.GetCols();
			int num3 = 0;
			if (cols > 0)
			{
				int num4 = 0;
				Collider2D[] array = Gargantuar.sharedCols;
				bool flag;
				if (flag)
				{
					int theZombieRow = this.theZombieRow;
					bool flag2;
					if (!flag2)
					{
						int num5 = 0;
						bool flag3;
						if (!flag3)
						{
							bool flag4 = hashSet.Add(num5);
						}
					}
				}
				bool flag5;
				if (flag5)
				{
					goto IL_00AC;
				}
				bool flag6;
				if (flag6)
				{
					int theZombieRow2 = this.theZombieRow;
					uint num6;
					uint num7;
					GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num6, (int)num7), 0.5f, 1f);
				}
				Board board = this.board;
				bool flag7;
				if (flag7)
				{
					int theZombieRow3 = this.theZombieRow;
					goto IL_00AC;
				}
				IL_00BC:
				num3++;
				num4++;
				uint num8;
				num8 += (uint)8;
				goto IL_00CF;
				IL_00AC:
				int theZombieRow4 = this.theZombieRow;
				bool isMindControlled = this.isMindControlled;
				goto IL_00BC;
			}
			IL_00CF:
			bool flag8;
			if (flag8)
			{
				int theZombieRow5 = this.theZombieRow;
				List<Plant> list = global::Lawnf.Get1x1Plants(num, theZombieRow5);
				Func<Plant, bool> func;
				if (Enumerable.FirstOrDefault<Plant>(list, func))
				{
					Predicate<Plant> predicate;
					if (Gargantuar.<>c.<>9__9_1 == 0)
					{
						Gargantuar.<>c.<>9__9_1 = predicate;
					}
					int num9 = list.RemoveAll(predicate);
				}
				bool flag9;
				if (flag9)
				{
					bool flag10 = this.Crashable(num);
					this.CrashPlant(num, flag10);
				}
				ulong num10;
				if (num10 != (ulong)0L)
				{
					goto IL_0149;
				}
			}
		}
		while (num11 != (ulong)0L);
		return;
		IL_0149:
		throw new NullReferenceException();
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x000A747C File Offset: 0x000A567C
	[Token(Token = "0x6001F5F")]
	[Address(RVA = "0x549640", Offset = "0x547C40", VA = "0x180549640")]
	private bool Crashable(Plant plant)
	{
		if (!TypeMgr.UncrashablePlant(plant) && plant.theLevel < 3)
		{
			PlantType thePlantType = plant.thePlantType;
			if (thePlantType != PlantType.ObsidianWallNut && thePlantType != PlantType.IFVStar && thePlantType != PlantType.PickaxeStar)
			{
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x000A74C8 File Offset: 0x000A56C8
	[Token(Token = "0x6001F60")]
	[Address(RVA = "0x549580", Offset = "0x547B80", VA = "0x180549580", Slot = "77")]
	protected virtual void CrashPlant(Plant plant, bool crash)
	{
		if (!crash)
		{
			plant.FlashOnce();
			return;
		}
		int num = 0;
		plant.Crashed(1, num, this);
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x000A74F4 File Offset: 0x000A56F4
	[Token(Token = "0x6001F61")]
	[Address(RVA = "0x549CC0", Offset = "0x5482C0", VA = "0x180549CC0", Slot = "44")]
	public override void PlayFallSound()
	{
		GameAPP.PlaySound(74, 0.5f, 1f);
		ScreenShake.TriggerShake(0.05f);
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x000A751C File Offset: 0x000A571C
	[Token(Token = "0x6001F62")]
	[Address(RVA = "0x549C60", Offset = "0x548260", VA = "0x180549C60")]
	private void PlayDieSound()
	{
		GameAPP.PlaySound(112, 0.5f, 1f);
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x000A753C File Offset: 0x000A573C
	[Token(Token = "0x6001F63")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "41")]
	protected override bool GetLadder(Plant plant)
	{
		return false;
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x000A754C File Offset: 0x000A574C
	[Token(Token = "0x6001F64")]
	[Address(RVA = "0x549AC0", Offset = "0x5480C0", VA = "0x180549AC0", Slot = "78")]
	protected virtual int GetCols()
	{
		Transform axis = this.axis;
		int num = this._LayerMask;
		Collider2D[] array = Gargantuar.sharedCols;
		return Gargantuar.sharedCols.Length;
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x000A758C File Offset: 0x000A578C
	[Token(Token = "0x6001F65")]
	[Address(RVA = "0x549FF0", Offset = "0x5485F0", VA = "0x180549FF0")]
	public Gargantuar()
	{
	}

	// Token: 0x04001083 RID: 4227
	[Token(Token = "0x4001083")]
	public static Collider2D[] sharedCols = new Collider2D[32];

	// Token: 0x04001084 RID: 4228
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001084")]
	protected LayerMask _LayerMask;
}
