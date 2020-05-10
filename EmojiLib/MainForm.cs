using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
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

		private void SomethingWentWrong()
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
			if (sender is TextBox)
			{
				SetStatusbar(text: ((TextBox)sender).AccessibleDescription);
			}
			else if (sender is Button)
			{
				SetStatusbar(text: ((Button)sender).AccessibleDescription);
			}
			else if (sender is RadioButton)
			{
				SetStatusbar(text: ((RadioButton)sender).AccessibleDescription);
			}
			else if (sender is CheckBox)
			{
				SetStatusbar(text: ((CheckBox)sender).AccessibleDescription);
			}
			else if (sender is DateTimePicker)
			{
				SetStatusbar(text: ((DateTimePicker)sender).AccessibleDescription);
			}
			else if (sender is Label)
			{
				SetStatusbar(text: ((Label)sender).AccessibleDescription);
			}
			else if (sender is PictureBox)
			{
				SetStatusbar(text: ((PictureBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripButton)
			{
				SetStatusbar(text: ((ToolStripButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem)
			{
				SetStatusbar(text: ((ToolStripMenuItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripLabel)
			{
				SetStatusbar(text: ((ToolStripLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripComboBox)
			{
				SetStatusbar(text: ((ToolStripComboBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDown)
			{
				SetStatusbar(text: ((ToolStripDropDown)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton)
			{
				SetStatusbar(text: ((ToolStripDropDownButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem)
			{
				SetStatusbar(text: ((ToolStripDropDownItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu)
			{
				SetStatusbar(text: ((ToolStripDropDownMenu)sender).AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar)
			{
				SetStatusbar(text: ((ToolStripProgressBar)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton)
			{
				SetStatusbar(text: ((ToolStripSplitButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSeparator)
			{
				SetStatusbar(text: ((ToolStripSeparator)sender).AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel)
			{
				SetStatusbar(text: ((ToolStripStatusLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripTextBox)
			{
				SetStatusbar(text: ((ToolStripTextBox)sender).AccessibleDescription);
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

		private void ShowEmojiInfo(string code, string shortName, string group, string subGroup, object tag, Image appleVersion, Image googleVersion, Image facebookVersion, Image windowsVersion, Image twitterVersion, Image joypixelsVersion, Image samsungVersion, Image gmailVersion, Image docomoVersion, Image kddiVersion, Image softbankVersion)
		{
			EmojiInfoForm emojiInfo = new EmojiInfoForm();
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
						Button newButton = new Button();
						newButton.AccessibleDescription = button.AccessibleDescription;
						newButton.AccessibleName = button.AccessibleName;
						newButton.AccessibleRole = button.AccessibleRole;
						newButton.BackgroundImage = button.BackgroundImage;
						newButton.BackgroundImageLayout = button.BackgroundImageLayout;
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
						newButton.Click += new System.EventHandler(Button_Click);
						newButton.Enter += new System.EventHandler(SetStatusbar_Enter);
						newButton.Leave += new System.EventHandler(ClearStatusbar_Leave);
						newButton.MouseEnter += new System.EventHandler(SetStatusbar_Enter);
						newButton.MouseLeave += new System.EventHandler(ClearStatusbar_Leave);
						switch (newButton.Name)
						{
							case "buttonGrinningFace": newButton.Click += new System.EventHandler(ButtonGrinningFace_Click); break;
							case "buttonGrinningFaceWithBigEyes": newButton.Click += new System.EventHandler(ButtonGrinningFaceWithBigEyes_Click); break;
							case "buttonGrinningFaceWithSmilingEyes": newButton.Click += new System.EventHandler(ButtonGrinningFaceWithSmilingEyes_Click); break;
							case "buttonBeamingFaceWithSmilingEyes": newButton.Click += new System.EventHandler(ButtonBeamingFaceWithSmilingEyes_Click); break;
							case "buttonGrinningSquintingFace": newButton.Click += new System.EventHandler(ButtonGrinningSquintingFace_Click); break;
							case "buttonGrinningFaceWithSweat": newButton.Click += new System.EventHandler(ButtonGrinningFaceWithSweat_Click); break;
							case "buttonRollingOnTheFloorLaughing": newButton.Click += new System.EventHandler(ButtonRollingOnTheFloorLaughing_Click); break;
							case "buttonFaceWithTearsOfJoy": newButton.Click += new System.EventHandler(ButtonFaceWithTearsOfJoy_Click); break;
							case "buttonSlightlySmilingFace": newButton.Click += new System.EventHandler(ButtonSlightlySmilingFace_Click); break;
							case "buttonUpsideDownFace": newButton.Click += new System.EventHandler(ButtonUpsideDownFace_Click); break;
							case "buttonWinkingFace": newButton.Click += new System.EventHandler(ButtonWinkingFace_Click); break;
							case "buttonSmilingFaceWithSmilingEyes": newButton.Click += new System.EventHandler(ButtonGrinningFace_Click); break;
							case "buttonSmilingFaceWithHalo": newButton.Click += new System.EventHandler(ButtonSmilingFaceWithHalo_Click); break;
							case "buttonSmilingFaceWithHearts": newButton.Click += new System.EventHandler(ButtonSmilingFaceWithHearts_Click); break;
							case "buttonSmilingFaceWithHeartEyes": newButton.Click += new System.EventHandler(ButtonSmilingFaceWithHeartEyes_Click); break;
							case "buttonStarStruck": newButton.Click += new System.EventHandler(ButtonStarStruck_Click); break;
							case "buttonFaceBlowingAKiss": newButton.Click += new System.EventHandler(ButtonFaceBlowingAKiss_Click); break;
							case "buttonKissingFace": newButton.Click += new System.EventHandler(ButtonKissingFace_Click); break;
							case "buttonSmilingFaceFace": newButton.Click += new System.EventHandler(ButtonSmilingFace_Click); break;
							case "buttonKissingFaceWithClosedEyes": newButton.Click += new System.EventHandler(ButtonKissingFaceWithClosedEyes_Click); break;
							case "buttonKissingFaceWithSmilingEyes": newButton.Click += new System.EventHandler(ButtonKissingFaceWithSmilingEyes_Click); break;
							case "buttonSmilingFaceWithTear": newButton.Click += new System.EventHandler(ButtonSmilingFaceWithTear_Click); break;
							case "buttonFaceSavoringFood": newButton.Click += new System.EventHandler(ButtonFaceSavoringFood_Click); break;
							case "buttonFaceWithTongue": newButton.Click += new System.EventHandler(ButtonFaceWithTongue_Click); break;
							case "buttonWinkingFaceWithTongue": newButton.Click += new System.EventHandler(ButtonWinkingFaceWithTongue_Click); break;
							case "buttonZanyFace": newButton.Click += new System.EventHandler(ButtonZanyFace_Click); break;
							case "buttonSquintingFaceWithTongue": newButton.Click += new System.EventHandler(ButtonSquintingFaceWithTongue_Click); break;
							case "buttonMoneyMouthFace": newButton.Click += new System.EventHandler(ButtonMoneyMouthFace_Click); break;
							case "buttonHuggingFace": newButton.Click += new System.EventHandler(ButtonHuggingFace_Click); break;
							case "buttonFaceWithHandOverMouth": newButton.Click += new System.EventHandler(ButtonFaceWithHandOverMouth_Click); break;
							case "buttonShushingFace": newButton.Click += new System.EventHandler(ButtonShushingFace_Click); break;
							case "buttonThinkingFace": newButton.Click += new System.EventHandler(ButtonThinkingFace_Click); break;
							case "buttonZipperMouthFace": newButton.Click += new System.EventHandler(ButtonZipperMouthFace_Click); break;
							case "buttonFaceWithRaisedEyebrow": newButton.Click += new System.EventHandler(ButtonFaceWithRaisedEyebrow_Click); break;
							case "buttonNeutralFace": newButton.Click += new System.EventHandler(ButtonNeutralFace_Click); break;
							case "buttonExpressionlessFace": newButton.Click += new System.EventHandler(ButtonExpressionlessFace_Click); break;
							case "buttonFaceWithoutMouth": newButton.Click += new System.EventHandler(ButtonFaceWithoutMouth_Click); break;
							case "buttonSmirkingFace": newButton.Click += new System.EventHandler(ButtonSmirkingFace_Click); break;
							case "buttonUnamusedFace": newButton.Click += new System.EventHandler(ButtonUnamusedFace_Click); break;
							case "buttonFaceWithRollingEyes": newButton.Click += new System.EventHandler(ButtonFaceWithRollingEyes_Click); break;
							case "buttonGrimacingFace": newButton.Click += new System.EventHandler(ButtonGrimacingFace_Click); break;
							case "buttonLyingFace": newButton.Click += new System.EventHandler(ButtonLyingFace_Click); break;
							case "buttonRelievedFace": newButton.Click += new System.EventHandler(ButtonRelievedFace_Click); break;
							case "buttonPensiveFace": newButton.Click += new System.EventHandler(ButtonPensiveFace_Click); break;
							case "buttonSleepyFace": newButton.Click += new System.EventHandler(ButtonSleepyFace_Click); break;
							case "buttonDroolingFace": newButton.Click += new System.EventHandler(ButtonDroolingFace_Click); break;
							case "buttonSleepingFace": newButton.Click += new System.EventHandler(ButtonSleepingFace_Click); break;
							case "buttonFaceWithMedicalMask": newButton.Click += new System.EventHandler(ButtonFaceWithMedicalMask_Click); break;
							case "buttonFaceWithThermometer": newButton.Click += new System.EventHandler(ButtonFaceWithThermometer_Click); break;
							case "buttonFaceWithHeadBandage": newButton.Click += new System.EventHandler(ButtonFaceWithHeadBandage_Click); break;
							case "buttonNauseatedFace": newButton.Click += new System.EventHandler(ButtonNauseatedFace_Click); break;
							case "buttonFaceVomiting": newButton.Click += new System.EventHandler(ButtonFaceVomiting_Click); break;
							case "buttonSneezingFace": newButton.Click += new System.EventHandler(ButtonSneezingFace_Click); break;
							case "buttonHotFace": newButton.Click += new System.EventHandler(ButtonHotFace_Click); break;
							case "buttonColdFace": newButton.Click += new System.EventHandler(ButtonColdFace_Click); break;
							case "buttonWoozyFace": newButton.Click += new System.EventHandler(ButtonWoozyFace_Click); break;
							case "buttonDizzyFace": newButton.Click += new System.EventHandler(ButtonDizzyFace_Click); break;
							case "buttonExplodingHead": newButton.Click += new System.EventHandler(ButtonExplodingHead_Click); break;
							case "buttonCowboyHatFace": newButton.Click += new System.EventHandler(ButtonCowboyHatFace_Click); break;
							case "buttonPartyingFace": newButton.Click += new System.EventHandler(ButtonPartyingFace_Click); break;
							case "buttonDisguisedFace": newButton.Click += new System.EventHandler(ButtonDisguisedFace_Click); break;
							case "buttonSmilingFaceWithSunglasses": newButton.Click += new System.EventHandler(ButtonSmilingFaceWithSunglasses_Click); break;
							case "buttonNerdFace": newButton.Click += new System.EventHandler(ButtonNerdFace_Click); break;
							case "buttonFaceWithMonocle": newButton.Click += new System.EventHandler(ButtonFaceWithMonocle_Click); break;
							case "buttonConfusedFace": newButton.Click += new System.EventHandler(ButtonConfusedFace_Click); break;
							case "buttonWorriedFace": newButton.Click += new System.EventHandler(ButtonWorriedFace_Click); break;
							case "buttonSlightlyFrowningFace": newButton.Click += new System.EventHandler(ButtonSlightlyFrowningFace_Click); break;
							case "buttonFrowningFace": newButton.Click += new System.EventHandler(ButtonFrowningFace_Click); break;
							case "buttonFaceWithOpenMouth": newButton.Click += new System.EventHandler(ButtonFaceWithOpenMouth_Click); break;
							case "buttonHushedFace": newButton.Click += new System.EventHandler(ButtonHushedFace_Click); break;
							case "buttonAstonishedFace": newButton.Click += new System.EventHandler(ButtonAstonishedFace_Click); break;
							case "buttonFlushedFace": newButton.Click += new System.EventHandler(ButtonFlushedFace_Click); break;
							case "buttonPleadingFace": newButton.Click += new System.EventHandler(ButtonPleadingFace_Click); break;
							case "buttonFrowningFaceWithOpenMouth": newButton.Click += new System.EventHandler(ButtonFrowningFaceWithOpenMouth_Click); break;
							case "buttonAnguishedFace": newButton.Click += new System.EventHandler(ButtonAnguishedFace_Click); break;
							case "buttonFearfulFace": newButton.Click += new System.EventHandler(ButtonFearfulFace_Click); break;
							case "buttonAnxiousFaceWithSweat": newButton.Click += new System.EventHandler(ButtonAnxiousFaceWithSweat_Click); break;
							case "buttonSadButRelievedFace": newButton.Click += new System.EventHandler(ButtonSadButRelievedFace_Click); break;
							case "buttonCryingFace": newButton.Click += new System.EventHandler(ButtonCryingFace_Click); break;
							case "buttonLoudlyCryingFace": newButton.Click += new System.EventHandler(ButtonLoudlyCryingFace_Click); break;
							case "buttonFaceScreamingInFear": newButton.Click += new System.EventHandler(ButtonFaceScreamingInFear_Click); break;
							case "buttonConfoundedFace": newButton.Click += new System.EventHandler(ButtonConfoundedFace_Click); break;
							case "buttonPerseveringFace": newButton.Click += new System.EventHandler(ButtonPerseveringFace_Click); break;
							case "buttonDisappointedFace": newButton.Click += new System.EventHandler(ButtonDisappointedFace_Click); break;
							case "buttonDowncastFaceWithSweat": newButton.Click += new System.EventHandler(ButtonGrinningFace_Click); break;
							case "buttonWearyFace": newButton.Click += new System.EventHandler(ButtonWearyFace_Click); break;
							case "buttonTiredFace": newButton.Click += new System.EventHandler(ButtonTiredFace_Click); break;
							case "buttonYawningFace": newButton.Click += new System.EventHandler(ButtonYawningFace_Click); break;
							case "buttonFaceWithSteamFromNose": newButton.Click += new System.EventHandler(ButtonFaceWithSteamFromNose_Click); break;
							case "buttonPoutingFace": newButton.Click += new System.EventHandler(ButtonPoutingFace_Click); break;
							case "buttonAngryFace": newButton.Click += new System.EventHandler(ButtonAngryFace_Click); break;
							case "buttonFaceWithSymbolsOnMouth": newButton.Click += new System.EventHandler(ButtonFaceWithSymbolsOnMouth_Click); break;
							case "buttonSmilingFaceWithHorns": newButton.Click += new System.EventHandler(ButtonSmilingFaceWithHorns_Click); break;
							case "buttonAngryFaceWithHorns": newButton.Click += new System.EventHandler(ButtonAngryFaceWithHorns_Click); break;
							case "buttonSkull": newButton.Click += new System.EventHandler(ButtonSkull_Click); break;
							case "buttonSkullAndCrossbones": newButton.Click += new System.EventHandler(ButtonSkullAndCrossbones_Click); break;
							default: newButton.Click += new System.EventHandler(Button_Click); break;
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

		private void ButtonGrinningFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningFace.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F600", buttonGrinningFace.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonGrinningFace.Tag,
					FaceSmiling.GrinningFaceApple,
					FaceSmiling.GrinningFaceGoogle,
					FaceSmiling.GrinningFaceFacebook,
					FaceSmiling.GrinningFaceWindows,
					FaceSmiling.GrinningFaceTwitter,
					FaceSmiling.GrinningFaceJoyPixels,
					FaceSmiling.GrinningFaceSamsung,
					FaceSmiling.GrinningFaceGmail, null, null, null);
			}
			else
			{
				SomethingWentWrong();
			}
		}

		private void ButtonGrinningFaceWithBigEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningFaceWithBigEyes.Tag.ToString());
			}
			else if (buttonLibraryMode.Checked)
			{
				ShowEmojiInfo("U+1F603", buttonGrinningFaceWithBigEyes.AccessibleName,
					Resources.smileysAndEmotion, Resources.faceSmiling,
					buttonGrinningFaceWithBigEyes.Tag,
					FaceSmiling.GrinningFaceWithBigEyesApple,
					FaceSmiling.GrinningFaceWithBigEyesGoogle,
					FaceSmiling.GrinningFaceWithBigEyesFacebook,
					FaceSmiling.GrinningFaceWithBigEyesWindows,
					FaceSmiling.GrinningFaceWithBigEyesTwitter,
					FaceSmiling.GrinningFaceWithBigEyesJoyPixels,
					FaceSmiling.GrinningFaceWithBigEyesSamsung,
					FaceSmiling.GrinningFaceWithBigEyesGmail,
					FaceSmiling.GrinningFaceWithBigEyesDocomo,
					FaceSmiling.GrinningFaceWithBigEyesKddi,
					FaceSmiling.GrinningFaceWithBigEyesSoftbank);
			}
			else
			{
				SomethingWentWrong();
			}
		}

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
					FaceSmiling.BeamingFaceWithSmilingEyesSamsung);
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
					FaceSmiling.GrinningSquintingFaceSamsung);
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
					FaceSmiling.GrinningFaceWithSweatSamsung);
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
					FaceSmiling.RollingOnTheFloorLaughingSamsung);
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
					FaceSmiling.FaceWithTearsOfJoySamsung);
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
					FaceSmiling.SlightlySmilingFaceSamsung);
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
					FaceSmiling.UpsideDownFaceSamsung);
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
					FaceSmiling.WinkingFaceSamsung);
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
					FaceSmiling.SmilingFaceWithSmilingEyesSamsung);
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
					FaceSmiling.SmilingFaceWithHaloSamsung);
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
					FaceAffection.SmilingFaceWithHeartsSamsung);
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
					FaceAffection.SmilingFaceWithHeartEyesSamsung);
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
					FaceAffection.StarStruckSamsung);
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
					FaceAffection.FaceBlowingAKissSamsung);
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
					FaceAffection.KissingFaceSamsung);
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
					FaceAffection.SmilingFaceSamsung);
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
					FaceAffection.KissingFaceWithClosedEyesSamsung);
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
					FaceAffection.KissingFaceWithSmilingEyesSamsung);
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
					FaceTongue.FaceSavoringFoodSamsung);
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
					FaceTongue.FaceWithTongueSamsung);
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
					FaceTongue.WinkingFaceWithTongueSamsung);
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
					FaceTongue.ZanyFaceSamsung);
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
					FaceTongue.SquintingFaceWithTongueSamsung);
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
					FaceTongue.MoneyMouthFaceSamsung);
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
					FaceHand.HuggingFaceSamsung);
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
					FaceHand.FaceWithHandOverMouthSamsung);
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
					FaceHand.ShushingFaceSamsung);
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
					FaceHand.ThinkingFaceSamsung);
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
					FaceNeutralSkeptical.ZipperMouthFaceSamsung);
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
					FaceNeutralSkeptical.FaceWithRaisedEyebrowSamsung);
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
					FaceNeutralSkeptical.NeutralFaceSamsung);
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
					FaceNeutralSkeptical.ExpressionlessFaceSamsung);
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
					FaceNeutralSkeptical.FaceWithoutMouthSamsung);
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
					FaceNeutralSkeptical.SmirkingFaceSamsung);
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
					FaceNeutralSkeptical.UnamusedFaceSamsung);
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
					FaceNeutralSkeptical.FaceWithRollingEyesSamsung);
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
					FaceNeutralSkeptical.GrimacingFaceSamsung);
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
					FaceNeutralSkeptical.LyingFaceSamsung);
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
					FaceSleepy.RelievedFaceSamsung);
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
					FaceSleepy.PensiveFaceSamsung);
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
					FaceSleepy.SleepyFaceSamsung);
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
					FaceSleepy.DroolingFaceSamsung);
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
					FaceSleepy.SleepingFaceSamsung);
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
					FaceUnwell.FaceWithMedicalMaskSamsung);
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
					FaceUnwell.FaceWithThermometerSamsung);
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
					FaceUnwell.FaceWithHeadBandageSamsung);
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
					FaceUnwell.NauseatedFaceSamsung);
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
					FaceUnwell.FaceVomitingSamsung);
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
					FaceUnwell.SneezingFaceSamsung);
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
					FaceUnwell.HotFaceSamsung);
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
					FaceUnwell.ColdFaceSamsung);
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
					FaceUnwell.WoozyFaceSamsung);
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
					FaceUnwell.DizzyFaceSamsung);
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
					FaceUnwell.ExplodingHeadSamsung);
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
					FaceHat.CowboyHatFaceSamsung);
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
					FaceHat.PartyingFaceSamsung);
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
					FaceGlasses.SmilingFaceWithSunglassesSamsung);
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
					FaceGlasses.NerdFaceSamsung);
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
					FaceGlasses.FaceWithMonocleSamsung);
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
					FaceConcerned.ConfusedFaceSamsung);
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
					FaceConcerned.WorriedFaceSamsung);
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
					FaceConcerned.SlightlyFrowningFaceSamsung);
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
					FaceConcerned.FrowningFaceSamsung);
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
					FaceConcerned.FaceWithOpenMouthSamsung);
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
					FaceConcerned.HushedFaceSamsung);
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
					FaceConcerned.AstonishedFaceSamsung);
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
					FaceConcerned.FlushedFaceSamsung);
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
					FaceConcerned.PleadingFaceSamsung);
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
					FaceConcerned.FrowningFaceWithOpenMouthSamsung);
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
					FaceConcerned.AnguishedFaceSamsung);
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
					FaceConcerned.FearfulFaceSamsung);
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
					FaceConcerned.AnxiousFaceWithSweatSamsung);
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
					FaceConcerned.SadButRelievedFaceSamsung);
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
					FaceConcerned.CryingFaceSamsung);
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
					FaceConcerned.LoudlyCryingFaceSamsung);
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
					FaceConcerned.FaceScreamingInFearSamsung);
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
					FaceConcerned.ConfoundedFaceSamsung);
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
					FaceConcerned.PerseveringFaceSamsung);
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
					FaceConcerned.DisappointedFaceSamsung);
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
					FaceConcerned.DowncastFaceWithSweatSamsung);
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
					FaceConcerned.WearyFaceSamsung);
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
					FaceConcerned.TiredFaceSamsung);
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
					FaceConcerned.YawningFaceSamsung);
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
					FaceNegative.FaceWithSteamFromNoseSamsung);
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
					FaceNegative.PoutingFaceSamsung);
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
					FaceNegative.AngryFaceSamsung);
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
					FaceNegative.FaceWithSymbolsOnMouthSamsung);
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
					FaceNegative.SmilingFaceWithHornsSamsung);
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
					FaceNegative.AngryFaceWithHornsSamsung);
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
					FaceNegative.SkullSamsung);
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
					FaceNegative.SkullAndCrossbonesSamsung);
			}
			else
			{
				SomethingWentWrong();
			}
		}
	}
}