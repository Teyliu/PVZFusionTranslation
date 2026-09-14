using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200026B RID: 619
[Token(Token = "0x200026B")]
public class RiverBlock : MonoBehaviour
{
	// Token: 0x06000B21 RID: 2849 RVA: 0x000400B8 File Offset: 0x0003E2B8
	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x8A8870", Offset = "0x8A6E70", VA = "0x1808A8870")]
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

	// Token: 0x06000B22 RID: 2850 RVA: 0x00040150 File Offset: 0x0003E350
	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public RiverBlock()
	{
	}

	// Token: 0x04000739 RID: 1849
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000739")]
	public Vector2Int position;

	// Token: 0x0400073A RID: 1850
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400073A")]
	public Team team;

	// Token: 0x0400073B RID: 1851
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400073B")]
	public List<Corner> targetRows;
}
