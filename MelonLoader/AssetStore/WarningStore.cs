﻿using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using UnityEngine;
using UnityEngine.TextCore.Text;
using static MelonLoader.MelonLogger;

namespace PvZ_Fusion_Translator.AssetStore
{
	public static class WarningStore
	{
		#if MULTI_LANGUAGE
		private static Dictionary<string, (string, string)> warningMessages = new()
		{
			{ "English", ("<size=10>The only valid source of this translation is from this community:\n" +
				"<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. If you got this <i>anywhere</i> else like \n" +
				"<color=#8B0000>Plants Hybrid</color> and <color=#8B0000>superhybrid.online</color>, they stole it.\n" +
				"Stray away from other sources as they may contain viruses.\n" +
				"Please visit our community for future updates.</size>", 
				"Okay! Got it.") },
			{ "French", ("<size=9.5>La seule source valide pour cette traduction provient de cette\n" +
				"communauté :<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Si vous l'avez obtenue \n" +
				"<i>ailleurs</i>, comme <color=#8B0000>Plants Hybrid</color> ou <color=#8B0000>superhybrid.online</color>, ils l'ont volée.\n" +
				"Évitez les autres sources, car elles peuvent contenir des virus.\n" +
				"Veuillez visiter notre communauté pour les mises à jour futures.", 
				"D'accord !") },
			{ "Italian", ("<size=10>L'unica fonte valida di questa traduzione è questa community:\n" +
				"<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Se l'hai ottenuta <i>altrove</i>, come \n" +
				"<color=#8B0000>Plants Hybrid</color> e <color=#8B0000>superhybrid.online</color>, l'hanno rubata.\n" +
				"Evita altre fonti, potrebbero contenere virus.\n" +
				"Visita la nostra community per aggiornamenti futuri.</size>", 
				"Va bene! Ho capito.") },
			{ "German", ("<size=10>Die einzige gültige Quelle für diese Übersetzung stammt aus\n" +
				"dieser Community: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Wenn Sie diese \n" +
				"<i>irgendwo</i> anders gefunden haben, z. B. bei <color=#8B0000>Plants Hybrid</color> oder \n" +
				"<color=#8B0000>superhybrid.online</color>, dann haben sie sie gestohlen.\n" +
				"Meiden Sie andere Quellen, da diese Viren enthalten könnten.\n" +
				"Bitte besuchen Sie unsere Community für zukünftige Updates.", 
				"Okay, verstanden!") },
			{ "Spanish", ("<size=10>La única fuente válida de esta traducción proviene de esta\n" +
				"comunidad: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Si la obtuvo <i>en cualquier</i>\n" +
				"otro lugar como <color=#8B0000>Plants Hybrid</color> o <color=#8B0000>superhybrid.online</color>, la robaron.\n" +
				"Manténgase alejado de otras fuentes, ya que podrían contener virus.\n" +
				"Por favor, visite nuestra comunidad para futuras actualizaciones.", 
				"¡Entendido!") },
			{ "Portuguese", ("<size=10>O lugar original e seguro dessa tradução vem daqui:\n" +
				"<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Se você baixou ela de <i>qualquer \n" +
				"lugar</i> como <color=#8B0000>Plants Hybrid</color> ou <color=#8B0000>superhybrid.online</color>, eles\n" +
				"roubaram. Evite baixar deles, pode conter vírus.\n" +
				"Por favor, visite nossa comunidade para atualizações futuras.</size>", 
				"Okay, entendido.") },
			{ "Filipino", ("<size=9>Ang tanging opisyal na source ng pagsasaling ito ay mula\n" +
				"lamang dito: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Kung nakuha nmo ito <i>kahit \n" +
				"saan pa</i> tulad ng <color=#8B0000>Plants Hybrid</color> at <color=#8B0000>superhybrid.online</color>, ito ay ninakaw. \n" +
				"Lumayo sa ibang source dahil posibleng may kasamang virus.\n" +
				"Paki-bisita ang aming komunidad para sa mga darating na update.</size>" , 
				"Naiintindihan!") },
			{ "Vietnamese", ("<size=8>Nguồn duy nhất hợp lệ của bản dịch này là từ cộng\n" +
				"đồng này: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Nếu bạn nhận \n" +
				"được nó <i>ở bất cứ nơi nào</i> khác như <color=#8B0000>Plants Hybrid</color> \n" +
				"hoặc <color=#8B0000>superhybrid.online</color>, họ đã ăn cắp nó.\n" +
				"Tránh xa các nguồn khác vì chúng có thể chứa \n" +
				"virus. Hãy ghé thăm cộng đồng của chúng tôi để \n" +
				"cập nhật trong tương lai.</size>", 
				"Đồng ý!") },
			{ "Indonesian", ("<size=10>Satu-satunya sumber resmi dari terjemahan ini adalah \n" +
				"komunitas kami: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Jika Anda \n" +
				"mendapatkannya dari <i>sumber lain</i> seperti <color=#8B0000>Plants Hybrid</color> \n" +
				"dan <color=#8B0000>superhybrid.online</color>, mereka mencurinya. \n" +
				"Jauhi sumber lain karena mungkin ada virus.\n" +
				"Silakan kunjungi komunitas kami untuk pembaruan berikutnya.</size>", 
				"Oke! Mengerti.") },
			{ "Russian", ("<size=9>Единственный проверенный источник этого перевода —\n" +
				"сообщество <color=#E6E6FA>discord.gg/DPAC5ZVJ8T</color>.\n" +
				"Или же его замена <color=#E6E6FA>https://t.me/nekoshkindom</color>\n" +
				"Если вы скачали этот мод <i>где-либо ещё</i>, возможно он содержит вирусы.\n" +
				"Программист перевода: LancerX0.\n" +
				"Переводчик: Nekosha.", "Хорошо!") },
			{ "Japanese", ("<size=6>この翻訳の唯一の有効なソースは、このコミュニティからです：\n" +
				"<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>.<color=#8B0000>Plants Hybrid</color>や<color=#8B0000>superhybrid.online</color>、\n" +
				"<color=#8B0000>YoutubeのBlue Fly</color>が作っているもの、他のどこかでこれを入手した場合、\n" +
				"彼らはそれを盗んだことになります。ウイルスが含まれている可能性があるので、\n" +
				"他のソースからは離れてください。今後のアップデートについては、\n私たちのコミュニティをご覧ください。</size>", 
				"了解しました！") },
			{ "Korean", ("<size=8>이 번역은 Bloom(<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>)에서만\n" +
				"제공됩니다. Bloom 디스코드 이외의 다른</i>서드 파티 사이트, \n" +
				"예를 들어 <color=#8B0000>Plants Hybrid</color> 및 <color=#8B0000>superhybrid.online</color>, 또는\n" +
				"<color=#8B0000>유튜브 Blue Fly</color>등에서 제공하는 파일은 무단으로 재배포된 것이며,\n" +
				"이런 사이트들에는 바이러스가 포함되어 있을 가능성이 높습니다. \n향후 업데이트를 위해 저희 디스코드를 방문해 주세요.", 
				"확인") },
			{ "Javanese" , ("<size=10>Sumber mung sing sah kanggo terjemahan iki saka komunitas iki:\n" +
				"<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Yen sampeyan nemokake iki <i>ing papan\n" +
				"liya</i> kaya <color=#8B0000>Plants Hybrid</color> lan <color=#8B0000>superhybrid.online</color>, iku dicolong.\n" +
				"Aja nyedhaki sumber liya amarga bisa ngandhut virus. Mangga\n" +
				"ngunjungi komunitas kita kanggo nganyari ing mangsa ngarep.</size>", 
				"Oke! Ngertos.") },
            { "Polish" , ("<size=8>Jedynym wiarygodnym źródłem tego tłumaczenia jest ta społeczność:\n" +
				"<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Jeśli znalazłeś to <i>gdziekolwiek</i> indziej, np. \n" +
				"<color=#8B0000>Plants Hybrid</color> i <color=#8B0000>superhybrid.online</color>, ukradli to.\n" +
				"Omijaj inne źródła, ponieważ mogą zawierać wirusy.\n" +
				"Odwiedź naszą społeczność, aby uzyskać przyszłe aktualizacje.</size>",
				"Okay! Rozumiem.") },
            { "Hungarian" , ("<size=8>Ennek a fordításnak az egyetlen érvényes forrása ebből a közösségből származik:\n" +
				"<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Ha ezt <i>valahol</i> máshol szerezted, például \n" +
				"<color=#8B0000>Plants Hybrid</color> és <color=#8B0000>superhybrid.online</color> oldalakon, akkor ők lopták.\n" +
				"Kerüld a többi forrást, mert vírusokat tartalmazhatnak.\n" +
				"Kérjük, látogass el közösségünkbe a jövőbeli frissítésekért.</size>",
                "Oké! Értem.") },
            { "Arabic" , ("<size=10>The only valid source of this translation is from this community:\n" +
                "<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. If you got this <i>anywhere</i> else like \n" +
                "<color=#8B0000>Plants Hybrid</color> and <color=#8B0000>superhybrid.online</color>, they stole it.\n" +
                "Stray away from other sources as they may contain viruses.\n" +
                "Please visit our community for future updates.</size>",
                "Okay! Got it.") },
			// { "OTHER" , ("<size=10>A única fonte válida dessa tradução é desta\ncomunidade: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Se você obteve \nisso <i>em qualquer lugar</i> como <color=#8B0000>Plants Hybrid</color>\ne <color=#8B0000>superhybrid.online</color>,ou Blue Fly do Youtube,\nelses roubaram. Fique longe de sites falsos. Por favor,\nvisite nossa comunidade para futuras atualizações.</size>", "¡Okei! Entendido.") }
			// { "OTHER" , ("<size=9.5>Ang translation na ito ay galing dito lamang:\n<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Pag nakuha niyo ito <i>sa iba pa</i>\nkagaya ng <color=#8B0000>Plants Hybrid</color> o <color=#8B0000>superhybrid.online</color>, anumang\nginawagawa ng <color=#8B0000>Blue Fly mula sa Youtube</color>, o anumang\n<color=#8B0000>Sub2Unlock links</color>, scam sila. MAG INGAT dahil\nkasi baka may virus 'jan. Join kayo sa discord namin!\nFilipino Translation by ColinPogi</size>" , "Tayo magsi-laro!") }
		};
		#else
		public static string warningMessage = "<size=10>La única fuente válida de esta traducción proviene de esta\ncomunidad: <color=#64DD17>discord.gg/DPAC5ZVJ8T</color>. Si la obtuvo <i>en cualquier</i>\notro lugar como <color=#8B0000>Plants Hybrid</color> o <color=#8B0000>superhybrid.online</color>, la robaron.\nManténgase alejado de otras fuentes, ya que podrían contener virus.\nPor favor, visite nuestra comunidad para futuras actualizaciones.";
		public static string okayButton = "¡Entendido!";
		#endif

		#if MULTI_LANGUAGE
		public static (string, string) GetWarningMessage(Utils.LanguageEnum language)
		{
			if (warningMessages.TryGetValue(language.ToString(), out var message))
			{

				return message;
			}
			else
			{
				return warningMessages["English"]; // Default to English if language code is not found
			}
		}
#endif

        public static void WarningLoad(NoticeMenu noticeMenu)
        {
            if (noticeMenu == null || noticeMenu.transform == null)
            {
                MelonLogger.Warning("[WarningStore] NoticeMenu or transform is null - ABORTING");
                return;
            }

#if MULTI_LANGUAGE
            try
            {
                var (warningMessage, okayButton) = GetWarningMessage(Utils.Language);
                TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

                Transform warningTransform = noticeMenu.transform.Find("窗口");
                if (warningTransform == null)
                {
                    MelonLogger.Warning("[WarningStore] '窗口' transform not found - ABORTING");
                    return;
                }

                Transform warningTextTransform = warningTransform.Find("文字");
                Transform warningTextShadowTransform = warningTransform.Find("文字2");

                if (warningTextTransform == null || warningTextShadowTransform == null)
                {
                    MelonLogger.Warning("[WarningStore] Could not find text components (文字/文字2)");
                    return;
                }

                TextMeshProUGUI warningText = warningTextTransform.GetComponent<TextMeshProUGUI>();
                TextMeshProUGUI shadowText = warningTextShadowTransform.GetComponent<TextMeshProUGUI>();

                if (warningText == null || shadowText == null)
                {
                    MelonLogger.Warning("[WarningStore] TextMeshProUGUI components missing");
                    return;
                }

                warningText.text = warningMessage;
                shadowText.text = warningMessage;

                if (fontAsset != null)
                {
                    warningText.font = fontAsset;
                    shadowText.font = fontAsset;
                }
                else
                {
                    MelonLogger.Warning("[WarningStore] Font asset is null");
                }

                MelonLogger.Msg("Warning message loaded successfully!");
            }
            catch (Exception e)
            {
                MelonLogger.Error($"Critical error in WarningLoad: {e}");
            }
#endif
        }
#if MULTI_LANGUAGE
        public static bool isWarningMessageLoaded = false;

        public static void WarningReload(Utils.LanguageEnum language, NoticeMenu noticeMenu)
        {
            if (noticeMenu == null)
            {
                MelonLogger.Warning("[WarningStore] NoticeMenu is null in WarningReload");
                return;
            }

            if (Utils.OldLanguage.ToString() == language.ToString() && Utils.OldLanguage.ToString() != "English")
            {
                return;
            }

            if (!isWarningMessageLoaded)
            {
                WarningLoad(noticeMenu);
                isWarningMessageLoaded = true;
            }
        }
#else
        public static bool isWarningMessageLoaded = false;

        public static void WarningReload()
        {
            if (!WarningStore.isWarningMessageLoaded)
            {
                WarningStore.WarningLoad();
                WarningStore.isWarningMessageLoaded = true;
            }
        }
#endif
    }
}