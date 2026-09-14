using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000DC RID: 220
[Token(Token = "0x20000DC")]
public class NutCannon : MonoBehaviour
{
	// Token: 0x06000432 RID: 1074 RVA: 0x00015114 File Offset: 0x00013314
	[Token(Token = "0x6000432")]
	[Address(RVA = "0x4FD470", Offset = "0x4FBA70", VA = "0x1804FD470")]
	public void Shoot()
	{
		NutCannon_bullet nutCannon_bullet = this.shootObj;
		nutCannon_bullet.launched = true;
		Transform transform = nutCannon_bullet.transform;
		Transform transform2 = Board.Instance.transform;
		transform.parentInternal = transform2;
		NutCannon_bullet nutCannon_bullet2 = this.waitObj;
		this.shootObj = nutCannon_bullet2;
		Transform transform3 = this.shootObj.transform;
		Transform transform4 = this.shoot;
		transform3.parentInternal = transform4;
		Transform transform5 = this.shootObj.transform;
		Transform transform6 = this.shootObj.transform;
		Transform transform7 = this.shootObj.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		transform7.localRotation = identityQuaternion;
		PlantType random = ListExtensions.GetRandom<PlantType>(this.bullets);
		NutCannon_bullet nutCannon_bullet3;
		this.waitObj = nutCannon_bullet3;
		Transform transform8 = this.waitObj.transform;
		Transform transform9 = this.wait;
		transform8.parentInternal = transform9;
		Transform transform10 = this.waitObj.transform;
		Transform transform11 = this.waitObj.transform;
		Transform transform12 = this.waitObj.transform;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		transform12.localRotation = identityQuaternion2;
		this.anim.SetTrigger("shoot");
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00015244 File Offset: 0x00013444
	[Token(Token = "0x6000433")]
	[Address(RVA = "0x4FD930", Offset = "0x4FBF30", VA = "0x1804FD930")]
	private void Start()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		PlantType random = ListExtensions.GetRandom<PlantType>(this.bullets);
		NutCannon_bullet nutCannon_bullet;
		this.shootObj = nutCannon_bullet;
		Transform transform = this.shootObj.transform;
		Transform transform2 = this.shoot;
		transform.parentInternal = transform2;
		Transform transform3 = this.shootObj.transform;
		Transform transform4 = this.shootObj.transform;
		Transform transform5 = this.shootObj.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		transform5.localRotation = identityQuaternion;
		PlantType random2 = ListExtensions.GetRandom<PlantType>(this.bullets);
		NutCannon_bullet nutCannon_bullet2;
		this.waitObj = nutCannon_bullet2;
		Transform transform6 = this.waitObj.transform;
		Transform transform7 = this.wait;
		transform6.parentInternal = transform7;
		Transform transform8 = this.waitObj.transform;
		Transform transform9 = this.waitObj.transform;
		Transform transform10 = this.waitObj.transform;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		transform10.localRotation = identityQuaternion2;
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00015338 File Offset: 0x00013538
	[Token(Token = "0x6000434")]
	[Address(RVA = "0x4FD410", Offset = "0x4FBA10", VA = "0x1804FD410")]
	private PlantType GetPlantType()
	{
		return ListExtensions.GetRandom<PlantType>(this.bullets);
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00015350 File Offset: 0x00013550
	[Token(Token = "0x6000435")]
	[Address(RVA = "0x4FDD80", Offset = "0x4FC380", VA = "0x1804FDD80")]
	private void Update()
	{
		if (this.auto)
		{
			if (this.auto)
			{
				return;
			}
		}
		else
		{
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			Transform transform = base.transform;
			Vector3 vector;
			float z2 = vector.z;
			Transform transform2 = this.cannonPos.transform;
			bool mouseButton = Input.GetMouseButton(0);
			while (!mouseButton)
			{
			}
			while (mouseButton)
			{
			}
		}
		this.Shoot();
		this.timer = 0.2f;
		throw new NullReferenceException();
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x000153CC File Offset: 0x000135CC
	[Token(Token = "0x6000436")]
	[Address(RVA = "0x4FD170", Offset = "0x4FB770", VA = "0x1804FD170")]
	private void FixedUpdate()
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.timer = num;
			this.timer = 0f;
		}
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00015400 File Offset: 0x00013600
	[Token(Token = "0x6000437")]
	[Address(RVA = "0x4FD1C0", Offset = "0x4FB7C0", VA = "0x1804FD1C0")]
	private NutCannon_bullet GetBullet(PlantType theSeedType)
	{
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (!flag)
		{
		}
		NutCannon_bullet nutCannon_bullet = new GameObject("bullet").AddComponent<NutCannon_bullet>();
		nutCannon_bullet.thePlantType = theSeedType;
		GameObject gameObject;
		Transform transform = gameObject.transform;
		Transform transform2 = nutCannon_bullet.transform;
		transform.parentInternal = transform2;
		Transform transform3 = gameObject.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00015468 File Offset: 0x00013668
	[Token(Token = "0x6000438")]
	[Address(RVA = "0x4FDF30", Offset = "0x4FC530", VA = "0x1804FDF30")]
	public NutCannon()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		this.bullets = list;
		base..ctor();
	}

	// Token: 0x0400023D RID: 573
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400023D")]
	public Transform cannonPos;

	// Token: 0x0400023E RID: 574
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400023E")]
	public Transform shoot;

	// Token: 0x0400023F RID: 575
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400023F")]
	public Transform wait;

	// Token: 0x04000240 RID: 576
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000240")]
	public bool auto = true;

	// Token: 0x04000241 RID: 577
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000241")]
	private NutCannon_bullet shootObj;

	// Token: 0x04000242 RID: 578
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000242")]
	private NutCannon_bullet waitObj;

	// Token: 0x04000243 RID: 579
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000243")]
	private Animator anim;

	// Token: 0x04000244 RID: 580
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000244")]
	private float timer;

	// Token: 0x04000245 RID: 581
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000245")]
	private readonly List<PlantType> bullets;
}
