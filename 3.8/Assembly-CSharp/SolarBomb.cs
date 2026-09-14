using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D8 RID: 728
[Token(Token = "0x20002D8")]
public class SolarBomb : MonoBehaviour
{
	// Token: 0x06000D13 RID: 3347 RVA: 0x0004B7EC File Offset: 0x000499EC
	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x3F9DA0", Offset = "0x3F83A0", VA = "0x1803F9DA0")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x0004B808 File Offset: 0x00049A08
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x3FA1D0", Offset = "0x3F87D0", VA = "0x1803FA1D0")]
	private void Start()
	{
		this.SetStartPosition();
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x0004B81C File Offset: 0x00049A1C
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x3F9DF0", Offset = "0x3F83F0", VA = "0x1803F9DF0")]
	private void SetStartPosition()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			int columnNum = this.board.columnNum;
			float boxXFromColumn = global::Lawnf.GetBoxXFromColumn(global::UnityEngine.Random.Range(4, columnNum));
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
				bool flag3;
				while (!flag3)
				{
				}
				int i;
				while (i <= num2)
				{
				}
			}
		}
		while (num2 != 0);
		int num4 = 0;
		if (!(num2 != num4))
		{
			int num5 = global::UnityEngine.Random.Range(0, num4);
		}
		Vector3 vector;
		this.row = vector;
		float num6 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		float num7 = global::UnityEngine.Random.Range((float)0, 1f);
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x0004B8DC File Offset: 0x00049ADC
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x3FA230", Offset = "0x3F8830", VA = "0x1803FA230")]
	private void Update()
	{
		Transform transform = base.transform;
		float num = Time.deltaTime * 100f;
		int num2 = 0;
		int num3 = 0;
		transform.Rotate((float)num3, (float)num2, num);
		Transform transform2 = base.transform;
		float num4 = Time.deltaTime * 25f;
		Mouse instance = Mouse.Instance;
		int num5 = this.row;
		float boxYFromRow = instance.GetBoxYFromRow(num5);
		Transform transform3 = base.transform;
		Vector3 vector;
		if (boxYFromRow > vector.y)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			Transform transform4 = base.transform;
			Vector3 vector2;
			float z = vector2.z;
			int mask = LayerMask.GetMask(new string[] { "Zombie" });
			List<Zombie> list = new List();
			int num6 = 0;
			int num7 = 0;
			Collider2D[] array;
			if (num6 < array.Length)
			{
				bool flag;
				bool flag2;
				if (!flag || flag2)
				{
				}
				num7++;
			}
			Func<Zombie, bool> func;
			if (SolarBomb.<>c.<>9__7_1 == 0)
			{
				SolarBomb.<>c.<>9__7_1 = func;
			}
			uint num8;
			Action<Zombie> action;
			global::Core.Lawnf.Bounce<Zombie>(list, (int)num8, action, func);
			uint num9;
			GameAPP.PlaySound((int)num9, 0.5f, 1f);
			ScreenShake.TriggerShake(0.02f);
			Transform transform5 = base.transform;
			Vector3 vector3;
			float z2 = vector3.z;
		}
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x0004BA0C File Offset: 0x00049C0C
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x3FA830", Offset = "0x3F8E30", VA = "0x1803FA830")]
	public SolarBomb()
	{
	}

	// Token: 0x04000942 RID: 2370
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000942")]
	private Board board;

	// Token: 0x04000943 RID: 2371
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000943")]
	public int row;

	// Token: 0x04000944 RID: 2372
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000944")]
	public int dmg = (int)((ulong)300L);

	// Token: 0x04000945 RID: 2373
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000945")]
	public int count;
}
