using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020003F6 RID: 1014
[Token(Token = "0x20003F6")]
public class Magnetshroom : Plant
{
	// Token: 0x060012AB RID: 4779 RVA: 0x000687F0 File Offset: 0x000669F0
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x4A6500", Offset = "0x4A4B00", VA = "0x1804A6500", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie", "Ladder" });
		this.magnetLayer = layerMask;
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x0006883C File Offset: 0x00066A3C
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x4A68F0", Offset = "0x4A4EF0", VA = "0x1804A68F0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
		}
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00068868 File Offset: 0x00066A68
	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x4A6990", Offset = "0x4A4F90", VA = "0x1804A6990", Slot = "68")]
	protected virtual void MagnetUpdate()
	{
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00068878 File Offset: 0x00066A78
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x4A6B60", Offset = "0x4A5160", VA = "0x1804A6B60", Slot = "69")]
	protected virtual void SearchZombieWithIron()
	{
		Transform axis = this.axis;
		int num = 0;
		LayerMask layerMask = this.magnetLayer;
		float num2 = this.attrackRange;
		int num3 = layerMask;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag)
			{
				float num4 = this.rangeRow;
				if (this.TryAttrackZombie(num))
				{
					return;
				}
			}
			else if (flag2 && num != 0 && num != 0 && this.rangeRow >= num2)
			{
				goto IL_005D;
			}
			num++;
			IL_005D:
			this.attrackType = (BucketType)((ulong)7L);
			GameObject gameObject2;
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2);
			Bucket bucket = this.AttrackItem(gameObject, num);
			throw new NullReferenceException();
		}
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x00068908 File Offset: 0x00066B08
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x4A6F30", Offset = "0x4A5530", VA = "0x1804A6F30", Slot = "70")]
	protected virtual bool TryAttrackZombie(Zombie zombie)
	{
		int num = 0;
		this.targetZombie = zombie;
		if (zombie.theFirstArmorType <= Zombie.FirstArmorType.TallNut)
		{
			this.attrackType = (BucketType)num;
			GameObject theFirstArmor = zombie.theFirstArmor;
			zombie.theFirstArmor = num;
			zombie.theFirstArmorHealth = num;
			zombie.theFirstArmorType = (Zombie.FirstArmorType)num;
			int theZombieRow = zombie.theZombieRow;
			Bucket bucket = this.AttrackItem(theFirstArmor, theZombieRow);
			zombie.beforeDying = true;
			GameObject gameObject = zombie.DropArmor();
			GameObject theFirstArmor2 = zombie.theFirstArmor;
			zombie.theFirstArmorType = Zombie.FirstArmorType.Nothing;
			global::UnityEngine.Object.Destroy(theFirstArmor2);
			int num2 = 0;
			zombie.Die(num2);
		}
		DoorZombie component;
		if (zombie.theSecondArmorType == Zombie.SecondArmorType.Door)
		{
			this.attrackType = (BucketType)((ulong)10L);
			GameObject theSecondArmor = zombie.theSecondArmor;
			zombie.theSecondArmor = num;
			Animator anim = zombie.anim;
			zombie.theSecondArmorHealth = num;
			zombie.theSecondArmorType = (Zombie.SecondArmorType)num;
			anim.SetTrigger("loseDoor");
			ulong num3;
			zombie.anim.SetBool("isLoseDoor", num3 != 0UL);
			int theZombieRow2 = zombie.theZombieRow;
			Bucket bucket2 = this.AttrackItem(theSecondArmor, theZombieRow2);
			component = zombie.GetComponent<DoorZombie>();
			component.DestoryHand();
		}
		LadderZombie component2;
		if (component == (ulong)3L)
		{
			this.attrackType = (BucketType)((ulong)7L);
			component2 = zombie.GetComponent<LadderZombie>();
			component2.LoseLadder();
		}
		Zombie.UniqueItemType theUniqueItemType = zombie.theUniqueItemType;
		bool flag2;
		if (component2 != 0)
		{
			if (component2 != 0)
			{
				if (component2 != 0)
				{
					if (component2 != 0 && theUniqueItemType != Zombie.UniqueItemType.Jackbox)
					{
						bool flag = this.MoreAttrack(zombie);
					}
					flag2 = zombie.theUniqueItemType != Zombie.UniqueItemType.IronHead;
					this.attrackType = (flag2 ? BucketType.Helmet : BucketType.Bucket);
					List<GameObject> theUniqueItems = zombie.theUniqueItems;
					int num4 = 0;
					GameObject gameObject2 = theUniqueItems[num4];
					int theZombieRow3 = zombie.theZombieRow;
					Bucket bucket3 = this.AttrackItem(gameObject2, theZombieRow3);
					IronGargantuar component3 = zombie.GetComponent<IronGargantuar>();
					ulong num5;
					component3.theHealth = (long)num5;
					component3.LoseIronHead();
				}
				this.attrackType = (BucketType)((ulong)3L);
				List<GameObject> theUniqueItems2 = zombie.theUniqueItems;
				int num6 = 0;
				GameObject gameObject3 = theUniqueItems2[num6];
				int theZombieRow4 = zombie.theZombieRow;
				Bucket bucket4 = this.AttrackItem(gameObject3, theZombieRow4);
			}
			this.attrackType = (BucketType)((ulong)6L);
			List<GameObject> theUniqueItems3 = zombie.theUniqueItems;
			int num7 = 0;
			GameObject gameObject4 = theUniqueItems3[num7];
			int theZombieRow5 = zombie.theZombieRow;
			Bucket bucket5 = this.AttrackItem(gameObject4, theZombieRow5);
			PogoZombie component4 = zombie.GetComponent<PogoZombie>();
			int num8 = 0;
			component4.LoseJumper(num8);
		}
		if (zombie.TryGetComponent<JackboxZombie>(num))
		{
		}
		this.attrackType = (BucketType)((ulong)2L);
		List<GameObject> theUniqueItems4 = zombie.theUniqueItems;
		int num9 = 0;
		GameObject gameObject5 = theUniqueItems4[num9];
		int theZombieRow6 = zombie.theZombieRow;
		Bucket bucket6 = this.AttrackItem(gameObject5, theZombieRow6);
		uint num10;
		global::UnityEngine.Object.Destroy(zombie.theUniqueItems[(int)num10]);
		List<GameObject> theUniqueItems5 = zombie.theUniqueItems;
		int num11 = 0;
		int num12 = 0;
		theUniqueItems5[num12] = num11;
		zombie.theUniqueItemType = (flag2 ? Zombie.UniqueItemType.Jackbox : Zombie.UniqueItemType.Nothing);
		throw new NullReferenceException();
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x00068B9C File Offset: 0x00066D9C
	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "71")]
	protected virtual bool MoreAttrack(Zombie zombie)
	{
		return false;
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x00068BAC File Offset: 0x00066DAC
	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x4A5B20", Offset = "0x4A4120", VA = "0x1804A5B20", Slot = "72")]
	protected virtual Bucket AttrackItem(GameObject item, int theRow)
	{
		int num = 0;
		if (!(item == num))
		{
			if (!item.TryGetComponent<Bucket>(num))
			{
				if (this.attrackType <= BucketType.Door)
				{
					GameObject gameObject = GameAPP.itemPrefab[4];
					Transform transform = item.transform;
					GameObject gameObject2;
					Bucket bucket = this.SetItemUseable(gameObject2);
					global::UnityEngine.Object.Destroy(item);
					GameObject[] itemPrefab = GameAPP.itemPrefab;
					GameObject[] itemPrefab2 = GameAPP.itemPrefab;
					GameObject[] itemPrefab3 = GameAPP.itemPrefab;
					GameObject[] itemPrefab4 = GameAPP.itemPrefab;
					GameObject[] itemPrefab5 = GameAPP.itemPrefab;
					GameObject[] itemPrefab6 = GameAPP.itemPrefab;
					GameObject[] itemPrefab7 = GameAPP.itemPrefab;
					GameObject[] itemPrefab8 = GameAPP.itemPrefab;
				}
				GameObject[] itemPrefab9 = GameAPP.itemPrefab;
			}
			this.targetItem = item;
			this.ChangeLayer();
			this.anim.SetTrigger("attrack");
			float num2 = this.attrackMaxTime;
			base.AttributeCountdown = num2;
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			this.MoveIronItem();
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x00068C8C File Offset: 0x00066E8C
	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x4A65D0", Offset = "0x4A4BD0", VA = "0x1804A65D0", Slot = "73")]
	protected virtual void ChangeLayer()
	{
		GameObject gameObject = this.targetItem;
		int num = 0;
		if (!gameObject.TryGetComponent<SpriteRenderer>(num))
		{
			if (this.targetItem.TryGetComponent<SortingGroup>(num))
			{
				int thePlantRow = this.thePlantRow;
				string text = string.Format("plant{0}", thePlantRow);
				int num2 = this.baseLayer;
				num2 += 30;
			}
			return;
		}
		int thePlantRow2 = this.thePlantRow;
		string text2 = string.Format("plant{0}", thePlantRow2);
		int num3 = this.baseLayer;
		num3 += 30;
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x00068D0C File Offset: 0x00066F0C
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x4A69C0", Offset = "0x4A4FC0", VA = "0x1804A69C0", Slot = "74")]
	protected virtual void MoveIronItem()
	{
		GameObject gameObject = this.targetItem;
		Transform transform = base.transform.Find("Position");
		int num = 0;
		IEnumerator enumerator = this.MoveObject(gameObject, num, 0.3f);
		Coroutine coroutine = base.StartCoroutine(enumerator);
		Transform transform2 = this.targetItem.transform;
		Transform transform3 = base.transform;
		transform2.parentInternal = transform3;
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x00068D74 File Offset: 0x00066F74
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x4A6EB0", Offset = "0x4A54B0", VA = "0x1804A6EB0", Slot = "75")]
	protected virtual Bucket SetItemUseable(GameObject obj)
	{
		Bucket component = obj.GetComponent<Bucket>();
		component.isLand = true;
		component.magnetShroom = this;
		return component;
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x00068DA0 File Offset: 0x00066FA0
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x4A6AC0", Offset = "0x4A50C0", VA = "0x1804A6AC0", Slot = "76")]
	protected virtual IEnumerator MoveObject(GameObject obj, Vector2 targetPosition, float duration)
	{
		Magnetshroom.<MoveObject>d__16 <MoveObject>d__;
		<MoveObject>d__.System.IDisposable.Dispose();
		<MoveObject>d__.<>1__state = (int)((ulong)0L);
		<MoveObject>d__.obj = obj;
		<MoveObject>d__.duration = duration;
		<MoveObject>d__.targetPosition = targetPosition;
		<MoveObject>d__.targetPosition.y = (float)0;
		return null;
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x00068DE0 File Offset: 0x00066FE0
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x4A6100", Offset = "0x4A4700", VA = "0x1804A6100", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num;
		List<HypnoMagnet> list;
		List<HypnoMagnet> list2;
		do
		{
			num = 0;
			this.anim.SetTrigger("recover");
			global::UnityEngine.Object.Destroy(this.targetItem);
			this.targetItem = num;
			List<Plant> plants = MagnetSystem.GetPlants(this);
			list = new List();
			list2 = new List();
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
					int thePlantRow = this.thePlantRow;
				}
				MagnetBox magnetBox;
				if (flag2)
				{
					int num2 = 0;
					BucketType bucketType = this.attrackType;
					magnetBox.AddMagnet(bucketType, num2);
				}
				while (magnetBox != (ulong)924L)
				{
				}
			}
		}
		while (num != 0);
		int size = list._size;
		int num3 = global::UnityEngine.Random.Range(0, size);
		int num4 = list2._size;
		num4 = global::UnityEngine.Random.Range(0, num4);
		HypnoMagnet hypnoMagnet = list2[num4];
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x00068EBC File Offset: 0x000670BC
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x4A6770", Offset = "0x4A4D70", VA = "0x1804A6770", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		GameObject gameObject = this.targetItem;
		int num = 0;
		if (gameObject != num)
		{
			GameObject gameObject2 = this.targetItem;
			bool flag;
			if (flag)
			{
				Transform transform = this.board.transform;
				Transform transform2;
				transform2.parentInternal = transform;
			}
		}
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x00068F08 File Offset: 0x00067108
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x49B110", Offset = "0x499710", VA = "0x18049B110")]
	public Magnetshroom()
	{
	}

	// Token: 0x04000C75 RID: 3189
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C75")]
	protected BucketType attrackType;

	// Token: 0x04000C76 RID: 3190
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C76")]
	public GameObject targetItem;

	// Token: 0x04000C77 RID: 3191
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C77")]
	protected float attrackRange = 4f;

	// Token: 0x04000C78 RID: 3192
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000C78")]
	protected float attrackMaxTime = 15f;

	// Token: 0x04000C79 RID: 3193
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C79")]
	protected float rangeRow = 2f;

	// Token: 0x04000C7A RID: 3194
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000C7A")]
	protected LayerMask magnetLayer;
}
