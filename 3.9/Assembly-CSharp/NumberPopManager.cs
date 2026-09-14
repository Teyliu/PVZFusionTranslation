using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Pool;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20002A9")]
public class NumberPopManager
{
	// Token: 0x06000C02 RID: 3074 RVA: 0x00044284 File Offset: 0x00042484
	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x424C30", Offset = "0x423230", VA = "0x180424C30")]
	public void SetPopUp(Board board, Vector2 position, string text, Color color, NumberPopManager.MoveType moveType = NumberPopManager.MoveType.Default)
	{
		NumberPopManager.NumberPop numberPop = this.pool.Get();
		numberPop.tmp.text = text;
		TextMeshPro tmp = numberPop.tmp;
		float num = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		float num2 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		Transform transform = numberPop.transform;
		this.DefaultUpdate(board, numberPop);
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x000442EC File Offset: 0x000424EC
	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x4249F0", Offset = "0x422FF0", VA = "0x1804249F0")]
	private void DefaultUpdate(Board board, NumberPopManager.NumberPop pop)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0004430C File Offset: 0x0004250C
	[Token(Token = "0x170000DA")]
	public static NumberPopManager Instance
	{
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x424F90", Offset = "0x423590", VA = "0x180424F90")]
		get
		{
			NumberPopManager numberPopManager = new NumberPopManager();
			Func<NumberPopManager.NumberPop> func;
			Action<NumberPopManager.NumberPop> action;
			Action<NumberPopManager.NumberPop> action2;
			Action<NumberPopManager.NumberPop> action3;
			ulong num;
			ulong num2;
			ulong num3;
			ObjectPool<NumberPopManager.NumberPop> objectPool = new ObjectPool(func, action, action2, action3, num != 0UL, (int)num2, (int)num3);
			numberPopManager.pool = objectPool;
			NumberPopManager._instance = numberPopManager;
			return NumberPopManager._instance;
		}
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00044348 File Offset: 0x00042548
	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x424DF0", Offset = "0x4233F0", VA = "0x180424DF0")]
	public NumberPopManager()
	{
		Func<NumberPopManager.NumberPop> func;
		Action<NumberPopManager.NumberPop> action;
		Action<NumberPopManager.NumberPop> action2;
		Action<NumberPopManager.NumberPop> action3;
		ulong num;
		ulong num2;
		ulong num3;
		ObjectPool<NumberPopManager.NumberPop> objectPool = new ObjectPool(func, action, action2, action3, num != 0UL, (int)num2, (int)num3);
		this.pool = objectPool;
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00044374 File Offset: 0x00042574
	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x4249A0", Offset = "0x422FA0", VA = "0x1804249A0")]
	private NumberPopManager.NumberPop CreatePop()
	{
		return new NumberPopManager.NumberPop();
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00044388 File Offset: 0x00042588
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x424B50", Offset = "0x423150", VA = "0x180424B50")]
	private void GetBullet(NumberPopManager.NumberPop pop)
	{
		pop.gameObject.SetActive(true);
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x000443A8 File Offset: 0x000425A8
	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x424B80", Offset = "0x423180", VA = "0x180424B80")]
	private void ReleaseBullet(NumberPopManager.NumberPop pop)
	{
		GameObject gameObject = pop.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		Transform transform = pop.transform;
		pop.tmp.alpha = 1f;
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x000443E4 File Offset: 0x000425E4
	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x424AF0", Offset = "0x4230F0", VA = "0x180424AF0")]
	private void DestoryBullet(NumberPopManager.NumberPop pop)
	{
		global::UnityEngine.Object.Destroy(pop.gameObject);
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00044404 File Offset: 0x00042604
	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x424D90", Offset = "0x423390", VA = "0x180424D90")]
	[CompilerGenerated]
	private void <DefaultUpdate>g__Over|1_0(NumberPopManager.<>c__DisplayClass1_0 cpp2il__autoParamName__idx_0)
	{
		ObjectPool<NumberPopManager.NumberPop> objectPool = this.pool;
		NumberPopManager.NumberPop pop = cpp2il__autoParamName__idx_0.pop;
		objectPool.Release(pop);
	}

	// Token: 0x040007EA RID: 2026
	[Token(Token = "0x40007EA")]
	private static NumberPopManager _instance;

	// Token: 0x040007EB RID: 2027
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007EB")]
	private readonly ObjectPool<NumberPopManager.NumberPop> pool;

	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	public class NumberPop
	{
		// Token: 0x06000C0B RID: 3083 RVA: 0x0004442C File Offset: 0x0004262C
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x4251B0", Offset = "0x4237B0", VA = "0x1804251B0")]
		public NumberPop()
		{
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("fonts/OutLinePrefab"));
			this.gameObject = gameObject;
			TextMeshPro component = this.gameObject.GetComponent<TextMeshPro>();
			this.tmp = component;
			Transform transform = this.gameObject.transform;
			this.transform = transform;
			this.tmp.alignment = (TextAlignmentOptions)((uint)514);
			TextMeshPro textMeshPro = this.tmp;
			int num = SortingLayer.NameToID("up1");
			textMeshPro.sortingLayerID = num;
			this.tmp.sortingOrder = 10000;
			TextMeshPro textMeshPro2 = this.tmp;
			TMP_FontAsset font = GameAPP.font;
			textMeshPro2.font = font;
			this.tmp.fontSize = 1.5f;
		}

		// Token: 0x040007EC RID: 2028
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007EC")]
		public Transform transform;

		// Token: 0x040007ED RID: 2029
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007ED")]
		public GameObject gameObject;

		// Token: 0x040007EE RID: 2030
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007EE")]
		public TextMeshPro tmp;
	}

	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	public enum MoveType
	{
		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		Default
	}
}
