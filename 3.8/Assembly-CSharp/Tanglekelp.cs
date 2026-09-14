using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000323 RID: 803
[Token(Token = "0x2000323")]
public class Tanglekelp : Plant
{
	// Token: 0x06000E9B RID: 3739 RVA: 0x0005377C File Offset: 0x0005197C
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x413EA0", Offset = "0x4124A0", VA = "0x180413EA0", Slot = "10")]
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

	// Token: 0x06000E9C RID: 3740 RVA: 0x00053814 File Offset: 0x00051A14
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x414010", Offset = "0x412610", VA = "0x180414010", Slot = "35")]
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

	// Token: 0x06000E9D RID: 3741 RVA: 0x00053844 File Offset: 0x00051A44
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x414270", Offset = "0x412870", VA = "0x180414270", Slot = "17")]
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

	// Token: 0x06000E9E RID: 3742 RVA: 0x00053884 File Offset: 0x00051A84
	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x414400", Offset = "0x412A00", VA = "0x180414400", Slot = "69")]
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

	// Token: 0x06000E9F RID: 3743 RVA: 0x00053984 File Offset: 0x00051B84
	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x4148C0", Offset = "0x412EC0", VA = "0x1804148C0", Slot = "70")]
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

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00053A00 File Offset: 0x00051C00
	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x414330", Offset = "0x412930", VA = "0x180414330", Slot = "71")]
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

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00053A5C File Offset: 0x00051C5C
	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0x414100", Offset = "0x412700", VA = "0x180414100", Slot = "53")]
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

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00053ACC File Offset: 0x00051CCC
	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x414A70", Offset = "0x413070", VA = "0x180414A70", Slot = "72")]
	protected virtual IEnumerator Moving()
	{
		Tanglekelp.<Moving>d__11 <Moving>d__;
		<Moving>d__.System.IDisposable.Dispose();
		<Moving>d__.<>1__state = (int)((ulong)0L);
		<Moving>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00053AF0 File Offset: 0x00051CF0
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x414AE0", Offset = "0x4130E0", VA = "0x180414AE0", Slot = "73")]
	protected virtual void SetWaterSplat(Vector2 position, Vector2 scale)
	{
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00053B00 File Offset: 0x00051D00
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x402450", Offset = "0x400A50", VA = "0x180402450")]
	public Tanglekelp()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04000AFE RID: 2814
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000AFE")]
	private Vector2 range = (ulong)1073741824L;

	// Token: 0x04000AFF RID: 2815
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000AFF")]
	protected Transform grab;

	// Token: 0x04000B00 RID: 2816
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B00")]
	private Transform main;

	// Token: 0x04000B01 RID: 2817
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B01")]
	private SortingGroup grabSort;
}
