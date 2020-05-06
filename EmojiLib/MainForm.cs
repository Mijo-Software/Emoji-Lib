using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
			labelInformation.Text = string.Empty;
			labelCopiedStatus.Visible = false;
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

		private void ShowEmojiInfo(string code, string shortName, string group, string subGroup, object tag, Image appleVersion, Image googleVersion, Image facebookVersion, Image windowsVersion, Image twitterVersion, Image joypixelsVersion, Image samsungVersion)
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

		private void toolStripMenuItemAboutBox_Click(object sender, EventArgs e)
		{
			AboutBoxForm formAboutBox = new AboutBoxForm();
			formAboutBox.ShowDialog();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
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
			buttonEmojiSize16.Checked = true;
			buttonEmojiSize24.Checked = false;
			buttonEmojiSize32.Checked = false;
			foreach (var button in flowLayoutPanelSmileys.Controls.OfType<Button>())
			{
				button.Size = new Size(16, 16);
			}
		}

		private void ButtonEmojiSize24_Click(object sender, EventArgs e)
		{
			buttonEmojiSize16.Checked = false;
			buttonEmojiSize24.Checked = true;
			buttonEmojiSize32.Checked = false;
			foreach (var button in flowLayoutPanelSmileys.Controls.OfType<Button>())
			{
				button.Size = new Size(24, 24);
			}
		}

		private void ButtonEmojiSize32_Click(object sender, EventArgs e)
		{
			buttonEmojiSize16.Checked = false;
			buttonEmojiSize24.Checked = false;
			buttonEmojiSize32.Checked = true;
			foreach (var button in flowLayoutPanelSmileys.Controls.OfType<Button>())
			{
				button.Size = new Size(32, 32);
			}
		}

		private void ButtonGrinningFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F600", buttonGrinningFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonGrinningFace.Tag,
					FaceSmiling.GrinningFaceApple,
					FaceSmiling.GrinningFaceGoogle,
					FaceSmiling.GrinningFaceFacebook,
					FaceSmiling.GrinningFaceWindows,
					FaceSmiling.GrinningFaceTwitter,
					FaceSmiling.GrinningFaceJoyPixels,
					FaceSmiling.GrinningFaceSamsung);
			}
		}

		private void ButtonGrinningFaceWithBigEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningFaceWithBigEyes.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F603", buttonGrinningFaceWithBigEyes.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonGrinningFaceWithBigEyes.Tag,
					FaceSmiling.GrinningFaceWithBigEyesApple,
					FaceSmiling.GrinningFaceWithBigEyesGoogle,
					FaceSmiling.GrinningFaceWithBigEyesFacebook,
					FaceSmiling.GrinningFaceWithBigEyesWindows,
					FaceSmiling.GrinningFaceWithBigEyesTwitter,
					FaceSmiling.GrinningFaceWithBigEyesJoyPixels,
					FaceSmiling.GrinningFaceWithBigEyesSamsung);
			}
		}

		private void ButtonGrinningFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningFaceWithSmilingEyes.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F604", buttonGrinningFaceWithSmilingEyes.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonGrinningFaceWithSmilingEyes.Tag,
					FaceSmiling.GrinningFaceWithSmilingEyesApple,
					FaceSmiling.GrinningFaceWithSmilingEyesGoogle,
					FaceSmiling.GrinningFaceWithSmilingEyesFacebook,
					FaceSmiling.GrinningFaceWithSmilingEyesWindows,
					FaceSmiling.GrinningFaceWithSmilingEyesTwitter,
					FaceSmiling.GrinningFaceWithSmilingEyesJoyPixels,
					FaceSmiling.GrinningFaceWithSmilingEyesSamsung);
			}
		}

		private void ButtonBeamingFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonBeamingFaceWithSmilingEyes.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F601", buttonBeamingFaceWithSmilingEyes.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonBeamingFaceWithSmilingEyes.Tag,
					FaceSmiling.BeamingFaceWithSmilingEyesApple,
					FaceSmiling.BeamingFaceWithSmilingEyesGoogle,
					FaceSmiling.BeamingFaceWithSmilingEyesFacebook,
					FaceSmiling.BeamingFaceWithSmilingEyesWindows,
					FaceSmiling.BeamingFaceWithSmilingEyesTwitter,
					FaceSmiling.BeamingFaceWithSmilingEyesJoyPixels,
					FaceSmiling.BeamingFaceWithSmilingEyesSamsung);
			}
		}

		private void ButtonGrinningSquintingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningSquintingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F606", buttonGrinningSquintingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonGrinningSquintingFace.Tag,
					FaceSmiling.GrinningSquintingFaceApple,
					FaceSmiling.GrinningSquintingFaceGoogle,
					FaceSmiling.GrinningSquintingFaceFacebook,
					FaceSmiling.GrinningSquintingFaceWindows,
					FaceSmiling.GrinningSquintingFaceTwitter,
					FaceSmiling.GrinningSquintingFaceJoyPixels,
					FaceSmiling.GrinningSquintingFaceSamsung);
			}
		}

		private void ButtonGrinningFaceWithSweat_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrinningFaceWithSweat.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F605", buttonGrinningFaceWithSweat.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonGrinningFaceWithSweat.Tag,
					FaceSmiling.GrinningFaceWithSweatApple,
					FaceSmiling.GrinningFaceWithSweatGoogle,
					FaceSmiling.GrinningFaceWithSweatFacebook,
					FaceSmiling.GrinningFaceWithSweatWindows,
					FaceSmiling.GrinningFaceWithSweatTwitter,
					FaceSmiling.GrinningFaceWithSweatJoyPixels,
					FaceSmiling.GrinningFaceWithSweatSamsung);
			}
		}

		private void ButtonRollingOnTheFloorLaughing_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonRollingOnTheFloorLaughing.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F923", buttonRollingOnTheFloorLaughing.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonRollingOnTheFloorLaughing.Tag,
					FaceSmiling.RollingOnTheFloorLaughingApple,
					FaceSmiling.RollingOnTheFloorLaughingGoogle,
					FaceSmiling.RollingOnTheFloorLaughingFacebook,
					FaceSmiling.RollingOnTheFloorLaughingWindows,
					FaceSmiling.RollingOnTheFloorLaughingTwitter,
					FaceSmiling.RollingOnTheFloorLaughingJoyPixels,
					FaceSmiling.RollingOnTheFloorLaughingSamsung);
			}
		}

		private void ButtonFaceWithTearsOfJoy_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithTearsOfJoy.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F602", buttonFaceWithTearsOfJoy.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonFaceWithTearsOfJoy.Tag,
					FaceSmiling.FaceWithTearsOfJoyApple,
					FaceSmiling.FaceWithTearsOfJoyGoogle,
					FaceSmiling.FaceWithTearsOfJoyFacebook,
					FaceSmiling.FaceWithTearsOfJoyWindows,
					FaceSmiling.FaceWithTearsOfJoyTwitter,
					FaceSmiling.FaceWithTearsOfJoyJoyPixels,
					FaceSmiling.FaceWithTearsOfJoySamsung);
			}
		}

		private void ButtonSlightlySmilingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSlightlySmilingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F642", buttonSlightlySmilingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonSlightlySmilingFace.Tag,
					FaceSmiling.SlightlySmilingFaceApple,
					FaceSmiling.SlightlySmilingFaceGoogle,
					FaceSmiling.SlightlySmilingFaceFacebook,
					FaceSmiling.SlightlySmilingFaceWindows,
					FaceSmiling.SlightlySmilingFaceTwitter,
					FaceSmiling.SlightlySmilingFaceJoyPixels,
					FaceSmiling.SlightlySmilingFaceSamsung);
			}
		}

		private void ButtonUpsideDownFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonUpsideDownFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F643", buttonUpsideDownFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonUpsideDownFace.Tag,
					FaceSmiling.UpsideDownFaceApple,
					FaceSmiling.UpsideDownFaceGoogle,
					FaceSmiling.UpsideDownFaceFacebook,
					FaceSmiling.UpsideDownFaceWindows,
					FaceSmiling.UpsideDownFaceTwitter,
					FaceSmiling.UpsideDownFaceJoyPixels,
					FaceSmiling.UpsideDownFaceSamsung);
			}
		}

		private void ButtonWinkingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWinkingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F609", buttonWinkingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonWinkingFace.Tag,
					FaceSmiling.WinkingFaceApple,
					FaceSmiling.WinkingFaceGoogle,
					FaceSmiling.WinkingFaceFacebook,
					FaceSmiling.WinkingFaceWindows,
					FaceSmiling.WinkingFaceTwitter,
					FaceSmiling.WinkingFaceJoyPixels,
					FaceSmiling.WinkingFaceSamsung);
			}
		}

		private void ButtonSmilingFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithSmilingEyes.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F60A", buttonSmilingFaceWithSmilingEyes.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonSmilingFaceWithSmilingEyes.Tag,
					FaceSmiling.SmilingFaceWithSmilingEyesApple,
					FaceSmiling.SmilingFaceWithSmilingEyesGoogle,
					FaceSmiling.SmilingFaceWithSmilingEyesFacebook,
					FaceSmiling.SmilingFaceWithSmilingEyesWindows,
					FaceSmiling.SmilingFaceWithSmilingEyesTwitter,
					FaceSmiling.SmilingFaceWithSmilingEyesJoyPixels,
					FaceSmiling.SmilingFaceWithSmilingEyesSamsung);
			}
		}

		private void ButtonSmilingFaceWithHalo_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithHalo.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F607", buttonSmilingFaceWithHalo.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSmiling,
					buttonSmilingFaceWithHalo.Tag,
					FaceSmiling.SmilingFaceWithHaloApple,
					FaceSmiling.SmilingFaceWithHaloGoogle,
					FaceSmiling.SmilingFaceWithHaloFacebook,
					FaceSmiling.SmilingFaceWithHaloWindows,
					FaceSmiling.SmilingFaceWithHaloTwitter,
					FaceSmiling.SmilingFaceWithHaloJoyPixels,
					FaceSmiling.SmilingFaceWithHaloSamsung);
			}
		}

		private void ButtonSmilingFaceWithHearts_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithHearts.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F970", buttonSmilingFaceWithHearts.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonSmilingFaceWithHearts.Tag,
					FaceAffection.SmilingFaceWithHeartsApple,
					FaceAffection.SmilingFaceWithHeartsGoogle,
					FaceAffection.SmilingFaceWithHeartsFacebook,
					FaceAffection.SmilingFaceWithHeartsWindows,
					FaceAffection.SmilingFaceWithHeartsTwitter,
					FaceAffection.SmilingFaceWithHeartsJoyPixels,
					FaceAffection.SmilingFaceWithHeartsSamsung);
			}
		}

		private void ButtonSmilingFaceWithHeartEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithHeartEyes.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F60D", buttonSmilingFaceWithHeartEyes.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonSmilingFaceWithHeartEyes.Tag,
					FaceAffection.SmilingFaceWithHeartEyesApple,
					FaceAffection.SmilingFaceWithHeartEyesGoogle,
					FaceAffection.SmilingFaceWithHeartEyesFacebook,
					FaceAffection.SmilingFaceWithHeartEyesWindows,
					FaceAffection.SmilingFaceWithHeartEyesTwitter,
					FaceAffection.SmilingFaceWithHeartEyesJoyPixels,
					FaceAffection.SmilingFaceWithHeartEyesSamsung);
			}
		}

		private void ButtonStarStruck_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonStarStruck.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F929", buttonStarStruck.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonStarStruck.Tag,
					FaceAffection.StarStruckApple,
					FaceAffection.StarStruckGoogle,
					FaceAffection.StarStruckFacebook,
					FaceAffection.StarStruckWindows,
					FaceAffection.StarStruckTwitter,
					FaceAffection.StarStruckJoyPixels,
					FaceAffection.StarStruckSamsung);
			}
		}

		private void ButtonFaceBlowingAKiss_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceBlowingAKiss.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F618", buttonFaceBlowingAKiss.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonFaceBlowingAKiss.Tag,
					FaceAffection.FaceBlowingAKissApple,
					FaceAffection.FaceBlowingAKissGoogle,
					FaceAffection.FaceBlowingAKissFacebook,
					FaceAffection.FaceBlowingAKissWindows,
					FaceAffection.FaceBlowingAKissTwitter,
					FaceAffection.FaceBlowingAKissJoyPixels,
					FaceAffection.FaceBlowingAKissSamsung);
			}
		}

		private void ButtonKissingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonKissingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F617", buttonKissingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonKissingFace.Tag,
					FaceAffection.KissingFaceApple,
					FaceAffection.KissingFaceGoogle,
					FaceAffection.KissingFaceFacebook,
					FaceAffection.KissingFaceWindows,
					FaceAffection.KissingFaceTwitter,
					FaceAffection.KissingFaceJoyPixels,
					FaceAffection.KissingFaceSamsung);
			}
		}

		private void ButtonSmilingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+263A", buttonSmilingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonSmilingFace.Tag,
					FaceAffection.SmilingFaceApple,
					FaceAffection.SmilingFaceGoogle,
					FaceAffection.SmilingFaceFacebook,
					FaceAffection.SmilingFaceWindows,
					FaceAffection.SmilingFaceTwitter,
					FaceAffection.SmilingFaceJoyPixels,
					FaceAffection.SmilingFaceSamsung);
			}
		}

		private void ButtonKissingFaceWithClosedEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonKissingFaceWithClosedEyes.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F61A", buttonKissingFaceWithClosedEyes.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonKissingFaceWithClosedEyes.Tag,
					FaceAffection.KissingFaceWithClosedEyesApple,
					FaceAffection.KissingFaceWithClosedEyesGoogle,
					FaceAffection.KissingFaceWithClosedEyesFacebook,
					FaceAffection.KissingFaceWithClosedEyesWindows,
					FaceAffection.KissingFaceWithClosedEyesTwitter,
					FaceAffection.KissingFaceWithClosedEyesJoyPixels,
					FaceAffection.KissingFaceWithClosedEyesSamsung);
			}
		}

		private void ButtonKissingFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonKissingFaceWithSmilingEyes.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F619", buttonKissingFaceWithSmilingEyes.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonKissingFaceWithSmilingEyes.Tag,
					FaceAffection.KissingFaceWithSmilingEyesApple,
					FaceAffection.KissingFaceWithSmilingEyesGoogle,
					FaceAffection.KissingFaceWithSmilingEyesFacebook,
					FaceAffection.KissingFaceWithSmilingEyesWindows,
					FaceAffection.KissingFaceWithSmilingEyesTwitter,
					FaceAffection.KissingFaceWithSmilingEyesJoyPixels,
					FaceAffection.KissingFaceWithSmilingEyesSamsung);
			}
		}

		private void ButtonSmilingFaceWithTear_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmilingFaceWithTear.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F972", buttonSmilingFaceWithTear.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceAffection,
					buttonSmilingFaceWithTear.Tag,
					null,
					FaceAffection.SmilingFaceWithTearGoogle,
					null,
					null,
					null,
					FaceAffection.SmilingFaceWithTearJoyPixels,
					null);
			}
		}

		private void ButtonFaceSavoringFood_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceSavoringFood.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F60B", buttonFaceSavoringFood.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceTongue,
					buttonFaceSavoringFood.Tag,
					FaceTongue.FaceSavoringFoodApple,
					FaceTongue.FaceSavoringFoodGoogle,
					FaceTongue.FaceSavoringFoodFacebook,
					FaceTongue.FaceSavoringFoodWindows,
					FaceTongue.FaceSavoringFoodTwitter,
					FaceTongue.FaceSavoringFoodJoyPixels,
					FaceTongue.FaceSavoringFoodSamsung);
			}
		}

		private void ButtonFaceWithTongue_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithTongue.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F61B", buttonFaceWithTongue.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceTongue,
					buttonFaceWithTongue.Tag,
					FaceTongue.FaceWithTongueApple,
					FaceTongue.FaceWithTongueGoogle,
					FaceTongue.FaceWithTongueFacebook,
					FaceTongue.FaceWithTongueWindows,
					FaceTongue.FaceWithTongueTwitter,
					FaceTongue.FaceWithTongueJoyPixels,
					FaceTongue.FaceWithTongueSamsung);
			}
		}

		private void ButtonWinkingFaceWithTongue_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonWinkingFaceWithTongue.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F61C", buttonWinkingFaceWithTongue.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceTongue,
					buttonWinkingFaceWithTongue.Tag,
					FaceTongue.WinkingFaceWithTongueApple,
					FaceTongue.WinkingFaceWithTongueGoogle,
					FaceTongue.WinkingFaceWithTongueFacebook,
					FaceTongue.WinkingFaceWithTongueWindows,
					FaceTongue.WinkingFaceWithTongueTwitter,
					FaceTongue.WinkingFaceWithTongueJoyPixels,
					FaceTongue.WinkingFaceWithTongueSamsung);
			}
		}

		private void ButtonZanyFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonZanyFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F92A", buttonZanyFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceTongue,
					buttonZanyFace.Tag,
					FaceTongue.ZanyFaceApple,
					FaceTongue.ZanyFaceGoogle,
					FaceTongue.ZanyFaceFacebook,
					FaceTongue.ZanyFaceWindows,
					FaceTongue.ZanyFaceTwitter,
					FaceTongue.ZanyFaceJoyPixels,
					FaceTongue.ZanyFaceSamsung);
			}
		}

		private void ButtonSquintingFaceWithTongue_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSquintingFaceWithTongue.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F61D", buttonSquintingFaceWithTongue.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceTongue,
					buttonSquintingFaceWithTongue.Tag,
					FaceTongue.SquintingFaceWithTongueApple,
					FaceTongue.SquintingFaceWithTongueGoogle,
					FaceTongue.SquintingFaceWithTongueFacebook,
					FaceTongue.SquintingFaceWithTongueWindows,
					FaceTongue.SquintingFaceWithTongueTwitter,
					FaceTongue.SquintingFaceWithTongueJoyPixels,
					FaceTongue.SquintingFaceWithTongueSamsung);
			}
		}

		private void ButtonMoneyMouthFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonMoneyMouthFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F911", buttonMoneyMouthFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceTongue,
					buttonMoneyMouthFace.Tag,
					FaceTongue.MoneyMouthFaceApple,
					FaceTongue.MoneyMouthFaceGoogle,
					FaceTongue.MoneyMouthFaceFacebook,
					FaceTongue.MoneyMouthFaceWindows,
					FaceTongue.MoneyMouthFaceTwitter,
					FaceTongue.MoneyMouthFaceJoyPixels,
					FaceTongue.MoneyMouthFaceSamsung);
			}
		}

		private void ButtonHuggingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonHuggingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F917", buttonHuggingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceHand,
					buttonHuggingFace.Tag,
					FaceHand.HuggingFaceApple,
					FaceHand.HuggingFaceGoogle,
					FaceHand.HuggingFaceFacebook,
					FaceHand.HuggingFaceWindows,
					FaceHand.HuggingFaceTwitter,
					FaceHand.HuggingFaceJoyPixels,
					FaceHand.HuggingFaceSamsung);
			}
		}

		private void ButtonFaceWithHandOverMouth_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithHandOverMouth.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F92D", buttonFaceWithHandOverMouth.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceHand,
					buttonFaceWithHandOverMouth.Tag,
					FaceHand.FaceWithHandOverMouthApple,
					FaceHand.FaceWithHandOverMouthGoogle,
					FaceHand.FaceWithHandOverMouthFacebook,
					FaceHand.FaceWithHandOverMouthWindows,
					FaceHand.FaceWithHandOverMouthTwitter,
					FaceHand.FaceWithHandOverMouthJoyPixels,
					FaceHand.FaceWithHandOverMouthSamsung);
			}
		}

		private void ButtonShushingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonShushingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F92B", buttonShushingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceHand,
					buttonShushingFace.Tag,
					FaceHand.ShushingFaceApple,
					FaceHand.ShushingFaceGoogle,
					FaceHand.ShushingFaceFacebook,
					FaceHand.ShushingFaceWindows,
					FaceHand.ShushingFaceTwitter,
					FaceHand.ShushingFaceJoyPixels,
					FaceHand.ShushingFaceSamsung);
			}
		}

		private void ButtonThinkingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonThinkingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F914", buttonThinkingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceHand,
					buttonThinkingFace.Tag,
					FaceHand.ThinkingFaceApple,
					FaceHand.ThinkingFaceGoogle,
					FaceHand.ThinkingFaceFacebook,
					FaceHand.ThinkingFaceWindows,
					FaceHand.ThinkingFaceTwitter,
					FaceHand.ThinkingFaceJoyPixels,
					FaceHand.ThinkingFaceSamsung);
			}
		}

		private void ButtonZipperMouthFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonZipperMouthFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F910", buttonZipperMouthFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonZipperMouthFace.Tag,
					FaceNeutralSkeptical.ZipperMouthFaceApple,
					FaceNeutralSkeptical.ZipperMouthFaceGoogle,
					FaceNeutralSkeptical.ZipperMouthFaceFacebook,
					FaceNeutralSkeptical.ZipperMouthFaceWindows,
					FaceNeutralSkeptical.ZipperMouthFaceTwitter,
					FaceNeutralSkeptical.ZipperMouthFaceJoyPixels,
					FaceNeutralSkeptical.ZipperMouthFaceSamsung);
			}
		}

		private void ButtonFaceWithRaisedEyebrow_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithRaisedEyebrow.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F928", buttonFaceWithRaisedEyebrow.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonFaceWithRaisedEyebrow.Tag,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowApple,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowGoogle,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowFacebook,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowWindows,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowTwitter,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowJoyPixels,
					FaceNeutralSkeptical.FaceWithRaisedEyebrowSamsung);
			}
		}

		private void ButtonNeutralFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonNeutralFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F610", buttonNeutralFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonNeutralFace.Tag,
					FaceNeutralSkeptical.NeutralFaceApple,
					FaceNeutralSkeptical.NeutralFaceGoogle,
					FaceNeutralSkeptical.NeutralFaceFacebook,
					FaceNeutralSkeptical.NeutralFaceWindows,
					FaceNeutralSkeptical.NeutralFaceTwitter,
					FaceNeutralSkeptical.NeutralFaceJoyPixels,
					FaceNeutralSkeptical.NeutralFaceSamsung);
			}
		}

		private void ButtonExpressionlessFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonExpressionlessFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F611", buttonExpressionlessFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonExpressionlessFace.Tag,
					FaceNeutralSkeptical.ExpressionlessFaceApple,
					FaceNeutralSkeptical.ExpressionlessFaceGoogle,
					FaceNeutralSkeptical.ExpressionlessFaceFacebook,
					FaceNeutralSkeptical.ExpressionlessFaceWindows,
					FaceNeutralSkeptical.ExpressionlessFaceTwitter,
					FaceNeutralSkeptical.ExpressionlessFaceJoyPixels,
					FaceNeutralSkeptical.ExpressionlessFaceSamsung);
			}
		}

		private void ButtonFaceWithoutMouth_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithoutMouth.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F636", buttonFaceWithoutMouth.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonFaceWithoutMouth.Tag,
					FaceNeutralSkeptical.FaceWithoutMouthApple,
					FaceNeutralSkeptical.FaceWithoutMouthGoogle,
					FaceNeutralSkeptical.FaceWithoutMouthFacebook,
					FaceNeutralSkeptical.FaceWithoutMouthWindows,
					FaceNeutralSkeptical.FaceWithoutMouthTwitter,
					FaceNeutralSkeptical.FaceWithoutMouthJoyPixels,
					FaceNeutralSkeptical.FaceWithoutMouthSamsung);
			}
		}

		private void ButtonSmirkingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSmirkingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F60F", buttonSmirkingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonSmirkingFace.Tag,
					FaceNeutralSkeptical.SmirkingFaceApple,
					FaceNeutralSkeptical.SmirkingFaceGoogle,
					FaceNeutralSkeptical.SmirkingFaceFacebook,
					FaceNeutralSkeptical.SmirkingFaceWindows,
					FaceNeutralSkeptical.SmirkingFaceTwitter,
					FaceNeutralSkeptical.SmirkingFaceJoyPixels,
					FaceNeutralSkeptical.SmirkingFaceSamsung);
			}
		}

		private void ButtonUnamusedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonUnamusedFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F612", buttonUnamusedFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonUnamusedFace.Tag,
					FaceNeutralSkeptical.UnamusedFaceApple,
					FaceNeutralSkeptical.UnamusedFaceGoogle,
					FaceNeutralSkeptical.UnamusedFaceFacebook,
					FaceNeutralSkeptical.UnamusedFaceWindows,
					FaceNeutralSkeptical.UnamusedFaceTwitter,
					FaceNeutralSkeptical.UnamusedFaceJoyPixels,
					FaceNeutralSkeptical.UnamusedFaceSamsung);
			}
		}

		private void ButtonFaceWithRollingEyes_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonFaceWithRollingEyes.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F644", buttonFaceWithRollingEyes.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonFaceWithRollingEyes.Tag,
					FaceNeutralSkeptical.FaceWithRollingEyesApple,
					FaceNeutralSkeptical.FaceWithRollingEyesGoogle,
					FaceNeutralSkeptical.FaceWithRollingEyesFacebook,
					FaceNeutralSkeptical.FaceWithRollingEyesWindows,
					FaceNeutralSkeptical.FaceWithRollingEyesTwitter,
					FaceNeutralSkeptical.FaceWithRollingEyesJoyPixels,
					FaceNeutralSkeptical.FaceWithRollingEyesSamsung);
			}
		}

		private void ButtonGrimacingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonGrimacingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F62C", buttonGrimacingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonGrimacingFace.Tag,
					FaceNeutralSkeptical.GrimacingFaceApple,
					FaceNeutralSkeptical.GrimacingFaceGoogle,
					FaceNeutralSkeptical.GrimacingFaceFacebook,
					FaceNeutralSkeptical.GrimacingFaceWindows,
					FaceNeutralSkeptical.GrimacingFaceTwitter,
					FaceNeutralSkeptical.GrimacingFaceJoyPixels,
					FaceNeutralSkeptical.GrimacingFaceSamsung);
			}
		}

		private void ButtonLyingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonLyingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F925", buttonLyingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceNeutralSkeptical,
					buttonLyingFace.Tag,
					FaceNeutralSkeptical.LyingFaceApple,
					FaceNeutralSkeptical.LyingFaceGoogle,
					FaceNeutralSkeptical.LyingFaceFacebook,
					FaceNeutralSkeptical.LyingFaceWindows,
					FaceNeutralSkeptical.LyingFaceTwitter,
					FaceNeutralSkeptical.LyingFaceJoyPixels,
					FaceNeutralSkeptical.LyingFaceSamsung);
			}
		}

		private void ButtonRelievedFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonRelievedFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F60C", buttonRelievedFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSleepy,
					buttonRelievedFace.Tag,
					FaceSleepy.RelievedFaceApple,
					FaceSleepy.RelievedFaceGoogle,
					FaceSleepy.RelievedFaceFacebook,
					FaceSleepy.RelievedFaceWindows,
					FaceSleepy.RelievedFaceTwitter,
					FaceSleepy.RelievedFaceJoyPixels,
					FaceSleepy.RelievedFaceSamsung);
			}
		}

		private void ButtonPensiveFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonPensiveFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F614", buttonPensiveFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSleepy,
					buttonPensiveFace.Tag,
					FaceSleepy.PensiveFaceApple,
					FaceSleepy.PensiveFaceGoogle,
					FaceSleepy.PensiveFaceFacebook,
					FaceSleepy.PensiveFaceWindows,
					FaceSleepy.PensiveFaceTwitter,
					FaceSleepy.PensiveFaceJoyPixels,
					FaceSleepy.PensiveFaceSamsung);
			}
		}

		private void ButtonSleepyFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSleepyFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F62A", buttonSleepyFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSleepy,
					buttonSleepyFace.Tag,
					FaceSleepy.SleepyFaceApple,
					FaceSleepy.SleepyFaceGoogle,
					FaceSleepy.SleepyFaceFacebook,
					FaceSleepy.SleepyFaceWindows,
					FaceSleepy.SleepyFaceTwitter,
					FaceSleepy.SleepyFaceJoyPixels,
					FaceSleepy.SleepyFaceSamsung);
			}
		}

		private void ButtonDroolingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonDroolingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F924", buttonDroolingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSleepy,
					buttonDroolingFace.Tag,
					FaceSleepy.DroolingFaceApple,
					FaceSleepy.DroolingFaceGoogle,
					FaceSleepy.DroolingFaceFacebook,
					FaceSleepy.DroolingFaceWindows,
					FaceSleepy.DroolingFaceTwitter,
					FaceSleepy.DroolingFaceJoyPixels,
					FaceSleepy.DroolingFaceSamsung);
			}
		}

		private void ButtonSleepingFace_Click(object sender, EventArgs e)
		{
			if (buttonPickerMode.Checked)
			{
				CopyToClipboard(buttonSleepingFace.Tag.ToString());
			}
			else
			{
				ShowEmojiInfo("U+1F634", buttonSleepingFace.AccessibleName,
					Properties.Resources.smileysAndEmotion, Properties.Resources.faceSleepy,
					buttonSleepingFace.Tag,
					FaceSleepy.SleepingFaceApple,
					FaceSleepy.SleepingFaceGoogle,
					FaceSleepy.SleepingFaceFacebook,
					FaceSleepy.SleepingFaceWindows,
					FaceSleepy.SleepingFaceTwitter,
					FaceSleepy.SleepingFaceJoyPixels,
					FaceSleepy.SleepingFaceSamsung);
			}
		}
	}
}