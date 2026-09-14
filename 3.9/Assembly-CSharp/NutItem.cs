using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002DC RID: 732
[Token(Token = "0x20002DC")]
public class NutItem : MonoBehaviour
{
	// Token: 0x06000D1F RID: 3359 RVA: 0x0004B2EC File Offset: 0x000494EC
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x43C6A0", Offset = "0x43ACA0", VA = "0x18043C6A0")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		this.damage = (int)((ulong)100000L);
		SortingGroup component = base.GetComponent<SortingGroup>();
		this.sortingGroup = component;
		Transform transform = this.mask;
		this.speed = 10f;
		transform.gameObject.SetActive(true);
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x0004B348 File Offset: 0x00049548
	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x43CDC0", Offset = "0x43B3C0", VA = "0x18043CDC0")]
	private void Start()
	{
		int num = this.board.columnNum;
		int num2 = 0;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(num);
		Board board = this.board;
		this.x = boxXFromColumn;
		if (board.rowNum != 1)
		{
			int num3 = board.rowNum;
			num3 -= num2;
			num = num3;
			uint num4;
			float boxYFromRow = Lawnf.GetBoxYFromRow(num, (int)num4);
		}
		Mouse instance = Mouse.Instance;
		int rowNum = board.rowNum;
		float landY = instance.GetLandY(boxXFromColumn, rowNum);
		Board board2 = this.board;
		Mouse instance2 = Mouse.Instance;
		int rowNum2 = board2.rowNum;
		float num5 = this.x;
		int num6 = rowNum2 - 1;
		float num7 = instance2.GetLandY(num5, num6) * 0.5f;
		this.y = num7;
		int rowNum3 = this.board.rowNum;
		this.row = rowNum3;
		SortingGroup sortingGroup = this.sortingGroup;
		string text = string.Format("bullet{0}", rowNum3);
		sortingGroup.sortingLayerName = text;
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x0004B434 File Offset: 0x00049634
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x43CF60", Offset = "0x43B560", VA = "0x18043CF60")]
	private void Update()
	{
		Transform transform = base.transform;
		float deltaTime = Time.deltaTime;
		Transform transform2 = this.mask.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x0004B470 File Offset: 0x00049670
	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x43C830", Offset = "0x43AE30", VA = "0x18043C830")]
	private void FixedUpdate()
	{
		Transform transform = this.head;
		Vector3 vector;
		if (this.y > vector.y)
		{
			float num = this.timer;
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.timer = num;
			this.timer = 0.2f;
			this.HitLandEvent();
			return;
		}
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x0004B4C8 File Offset: 0x000496C8
	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x43C8B0", Offset = "0x43AEB0", VA = "0x18043C8B0")]
	private void HitLandEvent()
	{
		int num5;
		do
		{
			int num = 0;
			float num2 = this.count;
			this.count = num2;
			float num3 = this.speed;
			this.speed = num3;
			this.speed = 2f;
			if (num2 > 5f && (this.final ? 1 : 0) == num)
			{
				int num4 = 0;
				NutItem.<FinalExplode>d__19 <FinalExplode>d__;
				<FinalExplode>d__.<>1__state = num4;
				<FinalExplode>d__.<>4__this = this;
				Coroutine coroutine = base.StartCoroutine(<FinalExplode>d__);
				this.final = true;
			}
			num5 = 0;
			Board board = this.board;
			if (num5 < board.rowNum)
			{
				BoardAction boardAction = this.board.boardAction;
				num5++;
				Board board2 = this.board;
			}
			NutItem.<Explode>d__20 <Explode>d__;
			<Explode>d__.<>1__state = num5;
			<Explode>d__.<>4__this = this;
			Coroutine coroutine2 = base.StartCoroutine(<Explode>d__);
			GameObject gameObject = this.shockWave;
			Transform transform = this.mask;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform2 = this.board.transform;
			GameObject gameObject2;
			gameObject2.SetActive(true);
			Transform transform3 = gameObject2.transform;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
			}
		}
		while (num5 != 0);
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x0004B5E4 File Offset: 0x000497E4
	[Token(Token = "0x6000D24")]
	[Address(RVA = "0x43C7C0", Offset = "0x43ADC0", VA = "0x18043C7C0")]
	private IEnumerator FinalExplode()
	{
		NutItem.<FinalExplode>d__19 <FinalExplode>d__;
		<FinalExplode>d__.System.IDisposable.Dispose();
		<FinalExplode>d__.<>1__state = (int)((ulong)0L);
		<FinalExplode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x0004B608 File Offset: 0x00049808
	[Token(Token = "0x6000D25")]
	[Address(RVA = "0x43C750", Offset = "0x43AD50", VA = "0x18043C750")]
	private IEnumerator Explode()
	{
		NutItem.<Explode>d__20 <Explode>d__;
		<Explode>d__.System.IDisposable.Dispose();
		<Explode>d__.<>1__state = (int)((ulong)0L);
		<Explode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x0004B62C File Offset: 0x0004982C
	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x43CD20", Offset = "0x43B320", VA = "0x18043CD20")]
	private IEnumerator Move(Transform transform, Vector3 direciton, float speed)
	{
		NutItem.<Move>d__21 <Move>d__;
		<Move>d__.System.IDisposable.Dispose();
		<Move>d__.<>1__state = (int)((ulong)0L);
		<Move>d__.transform = transform;
		float z = direciton.z;
		<Move>d__.speed = speed;
		<Move>d__.direciton.z = z;
		return null;
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x0004B66C File Offset: 0x0004986C
	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public NutItem()
	{
	}

	// Token: 0x04000944 RID: 2372
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000944")]
	public Transform mask;

	// Token: 0x04000945 RID: 2373
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000945")]
	public Transform head;

	// Token: 0x04000946 RID: 2374
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000946")]
	public Board board;

	// Token: 0x04000947 RID: 2375
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000947")]
	public GameObject shockWave;

	// Token: 0x04000948 RID: 2376
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000948")]
	public SpriteRenderer sprit;

	// Token: 0x04000949 RID: 2377
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000949")]
	public int damage;

	// Token: 0x0400094A RID: 2378
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400094A")]
	private SortingGroup sortingGroup;

	// Token: 0x0400094B RID: 2379
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400094B")]
	private float count;

	// Token: 0x0400094C RID: 2380
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400094C")]
	private float x;

	// Token: 0x0400094D RID: 2381
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400094D")]
	private float y;

	// Token: 0x0400094E RID: 2382
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400094E")]
	private float timer;

	// Token: 0x0400094F RID: 2383
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400094F")]
	private float speed;

	// Token: 0x04000950 RID: 2384
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000950")]
	private int row;

	// Token: 0x04000951 RID: 2385
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000951")]
	private bool final;
}
