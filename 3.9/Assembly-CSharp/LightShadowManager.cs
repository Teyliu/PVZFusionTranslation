using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000C7 RID: 199
[Token(Token = "0x20000C7")]
public class LightShadowManager : MonoBehaviour
{
	// Token: 0x06000396 RID: 918 RVA: 0x00010878 File Offset: 0x0000EA78
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x4F3F20", Offset = "0x4F2520", VA = "0x1804F3F20")]
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

	// Token: 0x06000397 RID: 919 RVA: 0x000108F8 File Offset: 0x0000EAF8
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x4F3E90", Offset = "0x4F2490", VA = "0x1804F3E90")]
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

	// Token: 0x06000398 RID: 920 RVA: 0x00010948 File Offset: 0x0000EB48
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x4F4030", Offset = "0x4F2630", VA = "0x1804F4030")]
	public LightShadowManager()
	{
	}

	// Token: 0x040001E4 RID: 484
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E4")]
	public Board board;

	// Token: 0x040001E5 RID: 485
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E5")]
	private float timer = 30f;
}
