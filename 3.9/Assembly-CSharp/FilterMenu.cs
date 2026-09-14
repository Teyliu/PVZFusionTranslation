using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200081F RID: 2079
[Token(Token = "0x200081F")]
public class FilterMenu : MonoBehaviour
{
	// Token: 0x06002A69 RID: 10857 RVA: 0x000E5634 File Offset: 0x000E3834
	[Token(Token = "0x6002A69")]
	[Address(RVA = "0x6935F0", Offset = "0x691BF0", VA = "0x1806935F0")]
	public void RightShow()
	{
		GameObject gameObject = this.rightButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.leftButton.SetActive(true);
		int num2 = 0;
		base.StopAllCoroutines();
		IEnumerator enumerator = this.Move(num2);
		Coroutine coroutine = base.StartCoroutine(enumerator);
	}

	// Token: 0x06002A6A RID: 10858 RVA: 0x000E567C File Offset: 0x000E387C
	[Token(Token = "0x6002A6A")]
	[Address(RVA = "0x6934F0", Offset = "0x691AF0", VA = "0x1806934F0")]
	public void LeftShow()
	{
		this.rightButton.SetActive(true);
		GameObject gameObject = this.leftButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		int num2 = 0;
		base.StopAllCoroutines();
		IEnumerator enumerator = this.Move(num2);
		Coroutine coroutine = base.StartCoroutine(enumerator);
	}

	// Token: 0x06002A6B RID: 10859 RVA: 0x000E56C4 File Offset: 0x000E38C4
	[Token(Token = "0x6002A6B")]
	[Address(RVA = "0x693560", Offset = "0x691B60", VA = "0x180693560")]
	private IEnumerator Move(Vector2 targetPosition)
	{
		FilterMenu.<Move>d__6 <Move>d__;
		<Move>d__.System.IDisposable.Dispose();
		<Move>d__.<>1__state = (int)((ulong)0L);
		<Move>d__.<>4__this = this;
		<Move>d__.targetPosition = targetPosition;
		<Move>d__.targetPosition.y = (float)0;
		return null;
	}

	// Token: 0x06002A6C RID: 10860 RVA: 0x000E56FC File Offset: 0x000E38FC
	[Token(Token = "0x6002A6C")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public FilterMenu()
	{
	}

	// Token: 0x0400185B RID: 6235
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400185B")]
	public GameObject rightButton;

	// Token: 0x0400185C RID: 6236
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400185C")]
	public GameObject leftButton;

	// Token: 0x0400185D RID: 6237
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400185D")]
	public Vector2 leftPosition;

	// Token: 0x0400185E RID: 6238
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400185E")]
	public Vector2 rightPostion;
}
