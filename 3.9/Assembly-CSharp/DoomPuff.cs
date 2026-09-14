using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000314 RID: 788
[Token(Token = "0x2000314")]
public class DoomPuff : Plant
{
	// Token: 0x06000E60 RID: 3680 RVA: 0x00052440 File Offset: 0x00050640
	[Token(Token = "0x6000E60")]
	[Address(RVA = "0x446A30", Offset = "0x445030", VA = "0x180446A30")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			if (thePlantRow != 1 && thePlantRow != 10)
			{
				this.Explode();
				int num = 0;
				base.Die((Plant.DieReason)num);
			}
		}
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00052478 File Offset: 0x00050678
	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x446720", Offset = "0x444D20", VA = "0x180446720", Slot = "68")]
	protected virtual void Explode()
	{
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		ScreenShake.TriggerShake(0.1f);
		GameObject[] particlePrefab = GameAPP.particlePrefab;
		Transform axis = this.axis;
		GameObject gameObject = particlePrefab[27];
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		Transform axis2 = this.axis;
		Collider2D[] array;
		if (num < array.Length)
		{
			GameObject gameObject2;
			if (gameObject2.TryGetComponent<Zombie>(num))
			{
				int thePlantRow = this.thePlantRow;
			}
			num++;
		}
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00052508 File Offset: 0x00050708
	[Token(Token = "0x6000E62")]
	[Address(RVA = "0x446700", Offset = "0x444D00", VA = "0x180446700", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (!this.exploded)
		{
		}
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00052520 File Offset: 0x00050720
	[Token(Token = "0x6000E63")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomPuff()
	{
	}

	// Token: 0x04000B1C RID: 2844
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B1C")]
	protected bool exploded;
}
