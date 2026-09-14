using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000621 RID: 1569
[Token(Token = "0x2000621")]
public class Corner : MonoBehaviour
{
	// Token: 0x06001D89 RID: 7561 RVA: 0x0009D23C File Offset: 0x0009B43C
	[Token(Token = "0x6001D89")]
	[Address(RVA = "0x56F880", Offset = "0x56DE80", VA = "0x18056F880")]
	private void OnDrawGizmos()
	{
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.theColumn);
		int num = this.road;
		float boxYFromRow = Lawnf.GetBoxYFromRow(this.theRow, num);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x0009D28C File Offset: 0x0009B48C
	[Token(Token = "0x6001D8A")]
	[Address(RVA = "0x56F880", Offset = "0x56DE80", VA = "0x18056F880")]
	private void SetPositionOnGizmozs()
	{
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.theColumn);
		int num = this.road;
		float boxYFromRow = Lawnf.GetBoxYFromRow(this.theRow, num);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x0009D2DC File Offset: 0x0009B4DC
	[Token(Token = "0x6001D8B")]
	[Address(RVA = "0x56FD10", Offset = "0x56E310", VA = "0x18056FD10")]
	public void SetPosition()
	{
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.theColumn);
		int num = this.road;
		float boxYFromRow = Lawnf.GetBoxYFromRow(this.theRow, num);
		Transform transform = base.transform;
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x0009D31C File Offset: 0x0009B51C
	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x56F9A0", Offset = "0x56DFA0", VA = "0x18056F9A0")]
	public void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		bool flag;
		if (flag)
		{
			Corner corner = this.next;
			int num2 = 0;
			if (corner != num2)
			{
				int num3 = this.theRow;
				int num4 = 0;
				if (corner == num4)
				{
					Transform transform = base.transform;
					int num5 = 0;
					float timeScale = Time.timeScale;
					if ((this.jump ? 1 : 0) == num || num5 == 0 || num5 != 0)
					{
					}
					Corner corner2 = this.next;
					if ((this.turn ? 1 : 0) != num)
					{
						Transform transform2 = collision.transform;
						throw new NullReferenceException();
					}
					int num6 = 0;
					Quaternion quaternion = Quaternion.Internal_FromEulerRad(num5);
					Transform transform3;
					transform3.rotation = num6;
				}
			}
		}
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x0009D3B8 File Offset: 0x0009B5B8
	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0x56F780", Offset = "0x56DD80", VA = "0x18056F780")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x0009D3D0 File Offset: 0x0009B5D0
	[Token(Token = "0x6001D8E")]
	[Address(RVA = "0x56F7E0", Offset = "0x56DDE0", VA = "0x18056F7E0")]
	public static Towards GetDirection(Corner from, Corner to)
	{
		int num = to.theColumn;
		int num2 = from.theRow;
		int num3 = to.theRow;
		if (from.theColumn != num)
		{
			if (num2 != num3)
			{
			}
			bool flag = from.theColumn < num;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x0009D41C File Offset: 0x0009B61C
	[Token(Token = "0x6001D8F")]
	[Address(RVA = "0x56F860", Offset = "0x56DE60", VA = "0x18056F860")]
	[ProButton]
	public void MoveRight()
	{
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x0009D42C File Offset: 0x0009B62C
	[Token(Token = "0x6001D90")]
	[Address(RVA = "0x56F850", Offset = "0x56DE50", VA = "0x18056F850")]
	[ProButton]
	public void MoveLeft()
	{
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x0009D43C File Offset: 0x0009B63C
	[Token(Token = "0x6001D91")]
	[Address(RVA = "0x56F870", Offset = "0x56DE70", VA = "0x18056F870")]
	[ProButton]
	public void MoveUp()
	{
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x0009D44C File Offset: 0x0009B64C
	[Token(Token = "0x6001D92")]
	[Address(RVA = "0x56F840", Offset = "0x56DE40", VA = "0x18056F840")]
	[ProButton]
	public void MoveDown()
	{
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x0009D45C File Offset: 0x0009B65C
	[Token(Token = "0x6001D93")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Corner()
	{
	}

	// Token: 0x0400100D RID: 4109
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100D")]
	public int theColumn;

	// Token: 0x0400100E RID: 4110
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400100E")]
	public int theRow;

	// Token: 0x0400100F RID: 4111
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400100F")]
	public Corner next;

	// Token: 0x04001010 RID: 4112
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001010")]
	public bool jump;

	// Token: 0x04001011 RID: 4113
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001011")]
	public bool turn;

	// Token: 0x04001012 RID: 4114
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001012")]
	[Range(5f, 6f)]
	public int road;
}
