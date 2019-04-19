﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using RTCV.CorruptCore;
using static RTCV.UI.UI_Extensions;
using RTCV.NetCore.StaticTools;

namespace RTCV.UI
{
	public partial class RTC_ConnectionStatus_Form : Form, IAutoColorize
	{
		public RTC_ConnectionStatus_Form()
		{
			InitializeComponent();
		}

		private void RTC_ConnectionStatus_Form_Load(object sender, EventArgs e)
		{
			int crashSound = 0;

			if (NetCore.Params.IsParamSet("CRASHSOUND"))
				crashSound = Convert.ToInt32(NetCore.Params.ReadParam("CRASHSOUND"));

			S.GET<RTC_SettingsNetCore_Form>().cbCrashSoundEffect.SelectedIndex = crashSound;
		}

		public void btnStartEmuhawkDetached_Click(object sender, EventArgs e)
		{

			S.GET<UI_CoreForm>().pbAutoKillSwitchTimeout.Value = S.GET<UI_CoreForm>().pbAutoKillSwitchTimeout.Maximum;

			//RTC_NetCoreSettings.PlayCrashSound();

			Process.Start("RESTARTDETACHEDRTC.bat");
		}

		private void btnStopGameProtection_Click(object sender, EventArgs e)
		{
			S.GET<UI_CoreForm>().cbUseGameProtection.Checked = false;
		}

	}
}
