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

		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonGrinningFace_Click(object sender, EventArgs e)
		{
			EmojiInfoForm emojiInfo = new EmojiInfoForm();
			emojiInfo.SetCode("U+1F600");
			emojiInfo.SetShortName("grinning face");
			emojiInfo.SetAppleImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceApple);
			emojiInfo.SetGoogleImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceGoogle);
			emojiInfo.SetFacebookImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceFacebook);
			emojiInfo.SetWindowsImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWindows);
			emojiInfo.SetTwitterImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceTwitter);
			emojiInfo.SetJoyPixelsImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceJoyPixels);
			emojiInfo.SetSamsungImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceSamsung);
			emojiInfo.ShowDialog();
		}

		private void ButtonGrinningFaceWithBigEyes_Click(object sender, EventArgs e)
		{
			EmojiInfoForm emojiInfo = new EmojiInfoForm();
			emojiInfo.SetCode("U+1F603");
			emojiInfo.SetShortName("grinning face with big eyes");
			emojiInfo.SetAppleImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesApple);
			emojiInfo.SetGoogleImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesGoogle);
			emojiInfo.SetFacebookImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesFacebook);
			emojiInfo.SetWindowsImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesWindows);
			emojiInfo.SetTwitterImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesTwitter);
			emojiInfo.SetJoyPixelsImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesJoyPixels);
			emojiInfo.SetSamsungImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithBigEyesSamsung);
			emojiInfo.ShowDialog();
		}

		private void ButtonGrinningFaceWithSmilingEyes_Click(object sender, EventArgs e)
		{
			EmojiInfoForm emojiInfo = new EmojiInfoForm();
			emojiInfo.SetCode("U+1F604");
			emojiInfo.SetShortName("grinning face with smiling eyes");
			emojiInfo.SetAppleImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesApple);
			emojiInfo.SetGoogleImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesGoogle);
			emojiInfo.SetFacebookImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesFacebook);
			emojiInfo.SetWindowsImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesWindows);
			emojiInfo.SetTwitterImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesTwitter);
			emojiInfo.SetJoyPixelsImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesJoyPixels);
			emojiInfo.SetSamsungImageVersion(global::EmojiLib.Properties.Resources.GrinningFaceWithSmilingEyesSamsung);
			emojiInfo.ShowDialog();
		}
	}
}
