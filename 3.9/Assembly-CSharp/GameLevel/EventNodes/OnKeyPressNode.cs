using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDF RID: 3039
	[Token(Token = "0x2000BDF")]
	[Serializable]
	public class OnKeyPressNode : EventNodeBase
	{
		// Token: 0x06003F42 RID: 16194 RVA: 0x0014C228 File Offset: 0x0014A428
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x864860", Offset = "0x862E60", VA = "0x180864860", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x0014C238 File Offset: 0x0014A438
		[Token(Token = "0x6003F43")]
		[Address(RVA = "0x8648A0", Offset = "0x862EA0", VA = "0x1808648A0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x0014C270 File Offset: 0x0014A470
		[Token(Token = "0x6003F44")]
		[Address(RVA = "0x864760", Offset = "0x862D60", VA = "0x180864760", Slot = "6")]
		public override void Execute()
		{
			if (this.targetKey != KeyCode.None)
			{
				KeyCode keyCode = this.targetKey;
				EventNodeDebug.Log(string.Format("[OnKeyPressNode] 触发按键事件: {0}", keyCode));
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnKeyPressNode] targetKey 为 None，无法触发按键事件，节点ID: " + nodeId);
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x0014C2C4 File Offset: 0x0014A4C4
		[Token(Token = "0x6003F45")]
		[Address(RVA = "0x864990", Offset = "0x862F90", VA = "0x180864990", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			TheButton buttonPrefab = ui.buttonPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			TheButton theButton = global::UnityEngine.Object.Instantiate<TheButton>(buttonPrefab, valueEditContainer);
			TheButton button = theButton;
			TextMeshProUGUI componentInChildren = button.GetComponentInChildren<TextMeshProUGUI>();
			TextMeshProUGUI tmp = componentInChildren;
			TextMeshProUGUI tmp2 = tmp;
			if (this.targetKey != KeyCode.None)
			{
				KeyCode keyCode = this.targetKey;
				string text;
				tmp2.text = text;
			}
			tmp2.text = "请设置按键";
			TheButton button2 = button;
			bool _lock = false;
			UnityEvent theEvent_up = button2.theEvent_up;
			UnityAction unityAction = delegate
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			};
			theEvent_up.AddListener(unityAction);
			return 1;
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x0014C378 File Offset: 0x0014A578
		[Token(Token = "0x6003F46")]
		[Address(RVA = "0x864BB0", Offset = "0x8631B0", VA = "0x180864BB0")]
		private UniTask<KeyCode> WaitSettingKey(CancellationToken cancellationToken)
		{
			return default(UniTask<KeyCode>);
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x0014C398 File Offset: 0x0014A598
		[Token(Token = "0x6003F47")]
		[Address(RVA = "0x864CA0", Offset = "0x8632A0", VA = "0x180864CA0")]
		public OnKeyPressNode()
		{
		}

		// Token: 0x0400300C RID: 12300
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400300C")]
		public KeyCode targetKey;

		// Token: 0x0400300D RID: 12301
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400300D")]
		public string trigger_PortName = "触发";
	}
}
