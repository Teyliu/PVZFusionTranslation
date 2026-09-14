using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000304 RID: 772
[Token(Token = "0x2000304")]
public class DoomPuff : Plant
{
	// Token: 0x06000E17 RID: 3607 RVA: 0x000514C4 File Offset: 0x0004F6C4
	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x402620", Offset = "0x400C20", VA = "0x180402620")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			if (thePlantRow != 1 && thePlantRow != 10)
			{
				GameAPP.PlaySound(41, 0.5f, 1f);
				ScreenShake.TriggerShake(0.1f);
				GameObject[] particlePrefab = GameAPP.particlePrefab;
				Transform axis = this.axis;
				GameObject gameObject = particlePrefab[27];
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.board.transform;
				this.AttackZombie();
				int num = 0;
				this.exploded = true;
				base.Die((Plant.DieReason)num);
			}
		}
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00051554 File Offset: 0x0004F754
	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x402470", Offset = "0x400A70", VA = "0x180402470")]
	private void AttackZombie()
	{
		Transform axis = this.axis;
		int num = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			GameObject gameObject;
			if (gameObject.TryGetComponent<Zombie>(num))
			{
				int thePlantRow = this.thePlantRow;
			}
			num++;
		}
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00051594 File Offset: 0x0004F794
	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x402600", Offset = "0x400C00", VA = "0x180402600", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (!this.exploded)
		{
			this.AttackZombie();
			return;
		}
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x000515B4 File Offset: 0x0004F7B4
	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomPuff()
	{
	}

	// Token: 0x04000ACB RID: 2763
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000ACB")]
	private bool exploded;
}
