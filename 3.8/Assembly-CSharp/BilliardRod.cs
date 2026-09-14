using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000092 RID: 146
[Token(Token = "0x2000092")]
public class BilliardRod : MonoBehaviour
{
	// Token: 0x0600026D RID: 621 RVA: 0x00009D7C File Offset: 0x00007F7C
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x3B6410", Offset = "0x3B4A10", VA = "0x1803B6410")]
	private void Awake()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		this.sprites = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00009DAC File Offset: 0x00007FAC
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x3B6780", Offset = "0x3B4D80", VA = "0x1803B6780")]
	public void OnUpdate()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.clicking = true;
		}
		if (Input.GetMouseButtonUp(0))
		{
			this.clicking = false;
		}
		GameObject theItemOnMouse = Mouse.Instance.theItemOnMouse;
		int num = 0;
		if (theItemOnMouse != num)
		{
			this.clicking = false;
		}
		if (this.sprites.activeSelf)
		{
			this.PositionUpdate();
			if (this.clicking)
			{
				float deltaTime = Time.deltaTime;
				this.timer = deltaTime;
				int num2 = 0;
				if (num2 > (int)deltaTime || deltaTime > (float)num2)
				{
				}
				this.forcing = true;
				return;
			}
			if (this.forcing)
			{
				float num3 = this.force;
				this.currentForce = num3;
				float deltaTime2 = Time.deltaTime;
				int num4 = 0;
				this.force = (float)num4;
				this.HitBall();
			}
		}
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00009E94 File Offset: 0x00008094
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x3B6E00", Offset = "0x3B5400", VA = "0x1803B6E00")]
	public bool Upgrade()
	{
		if (this.level == 0)
		{
			Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
			bool flag;
			if (flag)
			{
				Transform transform = this.sprites.transform;
				int num = 0;
				SpriteRenderer component = transform.GetChild(num).GetComponent<SpriteRenderer>();
				SpriteRenderer spriteRenderer;
				Sprite sprite = spriteRenderer.sprite;
				component.sprite = sprite;
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText("球杆力度大幅增加", 5f, num2 != 0);
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00009F18 File Offset: 0x00008118
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x3B6460", Offset = "0x3B4A60", VA = "0x1803B6460")]
	private void ForceUpdate()
	{
		if (!this.clicking)
		{
			if (this.forcing)
			{
				float num = this.force;
				this.currentForce = num;
				float deltaTime = Time.deltaTime;
				int num2 = 0;
				this.force = (float)num2;
				this.HitBall();
				return;
			}
		}
		else
		{
			float deltaTime2 = Time.deltaTime;
			this.timer = deltaTime2;
			int num3 = 0;
			if (num3 > (int)deltaTime2 || deltaTime2 > (float)num3)
			{
			}
			this.forcing = true;
		}
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00009FA4 File Offset: 0x000081A4
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x3B6590", Offset = "0x3B4B90", VA = "0x1803B6590")]
	private void HitBall()
	{
		BilliardBall whiteBall = BilliardManager.Instance.whiteBall;
		Transform transform = base.transform;
		float num2;
		float num = num2 * this.currentForce;
		GameAPP.PlaySound(53, 0.5f, 1f);
		Transform transform2 = whiteBall.transform;
		Board instance = Board.Instance;
		Rigidbody2D rb = whiteBall.rb;
		int num3 = 0;
		float num4 = num * 90f;
		rb.velocity = num3;
		GameObject gameObject = this.sprites;
		int num5 = 0;
		this.forcing = false;
		this.currentForce = (float)num5;
		this.force = (float)num5;
		int num6 = 0;
		gameObject.SetActive(num6 != 0);
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0000A040 File Offset: 0x00008240
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x3B6970", Offset = "0x3B4F70", VA = "0x1803B6970")]
	public void PositionUpdate()
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Transform transform = BilliardManager.Instance.whiteBall.transform;
		int num = 0;
		int num2 = 0;
		Transform transform2 = base.transform;
		Transform transform3 = BilliardManager.Instance.whiteBall.transform;
		float num3 = this.force;
		if (num > (int)num3 || num3 > 1f)
		{
		}
		float num4 = (float)(num2 * (int)57.29578f);
		LineRenderer lineRenderer = this.line;
		int num5 = 0;
		if (lineRenderer != num5)
		{
			LineRenderer lineRenderer2 = this.line;
			Transform transform4 = BilliardManager.Instance.whiteBall.transform;
			int num6 = 0;
			Vector3 vector;
			float z2 = vector.z;
			int num7 = 0;
			lineRenderer2.SetPosition(num7, num6);
			this.line.SetPosition(1, num6);
			this.line.startWidth = 0.3f;
			this.line.endWidth = 0.3f;
		}
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000A134 File Offset: 0x00008334
	[Token(Token = "0x6000273")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BilliardRod()
	{
	}

	// Token: 0x040000C8 RID: 200
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C8")]
	public float force;

	// Token: 0x040000C9 RID: 201
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000C9")]
	private bool forcing;

	// Token: 0x040000CA RID: 202
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000CA")]
	private float currentForce;

	// Token: 0x040000CB RID: 203
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000CB")]
	private float timer;

	// Token: 0x040000CC RID: 204
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000CC")]
	public GameObject sprites;

	// Token: 0x040000CD RID: 205
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000CD")]
	public LineRenderer line;

	// Token: 0x040000CE RID: 206
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000CE")]
	private int level;

	// Token: 0x040000CF RID: 207
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000CF")]
	private bool clicking;
}
