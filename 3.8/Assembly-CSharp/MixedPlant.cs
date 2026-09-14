using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000288 RID: 648
[Token(Token = "0x2000288")]
public class MixedPlant : Plant
{
	// Token: 0x06000BAE RID: 2990 RVA: 0x00043698 File Offset: 0x00041898
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x3D6820", Offset = "0x3D4E20", VA = "0x1803D6820", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int attributeCount = this.attributeCount;
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x000436B4 File Offset: 0x000418B4
	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x000436C4 File Offset: 0x000418C4
	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x000436D4 File Offset: 0x000418D4
	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x3D6190", Offset = "0x3D4790", VA = "0x1803D6190")]
	public void CreateAnim(Board board, int theColumn, int theRow, PlantType thePlantType)
	{
		int num = 0;
		Dictionary<PlantType, List<PlantType>> baseOfUltimatePlants = MixData.BaseOfUltimatePlants;
		bool flag;
		if (!flag)
		{
			List<PlantType> list = new List();
			int size = list._size;
			int size2 = list._size;
		}
		List<GameObject> list2 = new List();
		float num2 = global::UnityEngine.Random.Range((float)0, 360f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Transform transform = base.transform;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		int size3 = list2._size;
		list2._size = typeof(Vector3).TypeHandle;
		num++;
		Transform axis2 = this.axis;
		MixedPlant.<FusionAnimation>d__4 <FusionAnimation>d__;
		<FusionAnimation>d__.System.IDisposable.Dispose();
		<FusionAnimation>d__.<>1__state = (int)((ulong)0L);
		<FusionAnimation>d__.<>4__this = this;
		<FusionAnimation>d__.materials = list2;
		<FusionAnimation>d__.centerPos = 0;
		<FusionAnimation>d__.centerPos.y = (float)0;
		<FusionAnimation>d__.resultPlant = PlantType.Peashooter;
		<FusionAnimation>d__.column = 0;
		<FusionAnimation>d__.row = theRow;
		Coroutine coroutine = base.StartCoroutine(<FusionAnimation>d__);
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x000437C4 File Offset: 0x000419C4
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x3D6760", Offset = "0x3D4D60", VA = "0x1803D6760")]
	private IEnumerator FusionAnimation(List<GameObject> materials, Vector2 centerPos, PlantType resultPlant, Board board, int column, int row)
	{
		MixedPlant.<FusionAnimation>d__4 <FusionAnimation>d__;
		<FusionAnimation>d__.System.IDisposable.Dispose();
		<FusionAnimation>d__.<>1__state = (int)((ulong)0L);
		<FusionAnimation>d__.<>4__this = this;
		<FusionAnimation>d__.materials = materials;
		<FusionAnimation>d__.column = 0;
		<FusionAnimation>d__.row = 0;
		<FusionAnimation>d__.resultPlant = resultPlant;
		<FusionAnimation>d__.centerPos = centerPos;
		<FusionAnimation>d__.centerPos.y = (float)0;
		return null;
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x0004381C File Offset: 0x00041A1C
	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public MixedPlant()
	{
	}
}
