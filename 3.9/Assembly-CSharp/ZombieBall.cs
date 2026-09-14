using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200075E RID: 1886
[Token(Token = "0x200075E")]
public class ZombieBall : Obstacle
{
	// Token: 0x06002637 RID: 9783 RVA: 0x000C7DAC File Offset: 0x000C5FAC
	[Token(Token = "0x6002637")]
	[Address(RVA = "0x62EFE0", Offset = "0x62D5E0", VA = "0x18062EFE0", Slot = "4")]
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

	// Token: 0x06002638 RID: 9784 RVA: 0x000C7E04 File Offset: 0x000C6004
	[Token(Token = "0x6002638")]
	[Address(RVA = "0x62F680", Offset = "0x62DC80", VA = "0x18062F680")]
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

	// Token: 0x06002639 RID: 9785 RVA: 0x000C7E44 File Offset: 0x000C6044
	[Token(Token = "0x6002639")]
	[Address(RVA = "0x62F6B0", Offset = "0x62DCB0", VA = "0x18062F6B0")]
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

	// Token: 0x0600263A RID: 9786 RVA: 0x000C7EEC File Offset: 0x000C60EC
	[Token(Token = "0x600263A")]
	[Address(RVA = "0x62F340", Offset = "0x62D940", VA = "0x18062F340")]
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

	// Token: 0x0600263B RID: 9787 RVA: 0x000C8044 File Offset: 0x000C6244
	[Token(Token = "0x600263B")]
	[Address(RVA = "0x62F230", Offset = "0x62D830", VA = "0x18062F230")]
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

	// Token: 0x0600263C RID: 9788 RVA: 0x000C8074 File Offset: 0x000C6274
	[Token(Token = "0x600263C")]
	[Address(RVA = "0x62F810", Offset = "0x62DE10", VA = "0x18062F810")]
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

	// Token: 0x0600263D RID: 9789 RVA: 0x000C8130 File Offset: 0x000C6330
	[Token(Token = "0x600263D")]
	[Address(RVA = "0x62F120", Offset = "0x62D720", VA = "0x18062F120", Slot = "6")]
	public override void Die()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x000C8168 File Offset: 0x000C6368
	[Token(Token = "0x600263E")]
	[Address(RVA = "0x62F600", Offset = "0x62DC00", VA = "0x18062F600")]
	public void StartBigger()
	{
		ZombieBall.<Bigger>d__16 <Bigger>d__;
		<Bigger>d__.System.IDisposable.Dispose();
		<Bigger>d__.<>1__state = (int)((ulong)0L);
		<Bigger>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Bigger>d__);
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x000C8194 File Offset: 0x000C6394
	[Token(Token = "0x600263F")]
	[Address(RVA = "0x62F0B0", Offset = "0x62D6B0", VA = "0x18062F0B0")]
	private IEnumerator Bigger()
	{
		ZombieBall.<Bigger>d__16 <Bigger>d__;
		<Bigger>d__.System.IDisposable.Dispose();
		<Bigger>d__.<>1__state = (int)((ulong)0L);
		<Bigger>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x000C81B8 File Offset: 0x000C63B8
	[Token(Token = "0x6002640")]
	[Address(RVA = "0x62FBA0", Offset = "0x62E1A0", VA = "0x18062FBA0")]
	public ZombieBall()
	{
	}

	// Token: 0x04001364 RID: 4964
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001364")]
	private int bulletTime;

	// Token: 0x04001365 RID: 4965
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001365")]
	private float timer;

	// Token: 0x04001366 RID: 4966
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001366")]
	private Rigidbody2D rb;

	// Token: 0x04001367 RID: 4967
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001367")]
	private Animator anim;

	// Token: 0x04001368 RID: 4968
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001368")]
	private float Vx = -1.5f;

	// Token: 0x04001369 RID: 4969
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001369")]
	public int dmg;

	// Token: 0x0400136A RID: 4970
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400136A")]
	public bool boss;

	// Token: 0x0400136B RID: 4971
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x400136B")]
	public bool plant;
}
