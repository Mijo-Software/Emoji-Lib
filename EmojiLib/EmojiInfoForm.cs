using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmojiLib
{
	public partial class EmojiInfoForm : Form
	{
		public void SetTag(object tag) => Tag = tag;

		public void SetCode(string code) => labelCodeDesc.Text = code;

		public void SetShortName(string name) => labelShortNameDesc.Text = name;

		public void SetGroup(string group) => labelGroupDesc.Text = group;

		public void SetSubGroup(string subGroup) => labelSubGroupDesc.Text = subGroup;

		public void SetAppleImageVersion(Image image)
		{
			if (image == null)
			{
				labelAppleVersion.Enabled = false;
				pictureBoxApple.Enabled = false;
			}
			else
			{
				pictureBoxApple.Image = image;
			}
		}

		public void SetGoogleImageVersion(Image image)
		{
			if (image == null)
			{
				labelGoogleVersion.Enabled = false;
				pictureBoxGoogle.Enabled = false;
			}
			else
			{
				pictureBoxGoogle.Image = image;
			}
		}

		public void SetFacebookImageVersion(Image image)
		{
			if (image == null)
			{
				labelFacebookVersion.Enabled = false;
				pictureBoxFacebook.Enabled = false;
			}
			else
			{
				pictureBoxFacebook.Image = image;
			}
		}

		public void SetWindowsImageVersion(Image image)
		{
			if (image == null)
			{
				labelWindowsVersion.Enabled = false;
				pictureBoxWindows.Enabled = false;
			}
			else
			{
				pictureBoxWindows.Image = image;
			}
		}

		public void SetTwitterImageVersion(Image image)
		{
			if (image == null)
			{
				labelTwitterVersion.Enabled = false;
				pictureBoxTwitter.Enabled = false;
			}
			else
			{
				pictureBoxTwitter.Image = image;
			}
		}

		public void SetJoyPixelsImageVersion(Image image)
		{
			if (image == null)
			{
				labelJoyPixelsVersion.Enabled = false;
				pictureBoxJoyPixels.Enabled = false;
			}
			else
			{
				pictureBoxJoyPixels.Image = image;
			}
		}

		public void SetSamsungImageVersion(Image image)
		{
			if (image == null)
			{
				labelSamsungVersion.Enabled = false;
				pictureBoxSamsung.Enabled = false;
			}
			else
			{
				pictureBoxSamsung.Image = image;
			}
		}

		public void SetGmailImageVersion(Image image)
		{
			if (image == null)
			{
				labelGmailVersion.Enabled = false;
				pictureBoxGmail.Enabled = false;
			}
			else
			{
				pictureBoxGmail.Image = image;
			}
		}

		public void SetDocomoImageVersion(Image image)
		{
			if (image == null)
			{
				labelDocomoVersion.Enabled = false;
				pictureBoxDocomo.Enabled = false;
			}
			else
			{
				pictureBoxDocomo.Image = image;
			}
		}

		public void SetKddiImageVersion(Image image)
		{
			if (image == null)
			{
				labelKddiVersion.Enabled = false;
				pictureBoxKddi.Enabled = false;
			}
			else
			{
				pictureBoxKddi.Image = image;
			}
		}

		public void SetSoftbankImageVersion(Image image)
		{
			if (image == null)
			{
				labelSoftbankVersion.Enabled = false;
				pictureBoxSoftbank.Enabled = false;
			}
			else
			{
				pictureBoxSoftbank.Image = image;
			}
		}

		public EmojiInfoForm() => InitializeComponent();

		private void EmojiInfoForm_Click(object sender, EventArgs e) => Close();

		private void PictureBoxApple_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxApple.Image != null)
			{
				labelAppleVersion.ForeColor = SystemColors.Highlight;
				pictureBoxApple.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxGoogle_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxGoogle.Image != null)
			{
				labelGoogleVersion.ForeColor = SystemColors.Highlight;
				pictureBoxGoogle.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxFacebook_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxFacebook.Image != null)
			{
				labelFacebookVersion.ForeColor = SystemColors.Highlight;
				pictureBoxFacebook.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxWindows_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxWindows.Image != null)
			{
				labelWindowsVersion.ForeColor = SystemColors.Highlight;
				pictureBoxWindows.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxTwitter_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxTwitter.Image != null)
			{
				labelTwitterVersion.ForeColor = SystemColors.Highlight;
				pictureBoxTwitter.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxJoyPixels_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxJoyPixels.Image != null)
			{
				labelJoyPixelsVersion.ForeColor = SystemColors.Highlight;
				pictureBoxJoyPixels.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxSamsung_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxSamsung.Image != null)
			{
				labelSamsungVersion.ForeColor = SystemColors.Highlight;
				pictureBoxSamsung.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxGmail_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxGmail.Image != null)
			{
				labelGmailVersion.ForeColor = SystemColors.Highlight;
				pictureBoxGmail.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxDocomo_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxDocomo.Image != null)
			{
				labelDocomoVersion.ForeColor = SystemColors.Highlight;
				pictureBoxDocomo.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxKddi_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxKddi.Image != null)
			{
				labelKddiVersion.ForeColor = SystemColors.Highlight;
				pictureBoxKddi.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxSoftbank_MouseEnter(object sender, EventArgs e)
		{
			if (pictureBoxSoftbank.Image != null)
			{
				labelSoftbankVersion.ForeColor = SystemColors.Highlight;
				pictureBoxSoftbank.Cursor = Cursors.Hand;
			}
		}

		private void PictureBoxApple_MouseLeave(object sender, EventArgs e)
		{
			labelAppleVersion.ForeColor = SystemColors.ControlText;
			pictureBoxApple.Cursor = Cursors.Default;
		}

		private void PictureBoxGoogle_MouseLeave(object sender, EventArgs e)
		{
			labelGoogleVersion.ForeColor = SystemColors.ControlText;
			pictureBoxGoogle.Cursor = Cursors.Default;
		}

		private void PictureBoxFacebook_MouseLeave(object sender, EventArgs e)
		{
			labelFacebookVersion.ForeColor = SystemColors.ControlText;
			pictureBoxFacebook.Cursor = Cursors.Default;
		}

		private void PictureBoxWindows_MouseLeave(object sender, EventArgs e)
		{
			labelWindowsVersion.ForeColor = SystemColors.ControlText;
			pictureBoxWindows.Cursor = Cursors.Default;
		}

		private void PictureBoxTwitter_MouseLeave(object sender, EventArgs e)
		{
			labelTwitterVersion.ForeColor = SystemColors.ControlText;
			pictureBoxTwitter.Cursor = Cursors.Default;
		}

		private void PictureBoxJoyPixels_MouseLeave(object sender, EventArgs e)
		{
			labelJoyPixelsVersion.ForeColor = SystemColors.ControlText;
			pictureBoxJoyPixels.Cursor = Cursors.Default;
		}

		private void PictureBoxSamsung_MouseLeave(object sender, EventArgs e)
		{
			labelSamsungVersion.ForeColor = SystemColors.ControlText;
			pictureBoxSamsung.Cursor = Cursors.Default;
		}

		private void PictureBoxGmail_MouseLeave(object sender, EventArgs e)
		{
			labelGmailVersion.ForeColor = SystemColors.ControlText;
			pictureBoxGmail.Cursor = Cursors.Default;
		}

		private void PictureBoxDocomo_MouseLeave(object sender, EventArgs e)
		{
			labelDocomoVersion.ForeColor = SystemColors.ControlText;
			pictureBoxDocomo.Cursor = Cursors.Default;
		}

		private void PictureBoxKddi_MouseLeave(object sender, EventArgs e)
		{
			labelKddiVersion.ForeColor = SystemColors.ControlText;
			pictureBoxKddi.Cursor = Cursors.Default;
		}

		private void PictureBoxSoftbank_MouseLeave(object sender, EventArgs e)
		{
			labelSoftbankVersion.ForeColor = SystemColors.ControlText;
			pictureBoxSoftbank.Cursor = Cursors.Default;
		}

		private void PictureBoxApple_Click(object sender, EventArgs e)
		{
			if (pictureBoxApple.Image != null)
			{
				if (saveFileDialogAsPng.ShowDialog() == DialogResult.OK)
				{
					pictureBoxApple.Image.Save(filename: saveFileDialogAsPng.FileName);
				}
			}
		}

		private void PictureBoxGoogle_Click(object sender, EventArgs e)
		{
			if (pictureBoxGoogle.Image != null)
			{
				if (saveFileDialogAsPng.ShowDialog() == DialogResult.OK)
				{
					pictureBoxGoogle.Image.Save(filename: saveFileDialogAsPng.FileName);
				}
			}
		}

		private void PictureBoxFacebook_Click(object sender, EventArgs e)
		{
			if (pictureBoxFacebook.Image != null)
			{
				if (saveFileDialogAsPng.ShowDialog() == DialogResult.OK)
				{
					pictureBoxFacebook.Image.Save(filename: saveFileDialogAsPng.FileName);
				}
			}
		}

		private void PictureBoxWindows_Click(object sender, EventArgs e)
		{
			if (pictureBoxWindows.Image != null)
			{
				if (saveFileDialogAsPng.ShowDialog() == DialogResult.OK)
				{
					pictureBoxWindows.Image.Save(filename: saveFileDialogAsPng.FileName);
				}
			}
		}

		private void PictureBoxTwitter_Click(object sender, EventArgs e)
		{
			if (pictureBoxTwitter.Image != null)
			{
				if (saveFileDialogAsPng.ShowDialog() == DialogResult.OK)
				{
					pictureBoxTwitter.Image.Save(filename: saveFileDialogAsPng.FileName);
				}
			}
		}

		private void PictureBoxJoyPixels_Click(object sender, EventArgs e)
		{
			if (pictureBoxJoyPixels.Image != null)
			{
				if (saveFileDialogAsPng.ShowDialog() == DialogResult.OK)
				{
					pictureBoxJoyPixels.Image.Save(filename: saveFileDialogAsPng.FileName);
				}
			}
		}

		private void PictureBoxSamsung_Click(object sender, EventArgs e)
		{
			if (pictureBoxSamsung.Image != null)
			{
				if (saveFileDialogAsPng.ShowDialog() == DialogResult.OK)
				{
					pictureBoxSamsung.Image.Save(filename: saveFileDialogAsPng.FileName);
				}
			}
		}

		private void PictureBoxGmail_Click(object sender, EventArgs e)
		{
			if (pictureBoxGmail.Image != null)
			{
				if (saveFileDialogAsGif.ShowDialog() == DialogResult.OK)
				{
					pictureBoxGmail.Image.Save(filename: saveFileDialogAsGif.FileName);
				}
			}
		}

		private void PictureBoxDocomo_Click(object sender, EventArgs e)
		{
			if (pictureBoxDocomo.Image != null)
			{
				if (saveFileDialogAsGif.ShowDialog() == DialogResult.OK)
				{
					pictureBoxDocomo.Image.Save(filename: saveFileDialogAsGif.FileName);
				}
			}
		}

		private void PictureBoxKddi_Click(object sender, EventArgs e)
		{
			if (pictureBoxKddi.Image != null)
			{
				if (saveFileDialogAsGif.ShowDialog() == DialogResult.OK)
				{
					pictureBoxKddi.Image.Save(filename: saveFileDialogAsGif.FileName);
				}
			}
		}

		private void PictureBoxSoftbank_Click(object sender, EventArgs e)
		{
			if (pictureBoxSoftbank.Image != null)
			{
				if (saveFileDialogAsGif.ShowDialog() == DialogResult.OK)
				{
					pictureBoxSoftbank.Image.Save(filename: saveFileDialogAsGif.FileName);
				}
			}
		}
	}
}