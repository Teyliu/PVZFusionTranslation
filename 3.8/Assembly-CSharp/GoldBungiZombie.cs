using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000673 RID: 1651
[Token(Token = "0x2000673")]
public class GoldBungiZombie : BungiZombie
{
	// Token: 0x06001F89 RID: 8073 RVA: 0x000A7C2C File Offset: 0x000A5E2C
	[Token(Token = "0x6001F89")]
	[Address(RVA = "0x54B160", Offset = "0x549760", VA = "0x18054B160", Slot = "74")]
	public override void Blocked()
	{
		base.Blocked();
		this.blocked = true;
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x000A7C48 File Offset: 0x000A5E48
	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0x54B180", Offset = "0x549780", VA = "0x18054B180", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		if (!this.summoned)
		{
			this.summoned = true;
			if (this.blocked)
			{
				CreateZombie instance = CreateZombie.Instance;
				int num = 0;
				ZombieType theZombieType = this.theZombieType;
				int theZombieRow = this.theZombieRow;
				GoldBungiZombie component = instance.SetZombie(theZombieRow, theZombieType, 9.9f, num != 0).GetComponent<GoldBungiZombie>();
				component.setZombie = true;
				component.theSetZombieType = (ZombieType)((ulong)121L);
				bool isSplited = this.isSplited;
				component.isSplited = isSplited;
				bool revived = this.revived;
				component.revived = revived;
				throw new NullReferenceException();
			}
			Transform axis = this.axis;
			CreateItem instance2 = CreateItem.Instance;
			Vector3 vector;
			float z = vector.z;
			Transform axis2 = this.axis;
			CreateItem instance3 = CreateItem.Instance;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform axis3 = this.axis;
			CreateItem instance4 = CreateItem.Instance;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform axis4 = this.axis;
			CreateItem instance5 = CreateItem.Instance;
			Vector3 vector4;
			float z4 = vector4.z;
			Transform axis5 = this.axis;
			CreateItem instance6 = CreateItem.Instance;
			Vector3 vector5;
			float z5 = vector5.z;
			Transform axis6 = this.axis;
			CreateItem instance7 = CreateItem.Instance;
			Vector3 vector6;
			float z6 = vector6.z;
			Transform axis7 = this.axis;
			CreateItem instance8 = CreateItem.Instance;
			Vector3 vector7;
			float z7 = vector7.z;
		}
	}

	// Token: 0x06001F8B RID: 8075 RVA: 0x000A7D8C File Offset: 0x000A5F8C
	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0x54B5D0", Offset = "0x549BD0", VA = "0x18054B5D0")]
	public GoldBungiZombie()
	{
	}

	// Token: 0x0400108B RID: 4235
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x400108B")]
	private bool blocked;

	// Token: 0x0400108C RID: 4236
	[FieldOffset(Offset = "0x2A9")]
	[Token(Token = "0x400108C")]
	private bool summoned;
}
