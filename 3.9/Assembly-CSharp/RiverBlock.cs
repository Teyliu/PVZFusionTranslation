using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000271 RID: 625
[Token(Token = "0x2000271")]
public class RiverBlock : MonoBehaviour
{
	// Token: 0x06000B3D RID: 2877 RVA: 0x0003FF78 File Offset: 0x0003E178
	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x938890", Offset = "0x936E90", VA = "0x180938890")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		int num;
		if (flag && num == this.position)
		{
			int y = this.position.m_Y;
			Team team = this.team;
			bool flag2;
			ulong num2;
			if (team != (Team)10 && team != (Team)16 && team != (Team)20 && !flag2 && num2 != (ulong)105L && num2 != (ulong)110L && num2 != (ulong)215L)
			{
				List<Corner> list = this.targetRows;
				int num3 = list._size;
				num3 = global::UnityEngine.Random.Range(0, num3);
				Corner corner = list[num3];
				bool flag3;
				if (flag3)
				{
				}
			}
		}
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00040010 File Offset: 0x0003E210
	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public RiverBlock()
	{
	}

	// Token: 0x04000745 RID: 1861
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000745")]
	public Vector2Int position;

	// Token: 0x04000746 RID: 1862
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000746")]
	public Team team;

	// Token: 0x04000747 RID: 1863
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000747")]
	public List<Corner> targetRows;
}
