using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zimbo_Package_Installer
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (steam.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe"),
                        textBox1.Text + "\\SteamSetup.exe"
                    );
                }
            }
            if (epicgames.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi"),
                        textBox1.Text + "\\EpicGamesLauncherInstaller.msi"
                    );
                }
            }
            if (gog.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://webinstallers.gog-statics.com/download/GOG_Galaxy_2.0.exe?payload=ZH5CX1ViWawCY8A4tpEmBhFOGpvb6JAxLW_5H4DcpiiIxzpCxPfa0d9dnmK-CbvNyJSg_WfGHgOCv6yM8ZkEeVkxKzzaNExZbtd9zNsLHInAW6_5gqQ1Z_kd_H16OGt-VoaGE4PxT-XrxWFEqB8q5eiqyZ-PQWkh1BRSka12aczJhUlq4fDzDoRFtr8EowXE6jw-BjaMSBf-S5vl7dkRqC3F9xD8QujymQ4hWgdwZa6H5R7YutVyYQRf2ze5Mu9w6XE-P9hU8S7XwQ7S9n_WhqghgMtbF1skCnB2ACgp8PG2Lg813aMqWN8Jw4Wwx41ofmLoIdNyr_4JVDSz4tPmlcsdEVPBi8sZ14odN_1wbsVYVD5DmvgJeBkzsthLpJ3latqZmg2DPrCHZL_3-2qV7vKd--gNjI5rr-63ZAkRQTT-aLH6cb66NgXxWOOOsDd9tUmq96unDvtFmmAmxKU82CZYjc-F8EMLs0PzQxal2flqRd9NN52ZxrCTgsAgnyl5towpr_LVLiCEcSlg1I4QCxdtiVz0u3dv7cvIVOp_jKsxIPGXmcs0_aEBmpJwFchgGTpVGzLlOk5SFjMeftaggVap5YkusgOjPxLA-y7flkWGM2n9-6WZtXmZtA5KSiQxGlshN4ox-AQaKFt_a8ECCL5qInJQB3N1u-w1cVOyl5RbZujsTvGNlnQ8buCeHcdxrwjiSe-yGpWtNxLdOn54i36-2di6AamqfUGsAHt_BV_t-HzIZw2fw50wn7JQ9aaugFD1"),
                        textBox1.Text + "\\GOG_Galaxy_2.0.exe"
                    );
                }
            }
            if (ubisoftconnect.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://ubi.li/4vxt9"),
                        textBox1.Text + "\\UbisoftConnectInstaller.exe"
                    );
                }
            }
            if (eadesktop.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://origin-a.akamaihd.net/EA-Desktop-Client-Download/installer-releases/EAappInstaller.exe"),
                        textBox1.Text + "\\EAappInstaller.exe"
                    );
                }
            }
            if (logihub.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://download01.logi.com/web/ftp/pub/techsupport/gaming/lghub_installer.exe"),
                        textBox1.Text + "\\lghub_installer.exe"
                    );
                }
            }
            if (amd.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://drivers.amd.com/drivers/installer/23.40/whql/amd-software-adrenalin-edition-24.1.1-combined-minimalsetup-240122_web.exe"),
                        textBox1.Text + "\\amd-software-adrenalin-edition-24.1.1-combined-minimalsetup-240122_web.exe"
                    );
                }
            }
            if (nvidia.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://us.download.nvidia.com/GFE/GFEClient/3.27.0.120/GeForce_Experience_v3.27.0.120.exe"),
                        textBox1.Text + "\\GeForce_Experience_v3.27.0.120.exe"
                    );
                }
            }
            if (ajazz.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://download.s21i.faiusr.com/25789609/0/0/ABUIABBPGAAgsdnMqQYo2dW2iQc.zip?f=AJAZZ_%20AK820%20wired%20RGB_%20Keyboard%20driver_%20V1.0.zip&v=1697852593"),
                        textBox1.Text + "\\AJAZZ_ AK820 wired RGB_ Keyboard driver_ V1.0.zip"
                    );
                }
            }
            if (realtek.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://www.realtek.com/captcha/?token=495879ea4b60ea87625b01e805419868ebcccce2e4958f1611964e7176527e9ca3572e5aea00b67686ade0a4576d779b640bccabd6a55b70662258391f3690f007c5d06586c68adbba1669c28670f90929e7f8852a29f2618b891d935c7cb2c1a2536b7aeeba7919df66b2f0c1b23d64017fe3747d9c9c4d8365e369bfb20e8cc265d3487d278ca36ecd13bb4549872ad96dc0fa8b8c678570f49c4e447ec46779f82e30ad32cc8e04f291a991e1c0f4"),
                        textBox1.Text + "\\0009-64bit_Win7_Win8_Win81_Win10_R282.exe"
                    );
                }
            }
            if (ethernet.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://www.realtek.com/captcha/?token=495879ea4b60ea87625b01e8054198680c982926286a379c86343da8a020cb0ba09351d2caa90459fec1090c40c3d4a440ce2738b87c13f44957f184e3bb931a07c5d06586c68adbba1669c28670f90929e7f8852a29f2618b891d935c7cb2c1a2536b7aeeba7919df66b2f0c1b23d642431f46849fcd569dc70cc3ff8ab230010c4f5697a04d4dd4bb730ebcae05dddd46fb19a7727a945828517415e3423e86fd66fb8d7f72f631b884464ea0f1dc8"),
                        textBox1.Text + "\\Install_Win10_10069_01232024.zip"
                    );
                }
            }
            if (cpuz.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://www.cpuid.com/downloads/cpu-z/cpu-z_2.09-en.exe"),
                        textBox1.Text + "\\cpu-z_2.09-en.exe"
                    );
                }
            }
            if (msiafter.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://download.msi.com/uti_exe/vga/MSIAfterburnerSetup.zip?__token__=exp=1708772419~acl=/*~hmac=6abc364b8ddbc52e2d7125faf05d18cee3b0666da10ed73d312587c6973fbed7"),
                        textBox1.Text + "\\MSIAfterburnerSetup.zip"
                    );
                }
            }
            if (riot.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://lol.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.eune.exe"),
                        textBox1.Text + "\\Install League of Legends eune.exe"
                    );
                }
            }
            if (ctemp.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://www.alcpu.com/CoreTemp/Core-Temp-setup-v1.18.1.0.exe"),
                        textBox1.Text + "\\Core-Temp-setup-v1.18.1.0.exe"
                    );
                }
            }
            if (vstudio.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030"),
                        textBox1.Text + "\\VisualStudioSetup.exe"
                    );
                }
            }
            if (vstudioc.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user"),
                        textBox1.Text + "\\VSCodeUserSetup-x64-1.86.2.exe"
                    );
                }
            }
            if (python.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://www.python.org/ftp/python/3.12.2/python-3.12.2-amd64.exe"),
                        textBox1.Text + "\\python-3.12.2-amd64.exe"
                    );
                }
            }
            if (discord.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86"),
                        textBox1.Text + "\\DiscordSetup.exe"
                    );
                }
            }
            if (brave.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://laptop-updates.brave.com/download/BRV010?bitness=64"),
                        textBox1.Text + "\\BraveBrowserSetup-BRV010.exe"
                    );
                }
            }
            if (vlc.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://get.videolan.org/vlc/3.0.20/win64/vlc-3.0.20-win64.exe"),
                        textBox1.Text + "\\vlc-3.0.20-win64.exe"
                    );
                }
            }
            if (minecraft.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://aka.ms/minecraftClientGameCoreWindows"),
                        textBox1.Text + "\\MinecraftInstaller.exe"
                    );
                }
            }
            if (office.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://c2rsetup.officeapps.live.com/c2r/download.aspx?productReleaseID=O365ProPlusRetail&platform=Def&language=hu-hu&TaxRegion=db&correlationId=608bd445-b028-44ce-8e07-b1cd6248d4ad&token=056d2b7b-79b0-44cf-9dbd-7f6162ba66d3&version=O16GA&source=O15OLSO365&Br=2"),
                        textBox1.Text + "\\OfficeSetup.exe"
                    );
                }
            }
            if (activate.Checked == true)
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        new System.Uri("https://drive.usercontent.google.com/download?id=138oJVlXpJ8p6KOQXzthsUizLvmiLAnLO&export=download&authuser=0&confirm=t&uuid=a3cc4dca-2ea7-48e3-9e45-eb16f5a35ac7&at=APZUnTVNThoE0wGGZm3KCdqaoxZ7%3A1708630197373"),
                        textBox1.Text + "\\activator.bat"
                    );
                }
            }
        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    }
}
