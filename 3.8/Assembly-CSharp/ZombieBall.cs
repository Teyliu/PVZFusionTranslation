using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000725 RID: 1829
[Token(Token = "0x2000725")]
public class ZombieBall : Obstacle
{
	// Token: 0x06002514 RID: 9492 RVA: 0x000C2EB8 File Offset: 0x000C10B8
	[Token(Token = "0x6002514")]
	[Address(RVA = "0x5CDC70", Offset = "0x5CC270", VA = "0x1805CDC70", Slot = "4")]
	protected override void Awake()
	{
		base.Awake();
		this.Vx = -0.5f;
		if (!Board.Instance.isEveStarted)
		{
			this.Vx = -1f;
		}
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Animator component2 = base.GetComponent<Animator>();
		this.anim = component2;
		throw new NullReferenceException();
	}

	// Token: 0x06002515 RID: 9493 RVA: 0x000C2F10 File Offset: 0x000C1110
	[Token(Token = "0x6002515")]
	[Address(RVA = "0x5CE310", Offset = "0x5CC910", VA = "0x1805CE310")]
	private void Start()
	{
		if (this.boss)
		{
			float num = this.Vx * 1.5f;
			this.Vx = num;
		}
		if (this.plant)
		{
			this.Vx = 1f;
		}
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x000C2F50 File Offset: 0x000C1150
	[Token(Token = "0x6002516")]
	[Address(RVA = "0x5CE340", Offset = "0x5CC940", VA = "0x1805CE340")]
	private void Update()
	{
		float num = this.timer;
		int num2 = 0;
		if ((this.plant ? 1 : 0) == num2)
		{
			float deltaTime = Time.deltaTime;
			this.timer = deltaTime;
			if (deltaTime > 30f && !this.boss)
			{
				this.Die();
			}
			this.PositionUpdate();
			return;
		}
		float deltaTime2 = Time.deltaTime;
		this.timer = num;
		this.timer = 1.5f;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		FireOcean component = gameObject.GetComponent<FireOcean>();
		int num3 = this.dmg;
		component.theDamage = num3;
		int theBallRow = this.theBallRow;
		component.theRow = theBallRow;
		throw new NullReferenceException();
	}

	// Token: 0x06002517 RID: 9495 RVA: 0x000C2FF8 File Offset: 0x000C11F8
	[Token(Token = "0x6002517")]
	[Address(RVA = "0x5CDFD0", Offset = "0x5CC5D0", VA = "0x1805CDFD0")]
	private void PositionUpdate()
	{
		Board instance = Board.Instance;
		Transform transform = base.transform;
		if (!this.boss && !this.plant)
		{
			float vx = this.Vx;
			float deltaTime = Time.deltaTime;
			this.Vx = vx;
		}
		Animator animator = this.anim;
		float vx2 = this.Vx;
		animator.SetFloat("Speed", vx2);
		Rigidbody2D rigidbody2D = this.rb;
		float vx3 = this.Vx;
		int num = 0;
		if (num > (int)this.Vx)
		{
			if (!this.boss && !this.plant)
			{
				float num2 = Time.deltaTime * 0.25f;
				this.Vx = num2;
			}
			if (this.Vx > (float)num)
			{
				this.Vx = 0f;
			}
		}
		Animator animator2 = this.anim;
		float vx4 = this.Vx;
		animator2.SetFloat("Speed", vx4);
		Rigidbody2D rigidbody2D2 = this.rb;
		if (this.boss || this.plant)
		{
			Animator animator3 = this.anim;
			float num3 = this.Vx * 0.5f;
			animator3.SetFloat("Speed", num3);
		}
		Transform transform2 = base.transform;
		float boardMaxX = Board.Instance.boardMaxX;
		this.Die();
		Transform transform3 = base.transform;
		float boardMinX = Board.Instance.boardMinX;
		this.Die();
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x000C3150 File Offset: 0x000C1350
	[Token(Token = "0x6002518")]
	[Address(RVA = "0x5CDEC0", Offset = "0x5CC4C0", VA = "0x1805CDEC0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.plant)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				return;
			}
		}
		else
		{
			this.ZombieBallEffect(collision);
		}
	}

	// Token: 0x06002519 RID: 9497 RVA: 0x000C3180 File Offset: 0x000C1380
	[Token(Token = "0x6002519")]
	[Address(RVA = "0x5CE4A0", Offset = "0x5CCAA0", VA = "0x1805CE4A0")]
	private void ZombieBallEffect(Collider2D collision)
	{
		int num;
		for (;;)
		{
			num = 0;
			if (!collision.TryGetComponent<Plant>(num))
			{
				break;
			}
			int theBallRow = this.theBallRow;
			if (this.boss || TypeMgr.UncrashablePlant(num))
			{
				goto IL_0099;
			}
			int num2 = 0;
			Plant plant;
			if (plant == num2)
			{
				goto Block_7;
			}
		}
		if (!collision.TryGetComponent<Zombie>(num))
		{
			if (collision.TryGetComponent<Bullet>(num) && (this.boss ? 1 : 0) == num)
			{
				int theBallRow2 = this.theBallRow;
				int num3 = this.bulletTime;
				num3++;
				this.flashTime = 0.3f;
				this.bulletTime = num3;
				if (num3 > 30)
				{
					this.Die();
				}
			}
			return;
		}
		int theBallRow3 = this.theBallRow;
		return;
		Block_7:
		int num4 = global::UnityEngine.Random.Range(8, 10);
		return;
		IL_0099:
		int num5 = 0;
		int num6 = num.System.IConvertible.ToInt32(num5);
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x000C323C File Offset: 0x000C143C
	[Token(Token = "0x600251A")]
	[Address(RVA = "0x5CDDB0", Offset = "0x5CC3B0", VA = "0x1805CDDB0", Slot = "6")]
	public override void Die()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x000C3274 File Offset: 0x000C1474
	[Token(Token = "0x600251B")]
	[Address(RVA = "0x5CE290", Offset = "0x5CC890", VA = "0x1805CE290")]
	public void StartBigger()
	{
		ZombieBall.<Bigger>d__16 <Bigger>d__;
		<Bigger>d__.System.IDisposable.Dispose();
		<Bigger>d__.<>1__state = (int)((ulong)0L);
		<Bigger>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Bigger>d__);
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x000C32A0 File Offset: 0x000C14A0
	[Token(Token = "0x600251C")]
	[Address(RVA = "0x5CDD40", Offset = "0x5CC340", VA = "0x1805CDD40")]
	private IEnumerator Bigger()
	{
		ZombieBall.<Bigger>d__16 <Bigger>d__;
		<Bigger>d__.System.IDisposable.Dispose();
		<Bigger>d__.<>1__state = (int)((ulong)0L);
		<Bigger>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x000C32C4 File Offset: 0x000C14C4
	[Token(Token = "0x600251D")]
	[Address(RVA = "0x5CE840", Offset = "0x5CCE40", VA = "0x1805CE840")]
	public ZombieBall()
	{
	}

	// Token: 0x0400128F RID: 4751
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400128F")]
	private int bulletTime;

	// Token: 0x04001290 RID: 4752
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001290")]
	private float timer;

	// Token: 0x04001291 RID: 4753
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001291")]
	private Rigidbody2D rb;

	// Token: 0x04001292 RID: 4754
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001292")]
	private Animator anim;

	// Token: 0x04001293 RID: 4755
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001293")]
	private float Vx = -1.5f;

	// Token: 0x04001294 RID: 4756
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001294")]
	public int dmg;

	// Token: 0x04001295 RID: 4757
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001295")]
	public bool boss;

	// Token: 0x04001296 RID: 4758
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4001296")]
	public bool plant;
}
