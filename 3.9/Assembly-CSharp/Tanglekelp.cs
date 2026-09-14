using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000333 RID: 819
[Token(Token = "0x2000333")]
public class Tanglekelp : Plant
{
	// Token: 0x06000EE5 RID: 3813 RVA: 0x00054794 File Offset: 0x00052994
	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x46C2A0", Offset = "0x46A8A0", VA = "0x18046C2A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform.Find("Grab");
		this.main = transform;
		Transform transform2 = this.main;
		bool flag;
		if (!flag)
		{
			SortingGroup sortingGroup = this.main.AddComponent<SortingGroup>();
			this.grabSort = sortingGroup;
		}
		this.grabSort.sortAtRoot = true;
		SpriteMask component = this.main.GetChild(1).GetComponent<SpriteMask>();
		int num = 0;
		component.isCustomRangeActive = num != 0;
		Transform transform3 = this.main;
		int num2 = 0;
		Transform child = transform3.GetChild(num2);
		this.grab = child;
		throw new NullReferenceException();
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0005482C File Offset: 0x00052A2C
	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x46C410", Offset = "0x46AA10", VA = "0x18046C410", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		int num = 0;
		if (zombie != num && zombie != 0)
		{
			int num2 = 0;
			base.Die((Plant.DieReason)num2);
		}
		base.Crashed(level, soundID, zombie);
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x0005485C File Offset: 0x00052A5C
	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x46C670", Offset = "0x46AC70", VA = "0x18046C670", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			Zombie targetZombie = this.targetZombie;
			int num = 0;
			if (targetZombie == num)
			{
			}
		}
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x0005489C File Offset: 0x00052A9C
	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x46C800", Offset = "0x46AE00", VA = "0x18046C800", Slot = "68")]
	protected virtual void GrabUpdate()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			bool flag3;
			BoxType boxType;
			if (flag && !flag2 && !flag3 && boxType == BoxType.Water)
			{
				int thePlantRow = this.thePlantRow;
				bool flag4;
				if (flag4)
				{
					goto IL_005D;
				}
			}
			num3++;
			IL_005D:
			ulong num4;
			this.targetZombie = num4;
			this.anim.SetTrigger("grab");
			this.theStatus = (PlantStatus)((ulong)20L);
			this.GrabPrepare();
			Transform axis2 = this.targetZombie.axis;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform transform = this.grab;
			uint num5;
			GameAPP.PlaySound((int)num5, 0.5f, 1f);
			ZombieType theZombieType = this.targetZombie.theZombieType;
			if ((theZombieType > ZombieType.SuperSubmarine && (theZombieType == ZombieType.CherrySubmarine || theZombieType <= ZombieType.BucketZombie)) || theZombieType == ZombieType.SubmarineZombie || theZombieType != ZombieType.SuperSubmarine)
			{
			}
		}
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x0005499C File Offset: 0x00052B9C
	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x46CCC0", Offset = "0x46B2C0", VA = "0x18046CCC0", Slot = "69")]
	protected virtual void Grab()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		Coroutine coroutine;
		if (targetZombie != num)
		{
			Transform axis = this.targetZombie.axis;
			ZombieType theZombieType = this.targetZombie.theZombieType;
			if (theZombieType > ZombieType.SuperSubmarine)
			{
				if (theZombieType == ZombieType.CherrySubmarine || theZombieType <= ZombieType.BucketZombie)
				{
					goto IL_0043;
				}
			}
			else
			{
				while (coroutine == (ulong)14L)
				{
				}
				while (coroutine == (ulong)200L)
				{
				}
			}
			throw new NullReferenceException();
		}
		IL_0043:
		IEnumerator enumerator = this.Moving();
		coroutine = base.StartCoroutine(enumerator);
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00054A18 File Offset: 0x00052C18
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x46C730", Offset = "0x46AD30", VA = "0x18046C730", Slot = "70")]
	protected virtual void GrabPrepare()
	{
		int thePlantRow = this.thePlantRow;
		SortingGroup sortingGroup = this.grabSort;
		string text = string.Format("zombie{0}", thePlantRow);
		sortingGroup.sortingLayerName = text;
		Zombie targetZombie = this.targetZombie;
		SortingGroup sortingGroup2 = this.grabSort;
		int num = targetZombie.sortingGroup.sortingOrder + 1;
		sortingGroup2.sortingOrder = num;
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00054A74 File Offset: 0x00052C74
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x46C500", Offset = "0x46AB00", VA = "0x18046C500", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		bool flag = targetZombie != num;
		if (flag)
		{
			Transform axis = this.targetZombie.axis;
			ZombieType theZombieType = this.targetZombie.theZombieType;
			if (theZombieType > ZombieType.SuperSubmarine)
			{
				if (theZombieType == ZombieType.CherrySubmarine || theZombieType <= ZombieType.BucketZombie)
				{
					uint num2;
					this.targetZombie.Die((int)num2);
					return;
				}
			}
			else
			{
				while (flag)
				{
				}
				while (flag)
				{
				}
			}
			throw new NullReferenceException();
		}
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00054AE4 File Offset: 0x00052CE4
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x46CE70", Offset = "0x46B470", VA = "0x18046CE70", Slot = "71")]
	protected virtual IEnumerator Moving()
	{
		Tanglekelp.<Moving>d__11 <Moving>d__;
		<Moving>d__.System.IDisposable.Dispose();
		<Moving>d__.<>1__state = (int)((ulong)0L);
		<Moving>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00054B08 File Offset: 0x00052D08
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x46CEE0", Offset = "0x46B4E0", VA = "0x18046CEE0", Slot = "72")]
	protected virtual void SetWaterSplat(Vector2 position, Vector2 scale)
	{
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00054B18 File Offset: 0x00052D18
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x459540", Offset = "0x457B40", VA = "0x180459540")]
	public Tanglekelp()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04000B4F RID: 2895
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B4F")]
	private Vector2 range = (ulong)1073741824L;

	// Token: 0x04000B50 RID: 2896
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B50")]
	protected Transform grab;

	// Token: 0x04000B51 RID: 2897
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B51")]
	private Transform main;

	// Token: 0x04000B52 RID: 2898
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B52")]
	private SortingGroup grabSort;
}
