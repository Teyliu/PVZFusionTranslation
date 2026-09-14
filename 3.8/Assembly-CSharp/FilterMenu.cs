using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007E4 RID: 2020
[Token(Token = "0x20007E4")]
public class FilterMenu : MonoBehaviour
{
	// Token: 0x06002933 RID: 10547 RVA: 0x000E04BC File Offset: 0x000DE6BC
	[Token(Token = "0x6002933")]
	[Address(RVA = "0x62F840", Offset = "0x62DE40", VA = "0x18062F840")]
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

	// Token: 0x06002934 RID: 10548 RVA: 0x000E0504 File Offset: 0x000DE704
	[Token(Token = "0x6002934")]
	[Address(RVA = "0x62F740", Offset = "0x62DD40", VA = "0x18062F740")]
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

	// Token: 0x06002935 RID: 10549 RVA: 0x000E054C File Offset: 0x000DE74C
	[Token(Token = "0x6002935")]
	[Address(RVA = "0x62F7B0", Offset = "0x62DDB0", VA = "0x18062F7B0")]
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

	// Token: 0x06002936 RID: 10550 RVA: 0x000E0584 File Offset: 0x000DE784
	[Token(Token = "0x6002936")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public FilterMenu()
	{
	}

	// Token: 0x04001772 RID: 6002
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001772")]
	public GameObject rightButton;

	// Token: 0x04001773 RID: 6003
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001773")]
	public GameObject leftButton;

	// Token: 0x04001774 RID: 6004
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001774")]
	public Vector2 leftPosition;

	// Token: 0x04001775 RID: 6005
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001775")]
	public Vector2 rightPostion;
}
