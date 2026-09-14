using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000222 RID: 546
[Token(Token = "0x2000222")]
public class FloorMgr : MonoBehaviour
{
	// Token: 0x06000965 RID: 2405 RVA: 0x000336E4 File Offset: 0x000318E4
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x879180", Offset = "0x877780", VA = "0x180879180")]
	private void Start()
	{
		Mouse instance = Mouse.Instance;
		int num = this.theFloorRow;
		float boxYFromRow = instance.GetBoxYFromRow(num);
		Transform transform = base.transform;
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00033718 File Offset: 0x00031918
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public FloorMgr()
	{
	}

	// Token: 0x040004D6 RID: 1238
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004D6")]
	public int theFloorRow;
}
