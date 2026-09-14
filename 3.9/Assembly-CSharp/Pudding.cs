using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000425 RID: 1061
[Token(Token = "0x2000425")]
public class Pudding : TorchWood
{
	// Token: 0x06001391 RID: 5009 RVA: 0x0006DB4C File Offset: 0x0006BD4C
	[Token(Token = "0x6001391")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x0006DB6C File Offset: 0x0006BD6C
	[Token(Token = "0x6001392")]
	[Address(RVA = "0x4B8430", Offset = "0x4B6A30", VA = "0x1804B8430", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 1.5f;
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x0006DB90 File Offset: 0x0006BD90
	[Token(Token = "0x6001393")]
	[Address(RVA = "0x4B8460", Offset = "0x4B6A60", VA = "0x1804B8460", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Bullet>(num) && base.CheckFire(num))
		{
			int num2 = this.attributeCount;
			num2++;
			this.attributeCount = num2;
			if (num2 < 30)
			{
				int thePlantRow = this.thePlantRow;
				num += 136;
				this.anim.SetTrigger("rise");
				this.theStatus = (PlantStatus)((ulong)25L);
			}
		}
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x0006DC00 File Offset: 0x0006BE00
	[Token(Token = "0x6001394")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public Pudding()
	{
	}
}
