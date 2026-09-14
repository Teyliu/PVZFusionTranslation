using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F5 RID: 245
[Token(Token = "0x20000F5")]
public class MapConfig : MonoBehaviour
{
	// Token: 0x0600049C RID: 1180 RVA: 0x000182C0 File Offset: 0x000164C0
	[Token(Token = "0x600049C")]
	[Address(RVA = "0x5ADCF0", Offset = "0x5AC2F0", VA = "0x1805ADCF0")]
	private void Awake()
	{
		MapConfig.Instance = this;
		int size = this.pathPointList._size;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x000182E8 File Offset: 0x000164E8
	[Token(Token = "0x600049D")]
	[Address(RVA = "0x5ADD80", Offset = "0x5AC380", VA = "0x1805ADD80")]
	public Vector3 GetPosition(float progress)
	{
		throw new NullReferenceException();
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00018308 File Offset: 0x00016508
	[Token(Token = "0x600049E")]
	[Address(RVA = "0x5ADEE0", Offset = "0x5AC4E0", VA = "0x1805ADEE0")]
	public void InitMapConfig()
	{
		int size = this.pathPointList._size;
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x0600049F RID: 1183 RVA: 0x00018328 File Offset: 0x00016528
	// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0001833C File Offset: 0x0001653C
	[Token(Token = "0x17000059")]
	public float EndPoint
	{
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x3B0410", Offset = "0x3AEA10", VA = "0x1803B0410")]
		get;
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x3B0420", Offset = "0x3AEA20", VA = "0x1803B0420")]
		private set;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00018350 File Offset: 0x00016550
	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x5ADF30", Offset = "0x5AC530", VA = "0x1805ADF30")]
	public MapConfig()
	{
		List<Vector3> list = new List();
		this.pathPointList = list;
		this.minDistance = 0.43f;
		base..ctor();
	}

	// Token: 0x040002BE RID: 702
	[Token(Token = "0x40002BE")]
	public static MapConfig Instance;

	// Token: 0x040002BF RID: 703
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002BF")]
	public List<Vector3> pathPointList;

	// Token: 0x040002C0 RID: 704
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002C0")]
	public readonly float minDistance;
}
