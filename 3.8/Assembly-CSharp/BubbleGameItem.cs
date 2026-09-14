using System;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000098")]
public class BubbleGameItem : MonoBehaviour
{
	// Token: 0x0600028F RID: 655 RVA: 0x0000AA8C File Offset: 0x00008C8C
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x3B8320", Offset = "0x3B6920", VA = "0x1803B8320")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Collider2D component2 = base.GetComponent<Collider2D>();
		this.col = component2;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0000AAB8 File Offset: 0x00008CB8
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x3B87F0", Offset = "0x3B6DF0", VA = "0x1803B87F0")]
	public void Die()
	{
		bool flag = this.manager.bubbles.Remove(this);
		this.manager.destoryBubbles.Enqueue(this);
		Collider2D collider2D = this.col;
		int num = 0;
		collider2D.enabled = num != 0;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000AB00 File Offset: 0x00008D00
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x3B9440", Offset = "0x3B7A40", VA = "0x1803B9440")]
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

	// Token: 0x06000292 RID: 658 RVA: 0x0000AB80 File Offset: 0x00008D80
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x3B8690", Offset = "0x3B6C90", VA = "0x1803B8690")]
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

	// Token: 0x06000293 RID: 659 RVA: 0x0000ABB8 File Offset: 0x00008DB8
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x3B8CF0", Offset = "0x3B72F0", VA = "0x1803B8CF0")]
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

	// Token: 0x06000294 RID: 660 RVA: 0x0000AC60 File Offset: 0x00008E60
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x3B9070", Offset = "0x3B7670", VA = "0x1803B9070")]
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
		int num4 = 0;
		int num5 = bubble.theColumn;
		int x = num5;
		int num6 = bubble.theRow;
		int y = num6;
		Predicate<BubbleGameItem> predicate;
		BubbleGameItem bubbleGameItem = this.manager.bubbles.Find(predicate);
		int num7 = 0;
		if (bubbleGameItem != num7)
		{
		}
		num4++;
		return list;
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0000AD10 File Offset: 0x00008F10
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x3B9410", Offset = "0x3B7A10", VA = "0x1803B9410")]
	private bool Near(BubbleGameItem a, BubbleGameItem b)
	{
		BubbleGameItem.BubbleType bubbleType = b.bubbleType;
		return a.bubbleType == bubbleType;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0000AD34 File Offset: 0x00008F34
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x3B83A0", Offset = "0x3B69A0", VA = "0x1803B83A0")]
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
			Func<BubbleGameItem, bool> func;
			List<BubbleGameItem> list = Enumerable.ToList<BubbleGameItem>(Enumerable.Where<BubbleGameItem>(this.manager.bubbles, func));
			bool flag;
			if (flag)
			{
				bool flag2 = this.manager.bubbles.Remove(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000297 RID: 663 RVA: 0x0000ADC0 File Offset: 0x00008FC0
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x3B8890", Offset = "0x3B6E90", VA = "0x1803B8890")]
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
				Func<BubbleGameItem, bool> func;
				BubbleGameItem.<>c.<>9__17_0 = func;
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
				goto IL_0088;
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
		IL_0088:
		throw new NullReferenceException();
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0000AE68 File Offset: 0x00009068
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BubbleGameItem()
	{
	}

	// Token: 0x040000E6 RID: 230
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E6")]
	public BubbleGameManager manager;

	// Token: 0x040000E7 RID: 231
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E7")]
	public Collider2D col;

	// Token: 0x040000E8 RID: 232
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000E8")]
	public Rigidbody2D rb;

	// Token: 0x040000E9 RID: 233
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000E9")]
	public BubbleGameItem.BubbleType bubbleType;

	// Token: 0x040000EA RID: 234
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000EA")]
	public int theColumn;

	// Token: 0x040000EB RID: 235
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000EB")]
	public int theRow;

	// Token: 0x040000EC RID: 236
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000EC")]
	public bool odd;

	// Token: 0x040000ED RID: 237
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x40000ED")]
	public bool onShooter;

	// Token: 0x040000EE RID: 238
	[FieldOffset(Offset = "0x46")]
	[Token(Token = "0x40000EE")]
	public bool dying;

	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public enum BubbleType
	{
		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		Default,
		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		Cherry,
		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		Ice,
		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		Machine,
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		Hypno,
		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		Iron
	}
}
