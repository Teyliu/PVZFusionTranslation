using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000C2 RID: 194
[Token(Token = "0x20000C2")]
public class LightShadowManager : MonoBehaviour
{
	// Token: 0x0600037B RID: 891 RVA: 0x00010534 File Offset: 0x0000E734
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x4B4860", Offset = "0x4B2E60", VA = "0x1804B4860")]
	private void Update()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		this.timer = num;
		Board board = this.board;
		this.timer = 30f;
		SceneType sceneType = board.sceneType;
		if (sceneType != SceneType.Day)
		{
			if (sceneType != SceneType.Day)
			{
				if (sceneType != SceneType.Day && sceneType != SceneType.Night)
				{
					return;
				}
				Board board2 = this.board;
			}
			Board board3 = this.board;
		}
		Board board4 = this.board;
		IEnumerator enumerator;
		Coroutine coroutine = base.StartCoroutine(enumerator);
	}

	// Token: 0x0600037C RID: 892 RVA: 0x000105B4 File Offset: 0x0000E7B4
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x4B47D0", Offset = "0x4B2DD0", VA = "0x1804B47D0")]
	private void SwitchWorld()
	{
		SceneType sceneType = this.board.sceneType;
		if (sceneType != SceneType.Day)
		{
			if (sceneType != SceneType.Day)
			{
				if (sceneType != SceneType.Day && sceneType != SceneType.Night)
				{
					return;
				}
				Board board = this.board;
			}
			Board board2 = this.board;
		}
		Board board3 = this.board;
		IEnumerator enumerator;
		Coroutine coroutine = base.StartCoroutine(enumerator);
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00010604 File Offset: 0x0000E804
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x4B4970", Offset = "0x4B2F70", VA = "0x1804B4970")]
	public LightShadowManager()
	{
	}

	// Token: 0x040001D7 RID: 471
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D7")]
	public Board board;

	// Token: 0x040001D8 RID: 472
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D8")]
	private float timer = 30f;
}
