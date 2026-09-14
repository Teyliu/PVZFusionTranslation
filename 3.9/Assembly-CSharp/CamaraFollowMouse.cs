using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007C6 RID: 1990
[Token(Token = "0x20007C6")]
public class CamaraFollowMouse : MonoBehaviour
{
	// Token: 0x06002842 RID: 10306 RVA: 0x000D6174 File Offset: 0x000D4374
	[Token(Token = "0x6002842")]
	[Address(RVA = "0x6655A0", Offset = "0x663BA0", VA = "0x1806655A0")]
	private void Awake()
	{
		CamaraFollowMouse.Instance = this;
		Camera main = Camera.main;
		this.Camera = main;
	}

	// Token: 0x06002843 RID: 10307 RVA: 0x000D6198 File Offset: 0x000D4398
	[Token(Token = "0x6002843")]
	[Address(RVA = "0x6656E0", Offset = "0x663CE0", VA = "0x1806656E0")]
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

	// Token: 0x06002844 RID: 10308 RVA: 0x000D6300 File Offset: 0x000D4500
	[Token(Token = "0x6002844")]
	[Address(RVA = "0x665450", Offset = "0x663A50", VA = "0x180665450")]
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

	// Token: 0x06002845 RID: 10309 RVA: 0x000D6360 File Offset: 0x000D4560
	[Token(Token = "0x6002845")]
	[Address(RVA = "0x665610", Offset = "0x663C10", VA = "0x180665610")]
	public void ResetCamera()
	{
		Camera camera = this.Camera;
		float cameraSize = GameAPP.config.cameraSize;
		camera.orthographicSize = cameraSize;
		Transform transform = this.Camera.transform;
	}

	// Token: 0x06002846 RID: 10310 RVA: 0x000D639C File Offset: 0x000D459C
	[Token(Token = "0x6002846")]
	[Address(RVA = "0x665BD0", Offset = "0x6641D0", VA = "0x180665BD0")]
	public CamaraFollowMouse()
	{
		this.minPosition.y = -10f;
		this.maxPosition = (ulong)1101004800L;
		this.maxPosition.y = 2f;
		base..ctor();
	}

	// Token: 0x04001661 RID: 5729
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001661")]
	public float moveSpeed = 100f;

	// Token: 0x04001662 RID: 5730
	[Token(Token = "0x4001662")]
	public static CamaraFollowMouse Instance;

	// Token: 0x04001663 RID: 5731
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001663")]
	public Vector2 minPosition = (ulong)3221225472L;

	// Token: 0x04001664 RID: 5732
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001664")]
	public Vector2 maxPosition;

	// Token: 0x04001665 RID: 5733
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001665")]
	private Vector3 lastMousePosition;

	// Token: 0x04001666 RID: 5734
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001666")]
	[SerializeField]
	private bool isFollowing;

	// Token: 0x04001667 RID: 5735
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001667")]
	private Camera Camera;
}
