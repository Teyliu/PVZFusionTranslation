using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200030A RID: 778
[Token(Token = "0x200030A")]
public class IceCherry : Plant
{
	// Token: 0x06000E28 RID: 3624 RVA: 0x000517FC File Offset: 0x0004F9FC
	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x402E90", Offset = "0x401490", VA = "0x180402E90", Slot = "52")]
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

	// Token: 0x06000E29 RID: 3625 RVA: 0x00051844 File Offset: 0x0004FA44
	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x403150", Offset = "0x401750", VA = "0x180403150")]
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

	// Token: 0x06000E2A RID: 3626 RVA: 0x000518EC File Offset: 0x0004FAEC
	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x403080", Offset = "0x401680", VA = "0x180403080", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x0005190C File Offset: 0x0004FB0C
	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public IceCherry()
	{
	}
}
