using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000758 RID: 1880
[Token(Token = "0x2000758")]
public class GardenCamera : MonoBehaviour
{
	// Token: 0x06002635 RID: 9781 RVA: 0x000CB6B8 File Offset: 0x000C98B8
	[Token(Token = "0x6002635")]
	[Address(RVA = "0x5DBA70", Offset = "0x5DA070", VA = "0x1805DBA70")]
	private void Awake()
	{
		Camera main = Camera.main;
		this.theCamrea = main;
		float orthographicSize = this.theCamrea.orthographicSize;
		this.targetSize = orthographicSize;
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x000CB6F0 File Offset: 0x000C98F0
	[Token(Token = "0x6002636")]
	[Address(RVA = "0x5DBD20", Offset = "0x5DA320", VA = "0x1805DBD20")]
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

	// Token: 0x06002637 RID: 9783 RVA: 0x000CB754 File Offset: 0x000C9954
	[Token(Token = "0x6002637")]
	[Address(RVA = "0x5DBE80", Offset = "0x5DA480", VA = "0x1805DBE80")]
	private void Update()
	{
		Transform transform = this.follow;
		int num = 0;
		if (transform != num)
		{
			this.Following();
		}
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x000CB77C File Offset: 0x000C997C
	[Token(Token = "0x6002638")]
	[Address(RVA = "0x5DBAC0", Offset = "0x5DA0C0", VA = "0x1805DBAC0")]
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

	// Token: 0x06002639 RID: 9785 RVA: 0x000CB844 File Offset: 0x000C9A44
	[Token(Token = "0x6002639")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GardenCamera()
	{
	}

	// Token: 0x040013CB RID: 5067
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013CB")]
	[Header("引用")]
	public Camera theCamrea;

	// Token: 0x040013CC RID: 5068
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013CC")]
	public Transform follow;

	// Token: 0x040013CD RID: 5069
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013CD")]
	[Header("参数")]
	public float moveSpeed;

	// Token: 0x040013CE RID: 5070
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40013CE")]
	private float targetSize;
}
