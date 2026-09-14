using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002CE RID: 718
[Token(Token = "0x20002CE")]
public class NutItem : MonoBehaviour
{
	// Token: 0x06000CDC RID: 3292 RVA: 0x0004A724 File Offset: 0x00048924
	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x3EBB70", Offset = "0x3EA170", VA = "0x1803EBB70")]
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

	// Token: 0x06000CDD RID: 3293 RVA: 0x0004A780 File Offset: 0x00048980
	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0x3EC290", Offset = "0x3EA890", VA = "0x1803EC290")]
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

	// Token: 0x06000CDE RID: 3294 RVA: 0x0004A86C File Offset: 0x00048A6C
	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x3EC430", Offset = "0x3EAA30", VA = "0x1803EC430")]
	private void Update()
	{
		Transform transform = base.transform;
		float deltaTime = Time.deltaTime;
		Transform transform2 = this.mask.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x0004A8A8 File Offset: 0x00048AA8
	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x3EBD00", Offset = "0x3EA300", VA = "0x1803EBD00")]
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

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0004A900 File Offset: 0x00048B00
	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x3EBD80", Offset = "0x3EA380", VA = "0x1803EBD80")]
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

	// Token: 0x06000CE1 RID: 3297 RVA: 0x0004AA1C File Offset: 0x00048C1C
	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x3EBC90", Offset = "0x3EA290", VA = "0x1803EBC90")]
	private IEnumerator FinalExplode()
	{
		NutItem.<FinalExplode>d__19 <FinalExplode>d__;
		<FinalExplode>d__.System.IDisposable.Dispose();
		<FinalExplode>d__.<>1__state = (int)((ulong)0L);
		<FinalExplode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x0004AA40 File Offset: 0x00048C40
	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x3EBC20", Offset = "0x3EA220", VA = "0x1803EBC20")]
	private IEnumerator Explode()
	{
		NutItem.<Explode>d__20 <Explode>d__;
		<Explode>d__.System.IDisposable.Dispose();
		<Explode>d__.<>1__state = (int)((ulong)0L);
		<Explode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x0004AA64 File Offset: 0x00048C64
	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x3EC1F0", Offset = "0x3EA7F0", VA = "0x1803EC1F0")]
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

	// Token: 0x06000CE4 RID: 3300 RVA: 0x0004AAA4 File Offset: 0x00048CA4
	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public NutItem()
	{
	}

	// Token: 0x04000907 RID: 2311
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000907")]
	public Transform mask;

	// Token: 0x04000908 RID: 2312
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000908")]
	public Transform head;

	// Token: 0x04000909 RID: 2313
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000909")]
	public Board board;

	// Token: 0x0400090A RID: 2314
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400090A")]
	public GameObject shockWave;

	// Token: 0x0400090B RID: 2315
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400090B")]
	public SpriteRenderer sprit;

	// Token: 0x0400090C RID: 2316
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400090C")]
	public int damage;

	// Token: 0x0400090D RID: 2317
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400090D")]
	private SortingGroup sortingGroup;

	// Token: 0x0400090E RID: 2318
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400090E")]
	private float count;

	// Token: 0x0400090F RID: 2319
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400090F")]
	private float x;

	// Token: 0x04000910 RID: 2320
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000910")]
	private float y;

	// Token: 0x04000911 RID: 2321
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000911")]
	private float timer;

	// Token: 0x04000912 RID: 2322
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000912")]
	private float speed;

	// Token: 0x04000913 RID: 2323
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000913")]
	private int row;

	// Token: 0x04000914 RID: 2324
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000914")]
	private bool final;
}
