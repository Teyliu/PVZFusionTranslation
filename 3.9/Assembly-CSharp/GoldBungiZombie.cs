using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A9 RID: 1705
[Token(Token = "0x20006A9")]
public class GoldBungiZombie : BungiZombie
{
	// Token: 0x0600208B RID: 8331 RVA: 0x000AC504 File Offset: 0x000AA704
	[Token(Token = "0x600208B")]
	[Address(RVA = "0x5AD7F0", Offset = "0x5ABDF0", VA = "0x1805AD7F0", Slot = "76")]
	public override void Blocked()
	{
		base.Blocked();
		this.blocked = true;
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x000AC520 File Offset: 0x000AA720
	[Token(Token = "0x600208C")]
	[Address(RVA = "0x5AD810", Offset = "0x5ABE10", VA = "0x1805AD810", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		while (!this.summoned)
		{
			this.summoned = true;
			if (!this.blocked)
			{
				Transform axis = this.axis;
				CreateItem instance = CreateItem.Instance;
				Vector3 vector;
				float z = vector.z;
				Transform axis2 = this.axis;
				CreateItem instance2 = CreateItem.Instance;
				Vector3 vector2;
				float z2 = vector2.z;
				Transform axis3 = this.axis;
				CreateItem instance3 = CreateItem.Instance;
				Vector3 vector3;
				float z3 = vector3.z;
				Transform axis4 = this.axis;
				CreateItem instance4 = CreateItem.Instance;
				Vector3 vector4;
				float z4 = vector4.z;
				Transform axis5 = this.axis;
				CreateItem instance5 = CreateItem.Instance;
				Vector3 vector5;
				float z5 = vector5.z;
				Transform axis6 = this.axis;
				CreateItem instance6 = CreateItem.Instance;
				Vector3 vector6;
				float z6 = vector6.z;
				Transform axis7 = this.axis;
				CreateItem instance7 = CreateItem.Instance;
				Vector3 vector7;
				float z7 = vector7.z;
				break;
			}
			CreateZombie instance8 = CreateZombie.Instance;
			int num = 0;
			ZombieType theZombieType = this.theZombieType;
			int theZombieRow = this.theZombieRow;
			Zombie zombie = instance8.SetZombie(theZombieRow, theZombieType, 9.9f, num != 0);
			int num2 = 0;
			if (zombie != num2)
			{
				bool isSplited = this.isSplited;
				zombie.isSplited = isSplited;
				bool revived = this.revived;
				zombie.revived = revived;
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x000AC65C File Offset: 0x000AA85C
	[Token(Token = "0x600208D")]
	[Address(RVA = "0x5ADCB0", Offset = "0x5AC2B0", VA = "0x1805ADCB0")]
	public GoldBungiZombie()
	{
	}

	// Token: 0x04001158 RID: 4440
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4001158")]
	private bool blocked;

	// Token: 0x04001159 RID: 4441
	[FieldOffset(Offset = "0x2C9")]
	[Token(Token = "0x4001159")]
	private bool summoned;
}
