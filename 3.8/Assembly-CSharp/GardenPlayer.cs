using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200075D RID: 1885
[Token(Token = "0x200075D")]
public class GardenPlayer : MonoBehaviour
{
	// Token: 0x06002646 RID: 9798 RVA: 0x000CBBAC File Offset: 0x000C9DAC
	[Token(Token = "0x6002646")]
	[Address(RVA = "0x5DCC00", Offset = "0x5DB200", VA = "0x1805DCC00")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Transform transform = base.transform;
		BigGardenData gardenData = TreasureData.gardenData;
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x000CBBE0 File Offset: 0x000C9DE0
	[Token(Token = "0x6002647")]
	[Address(RVA = "0x5DD660", Offset = "0x5DBC60", VA = "0x1805DD660")]
	private void Start()
	{
		Garden instance = Garden.Instance;
		this.garden = instance;
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x000CBBFC File Offset: 0x000C9DFC
	[Token(Token = "0x6002648")]
	[Address(RVA = "0x5DD550", Offset = "0x5DBB50", VA = "0x1805DD550")]
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

	// Token: 0x06002649 RID: 9801 RVA: 0x000CBC98 File Offset: 0x000C9E98
	[Token(Token = "0x6002649")]
	[Address(RVA = "0x5DD3D0", Offset = "0x5DB9D0", VA = "0x1805DD3D0")]
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

	// Token: 0x0600264A RID: 9802 RVA: 0x000CBCF0 File Offset: 0x000C9EF0
	[Token(Token = "0x600264A")]
	[Address(RVA = "0x5DCCD0", Offset = "0x5DB2D0", VA = "0x1805DCCD0")]
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

	// Token: 0x0600264B RID: 9803 RVA: 0x000CBDD0 File Offset: 0x000C9FD0
	[Token(Token = "0x600264B")]
	[Address(RVA = "0x5DD050", Offset = "0x5DB650", VA = "0x1805DD050")]
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

	// Token: 0x0600264C RID: 9804 RVA: 0x000CBEBC File Offset: 0x000CA0BC
	[Token(Token = "0x600264C")]
	[Address(RVA = "0x5DD550", Offset = "0x5DBB50", VA = "0x1805DD550")]
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

	// Token: 0x0600264D RID: 9805 RVA: 0x000CBF58 File Offset: 0x000CA158
	[Token(Token = "0x600264D")]
	[Address(RVA = "0x5DD6B0", Offset = "0x5DBCB0", VA = "0x1805DD6B0")]
	public GardenPlayer()
	{
		List<SpriteRenderer> list = new List();
		this.lowerBodys = list;
		base..ctor();
	}

	// Token: 0x040013DC RID: 5084
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013DC")]
	public List<SpriteRenderer> lowerBodys;

	// Token: 0x040013DD RID: 5085
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013DD")]
	public GameObject duck;

	// Token: 0x040013DE RID: 5086
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013DE")]
	public Garden garden;

	// Token: 0x040013DF RID: 5087
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013DF")]
	public Rigidbody2D rb;

	// Token: 0x040013E0 RID: 5088
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013E0")]
	public Animator anim;

	// Token: 0x040013E1 RID: 5089
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013E1")]
	public float moveSpeed;
}
