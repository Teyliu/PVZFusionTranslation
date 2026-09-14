using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000361 RID: 865
[Token(Token = "0x2000361")]
public class CherryMagnet : Magnetshroom
{
	// Token: 0x06000FD6 RID: 4054 RVA: 0x0005B8B4 File Offset: 0x00059AB4
	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x423860", Offset = "0x421E60", VA = "0x180423860", Slot = "76")]
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

	// Token: 0x06000FD7 RID: 4055 RVA: 0x0005B8F4 File Offset: 0x00059AF4
	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x422FA0", Offset = "0x4215A0", VA = "0x180422FA0", Slot = "73")]
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

	// Token: 0x06000FD8 RID: 4056 RVA: 0x0005B92C File Offset: 0x00059B2C
	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x4231A0", Offset = "0x4217A0", VA = "0x1804231A0")]
	private Vector2 GetCounterClockwiseVector(Vector2 originalVector, float angleDegrees)
	{
		float num = angleDegrees * 0.017453292f;
		return default(Vector2);
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x0005B94C File Offset: 0x00059B4C
	[Token(Token = "0x6000FD9")]
	[Address(RVA = "0x423040", Offset = "0x421640", VA = "0x180423040", Slot = "74")]
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

	// Token: 0x06000FDA RID: 4058 RVA: 0x0005B984 File Offset: 0x00059B84
	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x4240E0", Offset = "0x4226E0", VA = "0x1804240E0", Slot = "61")]
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

	// Token: 0x06000FDB RID: 4059 RVA: 0x0005BAD0 File Offset: 0x00059CD0
	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0x423510", Offset = "0x421B10", VA = "0x180423510")]
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

	// Token: 0x06000FDC RID: 4060 RVA: 0x0005BB24 File Offset: 0x00059D24
	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0x423920", Offset = "0x421F20", VA = "0x180423920")]
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

	// Token: 0x06000FDD RID: 4061 RVA: 0x0005BCA4 File Offset: 0x00059EA4
	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0x423F50", Offset = "0x422550", VA = "0x180423F50", Slot = "16")]
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

	// Token: 0x06000FDE RID: 4062 RVA: 0x0005BD48 File Offset: 0x00059F48
	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x423110", Offset = "0x421710", VA = "0x180423110", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		GameObject targetItem = this.targetItem;
		int num = 0;
		if (targetItem != num)
		{
			global::UnityEngine.Object.Destroy(this.targetItem);
		}
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x0005BD74 File Offset: 0x00059F74
	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x422E80", Offset = "0x421480", VA = "0x180422E80")]
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

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0005BDEC File Offset: 0x00059FEC
	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0x423240", Offset = "0x421840", VA = "0x180423240", Slot = "77")]
	protected override IEnumerator MoveObject(GameObject obj, Vector2 targetPosition, float duration)
	{
		CherryMagnet.<MoveObject>d__17 <MoveObject>d__;
		<MoveObject>d__.System.IDisposable.Dispose();
		<MoveObject>d__.<>1__state = (int)((ulong)0L);
		return null;
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0005BE0C File Offset: 0x0005A00C
	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0x423290", Offset = "0x421890", VA = "0x180423290", Slot = "44")]
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

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0005BE78 File Offset: 0x0005A078
	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x423790", Offset = "0x421D90", VA = "0x180423790")]
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

	// Token: 0x06000FE3 RID: 4067 RVA: 0x0005BEB8 File Offset: 0x0005A0B8
	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x424430", Offset = "0x422A30", VA = "0x180424430")]
	public CherryMagnet()
	{
		Vector2 zeroVector = Vector2.zeroVector;
		this.attackPosition = zeroVector;
		base..ctor();
	}

	// Token: 0x04000B5B RID: 2907
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B5B")]
	public Transform attrackCenter;

	// Token: 0x04000B5C RID: 2908
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B5C")]
	public float gravitationalForce = 10f;

	// Token: 0x04000B5D RID: 2909
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000B5D")]
	private readonly float minDistance = 1f;

	// Token: 0x04000B5E RID: 2910
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000B5E")]
	private float timer = 1.5f;

	// Token: 0x04000B5F RID: 2911
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000B5F")]
	private Vector2 attackPosition;

	// Token: 0x04000B60 RID: 2912
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x4000B60")]
	private int targetRow;

	// Token: 0x04000B61 RID: 2913
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000B61")]
	private int attackCount;
}
