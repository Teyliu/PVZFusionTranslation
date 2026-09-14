using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200077E RID: 1918
[Token(Token = "0x200077E")]
public class ErrorHandler : MonoBehaviour
{
	// Token: 0x060026FA RID: 9978 RVA: 0x000CC500 File Offset: 0x000CA700
	[Token(Token = "0x60026FA")]
	[Address(RVA = "0x6228B0", Offset = "0x620EB0", VA = "0x1806228B0")]
	private void Awake()
	{
		Application.logMessageReceived += this.HandleLog;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x000CC52C File Offset: 0x000CA72C
	[Token(Token = "0x60026FB")]
	[Address(RVA = "0x622AB0", Offset = "0x6210B0", VA = "0x180622AB0")]
	private void OnDestroy()
	{
		Application.logMessageReceived -= this.HandleLog;
	}

	// Token: 0x060026FC RID: 9980 RVA: 0x000CC54C File Offset: 0x000CA74C
	[Token(Token = "0x60026FC")]
	[Address(RVA = "0x622980", Offset = "0x620F80", VA = "0x180622980")]
	private void HandleLog(string logString, string stackTrace, LogType type)
	{
		if (GameAPP.config.debug && (type == (LogType)(-5) || type == LogType.Assert))
		{
			InGameText instance = InGameText.Instance;
			string text = "错误信息：" + logString + "\n追踪：" + stackTrace;
		}
	}

	// Token: 0x060026FD RID: 9981 RVA: 0x000CC594 File Offset: 0x000CA794
	[Token(Token = "0x60026FD")]
	[Address(RVA = "0x622B40", Offset = "0x621140", VA = "0x180622B40")]
	private void OnUnityError(string errorMessage, string stackTrace, LogType errorType)
	{
		InGameText instance = InGameText.Instance;
		string text = "错误信息：" + errorMessage + "\n追踪：" + stackTrace;
	}

	// Token: 0x060026FE RID: 9982 RVA: 0x000CC5C4 File Offset: 0x000CA7C4
	[Token(Token = "0x60026FE")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ErrorHandler()
	{
	}
}
