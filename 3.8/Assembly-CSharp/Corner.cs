using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005EC RID: 1516
[Token(Token = "0x20005EC")]
public class Corner : MonoBehaviour
{
	// Token: 0x06001C8A RID: 7306 RVA: 0x000986EC File Offset: 0x000968EC
	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x504650", Offset = "0x502C50", VA = "0x180504650")]
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

	// Token: 0x06001C8B RID: 7307 RVA: 0x0009873C File Offset: 0x0009693C
	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x504650", Offset = "0x502C50", VA = "0x180504650")]
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

	// Token: 0x06001C8C RID: 7308 RVA: 0x0009878C File Offset: 0x0009698C
	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x504AE0", Offset = "0x5030E0", VA = "0x180504AE0")]
	public void SetPosition()
	{
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.theColumn);
		int num = this.road;
		float boxYFromRow = Lawnf.GetBoxYFromRow(this.theRow, num);
		Transform transform = base.transform;
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x000987CC File Offset: 0x000969CC
	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x504770", Offset = "0x502D70", VA = "0x180504770")]
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

	// Token: 0x06001C8E RID: 7310 RVA: 0x00098868 File Offset: 0x00096A68
	[Token(Token = "0x6001C8E")]
	[Address(RVA = "0x504550", Offset = "0x502B50", VA = "0x180504550")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06001C8F RID: 7311 RVA: 0x00098880 File Offset: 0x00096A80
	[Token(Token = "0x6001C8F")]
	[Address(RVA = "0x5045B0", Offset = "0x502BB0", VA = "0x1805045B0")]
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

	// Token: 0x06001C90 RID: 7312 RVA: 0x000988CC File Offset: 0x00096ACC
	[Token(Token = "0x6001C90")]
	[Address(RVA = "0x504630", Offset = "0x502C30", VA = "0x180504630")]
	[ProButton]
	public void MoveRight()
	{
	}

	// Token: 0x06001C91 RID: 7313 RVA: 0x000988DC File Offset: 0x00096ADC
	[Token(Token = "0x6001C91")]
	[Address(RVA = "0x504620", Offset = "0x502C20", VA = "0x180504620")]
	[ProButton]
	public void MoveLeft()
	{
	}

	// Token: 0x06001C92 RID: 7314 RVA: 0x000988EC File Offset: 0x00096AEC
	[Token(Token = "0x6001C92")]
	[Address(RVA = "0x504640", Offset = "0x502C40", VA = "0x180504640")]
	[ProButton]
	public void MoveUp()
	{
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x000988FC File Offset: 0x00096AFC
	[Token(Token = "0x6001C93")]
	[Address(RVA = "0x504610", Offset = "0x502C10", VA = "0x180504610")]
	[ProButton]
	public void MoveDown()
	{
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x0009890C File Offset: 0x00096B0C
	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Corner()
	{
	}

	// Token: 0x04000F45 RID: 3909
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F45")]
	public int theColumn;

	// Token: 0x04000F46 RID: 3910
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000F46")]
	public int theRow;

	// Token: 0x04000F47 RID: 3911
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F47")]
	public Corner next;

	// Token: 0x04000F48 RID: 3912
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F48")]
	public bool jump;

	// Token: 0x04000F49 RID: 3913
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000F49")]
	public bool turn;

	// Token: 0x04000F4A RID: 3914
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000F4A")]
	[Range(5f, 6f)]
	public int road;
}
