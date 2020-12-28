using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EmojiLib.Properties;

namespace EmojiLib
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			tabPageSearch.Parent = null;
			toolStripProgressBar.Visible = false;
			toolStripMenuItemSearch.Visible = false;
			labelInformation.Text = string.Empty;
			labelCopiedStatus.Visible = false;
		}

		private static void SomethingWentWrong()
		{
			MessageBox.Show(Resources.somethingWentWrong, Resources.errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
		}

		private void SetStatusbar(string text)
		{
			labelInformation.Text = text;
		}

		#region Enter event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is TextBox textBox)
			{
				SetStatusbar(text: (textBox).AccessibleDescription);
			}
			else if (sender is Button button)
			{
				SetStatusbar(text: (button).AccessibleDescription);
			}
			else if (sender is RadioButton radioButton)
			{
				SetStatusbar(text: (radioButton).AccessibleDescription);
			}
			else if (sender is CheckBox checkBox)
			{
				SetStatusbar(text: (checkBox).AccessibleDescription);
			}
			else if (sender is DateTimePicker dateTimePicker)
			{
				SetStatusbar(text: (dateTimePicker).AccessibleDescription);
			}
			else if (sender is Label label)
			{
				SetStatusbar(text: (label).AccessibleDescription);
			}
			else if (sender is PictureBox pictureBox)
			{
				SetStatusbar(text: (pictureBox).AccessibleDescription);
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				SetStatusbar(text: (toolStripButton).AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				SetStatusbar(text: (toolStripMenuItem).AccessibleDescription);
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				SetStatusbar(text: (toolStripLabel).AccessibleDescription);
			}
			else if (sender is ToolStripComboBox toolStripComboBox)
			{
				SetStatusbar(text: (toolStripComboBox).AccessibleDescription);
			}
			else if (sender is ToolStripDropDown toolStripDropDown)
			{
				SetStatusbar(text: (toolStripDropDown).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton toolStripDropDownButton)
			{
				SetStatusbar(text: (toolStripDropDownButton).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem toolStripDropDownItem)
			{
				SetStatusbar(text: (toolStripDropDownItem).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu toolStripDropDownMenu)
			{
				SetStatusbar(text: (toolStripDropDownMenu).AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar toolStripProgressBar2)
			{
				SetStatusbar(text: (toolStripProgressBar2).AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				SetStatusbar(text: (toolStripSplitButton).AccessibleDescription);
			}
			else if (sender is ToolStripSeparator toolStripSeparator)
			{
				SetStatusbar(text: (toolStripSeparator).AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel toolStripStatusLabel)
			{
				SetStatusbar(text: (toolStripStatusLabel).AccessibleDescription);
			}
			else if (sender is ToolStripTextBox toolStripTextBox)
			{
				SetStatusbar(text: (toolStripTextBox).AccessibleDescription);
			}
		}

		private void TabPageSmileys_Enter(object sender, EventArgs e)
		{
			toolStripMenuItemSmileys.Checked = true;
			toolStripMenuItemSearch.Checked = false;
		}

		private void TabPageSearch_Enter(object sender, EventArgs e)
		{
			toolStripMenuItemSmileys.Checked = false;
			toolStripMenuItemSearch.Checked = true;
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearStatusbar_Leave(object sender, EventArgs e)
		{
			labelCopiedStatus.Visible = false;
			SetStatusbar(text: "");
		}

		#endregion

		private static void ShowEmojiInfo(string code, string shortName, string group, string subGroup, object tag, Image appleVersion, Image googleVersion, Image facebookVersion, Image windowsVersion, Image twitterVersion, Image joypixelsVersion, Image samsungVersion, Image gmailVersion, Image docomoVersion, Image kddiVersion, Image softbankVersion)
		{
			using (EmojiInfoForm emojiInfo = new EmojiInfoForm())
			{
				emojiInfo.SetCode(code);
				emojiInfo.SetShortName(shortName);
				emojiInfo.SetGroup(group);
				emojiInfo.SetSubGroup(subGroup);
				emojiInfo.SetAppleImageVersion(appleVersion);
				emojiInfo.SetGoogleImageVersion(googleVersion);
				emojiInfo.SetFacebookImageVersion(facebookVersion);
				emojiInfo.SetWindowsImageVersion(windowsVersion);
				emojiInfo.SetTwitterImageVersion(twitterVersion);
				emojiInfo.SetJoyPixelsImageVersion(joypixelsVersion);
				emojiInfo.SetSamsungImageVersion(samsungVersion);
				emojiInfo.SetGmailImageVersion(gmailVersion);
				emojiInfo.SetDocomoImageVersion(docomoVersion);
				emojiInfo.SetKddiImageVersion(kddiVersion);
				emojiInfo.SetSoftbankImageVersion(softbankVersion);
				emojiInfo.ShowDialog();
			}
		}

		private void ShowEmojiInfo2(Emoji emoji)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(text: emoji.Character);
			}
			else if (buttonLibraryMode.Checked)
			{
				using (EmojiInfoForm emojiInfo = new EmojiInfoForm())
				{
					emojiInfo.SetCode(code: emoji.Unicode);
					emojiInfo.SetShortName(name: emoji.FullName);
					emojiInfo.SetGroup(group: emoji.Group);
					emojiInfo.SetSubGroup(subGroup: emoji.SubGroup);
					emojiInfo.SetAppleImageVersion(image: emoji.AppleIcon);
					emojiInfo.SetGoogleImageVersion(image: emoji.GoogleIcon);
					emojiInfo.SetFacebookImageVersion(image: emoji.FacebookIcon);
					emojiInfo.SetWindowsImageVersion(image: emoji.WindowsIcon);
					emojiInfo.SetTwitterImageVersion(image: emoji.TwitterIcon);
					emojiInfo.SetJoyPixelsImageVersion(image: emoji.JoypixelsIcon);
					emojiInfo.SetSamsungImageVersion(image: emoji.SamsungIcon);
					emojiInfo.SetGmailImageVersion(image: emoji.GmailIcon);
					emojiInfo.SetDocomoImageVersion(image: emoji.DocomoIcon);
					emojiInfo.SetKddiImageVersion(image: emoji.KddiIcon);
					emojiInfo.SetSoftbankImageVersion(image: emoji.SoftbankIcon);
					emojiInfo.ShowDialog();
				}
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void SetCopiedToClipboardStatus()
		{
			labelCopiedStatus.Visible = true;
		}

		private void CopyToClipboard(string text)
		{
			if (!string.IsNullOrEmpty(text))
			{
				try
				{
					Clipboard.SetText(text);
					SetCopiedToClipboardStatus();
				}
				catch (ExternalException exception)
				{
					MessageBox.Show(exception.Message);
				}
			}
		}

		private void ShowAboutBox_Click(object sender, EventArgs e)
		{
			AboutBoxForm formAboutBox = new AboutBoxForm();
			formAboutBox.ShowDialog();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Search_Click(object sender, EventArgs e)
		{
			if (toolStripButtonSearch.Checked)
			{
				tabPageSearch.Parent = tabControlEmojis;
				toolStripMenuItemSearch.Visible = true;
				tabControlEmojis.SelectedTab = tabPageSearch;
			}
			else
			{
				tabPageSearch.Parent = null;
				toolStripMenuItemSearch.Visible = false;
			}
		}

		private void GotoTabSmileys_Click(object sender, EventArgs e)
		{
			toolStripMenuItemSmileys.Checked = true;
			toolStripMenuItemSearch.Checked = false;
			tabControlEmojis.SelectedTab = tabPageSmileys;
		}

		private void GotoTabSearch_Click(object sender, EventArgs e)
		{
			toolStripMenuItemSmileys.Checked = false;
			toolStripMenuItemSearch.Checked = true;
			tabControlEmojis.SelectedTab = tabPageSearch;
		}

		private void ButtonSetPickerMode_Click(object sender, EventArgs e)
		{
			buttonPickerMode.Checked = true;
			buttonLibraryMode.Checked = false;
		}

		private void ButtonSetLibraryMode_Click(object sender, EventArgs e)
		{
			buttonPickerMode.Checked = false;
			buttonLibraryMode.Checked = true;
		}

		private void ButtonEmojiSize16_Click(object sender, EventArgs e)
		{
			toolStripProgressBar.Visible = true;
			buttonEmojiSize16.Checked = true;
			buttonEmojiSize24.Checked = false;
			buttonEmojiSize32.Checked = false;
			foreach (var button in flowLayoutPanelSmileys.Controls.OfType<Button>())
			{
				button.Size = new Size(16, 16);
			}
			foreach (var button in flowLayoutPanelSearchResult.Controls.OfType<Button>())
			{
				button.Size = new Size(16, 16);
			}
			toolStripProgressBar.Visible = false;
		}

		private void ButtonEmojiSize24_Click(object sender, EventArgs e)
		{
			toolStripProgressBar.Visible = true;
			buttonEmojiSize16.Checked = false;
			buttonEmojiSize24.Checked = true;
			buttonEmojiSize32.Checked = false;
			foreach (var button in flowLayoutPanelSmileys.Controls.OfType<Button>())
			{
				button.Size = new Size(24, 24);
			}
			foreach (var button in flowLayoutPanelSearchResult.Controls.OfType<Button>())
			{
				button.Size = new Size(24, 24);
			}
			toolStripProgressBar.Visible = false;
		}

		private void ButtonEmojiSize32_Click(object sender, EventArgs e)
		{
			toolStripProgressBar.Visible = true;
			buttonEmojiSize16.Checked = false;
			buttonEmojiSize24.Checked = false;
			buttonEmojiSize32.Checked = true;
			foreach (var button in flowLayoutPanelSmileys.Controls.OfType<Button>())
			{
				button.Size = new Size(32, 32);
			}
			foreach (var button in flowLayoutPanelSearchResult.Controls.OfType<Button>())
			{
				button.Size = new Size(32, 32);
			}
			toolStripProgressBar.Visible = false;
		}

		private void ButtonSearch_Click(object sender, EventArgs e)
		{
			toolStripProgressBar.Visible = true;
			toolStripButtonClearAll.Visible = false;
			if (!string.IsNullOrWhiteSpace(textBoxSearch.Text.ToLower()))
			{
				flowLayoutPanelSearchResult.Controls.Clear();
				List<Button> buttons = new List<Button>();
				int capacity = 0;
				foreach (var button in flowLayoutPanelSmileys.Controls.OfType<Button>())
				{
					if (button.AccessibleDescription.Contains(textBoxSearch.Text))
					{
						capacity++;
						Button newButton = new Button
						{
							AccessibleDescription = button.AccessibleDescription,
							AccessibleName = button.AccessibleName,
							AccessibleRole = button.AccessibleRole,
							BackgroundImage = button.BackgroundImage,
							BackgroundImageLayout = button.BackgroundImageLayout
						};
						newButton.FlatAppearance.BorderSize = button.FlatAppearance.BorderSize;
						newButton.FlatAppearance.CheckedBackColor = button.FlatAppearance.CheckedBackColor;
						newButton.FlatAppearance.MouseDownBackColor = button.FlatAppearance.MouseDownBackColor;
						newButton.FlatStyle = button.FlatStyle;
						newButton.Margin = button.Margin;
						newButton.Name = button.Name;
						newButton.Size = button.Size;
						newButton.Tag = button.Tag;
						newButton.Text = button.Text;
						toolTip.SetToolTip(newButton, button.AccessibleDescription);
						newButton.UseVisualStyleBackColor = button.UseVisualStyleBackColor;
						newButton.Click += Button_Click;
						newButton.Enter += SetStatusbar_Enter;
						newButton.Leave += ClearStatusbar_Leave;
						newButton.MouseEnter += SetStatusbar_Enter;
						newButton.MouseLeave += ClearStatusbar_Leave;
						switch (newButton.Name)
						{
							case "buttonGrinningFace": newButton.Click += ButtonGrinningFace_Click; break;
							case "buttonGrinningFaceWithBigEyes": newButton.Click += ButtonGrinningFaceWithBigEyes_Click; break;
							case "buttonGrinningFaceWithSmilingEyes": newButton.Click += ButtonGrinningFaceWithSmilingEyes_Click; break;
							case "buttonBeamingFaceWithSmilingEyes": newButton.Click += ButtonBeamingFaceWithSmilingEyes_Click; break;
							case "buttonGrinningSquintingFace": newButton.Click += ButtonGrinningSquintingFace_Click; break;
							case "buttonGrinningFaceWithSweat": newButton.Click += ButtonGrinningFaceWithSweat_Click; break;
							case "buttonRollingOnTheFloorLaughing": newButton.Click += ButtonRollingOnTheFloorLaughing_Click; break;
							case "buttonFaceWithTearsOfJoy": newButton.Click += ButtonFaceWithTearsOfJoy_Click; break;
							case "buttonSlightlySmilingFace": newButton.Click += ButtonSlightlySmilingFace_Click; break;
							case "buttonUpsideDownFace": newButton.Click += ButtonUpsideDownFace_Click; break;
							case "buttonWinkingFace": newButton.Click += ButtonWinkingFace_Click; break;
							case "buttonSmilingFaceWithSmilingEyes": newButton.Click += ButtonGrinningFace_Click; break;
							case "buttonSmilingFaceWithHalo": newButton.Click += ButtonSmilingFaceWithHalo_Click; break;
							case "buttonSmilingFaceWithHearts": newButton.Click += ButtonSmilingFaceWithHearts_Click; break;
							case "buttonSmilingFaceWithHeartEyes": newButton.Click += ButtonSmilingFaceWithHeartEyes_Click; break;
							case "buttonStarStruck": newButton.Click += ButtonStarStruck_Click; break;
							case "buttonFaceBlowingAKiss": newButton.Click += ButtonFaceBlowingAKiss_Click; break;
							case "buttonKissingFace": newButton.Click += ButtonKissingFace_Click; break;
							case "buttonSmilingFaceFace": newButton.Click += ButtonSmilingFace_Click; break;
							case "buttonKissingFaceWithClosedEyes": newButton.Click += ButtonKissingFaceWithClosedEyes_Click; break;
							case "buttonKissingFaceWithSmilingEyes": newButton.Click += ButtonKissingFaceWithSmilingEyes_Click; break;
							case "buttonSmilingFaceWithTear": newButton.Click += ButtonSmilingFaceWithTear_Click; break;
							case "buttonFaceSavoringFood": newButton.Click += ButtonFaceSavoringFood_Click; break;
							case "buttonFaceWithTongue": newButton.Click += ButtonFaceWithTongue_Click; break;
							case "buttonWinkingFaceWithTongue": newButton.Click += ButtonWinkingFaceWithTongue_Click; break;
							case "buttonZanyFace": newButton.Click += ButtonZanyFace_Click; break;
							case "buttonSquintingFaceWithTongue": newButton.Click += ButtonSquintingFaceWithTongue_Click; break;
							case "buttonMoneyMouthFace": newButton.Click += ButtonMoneyMouthFace_Click; break;
							case "buttonHuggingFace": newButton.Click += ButtonHuggingFace_Click; break;
							case "buttonFaceWithHandOverMouth": newButton.Click += ButtonFaceWithHandOverMouth_Click; break;
							case "buttonShushingFace": newButton.Click += ButtonShushingFace_Click; break;
							case "buttonThinkingFace": newButton.Click += ButtonThinkingFace_Click; break;
							case "buttonZipperMouthFace": newButton.Click += ButtonZipperMouthFace_Click; break;
							case "buttonFaceWithRaisedEyebrow": newButton.Click += ButtonFaceWithRaisedEyebrow_Click; break;
							case "buttonNeutralFace": newButton.Click += ButtonNeutralFace_Click; break;
							case "buttonExpressionlessFace": newButton.Click += ButtonExpressionlessFace_Click; break;
							case "buttonFaceWithoutMouth": newButton.Click += ButtonFaceWithoutMouth_Click; break;
							case "buttonSmirkingFace": newButton.Click += ButtonSmirkingFace_Click; break;
							case "buttonUnamusedFace": newButton.Click += ButtonUnamusedFace_Click; break;
							case "buttonFaceWithRollingEyes": newButton.Click += ButtonFaceWithRollingEyes_Click; break;
							case "buttonGrimacingFace": newButton.Click += ButtonGrimacingFace_Click; break;
							case "buttonLyingFace": newButton.Click += ButtonLyingFace_Click; break;
							case "buttonRelievedFace": newButton.Click += ButtonRelievedFace_Click; break;
							case "buttonPensiveFace": newButton.Click += ButtonPensiveFace_Click; break;
							case "buttonSleepyFace": newButton.Click += ButtonSleepyFace_Click; break;
							case "buttonDroolingFace": newButton.Click += ButtonDroolingFace_Click; break;
							case "buttonSleepingFace": newButton.Click += ButtonSleepingFace_Click; break;
							case "buttonFaceWithMedicalMask": newButton.Click += ButtonFaceWithMedicalMask_Click; break;
							case "buttonFaceWithThermometer": newButton.Click += ButtonFaceWithThermometer_Click; break;
							case "buttonFaceWithHeadBandage": newButton.Click += ButtonFaceWithHeadBandage_Click; break;
							case "buttonNauseatedFace": newButton.Click += ButtonNauseatedFace_Click; break;
							case "buttonFaceVomiting": newButton.Click += ButtonFaceVomiting_Click; break;
							case "buttonSneezingFace": newButton.Click += ButtonSneezingFace_Click; break;
							case "buttonHotFace": newButton.Click += ButtonHotFace_Click; break;
							case "buttonColdFace": newButton.Click += ButtonColdFace_Click; break;
							case "buttonWoozyFace": newButton.Click += ButtonWoozyFace_Click; break;
							case "buttonDizzyFace": newButton.Click += ButtonDizzyFace_Click; break;
							case "buttonExplodingHead": newButton.Click += ButtonExplodingHead_Click; break;
							case "buttonCowboyHatFace": newButton.Click += ButtonCowboyHatFace_Click; break;
							case "buttonPartyingFace": newButton.Click += ButtonPartyingFace_Click; break;
							case "buttonDisguisedFace": newButton.Click += ButtonDisguisedFace_Click; break;
							case "buttonSmilingFaceWithSunglasses": newButton.Click += ButtonSmilingFaceWithSunglasses_Click; break;
							case "buttonNerdFace": newButton.Click += ButtonNerdFace_Click; break;
							case "buttonFaceWithMonocle": newButton.Click += ButtonFaceWithMonocle_Click; break;
							case "buttonConfusedFace": newButton.Click += ButtonConfusedFace_Click; break;
							case "buttonWorriedFace": newButton.Click += ButtonWorriedFace_Click; break;
							case "buttonSlightlyFrowningFace": newButton.Click += ButtonSlightlyFrowningFace_Click; break;
							case "buttonFrowningFace": newButton.Click += ButtonFrowningFace_Click; break;
							case "buttonFaceWithOpenMouth": newButton.Click += ButtonFaceWithOpenMouth_Click; break;
							case "buttonHushedFace": newButton.Click += ButtonHushedFace_Click; break;
							case "buttonAstonishedFace": newButton.Click += ButtonAstonishedFace_Click; break;
							case "buttonFlushedFace": newButton.Click += ButtonFlushedFace_Click; break;
							case "buttonPleadingFace": newButton.Click += ButtonPleadingFace_Click; break;
							case "buttonFrowningFaceWithOpenMouth": newButton.Click += ButtonFrowningFaceWithOpenMouth_Click; break;
							case "buttonAnguishedFace": newButton.Click += ButtonAnguishedFace_Click; break;
							case "buttonFearfulFace": newButton.Click += ButtonFearfulFace_Click; break;
							case "buttonAnxiousFaceWithSweat": newButton.Click += ButtonAnxiousFaceWithSweat_Click; break;
							case "buttonSadButRelievedFace": newButton.Click += ButtonSadButRelievedFace_Click; break;
							case "buttonCryingFace": newButton.Click += ButtonCryingFace_Click; break;
							case "buttonLoudlyCryingFace": newButton.Click += ButtonLoudlyCryingFace_Click; break;
							case "buttonFaceScreamingInFear": newButton.Click += ButtonFaceScreamingInFear_Click; break;
							case "buttonConfoundedFace": newButton.Click += ButtonConfoundedFace_Click; break;
							case "buttonPerseveringFace": newButton.Click += ButtonPerseveringFace_Click; break;
							case "buttonDisappointedFace": newButton.Click += ButtonDisappointedFace_Click; break;
							case "buttonDowncastFaceWithSweat": newButton.Click += ButtonGrinningFace_Click; break;
							case "buttonWearyFace": newButton.Click += ButtonWearyFace_Click; break;
							case "buttonTiredFace": newButton.Click += ButtonTiredFace_Click; break;
							case "buttonYawningFace": newButton.Click += ButtonYawningFace_Click; break;
							case "buttonFaceWithSteamFromNose": newButton.Click += ButtonFaceWithSteamFromNose_Click; break;
							case "buttonPoutingFace": newButton.Click += ButtonPoutingFace_Click; break;
							case "buttonAngryFace": newButton.Click += ButtonAngryFace_Click; break;
							case "buttonFaceWithSymbolsOnMouth": newButton.Click += ButtonFaceWithSymbolsOnMouth_Click; break;
							case "buttonSmilingFaceWithHorns": newButton.Click += ButtonSmilingFaceWithHorns_Click; break;
							case "buttonAngryFaceWithHorns": newButton.Click += ButtonAngryFaceWithHorns_Click; break;
							case "buttonSkull": newButton.Click += ButtonSkull_Click; break;
							case "buttonSkullAndCrossbones": newButton.Click += ButtonSkullAndCrossbones_Click; break;
							case "buttonPileOfPoo": newButton.Click += ButtonPileOfPoo_Click; break;
							case "buttonClownFace": newButton.Click += ButtonClownFace_Click; break;
							case "buttonOgre": newButton.Click += ButtonOgre_Click; break;
							case "buttonGoblin": newButton.Click += ButtonGoblin_Click; break;
							case "buttonGhost": newButton.Click += ButtonGhost_Click; break;
							case "buttonAlien": newButton.Click += ButtonAlien_Click; break;
							case "buttonAlienMonster": newButton.Click += ButtonAlienMonster_Click; break;
							case "buttonRobot": newButton.Click += ButtonRobot_Click; break;
							case "buttonGrinningCat": newButton.Click += ButtonGrinningCat_Click; break;
							case "buttonGrinningCatWithSmilingEyes": newButton.Click += Button_Click; break;
							case "buttonCatWithTearsOfJoy": newButton.Click += ButtonCatWithTearsOfJoy_Click; break;
							case "buttonSmilingCatWithHeartEyes": newButton.Click += ButtonSmilingCatWithHeartEyes_Click; break;
							case "buttonCatWithWrySmile": newButton.Click += ButtonCatWithWrySmile_Click; break;
							case "buttonKissingCat": newButton.Click += ButtonKissingCat_Click; break;
							case "buttonWearyCat": newButton.Click += ButtonWearyCat_Click; break;
							case "buttonCryingCat": newButton.Click += ButtonCryingCat_Click; break;
							case "buttonPoutingCat": newButton.Click += ButtonPoutingCat_Click; break;
							case "buttonSeeNoEvilMonkey": newButton.Click += ButtonSeeNoEvilMonkey_Click; break;
							case "buttonHearNoEvilMonkey": newButton.Click += ButtonHearNoEvilMonkey_Click; break;
							case "buttonSpeakNoEvilMonkey": newButton.Click += ButtonSpeakNoEvilMonkey_Click; break;
							case "buttonKissMark": newButton.Click += ButtonKissMark_Click; break;
							case "buttonLoveLetter": newButton.Click += ButtonLoveLetter_Click; break;
							case "buttonHeartWithArrow": newButton.Click += ButtonHeartWithArrow_Click; break;
							case "buttonHeartWithRibbon": newButton.Click += ButtonHeartWithRibbon_Click; break;
							case "buttonSparklingHeart": newButton.Click += ButtonSparklingHeart_Click; break;
							case "buttonGrowingHeart": newButton.Click += ButtonGrowingHeart_Click; break;
							case "buttonBeatingHeart": newButton.Click += ButtonBeatingHeart_Click; break;
							case "buttonRevolvingHearts": newButton.Click += ButtonRevolvingHearts_Click; break;
							case "buttonTwoHearts": newButton.Click += ButtonTwoHearts_Click; break;
							case "buttonHeartDecoration": newButton.Click += ButtonHeartDecoration_Click; break;
							case "buttonHeartExclamation": newButton.Click += ButtonHeartExclamation_Click; break;
							case "buttonBrokenHeart": newButton.Click += ButtonBrokenHeart_Click; break;
							case "buttonRedHeart": newButton.Click += ButtonRedHeart_Click; break;
							case "buttonOrangeHeart": newButton.Click += ButtonOrangeHeart_Click; break;
							case "buttonYellowHeart": newButton.Click += ButtonYellowHeart_Click; break;
							case "buttonGreenHeart": newButton.Click += ButtonGreenHeart_Click; break;
							case "buttonBlueHeart": newButton.Click += ButtonBlueHeart_Click; break;
							case "buttonPurpleHeart": newButton.Click += ButtonPurpleHeart_Click; break;
							case "buttonBrownHeart": newButton.Click += ButtonBrownHeart_Click; break;
							case "buttonBlackHeart": newButton.Click += ButtonBlackHeart_Click; break;
							case "buttonWhiteHeart": newButton.Click += ButtonWhiteHeart_Click; break;
							case "buttonHundredPoints": newButton.Click += ButtonHundredPoints_Click; break;
							case "buttonAngerSymbol": newButton.Click += ButtonAngerSymbol_Click; break;
							case "buttonCollision": newButton.Click += ButtonCollision_Click; break;
							case "buttonDizzy": newButton.Click += ButtonDizzy_Click; break;
							case "buttonSweatDroplets": newButton.Click += ButtonSweatDroplets_Click; break;
							case "buttonDashingAway": newButton.Click += ButtonDashingAway_Click; break;
							case "buttonHole": newButton.Click += ButtonHole_Click; break;
							case "buttonBomb": newButton.Click += ButtonBomb_Click; break;
							case "buttonSpeechBalloon": newButton.Click += ButtonSpeechBalloon_Click; break;
							case "buttonEyeInSpeechBubble": newButton.Click += ButtonEyeInSpeechBubble_Click; break;
							case "buttonLeftSpeechBubble": newButton.Click += ButtonLeftSpeechBubble_Click; break;
							case "buttonRightAngerBubble": newButton.Click += ButtonRightAngerBubble_Click; break;
							case "buttonThoughtBalloon": newButton.Click += ButtonThoughtBalloon_Click; break;
							default: newButton.Click += Button_Click; break;
						}
						buttons.Capacity = capacity;
						buttons.Add(newButton);
					}
				}
				if (capacity > 0)
				{
					for (int i = 0; i < buttons.Capacity; i++)
					{
						flowLayoutPanelSearchResult.Controls.Add(buttons[i]);
					}
				}
				else
				{
					toolStripProgressBar.Visible = false;
					toolStripButtonClearAll.Visible = true;
					MessageBox.Show(Resources.nothingFound, Resources.warningTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				}
			}
			else
			{
				toolStripProgressBar.Visible = false;
				toolStripButtonClearAll.Visible = true;
				MessageBox.Show(Resources.pleaseEnterASearchTerm, Resources.warningTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
			}
			toolStripProgressBar.Visible = false;
			toolStripButtonClearAll.Visible = true;
		}

		private void ButtonClearAll_Click(object sender, EventArgs e)
		{
			flowLayoutPanelSearchResult.Controls.Clear();
			textBoxSearch.Text = "";
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			CopyToClipboard(button.Tag.ToString());
		}

		private void ButtonGrinningFace_Click(object sender, EventArgs e) => ShowEmojiInfo2(emoji: EmojiSet.grinningFace);

		private void ButtonGrinningFaceWithBigEyes_Click(object sender, EventArgs e) => ShowEmojiInfo2(emoji: EmojiSet.grinningFaceWithBigEyes);

		private void ButtonGrinningFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningFaceWithSmilingEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F604", buttonGrinningFaceWithSmilingEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonGrinningFaceWithSmilingEyes.Tag,
					FaceSmiling.GrinningFaceWithSmilingEyesApple,
					FaceSmiling.GrinningFaceWithSmilingEyesGoogle,
					FaceSmiling.GrinningFaceWithSmilingEyesFacebook,
					FaceSmiling.GrinningFaceWithSmilingEyesWindows,
					FaceSmiling.GrinningFaceWithSmilingEyesTwitter,
					FaceSmiling.GrinningFaceWithSmilingEyesJoyPixels,
					FaceSmiling.GrinningFaceWithSmilingEyesSamsung,
					FaceSmiling.GrinningFaceWithSmilingEyesGmail,
					null, null,
					FaceSmiling.GrinningFaceWithSmilingEyesSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonBeamingFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonBeamingFaceWithSmilingEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F601", buttonBeamingFaceWithSmilingEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonBeamingFaceWithSmilingEyes.Tag,
					FaceSmiling.BeamingFaceWithSmilingEyesApple,
					FaceSmiling.BeamingFaceWithSmilingEyesGoogle,
					FaceSmiling.BeamingFaceWithSmilingEyesFacebook,
					FaceSmiling.BeamingFaceWithSmilingEyesWindows,
					FaceSmiling.BeamingFaceWithSmilingEyesTwitter,
					FaceSmiling.BeamingFaceWithSmilingEyesJoyPixels,
					FaceSmiling.BeamingFaceWithSmilingEyesSamsung,
					FaceSmiling.BeamingFaceWithSmilingEyesGmail,
					FaceSmiling.BeamingFaceWithSmilingEyesDocomo,
					FaceSmiling.BeamingFaceWithSmilingEyesKddi,
					FaceSmiling.BeamingFaceWithSmilingEyesSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGrinningSquintingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningSquintingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F606", buttonGrinningSquintingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonGrinningSquintingFace.Tag,
					FaceSmiling.GrinningSquintingFaceApple,
					FaceSmiling.GrinningSquintingFaceGoogle,
					FaceSmiling.GrinningSquintingFaceFacebook,
					FaceSmiling.GrinningSquintingFaceWindows,
					FaceSmiling.GrinningSquintingFaceTwitter,
					FaceSmiling.GrinningSquintingFaceJoyPixels,
					FaceSmiling.GrinningSquintingFaceSamsung,
					FaceSmiling.GrinningSquintingFaceGmail,
					FaceSmiling.GrinningSquintingFaceDocomo,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGrinningFaceWithSweat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningFaceWithSweat.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F605", buttonGrinningFaceWithSweat.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonGrinningFaceWithSweat.Tag,
					FaceSmiling.GrinningFaceWithSweatApple,
					FaceSmiling.GrinningFaceWithSweatGoogle,
					FaceSmiling.GrinningFaceWithSweatFacebook,
					FaceSmiling.GrinningFaceWithSweatWindows,
					FaceSmiling.GrinningFaceWithSweatTwitter,
					FaceSmiling.GrinningFaceWithSweatJoyPixels,
					FaceSmiling.GrinningFaceWithSweatSamsung,
					FaceSmiling.GrinningFaceWithSweatGmail,
					FaceSmiling.GrinningFaceWithSweatDocomo,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonRollingOnTheFloorLaughing_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonRollingOnTheFloorLaughing.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F923", buttonRollingOnTheFloorLaughing.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonRollingOnTheFloorLaughing.Tag,
					FaceSmiling.RollingOnTheFloorLaughingApple,
					FaceSmiling.RollingOnTheFloorLaughingGoogle,
					FaceSmiling.RollingOnTheFloorLaughingFacebook,
					FaceSmiling.RollingOnTheFloorLaughingWindows,
					FaceSmiling.RollingOnTheFloorLaughingTwitter,
					FaceSmiling.RollingOnTheFloorLaughingJoyPixels,
					FaceSmiling.RollingOnTheFloorLaughingSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithTearsOfJoy_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithTearsOfJoy.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F602", buttonFaceWithTearsOfJoy.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonFaceWithTearsOfJoy.Tag,
					FaceSmiling.FaceWithTearsOfJoyApple,
					FaceSmiling.FaceWithTearsOfJoyGoogle,
					FaceSmiling.FaceWithTearsOfJoyFacebook,
					FaceSmiling.FaceWithTearsOfJoyWindows,
					FaceSmiling.FaceWithTearsOfJoyTwitter,
					FaceSmiling.FaceWithTearsOfJoyJoyPixels,
					FaceSmiling.FaceWithTearsOfJoySamsung,
					FaceSmiling.FaceWithTearsOfJoyGmail,
					null,
					FaceSmiling.FaceWithTearsOfJoyKddi,
					FaceSmiling.FaceWithTearsOfJoySoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSlightlySmilingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSlightlySmilingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F642", buttonSlightlySmilingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonSlightlySmilingFace.Tag,
					FaceSmiling.SlightlySmilingFaceApple,
					FaceSmiling.SlightlySmilingFaceGoogle,
					FaceSmiling.SlightlySmilingFaceFacebook,
					FaceSmiling.SlightlySmilingFaceWindows,
					FaceSmiling.SlightlySmilingFaceTwitter,
					FaceSmiling.SlightlySmilingFaceJoyPixels,
					FaceSmiling.SlightlySmilingFaceSamsung,
					FaceSmiling.SlightlySmilingFaceGmail,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonUpsideDownFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonUpsideDownFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F643", buttonUpsideDownFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonUpsideDownFace.Tag,
					FaceSmiling.UpsideDownFaceApple,
					FaceSmiling.UpsideDownFaceGoogle,
					FaceSmiling.UpsideDownFaceFacebook,
					FaceSmiling.UpsideDownFaceWindows,
					FaceSmiling.UpsideDownFaceTwitter,
					FaceSmiling.UpsideDownFaceJoyPixels,
					FaceSmiling.UpsideDownFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonWinkingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWinkingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F609", buttonWinkingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonWinkingFace.Tag,
					FaceSmiling.WinkingFaceApple,
					FaceSmiling.WinkingFaceGoogle,
					FaceSmiling.WinkingFaceFacebook,
					FaceSmiling.WinkingFaceWindows,
					FaceSmiling.WinkingFaceTwitter,
					FaceSmiling.WinkingFaceJoyPixels,
					FaceSmiling.WinkingFaceSamsung,
					FaceSmiling.WinkingFaceGmail,
					FaceSmiling.WinkingFaceDocomo,
					FaceSmiling.WinkingFaceKddi,
					FaceSmiling.WinkingFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithSmilingEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F60A", buttonSmilingFaceWithSmilingEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonSmilingFaceWithSmilingEyes.Tag,
					FaceSmiling.SmilingFaceWithSmilingEyesApple,
					FaceSmiling.SmilingFaceWithSmilingEyesGoogle,
					FaceSmiling.SmilingFaceWithSmilingEyesFacebook,
					FaceSmiling.SmilingFaceWithSmilingEyesWindows,
					FaceSmiling.SmilingFaceWithSmilingEyesTwitter,
					FaceSmiling.SmilingFaceWithSmilingEyesJoyPixels,
					FaceSmiling.SmilingFaceWithSmilingEyesSamsung,
					FaceSmiling.SmilingFaceWithSmilingEyesGmail,
					null,
					FaceSmiling.SmilingFaceWithSmilingEyesKddi,
					FaceSmiling.SmilingFaceWithSmilingEyesSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingFaceWithHalo_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithHalo.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F607", buttonSmilingFaceWithHalo.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonSmilingFaceWithHalo.Tag,
					FaceSmiling.SmilingFaceWithHaloApple,
					FaceSmiling.SmilingFaceWithHaloGoogle,
					FaceSmiling.SmilingFaceWithHaloFacebook,
					FaceSmiling.SmilingFaceWithHaloWindows,
					FaceSmiling.SmilingFaceWithHaloTwitter,
					FaceSmiling.SmilingFaceWithHaloJoyPixels,
					FaceSmiling.SmilingFaceWithHaloSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingFaceWithHearts_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithHearts.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F970", buttonSmilingFaceWithHearts.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonSmilingFaceWithHearts.Tag,
					FaceAffection.SmilingFaceWithHeartsApple,
					FaceAffection.SmilingFaceWithHeartsGoogle,
					FaceAffection.SmilingFaceWithHeartsFacebook,
					FaceAffection.SmilingFaceWithHeartsWindows,
					FaceAffection.SmilingFaceWithHeartsTwitter,
					FaceAffection.SmilingFaceWithHeartsJoyPixels,
					FaceAffection.SmilingFaceWithHeartsSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingFaceWithHeartEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithHeartEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F60D", buttonSmilingFaceWithHeartEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonSmilingFaceWithHeartEyes.Tag,
					FaceAffection.SmilingFaceWithHeartEyesApple,
					FaceAffection.SmilingFaceWithHeartEyesGoogle,
					FaceAffection.SmilingFaceWithHeartEyesFacebook,
					FaceAffection.SmilingFaceWithHeartEyesWindows,
					FaceAffection.SmilingFaceWithHeartEyesTwitter,
					FaceAffection.SmilingFaceWithHeartEyesJoyPixels,
					FaceAffection.SmilingFaceWithHeartEyesSamsung,
					FaceAffection.SmilingFaceWithHeartEyesGmail,
					FaceAffection.SmilingFaceWithHeartEyesDocomo,
					FaceAffection.SmilingFaceWithHeartEyesKddi,
					FaceAffection.SmilingFaceWithHeartEyesSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonStarStruck_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonStarStruck.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F929", buttonStarStruck.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonStarStruck.Tag,
					FaceAffection.StarStruckApple,
					FaceAffection.StarStruckGoogle,
					FaceAffection.StarStruckFacebook,
					FaceAffection.StarStruckWindows,
					FaceAffection.StarStruckTwitter,
					FaceAffection.StarStruckJoyPixels,
					FaceAffection.StarStruckSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceBlowingAKiss_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceBlowingAKiss.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F618", buttonFaceBlowingAKiss.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonFaceBlowingAKiss.Tag,
					FaceAffection.FaceBlowingAKissApple,
					FaceAffection.FaceBlowingAKissGoogle,
					FaceAffection.FaceBlowingAKissFacebook,
					FaceAffection.FaceBlowingAKissWindows,
					FaceAffection.FaceBlowingAKissTwitter,
					FaceAffection.FaceBlowingAKissJoyPixels,
					FaceAffection.FaceBlowingAKissSamsung,
					FaceAffection.FaceBlowingAKissGmail,
					null,
					FaceAffection.FaceBlowingAKissKddi,
					FaceAffection.FaceBlowingAKissSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonKissingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonKissingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F617", buttonKissingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonKissingFace.Tag,
					FaceAffection.KissingFaceApple,
					FaceAffection.KissingFaceGoogle,
					FaceAffection.KissingFaceFacebook,
					FaceAffection.KissingFaceWindows,
					FaceAffection.KissingFaceTwitter,
					FaceAffection.KissingFaceJoyPixels,
					FaceAffection.KissingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+263A", buttonSmilingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonSmilingFace.Tag,
					FaceAffection.SmilingFaceApple,
					FaceAffection.SmilingFaceGoogle,
					FaceAffection.SmilingFaceFacebook,
					FaceAffection.SmilingFaceWindows,
					FaceAffection.SmilingFaceTwitter,
					FaceAffection.SmilingFaceJoyPixels,
					FaceAffection.SmilingFaceSamsung,
					FaceAffection.SmilingFaceGmail,
					null,
					FaceAffection.SmilingFaceKddi,
					FaceAffection.SmilingFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonKissingFaceWithClosedEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonKissingFaceWithClosedEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F61A", buttonKissingFaceWithClosedEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonKissingFaceWithClosedEyes.Tag,
					FaceAffection.KissingFaceWithClosedEyesApple,
					FaceAffection.KissingFaceWithClosedEyesGoogle,
					FaceAffection.KissingFaceWithClosedEyesFacebook,
					FaceAffection.KissingFaceWithClosedEyesWindows,
					FaceAffection.KissingFaceWithClosedEyesTwitter,
					FaceAffection.KissingFaceWithClosedEyesJoyPixels,
					FaceAffection.KissingFaceWithClosedEyesSamsung,
					FaceAffection.KissingFaceWithClosedEyesGmail,
					null,
					FaceAffection.KissingFaceWithClosedEyesKddi,
					FaceAffection.KissingFaceWithClosedEyesSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonKissingFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonKissingFaceWithSmilingEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F619", buttonKissingFaceWithSmilingEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonKissingFaceWithSmilingEyes.Tag,
					FaceAffection.KissingFaceWithSmilingEyesApple,
					FaceAffection.KissingFaceWithSmilingEyesGoogle,
					FaceAffection.KissingFaceWithSmilingEyesFacebook,
					FaceAffection.KissingFaceWithSmilingEyesWindows,
					FaceAffection.KissingFaceWithSmilingEyesTwitter,
					FaceAffection.KissingFaceWithSmilingEyesJoyPixels,
					FaceAffection.KissingFaceWithSmilingEyesSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingFaceWithTear_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithTear.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F972", buttonSmilingFaceWithTear.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceAffection,
					buttonSmilingFaceWithTear.Tag,
					null,
					FaceAffection.SmilingFaceWithTearGoogle,
					null,
					null,
					null,
					FaceAffection.SmilingFaceWithTearJoyPixels,
					null,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceSavoringFood_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceSavoringFood.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F60B", buttonFaceSavoringFood.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceTongue,
					buttonFaceSavoringFood.Tag,
					FaceTongue.FaceSavoringFoodApple,
					FaceTongue.FaceSavoringFoodGoogle,
					FaceTongue.FaceSavoringFoodFacebook,
					FaceTongue.FaceSavoringFoodWindows,
					FaceTongue.FaceSavoringFoodTwitter,
					FaceTongue.FaceSavoringFoodJoyPixels,
					FaceTongue.FaceSavoringFoodSamsung,
					FaceTongue.FaceSavoringFoodGmail,
					FaceTongue.FaceSavoringFoodDocomo,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithTongue_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithTongue.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F61B", buttonFaceWithTongue.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceTongue,
					buttonFaceWithTongue.Tag,
					FaceTongue.FaceWithTongueApple,
					FaceTongue.FaceWithTongueGoogle,
					FaceTongue.FaceWithTongueFacebook,
					FaceTongue.FaceWithTongueWindows,
					FaceTongue.FaceWithTongueTwitter,
					FaceTongue.FaceWithTongueJoyPixels,
					FaceTongue.FaceWithTongueSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonWinkingFaceWithTongue_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWinkingFaceWithTongue.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F61C", buttonWinkingFaceWithTongue.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceTongue,
					buttonWinkingFaceWithTongue.Tag,
					FaceTongue.WinkingFaceWithTongueApple,
					FaceTongue.WinkingFaceWithTongueGoogle,
					FaceTongue.WinkingFaceWithTongueFacebook,
					FaceTongue.WinkingFaceWithTongueWindows,
					FaceTongue.WinkingFaceWithTongueTwitter,
					FaceTongue.WinkingFaceWithTongueJoyPixels,
					FaceTongue.WinkingFaceWithTongueSamsung,
					FaceTongue.WinkingFaceWithTongueGmail,
					FaceTongue.WinkingFaceWithTongueDocomo,
					FaceTongue.WinkingFaceWithTongueKddi,
					FaceTongue.WinkingFaceWithTongueSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonZanyFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonZanyFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F92A", buttonZanyFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceTongue,
					buttonZanyFace.Tag,
					FaceTongue.ZanyFaceApple,
					FaceTongue.ZanyFaceGoogle,
					FaceTongue.ZanyFaceFacebook,
					FaceTongue.ZanyFaceWindows,
					FaceTongue.ZanyFaceTwitter,
					FaceTongue.ZanyFaceJoyPixels,
					FaceTongue.ZanyFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSquintingFaceWithTongue_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSquintingFaceWithTongue.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F61D", buttonSquintingFaceWithTongue.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceTongue,
					buttonSquintingFaceWithTongue.Tag,
					FaceTongue.SquintingFaceWithTongueApple,
					FaceTongue.SquintingFaceWithTongueGoogle,
					FaceTongue.SquintingFaceWithTongueFacebook,
					FaceTongue.SquintingFaceWithTongueWindows,
					FaceTongue.SquintingFaceWithTongueTwitter,
					FaceTongue.SquintingFaceWithTongueJoyPixels,
					FaceTongue.SquintingFaceWithTongueSamsung,
					FaceTongue.SquintingFaceWithTongueGmail,
					null,
					null,
					FaceTongue.SquintingFaceWithTongueSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonMoneyMouthFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonMoneyMouthFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F911", buttonMoneyMouthFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceTongue,
					buttonMoneyMouthFace.Tag,
					FaceTongue.MoneyMouthFaceApple,
					FaceTongue.MoneyMouthFaceGoogle,
					FaceTongue.MoneyMouthFaceFacebook,
					FaceTongue.MoneyMouthFaceWindows,
					FaceTongue.MoneyMouthFaceTwitter,
					FaceTongue.MoneyMouthFaceJoyPixels,
					FaceTongue.MoneyMouthFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHuggingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHuggingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F917", buttonHuggingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceHand,
					buttonHuggingFace.Tag,
					FaceHand.HuggingFaceApple,
					FaceHand.HuggingFaceGoogle,
					FaceHand.HuggingFaceFacebook,
					FaceHand.HuggingFaceWindows,
					FaceHand.HuggingFaceTwitter,
					FaceHand.HuggingFaceJoyPixels,
					FaceHand.HuggingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithHandOverMouth_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithHandOverMouth.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F92D", buttonFaceWithHandOverMouth.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceHand,
					buttonFaceWithHandOverMouth.Tag,
					FaceHand.FaceWithHandOverMouthApple,
					FaceHand.FaceWithHandOverMouthGoogle,
					FaceHand.FaceWithHandOverMouthFacebook,
					FaceHand.FaceWithHandOverMouthWindows,
					FaceHand.FaceWithHandOverMouthTwitter,
					FaceHand.FaceWithHandOverMouthJoyPixels,
					FaceHand.FaceWithHandOverMouthSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonShushingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonShushingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F92B", buttonShushingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceHand,
					buttonShushingFace.Tag,
					FaceHand.ShushingFaceApple,
					FaceHand.ShushingFaceGoogle,
					FaceHand.ShushingFaceFacebook,
					FaceHand.ShushingFaceWindows,
					FaceHand.ShushingFaceTwitter,
					FaceHand.ShushingFaceJoyPixels,
					FaceHand.ShushingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonThinkingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonThinkingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F914", buttonThinkingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceHand,
					buttonThinkingFace.Tag,
					FaceHand.ThinkingFaceApple,
					FaceHand.ThinkingFaceGoogle,
					FaceHand.ThinkingFaceFacebook,
					FaceHand.ThinkingFaceWindows,
					FaceHand.ThinkingFaceTwitter,
					FaceHand.ThinkingFaceJoyPixels,
					FaceHand.ThinkingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonZipperMouthFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonZipperMouthFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F910", buttonZipperMouthFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonZipperMouthFace.Tag,
					FaceNeutralSkeptical.ZipperMouthFaceApple,
					FaceNeutralSkeptical.ZipperMouthFaceGoogle,
					FaceNeutralSkeptical.ZipperMouthFaceFacebook,
					FaceNeutralSkeptical.ZipperMouthFaceWindows,
					FaceNeutralSkeptical.ZipperMouthFaceTwitter,
					FaceNeutralSkeptical.ZipperMouthFaceJoyPixels,
					FaceNeutralSkeptical.ZipperMouthFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithRaisedEyebrow_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithRaisedEyebrow.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F928", buttonFaceWithRaisedEyebrow.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonFaceWithRaisedEyebrow.Tag,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowApple,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowGoogle,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowFacebook,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowWindows,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowTwitter,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowJoyPixels,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonNeutralFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonNeutralFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F610", buttonNeutralFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonNeutralFace.Tag,
					FaceNeutralSkeptical.NeutralFaceApple,
					FaceNeutralSkeptical.NeutralFaceGoogle,
					FaceNeutralSkeptical.NeutralFaceFacebook,
					FaceNeutralSkeptical.NeutralFaceWindows,
					FaceNeutralSkeptical.NeutralFaceTwitter,
					FaceNeutralSkeptical.NeutralFaceJoyPixels,
					FaceNeutralSkeptical.NeutralFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonExpressionlessFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonExpressionlessFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F611", buttonExpressionlessFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonExpressionlessFace.Tag,
					FaceNeutralSkeptical.ExpressionlessFaceApple,
					FaceNeutralSkeptical.ExpressionlessFaceGoogle,
					FaceNeutralSkeptical.ExpressionlessFaceFacebook,
					FaceNeutralSkeptical.ExpressionlessFaceWindows,
					FaceNeutralSkeptical.ExpressionlessFaceTwitter,
					FaceNeutralSkeptical.ExpressionlessFaceJoyPixels,
					FaceNeutralSkeptical.ExpressionlessFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithoutMouth_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithoutMouth.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F636", buttonFaceWithoutMouth.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonFaceWithoutMouth.Tag,
					FaceNeutralSkeptical.FaceWithoutMouthApple,
					FaceNeutralSkeptical.FaceWithoutMouthGoogle,
					FaceNeutralSkeptical.FaceWithoutMouthFacebook,
					FaceNeutralSkeptical.FaceWithoutMouthWindows,
					FaceNeutralSkeptical.FaceWithoutMouthTwitter,
					FaceNeutralSkeptical.FaceWithoutMouthJoyPixels,
					FaceNeutralSkeptical.FaceWithoutMouthSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmirkingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmirkingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F60F", buttonSmirkingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonSmirkingFace.Tag,
					FaceNeutralSkeptical.SmirkingFaceApple,
					FaceNeutralSkeptical.SmirkingFaceGoogle,
					FaceNeutralSkeptical.SmirkingFaceFacebook,
					FaceNeutralSkeptical.SmirkingFaceWindows,
					FaceNeutralSkeptical.SmirkingFaceTwitter,
					FaceNeutralSkeptical.SmirkingFaceJoyPixels,
					FaceNeutralSkeptical.SmirkingFaceSamsung,
					FaceNeutralSkeptical.SmirkingFaceGmail,
					FaceNeutralSkeptical.SmirkingFaceDocomo,
					FaceNeutralSkeptical.SmirkingFaceKddi,
					FaceNeutralSkeptical.SmirkingFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonUnamusedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonUnamusedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F612", buttonUnamusedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonUnamusedFace.Tag,
					FaceNeutralSkeptical.UnamusedFaceApple,
					FaceNeutralSkeptical.UnamusedFaceGoogle,
					FaceNeutralSkeptical.UnamusedFaceFacebook,
					FaceNeutralSkeptical.UnamusedFaceWindows,
					FaceNeutralSkeptical.UnamusedFaceTwitter,
					FaceNeutralSkeptical.UnamusedFaceJoyPixels,
					FaceNeutralSkeptical.UnamusedFaceSamsung,
					FaceNeutralSkeptical.UnamusedFaceGmail,
					FaceNeutralSkeptical.UnamusedFaceDocomo,
					FaceNeutralSkeptical.UnamusedFaceKddi,
					FaceNeutralSkeptical.UnamusedFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithRollingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithRollingEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F644", buttonFaceWithRollingEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonFaceWithRollingEyes.Tag,
					FaceNeutralSkeptical.FaceWithRollingEyesApple,
					FaceNeutralSkeptical.FaceWithRollingEyesGoogle,
					FaceNeutralSkeptical.FaceWithRollingEyesFacebook,
					FaceNeutralSkeptical.FaceWithRollingEyesWindows,
					FaceNeutralSkeptical.FaceWithRollingEyesTwitter,
					FaceNeutralSkeptical.FaceWithRollingEyesJoyPixels,
					FaceNeutralSkeptical.FaceWithRollingEyesSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGrimacingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrimacingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F62C", buttonGrimacingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonGrimacingFace.Tag,
					FaceNeutralSkeptical.GrimacingFaceApple,
					FaceNeutralSkeptical.GrimacingFaceGoogle,
					FaceNeutralSkeptical.GrimacingFaceFacebook,
					FaceNeutralSkeptical.GrimacingFaceWindows,
					FaceNeutralSkeptical.GrimacingFaceTwitter,
					FaceNeutralSkeptical.GrimacingFaceJoyPixels,
					FaceNeutralSkeptical.GrimacingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonLyingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonLyingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F925", buttonLyingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNeutralSkeptical,
					buttonLyingFace.Tag,
					FaceNeutralSkeptical.LyingFaceApple,
					FaceNeutralSkeptical.LyingFaceGoogle,
					FaceNeutralSkeptical.LyingFaceFacebook,
					FaceNeutralSkeptical.LyingFaceWindows,
					FaceNeutralSkeptical.LyingFaceTwitter,
					FaceNeutralSkeptical.LyingFaceJoyPixels,
					FaceNeutralSkeptical.LyingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonRelievedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonRelievedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F60C", buttonRelievedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSleepy,
					buttonRelievedFace.Tag,
					FaceSleepy.RelievedFaceApple,
					FaceSleepy.RelievedFaceGoogle,
					FaceSleepy.RelievedFaceFacebook,
					FaceSleepy.RelievedFaceWindows,
					FaceSleepy.RelievedFaceTwitter,
					FaceSleepy.RelievedFaceJoyPixels,
					FaceSleepy.RelievedFaceSamsung,
					FaceSleepy.RelievedFaceGmail,
					FaceSleepy.RelievedFaceDocomo,
					FaceSleepy.RelievedFaceKddi,
					FaceSleepy.RelievedFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonPensiveFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPensiveFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F614", buttonPensiveFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSleepy,
					buttonPensiveFace.Tag,
					FaceSleepy.PensiveFaceApple,
					FaceSleepy.PensiveFaceGoogle,
					FaceSleepy.PensiveFaceFacebook,
					FaceSleepy.PensiveFaceWindows,
					FaceSleepy.PensiveFaceTwitter,
					FaceSleepy.PensiveFaceJoyPixels,
					FaceSleepy.PensiveFaceSamsung,
					FaceSleepy.PensiveFaceGmail,
					FaceSleepy.PensiveFaceDocomo,
					FaceSleepy.PensiveFaceKddi,
					FaceSleepy.PensiveFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSleepyFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSleepyFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F62A", buttonSleepyFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSleepy,
					buttonSleepyFace.Tag,
					FaceSleepy.SleepyFaceApple,
					FaceSleepy.SleepyFaceGoogle,
					FaceSleepy.SleepyFaceFacebook,
					FaceSleepy.SleepyFaceWindows,
					FaceSleepy.SleepyFaceTwitter,
					FaceSleepy.SleepyFaceJoyPixels,
					FaceSleepy.SleepyFaceSamsung,
					FaceSleepy.SleepyFaceGmail,
					null,
					FaceSleepy.SleepyFaceKddi,
					FaceSleepy.SleepyFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonDroolingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonDroolingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F924", buttonDroolingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSleepy,
					buttonDroolingFace.Tag,
					FaceSleepy.DroolingFaceApple,
					FaceSleepy.DroolingFaceGoogle,
					FaceSleepy.DroolingFaceFacebook,
					FaceSleepy.DroolingFaceWindows,
					FaceSleepy.DroolingFaceTwitter,
					FaceSleepy.DroolingFaceJoyPixels,
					FaceSleepy.DroolingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSleepingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSleepingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F634", buttonSleepingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSleepy,
					buttonSleepingFace.Tag,
					FaceSleepy.SleepingFaceApple,
					FaceSleepy.SleepingFaceGoogle,
					FaceSleepy.SleepingFaceFacebook,
					FaceSleepy.SleepingFaceWindows,
					FaceSleepy.SleepingFaceTwitter,
					FaceSleepy.SleepingFaceJoyPixels,
					FaceSleepy.SleepingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithMedicalMask_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithMedicalMask.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F637", buttonFaceWithMedicalMask.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonFaceWithMedicalMask.Tag,
					FaceUnwell.FaceWithMedicalMaskApple,
					FaceUnwell.FaceWithMedicalMaskGoogle,
					FaceUnwell.FaceWithMedicalMaskFacebook,
					FaceUnwell.FaceWithMedicalMaskWindows,
					FaceUnwell.FaceWithMedicalMaskTwitter,
					FaceUnwell.FaceWithMedicalMaskJoyPixels,
					FaceUnwell.FaceWithMedicalMaskSamsung,
					FaceUnwell.FaceWithMedicalMaskGmail,
					null,
					FaceUnwell.FaceWithMedicalMaskKddi,
					FaceUnwell.FaceWithMedicalMaskSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithThermometer_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithThermometer.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F912", buttonFaceWithThermometer.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonFaceWithThermometer.Tag,
					FaceUnwell.FaceWithThermometerApple,
					FaceUnwell.FaceWithThermometerGoogle,
					FaceUnwell.FaceWithThermometerFacebook,
					FaceUnwell.FaceWithThermometerWindows,
					FaceUnwell.FaceWithThermometerTwitter,
					FaceUnwell.FaceWithThermometerJoyPixels,
					FaceUnwell.FaceWithThermometerSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithHeadBandage_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithHeadBandage.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F915", buttonFaceWithHeadBandage.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonFaceWithHeadBandage.Tag,
					FaceUnwell.FaceWithHeadBandageApple,
					FaceUnwell.FaceWithHeadBandageGoogle,
					FaceUnwell.FaceWithHeadBandageFacebook,
					FaceUnwell.FaceWithHeadBandageWindows,
					FaceUnwell.FaceWithHeadBandageTwitter,
					FaceUnwell.FaceWithHeadBandageJoyPixels,
					FaceUnwell.FaceWithHeadBandageSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonNauseatedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonNauseatedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F922", buttonNauseatedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonNauseatedFace.Tag,
					FaceUnwell.NauseatedFaceApple,
					FaceUnwell.NauseatedFaceGoogle,
					FaceUnwell.NauseatedFaceFacebook,
					FaceUnwell.NauseatedFaceWindows,
					FaceUnwell.NauseatedFaceTwitter,
					FaceUnwell.NauseatedFaceJoyPixels,
					FaceUnwell.NauseatedFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceVomiting_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceVomiting.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F92E", buttonFaceVomiting.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonFaceVomiting.Tag,
					FaceUnwell.FaceVomitingApple,
					FaceUnwell.FaceVomitingGoogle,
					FaceUnwell.FaceVomitingFacebook,
					FaceUnwell.FaceVomitingWindows,
					FaceUnwell.FaceVomitingTwitter,
					FaceUnwell.FaceVomitingJoyPixels,
					FaceUnwell.FaceVomitingSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSneezingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSneezingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F927", buttonSneezingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonSneezingFace.Tag,
					FaceUnwell.SneezingFaceApple,
					FaceUnwell.SneezingFaceGoogle,
					FaceUnwell.SneezingFaceFacebook,
					FaceUnwell.SneezingFaceWindows,
					FaceUnwell.SneezingFaceTwitter,
					FaceUnwell.SneezingFaceJoyPixels,
					FaceUnwell.SneezingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHotFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHotFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F975", buttonHotFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonHotFace.Tag,
					FaceUnwell.HotFaceApple,
					FaceUnwell.HotFaceGoogle,
					FaceUnwell.HotFaceFacebook,
					FaceUnwell.HotFaceWindows,
					FaceUnwell.HotFaceTwitter,
					FaceUnwell.HotFaceJoyPixels,
					FaceUnwell.HotFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonColdFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonColdFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F976", buttonColdFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonColdFace.Tag,
					FaceUnwell.ColdFaceApple,
					FaceUnwell.ColdFaceGoogle,
					FaceUnwell.ColdFaceFacebook,
					FaceUnwell.ColdFaceWindows,
					FaceUnwell.ColdFaceTwitter,
					FaceUnwell.ColdFaceJoyPixels,
					FaceUnwell.ColdFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonWoozyFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWoozyFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F974", buttonWoozyFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonWoozyFace.Tag,
					FaceUnwell.WoozyFaceApple,
					FaceUnwell.WoozyFaceGoogle,
					FaceUnwell.WoozyFaceFacebook,
					FaceUnwell.WoozyFaceWindows,
					FaceUnwell.WoozyFaceTwitter,
					FaceUnwell.WoozyFaceJoyPixels,
					FaceUnwell.WoozyFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonDizzyFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonDizzyFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F635", buttonDizzyFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonDizzyFace.Tag,
					FaceUnwell.DizzyFaceApple,
					FaceUnwell.DizzyFaceGoogle,
					FaceUnwell.DizzyFaceFacebook,
					FaceUnwell.DizzyFaceWindows,
					FaceUnwell.DizzyFaceTwitter,
					FaceUnwell.DizzyFaceJoyPixels,
					FaceUnwell.DizzyFaceSamsung,
					FaceUnwell.DizzyFaceGmail,
					FaceUnwell.DizzyFaceDocomo,
					FaceUnwell.DizzyFaceKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonExplodingHead_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonExplodingHead.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F92F", buttonExplodingHead.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceUnwell,
					buttonExplodingHead.Tag,
					FaceUnwell.ExplodingHeadApple,
					FaceUnwell.ExplodingHeadGoogle,
					FaceUnwell.ExplodingHeadFacebook,
					FaceUnwell.ExplodingHeadWindows,
					FaceUnwell.ExplodingHeadTwitter,
					FaceUnwell.ExplodingHeadJoyPixels,
					FaceUnwell.ExplodingHeadSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonCowboyHatFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonCowboyHatFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F920", buttonCowboyHatFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceHat,
					buttonCowboyHatFace.Tag,
					FaceHat.CowboyHatFaceApple,
					FaceHat.CowboyHatFaceGoogle,
					FaceHat.CowboyHatFaceFacebook,
					FaceHat.CowboyHatFaceWindows,
					FaceHat.CowboyHatFaceTwitter,
					FaceHat.CowboyHatFaceJoyPixels,
					FaceHat.CowboyHatFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonPartyingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPartyingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F973", buttonPartyingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceHat,
					buttonPartyingFace.Tag,
					FaceHat.PartyingFaceApple,
					FaceHat.PartyingFaceGoogle,
					FaceHat.PartyingFaceFacebook,
					FaceHat.PartyingFaceWindows,
					FaceHat.PartyingFaceTwitter,
					FaceHat.PartyingFaceJoyPixels,
					FaceHat.PartyingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonDisguisedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonDisguisedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F978", buttonDisguisedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceGlasses,
					buttonDisguisedFace.Tag,
					null,
					FaceHat.DisguisedFaceGoogle,
					null,
					null,
					null,
					FaceHat.DisguisedFaceJoyPixels,
					null,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingFaceWithSunglasses_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithSunglasses.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F60E", buttonSmilingFaceWithSunglasses.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceGlasses,
					buttonSmilingFaceWithSunglasses.Tag,
					FaceGlasses.SmilingFaceWithSunglassesApple,
					FaceGlasses.SmilingFaceWithSunglassesGoogle,
					FaceGlasses.SmilingFaceWithSunglassesFacebook,
					FaceGlasses.SmilingFaceWithSunglassesWindows,
					FaceGlasses.SmilingFaceWithSunglassesTwitter,
					FaceGlasses.SmilingFaceWithSunglassesJoyPixels,
					FaceGlasses.SmilingFaceWithSunglassesSamsung,
					FaceGlasses.SmilingFaceWithSunglassesGmail,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonNerdFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonNerdFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F913", buttonNerdFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceGlasses,
					buttonNerdFace.Tag,
					FaceGlasses.NerdFaceApple,
					FaceGlasses.NerdFaceGoogle,
					FaceGlasses.NerdFaceFacebook,
					FaceGlasses.NerdFaceWindows,
					FaceGlasses.NerdFaceTwitter,
					FaceGlasses.NerdFaceJoyPixels,
					FaceGlasses.NerdFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithMonocle_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithMonocle.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F9D0", buttonFaceWithMonocle.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceGlasses,
					buttonFaceWithMonocle.Tag,
					FaceGlasses.FaceWithMonocleApple,
					FaceGlasses.FaceWithMonocleGoogle,
					FaceGlasses.FaceWithMonocleFacebook,
					FaceGlasses.FaceWithMonocleWindows,
					FaceGlasses.FaceWithMonocleTwitter,
					FaceGlasses.FaceWithMonocleJoyPixels,
					FaceGlasses.FaceWithMonocleSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonConfusedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonConfusedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F615", buttonConfusedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonFaceWithMonocle.Tag,
					FaceConcerned.ConfusedFaceApple,
					FaceConcerned.ConfusedFaceGoogle,
					FaceConcerned.ConfusedFaceFacebook,
					FaceConcerned.ConfusedFaceWindows,
					FaceConcerned.ConfusedFaceTwitter,
					FaceConcerned.ConfusedFaceJoyPixels,
					FaceConcerned.ConfusedFaceSamsung,
					FaceConcerned.ConfusedFaceGmail,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonWorriedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWorriedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F61F", buttonWorriedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonWorriedFace.Tag,
					FaceConcerned.WorriedFaceApple,
					FaceConcerned.WorriedFaceGoogle,
					FaceConcerned.WorriedFaceFacebook,
					FaceConcerned.WorriedFaceWindows,
					FaceConcerned.WorriedFaceTwitter,
					FaceConcerned.WorriedFaceJoyPixels,
					FaceConcerned.WorriedFaceSamsung,
					FaceConcerned.WorriedFaceGmail,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSlightlyFrowningFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSlightlyFrowningFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F641", buttonSlightlyFrowningFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonSlightlyFrowningFace.Tag,
					FaceConcerned.SlightlyFrowningFaceApple,
					FaceConcerned.SlightlyFrowningFaceGoogle,
					FaceConcerned.SlightlyFrowningFaceFacebook,
					FaceConcerned.SlightlyFrowningFaceWindows,
					FaceConcerned.SlightlyFrowningFaceTwitter,
					FaceConcerned.SlightlyFrowningFaceJoyPixels,
					FaceConcerned.SlightlyFrowningFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFrowningFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFrowningFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+2639", buttonFrowningFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonFrowningFace.Tag,
					FaceConcerned.FrowningFaceApple,
					FaceConcerned.FrowningFaceGoogle,
					FaceConcerned.FrowningFaceFacebook,
					FaceConcerned.FrowningFaceWindows,
					FaceConcerned.FrowningFaceTwitter,
					FaceConcerned.FrowningFaceJoyPixels,
					FaceConcerned.FrowningFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithOpenMouth_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithOpenMouth.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F62E", buttonFaceWithOpenMouth.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonFaceWithOpenMouth.Tag,
					FaceConcerned.FaceWithOpenMouthApple,
					FaceConcerned.FaceWithOpenMouthGoogle,
					FaceConcerned.FaceWithOpenMouthFacebook,
					FaceConcerned.FaceWithOpenMouthWindows,
					FaceConcerned.FaceWithOpenMouthTwitter,
					FaceConcerned.FaceWithOpenMouthJoyPixels,
					FaceConcerned.FaceWithOpenMouthSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHushedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHushedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F62F", buttonHushedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonHushedFace.Tag,
					FaceConcerned.HushedFaceApple,
					FaceConcerned.HushedFaceGoogle,
					FaceConcerned.HushedFaceFacebook,
					FaceConcerned.HushedFaceWindows,
					FaceConcerned.HushedFaceTwitter,
					FaceConcerned.HushedFaceJoyPixels,
					FaceConcerned.HushedFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonAstonishedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonAstonishedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F632", buttonAstonishedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonAstonishedFace.Tag,
					FaceConcerned.AstonishedFaceApple,
					FaceConcerned.AstonishedFaceGoogle,
					FaceConcerned.AstonishedFaceFacebook,
					FaceConcerned.AstonishedFaceWindows,
					FaceConcerned.AstonishedFaceTwitter,
					FaceConcerned.AstonishedFaceJoyPixels,
					FaceConcerned.AstonishedFaceSamsung,
					FaceConcerned.AstonishedFaceGmail,
					null,
					FaceConcerned.AstonishedFaceKddi,
					FaceConcerned.AstonishedFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFlushedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFlushedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F633", buttonFlushedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonFlushedFace.Tag,
					FaceConcerned.FlushedFaceApple,
					FaceConcerned.FlushedFaceGoogle,
					FaceConcerned.FlushedFaceFacebook,
					FaceConcerned.FlushedFaceWindows,
					FaceConcerned.FlushedFaceTwitter,
					FaceConcerned.FlushedFaceJoyPixels,
					FaceConcerned.FlushedFaceSamsung,
					FaceConcerned.FlushedFaceGmail,
					null,
					FaceConcerned.FlushedFaceKddi,
					FaceConcerned.FlushedFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonPleadingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPleadingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F97A", buttonPleadingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonPleadingFace.Tag,
					FaceConcerned.PleadingFaceApple,
					FaceConcerned.PleadingFaceGoogle,
					FaceConcerned.PleadingFaceFacebook,
					FaceConcerned.PleadingFaceWindows,
					FaceConcerned.PleadingFaceTwitter,
					FaceConcerned.PleadingFaceJoyPixels,
					FaceConcerned.PleadingFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFrowningFaceWithOpenMouth_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFrowningFaceWithOpenMouth.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F626", buttonFrowningFaceWithOpenMouth.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonFrowningFaceWithOpenMouth.Tag,
					FaceConcerned.FrowningFaceWithOpenMouthApple,
					FaceConcerned.FrowningFaceWithOpenMouthGoogle,
					FaceConcerned.FrowningFaceWithOpenMouthFacebook,
					FaceConcerned.FrowningFaceWithOpenMouthWindows,
					FaceConcerned.FrowningFaceWithOpenMouthTwitter,
					FaceConcerned.FrowningFaceWithOpenMouthJoyPixels,
					FaceConcerned.FrowningFaceWithOpenMouthSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonAnguishedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonAnguishedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F627", buttonAnguishedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonAnguishedFace.Tag,
					FaceConcerned.AnguishedFaceApple,
					FaceConcerned.AnguishedFaceGoogle,
					FaceConcerned.AnguishedFaceFacebook,
					FaceConcerned.AnguishedFaceWindows,
					FaceConcerned.AnguishedFaceTwitter,
					FaceConcerned.AnguishedFaceJoyPixels,
					FaceConcerned.AnguishedFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFearfulFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFearfulFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F628", buttonFearfulFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonFearfulFace.Tag,
					FaceConcerned.FearfulFaceApple,
					FaceConcerned.FearfulFaceGoogle,
					FaceConcerned.FearfulFaceFacebook,
					FaceConcerned.FearfulFaceWindows,
					FaceConcerned.FearfulFaceTwitter,
					FaceConcerned.FearfulFaceJoyPixels,
					FaceConcerned.FearfulFaceSamsung,
					FaceConcerned.FearfulFaceGmail,
					null,
					FaceConcerned.FearfulFaceKddi,
					FaceConcerned.FearfulFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonAnxiousFaceWithSweat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonAnxiousFaceWithSweat.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F630", buttonAnxiousFaceWithSweat.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonAnxiousFaceWithSweat.Tag,
					FaceConcerned.AnxiousFaceWithSweatApple,
					FaceConcerned.AnxiousFaceWithSweatGoogle,
					FaceConcerned.AnxiousFaceWithSweatFacebook,
					FaceConcerned.AnxiousFaceWithSweatWindows,
					FaceConcerned.AnxiousFaceWithSweatTwitter,
					FaceConcerned.AnxiousFaceWithSweatJoyPixels,
					FaceConcerned.AnxiousFaceWithSweatSamsung,
					FaceConcerned.AnxiousFaceWithSweatGmail,
					null,
					FaceConcerned.AnxiousFaceWithSweatKddi,
					FaceConcerned.AnxiousFaceWithSweatSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSadButRelievedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSadButRelievedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F625", buttonSadButRelievedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonSadButRelievedFace.Tag,
					FaceConcerned.SadButRelievedFaceApple,
					FaceConcerned.SadButRelievedFaceGoogle,
					FaceConcerned.SadButRelievedFaceFacebook,
					FaceConcerned.SadButRelievedFaceWindows,
					FaceConcerned.SadButRelievedFaceTwitter,
					FaceConcerned.SadButRelievedFaceJoyPixels,
					FaceConcerned.SadButRelievedFaceSamsung,
					FaceConcerned.SadButRelievedFaceGmail,
					null,
					null,
					FaceConcerned.SadButRelievedFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonCryingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonCryingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F622", buttonCryingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonCryingFace.Tag,
					FaceConcerned.CryingFaceApple,
					FaceConcerned.CryingFaceGoogle,
					FaceConcerned.CryingFaceFacebook,
					FaceConcerned.CryingFaceWindows,
					FaceConcerned.CryingFaceTwitter,
					FaceConcerned.CryingFaceJoyPixels,
					FaceConcerned.CryingFaceSamsung,
					FaceConcerned.CryingFaceGmail,
					FaceConcerned.CryingFaceDocomo,
					FaceConcerned.CryingFaceKddi,
					FaceConcerned.CryingFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonLoudlyCryingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonLoudlyCryingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F62D", buttonLoudlyCryingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonLoudlyCryingFace.Tag,
					FaceConcerned.LoudlyCryingFaceApple,
					FaceConcerned.LoudlyCryingFaceGoogle,
					FaceConcerned.LoudlyCryingFaceFacebook,
					FaceConcerned.LoudlyCryingFaceWindows,
					FaceConcerned.LoudlyCryingFaceTwitter,
					FaceConcerned.LoudlyCryingFaceJoyPixels,
					FaceConcerned.LoudlyCryingFaceSamsung,
					FaceConcerned.LoudlyCryingFaceGmail,
					FaceConcerned.LoudlyCryingFaceDocomo,
					FaceConcerned.LoudlyCryingFaceKddi,
					FaceConcerned.LoudlyCryingFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceScreamingInFear_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceScreamingInFear.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F631", buttonFaceScreamingInFear.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonFaceScreamingInFear.Tag,
					FaceConcerned.FaceScreamingInFearApple,
					FaceConcerned.FaceScreamingInFearGoogle,
					FaceConcerned.FaceScreamingInFearFacebook,
					FaceConcerned.FaceScreamingInFearWindows,
					FaceConcerned.FaceScreamingInFearTwitter,
					FaceConcerned.FaceScreamingInFearJoyPixels,
					FaceConcerned.FaceScreamingInFearSamsung,
					FaceConcerned.FaceScreamingInFearGmail,
					FaceConcerned.FaceScreamingInFearDocomo,
					FaceConcerned.FaceScreamingInFearKddi,
					FaceConcerned.FaceScreamingInFearSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonConfoundedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonConfoundedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F616", buttonConfoundedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonConfoundedFace.Tag,
					FaceConcerned.ConfoundedFaceApple,
					FaceConcerned.ConfoundedFaceGoogle,
					FaceConcerned.ConfoundedFaceFacebook,
					FaceConcerned.ConfoundedFaceWindows,
					FaceConcerned.ConfoundedFaceTwitter,
					FaceConcerned.ConfoundedFaceJoyPixels,
					FaceConcerned.ConfoundedFaceSamsung,
					FaceConcerned.ConfoundedFaceGmail,
					FaceConcerned.ConfoundedFaceDocomo,
					FaceConcerned.ConfoundedFaceKddi,
					FaceConcerned.ConfoundedFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonPerseveringFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPerseveringFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F623", buttonPerseveringFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonPerseveringFace.Tag,
					FaceConcerned.PerseveringFaceApple,
					FaceConcerned.PerseveringFaceGoogle,
					FaceConcerned.PerseveringFaceFacebook,
					FaceConcerned.PerseveringFaceWindows,
					FaceConcerned.PerseveringFaceTwitter,
					FaceConcerned.PerseveringFaceJoyPixels,
					FaceConcerned.PerseveringFaceSamsung,
					FaceConcerned.PerseveringFaceGmail,
					FaceConcerned.PerseveringFaceDocomo,
					FaceConcerned.PerseveringFaceKddi,
					FaceConcerned.PerseveringFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonDisappointedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonDisappointedFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F61E", buttonDisappointedFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonDisappointedFace.Tag,
					FaceConcerned.DisappointedFaceApple,
					FaceConcerned.DisappointedFaceGoogle,
					FaceConcerned.DisappointedFaceFacebook,
					FaceConcerned.DisappointedFaceWindows,
					FaceConcerned.DisappointedFaceTwitter,
					FaceConcerned.DisappointedFaceJoyPixels,
					FaceConcerned.DisappointedFaceSamsung,
					FaceConcerned.DisappointedFaceGmail,
					FaceConcerned.DisappointedFaceDocomo,
					null,
					FaceConcerned.DisappointedFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonDowncastFaceWithSweat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonDowncastFaceWithSweat.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F613", buttonDowncastFaceWithSweat.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonDowncastFaceWithSweat.Tag,
					FaceConcerned.DowncastFaceWithSweatApple,
					FaceConcerned.DowncastFaceWithSweatGoogle,
					FaceConcerned.DowncastFaceWithSweatFacebook,
					FaceConcerned.DowncastFaceWithSweatWindows,
					FaceConcerned.DowncastFaceWithSweatTwitter,
					FaceConcerned.DowncastFaceWithSweatJoyPixels,
					FaceConcerned.DowncastFaceWithSweatSamsung,
					FaceConcerned.DowncastFaceWithSweatGmail,
					FaceConcerned.DowncastFaceWithSweatDocomo,
					FaceConcerned.DowncastFaceWithSweatKddi,
					FaceConcerned.DowncastFaceWithSweatSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonWearyFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWearyFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F629", buttonWearyFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonWearyFace.Tag,
					FaceConcerned.WearyFaceApple,
					FaceConcerned.WearyFaceGoogle,
					FaceConcerned.WearyFaceFacebook,
					FaceConcerned.WearyFaceWindows,
					FaceConcerned.WearyFaceTwitter,
					FaceConcerned.WearyFaceJoyPixels,
					FaceConcerned.WearyFaceSamsung,
					FaceConcerned.WearyFaceGmail,
					null,
					FaceConcerned.WearyFaceKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonTiredFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonTiredFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F62B", buttonTiredFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonTiredFace.Tag,
					FaceConcerned.TiredFaceApple,
					FaceConcerned.TiredFaceGoogle,
					FaceConcerned.TiredFaceFacebook,
					FaceConcerned.TiredFaceWindows,
					FaceConcerned.TiredFaceTwitter,
					FaceConcerned.TiredFaceJoyPixels,
					FaceConcerned.TiredFaceSamsung,
					FaceConcerned.TiredFaceGmail,
					null,
					FaceConcerned.TiredFaceKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonYawningFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonYawningFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F971", buttonYawningFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceConcerned,
					buttonYawningFace.Tag,
					FaceConcerned.YawningFaceApple,
					FaceConcerned.YawningFaceGoogle,
					FaceConcerned.YawningFaceFacebook,
					FaceConcerned.YawningFaceWindows,
					FaceConcerned.YawningFaceTwitter,
					FaceConcerned.YawningFaceJoyPixels,
					FaceConcerned.YawningFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithSteamFromNose_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithSteamFromNose.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F624", buttonFaceWithSteamFromNose.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonFaceWithSteamFromNose.Tag,
					FaceNegative.FaceWithSteamFromNoseApple,
					FaceNegative.FaceWithSteamFromNoseGoogle,
					FaceNegative.FaceWithSteamFromNoseFacebook,
					FaceNegative.FaceWithSteamFromNoseWindows,
					FaceNegative.FaceWithSteamFromNoseTwitter,
					FaceNegative.FaceWithSteamFromNoseJoyPixels,
					FaceNegative.FaceWithSteamFromNoseSamsung,
					FaceNegative.FaceWithSteamFromNoseGmail,
					null,
					FaceNegative.FaceWithSteamFromNoseKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonPoutingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPoutingFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F621", buttonPoutingFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonPoutingFace.Tag,
					FaceNegative.PoutingFaceApple,
					FaceNegative.PoutingFaceGoogle,
					FaceNegative.PoutingFaceFacebook,
					FaceNegative.PoutingFaceWindows,
					FaceNegative.PoutingFaceTwitter,
					FaceNegative.PoutingFaceJoyPixels,
					FaceNegative.PoutingFaceSamsung,
					FaceNegative.PoutingFaceGmail,
					FaceNegative.PoutingFaceDocomo,
					FaceNegative.PoutingFaceKddi,
					FaceNegative.PoutingFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonAngryFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonAngryFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F620", buttonAngryFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonAngryFace.Tag,
					FaceNegative.AngryFaceApple,
					FaceNegative.AngryFaceGoogle,
					FaceNegative.AngryFaceFacebook,
					FaceNegative.AngryFaceWindows,
					FaceNegative.AngryFaceTwitter,
					FaceNegative.AngryFaceJoyPixels,
					FaceNegative.AngryFaceSamsung,
					FaceNegative.AngryFaceGmail,
					FaceNegative.AngryFaceDocomo,
					FaceNegative.AngryFaceKddi,
					FaceNegative.AngryFaceSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonFaceWithSymbolsOnMouth_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithSymbolsOnMouth.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F92C", buttonFaceWithSymbolsOnMouth.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonFaceWithSymbolsOnMouth.Tag,
					FaceNegative.FaceWithSymbolsOnMouthApple,
					FaceNegative.FaceWithSymbolsOnMouthGoogle,
					FaceNegative.FaceWithSymbolsOnMouthFacebook,
					FaceNegative.FaceWithSymbolsOnMouthWindows,
					FaceNegative.FaceWithSymbolsOnMouthTwitter,
					FaceNegative.FaceWithSymbolsOnMouthJoyPixels,
					FaceNegative.FaceWithSymbolsOnMouthSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingFaceWithHorns_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithHorns.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F608", buttonSmilingFaceWithHorns.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonSmilingFaceWithHorns.Tag,
					FaceNegative.SmilingFaceWithHornsApple,
					FaceNegative.SmilingFaceWithHornsGoogle,
					FaceNegative.SmilingFaceWithHornsFacebook,
					FaceNegative.SmilingFaceWithHornsWindows,
					FaceNegative.SmilingFaceWithHornsTwitter,
					FaceNegative.SmilingFaceWithHornsJoyPixels,
					FaceNegative.SmilingFaceWithHornsSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonAngryFaceWithHorns_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonAngryFaceWithHorns.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F47F", buttonAngryFaceWithHorns.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonAngryFaceWithHorns.Tag,
					FaceNegative.AngryFaceWithHornsApple,
					FaceNegative.AngryFaceWithHornsGoogle,
					FaceNegative.AngryFaceWithHornsFacebook,
					FaceNegative.AngryFaceWithHornsWindows,
					FaceNegative.AngryFaceWithHornsTwitter,
					FaceNegative.AngryFaceWithHornsJoyPixels,
					FaceNegative.AngryFaceWithHornsSamsung,
					FaceNegative.AngryFaceWithHornsGmail,
					null,
					FaceNegative.AngryFaceWithHornsKddi,
					FaceNegative.AngryFaceWithHornsSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSkull_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSkull.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F480", buttonSkull.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonSkull.Tag,
					FaceNegative.SkullApple,
					FaceNegative.SkullGoogle,
					FaceNegative.SkullFacebook,
					FaceNegative.SkullWindows,
					FaceNegative.SkullTwitter,
					FaceNegative.SkullJoyPixels,
					FaceNegative.SkullSamsung,
					FaceNegative.AngryFaceWithHornsGmail,
					null,
					FaceNegative.AngryFaceWithHornsKddi,
					FaceNegative.AngryFaceWithHornsSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSkullAndCrossbones_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSkullAndCrossbones.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F971", buttonSkullAndCrossbones.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonSkullAndCrossbones.Tag,
					FaceNegative.SkullAndCrossbonesApple,
					FaceNegative.SkullAndCrossbonesGoogle,
					FaceNegative.SkullAndCrossbonesFacebook,
					FaceNegative.SkullAndCrossbonesWindows,
					FaceNegative.SkullAndCrossbonesTwitter,
					FaceNegative.SkullAndCrossbonesJoyPixels,
					FaceNegative.SkullAndCrossbonesSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonPileOfPoo_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPileOfPoo.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4A9", buttonPileOfPoo.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceCostume,
					buttonPileOfPoo.Tag,
					FaceCostume.PileOfPooApple,
					FaceCostume.PileOfPooGoogle,
					FaceCostume.PileOfPooFacebook,
					FaceCostume.PileOfPooWindows,
					FaceCostume.PileOfPooTwitter,
					FaceCostume.PileOfPooJoyPixels,
					FaceCostume.PileOfPooSamsung,
					FaceCostume.PileOfPooGmail,
					null,
					FaceCostume.PileOfPooKddi,
					FaceCostume.PileOfPooSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonClownFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonClownFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F921", buttonClownFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonClownFace.Tag,
					FaceCostume.ClownFaceApple,
					FaceCostume.ClownFaceGoogle,
					FaceCostume.ClownFaceFacebook,
					FaceCostume.ClownFaceWindows,
					FaceCostume.ClownFaceTwitter,
					FaceCostume.ClownFaceJoyPixels,
					FaceCostume.ClownFaceSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonOgre_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonOgre.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F479", buttonOgre.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonOgre.Tag,
					FaceCostume.OgreApple,
					FaceCostume.OgreGoogle,
					FaceCostume.OgreFacebook,
					FaceCostume.OgreWindows,
					FaceCostume.OgreTwitter,
					FaceCostume.OgreJoyPixels,
					FaceCostume.OgreSamsung,
					FaceCostume.OgreGmail,
					null,
					FaceCostume.OgreKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGoblin_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGoblin.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F47A", buttonGoblin.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonGoblin.Tag,
					FaceCostume.GoblinApple,
					FaceCostume.GoblinGoogle,
					FaceCostume.GoblinFacebook,
					FaceCostume.GoblinWindows,
					FaceCostume.GoblinTwitter,
					FaceCostume.GoblinJoyPixels,
					FaceCostume.GoblinSamsung,
					FaceCostume.GoblinGmail,
					null,
					FaceCostume.GoblinKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGhost_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGhost.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F47B", buttonGhost.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonGhost.Tag,
					FaceCostume.GhostApple,
					FaceCostume.GhostGoogle,
					FaceCostume.GhostFacebook,
					FaceCostume.GhostWindows,
					FaceCostume.GhostTwitter,
					FaceCostume.GhostJoyPixels,
					FaceCostume.GhostSamsung,
					FaceCostume.GhostGmail,
					null,
					FaceCostume.GhostKddi,
					FaceCostume.GhostSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonAlien_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonAlien.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F47D", buttonAlien.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonAlien.Tag,
					FaceCostume.AlienApple,
					FaceCostume.AlienGoogle,
					FaceCostume.AlienFacebook,
					FaceCostume.AlienWindows,
					FaceCostume.AlienTwitter,
					FaceCostume.AlienJoyPixels,
					FaceCostume.AlienSamsung,
					FaceCostume.AlienGmail,
					null,
					FaceCostume.AlienKddi,
					FaceCostume.AlienSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonAlienMonster_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonAlienMonster.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F47E", buttonAlienMonster.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonAlienMonster.Tag,
					FaceCostume.AlienMonsterApple,
					FaceCostume.AlienMonsterGoogle,
					FaceCostume.AlienMonsterFacebook,
					FaceCostume.AlienMonsterWindows,
					FaceCostume.AlienMonsterTwitter,
					FaceCostume.AlienMonsterJoyPixels,
					FaceCostume.AlienMonsterSamsung,
					FaceCostume.AlienMonsterGmail,
					null,
					FaceCostume.AlienMonsterKddi,
					FaceCostume.AlienMonsterSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonRobot_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonRobot.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F916", buttonRobot.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceNegative,
					buttonRobot.Tag,
					FaceCostume.RobotApple,
					FaceCostume.RobotGoogle,
					FaceCostume.RobotFacebook,
					FaceCostume.RobotWindows,
					FaceCostume.RobotTwitter,
					FaceCostume.RobotJoyPixels,
					FaceCostume.RobotSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGrinningCat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningCat.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F63A", buttonGrinningCat.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonGrinningCat.Tag,
					CatFace.GrinningCatApple,
					CatFace.GrinningCatGoogle,
					CatFace.GrinningCatFacebook,
					CatFace.GrinningCatWindows,
					CatFace.GrinningCatTwitter,
					CatFace.GrinningCatJoyPixels,
					CatFace.GrinningCatSamsung,
					CatFace.GrinningCatGmail,
					null,
					CatFace.GrinningCatKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGrinningCatWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningCatWithSmilingEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F638", buttonGrinningCatWithSmilingEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonGrinningCatWithSmilingEyes.Tag,
					CatFace.GrinningCatWithSmilingEyesApple,
					CatFace.GrinningCatWithSmilingEyesGoogle,
					CatFace.GrinningCatWithSmilingEyesFacebook,
					CatFace.GrinningCatWithSmilingEyesWindows,
					CatFace.GrinningCatWithSmilingEyesTwitter,
					CatFace.GrinningCatWithSmilingEyesJoyPixels,
					CatFace.GrinningCatWithSmilingEyesSamsung,
					CatFace.GrinningCatWithSmilingEyesGmail,
					null,
					CatFace.GrinningCatWithSmilingEyesKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonCatWithTearsOfJoy_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonCatWithTearsOfJoy.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F639", buttonCatWithTearsOfJoy.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonCatWithTearsOfJoy.Tag,
					CatFace.CatWithTearsOfJoyApple,
					CatFace.CatWithTearsOfJoyGoogle,
					CatFace.CatWithTearsOfJoyFacebook,
					CatFace.CatWithTearsOfJoyWindows,
					CatFace.CatWithTearsOfJoyTwitter,
					CatFace.CatWithTearsOfJoyJoyPixels,
					CatFace.CatWithTearsOfJoySamsung,
					CatFace.CatWithTearsOfJoyGmail,
					null,
					CatFace.CatWithTearsOfJoyKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSmilingCatWithHeartEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingCatWithHeartEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F63B", buttonSmilingCatWithHeartEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonSmilingCatWithHeartEyes.Tag,
					CatFace.SmilingCatWithHeartEyesApple,
					CatFace.SmilingCatWithHeartEyesGoogle,
					CatFace.SmilingCatWithHeartEyesFacebook,
					CatFace.SmilingCatWithHeartEyesWindows,
					CatFace.SmilingCatWithHeartEyesTwitter,
					CatFace.SmilingCatWithHeartEyesJoyPixels,
					CatFace.SmilingCatWithHeartEyesSamsung,
					CatFace.SmilingCatWithHeartEyesGmail,
					null,
					CatFace.SmilingCatWithHeartEyesKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonCatWithWrySmile_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonCatWithWrySmile.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F63C", buttonCatWithWrySmile.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonCatWithWrySmile.Tag,
					CatFace.CatWithWrySmileApple,
					CatFace.CatWithWrySmileGoogle,
					CatFace.CatWithWrySmileFacebook,
					CatFace.CatWithWrySmileWindows,
					CatFace.CatWithWrySmileTwitter,
					CatFace.CatWithWrySmileJoyPixels,
					CatFace.CatWithWrySmileSamsung,
					CatFace.CatWithWrySmileGmail,
					null,
					CatFace.CatWithWrySmileKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonKissingCat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonKissingCat.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F63D", buttonKissingCat.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonKissingCat.Tag,
					CatFace.KissingCatApple,
					CatFace.KissingCatGoogle,
					CatFace.KissingCatFacebook,
					CatFace.KissingCatWindows,
					CatFace.KissingCatTwitter,
					CatFace.KissingCatJoyPixels,
					CatFace.KissingCatSamsung,
					CatFace.KissingCatGmail,
					null,
					CatFace.KissingCatKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonWearyCat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWearyCat.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F640", buttonWearyCat.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonWearyCat.Tag,
					CatFace.WearyCatApple,
					CatFace.WearyCatGoogle,
					CatFace.WearyCatFacebook,
					CatFace.WearyCatWindows,
					CatFace.WearyCatTwitter,
					CatFace.WearyCatJoyPixels,
					CatFace.WearyCatSamsung,
					CatFace.WearyCatGmail,
					null,
					CatFace.WearyCatKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonCryingCat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonCryingCat.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F63F", buttonCryingCat.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonCryingCat.Tag,
					CatFace.CryingCatApple,
					CatFace.CryingCatGoogle,
					CatFace.CryingCatFacebook,
					CatFace.CryingCatWindows,
					CatFace.CryingCatTwitter,
					CatFace.CryingCatJoyPixels,
					CatFace.CryingCatSamsung,
					CatFace.CryingCatGmail,
					null,
					CatFace.CryingCatKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonPoutingCat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPoutingCat.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F63E", buttonPoutingCat.AccessibleName,
					Resources.smileysAndEmotion, Resources.catFace,
					buttonPoutingCat.Tag,
					CatFace.PoutingCatApple,
					CatFace.PoutingCatGoogle,
					CatFace.PoutingCatFacebook,
					CatFace.PoutingCatWindows,
					CatFace.PoutingCatTwitter,
					CatFace.PoutingCatJoyPixels,
					CatFace.PoutingCatSamsung,
					CatFace.PoutingCatGmail,
					null,
					CatFace.PoutingCatKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSeeNoEvilMonkey_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSeeNoEvilMonkey.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F648", buttonSeeNoEvilMonkey.AccessibleName,
					Resources.smileysAndEmotion, Resources.monkeyFace,
					buttonSeeNoEvilMonkey.Tag,
					MonkeyFace.SeeNoEvilMonkeyApple,
					MonkeyFace.SeeNoEvilMonkeyGoogle,
					MonkeyFace.SeeNoEvilMonkeyFacebook,
					MonkeyFace.SeeNoEvilMonkeyWindows,
					MonkeyFace.SeeNoEvilMonkeyTwitter,
					MonkeyFace.SeeNoEvilMonkeyJoyPixels,
					MonkeyFace.SeeNoEvilMonkeySamsung,
					MonkeyFace.SeeNoEvilMonkeyGmail,
					null,
					MonkeyFace.SeeNoEvilMonkeyKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHearNoEvilMonkey_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHearNoEvilMonkey.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F649", buttonHearNoEvilMonkey.AccessibleName,
					Resources.smileysAndEmotion, Resources.monkeyFace,
					buttonHearNoEvilMonkey.Tag,
					MonkeyFace.HearNoEvilMonkeyApple,
					MonkeyFace.HearNoEvilMonkeyGoogle,
					MonkeyFace.HearNoEvilMonkeyFacebook,
					MonkeyFace.HearNoEvilMonkeyWindows,
					MonkeyFace.HearNoEvilMonkeyTwitter,
					MonkeyFace.HearNoEvilMonkeyJoyPixels,
					MonkeyFace.HearNoEvilMonkeySamsung,
					MonkeyFace.HearNoEvilMonkeyGmail,
					null,
					MonkeyFace.HearNoEvilMonkeyKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSpeakNoEvilMonkey_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSpeakNoEvilMonkey.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F64A", buttonSpeakNoEvilMonkey.AccessibleName,
					Resources.smileysAndEmotion, Resources.monkeyFace,
					buttonSpeakNoEvilMonkey.Tag,
					MonkeyFace.SpeakNoEvilMonkeyApple,
					MonkeyFace.SpeakNoEvilMonkeyGoogle,
					MonkeyFace.SpeakNoEvilMonkeyFacebook,
					MonkeyFace.SpeakNoEvilMonkeyWindows,
					MonkeyFace.SpeakNoEvilMonkeyTwitter,
					MonkeyFace.SpeakNoEvilMonkeyJoyPixels,
					MonkeyFace.SpeakNoEvilMonkeySamsung,
					MonkeyFace.SpeakNoEvilMonkeyGmail,
					null,
					MonkeyFace.SpeakNoEvilMonkeyKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonKissMark_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonKissMark.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F48B", buttonKissMark.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonKissMark.Tag,
					Emotion.KissMarkApple,
					Emotion.KissMarkGoogle,
					Emotion.KissMarkFacebook,
					Emotion.KissMarkWindows,
					Emotion.KissMarkTwitter,
					Emotion.KissMarkJoyPixels,
					Emotion.KissMarkSamsung,
					Emotion.KissMarkGmail,
					Emotion.KissMarkDocomo,
					Emotion.KissMarkKddi,
					Emotion.KissMarkSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonLoveLetter_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonLoveLetter.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F48C", buttonLoveLetter.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonLoveLetter.Tag,
					Emotion.LoveLetterApple,
					Emotion.LoveLetterGoogle,
					Emotion.LoveLetterFacebook,
					Emotion.LoveLetterWindows,
					Emotion.LoveLetterTwitter,
					Emotion.LoveLetterJoyPixels,
					Emotion.LoveLetterSamsung,
					Emotion.LoveLetterGmail,
					Emotion.LoveLetterDocomo,
					Emotion.LoveLetterKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHeartWithArrow_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHeartWithArrow.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F498", buttonHeartWithArrow.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonHeartWithArrow.Tag,
					Emotion.HeartWithArrowApple,
					Emotion.HeartWithArrowGoogle,
					Emotion.HeartWithArrowFacebook,
					Emotion.HeartWithArrowWindows,
					Emotion.HeartWithArrowTwitter,
					Emotion.HeartWithArrowJoyPixels,
					Emotion.HeartWithArrowSamsung,
					Emotion.HeartWithArrowGmail,
					null,
					Emotion.HeartWithArrowKddi,
					Emotion.HeartWithArrowSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHeartWithRibbon_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHeartWithRibbon.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F49D", buttonHeartWithRibbon.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonHeartWithRibbon.Tag,
					Emotion.HeartWithRibbonApple,
					Emotion.HeartWithRibbonGoogle,
					Emotion.HeartWithRibbonFacebook,
					Emotion.HeartWithRibbonWindows,
					Emotion.HeartWithRibbonTwitter,
					Emotion.HeartWithRibbonJoyPixels,
					Emotion.HeartWithRibbonSamsung,
					Emotion.HeartWithRibbonGmail,
					null,
					Emotion.HeartWithRibbonKddi,
					Emotion.HeartWithRibbonSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSparklingHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSparklingHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F496", buttonSparklingHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonSparklingHeart.Tag,
					Emotion.SparklingHeartApple,
					Emotion.SparklingHeartGoogle,
					Emotion.SparklingHeartFacebook,
					Emotion.SparklingHeartWindows,
					Emotion.SparklingHeartTwitter,
					Emotion.SparklingHeartJoyPixels,
					Emotion.SparklingHeartSamsung,
					Emotion.SparklingHeartGmail,
					null,
					Emotion.SparklingHeartKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGrowingHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrowingHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F497", buttonGrowingHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonGrowingHeart.Tag,
					Emotion.GrowingHeartApple,
					Emotion.GrowingHeartGoogle,
					Emotion.GrowingHeartFacebook,
					Emotion.GrowingHeartWindows,
					Emotion.GrowingHeartTwitter,
					Emotion.GrowingHeartJoyPixels,
					Emotion.GrowingHeartSamsung,
					Emotion.GrowingHeartGmail,
					null,
					null,
					Emotion.GrowingHeartSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonBeatingHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonBeatingHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F493", buttonBeatingHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonBeatingHeart.Tag,
					Emotion.BeatingHeartApple,
					Emotion.BeatingHeartGoogle,
					Emotion.BeatingHeartFacebook,
					Emotion.BeatingHeartWindows,
					Emotion.BeatingHeartTwitter,
					Emotion.BeatingHeartJoyPixels,
					Emotion.BeatingHeartSamsung,
					Emotion.BeatingHeartGmail,
					Emotion.BeatingHeartDocomo,
					Emotion.BeatingHeartKddi,
					Emotion.BeatingHeartSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonRevolvingHearts_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonRevolvingHearts.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F49E", buttonRevolvingHearts.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonRevolvingHearts.Tag,
					Emotion.RevolvingHeartsApple,
					Emotion.RevolvingHeartsGoogle,
					Emotion.RevolvingHeartsFacebook,
					Emotion.RevolvingHeartsWindows,
					Emotion.RevolvingHeartsTwitter,
					Emotion.RevolvingHeartsJoyPixels,
					Emotion.RevolvingHeartsSamsung,
					Emotion.RevolvingHeartsGmail,
					null,
					Emotion.RevolvingHeartsKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonTwoHearts_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonTwoHearts.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F495", buttonTwoHearts.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonTwoHearts.Tag,
					Emotion.TwoHeartsApple,
					Emotion.TwoHeartsGoogle,
					Emotion.TwoHeartsFacebook,
					Emotion.TwoHeartsWindows,
					Emotion.TwoHeartsTwitter,
					Emotion.TwoHeartsJoyPixels,
					Emotion.TwoHeartsSamsung,
					Emotion.TwoHeartsGmail,
					Emotion.TwoHeartsDocomo,
					Emotion.TwoHeartsKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHeartDecoration_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHeartDecoration.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F49F", buttonHeartDecoration.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonHeartDecoration.Tag,
					Emotion.HeartDecorationApple,
					Emotion.HeartDecorationGoogle,
					Emotion.HeartDecorationFacebook,
					Emotion.HeartDecorationWindows,
					Emotion.HeartDecorationTwitter,
					Emotion.HeartDecorationJoyPixels,
					Emotion.HeartDecorationSamsung,
					Emotion.HeartDecorationGmail,
					null,
					null,
					Emotion.HeartDecorationSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHeartExclamation_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHeartExclamation.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+2763", buttonHeartExclamation.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonHeartExclamation.Tag,
					Emotion.HeartExclamationApple,
					Emotion.HeartExclamationGoogle,
					Emotion.HeartExclamationFacebook,
					Emotion.HeartExclamationWindows,
					Emotion.HeartExclamationTwitter,
					Emotion.HeartExclamationJoyPixels,
					Emotion.HeartExclamationSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonBrokenHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonBrokenHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F494", buttonBrokenHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonBrokenHeart.Tag,
					Emotion.BrokenHeartApple,
					Emotion.BrokenHeartGoogle,
					Emotion.BrokenHeartFacebook,
					Emotion.BrokenHeartWindows,
					Emotion.BrokenHeartTwitter,
					Emotion.BrokenHeartJoyPixels,
					Emotion.BrokenHeartSamsung,
					Emotion.BrokenHeartGmail,
					Emotion.BrokenHeartDocomo,
					Emotion.BrokenHeartKddi,
					Emotion.BrokenHeartSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonRedHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonRedHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+2764", buttonRedHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonRedHeart.Tag,
					Emotion.RedHeartApple,
					Emotion.RedHeartGoogle,
					Emotion.RedHeartFacebook,
					Emotion.RedHeartWindows,
					Emotion.RedHeartTwitter,
					Emotion.RedHeartJoyPixels,
					Emotion.RedHeartSamsung,
					Emotion.RedHeartGmail,
					Emotion.RedHeartDocomo,
					Emotion.RedHeartKddi,
					Emotion.RedHeartSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonOrangeHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonOrangeHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F9E1", buttonOrangeHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonOrangeHeart.Tag,
					Emotion.OrangeHeartApple,
					Emotion.OrangeHeartGoogle,
					Emotion.OrangeHeartFacebook,
					Emotion.OrangeHeartWindows,
					Emotion.OrangeHeartTwitter,
					Emotion.OrangeHeartJoyPixels,
					Emotion.OrangeHeartSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonYellowHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonYellowHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F49B", buttonYellowHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonYellowHeart.Tag,
					Emotion.YellowHeartApple,
					Emotion.YellowHeartGoogle,
					Emotion.YellowHeartFacebook,
					Emotion.YellowHeartWindows,
					Emotion.YellowHeartTwitter,
					Emotion.YellowHeartJoyPixels,
					Emotion.YellowHeartSamsung,
					Emotion.YellowHeartGmail,
					null,
					Emotion.YellowHeartKddi,
					Emotion.YellowHeartSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGreenHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGreenHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F49A", buttonGreenHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonGreenHeart.Tag,
					Emotion.GreenHeartApple,
					Emotion.GreenHeartGoogle,
					Emotion.GreenHeartFacebook,
					Emotion.GreenHeartWindows,
					Emotion.GreenHeartTwitter,
					Emotion.GreenHeartJoyPixels,
					Emotion.GreenHeartSamsung,
					Emotion.GreenHeartGmail,
					null,
					Emotion.GreenHeartKddi,
					Emotion.GreenHeartSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonBlueHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonBlueHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F499", buttonBlueHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonBlueHeart.Tag,
					Emotion.BlueHeartApple,
					Emotion.BlueHeartGoogle,
					Emotion.BlueHeartFacebook,
					Emotion.BlueHeartWindows,
					Emotion.BlueHeartTwitter,
					Emotion.BlueHeartJoyPixels,
					Emotion.BlueHeartSamsung,
					Emotion.BlueHeartGmail,
					null,
					Emotion.BlueHeartKddi,
					Emotion.BlueHeartSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonPurpleHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPurpleHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F49C", buttonPurpleHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonPurpleHeart.Tag,
					Emotion.PurpleHeartApple,
					Emotion.PurpleHeartGoogle,
					Emotion.PurpleHeartFacebook,
					Emotion.PurpleHeartWindows,
					Emotion.PurpleHeartTwitter,
					Emotion.PurpleHeartJoyPixels,
					Emotion.PurpleHeartSamsung,
					Emotion.PurpleHeartGmail,
					null,
					Emotion.PurpleHeartKddi,
					Emotion.PurpleHeartSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonBrownHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonBrownHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F90E", buttonBrownHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonBrownHeart.Tag,
					Emotion.BrownHeartApple,
					Emotion.BrownHeartGoogle,
					Emotion.BrownHeartFacebook,
					Emotion.BrownHeartWindows,
					Emotion.BrownHeartTwitter,
					Emotion.BrownHeartJoyPixels,
					Emotion.BrownHeartSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonBlackHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonBlackHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F5A4", buttonBlackHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonBlackHeart.Tag,
					Emotion.BlackHeartApple,
					Emotion.BlackHeartGoogle,
					Emotion.BlackHeartFacebook,
					Emotion.BlackHeartWindows,
					Emotion.BlackHeartTwitter,
					Emotion.BlackHeartJoyPixels,
					Emotion.BlackHeartSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonWhiteHeart_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWhiteHeart.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F90D", buttonWhiteHeart.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonWhiteHeart.Tag,
					Emotion.WhiteHeartApple,
					Emotion.WhiteHeartGoogle,
					Emotion.WhiteHeartFacebook,
					Emotion.WhiteHeartWindows,
					Emotion.WhiteHeartTwitter,
					Emotion.WhiteHeartJoyPixels,
					Emotion.WhiteHeartSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHundredPoints_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHundredPoints.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4AF", buttonHundredPoints.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonHundredPoints.Tag,
					Emotion.HundredPointsApple,
					Emotion.HundredPointsGoogle,
					Emotion.HundredPointsFacebook,
					Emotion.HundredPointsWindows,
					Emotion.HundredPointsTwitter,
					Emotion.HundredPointsJoyPixels,
					Emotion.HundredPointsSamsung,
					Emotion.HundredPointsGmail,
					null,
					Emotion.HundredPointsKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonAngerSymbol_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonAngerSymbol.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4A2", buttonAngerSymbol.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonAngerSymbol.Tag,
					Emotion.AngerSymbolApple,
					Emotion.AngerSymbolGoogle,
					Emotion.AngerSymbolFacebook,
					Emotion.AngerSymbolWindows,
					Emotion.AngerSymbolTwitter,
					Emotion.AngerSymbolJoyPixels,
					Emotion.AngerSymbolSamsung,
					Emotion.AngerSymbolGmail,
					Emotion.AngerSymbolDocomo,
					Emotion.AngerSymbolKddi,
					Emotion.AngerSymbolSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonCollision_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonCollision.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4A5", buttonCollision.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonCollision.Tag,
					Emotion.CollisionApple,
					Emotion.CollisionGoogle,
					Emotion.CollisionFacebook,
					Emotion.CollisionWindows,
					Emotion.CollisionTwitter,
					Emotion.CollisionJoyPixels,
					Emotion.CollisionSamsung,
					Emotion.CollisionGmail,
					Emotion.CollisionDocomo,
					Emotion.CollisionKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonDizzy_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonDizzy.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4AB", buttonDizzy.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonDizzy.Tag,
					Emotion.DizzyApple,
					Emotion.DizzyGoogle,
					Emotion.DizzyFacebook,
					Emotion.DizzyWindows,
					Emotion.DizzyTwitter,
					Emotion.DizzyJoyPixels,
					Emotion.DizzySamsung,
					Emotion.DizzyGmail,
					null,
					Emotion.DizzyKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSweatDroplets_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSweatDroplets.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4A6", buttonSweatDroplets.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonSweatDroplets.Tag,
					Emotion.SweatDropletsApple,
					Emotion.SweatDropletsGoogle,
					Emotion.SweatDropletsFacebook,
					Emotion.SweatDropletsWindows,
					Emotion.SweatDropletsTwitter,
					Emotion.SweatDropletsJoyPixels,
					Emotion.SweatDropletsSamsung,
					Emotion.SweatDropletsGmail,
					Emotion.SweatDropletsDocomo,
					Emotion.SweatDropletsKddi,
					Emotion.SweatDropletsSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonDashingAway_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonDashingAway.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4A8", buttonDashingAway.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonDashingAway.Tag,
					Emotion.DashingAwayApple,
					Emotion.DashingAwayGoogle,
					Emotion.DashingAwayFacebook,
					Emotion.DashingAwayWindows,
					Emotion.DashingAwayTwitter,
					Emotion.DashingAwayJoyPixels,
					Emotion.DashingAwaySamsung,
					Emotion.DashingAwayGmail,
					Emotion.DashingAwayDocomo,
					Emotion.DashingAwayKddi,
					Emotion.DashingAwaySoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonHole_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHole.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F573", buttonHole.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonHole.Tag,
					Emotion.HoleApple,
					Emotion.HoleGoogle,
					Emotion.HoleFacebook,
					Emotion.HoleWindows,
					Emotion.HoleTwitter,
					Emotion.HoleJoyPixels,
					Emotion.HoleSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonBomb_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonBomb.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4A3", buttonBomb.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonBomb.Tag,
					Emotion.BombApple,
					Emotion.BombGoogle,
					Emotion.BombFacebook,
					Emotion.BombWindows,
					Emotion.BombTwitter,
					Emotion.BombJoyPixels,
					Emotion.BombSamsung,
					Emotion.BombGmail,
					Emotion.BombDocomo,
					Emotion.BombKddi,
					Emotion.BombSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonSpeechBalloon_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSpeechBalloon.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4AC", buttonSpeechBalloon.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonSpeechBalloon.Tag,
					Emotion.SpeechBalloonApple,
					Emotion.SpeechBalloonGoogle,
					Emotion.SpeechBalloonFacebook,
					Emotion.SpeechBalloonWindows,
					Emotion.SpeechBalloonTwitter,
					Emotion.SpeechBalloonJoyPixels,
					Emotion.SpeechBalloonSamsung,
					Emotion.SpeechBalloonGmail,
					null,
					Emotion.SpeechBalloonKddi,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonEyeInSpeechBubble_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonEyeInSpeechBubble.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F441 U+FE0F U+200D U+1F5E8 U+FE0F", buttonEyeInSpeechBubble.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonEyeInSpeechBubble.Tag,
					Emotion.EyeInSpeechBubbleApple,
					Emotion.EyeInSpeechBubbleGoogle,
					Emotion.EyeInSpeechBubbleFacebook,
					Emotion.EyeInSpeechBubbleWindows,
					Emotion.EyeInSpeechBubbleTwitter,
					Emotion.EyeInSpeechBubbleJoyPixels,
					Emotion.EyeInSpeechBubbleSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonLeftSpeechBubble_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonLeftSpeechBubble.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F5E8", buttonLeftSpeechBubble.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonLeftSpeechBubble.Tag,
					Emotion.LeftSpeechBubbleApple,
					Emotion.LeftSpeechBubbleGoogle,
					Emotion.LeftSpeechBubbleFacebook,
					Emotion.LeftSpeechBubbleWindows,
					Emotion.LeftSpeechBubbleTwitter,
					Emotion.LeftSpeechBubbleJoyPixels,
					Emotion.LeftSpeechBubbleSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonRightAngerBubble_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonRightAngerBubble.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F5EF", buttonRightAngerBubble.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonRightAngerBubble.Tag,
					Emotion.RightAngerBubbleApple,
					Emotion.RightAngerBubbleGoogle,
					Emotion.RightAngerBubbleFacebook,
					Emotion.RightAngerBubbleWindows,
					Emotion.RightAngerBubbleTwitter,
					Emotion.RightAngerBubbleJoyPixels,
					Emotion.RightAngerBubbleSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonThoughtBalloon_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonThoughtBalloon.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4AD", buttonThoughtBalloon.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonThoughtBalloon.Tag,
					Emotion.ThoughtBalloonApple,
					Emotion.ThoughtBalloonGoogle,
					Emotion.ThoughtBalloonFacebook,
					Emotion.ThoughtBalloonWindows,
					Emotion.ThoughtBalloonTwitter,
					Emotion.ThoughtBalloonJoyPixels,
					Emotion.ThoughtBalloonSamsung,
					null,
					null,
					null,
					null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonZzz_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonZzz.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F4A4", buttonZzz.AccessibleName,
					Resources.smileysAndEmotion, Resources.emotion,
					buttonZzz.Tag,
					Emotion.ZzzApple,
					Emotion.ZzzGoogle,
					Emotion.ZzzFacebook,
					Emotion.ZzzWindows,
					Emotion.ZzzTwitter,
					Emotion.ZzzJoyPixels,
					Emotion.ZzzSamsung,
					Emotion.ZzzGmail,
					Emotion.ZzzDocomo,
					Emotion.ZzzKddi,
					Emotion.ZzzSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}
	}
}