using System;
using System.Collections;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000822 RID: 2082
[Token(Token = "0x2000822")]
public class DamagePopup : MonoBehaviour
{
	// Token: 0x06002A4B RID: 10827 RVA: 0x000E7830 File Offset: 0x000E5A30
	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x64C9E0", Offset = "0x64AFE0", VA = "0x18064C9E0")]
	private void Awake()
	{
		TextMeshProUGUI textMeshProUGUI = this.textMesh;
		int num = 0;
		if (textMeshProUGUI == num)
		{
			TextMeshProUGUI componentInChildren = base.GetComponentInChildren<TextMeshProUGUI>();
			this.textMesh = componentInChildren;
		}
		TextMeshProUGUI textMeshProUGUI2 = this.textMesh;
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x000E786C File Offset: 0x000E5A6C
	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x64CF10", Offset = "0x64B510", VA = "0x18064CF10")]
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		float num = this.scaleDuration;
		this.timer = deltaTime;
		if (deltaTime > num)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x000E78A0 File Offset: 0x000E5AA0
	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0x64CDD0", Offset = "0x64B3D0", VA = "0x18064CDD0")]
	public void Setup(string value, bool isCritical, int size = 72)
	{
		this.textMesh.text = value;
		TextMeshProUGUI textMeshProUGUI = this.textMesh;
		if (isCritical)
		{
			TextMeshProUGUI textMeshProUGUI2 = this.textMesh;
			TextMeshProUGUI textMeshProUGUI3 = this.textMesh;
			float num = textMeshProUGUI3.m_fontSize * 1.5f;
			textMeshProUGUI3.fontSize = num;
			this.textMesh.fontStyle = (FontStyles)((uint)1);
		}
		DamagePopup.<PopupAnimation>d__11 <PopupAnimation>d__;
		<PopupAnimation>d__.System.IDisposable.Dispose();
		<PopupAnimation>d__.<>1__state = (int)((ulong)0L);
		<PopupAnimation>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<PopupAnimation>d__);
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x000E7920 File Offset: 0x000E5B20
	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0x64CAA0", Offset = "0x64B0A0", VA = "0x18064CAA0")]
	private IEnumerator PopupAnimation()
	{
		DamagePopup.<PopupAnimation>d__11 <PopupAnimation>d__;
		<PopupAnimation>d__.System.IDisposable.Dispose();
		<PopupAnimation>d__.<>1__state = (int)((ulong)0L);
		<PopupAnimation>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x000E7944 File Offset: 0x000E5B44
	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0x64CB10", Offset = "0x64B110", VA = "0x18064CB10")]
	public static void SetPopUp(Board board, Vector2 position, string value, bool isCritical, int size)
	{
		GameObject gameObject = Resources.Load<GameObject>("UI/DamagePopup/DamagePopup");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject2;
		DamagePopup component = gameObject2.GetComponent<DamagePopup>();
		component.textMesh.text = value;
		TextMeshProUGUI textMeshProUGUI = component.textMesh;
		if (isCritical)
		{
			TextMeshProUGUI textMeshProUGUI2 = component.textMesh;
			TextMeshProUGUI textMeshProUGUI3 = component.textMesh;
			float num = textMeshProUGUI3.m_fontSize * 1.5f;
			textMeshProUGUI3.fontSize = num;
			component.textMesh.fontStyle = (FontStyles)((uint)1);
		}
		DamagePopup.<PopupAnimation>d__11 <PopupAnimation>d__;
		<PopupAnimation>d__.System.IDisposable.Dispose();
		<PopupAnimation>d__.<>1__state = (int)((ulong)0L);
		<PopupAnimation>d__.<>4__this = component;
		Coroutine coroutine = component.StartCoroutine(<PopupAnimation>d__);
	}

	// Token: 0x06002A50 RID: 10832 RVA: 0x000E79EC File Offset: 0x000E5BEC
	[Token(Token = "0x6002A50")]
	[Address(RVA = "0x64CFA0", Offset = "0x64B5A0", VA = "0x18064CFA0")]
	public DamagePopup()
	{
	}

	// Token: 0x040018A0 RID: 6304
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018A0")]
	[Header("动画设置")]
	public float moveSpeed = 2f;

	// Token: 0x040018A1 RID: 6305
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40018A1")]
	public float fadeDuration = 1f;

	// Token: 0x040018A2 RID: 6306
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018A2")]
	public float scaleAmount = 1.2f;

	// Token: 0x040018A3 RID: 6307
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40018A3")]
	public float scaleDuration = 0.2f;

	// Token: 0x040018A4 RID: 6308
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40018A4")]
	private float timer;

	// Token: 0x040018A5 RID: 6309
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40018A5")]
	[Header("文本组件")]
	public TextMeshProUGUI textMesh;

	// Token: 0x040018A6 RID: 6310
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018A6")]
	private Vector3 startPosition;

	// Token: 0x040018A7 RID: 6311
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40018A7")]
	private Color originalColor;
}
