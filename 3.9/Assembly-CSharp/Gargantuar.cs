using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A2 RID: 1698
[Token(Token = "0x20006A2")]
public class Gargantuar : Zombie
{
	// Token: 0x06002058 RID: 8280 RVA: 0x000AB5A0 File Offset: 0x000A97A0
	[Token(Token = "0x6002058")]
	[Address(RVA = "0x5AB360", Offset = "0x5A9960", VA = "0x1805AB360", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Plant", "TorchWood", "Zombie" });
		this._LayerMask = layerMask;
		throw new NullReferenceException();
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x000AB5F8 File Offset: 0x000A97F8
	[Token(Token = "0x6002059")]
	[Address(RVA = "0x5AC360", Offset = "0x5AA960", VA = "0x1805AC360", Slot = "76")]
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

	// Token: 0x0600205A RID: 8282 RVA: 0x000AB688 File Offset: 0x000A9888
	[Token(Token = "0x600205A")]
	[Address(RVA = "0x5AC4E0", Offset = "0x5AAAE0", VA = "0x1805AC4E0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.theStatus = (ZombieStatus)((ulong)15L);
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x000AB6A8 File Offset: 0x000A98A8
	[Token(Token = "0x600205B")]
	[Address(RVA = "0x5ABCE0", Offset = "0x5AA2E0", VA = "0x1805ABCE0", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.GargantuarAttackUpdate();
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x000AB6C4 File Offset: 0x000A98C4
	[Token(Token = "0x600205C")]
	[Address(RVA = "0x5AB470", Offset = "0x5A9A70", VA = "0x1805AB470", Slot = "30")]
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
			SpriteRenderer component3 = base.transform.GetChild((int)num19).GetComponent<SpriteRenderer>();
			int num20 = 0;
			component3.enabled = num20 != 0;
			uint num21;
			Transform child3 = base.transform.GetChild((int)num21);
			int num22 = 0;
			ulong num23;
			child3.GetChild(num22).gameObject.SetActive(num23 != 0UL);
		}
		int num24 = 0;
		int num25 = 0;
		if (num24 * (int)0.5f > num25)
		{
			Transform axis = this.axis;
			Board board = this.board;
			Animator anim = this.anim;
			this.theStatus = (ZombieStatus)((ulong)0L);
			anim.SetTrigger("throw");
		}
		int num26 = 0;
		float num27;
		if (num27 > (float)num26)
		{
			Transform transform4 = base.transform;
			int num28 = 0;
			SpriteRenderer component4 = transform4.GetChild(num28).GetComponent<SpriteRenderer>();
			int num29 = 0;
			component4.enabled = num29 != 0;
			Transform transform5 = base.transform;
			int num30 = 0;
			Transform child4 = transform5.GetChild(num30);
			int num31 = 0;
			GameObject gameObject2 = child4.GetChild(num31).gameObject;
			int num32 = 0;
			gameObject2.SetActive(num32 != 0);
			Transform transform6 = base.transform;
			int num33 = 0;
			uint num34;
			ulong num35;
			transform6.GetChild(num33).GetChild((int)num34).gameObject.SetActive(num35 != 0UL);
			uint num36;
			SpriteRenderer component5 = base.transform.GetChild((int)num36).GetComponent<SpriteRenderer>();
			int num37 = 0;
			component5.enabled = num37 != 0;
			uint num38;
			Transform child5 = base.transform.GetChild((int)num38);
			int num39 = 0;
			ulong num40;
			child5.GetChild(num39).gameObject.SetActive(num40 != 0UL);
			uint num41;
			SpriteRenderer component6 = base.transform.GetChild((int)num41).GetComponent<SpriteRenderer>();
			int num42 = 0;
			component6.enabled = num42 != 0;
			uint num43;
			Transform child6 = base.transform.GetChild((int)num43);
			int num44 = 0;
			ulong num45;
			child6.GetChild(num44).gameObject.SetActive(num45 != 0UL);
			uint num46;
			SpriteRenderer component7 = base.transform.GetChild((int)num46).GetComponent<SpriteRenderer>();
			int num47 = 0;
			component7.enabled = num47 != 0;
			uint num48;
			Transform child7 = base.transform.GetChild((int)num48);
			int num49 = 0;
			ulong num50;
			child7.GetChild(num49).gameObject.SetActive(num50 != 0UL);
		}
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x000AB9C4 File Offset: 0x000A9BC4
	[Token(Token = "0x600205D")]
	[Address(RVA = "0x5ABD00", Offset = "0x5AA300", VA = "0x1805ABD00")]
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

	// Token: 0x0600205E RID: 8286 RVA: 0x000ABAA0 File Offset: 0x000A9CA0
	[Token(Token = "0x600205E")]
	[Address(RVA = "0x5AAFF0", Offset = "0x5A95F0", VA = "0x1805AAFF0", Slot = "77")]
	protected virtual Zombie AnimThrow()
	{
		Transform transform = base.transform.Find("Shoot");
		Vector3 vector;
		float z = vector.z;
		CreateZombie instance = CreateZombie.Instance;
		int theZombieRow = this.theZombieRow;
		ulong num;
		Zombie zombie = instance.SetZombie(theZombieRow, (ZombieType)((uint)37), 9.9f, num != 0UL);
		Board board = this.board;
		Transform transform2 = zombie.transform;
		Transform transform3 = zombie.transform;
		Transform transform4 = zombie.transform;
		Transform transform5 = zombie.transform;
		ImpZombie component = zombie.GetComponent<ImpZombie>();
		component.Thrown();
		int num2 = 0;
		if (base.HasBuff((EffectType)num2))
		{
			int num3 = 0;
			int num4 = 0;
			component.SetCold(15f, num4, num3 != 0);
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

	// Token: 0x0600205F RID: 8287 RVA: 0x000ABBB8 File Offset: 0x000A9DB8
	[Token(Token = "0x600205F")]
	[Address(RVA = "0x5AA7A0", Offset = "0x5A8DA0", VA = "0x1805AA7A0", Slot = "78")]
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
				Func<Plant, bool> func = delegate(Plant p)
				{
					if (!TypeMgr.UncrashablePlant(p) && p.theLevel < 3)
					{
						PlantType thePlantType = p.thePlantType;
						if (thePlantType == PlantType.ObsidianWallNut || thePlantType == PlantType.IFVStar || thePlantType != PlantType.PickaxeStar)
						{
						}
					}
					return true;
				};
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
					goto IL_0157;
				}
			}
		}
		while (num11 != (ulong)0L);
		return;
		IL_0157:
		throw new NullReferenceException();
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x000ABD24 File Offset: 0x000A9F24
	[Token(Token = "0x6002060")]
	[Address(RVA = "0x5ABC50", Offset = "0x5AA250", VA = "0x1805ABC50")]
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

	// Token: 0x06002061 RID: 8289 RVA: 0x000ABD70 File Offset: 0x000A9F70
	[Token(Token = "0x6002061")]
	[Address(RVA = "0x5ABB90", Offset = "0x5AA190", VA = "0x1805ABB90", Slot = "79")]
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

	// Token: 0x06002062 RID: 8290 RVA: 0x000ABD9C File Offset: 0x000A9F9C
	[Token(Token = "0x6002062")]
	[Address(RVA = "0x5AC2D0", Offset = "0x5AA8D0", VA = "0x1805AC2D0", Slot = "46")]
	public override void PlayFallSound()
	{
		GameAPP.PlaySound(74, 0.5f, 1f);
		ScreenShake.TriggerShake(0.05f);
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x000ABDC4 File Offset: 0x000A9FC4
	[Token(Token = "0x6002063")]
	[Address(RVA = "0x5AC270", Offset = "0x5AA870", VA = "0x1805AC270")]
	private void PlayDieSound()
	{
		GameAPP.PlaySound(112, 0.5f, 1f);
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x000ABDE4 File Offset: 0x000A9FE4
	[Token(Token = "0x6002064")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "43")]
	protected override bool GetLadder(Plant plant)
	{
		return false;
	}

	// Token: 0x06002065 RID: 8293 RVA: 0x000ABDF4 File Offset: 0x000A9FF4
	[Token(Token = "0x6002065")]
	[Address(RVA = "0x5AC0D0", Offset = "0x5AA6D0", VA = "0x1805AC0D0", Slot = "80")]
	protected virtual int GetCols()
	{
		Transform axis = this.axis;
		int num = this._LayerMask;
		Collider2D[] array = Gargantuar.sharedCols;
		return Gargantuar.sharedCols.Length;
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x000ABE34 File Offset: 0x000AA034
	[Token(Token = "0x6002066")]
	[Address(RVA = "0x5AC600", Offset = "0x5AAC00", VA = "0x1805AC600")]
	public Gargantuar()
	{
	}

	// Token: 0x04001150 RID: 4432
	[Token(Token = "0x4001150")]
	public static Collider2D[] sharedCols = new Collider2D[32];

	// Token: 0x04001151 RID: 4433
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001151")]
	protected LayerMask _LayerMask;
}
