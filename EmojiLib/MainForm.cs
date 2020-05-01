using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
			SetStatusbar(text: ""); 
		}

		#endregion

		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ShowEmojiInfo(string code, string shortName, Image appleVersion, Image googleVersion, Image facebookVersion, Image windowsVersion, Image twitterVersion, Image joypixelsVersion, Image samsungVersion)
		{
			EmojiInfoForm emojiInfo = new EmojiInfoForm();
			emojiInfo.SetCode(code);
			emojiInfo.SetShortName(shortName);
			emojiInfo.SetAppleImageVersion(appleVersion);
			emojiInfo.SetGoogleImageVersion(googleVersion);
			emojiInfo.SetFacebookImageVersion(facebookVersion);
			emojiInfo.SetWindowsImageVersion(windowsVersion);
			emojiInfo.SetTwitterImageVersion(twitterVersion);
			emojiInfo.SetJoyPixelsImageVersion(joypixelsVersion);
			emojiInfo.SetSamsungImageVersion(samsungVersion);
			emojiInfo.ShowDialog();
		}

		private void ButtonGrinningFace_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F600", "grinning face",
				Properties.Resources.GrinningFaceApple,
				Properties.Resources.GrinningFaceGoogle,
				Properties.Resources.GrinningFaceFacebook,
				Properties.Resources.GrinningFaceWindows,
				Properties.Resources.GrinningFaceTwitter,
				Properties.Resources.GrinningFaceJoyPixels,
				Properties.Resources.GrinningFaceSamsung
				);
		}

		private void ButtonGrinningFaceWithBigEyes_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F603", "grinning face with big eyes",
				Properties.Resources.GrinningFaceWithBigEyesApple,
				Properties.Resources.GrinningFaceWithBigEyesGoogle,
				Properties.Resources.GrinningFaceWithBigEyesFacebook,
				Properties.Resources.GrinningFaceWithBigEyesWindows,
				Properties.Resources.GrinningFaceWithBigEyesTwitter,
				Properties.Resources.GrinningFaceWithBigEyesJoyPixels,
				Properties.Resources.GrinningFaceWithBigEyesSamsung
				);
		}

		private void ButtonGrinningFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F604", "grinning face with smiling eyes",
				Properties.Resources.GrinningFaceWithSmilingEyesApple,
				Properties.Resources.GrinningFaceWithSmilingEyesGoogle,
				Properties.Resources.GrinningFaceWithSmilingEyesFacebook,
				Properties.Resources.GrinningFaceWithSmilingEyesWindows,
				Properties.Resources.GrinningFaceWithSmilingEyesTwitter,
				Properties.Resources.GrinningFaceWithSmilingEyesJoyPixels,
				Properties.Resources.GrinningFaceWithSmilingEyesSamsung
				);
		}

		private void ButtonBeamingFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F601", "beaming face with smiling eyes",
				Properties.Resources.BeamingFaceWithSmilingEyesApple,
				Properties.Resources.BeamingFaceWithSmilingEyesGoogle,
				Properties.Resources.BeamingFaceWithSmilingEyesFacebook,
				Properties.Resources.BeamingFaceWithSmilingEyesWindows,
				Properties.Resources.BeamingFaceWithSmilingEyesTwitter,
				Properties.Resources.BeamingFaceWithSmilingEyesJoyPixels,
				Properties.Resources.BeamingFaceWithSmilingEyesSamsung
				);
		}

		private void ButtonGrinningSquintingFace_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F606", "grinning squinting face",
				Properties.Resources.GrinningSquintingFaceApple,
				Properties.Resources.GrinningSquintingFaceGoogle,
				Properties.Resources.GrinningSquintingFaceFacebook,
				Properties.Resources.GrinningSquintingFaceWindows,
				Properties.Resources.GrinningSquintingFaceTwitter,
				Properties.Resources.GrinningSquintingFaceJoyPixels,
				Properties.Resources.GrinningSquintingFaceSamsung
				);
		}

		private void ButtonGrinningFaceWithSweat_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F605", "grinning face with sweat",
				Properties.Resources.GrinningFaceWithSweatApple,
				Properties.Resources.GrinningFaceWithSweatGoogle,
				Properties.Resources.GrinningFaceWithSweatFacebook,
				Properties.Resources.GrinningFaceWithSweatWindows,
				Properties.Resources.GrinningFaceWithSweatTwitter,
				Properties.Resources.GrinningFaceWithSweatJoyPixels,
				Properties.Resources.GrinningFaceWithSweatSamsung
				);
		}

		private void ButtonRollingOnTheFloorLaughing_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F923", "rolling on the floor laughing",
				Properties.Resources.RollingOnTheFloorLaughingApple,
				Properties.Resources.RollingOnTheFloorLaughingGoogle,
				Properties.Resources.RollingOnTheFloorLaughingFacebook,
				Properties.Resources.RollingOnTheFloorLaughingWindows,
				Properties.Resources.RollingOnTheFloorLaughingTwitter,
				Properties.Resources.RollingOnTheFloorLaughingJoyPixels,
				Properties.Resources.RollingOnTheFloorLaughingSamsung
				);
		}

		private void ButtonFaceWithTearsOfJoy_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F602", "face with tears of joy",
				Properties.Resources.FaceWithTearsOfJoyApple,
				Properties.Resources.FaceWithTearsOfJoyGoogle,
				Properties.Resources.FaceWithTearsOfJoyFacebook,
				Properties.Resources.FaceWithTearsOfJoyWindows,
				Properties.Resources.FaceWithTearsOfJoyTwitter,
				Properties.Resources.FaceWithTearsOfJoyJoyPixels,
				Properties.Resources.FaceWithTearsOfJoySamsung
				);
		}

		private void ButtonSlightlySmilingFace_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F642", "slightly smiling face",
				Properties.Resources.SlightlySmilingFaceApple,
				Properties.Resources.SlightlySmilingFaceGoogle,
				Properties.Resources.SlightlySmilingFaceFacebook,
				Properties.Resources.SlightlySmilingFaceWindows,
				Properties.Resources.SlightlySmilingFaceTwitter,
				Properties.Resources.SlightlySmilingFaceJoyPixels,
				Properties.Resources.SlightlySmilingFaceSamsung
				);
		}

		private void ButtonUpsideDownFace_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F643", "upside-down face",
				Properties.Resources.UpsideDownFaceApple,
				Properties.Resources.UpsideDownFaceGoogle,
				Properties.Resources.UpsideDownFaceFacebook,
				Properties.Resources.UpsideDownFaceWindows,
				Properties.Resources.UpsideDownFaceTwitter,
				Properties.Resources.UpsideDownFaceJoyPixels,
				Properties.Resources.UpsideDownFaceSamsung
				);
		}

		private void ButtonWinkingFace_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F609", "winking face",
				Properties.Resources.WinkingFaceApple,
				Properties.Resources.WinkingFaceGoogle,
				Properties.Resources.WinkingFaceFacebook,
				Properties.Resources.WinkingFaceWindows,
				Properties.Resources.WinkingFaceTwitter,
				Properties.Resources.WinkingFaceJoyPixels,
				Properties.Resources.WinkingFaceSamsung
				);
		}

		private void ButtonSmilingFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F60A", "smiling face with smiling eyes",
				Properties.Resources.SmilingFaceWithSmilingEyesApple,
				Properties.Resources.SmilingFaceWithSmilingEyesGoogle,
				Properties.Resources.SmilingFaceWithSmilingEyesFacebook,
				Properties.Resources.SmilingFaceWithSmilingEyesWindows,
				Properties.Resources.SmilingFaceWithSmilingEyesTwitter,
				Properties.Resources.SmilingFaceWithSmilingEyesJoyPixels,
				Properties.Resources.SmilingFaceWithSmilingEyesSamsung
				);
		}

		private void ButtonSmilingFaceWithHalo_Click(object sender, EventArgs e)
		{
			ShowEmojiInfo("U+1F607", "smiling face with halo",
				Properties.Resources.SmilingFaceWithHaloApple,
				Properties.Resources.SmilingFaceWithHaloGoogle,
				Properties.Resources.SmilingFaceWithHaloFacebook,
				Properties.Resources.SmilingFaceWithHaloWindows,
				Properties.Resources.SmilingFaceWithHaloTwitter,
				Properties.Resources.SmilingFaceWithHaloJoyPixels,
				Properties.Resources.SmilingFaceWithHaloSamsung
				);
		}
	}
}