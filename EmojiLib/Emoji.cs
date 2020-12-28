using System;
using System.Drawing;

namespace EmojiLib
{
	public class Emoji
	{
		public Emoji(string character, string unicode, string group, string subGroup, string shortName, string fullName, string description, Bitmap appleIcon, Bitmap googleIcon, Bitmap facebookIcon, Bitmap windowsIcon, Bitmap twitterIcon, Bitmap joypixelsIcon, Bitmap samsungIcon, Bitmap gmailIcon, Bitmap docomoIcon, Bitmap kddiIcon, Bitmap softbankIcon)
		{
			Character = character ?? string.Empty;
			Unicode = unicode ?? string.Empty;
			Group = group ?? string.Empty;
			SubGroup = subGroup ?? string.Empty;
			ShortName = shortName ?? string.Empty;
			FullName = fullName ?? string.Empty;
			Description = description ?? string.Empty;
			AppleIcon = appleIcon ?? default;
			GoogleIcon = googleIcon ?? default;
			FacebookIcon = facebookIcon ?? default;
			WindowsIcon = windowsIcon ?? default;
			TwitterIcon = twitterIcon ?? default;
			JoypixelsIcon = joypixelsIcon ?? default;
			SamsungIcon = samsungIcon ?? default;
			GmailIcon = gmailIcon ?? default;
			DocomoIcon = docomoIcon ?? default;
			KddiIcon = kddiIcon ?? default;
			SoftbankIcon = softbankIcon ?? default;
		}

		public string Character { get; set; }

		public string Unicode { get; set; }

		public string SubGroup { get; set; }

		public string Group { get; set; }

		public string ShortName { get; set; }

		public string FullName { get; set; }

		public string Description { get; set; }

		public Bitmap AppleIcon { get; set; }

		public Bitmap GoogleIcon { get; set; }

		public Bitmap FacebookIcon { get; set; }

		public Bitmap WindowsIcon { get; set; }

		public Bitmap TwitterIcon { get; set; }

		public Bitmap JoypixelsIcon { get; set; }

		public Bitmap SamsungIcon { get; set; }

		public Bitmap GmailIcon { get; set; }

		public Bitmap DocomoIcon { get; set; }

		public Bitmap KddiIcon { get; set; }

		public Bitmap SoftbankIcon { get; set; }
	}
}