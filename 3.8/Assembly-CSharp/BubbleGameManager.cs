using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200009D RID: 157
[Token(Token = "0x200009D")]
public class BubbleGameManager : MonoBehaviour
{
	// Token: 0x060002A0 RID: 672 RVA: 0x0000AF44 File Offset: 0x00009144
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x3B9CC0", Offset = "0x3B82C0", VA = "0x1803B9CC0")]
	private void Awake()
	{
		List<GameObject> list = new List(this.allBalls);
		this.restBalls = list;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0000AF74 File Offset: 0x00009174
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x3BAB90", Offset = "0x3B9190", VA = "0x1803BAB90")]
	private void Start()
	{
		if (GameAPP.config.difficulty <= 5)
		{
			this.difficulty = (int)((ulong)10L);
			this.difficulty = (int)((ulong)9L);
			this.difficulty = (int)((ulong)8L);
			this.difficulty = (int)((ulong)7L);
			this.difficulty = (int)((ulong)6L);
			this.difficulty = (int)((ulong)5L);
		}
		int num = this.difficulty;
		TextMeshPro textMeshPro = this.restText;
		this.punishCount = num;
		string text = string.Format("{0}", num);
		textMeshPro.text = text;
		TextMeshPro textMeshPro2 = this.restText;
		if (this.allBalls == (ulong)0L)
		{
			Debug.LogError("Prefabs list is empty!");
			return;
		}
		if (this.maxRow > 0 && this.maxColumn > 0)
		{
			int num2 = 0;
			int num3 = this.maxRow;
			int num4 = num3 - 1;
			if (num2 != 1)
			{
				num3 = num4;
			}
			if (num3 > 0)
			{
				if (num3 < 0)
				{
					num3++;
				}
				if ((this.firstOdd ? 1 : 0) == num2)
				{
				}
				bool flag = num3 == 0;
				this.CreateBubbleAtPosition(num2, num2, flag);
				num2++;
			}
			num2++;
			return;
		}
		Debug.LogError("Invalid grid size!");
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0000B088 File Offset: 0x00009288
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x3B9F40", Offset = "0x3B8540", VA = "0x1803B9F40")]
	public void FailClear()
	{
		List<GameObject> list = this.allBalls;
		int num = this.difficulty;
		this.punishCount = num;
		List<GameObject> list2 = this.restBalls;
		int num2 = list._size;
		num2++;
		this.AddColumn(num2);
		int num3 = this.punishCount;
		TextMeshPro textMeshPro = this.restText;
		string text = string.Format("{0}", num3);
		textMeshPro.text = text;
		CrackStatus crackStatus;
		if (crackStatus != CrackStatus.Good)
		{
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus != CrackStatus.Normal)
				{
					return;
				}
				TextMeshPro textMeshPro2 = this.restText;
			}
			TextMeshPro textMeshPro3 = this.restText;
		}
		TextMeshPro textMeshPro4 = this.restText;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0000B118 File Offset: 0x00009318
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x3BA580", Offset = "0x3B8B80", VA = "0x1803BA580")]
	private void FixedUpdate()
	{
		BubbleGameItem bubbleGameItem = this.destoryBubbles.Dequeue();
		global::UnityEngine.Object.Destroy(bubbleGameItem.gameObject);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = bubbleGameItem.transform;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)65), num, 11, num3 != 0UL, (float)num2);
		Queue<BubbleGameItem> queue = this.destoryBubbles;
		this.UpdateRestType();
		List<BubbleGameItem> list = this.bubbles;
		Board board = this.board;
		if (!board.over)
		{
			board.boardVicotry.Win();
		}
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0000B19C File Offset: 0x0000939C
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x3BAE80", Offset = "0x3B9480", VA = "0x1803BAE80")]
	private void UpdateRestType()
	{
		int num2;
		do
		{
			HashSet<BubbleGameItem.BubbleType> hashSet = new HashSet();
			List<BubbleGameItem> list = this.bubbles;
			int num = 0;
			bool flag;
			if (flag)
			{
			}
			if (num != 0)
			{
				goto IL_0052;
			}
			num2 = 0;
			bool flag2;
			if (flag2)
			{
				BubbleGameItem bubbleGameItem;
				BubbleGameItem.BubbleType bubbleType = bubbleGameItem.bubbleType;
				if (!hashSet.Contains(bubbleType))
				{
					continue;
				}
			}
		}
		while (num2 != 0);
		return;
		IL_0052:
		throw new NullReferenceException();
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0000B214 File Offset: 0x00009414
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x3B9600", Offset = "0x3B7C00", VA = "0x1803B9600")]
	[ProButton]
	public void AddColumn(int count)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			if (num2 >= count)
			{
				return;
			}
			bool flag = !this.firstOdd;
			this.firstOdd = flag;
			List<BubbleGameItem> list = this.bubbles;
			bool flag2;
			if (flag2)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				float z = this.offset.z;
			}
		}
		while (num2 != 0);
		int num4 = 0;
		int num5 = this.maxRow;
		int num6 = num5 - 1;
		if ("{il2cpp field on {'constant31' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x54}" == (ulong)0L)
		{
			num6 = num5;
		}
		if (num4 < num6)
		{
			num4++;
		}
		num2++;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000B2A8 File Offset: 0x000094A8
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x3BA930", Offset = "0x3B8F30", VA = "0x1803BA930")]
	private void InitBalls()
	{
		if (this.allBalls == (ulong)0L)
		{
			Debug.LogError("Prefabs list is empty!");
			return;
		}
		List<GameObject> list = this.allBalls;
		if (this.maxRow > 0 && this.maxColumn > 0)
		{
			int num = 0;
			int num2 = this.maxRow;
			int num3 = num2 - 1;
			if (num != 1)
			{
				num2 = num3;
			}
			if (num2 > 0)
			{
				if (num2 < 0)
				{
					num2++;
				}
				if ((this.firstOdd ? 1 : 0) == num)
				{
				}
				bool flag = num2 == 0;
				this.CreateBubbleAtPosition(num, num, flag);
				num++;
			}
			num++;
			return;
		}
		Debug.LogError("Invalid grid size!");
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0000B334 File Offset: 0x00009534
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x3B9D70", Offset = "0x3B8370", VA = "0x1803B9D70")]
	private void CreateBubbleAtPosition(int column, int row, bool odd)
	{
		if (odd)
		{
		}
		float z = this.offset.z;
		BubbleGameItem bubbleGameItem;
		bubbleGameItem.theRow = row;
		bubbleGameItem.theColumn = column;
		bubbleGameItem.odd = odd;
		GameObject gameObject = bubbleGameItem.gameObject;
		string text = string.Format("Bubble_{0}_{1}", gameObject, gameObject);
		gameObject.name = text;
		List<BubbleGameItem> list = this.bubbles;
		int size = list._size;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x0000B3A4 File Offset: 0x000095A4
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x3BA8B0", Offset = "0x3B8EB0", VA = "0x1803BA8B0")]
	private Vector3 GetPosition(int column, int row, bool offset = true)
	{
		return default(Vector3);
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000B3BC File Offset: 0x000095BC
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x3BA720", Offset = "0x3B8D20", VA = "0x1803BA720")]
	public BubbleGameItem GetBubble(Vector3 spawnPosition)
	{
		int num = this.restBalls._size;
		int num2 = global::UnityEngine.Random.Range(0, num);
		List<GameObject> list = this.restBalls;
		num = num2;
		GameObject gameObject = list[num];
		Board board = this.board;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		float z = spawnPosition.z;
		GameObject gameObject2;
		BubbleGameItem component = gameObject2.GetComponent<BubbleGameItem>();
		component.manager = this;
		return component;
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0000B42C File Offset: 0x0000962C
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x3B98E0", Offset = "0x3B7EE0", VA = "0x1803B98E0")]
	public void AttachToGrid(BubbleGameItem bubble, bool land)
	{
		Transform transform = bubble.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		transform.rotation = identityQuaternion;
		Transform transform2 = bubble.transform;
		float num = this.offset.z;
		Vector3 vector;
		float z = vector.z;
		float num2 = this.bubbleRadius;
		num = z;
		if (land < false)
		{
			num += float.Epsilon;
		}
		bool flag = num == float.Epsilon;
		bubble.odd = flag;
		bool flag2;
		if (this.firstOdd)
		{
			flag2 = num != float.Epsilon;
			bubble.odd = flag2;
		}
		if (bubble.odd)
		{
		}
		Vector2Int vector2Int;
		if (this.IsPositionOccupied((int)z, flag2 ? 1 : 0))
		{
			vector2Int = this.FindEmptyAdjacentPosition(flag2 ? 1 : 0, (int)z);
		}
		Transform transform3 = bubble.transform;
		if (bubble.odd)
		{
		}
		float z2 = this.offset.z;
		bubble.theRow = vector2Int;
		bubble.theColumn = vector2Int;
		if (!this.bubbles.Contains(bubble))
		{
			List<BubbleGameItem> list = this.bubbles;
		}
		GameObject gameObject = bubble.gameObject;
		string text = string.Format("Bubble_{0}_{1}", gameObject, gameObject);
		gameObject.name = text;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(54, 56), 0.3f, 1f);
		if (!bubble.CheckNear())
		{
			this.FailClear();
		}
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0000B56C File Offset: 0x0000976C
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x3BAAB0", Offset = "0x3B90B0", VA = "0x1803BAAB0")]
	private bool IsPositionOccupied(int theColumn, int theRow)
	{
		Predicate<BubbleGameItem> predicate;
		return this.bubbles.Exists(predicate);
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000B5A4 File Offset: 0x000097A4
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x3BA0A0", Offset = "0x3B86A0", VA = "0x1803BA0A0")]
	private Vector2Int FindEmptyAdjacentPosition(int gridX, int gridY)
	{
		int num;
		do
		{
			num = 0;
			Vector2Int[] array = new Vector2Int[6];
			if (gridY == 1)
			{
				array[0] = num;
				ulong num2;
				array[1] = num2;
				ulong num3;
				array[2] = num3;
				array[3] = num;
			}
			ulong num4;
			array[0] = num4;
			ulong num5;
			array[1] = num5;
			array[2] = num;
			ulong num6;
			array[3] = num6;
			ulong num7;
			array[4] = num7;
			ulong num8;
			array[5] = num8;
			Func<Vector2Int, int> func;
			if (BubbleGameManager.<>c.<>9__26_0 == 0)
			{
				BubbleGameManager.<>c.<>9__26_0 = func;
			}
			if (Enumerable.OrderBy<Vector2Int, int>(array, func) != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_009B;
					}
					num++;
				}
				bool flag;
				while (flag)
				{
				}
				IL_009B:
				flag += flag;
			}
			if ("{il2cpp array field local26->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
		Debug.LogError("没有位置");
		throw new NullReferenceException();
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000B68C File Offset: 0x0000988C
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x3BB1D0", Offset = "0x3B97D0", VA = "0x1803BB1D0")]
	public BubbleGameManager()
	{
		List<GameObject> list = new List();
		this.allBalls = list;
		List<GameObject> list2 = new List();
		this.restBalls = list2;
		List<BubbleGameItem> list3 = new List();
		this.bubbles = list3;
		Queue<BubbleGameItem> queue = new Queue();
		this.destoryBubbles = queue;
		int num = 0;
		this.offset.z = (float)num;
		this.bubbleRadius = 0.55f;
		base..ctor();
	}

	// Token: 0x040000FB RID: 251
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000FB")]
	public List<GameObject> allBalls;

	// Token: 0x040000FC RID: 252
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000FC")]
	public List<GameObject> restBalls;

	// Token: 0x040000FD RID: 253
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000FD")]
	public int maxColumn;

	// Token: 0x040000FE RID: 254
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000FE")]
	public int maxRow;

	// Token: 0x040000FF RID: 255
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000FF")]
	public Board board;

	// Token: 0x04000100 RID: 256
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000100")]
	public List<BubbleGameItem> bubbles;

	// Token: 0x04000101 RID: 257
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000101")]
	public Queue<BubbleGameItem> destoryBubbles;

	// Token: 0x04000102 RID: 258
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000102")]
	public readonly float bubbleRadius;

	// Token: 0x04000103 RID: 259
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000103")]
	public bool firstOdd;

	// Token: 0x04000104 RID: 260
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4000104")]
	public bool clearing;

	// Token: 0x04000105 RID: 261
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000105")]
	public int punishCount;

	// Token: 0x04000106 RID: 262
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000106")]
	public int difficulty;

	// Token: 0x04000107 RID: 263
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000107")]
	public TextMeshPro restText;

	// Token: 0x04000108 RID: 264
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000108")]
	private readonly Vector3 offset;
}
