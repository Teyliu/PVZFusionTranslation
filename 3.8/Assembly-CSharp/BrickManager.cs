using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000095 RID: 149
[Token(Token = "0x2000095")]
public class BrickManager : MonoBehaviour
{
	// Token: 0x06000285 RID: 645 RVA: 0x0000A6DC File Offset: 0x000088DC
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x3B7C80", Offset = "0x3B6280", VA = "0x1803B7C80")]
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

	// Token: 0x06000286 RID: 646 RVA: 0x0000A77C File Offset: 0x0000897C
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x3B8080", Offset = "0x3B6680", VA = "0x1803B8080")]
	private void Start()
	{
		this.SetGraves();
	}

	// Token: 0x06000287 RID: 647 RVA: 0x0000A790 File Offset: 0x00008990
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x3B8090", Offset = "0x3B6690", VA = "0x1803B8090")]
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
					int num5 = 0;
					instance.ShowText(text, 3f, num5 != 0);
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

	// Token: 0x06000288 RID: 648 RVA: 0x0000A884 File Offset: 0x00008A84
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x3B7F40", Offset = "0x3B6540", VA = "0x1803B7F40")]
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

	// Token: 0x06000289 RID: 649 RVA: 0x0000A8DC File Offset: 0x00008ADC
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x3B8250", Offset = "0x3B6850", VA = "0x1803B8250")]
	public BrickManager()
	{
	}

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	public static BrickManager Instance;

	// Token: 0x040000DC RID: 220
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DC")]
	public Board board;

	// Token: 0x040000DD RID: 221
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000DD")]
	public int graveCount;

	// Token: 0x040000DE RID: 222
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000DE")]
	public int max = (int)((ulong)4L);

	// Token: 0x040000DF RID: 223
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000DF")]
	public BallLauncher launcher;

	// Token: 0x040000E0 RID: 224
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000E0")]
	private float timer;

	// Token: 0x040000E1 RID: 225
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000E1")]
	private int level = (int)((ulong)1L);
}
