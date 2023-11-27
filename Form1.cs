using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Core;
using System.IO;

namespace WindowsFormsApp.SurvivorVMT
{

    public partial class Form1 : Form
    {
        private void fun_preset_read()
        {
            preset_combobox.Items.Clear();
            string[] files = Directory.GetFiles("config", "*.yml");            // 获取同目录文件夹config中的所有yml文件
            foreach (string file in files)            // 遍历每个文件
            {
                try
                {
                    string content = File.ReadAllText(file);                    // 读取文件内容
                    var deserializer = new Deserializer();                    // 反序列化为字典对象
                    var dict = deserializer.Deserialize<Dictionary<string, string>>(content);
                    // 检查 YAML 文件的键拥有情况是否符合程序要求
                    if (dict.ContainsKey("$basetexture") && dict.ContainsKey("_bumpmap") && dict.ContainsKey("$bumpmap")
                        && dict.ContainsKey("_phongexponenttexture") && dict.ContainsKey("$phongexponenttexture")
                        && dict.ContainsKey("_lightwarptexture") && dict.ContainsKey("$lightwarptexture")
                        && dict.ContainsKey("$nocull") && dict.ContainsKey("$nodecal") && dict.ContainsKey("$phong")
                        && dict.ContainsKey("$halflambert") && dict.ContainsKey("_phongboost") && dict.ContainsKey("$phongboost")
                        && dict.ContainsKey("_phongexponent") && dict.ContainsKey("$phongexponent") && dict.ContainsKey("_phongfresnelranges")
                        && dict.ContainsKey("$phongfresnelranges[0]") && dict.ContainsKey("$phongfresnelranges[1]") && dict.ContainsKey("$phongfresnelranges[2]")
                        && dict.ContainsKey("$envmap") && dict.ContainsKey("$normalmapalphaenvmapmask") && dict.ContainsKey("_envmaptint")
                        && dict.ContainsKey("$envmaptint[0]") && dict.ContainsKey("$envmaptint[1]") && dict.ContainsKey("$envmaptint[2]")
                        && dict.ContainsKey("_envmapfresnel") && dict.ContainsKey("$envmapfresnel") && dict.ContainsKey("$selfillum")
                        && dict.ContainsKey("$translucent") && dict.ContainsKey("$additive") && dict.ContainsKey("_alpha")
                        && dict.ContainsKey("$alpha") && dict.ContainsKey("_proxies") && dict.ContainsKey("_AnimatedTexture")
                        && dict.ContainsKey("animatedtexturevar") && dict.ContainsKey("animatedtextureframenumvar") && dict.ContainsKey("animatedtextureframerate")
                        && dict.ContainsKey("_TrueRNG") && dict.ContainsKey("$numberoflastframe") && dict.ContainsKey("_Sine")
                        && dict.ContainsKey("sineperiod") && dict.ContainsKey("sinemin") && dict.ContainsKey("sinemax")
                        && dict.ContainsKey("timeoffset") && dict.ContainsKey("resultVar"))
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        preset_combobox.Items.Add(fileName);
                    }
                    else
                    {
                        string message = "预设文件 " + file + " 的键拥有情况不符合程序要求！";
                        MessageBox.Show(message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (YamlException ex)
                {
                    string message = "预设文件 " + file + " 存在错误！\n";
                    MessageBox.Show(message + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fun_preset_add()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            string folder = Path.Combine(dir, "config");
            string file = Path.Combine(folder, preset_combobox.Text + ".yml");
            if (File.Exists(file))            
            {
                MessageBox.Show("已存在同名预设，请更换预设名或删除原预设。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // else if (preset_combobox.Text == "") MessageBox.Show("预设名不可为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
                    {
                string yaml =
                    "$basetexture" + ": " + basetexture_textbox.Text + "\n" +
                    "_bumpmap" + ": " + bumpmap.Checked + "\n" +
                    "$bumpmap" + ": " + bumpmap_textbox.Text + "\n" +
                    "_phongexponenttexture" + ": " + phongexponenttexture.Checked + "\n" +
                    "$phongexponenttexture" + ": " + phongexponenttexture_textbox.Text + "\n" +
                    "_lightwarptexture" + ": " + lightwarptexture.Checked + "\n" +
                    "$lightwarptexture" + ": " + lightwarptexture_textbox.Text + "\n" +
                    "$nocull" + ": " + nocull.Checked + "\n" +
                    "$nodecal" + ": " + nodecal.Checked + "\n" +
                    "$phong" + ": " + phong.Checked + "\n" +
                    "$halflambert" + ": " + halflambert.Checked + "\n" +
                    "_phongboost" + ": " + phongboost.Checked + "\n" +
                    "$phongboost" + ": " + phongboost_textbox.Text + "\n" +
                    "_phongexponent" + ": " + phongexponent.Checked + "\n" +
                    "$phongexponent" + ": " + phongexponenttexture_textbox.Text + "\n" +
                    "_phongfresnelranges" + ": " + phongfresnelranges.Checked + "\n" +
                    "$phongfresnelranges[0]" + ": " + phongfresnelranges_textbox_0.Text + "\n" +
                    "$phongfresnelranges[1]" + ": " + phongfresnelranges_textbox_1.Text + "\n" +
                    "$phongfresnelranges[2]" + ": " + phongfresnelranges_textbox_2.Text + "\n" +
                    "$envmap" + ": " + envmap.Checked + "\n" +
                    "$normalmapalphaenvmapmask" + ": " + normalmapalphaenvmapmask.Checked + "\n" +
                    "_envmaptint" + ": " + envmaptint.Checked + "\n" +
                    "$envmaptint[0]" + ": " + envmaptint_textbox_0.Text + "\n" +
                    "$envmaptint[1]" + ": " + envmaptint_textbox_1.Text + "\n" +
                    "$envmaptint[2]" + ": " + envmaptint_textbox_2.Text + "\n" +
                    "_envmapfresnel" + ": " + envmapfresnel.Checked + "\n" +
                    "$envmapfresnel" + ": " + envmapfresnel_textbox.Text + "\n" +
                    "$selfillum" + ": " + selfillum.Checked + "\n" +
                    "$translucent" + ": " + translucent.Checked + "\n" +
                    "$additive" + ": " + additive.Checked + "\n" +
                    "_alpha" + ": " + alpha.Checked + "\n" +
                    "$alpha" + ": " + alpha_textbox.Text + "\n" +
                    "_proxies" + ": " + proxies.Checked + "\n" +
                    "_AnimatedTexture" + ": " + AnimatedTexture.Checked + "\n" +
                    "animatedtexturevar" + ": " + animatedtexturevar_combobox.Text + "\n" +
                    "animatedtextureframenumvar" + ": " + animatedtextureframenumvar_combobox.Text + "\n" +
                    "animatedtextureframerate" + ": " + animatedtextureframerate_textbox.Text + "\n" +
                    "_TrueRNG" + ": " + TrueRNG.Checked + "\n" +
                    "$numberoflastframe" + ": " + numberoflastframe_textbox.Text + "\n" +
                    "_Sine" + ": " + Sine.Checked + "\n" +
                    "sineperiod" + ": " + sineperiod_textbox.Text + "\n" +
                    "sinemin" + ": " + sinemin_textbox.Text + "\n" +
                    "sinemax" + ": " + sinemax_textbox.Text + "\n" +
                    "timeoffset" + ": " + timeoffset_textbox.Text + "\n" +
                    "resultVar" + ": " + resultVar_textbox.Text + "\n";
                File.WriteAllText(file, yaml);                // 写入yml文件
            }
        }
        private void fun_preset_delete()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            string folder = Path.Combine(dir, "config");
            string file = Path.Combine(folder, preset_combobox.Text + ".yml");
            if (File.Exists(file))
            {
                string ext = Path.GetExtension(file);                // 如果文件存在，获取文件的扩展名
                int count = 0;                // 定义一个计数器，表示文件的后缀数字
                string newFile = file + ".deleted_" + count;                // 定义一个新的文件名，加上 .deleted_0 的后缀
                while (File.Exists(newFile))                // 循环检查新的文件名是否已存在
                {
                    count++;                    // 如果已存在，增加计数器的值
                    newFile = file + ".deleted_" + count;                    // 重新定义新的文件名，加上 .deleted_ 的后缀和计数器的值
                }
                // 改名文件
                File.Move(file, newFile);
            }
            else MessageBox.Show("预设不存在，请检查预设名是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
        private void fun_preset_apply()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            string folder = Path.Combine(dir, "config");
            string file = Path.Combine(folder, preset_combobox.Text + ".yml");
            try
            {
                string content = File.ReadAllText(file);                   
                var deserializer = new Deserializer();                    
                var dict = deserializer.Deserialize<Dictionary<string, string>>(content);
                if (dict.ContainsKey("$basetexture") && dict.ContainsKey("_bumpmap") && dict.ContainsKey("$bumpmap")
                    && dict.ContainsKey("_phongexponenttexture") && dict.ContainsKey("$phongexponenttexture")
                    && dict.ContainsKey("_lightwarptexture") && dict.ContainsKey("$lightwarptexture")
                    && dict.ContainsKey("$nocull") && dict.ContainsKey("$nodecal") && dict.ContainsKey("$phong")
                    && dict.ContainsKey("$halflambert") && dict.ContainsKey("_phongboost") && dict.ContainsKey("$phongboost")
                    && dict.ContainsKey("_phongexponent") && dict.ContainsKey("$phongexponent") && dict.ContainsKey("_phongfresnelranges")
                    && dict.ContainsKey("$phongfresnelranges[0]") && dict.ContainsKey("$phongfresnelranges[1]") && dict.ContainsKey("$phongfresnelranges[2]")
                    && dict.ContainsKey("$envmap") && dict.ContainsKey("$normalmapalphaenvmapmask") && dict.ContainsKey("_envmaptint")
                    && dict.ContainsKey("$envmaptint[0]") && dict.ContainsKey("$envmaptint[1]") && dict.ContainsKey("$envmaptint[2]")
                    && dict.ContainsKey("_envmapfresnel") && dict.ContainsKey("$envmapfresnel") && dict.ContainsKey("$selfillum")
                    && dict.ContainsKey("$translucent") && dict.ContainsKey("$additive") && dict.ContainsKey("_alpha")
                    && dict.ContainsKey("$alpha") && dict.ContainsKey("_proxies") && dict.ContainsKey("_AnimatedTexture")
                    && dict.ContainsKey("animatedtexturevar") && dict.ContainsKey("animatedtextureframenumvar") && dict.ContainsKey("animatedtextureframerate")
                    && dict.ContainsKey("_TrueRNG") && dict.ContainsKey("$numberoflastframe") && dict.ContainsKey("_Sine")
                    && dict.ContainsKey("sineperiod") && dict.ContainsKey("sinemin") && dict.ContainsKey("sinemax")
                    && dict.ContainsKey("timeoffset") && dict.ContainsKey("resultVar"))
                {
                    basetexture_textbox.Text = dict["$basetexture"];
                    if (bool.TryParse(dict["_bumpmap"], out bool _bumpmap) == true) bumpmap.Checked = _bumpmap; 
                    else { bumpmap.Checked = false; MessageBox.Show("_bumpmap 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    bumpmap_textbox.Text = dict["$bumpmap"];
                    if (bool.TryParse(dict["_phongexponenttexture"], out bool _phongexponenttexture) == true) phongexponenttexture.Checked = _phongexponenttexture; 
                    else { phongexponenttexture.Checked = false; MessageBox.Show("_phongexponenttexture 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    phongexponenttexture_textbox.Text = dict["$phongexponenttexture"];
                    if (bool.TryParse(dict["_lightwarptexture"], out bool _lightwarptexture) == true) lightwarptexture.Checked = _lightwarptexture;
                    else { lightwarptexture.Checked = false; MessageBox.Show("_lightwarptexture 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    lightwarptexture_textbox.Text = dict["$lightwarptexture"];
                    if (bool.TryParse(dict["$nocull"], out bool _nocull) == true) nocull.Checked = _nocull;
                    else { nocull.Checked = false; MessageBox.Show("$nocull 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["$nodecal"], out bool _nodecal) == true) nodecal.Checked = _nodecal;
                    else { nodecal.Checked = false; MessageBox.Show("$nodecal 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["$phong"], out bool _phong) == true) phong.Checked = _phong;
                    else { phong.Checked = false; MessageBox.Show("$phong 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["$halflambert"], out bool _halflambert) == true) halflambert.Checked = _halflambert;
                    else { halflambert.Checked = false; MessageBox.Show("$halflambert 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["_phongboost"], out bool _phongboost) == true) phongboost.Checked = _phongboost;
                    else { phongboost.Checked = false; MessageBox.Show("_phongboost 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    phongboost_textbox.Text = dict["$phongboost"];
                    if (bool.TryParse(dict["_phongexponent"], out bool _phongexponent) == true) phongexponent.Checked = _phongexponent;
                    else { phongexponent.Checked = false; MessageBox.Show("_phongexponent 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    phongexponenttexture_textbox.Text = dict["$phongexponent"];
                    if (bool.TryParse(dict["_phongfresnelranges"], out bool _phongfresnelranges) == true) phongfresnelranges.Checked = _phongfresnelranges;
                    else { phongfresnelranges.Checked = false; MessageBox.Show("_phongfresnelranges 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    phongfresnelranges_textbox_0.Text = dict["$phongfresnelranges[0]"];
                    phongfresnelranges_textbox_1.Text = dict["$phongfresnelranges[1]"];
                    phongfresnelranges_textbox_2.Text = dict["$phongfresnelranges[2]"];
                    if (bool.TryParse(dict["$envmap"], out bool _envmap) == true) envmap.Checked = _envmap;
                    else { envmap.Checked = false; MessageBox.Show("$envmap 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["$normalmapalphaenvmapmask"], out bool _normalmapalphaenvmapmask) == true) normalmapalphaenvmapmask.Checked = _normalmapalphaenvmapmask;
                    else { normalmapalphaenvmapmask.Checked = false; MessageBox.Show("$normalmapalphaenvmapmask 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["_envmaptint"], out bool _envmaptint) == true) envmaptint.Checked = _envmaptint;
                    else { envmaptint.Checked = false; MessageBox.Show("_envmaptint 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    envmaptint_textbox_0.Text = dict["$envmaptint[0]"];
                    envmaptint_textbox_1.Text = dict["$envmaptint[1]"];
                    envmaptint_textbox_2.Text = dict["$envmaptint[2]"];
                    if (bool.TryParse(dict["_envmapfresnel"], out bool _envmapfresnel) == true) envmapfresnel.Checked = _envmapfresnel;
                    else { envmapfresnel.Checked = false; MessageBox.Show("_envmapfresnel 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    envmapfresnel_textbox.Text = dict["$envmapfresnel"];
                    if (bool.TryParse(dict["$selfillum"], out bool _selfillum) == true) selfillum.Checked = _selfillum;
                    else { selfillum.Checked = false; MessageBox.Show("$selfillum 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["$translucent"], out bool _translucent) == true) translucent.Checked = _translucent;
                    else { translucent.Checked = false; MessageBox.Show("$translucent 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["$additive"], out bool _additive) == true) additive.Checked = _additive;
                    else { additive.Checked = false; MessageBox.Show("$additive 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["_alpha"], out bool _alpha) == true) alpha.Checked = _alpha;
                    else { alpha.Checked = false; MessageBox.Show("_alpha 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    alpha_textbox.Text = dict["$alpha"];
                    if (bool.TryParse(dict["_proxies"], out bool _proxies) == true) proxies.Checked = _proxies;
                    else { proxies.Checked = false; MessageBox.Show("_proxies 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (bool.TryParse(dict["_AnimatedTexture"], out bool _AnimatedTexture) == true) AnimatedTexture.Checked = _AnimatedTexture;
                    else { AnimatedTexture.Checked = false; MessageBox.Show("_AnimatedTexture 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    animatedtexturevar_combobox.Text = dict["animatedtexturevar"];
                    animatedtextureframenumvar_combobox.Text = dict["animatedtextureframenumvar"];
                    animatedtextureframerate_textbox.Text = dict["animatedtextureframerate"];
                    if (bool.TryParse(dict["_TrueRNG"], out bool _TrueRNG) == true) TrueRNG.Checked = _TrueRNG;
                    else { TrueRNG.Checked = false; MessageBox.Show("_TrueRNG 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    numberoflastframe_textbox.Text = dict["$numberoflastframe"];
                    if (bool.TryParse(dict["_Sine"], out bool _Sine) == true) Sine.Checked = _Sine;
                    else { Sine.Checked = false; MessageBox.Show("_Sine 的值应为布尔型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    sineperiod_textbox.Text = dict["sineperiod"];
                    sinemin_textbox.Text = dict["sinemin"];
                    sinemax_textbox.Text = dict["sinemax"];
                    timeoffset_textbox.Text = dict["timeoffset"];
                    resultVar_textbox.Text = dict["resultVar"];
                }
                else
                {
                    string message = "预设文件 " + file + " 的键拥有情况不符合程序要求！";
                    MessageBox.Show(message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (YamlException ex)
            {
                string message = "预设文件 " + file + " 存在错误！\n";
                MessageBox.Show(message + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form1()
        {
            InitializeComponent();
            fun_preset_read();
        }

        private void output_Click(object sender, EventArgs e)
        {
            output_textBox.Text = "VertexlitGeneric"+ Environment.NewLine+"{"+ Environment.NewLine;

            // $basetexture 是必要的。如果 $basetexture 的值为空，将填入 NaN。

            if (basetexture_textbox.Text != "")
                output_textBox.Text += "    $basetexture    " + '"' + basetexture_textbox.Text + '"' + Environment.NewLine;
            else
                output_textBox.Text += "    $basetexture    " + '"' + "NaN" + '"' + Environment.NewLine;

            // $bumpmap

            if (bumpmap.Checked == true)
                if (bumpmap_textbox.Text != "") 
                    output_textBox.Text += "    $bumpmap    " + '"' + bumpmap_textbox.Text + '"' + Environment.NewLine;
                else output_textBox.Text += "    $bumpmap    " + '"' + "NaN" + '"' + Environment.NewLine;

            // $phongexponenttexture

            if (phongexponenttexture.Checked == true)
                if (phongexponenttexture_textbox.Text != "")
                    output_textBox.Text += "    $phongexponenttexture    " + '"' + phongexponenttexture_textbox.Text + '"' + Environment.NewLine;
                else output_textBox.Text += "    $phongexponenttexture    " + '"' + "NaN" + '"' + Environment.NewLine;

            // $lightwarptexture

            if (lightwarptexture.Checked == true)
                if (lightwarptexture_textbox.Text != "")
                    output_textBox.Text += "    $lightwarptexture    " + '"' + lightwarptexture_textbox.Text + '"' + Environment.NewLine;
                else output_textBox.Text += "    $lightwarptexture    " + '"' + "NaN" + '"' + Environment.NewLine;

            // $nocull

            if (nocull.Checked == true)
                output_textBox.Text += "    $nocull    " + '"' + "1" + '"' + Environment.NewLine;

            // $nodecal

            if (nodecal.Checked == true)
                output_textBox.Text += "    $nodecal    " + '"' + "1" + '"' + Environment.NewLine;

            // $phong

            if (phong.Checked == true)
                output_textBox.Text += "    $phong    " + '"' + "1" + '"' + Environment.NewLine;

            // $halflambert

            if (halflambert.Checked == true)
                output_textBox.Text += "    $halflambert    " + '"' + "1" + '"' + Environment.NewLine;

            // $phongboost，如果元素值不为浮点数，则输出替换为 NaN

            if (phongboost.Checked == true)
                if (float.TryParse(phongboost_textbox.Text, out _) == true)
                    output_textBox.Text += "    $phongboost    " + '"'  + phongboost_textbox.Text + '"' + Environment.NewLine;
                else output_textBox.Text += "    $phongboost    " + '"' + "NaN" + '"' + Environment.NewLine;

            // $phongexponent，如果元素值不为浮点数，则输出替换为 NaN

            if (phongexponent.Checked == true)
                if (float.TryParse(phongexponent_textbox.Text, out _) == true)
                    output_textBox.Text += "    $phongexponent    " + '"' + phongexponent_textbox.Text + '"' + Environment.NewLine;
                else output_textBox.Text += "    $phongexponent    " + '"' + "NaN" + '"' + Environment.NewLine;


            // $phongfresnelranges，如果元素值不为浮点数，则输出替换为 NaN

            if (phongfresnelranges.Checked == true)
            {
                if (float.TryParse(phongfresnelranges_textbox_0.Text, out _) == true)
                    output_textBox.Text += "    $phongfresnelranges    " + '"' + '[' + phongfresnelranges_textbox_0.Text + " ";
                else output_textBox.Text += "    $phongfresnelranges    " + '"' + '[' + "NaN" + " ";
                if (float.TryParse(phongfresnelranges_textbox_1.Text, out _) == true)
                    output_textBox.Text += phongfresnelranges_textbox_1.Text + " ";
                else output_textBox.Text += "NaN" + " ";
                if (float.TryParse(phongfresnelranges_textbox_2.Text, out _) == true)
                    output_textBox.Text += phongfresnelranges_textbox_2.Text + ']' + '"' + Environment.NewLine;
                else output_textBox.Text += "NaN" + ']' + '"' + Environment.NewLine;
            }

            // $envmap

            if (envmap.Checked == true)
                output_textBox.Text += "    $envmap    " + '"' + "env_cubemap" + '"' + Environment.NewLine;

            // $normalmapalphaenvmapmask

            if (normalmapalphaenvmapmask.Checked == true)
                output_textBox.Text += "    $normalmapalphaenvmapmask    " + '"' + "1" + '"' + Environment.NewLine;

            // $envmaptint，如果元素值不为浮点数，则输出替换为 NaN

            if (envmaptint.Checked == true)
            {
                if (float.TryParse(envmaptint_textbox_0.Text, out _) == true)
                    output_textBox.Text += "    $envmaptint    " + '"' + '[' + envmaptint_textbox_0.Text + " ";
                else output_textBox.Text += "    $envmaptint    " + '"' + '[' + "NaN" + " ";
                if (float.TryParse(envmaptint_textbox_1.Text, out _) == true)
                    output_textBox.Text += envmaptint_textbox_1.Text + " ";
                else output_textBox.Text += "NaN" + " ";
                if (float.TryParse(envmaptint_textbox_2.Text, out _) == true)
                    output_textBox.Text += envmaptint_textbox_2.Text + ']' + '"' + Environment.NewLine;
                else output_textBox.Text += "NaN" + ']' + '"' + Environment.NewLine;
            }

            // $envmapfresnel，如果元素值不为浮点数，则输出替换为 NaN

            if (envmapfresnel.Checked == true)
                if (float.TryParse(envmapfresnel_textbox.Text, out _) == true)
                    output_textBox.Text += "    $envmapfresnel    " + '"' + envmapfresnel_textbox.Text + '"' + Environment.NewLine;
                else output_textBox.Text += "    $envmapfresnel    " + '"' + "NaN" + '"' + Environment.NewLine;

            // $selfillum

            if (selfillum.Checked == true)
                output_textBox.Text += "    $selfillum    " + '"' + "1" + '"' + Environment.NewLine;

            // $translucent

            if (translucent.Checked == true)
                output_textBox.Text += "    $translucent    " + '"' + "1" + '"' + Environment.NewLine;

            // $additive

            if (additive.Checked == true)
                output_textBox.Text += "    $additive    " + '"' + "1" + '"' + Environment.NewLine;

            // $alpha，如果元素值不为浮点数，则输出替换为 NaN

            if (alpha.Checked == true)
                if (float.TryParse(alpha_textbox.Text, out _) == true)
                    output_textBox.Text += "    $alpha    " + '"' + alpha_textbox.Text + '"' + Environment.NewLine;
                else output_textBox.Text += "    $alpha    " + '"' + "NaN" + '"' + Environment.NewLine;

            // proxies

            if (proxies.Checked == true) 
            {
                // 如果启用了 TrueRNG 检查 numberoflastframe 是否为大于等于1的整形 并声明参数 否则输出 NaN

                bool TrueRNG_check = true;

                if (TrueRNG.Checked == true)
                {
                    if (int.TryParse(numberoflastframe_textbox.Text, out int numberoflastframe) == true && numberoflastframe >= 1)
                    {
                        output_textBox.Text += "    $numberoflastframe    " + '"' + numberoflastframe + '"' + Environment.NewLine;
                        if (numberoflastframe == 1) output_textBox.Text += "    $divn    " + '"' + 1.5 + '"' + Environment.NewLine;
                        else output_textBox.Text += "    $divn    " + '"' + 2 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $framec    " + '"' + 0 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $numberoflastframeplus    " + '"' + 0 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $ramp    " + '"' + 0 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $inval    " + '"' + 0 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $frame    " + '"' + 100 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $zero    " + '"' + 0 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $nn    " + '"' + 0.99 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $one    " + '"' + 1 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $docorr    " + '"' + 0 + '"' + Environment.NewLine;
                        output_textBox.Text += "    $framecdo    " + '"' + 0 + '"' + Environment.NewLine;
                    }
                    else
                    {
                        output_textBox.Text += "    // [ERROR] TRUE RNG: $numberoflastframe must be an integer >= 1" + Environment.NewLine;
                        TrueRNG_check = false;
                    }
                }
                else TrueRNG_check = false;

                // proxies

                output_textBox.Text += "    proxies" + Environment.NewLine + "    {" + Environment.NewLine;

                // AnimatedTexture

                if (AnimatedTexture.Checked == true)
                {
                    output_textBox.Text += "        AnimatedTexture" + Environment.NewLine + "        {" + Environment.NewLine;

                    // animatedtexturevar，只读

                    string temp = animatedtexturevar_combobox.Text;
                    if (animatedtexturevar_combobox.Text == "") temp = "NaN";
                    output_textBox.Text += "            animatedtexturevar    " + '"' + temp + '"' + Environment.NewLine;

                    // animatedtextureframenumvar，只读

                    temp = animatedtextureframenumvar_combobox.Text;
                    if (animatedtextureframenumvar_combobox.Text == "") temp = "NaN";
                    output_textBox.Text += "            animatedtextureframenumvar    " + '"' + temp + '"' + Environment.NewLine;

                    // animatedtextureframerate，如果元素值不为浮点数，则输出替换为 NaN

                    if (float.TryParse(animatedtextureframerate_textbox.Text, out _) == true)
                        output_textBox.Text += "            animatedtextureframerate    " + '"' + animatedtextureframerate_textbox.Text + '"' + Environment.NewLine;
                    else output_textBox.Text += "            animatedtextureframerate    " + '"' + "NaN" + '"' + Environment.NewLine;

                    output_textBox.Text += "        }" + Environment.NewLine;

                }

                if (TrueRNG_check != false)
                {
                    string true_rng_proxies = @"        ""Add""
        {
                ""srcVar1"" ""$numberoflastframe""
                ""srcVar2"" ""$nn""
                ""resultVar"" ""$framec""
        }
        ""Divide""
        {
                ""srcVar1"" ""$framec""
                ""srcVar2"" ""$divn""
                ""resultVar"" ""$numberoflastframeplus""
        }
        ""LinearRamp"" 
        {
                ""rate"" ""$numberoflastframeplus"" 
                ""initialValue"" ""$inval""
                ""resultVar"" ""$ramp""
        }
        ""LessOrEqual"" 
        {
                ""LessEqualVar"" ""$zero""
                ""greaterVar"" ""$one""
                ""srcVar1"" ""$ramp""
                ""srcVar2"" ""$framec""
                ""resultVar"" ""$docorr""
        }
        ""Multiply"" 
        {
                ""srcVar1"" ""$framec""
                ""srcVar2"" ""$docorr""
                ""resultVar"" ""$framecdo""
        }	
        ""Subtract"" 
        {
                ""srcVar1"" ""$inval""
                ""srcVar2"" ""$framecdo""
                ""resultVar"" ""$inval""
        }
        ""LessOrEqual""
        {
                ""LessEqualVar"" ""$frame""
                ""greaterVar"" ""$ramp""
                ""srcVar1"" ""$frame""
                ""srcVar2"" ""$framec""
                ""resultVar"" ""$frame""
        }";
                    output_textBox.Text += true_rng_proxies + Environment.NewLine;
                }

                if (Sine.Checked == true)
                {
                    output_textBox.Text += "        Sine" + Environment.NewLine + "        {" + Environment.NewLine;

                    if (float.TryParse(sineperiod_textbox.Text, out _) == true)
                        output_textBox.Text += "            sineperiod    " + '"' + sineperiod_textbox.Text + '"' + Environment.NewLine;
                    else output_textBox.Text += "            sineperiod    " + '"' + "NaN" + '"' + Environment.NewLine;

                    if (float.TryParse(sinemin_textbox.Text, out _) == true)
                        output_textBox.Text += "            sinemin    " + '"' + sinemin_textbox.Text + '"' + Environment.NewLine;
                    else output_textBox.Text += "            sinemin    " + '"' + "NaN" + '"' + Environment.NewLine;

                    if (float.TryParse(sinemax_textbox.Text, out _) == true)
                        output_textBox.Text += "            sinemax    " + '"' + sinemax_textbox.Text + '"' + Environment.NewLine;
                    else output_textBox.Text += "            sinemax    " + '"' + "NaN" + '"' + Environment.NewLine;

                    if (float.TryParse(timeoffset_textbox.Text, out _) == true)
                        output_textBox.Text += "            timeoffset    " + '"' + timeoffset_textbox.Text + '"' + Environment.NewLine;
                    else output_textBox.Text += "            timeoffset    " + '"' + "NaN" + '"' + Environment.NewLine;

                    output_textBox.Text += "            resultVar    " + '"' + resultVar_textbox.Text + '"' + Environment.NewLine;

                    output_textBox.Text += "        }" + Environment.NewLine;
                }

                output_textBox.Text += "    }" + Environment.NewLine;
            }

            output_textBox.Text += "}" + Environment.NewLine;
        }

        private void preset_add_Click(object sender, EventArgs e)
        {
            fun_preset_add();
            fun_preset_read();
        }

        private void preset_delete_Click(object sender, EventArgs e)
        {
            fun_preset_delete();
            preset_combobox.Text = "";
            fun_preset_read();
        }

        private void preset_apply_Click(object sender, EventArgs e)
        {
            fun_preset_apply();
        }
    }
    
}
