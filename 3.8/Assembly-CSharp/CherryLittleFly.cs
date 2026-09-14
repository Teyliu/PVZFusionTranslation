using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000360 RID: 864
[Token(Token = "0x2000360")]
public class CherryLittleFly : UltimateLittleFly
{
	// Token: 0x06000FD3 RID: 4051 RVA: 0x0005B6DC File Offset: 0x000598DC
	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x422670", Offset = "0x420C70", VA = "0x180422670", Slot = "5")]
	protected override void Update()
	{
		int num = 0;
		Plant parentPlant = this.parentPlant;
		int num2 = 0;
		if (!(parentPlant == num2))
		{
			Zombie target = this.target;
			int num3 = 0;
			if (!(target == num3))
			{
				if (this.target.TryGetComponent<Collider2D>(num3))
				{
					Zombie target2 = this.target;
					if (base.CheckZombie(target2))
					{
						Transform axis = this.axis;
						Transform transform = base.transform;
						Transform transform2 = base.transform;
					}
				}
				this.target = num;
			}
			Zombie zombie = base.GetZombie();
			this.target = zombie;
			this.onTarget = num != 0;
			Transform transform3 = base.transform;
			float num4 = this.offset * 5f;
			Transform transform4 = base.transform;
			Transform transform5 = base.transform;
			Transform axis2 = this.parentPlant.axis;
			Vector3 vector;
			float z = vector.z;
			float deltaTime = Time.deltaTime;
			if (num == 0)
			{
			}
			Transform transform6 = base.transform;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			float deltaTime2 = Time.deltaTime;
			Transform axis3 = this.axis;
			Transform transform7 = base.transform;
			Transform transform8 = base.transform;
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			this.Die();
			BoardAction boardAction = Board.Instance.boardAction;
			Transform transform9 = base.transform;
			Zombie target3 = this.target;
			PlantType fromType = this.fromType;
			int num5 = this.dmg;
			Transform transform10 = base.transform;
			Zombie target4 = this.target;
			PlantType fromType2 = this.fromType;
			return;
		}
		this.Die();
		throw new NullReferenceException();
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x0005B854 File Offset: 0x00059A54
	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x422530", Offset = "0x420B30", VA = "0x180422530", Slot = "8")]
	public override void Die()
	{
		Plant parentPlant = this.parentPlant;
		int num = 0;
		if (parentPlant != num)
		{
			Plant parentPlant2 = this.parentPlant;
			bool flag;
			if (flag)
			{
				Board instance = Board.Instance;
			}
		}
		Board instance2 = Board.Instance;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x0005B8A0 File Offset: 0x00059AA0
	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x422E70", Offset = "0x421470", VA = "0x180422E70")]
	public CherryLittleFly()
	{
	}

	// Token: 0x04000B5A RID: 2906
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B5A")]
	public int dmg;
}
