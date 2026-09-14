using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DC RID: 1756
[Token(Token = "0x20006DC")]
public class NormalZombie : Zombie
{
	// Token: 0x06002230 RID: 8752 RVA: 0x000B3C60 File Offset: 0x000B1E60
	[Token(Token = "0x6002230")]
	[Address(RVA = "0x5C4760", Offset = "0x5C2D60", VA = "0x1805C4760", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		int num = Animator.StringToHash("inWater");
		GameObject gameObject = this.duck;
		this.hash_inWater = num;
		int num2 = 0;
		if (gameObject != num2)
		{
			GameObject gameObject2 = this.duck;
			int num3 = 0;
			gameObject2.SetActive(num3 != 0);
		}
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x000B3CB0 File Offset: 0x000B1EB0
	[Token(Token = "0x6002231")]
	[Address(RVA = "0x5C4D80", Offset = "0x5C3380", VA = "0x1805C4D80", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		GameObject gameObject = this.duck;
		int num = 0;
		if (gameObject != num)
		{
			BoxType[] roadType = this.board.roadType;
			int theZombieRow = this.theZombieRow;
			BoxType boxType = roadType[theZombieRow];
			if (boxType != BoxType.Water && boxType != BoxType.River)
			{
				GameObject gameObject2 = this.duck;
			}
			this.duck.SetActive(true);
		}
		Board board = this.board;
		int column = base.Column;
		int theZombieRow2 = this.theZombieRow;
		if (board.GetBoxType(column, theZombieRow2) == BoxType.Water)
		{
			this.EnterWater();
		}
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x000B3D44 File Offset: 0x000B1F44
	[Token(Token = "0x6002232")]
	[Address(RVA = "0x5C4CB0", Offset = "0x5C32B0", VA = "0x1805C4CB0", Slot = "22")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		Animator anim = this.anim;
		int num = this.hash_inWater;
		bool @bool = anim.GetBool(num);
		Board board = this.board;
		int column = base.Column;
		int theZombieRow = this.theZombieRow;
		bool flag = board.GetBoxType(column, theZombieRow) == BoxType.Water;
		if (@bool != flag)
		{
			if (@bool)
			{
				return;
			}
			this.EnterWater();
		}
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x000B3DAC File Offset: 0x000B1FAC
	[Token(Token = "0x6002233")]
	[Address(RVA = "0x5C4C10", Offset = "0x5C3210", VA = "0x1805C4C10")]
	private void MoveWaterUpdate()
	{
		Animator anim = this.anim;
		int num = this.hash_inWater;
		bool @bool = anim.GetBool(num);
		Board board = this.board;
		int column = base.Column;
		int theZombieRow = this.theZombieRow;
		bool flag = board.GetBoxType(column, theZombieRow) == BoxType.Water;
		if (@bool != flag)
		{
			if (@bool)
			{
				return;
			}
			this.EnterWater();
		}
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x000B3E0C File Offset: 0x000B200C
	[Token(Token = "0x6002234")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x000B3E1C File Offset: 0x000B201C
	[Token(Token = "0x6002235")]
	[Address(RVA = "0x5C4D50", Offset = "0x5C3350", VA = "0x1805C4D50", Slot = "66")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x000B3E2C File Offset: 0x000B202C
	[Token(Token = "0x6002236")]
	[Address(RVA = "0x5C4810", Offset = "0x5C2E10", VA = "0x1805C4810")]
	private void EnterWater()
	{
		Animator anim = this.anim;
		int num = this.hash_inWater;
		anim.SetBool(num, true);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num3 = 0;
		Vector3 vector2;
		float z2 = vector2.z;
		int theZombieRow = this.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num3, theZombieRow, num4 != 0UL, (float)num2);
		Transform axis3 = this.axis;
		GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		SpriteRenderer component = this.axis.GetComponent<SpriteRenderer>();
		int num5 = 0;
		component.enabled = num5 != 0;
		this.inWater = true;
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x000B3EDC File Offset: 0x000B20DC
	[Token(Token = "0x6002237")]
	[Address(RVA = "0x5C4A10", Offset = "0x5C3010", VA = "0x1805C4A10")]
	private void ExitWater()
	{
		Animator anim = this.anim;
		int num = this.hash_inWater;
		int num2 = 0;
		anim.SetBool(num, num2 != 0);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num3 = 0;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num4 = 0;
		Vector3 vector2;
		float z2 = vector2.z;
		int theZombieRow = this.theZombieRow;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num4, theZombieRow, num5 != 0UL, (float)num3);
		Transform axis3 = this.axis;
		GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		this.axis.GetComponent<SpriteRenderer>().enabled = true;
		this.inWater = false;
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x000B3F84 File Offset: 0x000B2184
	[Token(Token = "0x6002238")]
	[Address(RVA = "0x5C4E90", Offset = "0x5C3490", VA = "0x1805C4E90")]
	public NormalZombie()
	{
	}

	// Token: 0x040011BC RID: 4540
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011BC")]
	public GameObject duck;

	// Token: 0x040011BD RID: 4541
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011BD")]
	private int hash_inWater;
}
