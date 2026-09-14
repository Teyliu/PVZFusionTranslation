using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000371 RID: 881
[Token(Token = "0x2000371")]
public class CherryMagnet : Magnetshroom
{
	// Token: 0x06001022 RID: 4130 RVA: 0x0005C874 File Offset: 0x0005AA74
	[Token(Token = "0x6001022")]
	[Address(RVA = "0x47A670", Offset = "0x478C70", VA = "0x18047A670", Slot = "75")]
	protected override Bucket SetItemUseable(GameObject obj)
	{
		Bucket component = obj.GetComponent<Bucket>();
		global::UnityEngine.Object.Destroy(component);
		Rigidbody2D rigidbody2D = this.SetAndGetRigidbody2D(obj);
		this.attackCount = (int)((ulong)0L);
		Transform transform = obj.transform;
		this.SetBucketColor(transform);
		return component;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x0005C8B4 File Offset: 0x0005AAB4
	[Token(Token = "0x6001023")]
	[Address(RVA = "0x479DB0", Offset = "0x4783B0", VA = "0x180479DB0", Slot = "72")]
	protected override Bucket AttrackItem(GameObject item, int theRow)
	{
		int num = 0;
		if (item != num)
		{
			Transform transform = item.transform;
			this.SetBucketColor(transform);
		}
		return base.AttrackItem(item, theRow);
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x0005C8EC File Offset: 0x0005AAEC
	[Token(Token = "0x6001024")]
	[Address(RVA = "0x479FB0", Offset = "0x4785B0", VA = "0x180479FB0")]
	private Vector2 GetCounterClockwiseVector(Vector2 originalVector, float angleDegrees)
	{
		float num = angleDegrees * 0.017453292f;
		return default(Vector2);
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x0005C90C File Offset: 0x0005AB0C
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x479E50", Offset = "0x478450", VA = "0x180479E50", Slot = "73")]
	protected override void ChangeLayer()
	{
		GameObject targetItem = this.targetItem;
		int num = 0;
		if (!targetItem.TryGetComponent<SpriteRenderer>(num))
		{
			if (this.targetItem.TryGetComponent<SortingGroup>(num))
			{
			}
			return;
		}
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x0005C944 File Offset: 0x0005AB44
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x47AEF0", Offset = "0x4794F0", VA = "0x18047AEF0", Slot = "60")]
	public override bool UseItem(BucketType type, Bucket bucket)
	{
		GameObject targetItem = this.targetItem;
		int num = 0;
		bool flag = targetItem != num;
		if (!flag)
		{
			float attributeCountdown = this.attributeCountdown;
			if (!flag)
			{
				int num2 = 0;
				if (bucket != num2)
				{
					Vector2 vector;
					this.attackPosition = vector;
					this.attackPosition.y = (float)0;
					this.attackCount = (int)((ulong)0L);
					Magnetshroom magnetShroom = bucket.magnetShroom;
					int num3 = 0;
					if (magnetShroom != num3)
					{
						GameObject targetItem2 = bucket.magnetShroom.targetItem;
						GameObject gameObject = bucket.gameObject;
						if (targetItem2 == gameObject)
						{
							bucket.magnetShroom.targetItem = (ulong)0L;
							bucket.magnetShroom = this;
							Transform transform = bucket.transform;
							Transform transform2 = base.transform;
							transform.parentInternal = transform2;
						}
					}
					GameObject gameObject2 = bucket.gameObject;
					this.targetItem = gameObject2;
					GameObject gameObject3 = bucket.gameObject;
					Bucket bucket2 = this.SetItemUseable(gameObject3);
					global::UnityEngine.Object.Destroy(bucket);
					this.anim.SetTrigger("attrack");
					float attrackMaxTime = this.attrackMaxTime;
					base.AttributeCountdown = attrackMaxTime;
					uint num4;
					GameAPP.PlaySound((int)num4, 0.5f, 1f);
					Rigidbody2D component = this.targetItem.GetComponent<Rigidbody2D>();
					float num5 = global::UnityEngine.Random.Range(-1f, 1f);
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x0005CA90 File Offset: 0x0005AC90
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x47A320", Offset = "0x478920", VA = "0x18047A320")]
	private Rigidbody2D SetAndGetRigidbody2D(GameObject obj)
	{
		bool flag;
		if (!flag)
		{
			Rigidbody2D rigidbody2D = obj.AddComponent<Rigidbody2D>();
			int num = 0;
			rigidbody2D.gravityScale = (float)num;
			rigidbody2D.interpolation = (RigidbodyInterpolation2D)((uint)1);
			Transform transform = this.attrackCenter;
			Transform transform2 = obj.transform;
			int num2 = 0;
			Vector2 velocity = rigidbody2D.velocity;
			rigidbody2D.velocity = num2;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x0005CAE4 File Offset: 0x0005ACE4
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x47A730", Offset = "0x478D30", VA = "0x18047A730")]
	private void TargetItemUpdate()
	{
		Rigidbody2D rigidbody2D;
		for (;;)
		{
			this.ChangeLayer();
			GameObject targetItem = this.targetItem;
			rigidbody2D = this.SetAndGetRigidbody2D(targetItem);
			float y = this.attackPosition.y;
			int num = 0;
			if (num != 0)
			{
				break;
			}
			Transform transform = this.targetItem.transform;
			int num2 = 0;
			rigidbody2D.velocity = num2;
			Transform transform2 = this.targetItem.transform;
			Vector2 vector = this.attackPosition;
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
			int attackDamage = this.attackDamage;
			GameAPP.PlaySound(40, 0.2f, 1f);
			Vector2 zeroVector = Vector2.zeroVector;
			int num3 = 0;
			this.attackPosition = zeroVector;
			this.attackPosition.y = 0.2f;
			Vector2 velocity = rigidbody2D.velocity;
			rigidbody2D.velocity = num3;
			int num4 = this.attackCount;
			num4++;
			this.attackCount = num4;
			GameObject targetItem2 = this.targetItem;
			this.attackCount = num;
			global::UnityEngine.Object.Destroy(targetItem2);
			this.targetItem = num;
			if (this.attributeCountdown > 0.5f)
			{
				goto Block_2;
			}
		}
		Transform transform3 = this.attrackCenter;
		Transform transform4 = this.targetItem.transform;
		Transform transform5 = this.attrackCenter;
		Transform transform6 = this.targetItem.transform;
		if (this.minDistance <= 9.9999994E-11f)
		{
			float num5;
			this.gravitationalForce = num5;
		}
		Vector2 velocity2 = rigidbody2D.velocity;
		Vector2 velocity3 = rigidbody2D.velocity;
		int num6 = 0;
		rigidbody2D.velocity = num6;
		int num7 = 0;
		Vector2 vector2;
		rigidbody2D.AddForce(vector2, (ForceMode2D)num7);
		return;
		Block_2:
		base.AttributeCountdown = 0.5f;
		throw new NullReferenceException();
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x0005CC64 File Offset: 0x0005AE64
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x47AD60", Offset = "0x479360", VA = "0x18047AD60", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		GameObject targetItem = this.targetItem;
		int num = 0;
		if (!(targetItem != num))
		{
			this.timer = 1f;
			return;
		}
		float num2 = this.timer;
		float deltaTime = Time.deltaTime;
		int num3 = 0;
		this.timer = num2;
		if (num3 > (int)num2)
		{
			this.timer = 3f;
			GameObject gameObject = this.SearchZombie();
			int num4 = 0;
			if (gameObject != num4)
			{
				Zombie component = gameObject.GetComponent<Zombie>();
				Collider2D col = component.col;
				int theZombieRow = component.theZombieRow;
				this.targetRow = theZombieRow;
			}
		}
		this.TargetItemUpdate();
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x0005CD08 File Offset: 0x0005AF08
	[Token(Token = "0x600102A")]
	[Address(RVA = "0x479F20", Offset = "0x478520", VA = "0x180479F20", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		GameObject targetItem = this.targetItem;
		int num = 0;
		if (targetItem != num)
		{
			global::UnityEngine.Object.Destroy(this.targetItem);
		}
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x0005CD34 File Offset: 0x0005AF34
	[Token(Token = "0x600102B")]
	[Address(RVA = "0x479C90", Offset = "0x478290", VA = "0x180479C90")]
	private void AttackUpdate()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			this.timer = 3f;
			GameObject gameObject = this.SearchZombie();
			int num3 = 0;
			if (gameObject != num3)
			{
				Zombie component = gameObject.GetComponent<Zombie>();
				Collider2D col = component.col;
				int theZombieRow = component.theZombieRow;
				this.targetRow = theZombieRow;
			}
		}
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x0005CDAC File Offset: 0x0005AFAC
	[Token(Token = "0x600102C")]
	[Address(RVA = "0x47A050", Offset = "0x478650", VA = "0x18047A050", Slot = "76")]
	protected override IEnumerator MoveObject(GameObject obj, Vector2 targetPosition, float duration)
	{
		CherryMagnet.<MoveObject>d__17 <MoveObject>d__;
		<MoveObject>d__.System.IDisposable.Dispose();
		<MoveObject>d__.<>1__state = (int)((ulong)0L);
		return null;
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x0005CDCC File Offset: 0x0005AFCC
	[Token(Token = "0x600102D")]
	[Address(RVA = "0x47A0A0", Offset = "0x4786A0", VA = "0x18047A0A0", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				if (!base.SearchUniqueZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x0005CE38 File Offset: 0x0005B038
	[Token(Token = "0x600102E")]
	[Address(RVA = "0x47A5A0", Offset = "0x478BA0", VA = "0x18047A5A0")]
	private void SetBucketColor(Transform gameObject)
	{
		int num = 0;
		if (gameObject.TryGetComponent<SpriteRenderer>(num))
		{
		}
		int childCount = gameObject.childCount;
		if (num < childCount)
		{
			Transform child = gameObject.GetChild(num);
			this.SetBucketColor(child);
			num++;
		}
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x0005CE78 File Offset: 0x0005B078
	[Token(Token = "0x600102F")]
	[Address(RVA = "0x47B240", Offset = "0x479840", VA = "0x18047B240")]
	public CherryMagnet()
	{
		Vector2 zeroVector = Vector2.zeroVector;
		this.attackPosition = zeroVector;
		base..ctor();
	}

	// Token: 0x04000BAC RID: 2988
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000BAC")]
	public Transform attrackCenter;

	// Token: 0x04000BAD RID: 2989
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000BAD")]
	public float gravitationalForce = 10f;

	// Token: 0x04000BAE RID: 2990
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000BAE")]
	private readonly float minDistance = 1f;

	// Token: 0x04000BAF RID: 2991
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000BAF")]
	private float timer = 1.5f;

	// Token: 0x04000BB0 RID: 2992
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000BB0")]
	private Vector2 attackPosition;

	// Token: 0x04000BB1 RID: 2993
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x4000BB1")]
	private int targetRow;

	// Token: 0x04000BB2 RID: 2994
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000BB2")]
	private int attackCount;
}
