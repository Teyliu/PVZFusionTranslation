using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200078D RID: 1933
[Token(Token = "0x200078D")]
public class CamaraFollowMouse : MonoBehaviour
{
	// Token: 0x06002713 RID: 10003 RVA: 0x000D114C File Offset: 0x000CF34C
	[Token(Token = "0x6002713")]
	[Address(RVA = "0x601D90", Offset = "0x600390", VA = "0x180601D90")]
	private void Awake()
	{
		CamaraFollowMouse.Instance = this;
		Camera main = Camera.main;
		this.Camera = main;
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x000D1170 File Offset: 0x000CF370
	[Token(Token = "0x6002714")]
	[Address(RVA = "0x601ED0", Offset = "0x6004D0", VA = "0x180601ED0")]
	private void Update()
	{
		Board instance = Board.Instance;
		int num = 0;
		if (instance != num)
		{
			Board instance2 = Board.Instance;
			GameObject theItemOnMouse = Mouse.Instance.theItemOnMouse;
			int num2 = 0;
			if (theItemOnMouse == num2)
			{
				if (Input.GetMouseButtonDown(1))
				{
					this.isFollowing = true;
					Camera main = Camera.main;
					float z = Input.mousePosition.z;
					this.lastMousePosition.z = 0f;
				}
				bool mouseButtonUp = Input.GetMouseButtonUp(1);
				if (mouseButtonUp)
				{
					this.isFollowing = false;
				}
				float axis = Input.GetAxis("Mouse ScrollWheel");
				if (mouseButtonUp && Camera.main.orthographic)
				{
					Camera main2 = Camera.main;
					float orthographicSize = Camera.main.orthographicSize;
					if (GameAPP.config.cameraSize > orthographicSize || orthographicSize > 12.5f)
					{
					}
					main2.orthographicSize = 12.5f;
					this.AdjustCameraPosition();
				}
				if (this.isFollowing)
				{
					Camera main3 = Camera.main;
					float z2 = Input.mousePosition.z;
					float deltaTime = Time.deltaTime;
					Transform transform = base.transform;
					int num3 = 0;
					base.transform.position = num3;
					this.AdjustCameraPosition();
					Camera main4 = Camera.main;
					float z3 = Input.mousePosition.z;
					this.lastMousePosition.z = 0f;
				}
			}
		}
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x000D12D8 File Offset: 0x000CF4D8
	[Token(Token = "0x6002715")]
	[Address(RVA = "0x601C40", Offset = "0x600240", VA = "0x180601C40")]
	public void AdjustCameraPosition()
	{
		float orthographicSize = Camera.main.orthographicSize;
		float aspect = Camera.main.aspect;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Vector2 vector2 = this.maxPosition;
		float y = this.maxPosition.y;
		Transform transform2 = base.transform;
	}

	// Token: 0x06002716 RID: 10006 RVA: 0x000D1338 File Offset: 0x000CF538
	[Token(Token = "0x6002716")]
	[Address(RVA = "0x601E00", Offset = "0x600400", VA = "0x180601E00")]
	public void ResetCamera()
	{
		Camera camera = this.Camera;
		float cameraSize = GameAPP.config.cameraSize;
		camera.orthographicSize = cameraSize;
		Transform transform = this.Camera.transform;
	}

	// Token: 0x06002717 RID: 10007 RVA: 0x000D1374 File Offset: 0x000CF574
	[Token(Token = "0x6002717")]
	[Address(RVA = "0x6023C0", Offset = "0x6009C0", VA = "0x1806023C0")]
	public CamaraFollowMouse()
	{
		this.minPosition.y = -10f;
		this.maxPosition = (ulong)1101004800L;
		this.maxPosition.y = 2f;
		base..ctor();
	}

	// Token: 0x04001585 RID: 5509
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001585")]
	public float moveSpeed = 100f;

	// Token: 0x04001586 RID: 5510
	[Token(Token = "0x4001586")]
	public static CamaraFollowMouse Instance;

	// Token: 0x04001587 RID: 5511
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001587")]
	public Vector2 minPosition = (ulong)3221225472L;

	// Token: 0x04001588 RID: 5512
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001588")]
	public Vector2 maxPosition;

	// Token: 0x04001589 RID: 5513
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001589")]
	private Vector3 lastMousePosition;

	// Token: 0x0400158A RID: 5514
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400158A")]
	[SerializeField]
	private bool isFollowing;

	// Token: 0x0400158B RID: 5515
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400158B")]
	private Camera Camera;
}
