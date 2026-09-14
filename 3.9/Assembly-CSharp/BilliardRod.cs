using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000097")]
public class BilliardRod : MonoBehaviour
{
	// Token: 0x06000288 RID: 648 RVA: 0x0000A0F4 File Offset: 0x000082F4
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x4031A0", Offset = "0x4017A0", VA = "0x1804031A0")]
	private void Awake()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		this.sprites = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x06000289 RID: 649 RVA: 0x0000A124 File Offset: 0x00008324
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x403510", Offset = "0x401B10", VA = "0x180403510")]
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

	// Token: 0x0600028A RID: 650 RVA: 0x0000A20C File Offset: 0x0000840C
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x403B90", Offset = "0x402190", VA = "0x180403B90")]
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
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600028B RID: 651 RVA: 0x0000A278 File Offset: 0x00008478
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x4031F0", Offset = "0x4017F0", VA = "0x1804031F0")]
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

	// Token: 0x0600028C RID: 652 RVA: 0x0000A304 File Offset: 0x00008504
	[Token(Token = "0x600028C")]
	[Address(RVA = "0x403320", Offset = "0x401920", VA = "0x180403320")]
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

	// Token: 0x0600028D RID: 653 RVA: 0x0000A3A0 File Offset: 0x000085A0
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x403700", Offset = "0x401D00", VA = "0x180403700")]
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

	// Token: 0x0600028E RID: 654 RVA: 0x0000A494 File Offset: 0x00008694
	[Token(Token = "0x600028E")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BilliardRod()
	{
	}

	// Token: 0x040000D5 RID: 213
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D5")]
	public float force;

	// Token: 0x040000D6 RID: 214
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000D6")]
	private bool forcing;

	// Token: 0x040000D7 RID: 215
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D7")]
	private float currentForce;

	// Token: 0x040000D8 RID: 216
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000D8")]
	private float timer;

	// Token: 0x040000D9 RID: 217
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D9")]
	public GameObject sprites;

	// Token: 0x040000DA RID: 218
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DA")]
	public LineRenderer line;

	// Token: 0x040000DB RID: 219
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000DB")]
	private int level;

	// Token: 0x040000DC RID: 220
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000DC")]
	private bool clicking;
}
