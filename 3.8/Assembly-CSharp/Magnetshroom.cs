using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020003E0 RID: 992
[Token(Token = "0x20003E0")]
public class Magnetshroom : Plant
{
	// Token: 0x06001247 RID: 4679 RVA: 0x00066E70 File Offset: 0x00065070
	[Token(Token = "0x6001247")]
	[Address(RVA = "0x4519E0", Offset = "0x44FFE0", VA = "0x1804519E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie", "Ladder" });
		this.magnetLayer = layerMask;
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00066EBC File Offset: 0x000650BC
	[Token(Token = "0x6001248")]
	[Address(RVA = "0x451DD0", Offset = "0x4503D0", VA = "0x180451DD0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
		}
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00066EE8 File Offset: 0x000650E8
	[Token(Token = "0x6001249")]
	[Address(RVA = "0x451E70", Offset = "0x450470", VA = "0x180451E70", Slot = "69")]
	protected virtual void MagnetUpdate()
	{
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00066EF8 File Offset: 0x000650F8
	[Token(Token = "0x600124A")]
	[Address(RVA = "0x452040", Offset = "0x450640", VA = "0x180452040", Slot = "70")]
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

	// Token: 0x0600124B RID: 4683 RVA: 0x00066F88 File Offset: 0x00065188
	[Token(Token = "0x600124B")]
	[Address(RVA = "0x452410", Offset = "0x450A10", VA = "0x180452410", Slot = "71")]
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
					int theHealth = component3.theHealth;
					component3.LoseIronHead();
				}
				this.attrackType = (BucketType)((ulong)3L);
				List<GameObject> theUniqueItems2 = zombie.theUniqueItems;
				int num5 = 0;
				GameObject gameObject3 = theUniqueItems2[num5];
				int theZombieRow4 = zombie.theZombieRow;
				Bucket bucket4 = this.AttrackItem(gameObject3, theZombieRow4);
			}
			this.attrackType = (BucketType)((ulong)6L);
			List<GameObject> theUniqueItems3 = zombie.theUniqueItems;
			int num6 = 0;
			GameObject gameObject4 = theUniqueItems3[num6];
			int theZombieRow5 = zombie.theZombieRow;
			Bucket bucket5 = this.AttrackItem(gameObject4, theZombieRow5);
			PogoZombie component4 = zombie.GetComponent<PogoZombie>();
			int num7 = 0;
			component4.LoseJumper(num7);
		}
		if (zombie.TryGetComponent<JackboxZombie>(num))
		{
		}
		this.attrackType = (BucketType)((ulong)2L);
		List<GameObject> theUniqueItems4 = zombie.theUniqueItems;
		int num8 = 0;
		GameObject gameObject5 = theUniqueItems4[num8];
		int theZombieRow6 = zombie.theZombieRow;
		Bucket bucket6 = this.AttrackItem(gameObject5, theZombieRow6);
		uint num9;
		global::UnityEngine.Object.Destroy(zombie.theUniqueItems[(int)num9]);
		List<GameObject> theUniqueItems5 = zombie.theUniqueItems;
		int num10 = 0;
		int num11 = 0;
		theUniqueItems5[num11] = num10;
		zombie.theUniqueItemType = (flag2 ? Zombie.UniqueItemType.Jackbox : Zombie.UniqueItemType.Nothing);
		throw new NullReferenceException();
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x0006721C File Offset: 0x0006541C
	[Token(Token = "0x600124C")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "72")]
	protected virtual bool MoreAttrack(Zombie zombie)
	{
		return false;
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x0006722C File Offset: 0x0006542C
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x451000", Offset = "0x44F600", VA = "0x180451000", Slot = "73")]
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

	// Token: 0x0600124E RID: 4686 RVA: 0x0006730C File Offset: 0x0006550C
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x451AB0", Offset = "0x4500B0", VA = "0x180451AB0", Slot = "74")]
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

	// Token: 0x0600124F RID: 4687 RVA: 0x0006738C File Offset: 0x0006558C
	[Token(Token = "0x600124F")]
	[Address(RVA = "0x451EA0", Offset = "0x4504A0", VA = "0x180451EA0", Slot = "75")]
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

	// Token: 0x06001250 RID: 4688 RVA: 0x000673F4 File Offset: 0x000655F4
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x452390", Offset = "0x450990", VA = "0x180452390", Slot = "76")]
	protected virtual Bucket SetItemUseable(GameObject obj)
	{
		Bucket component = obj.GetComponent<Bucket>();
		component.isLand = true;
		component.magnetShroom = this;
		return component;
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00067420 File Offset: 0x00065620
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x451FA0", Offset = "0x4505A0", VA = "0x180451FA0", Slot = "77")]
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

	// Token: 0x06001252 RID: 4690 RVA: 0x00067460 File Offset: 0x00065660
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x4515E0", Offset = "0x44FBE0", VA = "0x1804515E0", Slot = "40")]
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

	// Token: 0x06001253 RID: 4691 RVA: 0x0006753C File Offset: 0x0006573C
	[Token(Token = "0x6001253")]
	[Address(RVA = "0x451C50", Offset = "0x450250", VA = "0x180451C50", Slot = "53")]
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

	// Token: 0x06001254 RID: 4692 RVA: 0x00067588 File Offset: 0x00065788
	[Token(Token = "0x6001254")]
	[Address(RVA = "0x446C80", Offset = "0x445280", VA = "0x180446C80")]
	public Magnetshroom()
	{
	}

	// Token: 0x04000C07 RID: 3079
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C07")]
	protected BucketType attrackType;

	// Token: 0x04000C08 RID: 3080
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C08")]
	public GameObject targetItem;

	// Token: 0x04000C09 RID: 3081
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C09")]
	protected float attrackRange = 4f;

	// Token: 0x04000C0A RID: 3082
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000C0A")]
	protected float attrackMaxTime = 15f;

	// Token: 0x04000C0B RID: 3083
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C0B")]
	protected float rangeRow = 2f;

	// Token: 0x04000C0C RID: 3084
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000C0C")]
	protected LayerMask magnetLayer;
}
