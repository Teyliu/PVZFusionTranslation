using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000229 RID: 553
[Token(Token = "0x2000229")]
public class FogMgr : MonoBehaviour
{
	// Token: 0x06000982 RID: 2434 RVA: 0x00033770 File Offset: 0x00031970
	[Token(Token = "0x6000982")]
	[Address(RVA = "0x9091D0", Offset = "0x9077D0", VA = "0x1809091D0")]
	private void Awake()
	{
		FogMgr.Instance = this;
		GameObject gameObject = base.gameObject;
		this.GetFog(gameObject);
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x00033794 File Offset: 0x00031994
	[Token(Token = "0x6000983")]
	[Address(RVA = "0x9094C0", Offset = "0x907AC0", VA = "0x1809094C0")]
	private void FixedUpdate()
	{
		this.Light();
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x000337A8 File Offset: 0x000319A8
	[Token(Token = "0x6000984")]
	[Address(RVA = "0x909F20", Offset = "0x908520", VA = "0x180909F20")]
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

	// Token: 0x06000985 RID: 2437 RVA: 0x00033844 File Offset: 0x00031A44
	[Token(Token = "0x6000985")]
	[Address(RVA = "0x909A30", Offset = "0x908030", VA = "0x180909A30")]
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

	// Token: 0x06000986 RID: 2438 RVA: 0x000338E0 File Offset: 0x00031AE0
	[Token(Token = "0x6000986")]
	[Address(RVA = "0x909940", Offset = "0x907F40", VA = "0x180909940")]
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

	// Token: 0x06000987 RID: 2439 RVA: 0x00033934 File Offset: 0x00031B34
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x9097B0", Offset = "0x907DB0", VA = "0x1809097B0")]
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

	// Token: 0x06000988 RID: 2440 RVA: 0x00033978 File Offset: 0x00031B78
	[Token(Token = "0x6000988")]
	[Address(RVA = "0x9094D0", Offset = "0x907AD0", VA = "0x1809094D0")]
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

	// Token: 0x06000989 RID: 2441 RVA: 0x000339FC File Offset: 0x00031BFC
	[Token(Token = "0x6000989")]
	[Address(RVA = "0x909120", Offset = "0x907720", VA = "0x180909120")]
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

	// Token: 0x0600098A RID: 2442 RVA: 0x00033A4C File Offset: 0x00031C4C
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x909DD0", Offset = "0x9083D0", VA = "0x180909DD0")]
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

	// Token: 0x0600098B RID: 2443 RVA: 0x00033A9C File Offset: 0x00031C9C
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x909240", Offset = "0x907840", VA = "0x180909240")]
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

	// Token: 0x0600098C RID: 2444 RVA: 0x00033B40 File Offset: 0x00031D40
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x9093E0", Offset = "0x9079E0", VA = "0x1809093E0")]
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

	// Token: 0x0600098D RID: 2445 RVA: 0x00033BC8 File Offset: 0x00031DC8
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x909E80", Offset = "0x908480", VA = "0x180909E80")]
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

	// Token: 0x0600098E RID: 2446 RVA: 0x00033C08 File Offset: 0x00031E08
	[Token(Token = "0x600098E")]
	[Address(RVA = "0x909360", Offset = "0x907960", VA = "0x180909360")]
	private float EaseInOut(float t)
	{
		return t * 4f;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00033C24 File Offset: 0x00031E24
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x90A0B0", Offset = "0x9086B0", VA = "0x18090A0B0")]
	public FogMgr()
	{
		List<FogBlock> list = new List();
		this.fogList = list;
		base..ctor();
	}

	// Token: 0x040004E7 RID: 1255
	[Token(Token = "0x40004E7")]
	public static FogMgr Instance;

	// Token: 0x040004E8 RID: 1256
	[Token(Token = "0x40004E8")]
	private const float appearSpeed = 1f;

	// Token: 0x040004E9 RID: 1257
	[Token(Token = "0x40004E9")]
	private const float moveSpeed = 10f;

	// Token: 0x040004EA RID: 1258
	[Token(Token = "0x40004EA")]
	private const float fadeSpeed = 20f;

	// Token: 0x040004EB RID: 1259
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004EB")]
	private readonly List<FogBlock> fogList;

	// Token: 0x040004EC RID: 1260
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004EC")]
	public float appearTime;

	// Token: 0x040004ED RID: 1261
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004ED")]
	private Coroutine coroutine1;

	// Token: 0x040004EE RID: 1262
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004EE")]
	private Coroutine coroutine2;

	// Token: 0x040004EF RID: 1263
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004EF")]
	private Coroutine coroutine3;
}
