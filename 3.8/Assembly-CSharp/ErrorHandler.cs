using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000745 RID: 1861
[Token(Token = "0x2000745")]
public class ErrorHandler : MonoBehaviour
{
	// Token: 0x060025D5 RID: 9685 RVA: 0x000C7604 File Offset: 0x000C5804
	[Token(Token = "0x60025D5")]
	[Address(RVA = "0x5C1D30", Offset = "0x5C0330", VA = "0x1805C1D30")]
	private void Awake()
	{
		Application.logMessageReceived += this.HandleLog;
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x000C7630 File Offset: 0x000C5830
	[Token(Token = "0x60025D6")]
	[Address(RVA = "0x5C1F10", Offset = "0x5C0510", VA = "0x1805C1F10")]
	private void OnDestroy()
	{
		Application.logMessageReceived -= this.HandleLog;
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x000C7650 File Offset: 0x000C5850
	[Token(Token = "0x60025D7")]
	[Address(RVA = "0x5C1E00", Offset = "0x5C0400", VA = "0x1805C1E00")]
	private void HandleLog(string logString, string stackTrace, LogType type)
	{
		if (GameAPP.config.debug && (type == (LogType)(-5) || type == LogType.Assert))
		{
			InGameText instance = InGameText.Instance;
			string text = "错误信息：" + logString + "\n追踪：" + stackTrace;
			int num = 0;
			instance.ShowText(text, 15f, num != 0);
		}
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x000C76A8 File Offset: 0x000C58A8
	[Token(Token = "0x60025D8")]
	[Address(RVA = "0x5C1FA0", Offset = "0x5C05A0", VA = "0x1805C1FA0")]
	private void OnUnityError(string errorMessage, string stackTrace, LogType errorType)
	{
		InGameText instance = InGameText.Instance;
		string text = "错误信息：" + errorMessage + "\n追踪：" + stackTrace;
		int num = 0;
		instance.ShowText(text, 15f, num != 0);
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x000C76E8 File Offset: 0x000C58E8
	[Token(Token = "0x60025D9")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ErrorHandler()
	{
	}
}
