using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002AF RID: 687
[Token(Token = "0x20002AF")]
public class CoinMoney : MonoBehaviour
{
	// Token: 0x06000C23 RID: 3107 RVA: 0x00045DD8 File Offset: 0x00043FD8
	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x3D1DF0", Offset = "0x3D03F0", VA = "0x1803D1DF0")]
	private void Start()
	{
		Money instance = Money.Instance;
		int num = 0;
		if (!(instance != num))
		{
			InGameUI instance2 = InGameUI.Instance;
			int num2 = 0;
			if (!(instance2 != num2))
			{
				return;
			}
			ulong num3;
			InGameUI.Instance.MoneyBank.SetActive(num3 != 0UL);
		}
		Money.Instance.EnableMoneyBank();
		Transform moneyPos = Money.Instance.moneyPos;
		this.target = moneyPos;
		Transform transform = base.transform;
		float num4 = global::UnityEngine.Random.Range(-1.5f, 1.5f);
		float num5 = this.verticalSpeed;
		this.velocity.y = num5;
		int num6 = this.theCoinType;
		num6 += -34;
		this.velocity = num4;
		if (num6 <= 5)
		{
			this.moneyPrice = (int)((ulong)300L);
			this.moneyPrice = (int)((ulong)1000L);
			this.moneyPrice = (int)((ulong)25L);
			this.moneyPrice = (int)((ulong)100L);
		}
		Money instance3 = Money.Instance;
		int num7 = 0;
		if (instance3 != num7)
		{
			Money.Instance.EnableMoneyBank();
		}
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00045EDC File Offset: 0x000440DC
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x3D2040", Offset = "0x3D0640", VA = "0x1803D2040")]
	private void Update()
	{
		if (!this.isLand)
		{
			if (this.theMoveType == 1)
			{
				float timeScale = Time.timeScale;
				if (this.theMoveType != 1)
				{
					goto IL_008A;
				}
			}
			if (!this.isLand)
			{
				float y = this.velocity.y;
				float deltaTime = Time.deltaTime;
				this.velocity.y = y;
				Transform transform = base.transform;
				float deltaTime2 = Time.deltaTime;
				Transform transform2 = base.transform;
				Vector3 vector;
				if (this.startPosition.y > vector.y)
				{
					this.isLand = true;
				}
			}
			return;
		}
		IL_008A:
		this.MoveToPosition();
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x00045F80 File Offset: 0x00044180
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x3D18F0", Offset = "0x3CFEF0", VA = "0x1803D18F0")]
	private void MoveToPosition()
	{
		Transform transform = this.target;
		int num = 0;
		if (!(transform == num))
		{
			Transform transform2 = this.target;
			Vector3 position = transform.position;
			Transform transform3 = base.transform;
			float num2 = this.moveSpeed;
			float deltaTime = Time.deltaTime;
			this.moveSpeed = num2;
			Transform transform4 = base.transform;
			Transform transform5 = base.transform;
			Transform transform6 = this.target;
			Vector3 vector;
			float z = vector.z;
			float deltaTime2 = Time.deltaTime;
			Transform transform7 = base.transform;
			float deltaTime3 = Time.deltaTime;
			float deltaTime4 = Time.deltaTime;
			float deltaTime5 = Time.deltaTime;
			Transform transform8 = base.transform;
			bool flag;
			if (flag)
			{
				int maxMoney = Board.Instance.maxMoney;
				Board instance = Board.Instance;
				int num3 = this.moneyPrice;
				num3 -= typeof(Board).TypeHandle;
			}
			Board instance2 = Board.Instance;
			this.Die();
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
		throw new NullReferenceException();
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x000460A4 File Offset: 0x000442A4
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x3D1890", Offset = "0x3CFE90", VA = "0x1803D1890")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x000460BC File Offset: 0x000442BC
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x3D2170", Offset = "0x3D0770", VA = "0x1803D2170")]
	public CoinMoney()
	{
	}

	// Token: 0x04000828 RID: 2088
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000828")]
	public int theCoinType;

	// Token: 0x04000829 RID: 2089
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000829")]
	public int theMoveType;

	// Token: 0x0400082A RID: 2090
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400082A")]
	public int moneyPrice = (int)((ulong)25L);

	// Token: 0x0400082B RID: 2091
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400082B")]
	private Transform target;

	// Token: 0x0400082C RID: 2092
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400082C")]
	private float moveSpeed = 300f;

	// Token: 0x0400082D RID: 2093
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400082D")]
	private bool isLand;

	// Token: 0x0400082E RID: 2094
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400082E")]
	public float horizontalSpeed = 1.5f;

	// Token: 0x0400082F RID: 2095
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400082F")]
	public float verticalSpeed = 4f;

	// Token: 0x04000830 RID: 2096
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000830")]
	public float gravity = 16f;

	// Token: 0x04000831 RID: 2097
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000831")]
	private Vector2 velocity;

	// Token: 0x04000832 RID: 2098
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000832")]
	private Vector2 startPosition;
}
