using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200009B RID: 155
[Token(Token = "0x200009B")]
public class PaddleController : MonoBehaviour
{
	// Token: 0x060002A5 RID: 677 RVA: 0x0000AC50 File Offset: 0x00008E50
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x415CE0", Offset = "0x4142E0", VA = "0x180415CE0")]
	private void Start()
	{
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000AC6C File Offset: 0x00008E6C
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x415D30", Offset = "0x414330", VA = "0x180415D30")]
	private void Update()
	{
		if (!this.mouse)
		{
			float axisRaw = Input.GetAxisRaw("Vertical");
			Transform transform = base.transform;
			float num = this.speed;
			float deltaTime = Time.deltaTime;
			float boardMinY = this.board.boardMinY;
			if (boardMinY > deltaTime || deltaTime > 3.5f)
			{
			}
			Transform transform2 = base.transform;
		}
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Vector3 vector;
		float z2 = vector.z;
		float boardMinY2 = this.board.boardMinY;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		if (Input.GetKeyDownInt((KeyCode)((uint)9)))
		{
			bool flag = this.mouse;
			bool flag2 = !flag;
			this.mouse = flag2;
			if (!flag)
			{
				InGameText instance = InGameText.Instance;
				throw new NullReferenceException();
			}
			InGameText instance2 = InGameText.Instance;
		}
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0000AD50 File Offset: 0x00008F50
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x416080", Offset = "0x414680", VA = "0x180416080")]
	public PaddleController()
	{
	}

	// Token: 0x040000EF RID: 239
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000EF")]
	public float speed = 10f;

	// Token: 0x040000F0 RID: 240
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000F0")]
	public float boundaryX = 7f;

	// Token: 0x040000F1 RID: 241
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F1")]
	private bool mouse = true;

	// Token: 0x040000F2 RID: 242
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000F2")]
	private Board board;
}
