namespace WindowsFormsApp.SurvivorVMT
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.basetexture_textbox = new System.Windows.Forms.TextBox();
            this.bumpmap_textbox = new System.Windows.Forms.TextBox();
            this.bumpmap = new System.Windows.Forms.CheckBox();
            this.preset_combobox = new System.Windows.Forms.ComboBox();
            this.preset_add = new System.Windows.Forms.Button();
            this.preset_delete = new System.Windows.Forms.Button();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.lightwarptexture_textbox = new System.Windows.Forms.TextBox();
            this.lightwarptexture = new System.Windows.Forms.CheckBox();
            this.nocull = new System.Windows.Forms.CheckBox();
            this.nodecal = new System.Windows.Forms.CheckBox();
            this.phong = new System.Windows.Forms.CheckBox();
            this.halflambert = new System.Windows.Forms.CheckBox();
            this.phongboost_textbox = new System.Windows.Forms.TextBox();
            this.phongboost = new System.Windows.Forms.CheckBox();
            this.phongexponent_textbox = new System.Windows.Forms.TextBox();
            this.envmap = new System.Windows.Forms.CheckBox();
            this.phongfresnelranges_textbox_0 = new System.Windows.Forms.TextBox();
            this.phongfresnelranges = new System.Windows.Forms.CheckBox();
            this.phongexponent = new System.Windows.Forms.CheckBox();
            this.phongfresnelranges_textbox_1 = new System.Windows.Forms.TextBox();
            this.phongfresnelranges_textbox_2 = new System.Windows.Forms.TextBox();
            this.envmapfresnel = new System.Windows.Forms.CheckBox();
            this.normalmapalphaenvmapmask = new System.Windows.Forms.CheckBox();
            this.envmapfresnel_textbox = new System.Windows.Forms.TextBox();
            this.envmaptint_textbox_2 = new System.Windows.Forms.TextBox();
            this.envmaptint_textbox_1 = new System.Windows.Forms.TextBox();
            this.envmaptint_textbox_0 = new System.Windows.Forms.TextBox();
            this.envmaptint = new System.Windows.Forms.CheckBox();
            this.selfillum = new System.Windows.Forms.CheckBox();
            this.translucent = new System.Windows.Forms.CheckBox();
            this.alpha_textbox = new System.Windows.Forms.TextBox();
            this.alpha = new System.Windows.Forms.CheckBox();
            this.AnimatedTexture = new System.Windows.Forms.CheckBox();
            this.animatedtexturevar = new System.Windows.Forms.Label();
            this.animatedtextureframenumvar = new System.Windows.Forms.Label();
            this.animatedtextureframerate = new System.Windows.Forms.Label();
            this.animatedtextureframerate_textbox = new System.Windows.Forms.TextBox();
            this.proxies = new System.Windows.Forms.CheckBox();
            this.sinemax = new System.Windows.Forms.Label();
            this.sinemax_textbox = new System.Windows.Forms.TextBox();
            this.sinemin = new System.Windows.Forms.Label();
            this.sinemin_textbox = new System.Windows.Forms.TextBox();
            this.sineperiod = new System.Windows.Forms.Label();
            this.sineperiod_textbox = new System.Windows.Forms.TextBox();
            this.Sine = new System.Windows.Forms.CheckBox();
            this.timeoffset = new System.Windows.Forms.Label();
            this.timeoffset_textbox = new System.Windows.Forms.TextBox();
            this.resultVar = new System.Windows.Forms.Label();
            this.resultVar_textbox = new System.Windows.Forms.TextBox();
            this.numberoflastframe = new System.Windows.Forms.Label();
            this.numberoflastframe_textbox = new System.Windows.Forms.TextBox();
            this.TrueRNG = new System.Windows.Forms.CheckBox();
            this.phongexponenttexture_textbox = new System.Windows.Forms.TextBox();
            this.phongexponenttexture = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.Button();
            this.basetexture = new System.Windows.Forms.Label();
            this.animatedtexturevar_combobox = new System.Windows.Forms.ComboBox();
            this.animatedtextureframenumvar_combobox = new System.Windows.Forms.ComboBox();
            this.additive = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.preset_apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basetexture_textbox
            // 
            this.basetexture_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basetexture_textbox.Location = new System.Drawing.Point(168, 8);
            this.basetexture_textbox.Name = "basetexture_textbox";
            this.basetexture_textbox.Size = new System.Drawing.Size(488, 21);
            this.basetexture_textbox.TabIndex = 2;
            this.basetexture_textbox.Text = "ko/vrc/xxx/ccc/ppp_base";
            // 
            // bumpmap_textbox
            // 
            this.bumpmap_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bumpmap_textbox.Location = new System.Drawing.Point(168, 35);
            this.bumpmap_textbox.Name = "bumpmap_textbox";
            this.bumpmap_textbox.Size = new System.Drawing.Size(488, 21);
            this.bumpmap_textbox.TabIndex = 4;
            this.bumpmap_textbox.Text = "ko/vrc/xxx/ccc/ppp_normal";
            // 
            // bumpmap
            // 
            this.bumpmap.AutoSize = true;
            this.bumpmap.Location = new System.Drawing.Point(12, 40);
            this.bumpmap.Name = "bumpmap";
            this.bumpmap.Size = new System.Drawing.Size(72, 16);
            this.bumpmap.TabIndex = 3;
            this.bumpmap.Text = "$bumpmap";
            this.toolTip.SetToolTip(this.bumpmap, "法线贴图。没有用到就不要启用。");
            this.bumpmap.UseVisualStyleBackColor = true;
            // 
            // preset_combobox
            // 
            this.preset_combobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preset_combobox.FormattingEnabled = true;
            this.preset_combobox.Location = new System.Drawing.Point(662, 8);
            this.preset_combobox.Name = "preset_combobox";
            this.preset_combobox.Size = new System.Drawing.Size(158, 20);
            this.preset_combobox.TabIndex = 5;
            // 
            // preset_add
            // 
            this.preset_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preset_add.Location = new System.Drawing.Point(826, 7);
            this.preset_add.Name = "preset_add";
            this.preset_add.Size = new System.Drawing.Size(20, 20);
            this.preset_add.TabIndex = 6;
            this.preset_add.Text = "+";
            this.toolTip.SetToolTip(this.preset_add, "保存预设");
            this.preset_add.UseVisualStyleBackColor = true;
            this.preset_add.Click += new System.EventHandler(this.preset_add_Click);
            // 
            // preset_delete
            // 
            this.preset_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preset_delete.Location = new System.Drawing.Point(854, 7);
            this.preset_delete.Name = "preset_delete";
            this.preset_delete.Size = new System.Drawing.Size(20, 20);
            this.preset_delete.TabIndex = 7;
            this.preset_delete.Text = "-";
            this.toolTip.SetToolTip(this.preset_delete, "删除预设");
            this.preset_delete.UseVisualStyleBackColor = true;
            this.preset_delete.Click += new System.EventHandler(this.preset_delete_Click);
            // 
            // output_textBox
            // 
            this.output_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output_textBox.Location = new System.Drawing.Point(275, 121);
            this.output_textBox.Multiline = true;
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output_textBox.Size = new System.Drawing.Size(381, 312);
            this.output_textBox.TabIndex = 8;
            this.output_textBox.WordWrap = false;
            // 
            // lightwarptexture_textbox
            // 
            this.lightwarptexture_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightwarptexture_textbox.Location = new System.Drawing.Point(168, 89);
            this.lightwarptexture_textbox.Name = "lightwarptexture_textbox";
            this.lightwarptexture_textbox.Size = new System.Drawing.Size(488, 21);
            this.lightwarptexture_textbox.TabIndex = 10;
            this.lightwarptexture_textbox.Text = "ko/vrc/xxx/ccc/warp";
            // 
            // lightwarptexture
            // 
            this.lightwarptexture.AutoSize = true;
            this.lightwarptexture.Checked = true;
            this.lightwarptexture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightwarptexture.Location = new System.Drawing.Point(12, 94);
            this.lightwarptexture.Name = "lightwarptexture";
            this.lightwarptexture.Size = new System.Drawing.Size(126, 16);
            this.lightwarptexture.TabIndex = 9;
            this.lightwarptexture.TabStop = false;
            this.lightwarptexture.Text = "$lightwarptexture";
            this.toolTip.SetToolTip(this.lightwarptexture, "色彩校正。二次元必加。\r\n不推荐自制，一般会有格式问题导致效果异常。");
            this.lightwarptexture.UseVisualStyleBackColor = true;
            // 
            // nocull
            // 
            this.nocull.AutoSize = true;
            this.nocull.Checked = true;
            this.nocull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nocull.Location = new System.Drawing.Point(12, 121);
            this.nocull.Name = "nocull";
            this.nocull.Size = new System.Drawing.Size(66, 16);
            this.nocull.TabIndex = 11;
            this.nocull.TabStop = false;
            this.nocull.Text = "$nocull";
            this.toolTip.SetToolTip(this.nocull, "双面渲染。单面模型正反两处都暴露的话，一般都开。\r\n模型的边缝漏色严重可以关。");
            this.nocull.UseVisualStyleBackColor = true;
            // 
            // nodecal
            // 
            this.nodecal.AutoSize = true;
            this.nodecal.Checked = true;
            this.nodecal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nodecal.Location = new System.Drawing.Point(168, 122);
            this.nodecal.Name = "nodecal";
            this.nodecal.Size = new System.Drawing.Size(72, 16);
            this.nodecal.TabIndex = 13;
            this.nodecal.TabStop = false;
            this.nodecal.Text = "$nodecal";
            this.toolTip.SetToolTip(this.nodecal, "贴花阻止。关闭血迹。可以防止一些神秘闪退。");
            this.nodecal.UseVisualStyleBackColor = true;
            // 
            // phong
            // 
            this.phong.AutoSize = true;
            this.phong.Checked = true;
            this.phong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.phong.Location = new System.Drawing.Point(12, 148);
            this.phong.Name = "phong";
            this.phong.Size = new System.Drawing.Size(60, 16);
            this.phong.TabIndex = 15;
            this.phong.TabStop = false;
            this.phong.Text = "$phong";
            this.toolTip.SetToolTip(this.phong, "冯氏反射开关。半透明面和全息面可以关。");
            this.phong.UseVisualStyleBackColor = true;
            // 
            // halflambert
            // 
            this.halflambert.AutoSize = true;
            this.halflambert.Checked = true;
            this.halflambert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.halflambert.Location = new System.Drawing.Point(168, 149);
            this.halflambert.Name = "halflambert";
            this.halflambert.Size = new System.Drawing.Size(96, 16);
            this.halflambert.TabIndex = 17;
            this.halflambert.TabStop = false;
            this.halflambert.Text = "$halflambert";
            this.toolTip.SetToolTip(this.halflambert, "半兰伯特光照。让光照过渡更加自然，必开。");
            this.halflambert.UseVisualStyleBackColor = true;
            // 
            // phongboost_textbox
            // 
            this.phongboost_textbox.Location = new System.Drawing.Point(168, 170);
            this.phongboost_textbox.Name = "phongboost_textbox";
            this.phongboost_textbox.Size = new System.Drawing.Size(101, 21);
            this.phongboost_textbox.TabIndex = 20;
            this.phongboost_textbox.Text = ".04";
            // 
            // phongboost
            // 
            this.phongboost.AutoSize = true;
            this.phongboost.Checked = true;
            this.phongboost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.phongboost.Location = new System.Drawing.Point(12, 175);
            this.phongboost.Name = "phongboost";
            this.phongboost.Size = new System.Drawing.Size(90, 16);
            this.phongboost.TabIndex = 19;
            this.phongboost.TabStop = false;
            this.phongboost.Text = "$phongboost";
            this.toolTip.SetToolTip(this.phongboost, "冯氏反射亮度。亮度区分取决于法线贴图的A通道，越白则越亮。");
            this.phongboost.UseVisualStyleBackColor = true;
            // 
            // phongexponent_textbox
            // 
            this.phongexponent_textbox.Location = new System.Drawing.Point(168, 197);
            this.phongexponent_textbox.Name = "phongexponent_textbox";
            this.phongexponent_textbox.Size = new System.Drawing.Size(101, 21);
            this.phongexponent_textbox.TabIndex = 29;
            this.phongexponent_textbox.Text = "5.0";
            // 
            // envmap
            // 
            this.envmap.AutoSize = true;
            this.envmap.Location = new System.Drawing.Point(12, 254);
            this.envmap.Name = "envmap";
            this.envmap.Size = new System.Drawing.Size(66, 16);
            this.envmap.TabIndex = 27;
            this.envmap.TabStop = false;
            this.envmap.Text = "$envmap";
            this.toolTip.SetToolTip(this.envmap, "镜面反射。和冯氏反射不同，与所处地图位置而非与光源有关。不做金属不要开。");
            this.envmap.UseVisualStyleBackColor = true;
            // 
            // phongfresnelranges_textbox_0
            // 
            this.phongfresnelranges_textbox_0.Location = new System.Drawing.Point(168, 224);
            this.phongfresnelranges_textbox_0.Name = "phongfresnelranges_textbox_0";
            this.phongfresnelranges_textbox_0.Size = new System.Drawing.Size(30, 21);
            this.phongfresnelranges_textbox_0.TabIndex = 26;
            this.phongfresnelranges_textbox_0.Text = "1.0";
            this.toolTip.SetToolTip(this.phongfresnelranges_textbox_0, "当视线正对平行于曲面法线时曲面的反射率。");
            // 
            // phongfresnelranges
            // 
            this.phongfresnelranges.AutoSize = true;
            this.phongfresnelranges.Checked = true;
            this.phongfresnelranges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.phongfresnelranges.Location = new System.Drawing.Point(12, 227);
            this.phongfresnelranges.Name = "phongfresnelranges";
            this.phongfresnelranges.Size = new System.Drawing.Size(138, 16);
            this.phongfresnelranges.TabIndex = 25;
            this.phongfresnelranges.TabStop = false;
            this.phongfresnelranges.Text = "$phongfresnelranges";
            this.toolTip.SetToolTip(this.phongfresnelranges, "冯氏反射菲涅尔参数。不要乱调。\r\nX表示当视线正对平行于曲面法线时曲面的反射率。\r\nY表示当视线介于正对平行于和垂直于曲面法线之间时曲面的反射率。\r\nZ表示当视线" +
        "垂直于曲面法线时曲面的反射率。");
            this.phongfresnelranges.UseVisualStyleBackColor = true;
            // 
            // phongexponent
            // 
            this.phongexponent.AutoSize = true;
            this.phongexponent.Location = new System.Drawing.Point(12, 202);
            this.phongexponent.Name = "phongexponent";
            this.phongexponent.Size = new System.Drawing.Size(108, 16);
            this.phongexponent.TabIndex = 24;
            this.phongexponent.TabStop = false;
            this.phongexponent.Text = "$phongexponent";
            this.toolTip.SetToolTip(this.phongexponent, "冯氏反射密度。启用后将覆盖 $phongexponenttexture。默认即5.0。一般不做修改。");
            this.phongexponent.UseVisualStyleBackColor = true;
            // 
            // phongfresnelranges_textbox_1
            // 
            this.phongfresnelranges_textbox_1.Location = new System.Drawing.Point(204, 224);
            this.phongfresnelranges_textbox_1.Name = "phongfresnelranges_textbox_1";
            this.phongfresnelranges_textbox_1.Size = new System.Drawing.Size(30, 21);
            this.phongfresnelranges_textbox_1.TabIndex = 30;
            this.phongfresnelranges_textbox_1.Text = ".10";
            this.toolTip.SetToolTip(this.phongfresnelranges_textbox_1, "当视线介于正对平行于和垂直于曲面法线之间时曲面的反射率。");
            // 
            // phongfresnelranges_textbox_2
            // 
            this.phongfresnelranges_textbox_2.Location = new System.Drawing.Point(240, 224);
            this.phongfresnelranges_textbox_2.Name = "phongfresnelranges_textbox_2";
            this.phongfresnelranges_textbox_2.Size = new System.Drawing.Size(29, 21);
            this.phongfresnelranges_textbox_2.TabIndex = 31;
            this.phongfresnelranges_textbox_2.Text = ".10";
            this.toolTip.SetToolTip(this.phongfresnelranges_textbox_2, "当视线垂直于曲面法线时曲面的反射率。");
            // 
            // envmapfresnel
            // 
            this.envmapfresnel.AutoSize = true;
            this.envmapfresnel.Checked = true;
            this.envmapfresnel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.envmapfresnel.Location = new System.Drawing.Point(12, 335);
            this.envmapfresnel.Name = "envmapfresnel";
            this.envmapfresnel.Size = new System.Drawing.Size(108, 16);
            this.envmapfresnel.TabIndex = 32;
            this.envmapfresnel.TabStop = false;
            this.envmapfresnel.Text = "$envmapfresnel";
            this.toolTip.SetToolTip(this.envmapfresnel, "启用镜面反射菲涅尔效果。不要乱调。\r\n该值将与冯氏反射菲涅尔参数做乘法。");
            this.envmapfresnel.UseVisualStyleBackColor = true;
            // 
            // normalmapalphaenvmapmask
            // 
            this.normalmapalphaenvmapmask.AutoSize = true;
            this.normalmapalphaenvmapmask.Checked = true;
            this.normalmapalphaenvmapmask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalmapalphaenvmapmask.Location = new System.Drawing.Point(12, 281);
            this.normalmapalphaenvmapmask.Name = "normalmapalphaenvmapmask";
            this.normalmapalphaenvmapmask.Size = new System.Drawing.Size(174, 16);
            this.normalmapalphaenvmapmask.TabIndex = 34;
            this.normalmapalphaenvmapmask.TabStop = false;
            this.normalmapalphaenvmapmask.Text = "$normalmapalphaenvmapmask";
            this.toolTip.SetToolTip(this.normalmapalphaenvmapmask, "将法线贴图 A 通道作为镜面反射蒙版。\r\n镜面反射效果区分将取决于法线贴图的A通道，越白越显著。保持启用。");
            this.normalmapalphaenvmapmask.UseVisualStyleBackColor = true;
            // 
            // envmapfresnel_textbox
            // 
            this.envmapfresnel_textbox.Location = new System.Drawing.Point(168, 330);
            this.envmapfresnel_textbox.Name = "envmapfresnel_textbox";
            this.envmapfresnel_textbox.Size = new System.Drawing.Size(101, 21);
            this.envmapfresnel_textbox.TabIndex = 33;
            this.envmapfresnel_textbox.Text = "1.0";
            // 
            // envmaptint_textbox_2
            // 
            this.envmaptint_textbox_2.Location = new System.Drawing.Point(240, 303);
            this.envmaptint_textbox_2.Name = "envmaptint_textbox_2";
            this.envmaptint_textbox_2.Size = new System.Drawing.Size(29, 21);
            this.envmaptint_textbox_2.TabIndex = 39;
            this.envmaptint_textbox_2.Text = ".16";
            // 
            // envmaptint_textbox_1
            // 
            this.envmaptint_textbox_1.Location = new System.Drawing.Point(204, 303);
            this.envmaptint_textbox_1.Name = "envmaptint_textbox_1";
            this.envmaptint_textbox_1.Size = new System.Drawing.Size(30, 21);
            this.envmaptint_textbox_1.TabIndex = 38;
            this.envmaptint_textbox_1.Text = ".16";
            // 
            // envmaptint_textbox_0
            // 
            this.envmaptint_textbox_0.Location = new System.Drawing.Point(168, 303);
            this.envmaptint_textbox_0.Name = "envmaptint_textbox_0";
            this.envmaptint_textbox_0.Size = new System.Drawing.Size(30, 21);
            this.envmaptint_textbox_0.TabIndex = 37;
            this.envmaptint_textbox_0.Text = ".16";
            // 
            // envmaptint
            // 
            this.envmaptint.AutoSize = true;
            this.envmaptint.Checked = true;
            this.envmaptint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.envmaptint.Location = new System.Drawing.Point(12, 308);
            this.envmaptint.Name = "envmaptint";
            this.envmaptint.Size = new System.Drawing.Size(90, 16);
            this.envmaptint.TabIndex = 36;
            this.envmaptint.TabStop = false;
            this.envmaptint.Text = "$envmaptint";
            this.toolTip.SetToolTip(this.envmaptint, "镜面反射通道强度。整体越大，镜面反射越明显。\r\n不单为比例关系，可以调色。");
            this.envmaptint.UseVisualStyleBackColor = true;
            // 
            // selfillum
            // 
            this.selfillum.AutoSize = true;
            this.selfillum.Checked = true;
            this.selfillum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selfillum.Location = new System.Drawing.Point(12, 362);
            this.selfillum.Name = "selfillum";
            this.selfillum.Size = new System.Drawing.Size(84, 16);
            this.selfillum.TabIndex = 47;
            this.selfillum.TabStop = false;
            this.selfillum.Text = "$selfillum";
            this.toolTip.SetToolTip(this.selfillum, "开启自发光。不做自发光必须关掉。\r\n亮度区分取决于颜色贴图的 A 通道，越白则越亮。");
            this.selfillum.UseVisualStyleBackColor = true;
            // 
            // translucent
            // 
            this.translucent.AutoSize = true;
            this.translucent.Location = new System.Drawing.Point(168, 362);
            this.translucent.Name = "translucent";
            this.translucent.Size = new System.Drawing.Size(96, 16);
            this.translucent.TabIndex = 49;
            this.translucent.TabStop = false;
            this.translucent.Text = "$translucent";
            this.toolTip.SetToolTip(this.translucent, "开启半透明。和自发光冲突。\r\n透明程度区分取决于颜色贴图的 A 通道，越白则越不透明。");
            this.translucent.UseVisualStyleBackColor = true;
            // 
            // alpha_textbox
            // 
            this.alpha_textbox.Location = new System.Drawing.Point(168, 410);
            this.alpha_textbox.Name = "alpha_textbox";
            this.alpha_textbox.Size = new System.Drawing.Size(101, 21);
            this.alpha_textbox.TabIndex = 52;
            this.alpha_textbox.Text = "1.0";
            // 
            // alpha
            // 
            this.alpha.AutoSize = true;
            this.alpha.Location = new System.Drawing.Point(12, 416);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(60, 16);
            this.alpha.TabIndex = 51;
            this.alpha.TabStop = false;
            this.alpha.Text = "$alpha";
            this.toolTip.SetToolTip(this.alpha, "透明度缩放。该透明效果不会影响阴影效果。");
            this.alpha.UseVisualStyleBackColor = true;
            // 
            // AnimatedTexture
            // 
            this.AnimatedTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimatedTexture.AutoSize = true;
            this.AnimatedTexture.Location = new System.Drawing.Point(662, 121);
            this.AnimatedTexture.Name = "AnimatedTexture";
            this.AnimatedTexture.Size = new System.Drawing.Size(114, 16);
            this.AnimatedTexture.TabIndex = 53;
            this.AnimatedTexture.TabStop = false;
            this.AnimatedTexture.Text = "AnimatedTexture";
            this.toolTip.SetToolTip(this.AnimatedTexture, "使用多帧贴图动画");
            this.AnimatedTexture.UseVisualStyleBackColor = true;
            // 
            // animatedtexturevar
            // 
            this.animatedtexturevar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animatedtexturevar.AutoSize = true;
            this.animatedtexturevar.Location = new System.Drawing.Point(660, 149);
            this.animatedtexturevar.Name = "animatedtexturevar";
            this.animatedtexturevar.Size = new System.Drawing.Size(113, 12);
            this.animatedtexturevar.TabIndex = 57;
            this.animatedtexturevar.Text = "animatedtexturevar";
            this.toolTip.SetToolTip(this.animatedtexturevar, "帧数范围参考");
            // 
            // animatedtextureframenumvar
            // 
            this.animatedtextureframenumvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animatedtextureframenumvar.AutoSize = true;
            this.animatedtextureframenumvar.Location = new System.Drawing.Point(660, 176);
            this.animatedtextureframenumvar.Name = "animatedtextureframenumvar";
            this.animatedtextureframenumvar.Size = new System.Drawing.Size(161, 12);
            this.animatedtextureframenumvar.TabIndex = 59;
            this.animatedtextureframenumvar.Text = "animatedtextureframenumvar";
            this.toolTip.SetToolTip(this.animatedtextureframenumvar, "帧数作用变量");
            // 
            // animatedtextureframerate
            // 
            this.animatedtextureframerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animatedtextureframerate.AutoSize = true;
            this.animatedtextureframerate.Location = new System.Drawing.Point(660, 203);
            this.animatedtextureframerate.Name = "animatedtextureframerate";
            this.animatedtextureframerate.Size = new System.Drawing.Size(149, 12);
            this.animatedtextureframerate.TabIndex = 61;
            this.animatedtextureframerate.Text = "animatedtextureframerate";
            this.toolTip.SetToolTip(this.animatedtextureframerate, "每秒播放帧数");
            // 
            // animatedtextureframerate_textbox
            // 
            this.animatedtextureframerate_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animatedtextureframerate_textbox.Location = new System.Drawing.Point(826, 197);
            this.animatedtextureframerate_textbox.Name = "animatedtextureframerate_textbox";
            this.animatedtextureframerate_textbox.Size = new System.Drawing.Size(48, 21);
            this.animatedtextureframerate_textbox.TabIndex = 60;
            this.animatedtextureframerate_textbox.Text = "30.0";
            // 
            // proxies
            // 
            this.proxies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxies.AutoSize = true;
            this.proxies.Location = new System.Drawing.Point(662, 94);
            this.proxies.Name = "proxies";
            this.proxies.Size = new System.Drawing.Size(66, 16);
            this.proxies.TabIndex = 62;
            this.proxies.TabStop = false;
            this.proxies.Text = "proxies";
            this.toolTip.SetToolTip(this.proxies, "开启材质代理");
            this.proxies.UseVisualStyleBackColor = true;
            // 
            // sinemax
            // 
            this.sinemax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sinemax.AutoSize = true;
            this.sinemax.Location = new System.Drawing.Point(660, 363);
            this.sinemax.Name = "sinemax";
            this.sinemax.Size = new System.Drawing.Size(47, 12);
            this.sinemax.TabIndex = 69;
            this.sinemax.Text = "sinemax";
            this.toolTip.SetToolTip(this.sinemax, "最大值");
            // 
            // sinemax_textbox
            // 
            this.sinemax_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sinemax_textbox.Location = new System.Drawing.Point(826, 357);
            this.sinemax_textbox.Name = "sinemax_textbox";
            this.sinemax_textbox.Size = new System.Drawing.Size(48, 21);
            this.sinemax_textbox.TabIndex = 68;
            this.sinemax_textbox.Text = "5.0";
            // 
            // sinemin
            // 
            this.sinemin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sinemin.AutoSize = true;
            this.sinemin.Location = new System.Drawing.Point(660, 336);
            this.sinemin.Name = "sinemin";
            this.sinemin.Size = new System.Drawing.Size(47, 12);
            this.sinemin.TabIndex = 67;
            this.sinemin.Text = "sinemin";
            this.toolTip.SetToolTip(this.sinemin, "最小值");
            // 
            // sinemin_textbox
            // 
            this.sinemin_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sinemin_textbox.Location = new System.Drawing.Point(826, 330);
            this.sinemin_textbox.Name = "sinemin_textbox";
            this.sinemin_textbox.Size = new System.Drawing.Size(48, 21);
            this.sinemin_textbox.TabIndex = 66;
            this.sinemin_textbox.Text = "0.0";
            // 
            // sineperiod
            // 
            this.sineperiod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sineperiod.AutoSize = true;
            this.sineperiod.Location = new System.Drawing.Point(660, 309);
            this.sineperiod.Name = "sineperiod";
            this.sineperiod.Size = new System.Drawing.Size(65, 12);
            this.sineperiod.TabIndex = 65;
            this.sineperiod.Text = "sineperiod";
            this.toolTip.SetToolTip(this.sineperiod, "周期");
            // 
            // sineperiod_textbox
            // 
            this.sineperiod_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sineperiod_textbox.Location = new System.Drawing.Point(826, 303);
            this.sineperiod_textbox.Name = "sineperiod_textbox";
            this.sineperiod_textbox.Size = new System.Drawing.Size(48, 21);
            this.sineperiod_textbox.TabIndex = 64;
            this.sineperiod_textbox.Text = "10.0";
            // 
            // Sine
            // 
            this.Sine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sine.AutoSize = true;
            this.Sine.Location = new System.Drawing.Point(662, 281);
            this.Sine.Name = "Sine";
            this.Sine.Size = new System.Drawing.Size(48, 16);
            this.Sine.TabIndex = 63;
            this.Sine.TabStop = false;
            this.Sine.Text = "Sine";
            this.toolTip.SetToolTip(this.Sine, "使用正弦波函数");
            this.Sine.UseVisualStyleBackColor = true;
            // 
            // timeoffset
            // 
            this.timeoffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeoffset.AutoSize = true;
            this.timeoffset.Location = new System.Drawing.Point(660, 390);
            this.timeoffset.Name = "timeoffset";
            this.timeoffset.Size = new System.Drawing.Size(65, 12);
            this.timeoffset.TabIndex = 71;
            this.timeoffset.Text = "timeoffset";
            this.toolTip.SetToolTip(this.timeoffset, "偏移周期");
            // 
            // timeoffset_textbox
            // 
            this.timeoffset_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeoffset_textbox.Location = new System.Drawing.Point(826, 384);
            this.timeoffset_textbox.Name = "timeoffset_textbox";
            this.timeoffset_textbox.Size = new System.Drawing.Size(48, 21);
            this.timeoffset_textbox.TabIndex = 70;
            this.timeoffset_textbox.Text = "2.5";
            // 
            // resultVar
            // 
            this.resultVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultVar.AutoSize = true;
            this.resultVar.Location = new System.Drawing.Point(660, 416);
            this.resultVar.Name = "resultVar";
            this.resultVar.Size = new System.Drawing.Size(59, 12);
            this.resultVar.TabIndex = 73;
            this.resultVar.Text = "resultVar";
            this.toolTip.SetToolTip(this.resultVar, "结果变量");
            // 
            // resultVar_textbox
            // 
            this.resultVar_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultVar_textbox.Location = new System.Drawing.Point(826, 411);
            this.resultVar_textbox.Name = "resultVar_textbox";
            this.resultVar_textbox.Size = new System.Drawing.Size(48, 21);
            this.resultVar_textbox.TabIndex = 72;
            this.resultVar_textbox.Text = "$alpha";
            // 
            // numberoflastframe
            // 
            this.numberoflastframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberoflastframe.AutoSize = true;
            this.numberoflastframe.Location = new System.Drawing.Point(660, 255);
            this.numberoflastframe.Name = "numberoflastframe";
            this.numberoflastframe.Size = new System.Drawing.Size(113, 12);
            this.numberoflastframe.TabIndex = 76;
            this.numberoflastframe.Text = "$numberoflastframe";
            this.toolTip.SetToolTip(this.numberoflastframe, "颜色贴图最后帧编号");
            // 
            // numberoflastframe_textbox
            // 
            this.numberoflastframe_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberoflastframe_textbox.Location = new System.Drawing.Point(826, 249);
            this.numberoflastframe_textbox.Name = "numberoflastframe_textbox";
            this.numberoflastframe_textbox.Size = new System.Drawing.Size(48, 21);
            this.numberoflastframe_textbox.TabIndex = 75;
            this.numberoflastframe_textbox.Text = "1";
            this.toolTip.SetToolTip(this.numberoflastframe_textbox, "必须是 >=1 的整数");
            // 
            // TrueRNG
            // 
            this.TrueRNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrueRNG.AutoSize = true;
            this.TrueRNG.Location = new System.Drawing.Point(662, 227);
            this.TrueRNG.Name = "TrueRNG";
            this.TrueRNG.Size = new System.Drawing.Size(156, 16);
            this.TrueRNG.TabIndex = 74;
            this.TrueRNG.TabStop = false;
            this.TrueRNG.Text = "Linear Ramp : True RNG";
            this.toolTip.SetToolTip(this.TrueRNG, "使用 True RNG");
            this.TrueRNG.UseVisualStyleBackColor = true;
            // 
            // phongexponenttexture_textbox
            // 
            this.phongexponenttexture_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phongexponenttexture_textbox.Location = new System.Drawing.Point(168, 62);
            this.phongexponenttexture_textbox.Name = "phongexponenttexture_textbox";
            this.phongexponenttexture_textbox.Size = new System.Drawing.Size(488, 21);
            this.phongexponenttexture_textbox.TabIndex = 78;
            this.phongexponenttexture_textbox.Text = "ko/vrc/xxx/ccc/ppp_exp";
            // 
            // phongexponenttexture
            // 
            this.phongexponenttexture.AutoSize = true;
            this.phongexponenttexture.Location = new System.Drawing.Point(12, 67);
            this.phongexponenttexture.Name = "phongexponenttexture";
            this.phongexponenttexture.Size = new System.Drawing.Size(150, 16);
            this.phongexponenttexture.TabIndex = 77;
            this.phongexponenttexture.TabStop = false;
            this.phongexponenttexture.Text = "$phongexponenttexture";
            this.toolTip.SetToolTip(this.phongexponenttexture, "冯氏密度贴图 / 高光贴图。一般不启用。");
            this.phongexponenttexture.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(799, 90);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(75, 23);
            this.output.TabIndex = 79;
            this.output.Text = "output";
            this.toolTip.SetToolTip(this.output, "输出 VMT 文本");
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // basetexture
            // 
            this.basetexture.AutoSize = true;
            this.basetexture.Location = new System.Drawing.Point(12, 15);
            this.basetexture.Name = "basetexture";
            this.basetexture.Size = new System.Drawing.Size(77, 12);
            this.basetexture.TabIndex = 80;
            this.basetexture.Text = "$basetexture";
            this.toolTip.SetToolTip(this.basetexture, "颜色贴图。路径错误会导致紫黑。");
            // 
            // animatedtexturevar_combobox
            // 
            this.animatedtexturevar_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animatedtexturevar_combobox.FormattingEnabled = true;
            this.animatedtexturevar_combobox.Items.AddRange(new object[] {
            "$basetexture",
            "$bumpmap"});
            this.animatedtexturevar_combobox.Location = new System.Drawing.Point(779, 144);
            this.animatedtexturevar_combobox.Name = "animatedtexturevar_combobox";
            this.animatedtexturevar_combobox.Size = new System.Drawing.Size(95, 20);
            this.animatedtexturevar_combobox.TabIndex = 81;
            // 
            // animatedtextureframenumvar_combobox
            // 
            this.animatedtextureframenumvar_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animatedtextureframenumvar_combobox.FormattingEnabled = true;
            this.animatedtextureframenumvar_combobox.Items.AddRange(new object[] {
            "$frame",
            "$bumpframe"});
            this.animatedtextureframenumvar_combobox.Location = new System.Drawing.Point(826, 171);
            this.animatedtextureframenumvar_combobox.Name = "animatedtextureframenumvar_combobox";
            this.animatedtextureframenumvar_combobox.Size = new System.Drawing.Size(48, 20);
            this.animatedtextureframenumvar_combobox.TabIndex = 82;
            // 
            // additive
            // 
            this.additive.AutoSize = true;
            this.additive.Location = new System.Drawing.Point(12, 389);
            this.additive.Name = "additive";
            this.additive.Size = new System.Drawing.Size(78, 16);
            this.additive.TabIndex = 83;
            this.additive.TabStop = false;
            this.additive.Text = "$additive";
            this.toolTip.SetToolTip(this.additive, "开启颜色叠加，具有半透明效果，透明程度区分近似取决于颜色贴图的 RGB 通道（灰度），\r\n黑色为完全透明，白色也会透明，实际效果基本同于线性减淡（添加）。");
            this.additive.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // preset_apply
            // 
            this.preset_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preset_apply.Location = new System.Drawing.Point(826, 36);
            this.preset_apply.Name = "preset_apply";
            this.preset_apply.Size = new System.Drawing.Size(48, 23);
            this.preset_apply.TabIndex = 84;
            this.preset_apply.Text = "apply";
            this.toolTip.SetToolTip(this.preset_apply, "应用预设");
            this.preset_apply.UseVisualStyleBackColor = true;
            this.preset_apply.Click += new System.EventHandler(this.preset_apply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.preset_apply);
            this.Controls.Add(this.additive);
            this.Controls.Add(this.animatedtextureframenumvar_combobox);
            this.Controls.Add(this.animatedtexturevar_combobox);
            this.Controls.Add(this.basetexture);
            this.Controls.Add(this.output);
            this.Controls.Add(this.phongexponenttexture_textbox);
            this.Controls.Add(this.phongexponenttexture);
            this.Controls.Add(this.numberoflastframe);
            this.Controls.Add(this.numberoflastframe_textbox);
            this.Controls.Add(this.TrueRNG);
            this.Controls.Add(this.resultVar);
            this.Controls.Add(this.resultVar_textbox);
            this.Controls.Add(this.timeoffset);
            this.Controls.Add(this.timeoffset_textbox);
            this.Controls.Add(this.sinemax);
            this.Controls.Add(this.sinemax_textbox);
            this.Controls.Add(this.sinemin);
            this.Controls.Add(this.sinemin_textbox);
            this.Controls.Add(this.sineperiod);
            this.Controls.Add(this.sineperiod_textbox);
            this.Controls.Add(this.Sine);
            this.Controls.Add(this.proxies);
            this.Controls.Add(this.animatedtextureframerate);
            this.Controls.Add(this.animatedtextureframerate_textbox);
            this.Controls.Add(this.animatedtextureframenumvar);
            this.Controls.Add(this.animatedtexturevar);
            this.Controls.Add(this.AnimatedTexture);
            this.Controls.Add(this.alpha_textbox);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.translucent);
            this.Controls.Add(this.selfillum);
            this.Controls.Add(this.envmaptint_textbox_2);
            this.Controls.Add(this.envmaptint_textbox_1);
            this.Controls.Add(this.envmaptint_textbox_0);
            this.Controls.Add(this.envmaptint);
            this.Controls.Add(this.normalmapalphaenvmapmask);
            this.Controls.Add(this.envmapfresnel_textbox);
            this.Controls.Add(this.envmapfresnel);
            this.Controls.Add(this.phongfresnelranges_textbox_2);
            this.Controls.Add(this.phongfresnelranges_textbox_1);
            this.Controls.Add(this.phongexponent_textbox);
            this.Controls.Add(this.envmap);
            this.Controls.Add(this.phongfresnelranges_textbox_0);
            this.Controls.Add(this.phongfresnelranges);
            this.Controls.Add(this.phongexponent);
            this.Controls.Add(this.phongboost_textbox);
            this.Controls.Add(this.phongboost);
            this.Controls.Add(this.halflambert);
            this.Controls.Add(this.phong);
            this.Controls.Add(this.nodecal);
            this.Controls.Add(this.nocull);
            this.Controls.Add(this.lightwarptexture_textbox);
            this.Controls.Add(this.lightwarptexture);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.preset_delete);
            this.Controls.Add(this.preset_add);
            this.Controls.Add(this.preset_combobox);
            this.Controls.Add(this.bumpmap_textbox);
            this.Controls.Add(this.bumpmap);
            this.Controls.Add(this.basetexture_textbox);
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "Form1";
            this.Text = "SurvivorVMT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox basetexture_textbox;
        private System.Windows.Forms.TextBox bumpmap_textbox;
        private System.Windows.Forms.CheckBox bumpmap;
        private System.Windows.Forms.ComboBox preset_combobox;
        private System.Windows.Forms.Button preset_add;
        private System.Windows.Forms.Button preset_delete;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.TextBox lightwarptexture_textbox;
        private System.Windows.Forms.CheckBox lightwarptexture;
        private System.Windows.Forms.CheckBox nocull;
        private System.Windows.Forms.CheckBox nodecal;
        private System.Windows.Forms.CheckBox phong;
        private System.Windows.Forms.CheckBox halflambert;
        private System.Windows.Forms.TextBox phongboost_textbox;
        private System.Windows.Forms.CheckBox phongboost;
        private System.Windows.Forms.TextBox phongexponent_textbox;
        private System.Windows.Forms.CheckBox envmap;
        private System.Windows.Forms.TextBox phongfresnelranges_textbox_0;
        private System.Windows.Forms.CheckBox phongfresnelranges;
        private System.Windows.Forms.CheckBox phongexponent;
        private System.Windows.Forms.TextBox phongfresnelranges_textbox_1;
        private System.Windows.Forms.TextBox phongfresnelranges_textbox_2;
        private System.Windows.Forms.CheckBox envmapfresnel;
        private System.Windows.Forms.CheckBox normalmapalphaenvmapmask;
        private System.Windows.Forms.TextBox envmapfresnel_textbox;
        private System.Windows.Forms.TextBox envmaptint_textbox_2;
        private System.Windows.Forms.TextBox envmaptint_textbox_1;
        private System.Windows.Forms.TextBox envmaptint_textbox_0;
        private System.Windows.Forms.CheckBox envmaptint;
        private System.Windows.Forms.CheckBox selfillum;
        private System.Windows.Forms.CheckBox translucent;
        private System.Windows.Forms.TextBox alpha_textbox;
        private System.Windows.Forms.CheckBox alpha;
        private System.Windows.Forms.CheckBox AnimatedTexture;
        private System.Windows.Forms.Label animatedtexturevar;
        private System.Windows.Forms.Label animatedtextureframenumvar;
        private System.Windows.Forms.Label animatedtextureframerate;
        private System.Windows.Forms.TextBox animatedtextureframerate_textbox;
        private System.Windows.Forms.CheckBox proxies;
        private System.Windows.Forms.Label sinemax;
        private System.Windows.Forms.TextBox sinemax_textbox;
        private System.Windows.Forms.Label sinemin;
        private System.Windows.Forms.TextBox sinemin_textbox;
        private System.Windows.Forms.Label sineperiod;
        private System.Windows.Forms.TextBox sineperiod_textbox;
        private System.Windows.Forms.CheckBox Sine;
        private System.Windows.Forms.Label timeoffset;
        private System.Windows.Forms.TextBox timeoffset_textbox;
        private System.Windows.Forms.Label resultVar;
        private System.Windows.Forms.TextBox resultVar_textbox;
        private System.Windows.Forms.Label numberoflastframe;
        private System.Windows.Forms.TextBox numberoflastframe_textbox;
        private System.Windows.Forms.CheckBox TrueRNG;
        private System.Windows.Forms.TextBox phongexponenttexture_textbox;
        private System.Windows.Forms.CheckBox phongexponenttexture;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Label basetexture;
        private System.Windows.Forms.ComboBox animatedtexturevar_combobox;
        private System.Windows.Forms.ComboBox animatedtextureframenumvar_combobox;
        private System.Windows.Forms.CheckBox additive;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button preset_apply;
    }
}

