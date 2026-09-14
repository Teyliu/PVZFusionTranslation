using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Spine;
using Spine.Unity;
using UnityEngine;

// Token: 0x02000504 RID: 1284
[Token(Token = "0x2000504")]
public class HypnoCattailGirl : CattailGirl
{
	// Token: 0x060017FA RID: 6138 RVA: 0x0008282C File Offset: 0x00080A2C
	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x4CADD0", Offset = "0x4C93D0", VA = "0x1804CADD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		SkeletonAnimation component = base.GetComponent<SkeletonAnimation>();
		this.spineAnim = component;
		MeshRenderer component2 = base.GetComponent<MeshRenderer>();
		this.meshRenderer = component2;
		SkeletonAnimation skeletonAnimation = this.spineAnim;
		this.theStatus = (PlantStatus)((ulong)43L);
		skeletonAnimation.skeletonDataAsset.GetAnimationStateData().defaultMix = 0.05f;
		global::Spine.AnimationState animationState = this.spineAnim.AnimationState;
		int num = 0;
		int num2 = 0;
		TrackEntry trackEntry = animationState.SetAnimation(num2, "henshin", num != 0);
		global::Spine.AnimationState.TrackEntryDelegate trackEntryDelegate = delegate(TrackEntry entry)
		{
			this.theStatus = (PlantStatus)((ulong)0L);
		};
		trackEntry.Complete += trackEntryDelegate;
		global::Spine.AnimationState.TrackEntryDelegate trackEntryDelegate2 = delegate(TrackEntry entry)
		{
			this.canExplde = true;
		};
		trackEntry.Complete += trackEntryDelegate2;
		global::Spine.AnimationState animationState2 = this.spineAnim.AnimationState;
		int num3 = 0;
		int num4 = 0;
		TrackEntry trackEntry2 = animationState2.AddAnimation(num4, "idle", true, (float)num3);
		MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
		this.mpb = materialPropertyBlock;
		this.attributeCountdown = 3f;
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x00082918 File Offset: 0x00080B18
	[Token(Token = "0x60017FB")]
	[Address(RVA = "0x4CB460", Offset = "0x4C9A60", VA = "0x1804CB460", Slot = "38")]
	public override void SetBrightness(float b)
	{
		MeshRenderer meshRenderer = this.meshRenderer;
		this.brightness = b;
		MaterialPropertyBlock materialPropertyBlock = this.mpb;
		meshRenderer.Internal_GetPropertyBlock(materialPropertyBlock);
		this.mpb.SetFloat("_Brightness", b);
		MeshRenderer meshRenderer2 = this.meshRenderer;
		MaterialPropertyBlock materialPropertyBlock2 = this.mpb;
		meshRenderer2.Internal_SetPropertyBlock(materialPropertyBlock2);
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x00082970 File Offset: 0x00080B70
	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x4CB190", Offset = "0x4C9790", VA = "0x1804CB190", Slot = "39")]
	protected override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.idleTimer = deltaTime;
		global::Spine.AnimationState animationState = this.spineAnim.AnimationState;
		int num = global::UnityEngine.Random.Range(0, 2);
		string text = "garden2";
		if (num == 0)
		{
			text = "garden1";
		}
		int num2 = 0;
		int num3 = 0;
		TrackEntry trackEntry = animationState.SetAnimation(num3, text, num2 != 0);
		global::Spine.AnimationState animationState2 = this.spineAnim.AnimationState;
		int num4 = 0;
		int num5 = 0;
		TrackEntry trackEntry2 = animationState2.AddAnimation(num5, "idle", true, (float)num4);
		this.idleTimer = -7f;
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x00082A00 File Offset: 0x00080C00
	[Token(Token = "0x60017FD")]
	[Address(RVA = "0x4CB2C0", Offset = "0x4C98C0", VA = "0x1804CB2C0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (this.Shootable())
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			this.idleTimer = 0f;
		}
		if (global::UnityEngine.Random.Range(0, 2) == 0)
		{
			global::Spine.AnimationState animationState = this.spineAnim.AnimationState;
			int num2 = 0;
			TrackEntry trackEntry = animationState.SetAnimation(2, "1", num2 != 0);
		}
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x00082A84 File Offset: 0x00080C84
	[Token(Token = "0x60017FE")]
	[Address(RVA = "0x4CB8A0", Offset = "0x4C9EA0", VA = "0x1804CB8A0", Slot = "47")]
	protected override bool Shootable()
	{
		bool flag = base.Shootable();
		if (!flag)
		{
			return flag;
		}
		bool flag2;
		return flag2;
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x00082AA4 File Offset: 0x00080CA4
	[Token(Token = "0x60017FF")]
	[Address(RVA = "0x4CB150", Offset = "0x4C9750", VA = "0x1804CB150", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		global::Spine.AnimationState animationState = this.spineAnim.AnimationState;
		float thePlantSpeed = this.thePlantSpeed;
		animationState.timeScale = thePlantSpeed;
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x00082AD8 File Offset: 0x00080CD8
	[Token(Token = "0x6001800")]
	[Address(RVA = "0x4CB8D0", Offset = "0x4C9ED0", VA = "0x1804CB8D0")]
	private void SpineShoot()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x00082AF8 File Offset: 0x00080CF8
	[Token(Token = "0x6001801")]
	[Address(RVA = "0x4CB5E0", Offset = "0x4C9BE0", VA = "0x1804CB5E0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		float attributeCountdown = this.attributeCountdown;
		if (attributeCountdown > 1f)
		{
			this.attributeCountdown = attributeCountdown;
		}
		return bullet;
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x00082B58 File Offset: 0x00080D58
	[Token(Token = "0x6001802")]
	[Address(RVA = "0x4CB740", Offset = "0x4C9D40", VA = "0x1804CB740", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot2;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		float attributeCountdown = this.attributeCountdown;
		if (attributeCountdown > 1f)
		{
			this.attributeCountdown = attributeCountdown;
		}
		return bullet;
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x00082BB8 File Offset: 0x00080DB8
	[Token(Token = "0x6001803")]
	[Address(RVA = "0x4CB110", Offset = "0x4C9710", VA = "0x1804CB110", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		if (this.canExplde)
		{
			float attributeCountdown = this.attributeCountdown;
			int num = 0;
			if (attributeCountdown <= (float)num)
			{
				base.CreateCannonTarget(mouse);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001804 RID: 6148 RVA: 0x00082BE8 File Offset: 0x00080DE8
	[Token(Token = "0x6001804")]
	[Address(RVA = "0x4CB500", Offset = "0x4C9B00", VA = "0x1804CB500", Slot = "63")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x00082C0C File Offset: 0x00080E0C
	[Token(Token = "0x6001805")]
	[Address(RVA = "0x4CB020", Offset = "0x4C9620", VA = "0x1804CB020", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			DroppedCard droppedCard;
			Action<Plant> action;
			droppedCard.plantAction = action;
		}
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x00082C34 File Offset: 0x00080E34
	[Token(Token = "0x6001806")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public HypnoCattailGirl()
	{
	}

	// Token: 0x04000DD8 RID: 3544
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DD8")]
	private SkeletonAnimation spineAnim;

	// Token: 0x04000DD9 RID: 3545
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DD9")]
	private MaterialPropertyBlock mpb;

	// Token: 0x04000DDA RID: 3546
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000DDA")]
	private MeshRenderer meshRenderer;

	// Token: 0x04000DDB RID: 3547
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000DDB")]
	public SkeletonUtilityBone skillBone;

	// Token: 0x04000DDC RID: 3548
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000DDC")]
	private float idleTimer;

	// Token: 0x04000DDD RID: 3549
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000DDD")]
	private bool canExplde;
}
