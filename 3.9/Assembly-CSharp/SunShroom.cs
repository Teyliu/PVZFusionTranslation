using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DC RID: 1244
[Token(Token = "0x20004DC")]
public class SunShroom : Producer
{
	// Token: 0x06001772 RID: 6002 RVA: 0x000803E4 File Offset: 0x0007E5E4
	[Token(Token = "0x6001772")]
	[Address(RVA = "0x517590", Offset = "0x515B90", VA = "0x180517590", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001773 RID: 6003 RVA: 0x00080400 File Offset: 0x0007E600
	[Token(Token = "0x6001773")]
	[Address(RVA = "0x517180", Offset = "0x515780", VA = "0x180517180", Slot = "71")]
	protected virtual void ChangeUpdate()
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

	// Token: 0x06001774 RID: 6004 RVA: 0x00080490 File Offset: 0x0007E690
	[Token(Token = "0x6001774")]
	[Address(RVA = "0x517560", Offset = "0x515B60", VA = "0x180517560", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 120f;
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x000804B0 File Offset: 0x0007E6B0
	[Token(Token = "0x6001775")]
	[Address(RVA = "0x5170E0", Offset = "0x5156E0", VA = "0x1805170E0", Slot = "39")]
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

	// Token: 0x06001776 RID: 6006 RVA: 0x000804F8 File Offset: 0x0007E6F8
	[Token(Token = "0x6001776")]
	[Address(RVA = "0x517460", Offset = "0x515A60", VA = "0x180517460", Slot = "69")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		int num = 0;
		CreateItem instance = CreateItem.Instance;
		if ((this.isGrowen ? 1 : 0) == num)
		{
		}
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x00080534 File Offset: 0x0007E734
	[Token(Token = "0x6001777")]
	[Address(RVA = "0x5173D0", Offset = "0x5159D0", VA = "0x1805173D0")]
	public void Grow()
	{
		Animator anim = this.anim;
		this.isGrowen = true;
		anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x00080574 File Offset: 0x0007E774
	[Token(Token = "0x6001778")]
	[Address(RVA = "0x50E3B0", Offset = "0x50C9B0", VA = "0x18050E3B0")]
	public SunShroom()
	{
	}

	// Token: 0x04000E38 RID: 3640
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E38")]
	protected bool isGrowen;

	// Token: 0x04000E39 RID: 3641
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000E39")]
	private float timer = 150f;
}
