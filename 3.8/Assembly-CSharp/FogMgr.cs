using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000224 RID: 548
[Token(Token = "0x2000224")]
public class FogMgr : MonoBehaviour
{
	// Token: 0x0600096C RID: 2412 RVA: 0x00033930 File Offset: 0x00031B30
	[Token(Token = "0x600096C")]
	[Address(RVA = "0x879740", Offset = "0x877D40", VA = "0x180879740")]
	private void Awake()
	{
		FogMgr.Instance = this;
		GameObject gameObject = base.gameObject;
		this.GetFog(gameObject);
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00033954 File Offset: 0x00031B54
	[Token(Token = "0x600096D")]
	[Address(RVA = "0x879A30", Offset = "0x878030", VA = "0x180879A30")]
	private void FixedUpdate()
	{
		this.Light();
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00033968 File Offset: 0x00031B68
	[Token(Token = "0x600096E")]
	[Address(RVA = "0x87A490", Offset = "0x878A90", VA = "0x18087A490")]
	private void Update()
	{
		float num = this.appearTime;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.appearTime = num;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
			FogMgr.<MoveObject>d__20 <MoveObject>d__;
			<MoveObject>d__.System.IDisposable.Dispose();
			<MoveObject>d__.<>1__state = (int)((ulong)0L);
			<MoveObject>d__.<>4__this = this;
			<MoveObject>d__.endPos.z = z;
			<MoveObject>d__.speed = 1f;
			Coroutine coroutine = base.StartCoroutine(<MoveObject>d__);
			this.coroutine3 = coroutine;
			this.appearTime = 0f;
		}
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00033A04 File Offset: 0x00031C04
	[Token(Token = "0x600096F")]
	[Address(RVA = "0x879FA0", Offset = "0x8785A0", VA = "0x180879FA0")]
	private void Light()
	{
		int num2;
		do
		{
			int num = 0;
			List<FogBlock> list = this.fogList;
			num2 = 0;
			bool flag;
			if (flag)
			{
				List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
				bool flag2;
				if (flag2)
				{
					int num3 = 0;
					bool flag3;
					bool flag4;
					if (!(num != num3) || num == 0 || (!flag3 && (!flag4 || !this.InLanternRange(num, num))) || this.InTorchRange(num, num))
					{
					}
				}
				if (num2 != 0)
				{
					goto IL_0074;
				}
			}
		}
		while (num2 != 0);
		return;
		IL_0074:
		throw new NullReferenceException();
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00033AA0 File Offset: 0x00031CA0
	[Token(Token = "0x6000970")]
	[Address(RVA = "0x879EB0", Offset = "0x8784B0", VA = "0x180879EB0")]
	private bool InTorchRange(Plant p, FogBlock fog)
	{
		int fogRow = fog.fogRow;
		int fogColumn = fog.fogColumn;
		int num = p.thePlantColumn;
		if (p.thePlantRow != fogRow)
		{
			if (num == fogColumn)
			{
				int num2 = p.thePlantRow;
				num2 -= fogRow;
				if (num2 > 1)
				{
				}
			}
		}
		num -= fogColumn;
		return num <= 1;
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00033AF4 File Offset: 0x00031CF4
	[Token(Token = "0x6000971")]
	[Address(RVA = "0x879D20", Offset = "0x878320", VA = "0x180879D20")]
	private bool InLanternRange(Plant p, FogBlock fog)
	{
		int thePlantRow = p.thePlantRow;
		int num = p.thePlantColumn;
		int fogColumn = fog.fogColumn;
		num -= fogColumn;
		if (thePlantRow <= 1 || p.thePlantRow > 2)
		{
		}
		return num <= 3;
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00033B38 File Offset: 0x00031D38
	[Token(Token = "0x6000972")]
	[Address(RVA = "0x879A40", Offset = "0x878040", VA = "0x180879A40")]
	private void GetFog(GameObject obj)
	{
		int num;
		do
		{
			num = 0;
			if (obj.TryGetComponent<FogBlock>(num))
			{
				break;
			}
			IEnumerator enumerator = obj.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				GameObject gameObject;
				this.GetFog(gameObject);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		List<FogBlock> list = this.fogList;
		int size = list._size;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00033BBC File Offset: 0x00031DBC
	[Token(Token = "0x6000973")]
	[Address(RVA = "0x879690", Offset = "0x877C90", VA = "0x180879690")]
	public void AppearFog(Vector3 pos)
	{
		FogMgr.<MoveObject>d__20 <MoveObject>d__;
		<MoveObject>d__.System.IDisposable.Dispose();
		<MoveObject>d__.<>1__state = (int)((ulong)0L);
		<MoveObject>d__.<>4__this = this;
		float z = pos.z;
		<MoveObject>d__.endPos.z = z;
		<MoveObject>d__.speed = 1f;
		Coroutine coroutine = base.StartCoroutine(<MoveObject>d__);
		this.coroutine3 = coroutine;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00033C0C File Offset: 0x00031E0C
	[Token(Token = "0x6000974")]
	[Address(RVA = "0x87A340", Offset = "0x878940", VA = "0x18087A340")]
	public void MoveFog(Vector3 pos)
	{
		FogMgr.<MoveObject>d__20 <MoveObject>d__;
		<MoveObject>d__.System.IDisposable.Dispose();
		<MoveObject>d__.<>1__state = (int)((ulong)0L);
		<MoveObject>d__.<>4__this = this;
		float z = pos.z;
		<MoveObject>d__.endPos.z = z;
		<MoveObject>d__.speed = 10f;
		Coroutine coroutine = base.StartCoroutine(<MoveObject>d__);
		this.coroutine1 = coroutine;
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00033C5C File Offset: 0x00031E5C
	[Token(Token = "0x6000975")]
	[Address(RVA = "0x8797B0", Offset = "0x877DB0", VA = "0x1808797B0")]
	public void Blown()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		FogMgr.<MoveObject>d__20 <MoveObject>d__;
		<MoveObject>d__.System.IDisposable.Dispose();
		<MoveObject>d__.<>1__state = (int)((ulong)0L);
		<MoveObject>d__.<>4__this = this;
		<MoveObject>d__.endPos.z = z;
		<MoveObject>d__.speed = 20f;
		Coroutine coroutine = base.StartCoroutine(<MoveObject>d__);
		this.coroutine2 = coroutine;
		if (this.coroutine3 != (ulong)0L)
		{
			Coroutine coroutine2 = this.coroutine3;
			base.StopCoroutine(coroutine2);
		}
		if (this.coroutine1 != (ulong)0L)
		{
			Coroutine coroutine3 = this.coroutine1;
			base.StopCoroutine(coroutine3);
		}
		this.appearTime = 30f;
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00033D00 File Offset: 0x00031F00
	[Token(Token = "0x6000976")]
	[Address(RVA = "0x879950", Offset = "0x877F50", VA = "0x180879950")]
	public void FadeFog(Vector3 pos)
	{
		FogMgr.<MoveObject>d__20 <MoveObject>d__;
		<MoveObject>d__.System.IDisposable.Dispose();
		<MoveObject>d__.<>1__state = (int)((ulong)0L);
		<MoveObject>d__.<>4__this = this;
		float z = pos.z;
		<MoveObject>d__.endPos.z = z;
		<MoveObject>d__.speed = 20f;
		Coroutine coroutine = base.StartCoroutine(<MoveObject>d__);
		this.coroutine2 = coroutine;
		if (this.coroutine3 != (ulong)0L)
		{
			Coroutine coroutine2 = this.coroutine3;
			base.StopCoroutine(coroutine2);
		}
		if (this.coroutine1 != (ulong)0L)
		{
			Coroutine coroutine3 = this.coroutine1;
			base.StopCoroutine(coroutine3);
		}
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00033D88 File Offset: 0x00031F88
	[Token(Token = "0x6000977")]
	[Address(RVA = "0x87A3F0", Offset = "0x8789F0", VA = "0x18087A3F0")]
	private IEnumerator MoveObject(Vector3 endPos, float speed)
	{
		FogMgr.<MoveObject>d__20 <MoveObject>d__;
		<MoveObject>d__.System.IDisposable.Dispose();
		<MoveObject>d__.<>1__state = (int)((ulong)0L);
		<MoveObject>d__.<>4__this = this;
		float z = endPos.z;
		<MoveObject>d__.speed = speed;
		<MoveObject>d__.endPos.z = z;
		return null;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00033DC8 File Offset: 0x00031FC8
	[Token(Token = "0x6000978")]
	[Address(RVA = "0x8798D0", Offset = "0x877ED0", VA = "0x1808798D0")]
	private float EaseInOut(float t)
	{
		return t * 4f;
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00033DE4 File Offset: 0x00031FE4
	[Token(Token = "0x6000979")]
	[Address(RVA = "0x87A620", Offset = "0x878C20", VA = "0x18087A620")]
	public FogMgr()
	{
		List<FogBlock> list = new List();
		this.fogList = list;
		base..ctor();
	}

	// Token: 0x040004E1 RID: 1249
	[Token(Token = "0x40004E1")]
	public static FogMgr Instance;

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40004E2")]
	private const float appearSpeed = 1f;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40004E3")]
	private const float moveSpeed = 10f;

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40004E4")]
	private const float fadeSpeed = 20f;

	// Token: 0x040004E5 RID: 1253
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004E5")]
	private readonly List<FogBlock> fogList;

	// Token: 0x040004E6 RID: 1254
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004E6")]
	public float appearTime;

	// Token: 0x040004E7 RID: 1255
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004E7")]
	private Coroutine coroutine1;

	// Token: 0x040004E8 RID: 1256
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004E8")]
	private Coroutine coroutine2;

	// Token: 0x040004E9 RID: 1257
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004E9")]
	private Coroutine coroutine3;
}
