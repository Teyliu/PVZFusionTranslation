using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057A RID: 1402
[Token(Token = "0x200057A")]
public class PuffChomper : Plant
{
	// Token: 0x06001A05 RID: 6661 RVA: 0x0008BEB8 File Offset: 0x0008A0B8
	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x53A880", Offset = "0x538E80", VA = "0x18053A880", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		int num = 0;
		if ((this.startJump ? 1 : 0) == num)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int thePlantRow = this.thePlantRow;
					if (Lawnf.InLandStatus((ZombieStatus)num))
					{
						goto IL_004A;
					}
				}
				num++;
				IL_004A:
				this.anim.Play("jump");
				base.RemoveFromList();
				this.startJump = true;
			}
		}
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x0008BF34 File Offset: 0x0008A134
	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x53AB10", Offset = "0x539110", VA = "0x18053AB10", Slot = "38")]
	protected override void OnUpdate()
	{
		Transform transform = base.transform;
		float deltaTime = Time.deltaTime;
		Transform axis = this.axis;
		Mouse instance = Mouse.Instance;
		float num;
		base.AdjustPositionY(num);
		Transform axis2 = this.axis;
		Board board = this.board;
		int num2;
		if (num2 > board.columnNum)
		{
			int num3 = 0;
			base.Die((Plant.DieReason)num3);
		}
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x0008BF94 File Offset: 0x0008A194
	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x539BC0", Offset = "0x5381C0", VA = "0x180539BC0")]
	public void JumpStart()
	{
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x0008BFAC File Offset: 0x0008A1AC
	[Token(Token = "0x6001A08")]
	[Address(RVA = "0x53A380", Offset = "0x538980", VA = "0x18053A380")]
	public void JumpEnd()
	{
		int num = 0;
		this.theStatus = (PlantStatus)num;
		if (base.BoxType != BoxType.Water)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = this.zombieLayer;
			Collider2D[] array;
			if (num >= array.Length)
			{
				return;
			}
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				if (Lawnf.InLandStatus((ZombieStatus)num) && flag2)
				{
					PlantType thePlantType = this.thePlantType;
					num++;
				}
			}
			num++;
		}
		int num3 = 0;
		base.Die((Plant.DieReason)num3);
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x0008C040 File Offset: 0x0008A240
	[Token(Token = "0x6001A09")]
	[Address(RVA = "0x53ACE0", Offset = "0x5392E0", VA = "0x18053ACE0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (!this.startJump)
		{
			return;
		}
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x0008C058 File Offset: 0x0008A258
	[Token(Token = "0x6001A0A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x0008C068 File Offset: 0x0008A268
	[Token(Token = "0x6001A0B")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public PuffChomper()
	{
	}

	// Token: 0x04000EF7 RID: 3831
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000EF7")]
	public bool startJump;
}
