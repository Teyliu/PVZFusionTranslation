using System;
using System.Collections;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class MainThreadUtil : MonoBehaviour
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000D RID: 13 RVA: 0x00002204 File Offset: 0x00000404
	// (set) Token: 0x0600000E RID: 14 RVA: 0x00002218 File Offset: 0x00000418
	[Token(Token = "0x17000005")]
	public static MainThreadUtil Instance
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3FB7A0", Offset = "0x3F9DA0", VA = "0x1803FB7A0")]
		get;
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3FB820", Offset = "0x3F9E20", VA = "0x1803FB820")]
		private set;
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600000F RID: 15 RVA: 0x0000222C File Offset: 0x0000042C
	// (set) Token: 0x06000010 RID: 16 RVA: 0x00002240 File Offset: 0x00000440
	[Token(Token = "0x17000006")]
	public static SynchronizationContext synchronizationContext
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3FB7E0", Offset = "0x3F9DE0", VA = "0x1803FB7E0")]
		get;
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3FB880", Offset = "0x3F9E80", VA = "0x1803FB880")]
		private set;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002254 File Offset: 0x00000454
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3FB680", Offset = "0x3F9C80", VA = "0x1803FB680")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	public static void Setup()
	{
		MainThreadUtil.<Instance>k__BackingField = new GameObject("MainThreadUtil").AddComponent<MainThreadUtil>();
		MainThreadUtil.<synchronizationContext>k__BackingField = SynchronizationContext.Current;
		throw new NullReferenceException();
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002288 File Offset: 0x00000488
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3FB570", Offset = "0x3F9B70", VA = "0x1803FB570")]
	public static void Run(IEnumerator waitForUpdate)
	{
		SynchronizationContext synchronizationContext = MainThreadUtil.<synchronizationContext>k__BackingField;
		SendOrPostCallback sendOrPostCallback = delegate(object _)
		{
			MainThreadUtil mainThreadUtil = MainThreadUtil.<Instance>k__BackingField;
			IEnumerator waitForUpdate2 = waitForUpdate;
			Coroutine coroutine = mainThreadUtil.StartCoroutine(waitForUpdate2);
		};
		throw new NullReferenceException();
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000022BC File Offset: 0x000004BC
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3FB4F0", Offset = "0x3F9AF0", VA = "0x1803FB4F0")]
	private void Awake()
	{
		base.gameObject.hideFlags = (HideFlags)((uint)61);
		global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000022E8 File Offset: 0x000004E8
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public MainThreadUtil()
	{
	}
}
