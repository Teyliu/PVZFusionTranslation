using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000796 RID: 1942
[Token(Token = "0x2000796")]
public class GardenPlayer : MonoBehaviour
{
	// Token: 0x0600276D RID: 10093 RVA: 0x000D0C30 File Offset: 0x000CEE30
	[Token(Token = "0x600276D")]
	[Address(RVA = "0x63FB20", Offset = "0x63E120", VA = "0x18063FB20")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Transform transform = base.transform;
		BigGardenData gardenData = TreasureData.gardenData;
	}

	// Token: 0x0600276E RID: 10094 RVA: 0x000D0C64 File Offset: 0x000CEE64
	[Token(Token = "0x600276E")]
	[Address(RVA = "0x640580", Offset = "0x63EB80", VA = "0x180640580")]
	private void Start()
	{
		Garden instance = Garden.Instance;
		this.garden = instance;
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x000D0C80 File Offset: 0x000CEE80
	[Token(Token = "0x600276F")]
	[Address(RVA = "0x640470", Offset = "0x63EA70", VA = "0x180640470")]
	private void Update()
	{
		int num = 0;
		if (Lawnf.GetKey((KeyCode)((uint)119)))
		{
			Rigidbody2D rigidbody2D = this.rb;
			int num2 = 0;
			rigidbody2D.AddForce(num, (ForceMode2D)num2);
		}
		int num3 = 0;
		if (Lawnf.GetKey((KeyCode)((uint)97)))
		{
			Rigidbody2D rigidbody2D2 = this.rb;
			int num4 = 0;
			rigidbody2D2.AddForce(num3, (ForceMode2D)num4);
		}
		int num5 = 0;
		if (Lawnf.GetKey((KeyCode)((uint)115)))
		{
			Rigidbody2D rigidbody2D3 = this.rb;
			int num6 = 0;
			rigidbody2D3.AddForce(num5, (ForceMode2D)num6);
		}
		int num7 = 0;
		if (Lawnf.GetKey((KeyCode)((uint)100)))
		{
			Rigidbody2D rigidbody2D4 = this.rb;
			int num8 = 0;
			rigidbody2D4.AddForce(num7, (ForceMode2D)num8);
		}
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x000D0D1C File Offset: 0x000CEF1C
	[Token(Token = "0x6002770")]
	[Address(RVA = "0x6402F0", Offset = "0x63E8F0", VA = "0x1806402F0")]
	private void FixedUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
		Animator animator = this.anim;
		Vector2 velocity = rigidbody2D.velocity;
		if (animator <= 0)
		{
		}
		Vector2 velocity2 = this.rb.velocity;
		int num = 0;
		if (velocity2 <= num)
		{
			Transform transform = base.transform;
		}
		Transform transform2 = base.transform;
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x000D0D74 File Offset: 0x000CEF74
	[Token(Token = "0x6002771")]
	[Address(RVA = "0x63FBF0", Offset = "0x63E1F0", VA = "0x18063FBF0")]
	public void EnterWater()
	{
		ulong num4;
		do
		{
			this.anim.SetBool("inWater", true);
			this.duck.SetActive(true);
			Transform transform = base.transform;
			int num = 0;
			Transform child = transform.GetChild(num);
			Vector3 vector;
			float z = vector.z;
			Garden garden = this.garden;
			Transform transform2 = base.transform;
			int num2 = 0;
			Vector3 vector2;
			float z2 = vector2.z;
			GameObject gameObject = garden.SetParticle((ParticleType)((uint)32), num2);
			Garden garden2 = this.garden;
			Transform transform3 = base.transform;
			int num3 = 0;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform transform4 = garden2.SetParticle((ParticleType)((uint)122), num3).transform;
			Vector3 vector4;
			float z4 = vector4.z;
			GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
			List<SpriteRenderer> list = this.lowerBodys;
			bool flag;
			if (flag)
			{
			}
		}
		while (num4 != (ulong)0L);
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x000D0E54 File Offset: 0x000CF054
	[Token(Token = "0x6002772")]
	[Address(RVA = "0x63FF70", Offset = "0x63E570", VA = "0x18063FF70")]
	public void ExitWater()
	{
		ulong num6;
		do
		{
			Animator animator = this.anim;
			int num = 0;
			animator.SetBool("inWater", num != 0);
			GameObject gameObject = this.duck;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
			Transform transform = base.transform;
			int num3 = 0;
			Transform child = transform.GetChild(num3);
			Vector3 vector;
			float z = vector.z;
			Garden garden = this.garden;
			Transform transform2 = base.transform;
			int num4 = 0;
			Vector3 vector2;
			float z2 = vector2.z;
			GameObject gameObject2 = garden.SetParticle((ParticleType)((uint)32), num4);
			Garden garden2 = this.garden;
			Transform transform3 = base.transform;
			int num5 = 0;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform transform4 = garden2.SetParticle((ParticleType)((uint)122), num5).transform;
			Vector3 vector4;
			float z4 = vector4.z;
			GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
			List<SpriteRenderer> list = this.lowerBodys;
			bool flag;
			if (flag)
			{
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x000D0F40 File Offset: 0x000CF140
	[Token(Token = "0x6002773")]
	[Address(RVA = "0x640470", Offset = "0x63EA70", VA = "0x180640470")]
	private void InputUpdate()
	{
		int num = 0;
		if (Lawnf.GetKey((KeyCode)((uint)119)))
		{
			Rigidbody2D rigidbody2D = this.rb;
			int num2 = 0;
			rigidbody2D.AddForce(num, (ForceMode2D)num2);
		}
		int num3 = 0;
		if (Lawnf.GetKey((KeyCode)((uint)97)))
		{
			Rigidbody2D rigidbody2D2 = this.rb;
			int num4 = 0;
			rigidbody2D2.AddForce(num3, (ForceMode2D)num4);
		}
		int num5 = 0;
		if (Lawnf.GetKey((KeyCode)((uint)115)))
		{
			Rigidbody2D rigidbody2D3 = this.rb;
			int num6 = 0;
			rigidbody2D3.AddForce(num5, (ForceMode2D)num6);
		}
		int num7 = 0;
		if (Lawnf.GetKey((KeyCode)((uint)100)))
		{
			Rigidbody2D rigidbody2D4 = this.rb;
			int num8 = 0;
			rigidbody2D4.AddForce(num7, (ForceMode2D)num8);
		}
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x000D0FDC File Offset: 0x000CF1DC
	[Token(Token = "0x6002774")]
	[Address(RVA = "0x6405D0", Offset = "0x63EBD0", VA = "0x1806405D0")]
	public GardenPlayer()
	{
		List<SpriteRenderer> list = new List();
		this.lowerBodys = list;
		base..ctor();
	}

	// Token: 0x040014B4 RID: 5300
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014B4")]
	public List<SpriteRenderer> lowerBodys;

	// Token: 0x040014B5 RID: 5301
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014B5")]
	public GameObject duck;

	// Token: 0x040014B6 RID: 5302
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014B6")]
	public Garden garden;

	// Token: 0x040014B7 RID: 5303
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014B7")]
	public Rigidbody2D rb;

	// Token: 0x040014B8 RID: 5304
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014B8")]
	public Animator anim;

	// Token: 0x040014B9 RID: 5305
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40014B9")]
	public float moveSpeed;
}
