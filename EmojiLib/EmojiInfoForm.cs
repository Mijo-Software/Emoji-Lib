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
	public partial class EmojiInfoForm : Form
	{
		public void SetCode(string code)
		{
			labelCodeDesc.Text = code;
		}

		public void SetShortName(string name)
		{
			labelDescription.Text = name;
		}

		public void SetAppleImageVersion(Image image)
		{
			pictureBoxApple.Image = image;
		}

		public void SetGoogleImageVersion(Image image)
		{
			pictureBoxGoogle.Image = image;
		}

		public void SetFacebookImageVersion(Image image)
		{
			pictureBoxFacebook.Image = image;
		}

		public void SetWindowsImageVersion(Image image)
		{
			pictureBoxWindows.Image = image;
		}

		public void SetTwitterImageVersion(Image image)
		{
			pictureBoxTwitter.Image = image;
		}

		public void SetJoyPixelsImageVersion(Image image)
		{
			pictureBoxJoyPixels.Image = image;
		}

		public void SetSamsungImageVersion(Image image)
		{
			pictureBoxSamsung.Image = image;
		}

		public EmojiInfoForm()
		{
			InitializeComponent();
		}

		private void EmojiInfoForm_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
