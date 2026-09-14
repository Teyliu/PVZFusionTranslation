using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E6 RID: 742
[Token(Token = "0x20002E6")]
public class SolarBomb : MonoBehaviour
{
	// Token: 0x06000D56 RID: 3414 RVA: 0x0004C3E0 File Offset: 0x0004A5E0
	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x43D990", Offset = "0x43BF90", VA = "0x18043D990")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0004C3FC File Offset: 0x0004A5FC
	[Token(Token = "0x6000D57")]
	[Address(RVA = "0x43DDC0", Offset = "0x43C3C0", VA = "0x18043DDC0")]
	private void Start()
	{
		this.SetStartPosition();
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x0004C410 File Offset: 0x0004A610
	[Token(Token = "0x6000D58")]
	[Address(RVA = "0x43D9E0", Offset = "0x43BFE0", VA = "0x18043D9E0")]
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
				ulong num4;
				while (num4 == (ulong)0L)
				{
				}
				long num5;
				while (num5 <= (long)num2)
				{
				}
			}
		}
		while (num2 != 0);
		int num6 = 0;
		if (!(num2 != num6))
		{
			int num7 = global::UnityEngine.Random.Range(0, num6);
		}
		Vector3 vector;
		this.row = vector;
		float num8 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		float num9 = global::UnityEngine.Random.Range((float)0, 1f);
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x0004C4D4 File Offset: 0x0004A6D4
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x43DE20", Offset = "0x43C420", VA = "0x18043DE20")]
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
				ulong num8;
				if (!flag || num8 != (ulong)0L)
				{
				}
				num7++;
			}
			Func<Zombie, bool> func;
			if (SolarBomb.<>c.<>9__7_1 == 0)
			{
				func = (Zombie zombie) => !zombie.Alive;
				SolarBomb.<>c.<>9__7_1 = func;
			}
			uint num9;
			Action<Zombie> action;
			global::Core.Lawnf.Bounce<Zombie>(list, (int)num9, action, func);
			uint num10;
			GameAPP.PlaySound((int)num10, 0.5f, 1f);
			ScreenShake.TriggerShake(0.02f);
			Transform transform5 = base.transform;
			Vector3 vector3;
			float z2 = vector3.z;
		}
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x0004C618 File Offset: 0x0004A818
	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x43E430", Offset = "0x43CA30", VA = "0x18043E430")]
	public SolarBomb()
	{
	}

	// Token: 0x0400097F RID: 2431
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400097F")]
	private Board board;

	// Token: 0x04000980 RID: 2432
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000980")]
	public int row;

	// Token: 0x04000981 RID: 2433
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000981")]
	public int dmg = (int)((ulong)300L);

	// Token: 0x04000982 RID: 2434
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000982")]
	public int count;
}
