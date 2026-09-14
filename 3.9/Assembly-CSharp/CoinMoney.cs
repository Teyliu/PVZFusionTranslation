using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002BA RID: 698
[Token(Token = "0x20002BA")]
public class CoinMoney : MonoBehaviour
{
	// Token: 0x06000C4C RID: 3148 RVA: 0x00046100 File Offset: 0x00044300
	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x41EC50", Offset = "0x41D250", VA = "0x18041EC50")]
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

	// Token: 0x06000C4D RID: 3149 RVA: 0x00046204 File Offset: 0x00044404
	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x41EEA0", Offset = "0x41D4A0", VA = "0x18041EEA0")]
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

	// Token: 0x06000C4E RID: 3150 RVA: 0x000462A8 File Offset: 0x000444A8
	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x41E750", Offset = "0x41CD50", VA = "0x18041E750")]
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

	// Token: 0x06000C4F RID: 3151 RVA: 0x000463CC File Offset: 0x000445CC
	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x41E6F0", Offset = "0x41CCF0", VA = "0x18041E6F0")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x000463E4 File Offset: 0x000445E4
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x41EFD0", Offset = "0x41D5D0", VA = "0x18041EFD0")]
	public CoinMoney()
	{
	}

	// Token: 0x04000847 RID: 2119
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000847")]
	public int theCoinType;

	// Token: 0x04000848 RID: 2120
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000848")]
	public int theMoveType;

	// Token: 0x04000849 RID: 2121
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000849")]
	public int moneyPrice = (int)((ulong)25L);

	// Token: 0x0400084A RID: 2122
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400084A")]
	private Transform target;

	// Token: 0x0400084B RID: 2123
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400084B")]
	private float moveSpeed = 300f;

	// Token: 0x0400084C RID: 2124
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400084C")]
	private bool isLand;

	// Token: 0x0400084D RID: 2125
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400084D")]
	public float horizontalSpeed = 1.5f;

	// Token: 0x0400084E RID: 2126
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400084E")]
	public float verticalSpeed = 4f;

	// Token: 0x0400084F RID: 2127
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400084F")]
	public float gravity = 16f;

	// Token: 0x04000850 RID: 2128
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000850")]
	private Vector2 velocity;

	// Token: 0x04000851 RID: 2129
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000851")]
	private Vector2 startPosition;
}
