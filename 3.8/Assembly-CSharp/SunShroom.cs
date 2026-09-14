using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B8 RID: 1208
[Token(Token = "0x20004B8")]
public class SunShroom : Producer
{
	// Token: 0x060016C9 RID: 5833 RVA: 0x0007D78C File Offset: 0x0007B98C
	[Token(Token = "0x60016C9")]
	[Address(RVA = "0x4AB710", Offset = "0x4A9D10", VA = "0x1804AB710", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			float num = this.timer;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			this.timer = num;
			if (num2 > (int)num)
			{
				int num3 = 0;
				base.Die((Plant.DieReason)num3);
				CreatePlant instance = CreatePlant.Instance;
				int num4 = 0;
				Plant plant;
				if (plant != num4)
				{
					float attributeCountdown = this.attributeCountdown;
					plant.AttributeCountdown = attributeCountdown;
					if (plant == 0)
					{
						Transform axis = plant.axis;
						Vector3 vector;
						float z = vector.z;
						Transform transform = plant.transform;
						Vector3 vector2;
						float z2 = vector2.z;
					}
				}
			}
		}
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x0007D82C File Offset: 0x0007BA2C
	[Token(Token = "0x60016CA")]
	[Address(RVA = "0x4AB6E0", Offset = "0x4A9CE0", VA = "0x1804AB6E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 120f;
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x0007D84C File Offset: 0x0007BA4C
	[Token(Token = "0x60016CB")]
	[Address(RVA = "0x4AB4B0", Offset = "0x4A9AB0", VA = "0x1804AB4B0", Slot = "40")]
	protected override void AttributeEvent()
	{
		if (!this.isGrowen)
		{
			Animator anim = this.anim;
			this.isGrowen = true;
			anim.SetTrigger("grow");
			GameAPP.PlaySound(56, 0.5f, 1f);
			return;
		}
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x0007D894 File Offset: 0x0007BA94
	[Token(Token = "0x60016CC")]
	[Address(RVA = "0x4AB5E0", Offset = "0x4A9BE0", VA = "0x1804AB5E0", Slot = "70")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		int num = 0;
		CreateItem instance = CreateItem.Instance;
		if ((this.isGrowen ? 1 : 0) == num)
		{
		}
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x0007D8D0 File Offset: 0x0007BAD0
	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x4AB550", Offset = "0x4A9B50", VA = "0x1804AB550")]
	public void Grow()
	{
		Animator anim = this.anim;
		this.isGrowen = true;
		anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x0007D910 File Offset: 0x0007BB10
	[Token(Token = "0x60016CE")]
	[Address(RVA = "0x4AB980", Offset = "0x4A9F80", VA = "0x1804AB980")]
	public SunShroom()
	{
	}

	// Token: 0x04000D9F RID: 3487
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D9F")]
	private bool isGrowen;

	// Token: 0x04000DA0 RID: 3488
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000DA0")]
	private float timer = 150f;
}
