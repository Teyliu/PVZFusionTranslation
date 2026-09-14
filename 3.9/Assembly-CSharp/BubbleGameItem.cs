using System;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200009D RID: 157
[Token(Token = "0x200009D")]
public class BubbleGameItem : MonoBehaviour
{
	// Token: 0x060002AA RID: 682 RVA: 0x0000ADC4 File Offset: 0x00008FC4
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x4050D0", Offset = "0x4036D0", VA = "0x1804050D0")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Collider2D component2 = base.GetComponent<Collider2D>();
		this.col = component2;
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0000ADF0 File Offset: 0x00008FF0
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x4055A0", Offset = "0x403BA0", VA = "0x1804055A0")]
	public void Die()
	{
		bool flag = this.manager.bubbles.Remove(this);
		this.manager.destoryBubbles.Enqueue(this);
		Collider2D collider2D = this.col;
		int num = 0;
		collider2D.enabled = num != 0;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000AE38 File Offset: 0x00009038
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x4061F0", Offset = "0x4047F0", VA = "0x1804061F0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
		while (this.onShooter)
		{
			GameObject gameObject = collision.gameObject;
			bool flag;
			if (flag)
			{
				this.rb.isKinematic = 2.3509887E-38f != null;
				Rigidbody2D rigidbody2D = this.rb;
				Vector2 vector;
				rigidbody2D.velocity = vector;
				BubbleGameManager bubbleGameManager = this.manager;
				this.onShooter = false;
				int num = 0;
				bubbleGameManager.AttachToGrid(this, num != 0);
				break;
			}
			if (string.Equals(collision.gameObject.name, "endWall"))
			{
				return;
			}
		}
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000AEB8 File Offset: 0x000090B8
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x405440", Offset = "0x403A40", VA = "0x180405440")]
	[ProButton]
	public bool CheckNear()
	{
		ulong num;
		do
		{
			List<BubbleGameItem> list = this.FindConnectedBubbles();
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		return true;
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0000AEF0 File Offset: 0x000090F0
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x405AA0", Offset = "0x4040A0", VA = "0x180405AA0")]
	private List<BubbleGameItem> FindConnectedBubbles()
	{
		List<BubbleGameItem> list;
		ulong num2;
		do
		{
			int num = 0;
			list = new List();
			Queue<BubbleGameItem> queue = new Queue();
			HashSet<BubbleGameItem> hashSet = new HashSet();
			queue.Enqueue(this);
			bool flag = hashSet.Add(this);
			BubbleGameItem bubbleGameItem = queue.Dequeue();
			int size = list._size;
			list._size = bubbleGameItem;
			bubbleGameItem.manager = bubbleGameItem;
			List<BubbleGameItem> neighbors = this.GetNeighbors(bubbleGameItem);
			bool flag2;
			if (flag2)
			{
				if (hashSet.Contains(num))
				{
					continue;
				}
				BubbleGameItem.BubbleType bubbleType = this.bubbleType;
				bool flag3 = hashSet.Add(num);
				queue.Enqueue(num);
			}
		}
		while (num2 != (ulong)0L);
		return list;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0000AF98 File Offset: 0x00009198
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x405E20", Offset = "0x404420", VA = "0x180405E20")]
	private List<BubbleGameItem> GetNeighbors(BubbleGameItem bubble)
	{
		List<BubbleGameItem> list = new List();
		if (bubble.odd)
		{
			Vector2Int[] array = new Vector2Int[6];
			int num = 0;
			array[0] = num;
			array[1] = num;
			ulong num2;
			array[2] = num2;
			ulong num3;
			array[3] = num3;
		}
		Vector2Int[] array2 = new Vector2Int[6];
		int num4 = 0;
		array2[0] = num4;
		array2[1] = num4;
		ulong num5;
		array2[2] = num5;
		ulong num6;
		array2[3] = num6;
		ulong num7;
		array2[4] = num7;
		ulong num8;
		array2[5] = num8;
		if (num4 < array2.Length)
		{
			int num9 = bubble.theColumn;
			int x = num9;
			int num10 = bubble.theRow;
			int y = num10;
			Predicate<BubbleGameItem> predicate;
			BubbleGameItem bubbleGameItem = this.manager.bubbles.Find(predicate);
			int num11 = 0;
			if (bubbleGameItem != num11)
			{
			}
			num4++;
		}
		return list;
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0000B098 File Offset: 0x00009298
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x4061C0", Offset = "0x4047C0", VA = "0x1804061C0")]
	private bool Near(BubbleGameItem a, BubbleGameItem b)
	{
		BubbleGameItem.BubbleType bubbleType = b.bubbleType;
		return a.bubbleType == bubbleType;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0000B0BC File Offset: 0x000092BC
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x405150", Offset = "0x403750", VA = "0x180405150")]
	[ProButton]
	private void CheckFloatingBubbles()
	{
		ulong num2;
		do
		{
			int num = 0;
			HashSet<BubbleGameItem> hashSet = this.FindBubblesConnectedToTop();
			BubbleGameItem.<>c__DisplayClass16_0 CS$<>8__locals1;
			CS$<>8__locals1.connectedToTop = hashSet;
			List<BubbleGameItem> bubbles = this.manager.bubbles;
			Func<BubbleGameItem, bool> func = (BubbleGameItem bubble) => CS$<>8__locals1.connectedToTop.Contains(bubble);
			List<BubbleGameItem> list = Enumerable.ToList<BubbleGameItem>(Enumerable.Where<BubbleGameItem>(bubbles, func));
			bool flag;
			if (flag)
			{
				bool flag2 = this.manager.bubbles.Remove(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x0000B15C File Offset: 0x0000935C
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x405640", Offset = "0x403C40", VA = "0x180405640")]
	private HashSet<BubbleGameItem> FindBubblesConnectedToTop()
	{
		HashSet<BubbleGameItem> hashSet;
		int num3;
		do
		{
			int num = 0;
			hashSet = new HashSet();
			Queue<BubbleGameItem> queue = new Queue();
			if (BubbleGameItem.<>c.<>9__17_0 == 0)
			{
				BubbleGameItem.<>c.<>9__17_0 = (BubbleGameItem b) => b.theColumn == 0;
			}
			IEnumerable<BubbleGameItem> enumerable;
			List<BubbleGameItem> list = Enumerable.ToList<BubbleGameItem>(enumerable);
			int num2 = 0;
			bool flag;
			if (flag)
			{
				queue.Enqueue(num);
				bool flag2 = hashSet.Add(num);
			}
			if (num2 != 0)
			{
				goto IL_0099;
			}
			num3 = 0;
			BubbleGameItem bubbleGameItem = queue.Dequeue();
			bool flag3;
			if (flag3)
			{
				if (hashSet.Contains(num))
				{
					continue;
				}
				bool flag4 = hashSet.Add(num);
				queue.Enqueue(num);
			}
		}
		while (num3 != 0);
		return hashSet;
		IL_0099:
		throw new NullReferenceException();
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x0000B214 File Offset: 0x00009414
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BubbleGameItem()
	{
	}

	// Token: 0x040000F3 RID: 243
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F3")]
	public BubbleGameManager manager;

	// Token: 0x040000F4 RID: 244
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F4")]
	public Collider2D col;

	// Token: 0x040000F5 RID: 245
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000F5")]
	public Rigidbody2D rb;

	// Token: 0x040000F6 RID: 246
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000F6")]
	public BubbleGameItem.BubbleType bubbleType;

	// Token: 0x040000F7 RID: 247
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000F7")]
	public int theColumn;

	// Token: 0x040000F8 RID: 248
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000F8")]
	public int theRow;

	// Token: 0x040000F9 RID: 249
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000F9")]
	public bool odd;

	// Token: 0x040000FA RID: 250
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x40000FA")]
	public bool onShooter;

	// Token: 0x040000FB RID: 251
	[FieldOffset(Offset = "0x46")]
	[Token(Token = "0x40000FB")]
	public bool dying;

	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public enum BubbleType
	{
		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		Default,
		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		Cherry,
		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		Ice,
		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		Machine,
		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		Hypno,
		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		Iron
	}
}
