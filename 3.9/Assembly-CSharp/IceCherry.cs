using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200031A RID: 794
[Token(Token = "0x200031A")]
public class IceCherry : Plant
{
	// Token: 0x06000E71 RID: 3697 RVA: 0x00052760 File Offset: 0x00050960
	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x447110", Offset = "0x445710", VA = "0x180447110", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		int attackDamage = this.attackDamage;
		if (IceCherry.<>c.<>9__0_0 == 0)
		{
			Action<Zombie> action;
			IceCherry.<>c.<>9__0_0 = action;
		}
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x000527A8 File Offset: 0x000509A8
	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x4473D0", Offset = "0x4459D0", VA = "0x1804473D0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Bullet>(num))
		{
			int thePlantRow = this.thePlantRow;
			if (thePlantRow == 1)
			{
				ParticleManager instance = ParticleManager.Instance;
				Vector3 vector;
				float z = vector.z;
			}
			if (thePlantRow == 3)
			{
				ParticleManager instance2 = ParticleManager.Instance;
				Vector3 vector2;
				float z2 = vector2.z;
			}
			if (thePlantRow == 105)
			{
				ParticleManager instance3 = ParticleManager.Instance;
				Vector3 vector3;
				float z3 = vector3.z;
				base.UpdateText();
				uint num2;
				GameAPP.PlaySound((int)num2, 0.5f, 1f);
				Transform axis = this.axis;
				this.attributeCount = num;
				uint num3;
				GameAPP.PlaySound((int)num3, 0.5f, 1f);
			}
		}
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00052850 File Offset: 0x00050A50
	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x447300", Offset = "0x445900", VA = "0x180447300", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00052870 File Offset: 0x00050A70
	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public IceCherry()
	{
	}
}
