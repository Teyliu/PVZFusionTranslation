using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
public class PaddleController : MonoBehaviour
{
	// Token: 0x0600028A RID: 650 RVA: 0x0000A904 File Offset: 0x00008B04
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x3C8F10", Offset = "0x3C7510", VA = "0x1803C8F10")]
	private void Start()
	{
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x0600028B RID: 651 RVA: 0x0000A920 File Offset: 0x00008B20
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x3C8F60", Offset = "0x3C7560", VA = "0x1803C8F60")]
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
			int num2 = 0;
			instance2.ShowText("键盘控制模式", 3f, num2 != 0);
		}
	}

	// Token: 0x0600028C RID: 652 RVA: 0x0000AA18 File Offset: 0x00008C18
	[Token(Token = "0x600028C")]
	[Address(RVA = "0x3C9290", Offset = "0x3C7890", VA = "0x1803C9290")]
	public PaddleController()
	{
	}

	// Token: 0x040000E2 RID: 226
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E2")]
	public float speed = 10f;

	// Token: 0x040000E3 RID: 227
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000E3")]
	public float boundaryX = 7f;

	// Token: 0x040000E4 RID: 228
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E4")]
	private bool mouse = true;

	// Token: 0x040000E5 RID: 229
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000E5")]
	private Board board;
}
