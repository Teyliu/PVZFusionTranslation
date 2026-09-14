using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000204 RID: 516
[Token(Token = "0x2000204")]
public class CoinSun : MonoBehaviour
{
	// Token: 0x060008B4 RID: 2228 RVA: 0x0002D2E4 File Offset: 0x0002B4E4
	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x857300", Offset = "0x855900", VA = "0x180857300")]
	private void Awake()
	{
		this.SetTarget();
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x0002D2F8 File Offset: 0x0002B4F8
	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x857A70", Offset = "0x856070", VA = "0x180857A70")]
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

	// Token: 0x060008B6 RID: 2230 RVA: 0x0002D360 File Offset: 0x0002B560
	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x857BE0", Offset = "0x8561E0", VA = "0x180857BE0")]
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

	// Token: 0x060008B7 RID: 2231 RVA: 0x0002D50C File Offset: 0x0002B70C
	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x858040", Offset = "0x856640", VA = "0x180858040")]
	private void Update()
	{
		this.PositionUpdate();
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x0002D520 File Offset: 0x0002B720
	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x8577C0", Offset = "0x855DC0", VA = "0x1808577C0")]
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

	// Token: 0x060008B9 RID: 2233 RVA: 0x0002D5DC File Offset: 0x0002B7DC
	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x857370", Offset = "0x855970", VA = "0x180857370")]
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

	// Token: 0x060008BA RID: 2234 RVA: 0x0002D6B0 File Offset: 0x0002B8B0
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x857310", Offset = "0x855910", VA = "0x180857310")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x0002D6C8 File Offset: 0x0002B8C8
	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x8579B0", Offset = "0x855FB0", VA = "0x1808579B0")]
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

	// Token: 0x060008BC RID: 2236 RVA: 0x0002D794 File Offset: 0x0002B994
	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x8580B0", Offset = "0x8566B0", VA = "0x1808580B0")]
	public CoinSun()
	{
	}

	// Token: 0x04000447 RID: 1095
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000447")]
	public int theMoveType;

	// Token: 0x04000448 RID: 1096
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000448")]
	public int theCoinType;

	// Token: 0x04000449 RID: 1097
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000449")]
	public int sunPrice;

	// Token: 0x0400044A RID: 1098
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400044A")]
	public int realCost;

	// Token: 0x0400044B RID: 1099
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400044B")]
	public bool save = true;

	// Token: 0x0400044C RID: 1100
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400044C")]
	public int followValue = (int)((ulong)4294967295L);

	// Token: 0x0400044D RID: 1101
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400044D")]
	public Action<int> action;

	// Token: 0x0400044E RID: 1102
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400044E")]
	public Transform target;

	// Token: 0x0400044F RID: 1103
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400044F")]
	private bool isLand;

	// Token: 0x04000450 RID: 1104
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000450")]
	private Vector2 velocity;

	// Token: 0x04000451 RID: 1105
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000451")]
	private Vector2 startPosition;
}
