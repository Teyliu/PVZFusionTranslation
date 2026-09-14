using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000383 RID: 899
[Token(Token = "0x2000383")]
public class DiamondImitater : Imitater
{
	// Token: 0x06001088 RID: 4232 RVA: 0x0005E51C File Offset: 0x0005C71C
	[Token(Token = "0x6001088")]
	[Address(RVA = "0x47F820", Offset = "0x47DE20", VA = "0x18047F820")]
	private void AnimExplode()
	{
		uint num2;
		int num = global::UnityEngine.Random.Range(0, (int)num2);
		List<PlantType> ultimatePlants = Lawnf.GetUltimatePlants();
		Predicate<PlantType> <>9__0_ = DiamondImitater.<>c.<>9__0_0;
		if (<>9__0_ == 0)
		{
			DiamondImitater.<>c.<>9__0_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int num3 = ultimatePlants.RemoveAll(<>9__0_);
		int num4 = ultimatePlants._size;
		int num5 = 0;
		CreatePlant instance = CreatePlant.Instance;
		num4 = global::UnityEngine.Random.Range(num5, num4);
		PlantType plantType = ultimatePlants[num4];
		Transform axis = this.axis;
		ParticleManager instance2 = ParticleManager.Instance;
		CreatePlant instance3 = CreatePlant.Instance;
		Plant plant;
		plant.GetComponent<Present>().AnimEvent();
		Transform axis2 = this.axis;
		CreateZombie instance4 = CreateZombie.Instance;
		Transform axis3 = this.axis;
		CreateZombie instance5 = CreateZombie.Instance;
		Zombie zombie;
		zombie.GetComponent<RandomZombie>().theFirstArmorHealth = (int)((ulong)1L);
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x0005E770 File Offset: 0x0005C970
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x480460", Offset = "0x47EA60", VA = "0x180480460")]
	private void FireBall()
	{
		GameObject gameObject = Resources.Load<GameObject>("Zombies/_Image/FireBall");
		int num = LayerMask.NameToLayer("Plant");
		Board board = this.board;
		int num2 = 0;
		if (num2 < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			Mouse instance = Mouse.Instance;
			int num3 = 0;
			float boxXFromColumn = instance.GetBoxXFromColumn(num3);
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, num2);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			ZombieBall component = gameObject2.GetComponent<ZombieBall>();
			component.plant = true;
			component.gameObject.layer = num;
			SortingGroup component2 = component.GetComponent<SortingGroup>();
			int num4;
			num2 = num4;
			string text = string.Format("bullet{0}", num4);
			component2.sortingLayerName = text;
			component.theBallRow = num2;
			component.dmg = (int)((ulong)40L);
			Board board2 = this.board;
			num2++;
			uint num5;
			num5 += (uint)4;
		}
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x0005E864 File Offset: 0x0005CA64
	[Token(Token = "0x600108A")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public DiamondImitater()
	{
	}

	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	private enum RandomEffect
	{
		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		TravelBuff,
		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		Sun,
		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		FireBall,
		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		KillZombies,
		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		DamagePlants
	}
}
