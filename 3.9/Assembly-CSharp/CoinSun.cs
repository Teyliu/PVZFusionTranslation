using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200020B RID: 523
[Token(Token = "0x200020B")]
public class CoinSun : MonoBehaviour
{
	// Token: 0x060008CE RID: 2254 RVA: 0x0002D2E0 File Offset: 0x0002B4E0
	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x8E5FE0", Offset = "0x8E45E0", VA = "0x1808E5FE0")]
	private void Awake()
	{
		this.SetTarget();
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x0002D2F4 File Offset: 0x0002B4F4
	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x8E6750", Offset = "0x8E4D50", VA = "0x1808E6750")]
	private void SetTarget()
	{
		Board instance = Board.Instance;
		InGameUI instance2 = InGameUI.Instance;
		int num = 0;
		if (!(instance2 != num))
		{
			InGameUI_IZ instance3 = InGameUI_IZ.Instance;
			int num2 = 0;
			if (instance3 != num2)
			{
				Transform sunPos = InGameUI_IZ.Instance.sunPos;
				this.target = sunPos;
			}
			return;
		}
		InGameUI instance4 = InGameUI.Instance;
		Player player = PlayerShootingManager.Instance.player;
		throw new NullReferenceException();
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x0002D35C File Offset: 0x0002B55C
	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x8E68C0", Offset = "0x8E4EC0", VA = "0x1808E68C0")]
	private void Start()
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			this.startPosition.y = (float)num;
			float num3 = global::UnityEngine.Random.Range(-1.5f, 1.5f);
			this.velocity = num3;
			this.velocity.y = 4f;
			int num4 = this.theCoinType;
			bool flag;
			if (flag)
			{
				goto IL_00A2;
			}
			if (num4 > 13)
			{
				if (num4 == 53)
				{
					this.sunPrice = (int)((ulong)35L);
				}
				if (num4 != 54)
				{
					goto IL_0108;
				}
				this.sunPrice = (int)((ulong)20L);
			}
			if (num4 == 0)
			{
				goto IL_00CB;
			}
			if (num4 == 0)
			{
				goto IL_00FE;
			}
			if (num4 == 1)
			{
				goto IL_00EA;
			}
			if (num4 == 13)
			{
				this.sunPrice = (int)((ulong)5L);
				goto IL_00A2;
			}
			IL_0108:
			if (this.realCost != 0)
			{
				int num5 = this.realCost;
				this.sunPrice = num5;
			}
			int num6 = this.theMoveType;
			if (num6 != 0)
			{
				if (num6 == 0 || num6 != 1)
				{
					break;
				}
				int num7 = 0;
				this.theMoveType = num7;
			}
			Transform transform2 = base.transform;
			Mouse instance = Mouse.Instance;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			int num8;
			int num9;
			uint num10;
			List<Plant> rangePlants = Lawnf.GetRangePlants(num8, num9, (int)num10);
			int num11 = 0;
			bool flag2;
			if (flag2)
			{
				while (num2 == 0)
				{
				}
				if (num2 != 0)
				{
				}
				while (this == 0)
				{
				}
			}
			if (num11 == 0)
			{
				break;
			}
			continue;
			IL_00A2:
			int num12 = this.realCost;
			num12 += num12;
			this.realCost = num12;
			if (num4 > 13)
			{
				if (num4 == 53)
				{
					goto IL_00FE;
				}
				if (num4 == 54)
				{
					goto IL_00CB;
				}
				goto IL_0108;
			}
			IL_00D5:
			if (num4 == 0)
			{
				goto IL_00FE;
			}
			if (num4 == 0)
			{
				goto IL_00F4;
			}
			while (num4 == 1)
			{
			}
			if (num4 == 13)
			{
				goto IL_00EA;
			}
			goto IL_0108;
			IL_00CB:
			this.sunPrice = (int)((ulong)25L);
			goto IL_00D5;
			IL_00FE:
			this.sunPrice = (int)((ulong)50L);
			goto IL_0108;
			IL_00F4:
			this.sunPrice = (int)((ulong)75L);
			goto IL_00FE;
			IL_00EA:
			this.sunPrice = (int)((ulong)15L);
			goto IL_00F4;
		}
		bool flag3;
		if (flag3)
		{
			GameObject gameObject;
			global::UnityEngine.Object.Destroy(gameObject);
		}
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x0002D508 File Offset: 0x0002B708
	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x8E6D20", Offset = "0x8E5320", VA = "0x1808E6D20")]
	private void Update()
	{
		this.PositionUpdate();
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x0002D51C File Offset: 0x0002B71C
	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x8E64A0", Offset = "0x8E4AA0", VA = "0x1808E64A0")]
	private void PositionUpdate()
	{
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
			return;
		}
		Transform transform3 = this.target;
		int num = 0;
		if (transform3 == num)
		{
			this.SetTarget();
			this.action = (ulong)0L;
			Transform transform4 = this.target;
			int num2 = 0;
			if (transform4 == num2)
			{
				this.Die();
				return;
			}
		}
		this.MoveToPosition();
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x0002D5D8 File Offset: 0x0002B7D8
	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x8E6050", Offset = "0x8E4650", VA = "0x1808E6050")]
	private void MoveToPosition()
	{
		Transform transform = this.target;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		Transform transform5 = this.target;
		float num = Time.deltaTime * 5f;
		int num2 = 0;
		if (num2 > (int)num || num > 1f)
		{
		}
		Transform transform6 = base.transform;
		Transform transform7 = base.transform;
		float num3 = Time.deltaTime * 3f;
		int num4;
		if (num2 > (int)num3 || num3 > 1f)
		{
			num4 = 0;
		}
		Transform transform8 = base.transform;
		if (this.action != (ulong)0L)
		{
			Action<int> action = this.action;
		}
		Board instance = Board.Instance;
		bool flag = this.save;
		instance.GetSun((float)num4, flag);
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x0002D6AC File Offset: 0x0002B8AC
	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x8E5FF0", Offset = "0x8E45F0", VA = "0x1808E5FF0")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x8E6690", Offset = "0x8E4C90", VA = "0x1808E6690")]
	private void SetCost()
	{
		int num = this.theCoinType;
		bool flag;
		if (!flag)
		{
			if (num > 13)
			{
				if (num == 53)
				{
					this.sunPrice = (int)((ulong)35L);
				}
				if (num != 54)
				{
					goto IL_00A5;
				}
				this.sunPrice = (int)((ulong)20L);
			}
			if (num == 0)
			{
				goto IL_006C;
			}
			if (num == 0)
			{
				goto IL_009B;
			}
			if (num == 1)
			{
				goto IL_0087;
			}
			if (num != 13)
			{
				goto IL_00A5;
			}
			this.sunPrice = (int)((ulong)5L);
		}
		int num2 = this.realCost;
		num2 += num2;
		this.realCost = num2;
		if (num <= 13)
		{
			goto IL_0076;
		}
		if (num == 53)
		{
			goto IL_009B;
		}
		if (num != 54)
		{
			goto IL_00A5;
		}
		IL_006C:
		this.sunPrice = (int)((ulong)25L);
		IL_0076:
		if (num == 0)
		{
			goto IL_009B;
		}
		if (num == 0)
		{
			goto IL_0091;
		}
		while (num == 1)
		{
		}
		if (num != 13)
		{
			goto IL_00A5;
		}
		IL_0087:
		this.sunPrice = (int)((ulong)15L);
		IL_0091:
		this.sunPrice = (int)((ulong)75L);
		IL_009B:
		this.sunPrice = (int)((ulong)50L);
		IL_00A5:
		if (this.realCost != 0)
		{
			int num3 = this.realCost;
			this.sunPrice = num3;
		}
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x0002D790 File Offset: 0x0002B990
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x8E6D90", Offset = "0x8E5390", VA = "0x1808E6D90")]
	public CoinSun()
	{
	}

	// Token: 0x04000451 RID: 1105
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000451")]
	public int theMoveType;

	// Token: 0x04000452 RID: 1106
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000452")]
	public int theCoinType;

	// Token: 0x04000453 RID: 1107
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000453")]
	public int sunPrice;

	// Token: 0x04000454 RID: 1108
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000454")]
	public int realCost;

	// Token: 0x04000455 RID: 1109
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000455")]
	public bool save = true;

	// Token: 0x04000456 RID: 1110
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000456")]
	public int followValue = (int)((ulong)4294967295L);

	// Token: 0x04000457 RID: 1111
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000457")]
	public Action<int> action;

	// Token: 0x04000458 RID: 1112
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000458")]
	public Transform target;

	// Token: 0x04000459 RID: 1113
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000459")]
	private bool isLand;

	// Token: 0x0400045A RID: 1114
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400045A")]
	private Vector2 velocity;

	// Token: 0x0400045B RID: 1115
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400045B")]
	private Vector2 startPosition;
}
