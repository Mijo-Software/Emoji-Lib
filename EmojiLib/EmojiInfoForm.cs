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
		public void SetTag(object tag)
		{
			Tag = tag;
		}

		public void SetCode(string code)
		{
			labelCodeDesc.Text = code;
		}

		public void SetShortName(string name)
		{
			labelShortNameDesc.Text = name;
		}

		public void SetGroup(string group)
		{
			labelGroupDesc.Text = group;
		}

		public void SetSubGroup(string subGroup)
		{
			labelSubGroupDesc.Text = subGroup;
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

		private void PictureBoxApple_Click(object sender, EventArgs e)
		{
			if (pictureBoxApple.Image != null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxApple.Image.Save(saveFileDialog.FileName);
				}
			}
		}

		private void PictureBoxGoogle_Click(object sender, EventArgs e)
		{
			if (pictureBoxGoogle.Image != null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxGoogle.Image.Save(saveFileDialog.FileName);
				}
			}
		}

		private void PictureBoxFacebook_Click(object sender, EventArgs e)
		{
			if (pictureBoxFacebook.Image != null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxFacebook.Image.Save(saveFileDialog.FileName);
				}
			}
		}

		private void PictureBoxWindows_Click(object sender, EventArgs e)
		{
			if (pictureBoxWindows.Image != null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxWindows.Image.Save(saveFileDialog.FileName);
				}
			}
		}

		private void PictureBoxTwitter_Click(object sender, EventArgs e)
		{
			if (pictureBoxTwitter.Image != null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxTwitter.Image.Save(saveFileDialog.FileName);
				}
			}
		}

		private void PictureBoxJoyPixels_Click(object sender, EventArgs e)
		{
			if (pictureBoxJoyPixels.Image != null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxJoyPixels.Image.Save(saveFileDialog.FileName);
				}
			}
		}

		private void PictureBoxSamsung_Click(object sender, EventArgs e)
		{
			if (pictureBoxSamsung.Image != null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxSamsung.Image.Save(saveFileDialog.FileName);
				}
			}
		}
	}
}
