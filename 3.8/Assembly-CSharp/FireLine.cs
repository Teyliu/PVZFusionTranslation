using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x20002E3")]
public class FireLine : MonoBehaviour
{
	// Token: 0x06000D40 RID: 3392 RVA: 0x0004CBE4 File Offset: 0x0004ADE4
	[Token(Token = "0x6000D40")]
	[Address(RVA = "0x3E0B80", Offset = "0x3DF180", VA = "0x1803E0B80")]
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

	// Token: 0x06000D41 RID: 3393 RVA: 0x0004CC60 File Offset: 0x0004AE60
	[Token(Token = "0x6000D41")]
	[Address(RVA = "0x3E0CC0", Offset = "0x3DF2C0", VA = "0x1803E0CC0")]
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

	// Token: 0x06000D42 RID: 3394 RVA: 0x0004CCE0 File Offset: 0x0004AEE0
	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x3E0A30", Offset = "0x3DF030", VA = "0x1803E0A30")]
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

	// Token: 0x06000D43 RID: 3395 RVA: 0x0004CD60 File Offset: 0x0004AF60
	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x3E0940", Offset = "0x3DEF40", VA = "0x1803E0940")]
	public void Fade()
	{
		FireLine.<Fading>d__9 <Fading>d__;
		<Fading>d__.<>1__state = (int)((ulong)0L);
		<Fading>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Fading>d__);
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x0004CD88 File Offset: 0x0004AF88
	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x3E09C0", Offset = "0x3DEFC0", VA = "0x1803E09C0")]
	private IEnumerator Fading()
	{
		FireLine.<Fading>d__9 <Fading>d__;
		<Fading>d__.<>1__state = (int)((ulong)0L);
		<Fading>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x0004CDA8 File Offset: 0x0004AFA8
	[Token(Token = "0x6000D45")]
	[Address(RVA = "0x3E0910", Offset = "0x3DEF10", VA = "0x1803E0910")]
	private void Die()
	{
		GameObject gameObject = base.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x0004CDCC File Offset: 0x0004AFCC
	[Token(Token = "0x6000D46")]
	[Address(RVA = "0x3E0F20", Offset = "0x3DF520", VA = "0x1803E0F20")]
	public FireLine()
	{
		List<GameObject> list = new List();
		this.fireArray = list;
		this.speed = 15f;
		this.theFireRow = (int)((ulong)4294967295L);
		this.auto = true;
		base..ctor();
	}

	// Token: 0x04000977 RID: 2423
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000977")]
	private float fadeTime;

	// Token: 0x04000978 RID: 2424
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000978")]
	private readonly List<GameObject> fireArray;

	// Token: 0x04000979 RID: 2425
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000979")]
	private readonly float speed;

	// Token: 0x0400097A RID: 2426
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400097A")]
	public int theFireRow;

	// Token: 0x0400097B RID: 2427
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400097B")]
	public bool auto;
}
