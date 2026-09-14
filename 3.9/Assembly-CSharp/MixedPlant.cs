using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200028E RID: 654
[Token(Token = "0x200028E")]
public class MixedPlant : Plant
{
	// Token: 0x06000BCA RID: 3018 RVA: 0x00043504 File Offset: 0x00041704
	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x423F70", Offset = "0x422570", VA = "0x180423F70", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int attributeCount = this.attributeCount;
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x00043520 File Offset: 0x00041720
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x00043530 File Offset: 0x00041730
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x00043540 File Offset: 0x00041740
	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x4238E0", Offset = "0x421EE0", VA = "0x1804238E0")]
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

	// Token: 0x06000BCE RID: 3022 RVA: 0x00043630 File Offset: 0x00041830
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x423EB0", Offset = "0x4224B0", VA = "0x180423EB0")]
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

	// Token: 0x06000BCF RID: 3023 RVA: 0x00043688 File Offset: 0x00041888
	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public MixedPlant()
	{
	}
}
