using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000791 RID: 1937
[Token(Token = "0x2000791")]
public class GardenCamera : MonoBehaviour
{
	// Token: 0x0600275C RID: 10076 RVA: 0x000D0748 File Offset: 0x000CE948
	[Token(Token = "0x600275C")]
	[Address(RVA = "0x63E980", Offset = "0x63CF80", VA = "0x18063E980")]
	private void Awake()
	{
		Camera main = Camera.main;
		this.theCamrea = main;
		float orthographicSize = this.theCamrea.orthographicSize;
		this.targetSize = orthographicSize;
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x000D0780 File Offset: 0x000CE980
	[Token(Token = "0x600275D")]
	[Address(RVA = "0x63EC30", Offset = "0x63D230", VA = "0x18063EC30")]
	private void Start()
	{
		Transform transform = this.theCamrea.transform;
		Transform transform2 = this.follow;
		Camera camera = this.theCamrea;
		Vector3 vector;
		float z = vector.z;
		Transform transform3 = camera.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		this.theCamrea.orthographicSize = 6.5f;
		this.targetSize = 6.5f;
	}

	// Token: 0x0600275E RID: 10078 RVA: 0x000D07E4 File Offset: 0x000CE9E4
	[Token(Token = "0x600275E")]
	[Address(RVA = "0x63ED90", Offset = "0x63D390", VA = "0x18063ED90")]
	private void Update()
	{
		Transform transform = this.follow;
		int num = 0;
		if (transform != num)
		{
			this.Following();
		}
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x000D080C File Offset: 0x000CEA0C
	[Token(Token = "0x600275F")]
	[Address(RVA = "0x63E9D0", Offset = "0x63CFD0", VA = "0x18063E9D0")]
	private void Following()
	{
		Transform transform = this.theCamrea.transform;
		Transform transform2 = this.follow;
		Vector3 vector;
		float z = vector.z;
		float deltaTime = Time.deltaTime;
		int num = 0;
		if (num > (int)deltaTime || deltaTime > 1f)
		{
		}
		Transform transform3 = this.theCamrea.transform;
		float axis = Input.GetAxis("Mouse ScrollWheel");
		if (transform3 == 0 || Camera.main.orthographicSize > 10f)
		{
		}
		if (this.theCamrea.orthographic)
		{
			Camera camera = this.theCamrea;
			float orthographicSize = camera.orthographicSize;
			float num2 = this.targetSize;
			float deltaTime2 = Time.deltaTime;
			if (num > (int)deltaTime2 || deltaTime2 > 1f)
			{
			}
			camera.orthographicSize = num2;
		}
	}

	// Token: 0x06002760 RID: 10080 RVA: 0x000D08D4 File Offset: 0x000CEAD4
	[Token(Token = "0x6002760")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GardenCamera()
	{
	}

	// Token: 0x040014A3 RID: 5283
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014A3")]
	[Header("引用")]
	public Camera theCamrea;

	// Token: 0x040014A4 RID: 5284
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014A4")]
	public Transform follow;

	// Token: 0x040014A5 RID: 5285
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014A5")]
	[Header("参数")]
	public float moveSpeed;

	// Token: 0x040014A6 RID: 5286
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40014A6")]
	private float targetSize;
}
