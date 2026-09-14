using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002F1 RID: 753
[Token(Token = "0x20002F1")]
public class FireLine : MonoBehaviour
{
	// Token: 0x06000D83 RID: 3459 RVA: 0x0004D858 File Offset: 0x0004BA58
	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x42F490", Offset = "0x42DA90", VA = "0x18042F490")]
	public void InitFireLine()
	{
		int num = 0;
		this.fadeTime = (float)num;
		if (!base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(true);
		}
		List<GameObject> list = this.fireArray;
		Animator component = this.fireArray[num].GetComponent<Animator>();
		component.Play("idle");
		int num2 = 0;
		component.SetBool("fade", num2 != 0);
		List<GameObject> list2 = this.fireArray;
		num++;
		base.StopAllCoroutines();
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x0004D8D4 File Offset: 0x0004BAD4
	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x42F5D0", Offset = "0x42DBD0", VA = "0x18042F5D0")]
	private void Start()
	{
		int num = 0;
		Transform transform = base.transform;
		int childCount = transform.childCount;
		if (num < childCount)
		{
			Transform transform2 = base.transform;
			GameObject gameObject = transform2.GetChild(num).gameObject;
			int size = this.fireArray._size;
			Board instance = Board.Instance;
			Transform transform3 = gameObject.transform;
			Mouse instance2 = Mouse.Instance;
			Transform transform4 = gameObject.transform;
			num++;
			Transform transform5 = base.transform;
		}
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x0004D954 File Offset: 0x0004BB54
	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x42F340", Offset = "0x42D940", VA = "0x18042F340")]
	private void FixedUpdate()
	{
		if (this.auto)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			float num = this.speed;
			this.fadeTime = fixedDeltaTime;
			if (fixedDeltaTime > num)
			{
				List<GameObject> list = this.fireArray;
				GameObject gameObject;
				gameObject.GetComponent<Animator>().SetBool("fade", true);
			}
			float num2 = this.speed * 4f;
			if (this.fadeTime > num2)
			{
				GameObject gameObject2 = base.gameObject;
				int num3 = 0;
				gameObject2.SetActive(num3 != 0);
				return;
			}
		}
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x0004D9D4 File Offset: 0x0004BBD4
	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x42F250", Offset = "0x42D850", VA = "0x18042F250")]
	public void Fade()
	{
		FireLine.<Fading>d__9 <Fading>d__;
		<Fading>d__.<>1__state = (int)((ulong)0L);
		<Fading>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Fading>d__);
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0004D9FC File Offset: 0x0004BBFC
	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x42F2D0", Offset = "0x42D8D0", VA = "0x18042F2D0")]
	private IEnumerator Fading()
	{
		FireLine.<Fading>d__9 <Fading>d__;
		<Fading>d__.<>1__state = (int)((ulong)0L);
		<Fading>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x0004DA1C File Offset: 0x0004BC1C
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x42F220", Offset = "0x42D820", VA = "0x18042F220")]
	private void Die()
	{
		GameObject gameObject = base.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x0004DA40 File Offset: 0x0004BC40
	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x42F830", Offset = "0x42DE30", VA = "0x18042F830")]
	public FireLine()
	{
		List<GameObject> list = new List();
		this.fireArray = list;
		this.speed = 15f;
		this.theFireRow = (int)((ulong)4294967295L);
		this.auto = true;
		base..ctor();
	}

	// Token: 0x040009B4 RID: 2484
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009B4")]
	private float fadeTime;

	// Token: 0x040009B5 RID: 2485
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009B5")]
	private readonly List<GameObject> fireArray;

	// Token: 0x040009B6 RID: 2486
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009B6")]
	private readonly float speed;

	// Token: 0x040009B7 RID: 2487
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009B7")]
	public int theFireRow;

	// Token: 0x040009B8 RID: 2488
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009B8")]
	public bool auto;
}
