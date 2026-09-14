using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200009A RID: 154
[Token(Token = "0x200009A")]
public class BrickManager : MonoBehaviour
{
	// Token: 0x060002A0 RID: 672 RVA: 0x0000AA3C File Offset: 0x00008C3C
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x404A20", Offset = "0x403020", VA = "0x180404A20")]
	private void Awake()
	{
		BrickManager.Instance = this;
		GameObject gameObject = Resources.Load<GameObject>("Board/Game/BrickGame/Paddle");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = base.transform;
		GameObject gameObject2;
		BallLauncher component = gameObject2.GetComponent<BallLauncher>();
		this.launcher = component;
		if (Board.Instance.sceneType != SceneType.MidMap)
		{
			GameObject gameObject3 = Resources.Load<GameObject>("Board/Game/BrickGame/MapCols");
			Transform transform2 = base.transform;
			GameObject gameObject4 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject3, transform2);
			return;
		}
		GameObject gameObject5 = Resources.Load<GameObject>("Board/Game/BrickGame/MapCols2");
		Transform transform3 = base.transform;
		GameObject gameObject6 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject5, transform3);
		Transform transform4 = this.launcher.transform;
		throw new NullReferenceException();
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0000AADC File Offset: 0x00008CDC
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x404E20", Offset = "0x403420", VA = "0x180404E20")]
	private void Start()
	{
		this.SetGraves();
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0000AAF0 File Offset: 0x00008CF0
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x404E30", Offset = "0x403430", VA = "0x180404E30")]
	private void Update()
	{
		Board board = this.board;
		if (!board.over)
		{
			if (board.theWave == 95)
			{
				board.theWave = (int)((ulong)85L);
			}
			if (this.graveCount == 0)
			{
				float num = this.timer;
				if (this.graveCount == 0)
				{
					int num2 = this.level;
					num2++;
					this.level = num2;
					if (num2 >= this.max)
					{
						Board board2 = this.board;
						int num3 = 0;
						Vector2 vector;
						PrizeMgr prizeMgr = global::Lawnf.SetAward(board2, vector, true, num3 != 0);
						this.board.over = true;
						return;
					}
					InGameText instance = InGameText.Instance;
					int num4 = this.level;
					string text = string.Format("干得好，即将出现第{0}批墓碑！", instance);
				}
				float deltaTime = Time.deltaTime;
				this.timer = deltaTime;
				this.timer = 0f;
				this.SetGraves();
				return;
			}
			this.timer = 0f;
		}
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0000ABD0 File Offset: 0x00008DD0
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x404CE0", Offset = "0x4032E0", VA = "0x180404CE0")]
	private void SetGraves()
	{
		Board board = this.board;
		int num = 0;
		if (5 < board.columnNum)
		{
			Board board2 = this.board;
			if (num < board2.rowNum)
			{
				int num2 = 0;
				GridItem gridItem = GridItem.SetGridItem(5, num, (GridItemType)((uint)7), (GraveType)num2);
				bool flag = "{il2cpp field on 5, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Grave).TypeHandle;
				num++;
			}
		}
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0000AC28 File Offset: 0x00008E28
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x405000", Offset = "0x403600", VA = "0x180405000")]
	public BrickManager()
	{
	}

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	public static BrickManager Instance;

	// Token: 0x040000E9 RID: 233
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E9")]
	public Board board;

	// Token: 0x040000EA RID: 234
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000EA")]
	public int graveCount;

	// Token: 0x040000EB RID: 235
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000EB")]
	public int max = (int)((ulong)4L);

	// Token: 0x040000EC RID: 236
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000EC")]
	public BallLauncher launcher;

	// Token: 0x040000ED RID: 237
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000ED")]
	private float timer;

	// Token: 0x040000EE RID: 238
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000EE")]
	private int level = (int)((ulong)1L);
}
