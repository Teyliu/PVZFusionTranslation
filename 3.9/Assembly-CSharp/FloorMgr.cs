using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000227 RID: 551
[Token(Token = "0x2000227")]
public class FloorMgr : MonoBehaviour
{
	// Token: 0x0600097B RID: 2427 RVA: 0x00033524 File Offset: 0x00031724
	[Token(Token = "0x600097B")]
	[Address(RVA = "0x908C10", Offset = "0x907210", VA = "0x180908C10")]
	private void Start()
	{
		Mouse instance = Mouse.Instance;
		int num = this.theFloorRow;
		float boxYFromRow = instance.GetBoxYFromRow(num);
		Transform transform = base.transform;
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00033558 File Offset: 0x00031758
	[Token(Token = "0x600097C")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public FloorMgr()
	{
	}

	// Token: 0x040004DC RID: 1244
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004DC")]
	public int theFloorRow;
}
