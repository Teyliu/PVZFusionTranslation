using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000FA RID: 250
[Token(Token = "0x20000FA")]
public class MapConfig : MonoBehaviour
{
	// Token: 0x060004B7 RID: 1207 RVA: 0x000186C4 File Offset: 0x000168C4
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x5E3780", Offset = "0x5E1D80", VA = "0x1805E3780")]
	private void Awake()
	{
		MapConfig.Instance = this;
		int size = this.pathPointList._size;
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x000186EC File Offset: 0x000168EC
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x5E3810", Offset = "0x5E1E10", VA = "0x1805E3810")]
	public Vector3 GetPosition(float progress)
	{
		throw new NullReferenceException();
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x0001870C File Offset: 0x0001690C
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x5E3970", Offset = "0x5E1F70", VA = "0x1805E3970")]
	public void InitMapConfig()
	{
		int size = this.pathPointList._size;
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x060004BA RID: 1210 RVA: 0x0001872C File Offset: 0x0001692C
	// (set) Token: 0x060004BB RID: 1211 RVA: 0x00018740 File Offset: 0x00016940
	[Token(Token = "0x17000096")]
	public float EndPoint
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x3FC6D0", Offset = "0x3FACD0", VA = "0x1803FC6D0")]
		get;
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x3FC6E0", Offset = "0x3FACE0", VA = "0x1803FC6E0")]
		private set;
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00018754 File Offset: 0x00016954
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x5E39C0", Offset = "0x5E1FC0", VA = "0x1805E39C0")]
	public MapConfig()
	{
		List<Vector3> list = new List();
		this.pathPointList = list;
		this.minDistance = 0.43f;
		base..ctor();
	}

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x40002CC")]
	public static MapConfig Instance;

	// Token: 0x040002CD RID: 717
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002CD")]
	public List<Vector3> pathPointList;

	// Token: 0x040002CE RID: 718
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002CE")]
	public readonly float minDistance;
}
